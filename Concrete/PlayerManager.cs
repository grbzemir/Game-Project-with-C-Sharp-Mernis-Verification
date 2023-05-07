using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class PlayerManager:IPlayerService

    {
        public static Player Player;

        public PlayerManager(MernisServiceAdapter mernisServiceAdapter) 
        
        {

            MernisServiceAdapter = mernisServiceAdapter;

        
        }

        public MernisServiceAdapter MernisServiceAdapter { get; }

        public virtual void Save(Player player)

        {
            if (MernisServiceAdapter.CheckIfRealPerson(player))

            {
                Console.WriteLine("Saved to db : " + player.FirstName);

            }

            else

            {
                
             Console.WriteLine(player.username + " " + "player has been registered in the system.");
            
            }
        }

        public void Delete(Player player)

        {

            Console.WriteLine("Deleted from db : " + player.FirstName);
        }

        public void Update(Player player)

        {

            Console.WriteLine("Updated in db : " + player.FirstName);
        }

        
    }
}
