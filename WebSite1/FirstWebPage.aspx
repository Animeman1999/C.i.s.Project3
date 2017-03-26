<%@ Page Language="VB" AutoEventWireup="false" CodeFile="FirstWebPage.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 200px;
            height: 200px;
        }
        .auto-style2 {
            text-align: center;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <p class="auto-style2">
            Welcome to Wacky Tabs</p>
        <p class="auto-style2">
            <asp:Button ID="StartButton" runat="server" BackColor="#66FF99" Font-Bold="True" Height="80px" Text="Start" Width="160px" />
        </p>
        <p>
        <asp:Button ID="Button1" Visible ="False" runat="server" Text="Enter Your Name:" />
        <asp:TextBox ID="TextBox1" Visible ="False" runat="server"></asp:TextBox>
        </p>
    <p>
        &nbsp;</p>
    
        <asp:Button ID="Tab1Button" Visible ="False" runat="server" BackColor="#FFFFCC" BorderColor="#FFFFCC" Height="65px" Text="1 One 1" Width="163px" />
        <asp:Button ID="Tab2Button" Visible ="False" runat="server" BackColor="#FFFFCC" BorderColor="#FFFFCC" height="65px" Text="2 Two 2" width="163px" />
        <asp:Button ID="Tab3Button" Visible ="False" runat="server" BackColor="#FFFFCC" BorderColor="#FFFFCC" height="65px" Text="3 Tab 3" width="163px" />
       
        <asp:Panel ID="Tab1Panel" Visible ="False" runat="server">
            <asp:Label ID="Label1" runat="server" ForeColor="DarkBlue" align="middle" Text="."></asp:Label>
            <br />
            <img alt="One" class="auto-style1"  src="http://images.clipartpanda.com/number-one-clipart-847-blue-number-one-clip-art.png" />
            <asp:Button ID="ButtonInTab1" Visible ="False" runat="server" Text="Enter your Location:" Width="242px" />
            <asp:TextBox ID="TextBoxInTab1" Visible ="False" runat="server"></asp:TextBox>
            <br />
            <br />
        </asp:Panel>
        <asp:Panel ID="Tab2Panel" Visible ="False" runat="server">
            <asp:Label ID="Label2" runat="server" ForeColor="DarkBlue" Text="."></asp:Label>
            <br />
            <img alt="One" class="auto-style1" src="https://img.clipartfest.com/793e850a38ae570c9675694c556d5182_767bf05949e4a4b5cdcaf00a4e9382-clipart-two_300-300.png" />
            <asp:Button ID="ButtonInTab2" Visible ="False" runat="server" Text="Enter an Author:" />
            <asp:TextBox ID="TextBoxInTab2" Visible ="False" runat="server"></asp:TextBox>
            <br />
            <br />
        </asp:Panel>
        <asp:Panel ID="Tab3Panel" Visible ="False" runat="server">
            <asp:Label ID="Label3" runat="server" ForeColor="DarkBlue" Text="."></asp:Label>
            <br />
            <img alt="One" class="auto-style1"  src="http://cdn.mysitemyway.com/etc-mysitemyway/icons/legacy-previews/icons-256/blue-jelly-icons-alphanumeric/069575-blue-jelly-icon-alphanumeric-n3-solid.png" />
            <asp:Label ID="LabelInsideTab3" Visible ="False" runat="server" Text="."></asp:Label>
            <asp:Button ID="Tab3YesButton" Visible ="False" runat="server" Text="Yes" />
            <asp:Button ID="Tab3NoButton" Visible ="False" runat="server" Text="No" />
            <br />
            <br />
        </asp:Panel>
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
