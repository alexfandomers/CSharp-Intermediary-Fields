using IntermediaryFields;

namespace IntermediaryFields
{
     public class Program
    {
        static void Main(string[] args)
        {  
        }
    }
    //a fieldcan be initialized in two ways: in a constructor or upon declaration
    //the benefit of initializing a field during declaration is that if your class has
    //one or more constructors, you'll make sure that the field will always be initialized
    //irrespective of wich constructor is going to be called.
     public class Customer
    {
        //public List <Order> Orders = new List<Order>();

        //We use the readonly modifier to improve the robustness or our code
        //when a field is declared with readonly, it needs to be initialized either during declaration
        //or in a constructor. The value cannot be changed. This prevents you from accidentaly overwriting
        //the value of a field, wich can result in an unexpected state. As an example, think of the orders
        //in the above example. If we accidentally re-initialize this field somewhere else in the class,
        //all the Order objects stored in the list will be lost. So we should declare it as readonly:

        //public readonly List<Order> Orders = new List<Order>();
    }
}