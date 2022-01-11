<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PresentationWeb1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <table>
        <tr><td><asp:Label ID="lbl1ID" runat="server" Text="Membership ID: "></asp:Label></td>
    <td><asp:TextBox ID="tb1ID" runat="server" Width="128px"></asp:TextBox> </td>
            </tr>

    <tr>

         <td>
    <asp:Label ID="lbl2Pass" runat="server" Text="Password:"></asp:Label></td>
    <td><asp:TextBox ID="tb2Pass"  TextMode="Password" runat="server" Width="128px"></asp:TextBox></td>
        </tr>
    </table>
        <br/>
        <br/>
        <asp:Button ID="Btn1LogIn" runat="server" Height="32px" Text="Log in" Width="236px" OnClick="Btn1LogIn_Click" />
        <br/>
        <asp:Label ID="Lbl3Message" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
