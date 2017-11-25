using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOP_Pratice
{
    public abstract class Duck
    {
       public FlyInterface1 flyableBehaviour;
        public QuackInterface quackBehaviour;

        public void display();

        public void performFly()
        {
            flyableBehaviour.fly();
        }
        
        public void performQuack()
        {
            quackBehaviour.quack();
        }
    }
}