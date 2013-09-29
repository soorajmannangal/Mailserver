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

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lbt_inbox_Click(object sender, EventArgs e)
    {
        Response.Redirect("inbox.aspx?id=" + Request.QueryString["id"]);
    }
    protected void lbt_compose_Click(object sender, EventArgs e)
    {        
        Response.Redirect("composemail.aspx?id=" + Request.QueryString["id"]);
    }
    protected void lbt_sentmail_Click(object sender, EventArgs e)
    {
        Response.Redirect("sentmail.aspx?id=" + Request.QueryString["id"]);
    }
    protected void lbt_signout_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
}
