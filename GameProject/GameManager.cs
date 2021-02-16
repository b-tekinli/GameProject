using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} oyunu sisteme eklendi.", game.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine("{0} oyunu güncellendi.", game.Name);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} oyunu sistemden silindi.", game.Name);
        }
    }
}
