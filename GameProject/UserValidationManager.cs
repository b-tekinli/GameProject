using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool CheckGamer(Gamer gamer)
        {
            Console.WriteLine("Oyuncu doğrulandı.");
            return true;
        }
    }
}
