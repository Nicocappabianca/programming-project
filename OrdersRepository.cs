using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    [Serializable]
    public class OrdersRepository
    {
        public List<Order> ordersList = new List<Order>();
        
        public void addOrder(int id, string date, string product, string description)
        {
            Order newOrder = new Order(id, date, product, description); 
            ordersList.Add(newOrder); 
        }

        public Order getOrderById(int id)
        {
            foreach(Order _order in ordersList)
            {
                if(_order.id == id)
                {
                    Order found = _order;
                    return found; 
                }
            }
            return null; 
        }

        public int listCount()
        {
            return ordersList.Count(); 
        }
    }
}
