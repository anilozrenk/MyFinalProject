using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürün listelendi";
        public static string ProductCountOfCategoryError="Categori limiti aşıldı";
        public static string ProductNameAlreadyExist="aynı isimde birden fazla ürün bulunamaz";
        public static string CategoryLimitExceded="categori limiti aşıldı";
        public static string AuthorizationDenied="yetkiniz yok";
        public static string UserRegistered= "UserRegistered";
        public static string UserNotFound= "UserNotFound";
        public static string PasswordError= "PasswordError";
        public static string SuccessfulLogin= "SuccessfulLogin";
        public static string UserAlreadyExists = "UserAlreadyExists";
        public static string AccessTokenCreated = "AccessTokenCreated";
    }
}
