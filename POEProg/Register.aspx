<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="POEProg.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Site.css" rel="stylesheet" />
    <i><h1>Register</h1></i>
    <p></p>
      <asp:Label ID="lblUsers" runat="server" Text=""></asp:Label>
    <hr>
    <p></p>
            
    <asp:Label ID="Label1" runat="server" Text="Student Number:"></asp:Label>&nbsp;&nbsp &nbsp;&nbsp;
    <br>
            <asp:TextBox ID="txtStudentNo" Class="inputBoxes" runat="server"></asp:TextBox><br />


      
            <asp:Label ID="Label3" runat="server" Text="First Name:"></asp:Label>&nbsp;&nbsp &nbsp;&nbsp;
    <br>
            <asp:TextBox ID="txtFirstName" Class="inputBoxes" runat="server"></asp:TextBox><br />


            <asp:Label ID="Label4" runat="server" Text="Last Name:"></asp:Label>&nbsp;&nbsp &nbsp;&nbsp;
    <br>
            <asp:TextBox ID="txtLastName" Class="inputBoxes" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label5" runat="server" Text="Password:"></asp:Label>&nbsp;&nbsp &nbsp;&nbsp;
    <br>
            <asp:TextBox ID="txtPassword" Class="inputBoxes" runat="server"></asp:TextBox><br />

     <br>

    <asp:DropDownList ID="ddlGender" Class="inputBoxes" runat="server"></asp:DropDownList>
   
    <br>
     <br>

            <asp:Button ID="Button3" class="btns" runat="server" Text="Register" OnClick="Button3_Click"  /> &nbsp;&nbsp &nbsp;&nbsp;
            <asp:Button ID="Button1" class="btns" runat="server" Text="Login" OnClick="Button1_Click" />


</asp:Content>
