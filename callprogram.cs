using OpenQA.Selenium.DevTools.V114.Cast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundas
{
    class callprogram : Program4
    {
        //
        string name;
        public callprogram(string name) {
            this.name = name;

        }
        
        public void printName()
        {
            Console.WriteLine("My name is "+name);
        }
        public void getData()
        {
            Console.WriteLine("I am insided second program");
        }


        static void Main(string[] args)
        {
            callprogram cp =  new callprogram( "Prathiba");
            callprogram cp1 = new callprogram("Prabhu");
            cp.getData();
            cp.setData();
            cp.printName();
            cp1.printName();
        }
    }
}
