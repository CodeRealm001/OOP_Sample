using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObserverPattern
{
    public class ClassSubcribers: InterfaceSubcribers
    {
        InterfaceSubcribers newsScriber;
        

       

        /// <summary>
        /// If there should be different types subcribers, another class can inherit from the class 
        /// copy this methods in every classes then use different business logic 
        /// </summary>
        //public void subcriber()
        //{
        //    throw new NotImplementedException();
        //}
    }

    

}