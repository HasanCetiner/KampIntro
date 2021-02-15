using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer); //UserValidationManager'de if yapısında "doğru ise..." diyebilek için void'i bool'a çevirdik.
    }
}
