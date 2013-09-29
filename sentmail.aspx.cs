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

public partial class sentmail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillGridView();
        }

    }
    private void FillGridView()
    {
        SqlConnection cn = new SqlConnection("server=localhost;database=Mailserver;uid=sa;pwd=sa");
        SqlCommand cmd = new SqlCommand("SELECT     dbo.tbl_mails.send_date, dbo.tbl_login.username, dbo.tbl_mails.subject, dbo.tbl_mails.file_id"+
                                        " FROM         dbo.tbl_mails INNER JOIN"+
                                        "                      dbo.tbl_login ON dbo.tbl_mails.to_id = dbo.tbl_login.regno"+
                                        " WHERE     (dbo.tbl_mails.from_id = " + Request.QueryString["id"]+")", cn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);

        GridView2.DataSource = ds;
        GridView2.DataBind();
        /*
        int[,] MailID = new int[ds.Tables[0].Rows.Count, 2];
        for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
        {
            MailID[i, 0] = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray.GetValue(3));
            MailID[i, 1] = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray.GetValue(4));
        }

        Session["MID"] = MailID;*/
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        int[,] tmp = (int[,])Session["MID"];
        Session["VID"] = tmp[GridView2.SelectedIndex, 0];
        Response.Redirect("view.aspx?id=" + Request.QueryString["id"]);
    }
    
}

