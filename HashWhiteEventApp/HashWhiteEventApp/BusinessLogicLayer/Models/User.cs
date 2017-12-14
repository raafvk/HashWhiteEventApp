using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashWhiteEventApp.BusinessLogicLayer.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }
        public string EmailID { get; set; }
        public string PhoneNo { get; set; }
        //public bool Done { get; set; }
    }
}
