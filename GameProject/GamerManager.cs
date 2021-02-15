using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService
    //Bir manager sınıfının içinde başka bir manager sınıfını kullanmak istiyorsak onu new'leme
    class GamerManager : IGamerService //IUserValidationService'i virgül ile ayırarak buraya ekleyebilirdik ama daha iyi olan aşağıdaki şekilde yaptık
    {
        IUserValidationService _userValidationService; // yani böyle bir servisin olduğunu yukarıdaki IGamerService gibi bu interface kalıbını tanıttık

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        /* Örneğin devlet ileriki zamanlarda mernis sisteminden başka bir doğrulama sistemine geçtiğinde sıkıntı yaşamayalım diye bu interface'i
         yukarıdaki 11-16 satırlarındaki gibi yazıyoruz*/
        public void Add(Gamer gamer) // (Gamer gamer, IUserValidationService userValidationService) şeklinde de eklenebilir, bu yukarıdakinin alternatif eklenme şeklidir.
        {                            //ancak bir üst satırda eklenen yorumdaki gibi değil daha yukarıdaki gibi constructor şeklinde yazılmalıdır
            if(_userValidationService.Validate(gamer)==true)
            Console.WriteLine("Kayıt Oldu");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
