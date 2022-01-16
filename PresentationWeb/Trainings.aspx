<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Trainings.aspx.cs" Inherits="PresentationWeb1.Trainings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Scheduled Trainings:</h1>
    <hr />
    <asp:GridView ID="GridViewTRAINING" runat="server" Height="139px" Width="764px" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField = "Appointment" HeaderText="Appointment"  />
            <asp:BoundField DataField = "MemberName" HeaderText="Member Name" />
            <asp:BoundField DataField = "EmployeeName" HeaderText="Trainer Name" />
            <asp:BoundField DataField = "Type" HeaderText="Type" />

        </Columns>    
    </asp:GridView>


    <asp:Label ID="lbl1Message" runat="server" Text="Message"></asp:Label>


    <br />




</asp:Content>
