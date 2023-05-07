using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    internal interface IPlayerCheckService
    
    {

        bool CheckIfRealPerson(Player player);

    }
}
