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
                if (Session["addr"] == null)
                    row++;
                else row = Convert.ToInt16(Session["addr"]);
            }
            if (Request["addl"] != null)
            {
                lengh++;
            }
            if(row != 1)
            {
                Session["addr"] = row;
            }

            tablex += "<table>";
            for(int i = 0; i<row +1; i++)
            {
                tablex += "<tr>" ;
                for (int j = 0; j < lengh; j++)
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