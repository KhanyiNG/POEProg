<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="POEProg.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <h1>LOGIN</h1>

      <div class="myContainer">

    <p></p>

  

            <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label><br />
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
          <br>

              <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label><br />
             <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
           <br >
           <br >
            <asp:Button ID="Button1" class ="btns" runat="server" Text="Login" OnClick="Button1_Click1" />&nbsp;&nbsp &nbsp;&nbsp;
            <br >
          <asp:Button ID="Button2" class ="btns" runat="server" Text="Register" OnClick="Button2_Click1" />
            
 </div>
</asp:Content>
