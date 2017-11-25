using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ObserverPattern
{
    public partial class index : System.Web.UI.Page
    {
       public void Page_Load(object sender, EventArgs e)
        {
            string name = TextBox1.Text.ToString();
            string displayContent = Label1.Text.ToString();
        }
    }
}