using System;
using System.Collections.Generic;
using System.Text;

//TODO:
namespace practise1
{
    interface INameValue
    {
        string Name
        {
            get;
            set;
            }
        string Value
        {
            get;
            set;
        }
    }
        
    
    class NamedValue : INameValue
    {
        public string Name
        {
            get;
            set;
        }
        public string Value
        {
            get;
            set;
        }
            
    }
    class PropertiesInInterface
    {

        static void Main(string [] args)
        {
            NamedValue name = new NamedValue() { Name = "name", Value = "HongKilDong" };

            NamedValue height = new NamedValue() { Name = "height", Value = "199Cm" };

            NamedValue weight = new NamedValue() { Name = "weight", Value = "110Kg" };

            Console.WriteLine("{0} : {1} ", name.Name, name.Value);
            Console.WriteLine("{0} : {1} ", height.Name, height.Value);
            Console.WriteLine("{0} : {1} ", weight.Name, weight.Value);



        }
    }
}
