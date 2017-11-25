using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOP_Pratice
{
    public class notQuack : QuackInterface
    {
        void quack()
        {
            // Do something that will make it not Squack
            string print = "I'm not Quacking ";
        }


    }
}