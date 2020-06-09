using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    public static class OrdersRepository
    {
        static List<Order> ordersList = new List<Order>();
        
        public static void addOrder(int id, string date, string product, string description)
        {
            Order newOrder = new Order(id, date, product, description); 
            ordersList.Add(newOrder); 
        }

        public static Order getOrderById(int id)
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

        public static int listCount()
        {
            return ordersList.Count(); 
        }
    }
}
