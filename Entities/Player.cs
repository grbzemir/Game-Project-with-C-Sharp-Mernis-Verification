using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;

namespace GameProject.Entities
{
    internal class Player:IEntity

    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime YearOfBirth { get; set; }

        public string username { get; set; }

        public string NationalityId { get; set; }
    }
}
