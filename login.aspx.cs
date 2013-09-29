using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        SqlConnection cn = new SqlConnection("server=localhost;database=Mailserver;uid=sa;pwd=sa");
        SqlCommand cmd = new SqlCommand("select regno,isadmin from tbl_login where username=@u and pwd=@p and isapproved=1", cn);
        cmd.Parameters.Add(new SqlParameter("@u", Login1.UserName));
        cmd.Parameters.Add(new SqlParameter("@p", Login1.Password));

        cn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        int RegNo = 0;
        bool IsAdmin = false;

        if (dr.Read())
        {
            RegNo = Convert.ToInt32(dr.GetValue(0));
            IsAdmin = Convert.ToBoolean(dr.GetValue(1));
        }

        dr.Close();
        cn.Close();

        if (RegNo > 0)
        {
            if (IsAdmin)
                Response.Redirect("Admin.aspx");
            else
                Response.Redirect("inbox.aspx?id=" + RegNo.ToString());
        }
        Login1.FailureText = "Username or Password Incorrect !";

    }
  
}
