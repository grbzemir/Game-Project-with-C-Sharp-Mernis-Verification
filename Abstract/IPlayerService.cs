using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    internal interface IPlayerService

    {

        void Save(Player player);

        void Update(Player player);

        void Delete(Player player);

    }
}
