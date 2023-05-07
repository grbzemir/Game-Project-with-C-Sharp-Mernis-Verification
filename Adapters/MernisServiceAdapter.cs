using GameProject.Abstract;
using GameProject.Entities;
using GameProject.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Adapters
{
    internal class MernisServiceAdapter:IPlayerCheckService

    {

        public bool CheckIfRealPerson(Player player)
        
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalityId), player.FirstName.ToUpper(), player.LastName.ToUpper(), player.YearOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
            
        }


    }
}
