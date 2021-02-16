using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GamerManager : IGamerService, IUserValidationService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("{0} {1} adlı oyuncu sisteme eklendi.", gamer.Name, gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("{0} {1} adlı oyuncunun bilgileri sistemde güncellendi.", gamer.Name, gamer.LastName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("{0} {1} adlı oyuncu sistemden silindi.", gamer.Name, gamer.LastName);
        }

        public bool CheckGamer(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
