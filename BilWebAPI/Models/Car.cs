using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilWebAPI.Models
{
    public class Car
    {
        private string regNo;

        public string RegNo { get; set; }

        public Car()
        {

        }

        public Car(string regNo)
        {
            RegNo = regNo;
        }
    }
}