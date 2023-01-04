using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntermediaryFields
{
    public class Customer
    {
        public int Id;
       public string Name;
       public readonly List<Order> Orders;

       //Declaring a constructor
       public Customer() // in this constructor orders will be initialized but will be null on the oders ones.
       {
            Orders = new List<Order>();
       }
       public Customer(int id)
            : this() //this means when we call this constructor we initialize orders from the first constuctor
                     //We can pass control from one constructor to the other by using the this keyword.
       {
            this.Id = id;
       }
       public Customer(int id, string name)
            : this(id) //this means when we call this constructor we initialize orders from the second constuctor
       {
            //this.Id = id;
            this.Name = name;
       }
                                ///////readonly modifier/////
       //method promote
       public void Promote()
       {
            //if a accidentaly initialize this order here and call this method on program.cs
            //when we run the application all the data in orders field will be lost

            /*Orders = new List<Order>();*/ //when we use a reaonly modifier an error will appear on this line
       }
    }
   
}