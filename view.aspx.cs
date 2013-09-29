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
using System.IO;


public partial class view : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string MailID = Session["VID"].ToString();


            SqlConnection cn = new SqlConnection("server=localhost;database=Mailserver;uid=sa;pwd=sa");

            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_attachments where mail_id=" + MailID + "",cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                Label1.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
            }
            SqlCommand cmd = new SqlCommand("SELECT dbo.tbl_login.username, dbo.tbl_mails.subject, dbo.tbl_mails.send_date, dbo.tbl_mails.file_id FROM dbo.tbl_mails INNER JOIN dbo.tbl_login ON dbo.tbl_mails.from_id = dbo.tbl_login.regno WHERE dbo.tbl_mails.mail_id =" + MailID , cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lbl_from.Text = "From: " + dr.GetValue(0).ToString() + "@MailServer.com";
                lbl_sub.Text = "Subject: " + dr.GetValue(1).ToString();
                lbl_date.Text = "Sent: " + dr.GetValue(2).ToString();

                string FileID = dr.GetValue(3).ToString();
                FileStream fs = new FileStream(Server.MapPath("~/files/" + FileID), FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                txt_Body.Text = sr.ReadToEnd();
                sr.Close();
                fs.Close();
            }
        }

    }
    protected void btn_all_Click(object sender, EventArgs e)
    {
         
    }
    protected void btn_forward_Click(object sender, EventArgs e)
    {
    }
    protected void btn_reply_Click(object sender, EventArgs e)
    {
        txt_send.Visible = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("inbox.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://localhost:1645/WebSite4/Attach/"+Label1.Text);
    }
}
