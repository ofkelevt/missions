using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace missions
{
    public partial class login : System.Web.UI.Page
    {
        public string error;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["check"] != null) 
            {
                string user = Request["user"];
                string pass = Request["pass"];
                string sql = $"SELECT * FROM users WHERE username ='{user}' AND password='{pass}'";

                if (MyAdoHelper.IsExist("Database1.accdb", sql))
                {
                    Session["user"] = Request["user"].ToString();
                    Session["pass"] = Request["pass"].ToString();
                    Response.Redirect("missionstable.aspx");
                        
                }
                else
                {
                    error = "login failed";
                }
                Response.Redirect("missiontable.aspx");
            }
        }
    }
}