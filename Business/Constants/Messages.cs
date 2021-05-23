using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInValid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime ="Sistem bakımda.";
        public static string ProductListed ="Ürünler listelendi.";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameOfAlreadyExists="Aynı isimli ürün eklenemez.";
        public static string CategoryLimitExceded="Kayegori sayısı max. olduğu için ürün eklenemez.";
    }
}
