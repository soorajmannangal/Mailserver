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


public partial class composemail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_send_Click(object sender, EventArgs e)
    {
        //Check the toID
        int UserID = GetUserID(txt_to.Text);
        if (UserID == -1)
        {
            lbl_Err.Visible = true;
            return;
        }

        //Sender ID
        int FromID = Convert.ToInt32( Request.QueryString["id"]);

        //Get MailID
        int MailID = GetNewMailID();

        int FileID = GetNewFileID();
        FileStream fs = new FileStream(Server.MapPath("~/files/" + FileID.ToString()) , FileMode.Create, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);
        sw.Write(txt_Body.Text);
        sw.Close();
        fs.Close();

        if (Session["flg"] == "1")
        {
            Int32 a_id=GetNewAttID();
            SqlConnection cns = new SqlConnection("server=localhost;database=Mailserver;uid=sa;pwd=sa");
            if (Session["fname"] != null)
            {
                string fname =""+ Session["fname"];
                SqlCommand cmds = new SqlCommand("insert into tbl_Attachments values (" + a_id + "," + MailID + ",'" + fname + "')", cns);
                cns.Open();
                cmds.ExecuteNonQuery();
                cns.Close();
            }
        }

        SqlConnection cn = new SqlConnection("server=localhost;database=Mailserver;uid=sa;pwd=sa");
        SqlCommand cmd = new SqlCommand("insert into tbl_mails values(@mid,@fid,@tid,@sub,@sdate,@flid,@isread)", cn);
        cmd.Parameters.Add(new SqlParameter("@mid", MailID ));
        cmd.Parameters.Add(new SqlParameter("@fid", FromID ));
        cmd.Parameters.Add(new SqlParameter("@tid", UserID));
        cmd.Parameters.Add(new SqlParameter("@sub", txt_subject.Text));
        cmd.Parameters.Add(new SqlParameter("@sdate", DateTime.Now));
        cmd.Parameters.Add(new SqlParameter("@flid", FileID));
        cmd.Parameters.Add(new SqlParameter("@isread", false));
       //cmd.Parameters.Add(new SqlParameter("@isdel", false));
        cn.Open();
        cmd.ExecuteNonQuery();


        Response.Redirect("inbox.aspx?id=" + Request.QueryString["id"]);
    }

    private int GetNewMailID()
    {
        SqlConnection cn = new SqlConnection("server=localhost;database=Mailserver;uid=sa;pwd=sa");
        SqlCommand cmd = new SqlCommand("select max(mail_id) from tbl_mails", cn);
        int MailID = 1;

        cn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            if(!dr.IsDBNull(0))
                MailID = Convert.ToInt32(dr.GetValue(0)) + 1;
        }

        dr.Close();
        cn.Close();

        return MailID;
    }

    private int GetNewFileID()
    {
        SqlConnection cn = new SqlConnection("server=localhost;database=Mailserver;uid=sa;pwd=sa");
        SqlCommand cmd = new SqlCommand("select max(file_id) from tbl_mails", cn);
        int FileID = 1;

        cn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            if (!dr.IsDBNull(0))
                FileID = Convert.ToInt32(dr.GetValue(0)) + 1;
        }
        
        dr.Close();
        cn.Close();

        return FileID;
    }
    private int GetNewAttID()
    {
        SqlConnection cn = new SqlConnection("server=localhost;database=Mailserver;uid=sa;pwd=sa");
        SqlCommand cmd = new SqlCommand("select max(att_id) from tbl_Attachments", cn);
        int FileID = 1;

        cn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            if (!dr.IsDBNull(0))
                FileID = Convert.ToInt32(dr.GetValue(0)) + 1;
        }

        dr.Close();
        cn.Close();

        return FileID;
    }
    private int GetUserID(string UserName)
    {
        SqlConnection cn = new SqlConnection("server=localhost;database=Mailserver;uid=sa;pwd=sa");
        SqlCommand cmd = new SqlCommand("select regno from tbl_login where username=@u", cn);
        cmd.Parameters.Add(new SqlParameter("@u", txt_to.Text));

        int UserID = -1;

        cn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            if (!dr.IsDBNull(0))
                UserID = Convert.ToInt32(dr.GetValue(0));
        }

        dr.Close();
        cn.Close();

        return UserID;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Int64 a_id= GetNewAttID();
        byte[] b = FileUpload1.FileBytes;
        string fname =  a_id+FileUpload1.FileName.Substring(FileUpload1.FileName.LastIndexOf("."));
        Session["fname"] = fname;
        FileStream fs = new FileStream(Server.MapPath("~/Attach/" +fname), FileMode.Create, FileAccess.Write);
        BinaryWriter br = new BinaryWriter(fs);
        br.Write(b);
        br.Close();
        fs.Close();
        Session["flg"] = "1";
        
        
    }
}
