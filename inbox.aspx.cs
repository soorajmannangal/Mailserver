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

public partial class inbox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillGridView();
        }

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int[,] tmp = (int[,])Session["MID"];
        Session["VID"] = tmp[GridView1.SelectedIndex, 0];

        Session["n"] = "sooraj";

        Response.Redirect("view.aspx?id=" + Request.QueryString["id"]);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection("server=localhost;database=Mailserver;uid=sa;pwd=sa");
        cn.Open();

        for (int i = 0; i < GridView1.Rows.Count; ++i)
        {
            CheckBox c = (CheckBox)GridView1.Rows[i].FindControl("ChkSelect");
            if (c.Checked)
            {
                int[,] tmp = (int[,])Session["MID"];
                
                SqlCommand cmd = new SqlCommand("delete from tbl_Mails where mail_id=" + tmp[i,0].ToString (),cn);
                System.IO.File.Delete(Server.MapPath("~/files/" + tmp[i, 1].ToString()));

                //SqlCommand cmd = new SqlCommand("delete from tbl_Mails where to_id=@userid and subject=@sub and send_date=@sdate", cn);
                //cmd.Parameters .Add (new SqlParameter ("@userid",Convert.ToInt32 ( Request.QueryString["id"])));
                //cmd.Parameters .Add (new SqlParameter ("@sub",GridView1.Rows[i].Cells[2].Text));
                //cmd.Parameters .Add (new SqlParameter ("@sdate",GridView1.Rows[i].Cells[3].Text));
                cmd.ExecuteNonQuery ();
            }
        }
        cn.Close();
        FillGridView();
    }


    private void FillGridView()
    {
        SqlConnection cn = new SqlConnection("server=localhost;database=Mailserver;uid=sa;pwd=sa");
        SqlCommand cmd = new SqlCommand("SELECT dbo.tbl_login.username, dbo.tbl_mails.subject, dbo.tbl_mails.send_date, dbo.tbl_mails.mail_id, dbo.tbl_mails.file_id FROM  dbo.tbl_login INNER JOIN  dbo.tbl_mails ON dbo.tbl_login.regno = dbo.tbl_mails.from_id WHERE dbo.tbl_mails.to_id =" + Request.QueryString["id"], cn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);

        GridView1.DataSource = ds.Tables[0].DefaultView;
        GridView1.DataBind();

        int[,] MailID = new int[ds.Tables[0].Rows.Count,2];
        for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
        {
            MailID[i, 0] = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray.GetValue(3));
            MailID[i, 1] = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray.GetValue(4));
        }

        Session["MID"] = MailID;
    }
}
