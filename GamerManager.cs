using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService; //bu constracter ile doğrulama işlemimizi gamer içine çekmiş olduk ve daha güvenli oldu.

        public GamerManager(IUserValidationService userValidationService) //üsteki _userVal.. değişkeninin üzerine gelip ampul simgesi ile
                                                                          //constracterı buraya işlemiş olduk böylece bu gamer a kullanıcı
                                                                          //eklemeyi doğrulama işlemine şartlı olduğunu belirtmiş olduk.
                                                                          //Tabii bu doğrulama şuan fake gerçekten bi api kullanmıyoruz.
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true) //_userVal... bizim doprulama işleminin GamerManager içindeki yapının temsili adı
                                                                //bu yapının doğrulama fonk. dan gelen (Validate) değer doğru ise ekle.
            {
                Console.WriteLine("Kullanıcı eklendi: " + gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız!");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı silindi: " + gamer.FirstName); 
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı güncellendi: " + gamer.FirstName);
        }
    }
}
