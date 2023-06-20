using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace missions
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string eror;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["submitsign"] != null)
            {
                string username = Request["user"].ToString();
                string sql = "Select * FROM Users WHERE username ='" + username + "'";
                if (MyAdoHelper.IsExist("Database1.accdb", sql))
                {
                    eror = "username already exists<br/>";

                }
                else
                {
                    string users = Request["user"].ToString();
                    string password = Request["spass"].ToString();
                    string fname = Request["fname"].ToString();
                    string lname = Request["lname"].ToString();
                    string phonenum = Request["phonenum"].ToString();
                    string email = Request["email"].ToString();
                    string data = "empty";
                    string sql2 = $"INSERT INTO USERS values ('{users}' , '{password}' , '{fname}' , '{lname}' , '{phonenum}' , '{email}' , '{data}')";
                    MyAdoHelper.DoQuery("Database1.accdb", sql2);
                    string user = Request["user"];
                    Session["user"] = user;
                    Response.Redirect("missionstable.aspx");
                }
            }
        }
    }
}