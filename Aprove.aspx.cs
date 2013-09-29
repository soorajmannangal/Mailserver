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

public partial class Aprove : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("server=localhost;database=MailServer;uid=sa;pwd=sa");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillGrid();
        }
    }
    public void FillGrid()
    {
        SqlDataAdapter da = new SqlDataAdapter("SELECT     dbo.tbl_login.isapproved, dbo.tbl_login.username, dbo.tbl_registration.fname, dbo.tbl_registration.lname, dbo.tbl_registration.dob, "+
                      " dbo.tbl_registration.gender, dbo.tbl_registration.address, dbo.tbl_registration.place, dbo.tbl_registration.phone"+
                      " FROM         dbo.tbl_login INNER JOIN"+
                      " dbo.tbl_registration ON dbo.tbl_login.regno = dbo.tbl_registration.regno where dbo.tbl_login.isapproved=0", cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        cn.Close();
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            CheckBox ch = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
            if (ch.Checked)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("update tbl_login set isapproved=1 where username='" + GridView1.Rows[i].Cells[1].Text + "'", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        FillGrid();
    }
}
