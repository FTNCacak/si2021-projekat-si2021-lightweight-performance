<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Trainings.aspx.cs" Inherits="PresentationWeb1.Trainings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Scheduled Trainings:</h1>
    <hr />
    <asp:GridView ID="GridViewTRAINING" runat="server" Height="139px" Width="764px" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField = "Appointment" HeaderText="Appointment" />
            <asp:BoundField DataField = "FirstName" HeaderText="First Name" />
            <asp:BoundField DataField = "LastName" HeaderText="Last Name" />
            <asp:BoundField DataField = "FirstName1" HeaderText="First Name" />
            <asp:BoundField DataField = "LastName1" HeaderText="Last Name" />
            <asp:BoundField DataField = "Type" HeaderText="Type" />

        </Columns>
    </asp:GridView>
</asp:Content>
