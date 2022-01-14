<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="PresentationWeb1.Info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1>Membership info:
        </h1>

    <br />

    <asp:Label ID="lbl1" runat="server" Text="Label">Membership ID:</asp:Label>
        
    <asp:Label ID="lbl1_MembershipID" runat="server" Text="Label">IDNUMBER</asp:Label>

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

    <asp:Label ID="lbl7" runat="server" Text="Label">Payment Date:</asp:Label>
        
    <asp:Label ID="lbl7PaymentDate" runat="server" Text="Label">PAYMENTDATE</asp:Label>

        
    <br />
    <asp:Label ID="lbl8" runat="server" Text="Label">Expiration Date:</asp:Label>
        
    <asp:Label ID="lbl8ExpirationDate" runat="server" Text="Label">EXPIRATIONDATE</asp:Label>
    <br />
    

    <asp:Label ID="lbl9" runat="server" Text="Label">Note:</asp:Label>
        
    <br />
    <br />

    <asp:Label ID="lbl9Note" runat="server" Text="Label"> Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur cursus consectetur maximus. Nulla et diam tincidunt, interdum sem in, eleifend felis. Proin felis nibh, lacinia a porta nec, tincidunt sit amet nisi. Nullam sit amet tortor placerat, pretium augue eget, lobortis nunc. Nam ultricies ultrices elit eu sollicitudin. In hac habitasse platea dictumst. Cras scelerisque ipsum vitae elit volutpat, vel pharetra turpis pharetra. Phasellus sollicitudin tortor sit amet mi faucibus ornare. Maecenas congue dolor nisl, quis maximus augue porta id. Aenean mollis efficitur leo, ut laoreet mi placerat placerat. Donec vitae odio bibendum, rutrum enim pharetra, dictum augue. Cras sagittis nunc felis, nec dignissim eros bibendum eget.

Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Maecenas mauris nulla, venenatis nec mauris vel, hendrerit ornare tellus. Proin porttitor tincidunt enim, et efficitur quam. Vestibulum laoreet metus id posuere elementum. Suspendisse rhoncus lectus non congue efficitur. Pellentesque ultricies efficitur quam, at imperdiet turpis pretium luctus. Maecenas in mi dolor.

Nullam placerat arcu ex, sed faucibus nisl pretium ac. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Donec nec orci blandit augue pulvinar suscipit. Suspendisse potenti. Nam a pretium augue, sit amet sodales metus. Nulla in aliquam lacus. Donec a est et odio tincidunt dapibus vel quis erat. Duis vel vestibulum nulla. Mauris rhoncus eget ligula et tristique. Nulla in neque eget sem mollis eleifend. Morbi porttitor orci non vestibulum porttitor. Maecenas ultrices semper justo. In ornare sit amet ipsum vitae eleifend.

Suspendisse augue ante, laoreet at pellentesque eget, scelerisque ut erat. Duis eget tristique purus. Etiam placerat enim ac dolor dapibus laoreet. Nunc sed pretium diam, non sodales massa. Nam non vulputate lectus, in accumsan augue. Phasellus cursus, purus aliquet vestibulum accumsan, urna tortor suscipit velit, at malesuada sem orci eu ex. Sed malesuada turpis at sagittis facilisis. Mauris ut nisi et ante tincidunt iaculis. Integer rutrum, quam at vehicula elementum, nibh mauris dignissim eros, commodo mollis nulla odio id tellus. Sed quis arcu quam. Nunc eget posuere lacus. Praesent posuere quam diam, sit amet lacinia diam laoreet non. Aenean efficitur ac orci et posuere. Suspendisse in tristique turpis, in iaculis mi. Quisque enim ex, gravida eu tempor eu, pharetra id augue. Etiam lacinia elit a metus maximus, et accumsan quam feugiat.

Donec vitae metus in nisl viverra volutpat. Curabitur vel vehicula magna. Nunc vehicula pellentesque diam nec varius. Integer dignissim non ipsum quis bibendum. Nulla facilisi. Aliquam ut molestie sapien. Phasellus id lorem eros.</asp:Label>
    <br/>
    <br/>
    <br/>
    <br/>
    <h2>Check-Ins:</h2>
    <hr />
    <asp:GridView ID="GridViewCHECKIN" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField = "CheckinDate" HeaderText="Checkin Date" />
        </Columns>
    </asp:GridView>

    <asp:Label ID="lbl1Message" runat="server" Text="Message"></asp:Label>




    <hr />
</asp:Content>
