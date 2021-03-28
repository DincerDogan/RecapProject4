using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string ProductAdded = "Urun eklendi.";
        public static string InvalidProductName = "Urun ismi en az 2 karakter olmalidir.";
        public static string ProductListAdded = "Urunler eklendi.";

        public static string CarAdded = "Araba ekleme işlemi başarıyla gerçekleşti.";
        public static string CarDeleted = "Araba silme işlemi başarıyla gerçekleşti.";
        public static string CarUpdated = "Araba güncelleme işlemi başarıyla gerçekleşti.";
        public static string CarDailyPriceInvalid = "Hata! Günlük fiyat 0'dan büyük olmalıdır.";
        public static string CarDescriptionInvalid = "Hata! Açıklama en az iki karakter olmalıdır.";

        public static string ColorAdded = "Renk ekleme işlemi başarıyla gerçekleşti.";
        public static string ColorDeleted = "Renk silme işlemi başarıyla gerçekleşti.";
        public static string ColorUpdated = "Renk güncelleme işlemi başarıyla gerçekleşti.";

        public static string BrandAdded = "Marka ekleme işlemi başarıyla gerçekleşti.";
        public static string BrandDeleted = "Marka silme işlemi başarıyla gerçekleşti.";
        public static string BrandUpdated = "Marka güncelleme işlemi başarıyla gerçekleşti.";
        public static string BrandNameInvalid = "Hata! Marka ismi em az iki karakter olmalıdır.";

        public static string UserAdded = "Kullanıcı ekleme işlemi başarıyla gerçekleşti.";
        public static string UserDeleted = "Kullanıcı silme işlemi başarıyla gerçekleşti.";
        public static string UserUpdated = "Kullanıcı güncelleme işlemi başarıyla gerçekleşti.";

        public static string CustomerAdded = "Müşteri ekleme işlemi başarıyla gerçekleşti.";
        public static string CustomerDeleted = "Müşteri silme işlemi başarıyla gerçekleşti.";
        public static string CustomerUpdated = "Müşteri güncelleme işlemi başarıyla gerçekleşti.";

        public static string RentalAdded = "Araba kiralama işlemi başarıyla gerçekleşti.";
        public static string RentalDeleted = "Araba kiralama işlemi başarıyla silindi.";
        public static string RentalUpdated = "Kiralama işlemi başarıyla güncellendi.";
        public static string RentalReturnDateIsNull = "Araba henüz teslim edilmemiştir, kiralanamaz.";

        public static string InvalidRequest = "Lütfen bilgileri kontrol edip, tekrar deneyin";
        public static string MaintenanceTime = "Sistem şu anda bakımdadır.";


        public static string Added = "Add process OK";
        public static string Deleted = "Delete process OK";
        public static string Updated = "Update process OK";
        public static string Listed = "List process OK";
       
        public static string FailedRental = "The car has not yet been delivered";
        public static string CarImageLimitExceeded = "More than 5 images cannot be added";
        public static string NoCarImages = "The car does NOT have any images";

        public static string AuthorizationDenied = "Bu işlemi yapmak için yetkiniz bulunmamaktadır.";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu.";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut.";
        public static string SuccessfulLogin = "Sisteme giriş başarılı.";
        public static string PasswordError = "Şifre hatalıdır.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";

        public static string UserRegistered { get; internal set; }
    }
}
