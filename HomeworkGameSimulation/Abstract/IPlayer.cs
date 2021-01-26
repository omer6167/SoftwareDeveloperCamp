using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkGameSimulation.Abstract
{
    internal interface IPlayer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNo { get; set; }
        public DateTime BirthDate{ get; set; }

    }
}
