<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="game1.aspx.cs" Inherits="WebApplication5.game1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    電腦出<asp:Image ID="Image1" runat="server" />
<br />

<asp:Label ID="Label2" runat="server" Text="玩家出"></asp:Label>

<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/pic/siscer.png" OnClick="ImageButton1_Click" />
<asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/pic/stone.png" OnClick="ImageButton2_Click" />
<asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/pic/paper.png" OnClick="ImageButton3_Click" />
<br />
<asp:Label ID="Label1" runat="server" Text=""></asp:Label>
<br />
<asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    <br />
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button2" runat="server" Text="傳送訊息" OnClick="Button2_Click" />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
            </asp:Timer>
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
        </Triggers>
    </asp:UpdatePanel>
<br />
<asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" />
</asp:Content>
