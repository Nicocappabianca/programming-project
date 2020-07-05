using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    [Serializable]
    public class Order
    {
        public int id;
        public string date;
        public string product;
        public string description;
        public string status; 
        public Order (int id, string date, string product, string description)
        {
            this.id = id;
            this.date = date;
            this.product = product;
            this.description = description;
            this.status = "Pendiente de aprobación";  
        }
    }
}
