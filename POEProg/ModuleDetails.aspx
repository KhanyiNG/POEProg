<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModuleDetails.aspx.cs" Inherits="POEProg.ModuleDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Module Details</h1>

            <asp:Label ID="Label1" runat="server" Text="Module Code:"></asp:Label>&nbsp;&nbsp &nbsp;&nbsp;
    <br>
            <asp:TextBox ID="txtModuleCode" runat="server"></asp:TextBox><br />
       
            <asp:Label ID="Label3" runat="server" Text="Module Name:"></asp:Label>&nbsp;&nbsp &nbsp;&nbsp;
    <br>
            <asp:TextBox ID="txtModulename" runat="server"></asp:TextBox><br />


            <asp:Label ID="Label5" runat="server" Text="Module Credit:"></asp:Label>&nbsp;&nbsp &nbsp;&nbsp;
     <br>
            <asp:TextBox ID="txtModuleCredit" runat="server"></asp:TextBox><br />


            <asp:Label ID="Label6" runat="server" Text="Starting Date:"></asp:Label>&nbsp;&nbsp &nbsp;&nbsp;
     <br>
            <asp:TextBox ID="txtStartingDate" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label7" runat="server" Text="Number Of Weeks:"></asp:Label>&nbsp;&nbsp &nbsp;&nbsp;
     <br>
            <asp:TextBox ID="txtNumberOfWeeks" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label8" runat="server" Text="Class Hours Per Week:"></asp:Label>&nbsp;&nbsp &nbsp;&nbsp;
     <br >
            <asp:TextBox ID="txtclassHoursPerWeek" runat="server"></asp:TextBox><br />
     

     <asp:Button ID="Button2" runat="server" Text="ADD" OnClick="Button2_Click" /> 


</asp:Content>
