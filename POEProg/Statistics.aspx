<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Statistics.aspx.cs" Inherits="POEProg.Statistics" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p></p>

    
<asp:Chart ID="Chart1" runat="server" BackColor="Silver" BackGradientStyle="Center" OnLoad="Chart1_Load" Height="476px" Width="631px">
     <Titles>
            <asp:Title Text="Statistics"></asp:Title>
        </Titles>
    <Series>
       <asp:Series Name="Series1" XValueMember="firstName" YValueMembers="salary" ChartArea="ChartArea1" ChartType="Column"></asp:Series>
    </Series>
    <ChartAreas>
         <asp:ChartArea Name="ChartArea1">

                <AxisX Title="Hours"></AxisX> 
                <AxisY Title="Modules"></AxisY>
             </asp:ChartArea>
    </ChartAreas>
</asp:Chart>
      <hr>
    <p></p>

    <asp:DropDownList ID="ddlStudents" runat="server"></asp:DropDownList>
</asp:Content>