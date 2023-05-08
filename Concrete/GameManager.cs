using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;


namespace GameProject.Concrete
{
    internal class GameManager: IGameService

    {
        public void Add(GameInfo game)

        {

            Console.WriteLine(game.GameName +  game.GamePrice + " isimli oyun eklendi.");
        }

        public void Update(GameInfo game)

        {
            Console.WriteLine(game.GameName + game.GamePrice + " isimli oyun güncellendi.");
        }
        public void Delete(GameInfo game)

        {
            Console.WriteLine(game.GameName + game.GamePrice + " isimli oyun silindi.");
        }

        public void Save(GameInfo game)

        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Game Info:");
            Console.WriteLine("Id: " + game.Id);
            Console.WriteLine("Game Name: " + game.GameName);
            Console.WriteLine("Game Price: " + game.GamePrice);
            Console.WriteLine("Game Category: " + game.GameCategory);
            Console.WriteLine("-----------------------------------");


        }


    }
}
