using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace helloWorld
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //hello world 
            Response.Write("Hello World\n");

            //Date Time

            string Date = DateTime.Now.ToString("dddd, MMMM");
            Console.WriteLine(Date);


        }
    }
}