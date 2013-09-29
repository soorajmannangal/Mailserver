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

public partial class registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        for (int i = 1; i <= 31; i++)
        {
            DDL_date.Items.Add(Convert.ToString(i));
        }
        for (int i = DateTime.Today.Year; i >= 1950; i--)
        {
            ddl_year.Items.Add(Convert.ToString(i));
        }
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        if (!chk_accept.Checked)
        {
            lbl_Err.Visible = true;
            return;
        }

        if (avilability())
        {
            int RegNo = GetNewRegisterNumber();
            DateTime dob = new DateTime(Convert.ToInt32(ddl_year.SelectedValue), Convert.ToInt32(ddl_month.SelectedValue), Convert.ToInt32(DDL_date.SelectedValue));

            string Gender = "Male";
            if (rad_Female.Checked) Gender = "Female";

            SqlConnection cn = new SqlConnection("server=localhost;database=Mailserver;uid=sa;pwd=sa");
            SqlCommand cmd = new SqlCommand("insert into tbl_Registration values(@Regno,@Fname,@Lname,@Dob,@Gender,@Addrs,@Country,@Phone)", cn);
            cmd.Parameters.Add(new SqlParameter("@Regno", RegNo));
            cmd.Parameters.Add(new SqlParameter("@Fname", txt_fname.Text));
            cmd.Parameters.Add(new SqlParameter("@Lname", txt_lname.Text));
            cmd.Parameters.Add(new SqlParameter("@Dob", dob.ToShortDateString()));
            cmd.Parameters.Add(new SqlParameter("@Gender", Gender));
            cmd.Parameters.Add(new SqlParameter("@Addrs", txt_address.Text));
            cmd.Parameters.Add(new SqlParameter("@Country", dd_Country.SelectedValue));
            cmd.Parameters.Add(new SqlParameter("@Phone", txt_phone.Text));

            cn.Open();
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("insert into tbl_login values(@u,@p,0,0,@regno)", cn);
            cmd.Parameters.Add(new SqlParameter("@u", txt_loginname.Text));
            cmd.Parameters.Add(new SqlParameter("@p", txt_pwd.Text));
            cmd.Parameters.Add(new SqlParameter("@regno", RegNo));

            cmd.ExecuteNonQuery();
            Response.Redirect("regsuccess.aspx");
        }
    }
    private int GetNewRegisterNumber()
    {
        SqlConnection cn = new SqlConnection("server=localhost;database=Mailserver;uid=sa;pwd=sa");
        SqlCommand cmd = new SqlCommand("select max(regno) from tbl_login", cn);
        int RegNo = 1;

        cn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
            RegNo = Convert.ToInt32(dr.GetValue(0)) + 1;

        dr.Close();
        cn.Close();

        return RegNo;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        avilability();
    }
    private bool avilability()
    {
        SqlConnection cn = new SqlConnection("server=localhost;database=Mailserver;uid=sa;pwd=sa");
        SqlCommand cmd = new SqlCommand("select count(*) from tbl_login where '"+txt_loginname.Text+"' = username", cn);
        cn.Open();
        lbl_avail.Visible = true;
  
        int x=Convert.ToInt32(cmd.ExecuteScalar());
        cn.Close();
        if (x>0)
        {

            lbl_avail.Text = "It is not available";
            return false;

        }
        else
            lbl_avail.Text = "It is available";
        return true;
        
    }
}

