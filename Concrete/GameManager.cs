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

            Console.WriteLine(game.GameName + " isimli oyun eklendi.");
        }

        public void Update(GameInfo game)

        {
            Console.WriteLine(game.GameName + " isimli oyun güncellendi.");
        }
        public void Delete(GameInfo game)

        {
            Console.WriteLine(game.GameName + " isimli oyun silindi.");
        }

        public void Save(GameInfo game)

        {
            throw new NotImplementedException();

        }
    }
}
