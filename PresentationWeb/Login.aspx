<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PresentationWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    


    <div>
        <h1 style="text-align:center">
            Lightweight Performance<br />Personal Account</h1>
    </div>



    <div class="container jumbotron" style=" background:url('Background_Dark.gif'); width: 60rem; height :30rem;">
        <div class="form-row">
            <div class="col-md-4">
                <asp:Label ID="lbl1ID" runat="server" Text="Membership ID: " ></asp:Label>
            </div>
            

            <div class="col-md-8">
                <asp:TextBox ID="tb1ID" runat="server" Width="256px" ForeColor="Black"></asp:TextBox>
            </div>
        </div>




        <div class="form-row">
            <div class="col-md-4">
                <div style="height: 13px;"></div>
                <asp:Label ID="lbl2Pass" runat="server" Text="Password:" ></asp:Label>
            </div>


            <div class="col-md-8">
                <div style="height: 13px;"></div>
                <asp:TextBox ID="tb2Pass"  TextMode="Password" runat="server" Width="256px" ForeColor="Black"></asp:TextBox>
            </div>
        </div>

        <div class="col-md-2"> </div>

        <div class="col-md-8">
                <div style="height: 50px;">
                    
                </div>
                <asp:Button ID="Btn1LogIn" runat="server" Height="32px" Text="Log in" Width="300px" OnClick="Btn1LogIn_Click" style=" background:url('Background_Light.gif');"/>
                <div style="height: 20px;"></div>
            <asp:Label ID="Lbl3Message" runat="server" Text="Label"></asp:Label>

            </div>
    </div>
</asp:Content>
