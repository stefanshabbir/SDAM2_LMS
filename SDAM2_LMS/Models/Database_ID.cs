using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    internal class Database_ID
    {
        protected int ID { get; private set; }
        public Database_ID(int id)
        {
            this.ID = id;
        }
        public int getID()
        {
            return ID;
        }
    }
}
