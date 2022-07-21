using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //sürekli new'lemeyeyim diye static yazdım
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductsNameInValid = "Ürünler İsmi Boş Geçilemez!";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde Ürün  zaten var";
        public static string CategoryLimitExceded= "Kategori Limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
