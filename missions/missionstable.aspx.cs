using System;

namespace missions
{
    public partial class missionstable : System.Web.UI.Page
    {
        public int row = 1;
        public int lengh = 1;
        public string tablex;
        public int saver;
        public string eror;
        public string data;
        public int x;
        public int y;
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
                    lengh = Convert.ToInt16(Session["addl"]);
                lengh++;
            }
            if (row != 1)
            {
                Session["addr"] = row;
            }
            if (lengh != 1)
            {
                Session["addl"] = lengh;
            }
            if (Convert.ToInt16(Session["addr"]) == 0)
            {
                Session["addr"] = 1;
                Session["addl"] = 1;
            }


             x = Convert.ToInt16(Session["addl"]);
             y = Convert.ToInt16(Session["addr"]);
            data = "{" + $"\"data\":["; 
            tablex += "<table>" +"<form method= \"post \">" ;
            for (int i = 0; i < y + 1; i++)
            {
                tablex += "<tr>";
                for (int j = 0; j < x; j++)
                {
                    if (Session[$"text{x * i + j}"] != null)
                    {
                        if (i == 0) { tablex += $"<th>" + Session[$"text{x * i + j}"].ToString() + "</th>"; }
                        else tablex += "<td>" + Session[$"text{x * i + j}"].ToString() + "</td>";
                        data += "{" + $"\"tablesqare\" : \"{Session[$"text{x * i + j}"].ToString()}\"" + "} ";
                    }
                    
                    else if (Request[$"text{x * i + j}"] != null)
                    {

                        if (i == 0) { tablex += $"<th>" + Request[$"text{x * i + j}"].ToString() + "</th>"; }
                        else tablex += "<td>" + Request[$"text{x * i + j}"].ToString() + "</td>";
                        data += "{" + $"\"tablesqare\" : \"{Request[$"text{x * i + j}"].ToString()}\"" + "} ";
                    }

                    else if (i == 0)
                    {
                        tablex += $"<th>\r\n title<input type=\"text\" name=\"text{x*i+j}\"  /> </th>";
                        data += "{"+$"\"tablesqare\" : \"title<input type=\\\"text\\\" name=\\\"text{x*i+j}\\\"/>\""+"}  ";
                    }
                    else  {
                        tablex +=  $"<td>\r\n mission<input type=\"text\" name=\"text{x*i+j}\"  /> </td>";
                        data += "{"+$"\"tablesqare\" : \"title<input type=\\\"text\\\" name=\\\"text{x*i+j}\\\"/>\"" +"}  ";
                    }
                    if (!(i == y && j == x - 1)) { data += ","; }
                    


                }
                tablex += "</tr>";
               
            }
            data += "]}";
            tablex +=  $"<tr><td><input type=\"submit\" name=\"submit\" value = \"submit \"  /> </td><tr>";
            tablex +="</form>"+ "</table>";
            if (Request["submit"]!= null) {
                string sql = "UPDATE users SET data ='" + data + "' WHERE username = '" + Session["user"] + "'";
                MyAdoHelper.DoQuery("Database1.accdb", sql);
            }
            
        }
    }
}