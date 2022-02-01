using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakimda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Eklenen category sayisi fazla";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir  ürün var";
        public static string CheckIfCategoryLimitedExceded = "Kategoru sayi 15 den fazla";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string UserNotFound = "Kulanıcı bulunamadı";
        public static string PasswordError = "Şifre yanlış";
        public static string SuccessfulLogin = "Login başarılı";
        public static string UserAlreadyExists = "Başka kullanıcı tarafından kullanılmaktadır";
        public static string AccessTokenCreated = "Token yaratıldı";
        public static string Updated = "Güncellendi";
        public static string CategoryLimitExceded = "Kategori limiti asildigi icin yeni urun eklenemiyor";
    }
}
