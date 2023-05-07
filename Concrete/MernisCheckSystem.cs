using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class MernisCheckSystem:IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        
        {
            return true;
        }

    }
    
    
}
