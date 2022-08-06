using System;
using System.Collections;

namespace Collections
{
    class Program
    {

        protected void Button1_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            string str = "kiran teja jallepalli";
            int x = 7;
            DateTime d = DateTime.Parse("8-oct-1985");
            al.Add(str);
            al.Add(x);
            al.Add(d);

            foreach (object o in al)
            {
                Response.Write(o);
                Response.Write("<br>");
            }
        }
    }
}