using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    interface InterfaceNewspaper
    {
        public void registerSubcriber(InterfaceSubcribers subcribe);
        public void notifySubcriber();
        public void removeSubcriber(InterfaceSubcribers subcribe);
    }
}
