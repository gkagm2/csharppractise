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

        }
    }
}
