using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOP_Pratice
{
    public class mallardDuck : Duck

    {
        
        
        public mallardDuck()
        {
            //quackBehaviour = new quack(); 
            quackBehaviour = new notQuack();
            flyableBehaviour = new Flyable();
        }

        public void display()
        {

        }
        


    }
}