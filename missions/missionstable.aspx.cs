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
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["data"] == null)
            {
                Session["data"] = new string[20, 20];
            }

            var data = (string[,])Session["data"];
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
            
            if (Request["submit"] != null)
            {
                for (int k = 0; k < row + 1; k++)
                {
                    for (int l = 0; l < lengh; l++)
                    {
                        if (Request[$"text{k}.{l}"] != null)
                        {
                            data[k, l] = Request[$"text{k}.{l}"].ToString();
                            if (data[k, l].Contains(",.,") == true)
                            {
                                if (k == 0) data[k, l] = $"<th>\r\n tytle<input type=\"text\" name=\"text{k}.{l}\"  /> </th>";
                                else data[k, l] = $"<td>\r\n mission<input type=\"text\" name=\"text{k}.{l}\"  /> </td>";
                                eror += $"square height:{k + 1} lengh :{l + 1} contains ,., pls remove it and rewrite the sentense";
                            }
                            else if(k==0 ) data[k, l] = "<th>"+ Request[$"text{k}.{l}"].ToString() + "</th>";
                            else data[k, l] = "<td>" + Request[$"text{k}.{l}"].ToString() + "</td>";
                        }
                        else data[k, l] = "\"<th>\" + $\"title<input type = \\\"text\\\" name =\\\" title{j}\\\" \" + \"</th>\";";
                    }
                }
                string sql = "UPDATE user SET data ='" + data + "' WHERE username = '"+ Session["user"] + "'"   ;
                MyAdoHelper.DoQuery("Database1.accdb", sql);
            }
            tablex += "<table>" +"<form method= \"post \">" ;
            for (int i = 0; i < Convert.ToInt16(Session["addr"]) + 1; i++)
            {
                tablex += "<tr>";
                for (int j = 0; j < Convert.ToInt16(Session["addl"]); j++)
                {
                    if (data[i, j] != null)
                    {
                        tablex += data[i, j];
                    }
                    else if (i == 0) { tablex += $"<th>\r\n tytle<input type=\"text\" name=\"text{i}.{j}\"  /> </th>"; }
                    else tablex += $"<td>\r\n mission<input type=\"text\" name=\"text{i}.{j}\"  /> </td>";
                }
                tablex += "</tr>";
            }
            tablex += $"<tr><td><input type=\"submit\" name=\"submit\" value = \"submit \"  /> </td><tr>";
            tablex +="</form>"+ "</table>";
            
        }
    }
}