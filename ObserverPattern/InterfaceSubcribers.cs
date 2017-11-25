using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    interface InterfaceSubcribers
    {
        public void updateSubcriber(string breakingNews, string newInformation);
    }
}
