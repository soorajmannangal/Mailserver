<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Aprove.aspx.cs" Inherits="Aprove" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    Activate
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="username" HeaderText="UserName" />
            <asp:BoundField DataField="fname" HeaderText="First Name" />
            <asp:BoundField DataField="lname" HeaderText="Last Name" />
            <asp:BoundField DataField="dob" HeaderText="Date Of Birth" />
            <asp:BoundField DataField="gender" HeaderText="Gender" />
            <asp:BoundField DataField="address" HeaderText="Address" />
            <asp:BoundField DataField="place" HeaderText="Place" />
            <asp:BoundField DataField="phone" HeaderText="Phone" />
        </Columns>
    </asp:GridView>
    &nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Activate" />
</asp:Content>

