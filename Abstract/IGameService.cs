using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    internal interface IGameService

    {

        void Save(GameInfo game);
        void Update(GameInfo game);
        void Delete(GameInfo game);
    }
}
