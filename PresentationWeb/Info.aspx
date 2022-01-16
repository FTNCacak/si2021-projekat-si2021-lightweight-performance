<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="PresentationWeb1.Info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div  class="form-row">
        <div class="col-md-6 ">
            <h1>Membership info:</h1>
            <br />


            <asp:Label ID="lbl1" runat="server" Text="Label">Membership ID:</asp:Label>
            <asp:Label ID="lbl1_MembershipID" runat="server" Text="Label">IDNUMBER</asp:Label>

            <br />

            <asp:Label ID="lbl7" runat="server" Text="Label">Payment Date:</asp:Label>
            <asp:Label ID="lbl7PaymentDate" runat="server" Text="Label">PAYMENTDATE</asp:Label>

            <br />

            <asp:Label ID="lbl8" runat="server" Text="Label">Expiration Date:</asp:Label>
            <asp:Label ID="lbl8ExpirationDate" runat="server" Text="Label">EXPIRATIONDATE</asp:Label>
            
            <br />
            <hr />

            <h2>Personal Data:</h2>

            <br />
            
            <asp:Label ID="lbl2" runat="server" Text="Label">First Name:</asp:Label>
            <asp:Label ID="lbl2_FirstName" runat="server" Text="Label">FIRSTNAME</asp:Label>

            <br />

            <asp:Label ID="lbl3" runat="server" Text="Label">Last Name:</asp:Label>
            <asp:Label ID="lbl3LastName" runat="server" Text="Label">LASTNAME</asp:Label>

            <br />

            <asp:Label ID="lbl4" runat="server" Text="Label">Address:</asp:Label>
            <asp:Label ID="lbl4Address" runat="server" Text="Label">ADDRESS</asp:Label>

            <br />

            <asp:Label ID="lbl5" runat="server" Text="Label">PhoneNumber:</asp:Label>
            <asp:Label ID="lbl5PhoneNumber" runat="server" Text="Label">PHONENUMBER</asp:Label>

            <br />

            <asp:Label ID="lbl6" runat="server" Text="Label">Birth Date:</asp:Label>
            <asp:Label ID="lbl6BirthDate" runat="server" Text="Label">BIRTHDATE</asp:Label>

            <hr />

        </div>


        <div class="col-md-6 ">

            <h2>Check-Ins:</h2>

            <hr />
            <asp:GridView ID="GridViewCHECKIN" runat="server" AutoGenerateColumns="false" Width="185px" BorderColor="Transparent">
                <Columns>
                    <asp:BoundField DataField = "CheckinDate" HeaderText="Checkin Date" />
                </Columns>
            </asp:GridView>

            <asp:Label ID="lbl1Message" runat="server" Text="Message"></asp:Label>
        </div>
    </div>

    <hr />

  
</asp:Content>
