<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="inbox.aspx.cs" Inherits="inbox" Title="Untitled Page" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <br />
    <table rules="all" width="500">
        <tr>
            <td align="center" colspan="2" style="height: 28px">
                </td>
            <td colspan="1" style="height: 28px">
            </td>
            <td colspan="1" style="height: 28px">
            </td>
            <td colspan="1" style="height: 28px">
            </td>
            <td align="center" colspan="2" style="height: 28px">
                <asp:Button ID="Button2" runat="server" Text="Delete" Width="173px" OnClick="Button2_Click" /></td>
            <td style="width: 100px; height: 28px;">
            </td>
            <td style="width: 104px; height: 28px;">
            </td>
            <td style="width: 104px; height: 28px;">
            </td>
            <td style="width: 104px; height: 28px;">
            </td>
            <td style="height: 28px;">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 120px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td>
            </td>
            <td>
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 110px">
            </td>
            <td style="width: 100px">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td colspan="10" rowspan="13">
                &nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    ForeColor="#333333" GridLines="None" Height="92px" Width="502px" AllowPaging="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:CheckBox ID="ChkSelect" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="send_date" HeaderText="Date" />
                        <asp:BoundField DataField="username" HeaderText="From" />
                        <asp:BoundField DataField="subject" HeaderText="Subject" />
                        <asp:CommandField SelectText="View" ShowSelectButton="True" />
                    </Columns>
                    <RowStyle BackColor="#EFF3FB" />
                    <EditRowStyle BackColor="#2461BF" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 100px; height: 21px">
            </td>
            <td style="height: 21px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>

