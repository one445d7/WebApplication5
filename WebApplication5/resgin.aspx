<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="resgin.aspx.cs" Inherits="WebApplication5.resgin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="帳號"></asp:Label><input id="Text1" type="text" name ="acount" />
    <br />
    <asp:Label ID="Label2" runat="server" Text="密碼"></asp:Label><input id="Text1" type="text" name ="password"/>
    <br />
    <asp:Label ID="Label4" runat="server" Text="再次輸入密碼"></asp:Label><input id="Text1" type="text" name ="password2"/>
    <br />
    <asp:Label ID="Label3" runat="server" Text="暱稱"></asp:Label><input id="Text1" type="text" name ="userName"/><br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="註冊新帳號" />
    <asp:Button ID="Button2" runat="server" Text="取消(回登入頁面)" OnClick="Button2_Click" />
    <br />
    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
&nbsp;<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AcountConnectionString2 %>" SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>
&nbsp;

</asp:Content>
