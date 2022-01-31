using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcers.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity) //entity,dto ekleyebiliriz.o yüzden object tanımladık,herşeyin base i çünkü
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context); //ProductValidator kullnarak doğrulama yapacak
            if (!result.IsValid) // geçerli değilse hata fırlat
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}