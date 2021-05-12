<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="test1.aspx.cs" Inherits="WebApplication5.test1" %>

<script runat="server">

    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="帳號"></asp:Label>
    <input id="Text1" type="text" name ="acount" />
    <br />
    <asp:Label ID="Label2" runat="server" Text="密碼"></asp:Label>
    <input id="Text2" type="text" name ="password" /><br />
    <asp:Label ID="Label5" runat="server" Text="暱稱"></asp:Label>
    <input id="Text3" type="text" name ="username"/><br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="登入" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="註冊" OnClick="Button2_Click" />
    <br />
    <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
&nbsp;
    </asp:Content>
