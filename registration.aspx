<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="registration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 646px; height: 506px">
            <tr>
                <td colspan="1">
                </td>
                <td colspan="3">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td colspan="1">
                </td>
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Registration Form"
                        Width="329px"></asp:Label></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Label ID="Label2" runat="server" Text="First Name" Width="69px"></asp:Label></td>
                <td colspan="2">
                    <asp:TextBox ID="txt_fname" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_fname"
                        ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Label ID="Label3" runat="server" Text="Last name"></asp:Label></td>
                <td colspan="2">
                    <asp:TextBox ID="txt_lname" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_lname"
                        ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Label ID="Label10" runat="server" Text="Date of birth"></asp:Label></td>
                <td colspan="3">
                    <asp:DropDownList ID="DDL_date" runat="server">
                    </asp:DropDownList><asp:DropDownList ID="ddl_month" runat="server" Width="84px">
                        <asp:ListItem Value="1">January</asp:ListItem>
                        <asp:ListItem Value="2">February</asp:ListItem>
                        <asp:ListItem Value="3">March</asp:ListItem>
                        <asp:ListItem Value="4">April</asp:ListItem>
                        <asp:ListItem Value="5">May</asp:ListItem>
                        <asp:ListItem Value="6">June</asp:ListItem>
                        <asp:ListItem Value="7">July</asp:ListItem>
                        <asp:ListItem Value="8">August</asp:ListItem>
                        <asp:ListItem Value="9">September</asp:ListItem>
                        <asp:ListItem Value="10">October</asp:ListItem>
                        <asp:ListItem Value="11">November</asp:ListItem>
                        <asp:ListItem Value="12">December</asp:ListItem>
                    </asp:DropDownList>&nbsp;<asp:DropDownList ID="ddl_year" runat="server">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Label ID="Label11" runat="server" Text="Gender"></asp:Label></td>
                <td style="width: 100px">
                    <asp:RadioButton ID="rad_Male" runat="server" Checked="True" GroupName="radio" Text="Male" /></td>
                <td style="width: 100px">
                    <asp:RadioButton ID="rad_Female" runat="server" GroupName="radio" Text="Female" /></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Label ID="Label12" runat="server" Text="Address"></asp:Label></td>
                <td colspan="2">
                    <asp:TextBox ID="txt_address" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Label ID="Label13" runat="server" Text="Country"></asp:Label></td>
                <td colspan="2">
                    <asp:DropDownList ID="dd_Country" runat="server">
                        <asp:ListItem>India</asp:ListItem>
                        <asp:ListItem>China</asp:ListItem>
                        <asp:ListItem>USA</asp:ListItem>
                        <asp:ListItem>Japan</asp:ListItem>
                        <asp:ListItem>Australia</asp:ListItem>
                        <asp:ListItem>Canada</asp:ListItem>
                        <asp:ListItem>Korea</asp:ListItem>
                        <asp:ListItem>Srilanka</asp:ListItem>
                        <asp:ListItem>Pakistan</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Label ID="Label14" runat="server" Text="Phone no"></asp:Label></td>
                <td colspan="2">
                    <asp:TextBox ID="txt_phone" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_phone"
                        ErrorMessage="*" ValidationExpression="\d{6,15}"></asp:RegularExpressionValidator></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Label ID="Label4" runat="server" Text="Desired Log in name"></asp:Label></td>
                <td colspan="2">
                    <asp:TextBox ID="txt_loginname" runat="server"></asp:TextBox><asp:Label ID="Label7"
                        runat="server" Height="19px" Text="@abc.com" Visible="False" Width="86px"></asp:Label></td>
                <td style="width: 100px">
                    <asp:Label ID="lbl_avail" runat="server" Text="id not available" Visible="False"
                        Width="86px" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Check Availability" /></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Label ID="Label5" runat="server" Text="Choose a password"></asp:Label></td>
                <td colspan="2">
                    <asp:TextBox ID="txt_pwd" runat="server" TextMode="Password"></asp:TextBox></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Label ID="Label6" runat="server" Text="Re-enter password"></asp:Label></td>
                <td colspan="2">
                    <asp:TextBox ID="txt_repwd" runat="server" TextMode="Password"></asp:TextBox></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px; height: 40px;">
                </td>
                <td style="width: 100px; height: 40px;">
                    <asp:Label ID="Label8" runat="server" Text="Secondary Email"></asp:Label></td>
                <td colspan="2" style="height: 40px">
                    <asp:TextBox ID="txt_secemail" runat="server"></asp:TextBox></td>
                <td style="width: 100px; height: 40px;">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td colspan="2">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td colspan="1">
                </td>
                <td colspan="3">
                    <asp:Label ID="Label9" runat="server" Text="Terms and condition" Width="183px"></asp:Label></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td colspan="1">
                </td>
                <td colspan="3">
                    <asp:TextBox ID="txt_term" runat="server" TextMode="MultiLine" Width="407px">terms and condition
</asp:TextBox></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td colspan="1" style="height: 21px">
                </td>
                <td colspan="3" style="height: 21px">
                    <asp:CheckBox ID="chk_accept" runat="server" Text="Accept" />
                    <asp:Label ID="lbl_Err" runat="server" ForeColor="Red" Text="You must agree the terms..."
                        Visible="False"></asp:Label></td>
                <td style="width: 100px; height: 21px">
                </td>
            </tr>
            <tr>
                <td colspan="1" style="height: 21px">
                </td>
                <td colspan="3" style="height: 21px">
                </td>
                <td style="width: 100px; height: 21px">
                </td>
            </tr>
            <tr>
                <td colspan="1" style="height: 21px">
                </td>
                <td colspan="3" style="height: 21px">
                    <asp:Button ID="btn_submit" runat="server" OnClick="btn_submit_Click" Text="Submit"
                        Width="127px" /></td>
                <td style="width: 100px; height: 21px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
