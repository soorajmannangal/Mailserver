<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="composemail.aspx.cs" Inherits="composemail" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
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
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#3300FF" Text="To"></asp:Label></td>
            <td colspan="2">
                <asp:TextBox ID="txt_to" runat="server" Width="284px"></asp:TextBox></td>
            <td style="width: 100px">
                &nbsp;@MailServer.Com</td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                </td>
            <td colspan="2">
                <asp:Label ID="lbl_Err" runat="server" ForeColor="Red" Text="User does not Exist !"
                    Visible="False"></asp:Label></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="#0000FF"
                    Text="Subject"></asp:Label></td>
            <td colspan="2">
                <asp:TextBox ID="txt_subject" runat="server" Width="283px"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="Blue"
                    Text="Attachments"></asp:Label></td>
            <td colspan="2">
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Attach" /></td>
            <td style="width: 100px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td colspan="3" rowspan="11">
                &nbsp;
                <asp:TextBox ID="txt_Body" runat="server" Height="240px" TextMode="MultiLine" Width="381px"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <asp:Button ID="btn_send" runat="server" Text="Send" Width="73px" OnClick="btn_send_Click" /></td>
            <td style="width: 100px">
                <asp:Button ID="btn_save" runat="server" Text="Savenow" /></td>
            <td style="width: 100px">
                &nbsp;<asp:Button ID="Btn_dicard" runat="server" Text="Discard" /></td>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
</asp:Content>

