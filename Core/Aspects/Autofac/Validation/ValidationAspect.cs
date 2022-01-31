using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;
using Core.CrossCuttingConcers.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;

namespace Core.Aspects.Autofac.Validation
{
    //Autofac i kullanarak yaptığımız aspect sınıfı
    public class ValidationAspect : MethodInterception//Aspect =>metod hata verdiğinde başında sonunda yada ortasında çalışacak yapı
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)//validator type ver
        {
            //attitirubute ler type ile çalışır
            //defensive coding
            //validatör den farklı type de yapabilir.Bunun önüne geçmek için yaptık
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil");
            }
            //AspectMessages.WrongValidationType
            _validatorType = validatorType;
        }
        //Doğrulama başta yapılır o yüzden onbefore şekilde yaptık
        protected override void OnBefore(IInvocation invocation)
        {
            //ProductValidator ü newledi.Referansını kullanabilcez
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}