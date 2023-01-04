using IntermediaryFields;

namespace IntermediaryFields
{
     public class Program
    {
        static void Main(string[] args)
        {  
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();//all the data will be lost because we accidentaly initialize order list on the promote method
                               // it must be initialized only once. We solve this using readonly modifier 
                               //on the customer class: public readoonly List<Order> Orders;

            System.Console.WriteLine(customer.Orders.Count);
        }
    }
}