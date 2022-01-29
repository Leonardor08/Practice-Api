using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public abstract class Address
    {
        public int iD { get; set; }
        public string DescriptionAddress { get; set; }

        //Foreign Key

        public int StudentId { get; set; }
    }
}
