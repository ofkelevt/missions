using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace missions
{
    public partial class missionstable : System.Web.UI.Page
    {
        public int row=1 ;
        public int lengh=1;
        public string[,] data = new string[20, 20];
        public string tablex ;
        public int saver;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request["addr"] != null)
            {
                if (Session["addr"] != null) 
                 row = Convert.ToInt16(Session["addr"]);
                row++;
            }
            if (Request["addl"] != null)
            {
                if (Session["addl"] != null)
                    lengh = Convert.ToInt16(Session["addr"]);
                lengh++;
            }
            if(row != 1)
            {
                Session["addr"] = row;
            }
            if (lengh != 1)
            {
                Session["addl"] = lengh;
            }
            if(Convert.ToInt16(Session["addr"]) == 0)
            {
                Session["addr"] = 1;
                Session["addl"] = 1;
            }
            tablex += "<table>";
                for(int i = 0; i< Convert.ToInt16(Session["addr"]) + 1; i++)
            {
                tablex += "<tr>" ;
                for (int j = 0; j < Convert.ToInt16(Session["addl"]); j++)
                {
                    if (i == 0) { tablex += "<th>" + $"title<input type = \"text\" name =\" title{j}\" " + "</th>"; }
                    else tablex += "<td>" + $"mission<input type = \"text\" name =\" text{i}.{j}\" " + "</td>";
                }
                tablex += "</tr>";
            }
            tablex += "</table>";
           
        }
    }
}