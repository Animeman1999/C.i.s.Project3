<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="Default2" %>

<%--Jeffrey Martin
Project 3 Tabs

This is the html file used for the program. It is a single page program used do demonstrate tabs.--%>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Wacky Tabs</title>
    <style type="text/css"></style>
        
     <%--Style sheet used for this page --%>  
    <link href="Layout.css" rel="stylesheet" type="text/css" />

</head>

<body>

    <form id="form1" runat="server">
        
        <%--The heading that is visible at start up.--%>
            <div id="banner">

                <h1> Welcome to Wacky Tabs</h1>

            </div>

        <p class="auto-style2">

           <%-- Start button that is only visible at start up until it is pressed, than the tabbed panel will be visable.--%>
            <asp:Button ID="StartButton" runat="server" BackColor="#66FF99" Font-Bold="True" Height="80px" Text="Start" Width="160px" />

        </p>

        <p>

        <%--After the name is enterd here it will enable the items other than the Picture to be visable. The name entered here will be placed into
            each of the informaiton labels on each panel conctinated with unique text.--%>
        <asp:Button ID="EnterNameButton" Visible ="False" runat="server" Text="Enter Your Name:" />
        <asp:TextBox ID="NameTextBox" Visible ="False" runat="server"></asp:TextBox>


        </p>

        <p> </p>
    
        <%--The buttons used as tabs. Not in <p> so that it will be butted up againes the panels--%>
        <asp:Button ID="Tab1Button" Visible ="False" runat="server" Height="65px" Text="1 One 1" Width="163px" CssClass="TabButtons" BorderStyle="None"/>
        <asp:Button ID="Tab2Button" Visible ="False" runat="server" height="65px" Text="2 Two 2" width="163px" CssClass="TabButtons" BorderStyle="None"/>
        <asp:Button ID="Tab3Button" Visible ="False" runat="server" height="65px" Text="3 Tab 3" width="163px" CssClass="TabButtons" BorderStyle="None"/>
       
        <%--The panels used to desplay the output for each tab. Each panel will have an information label to output information and a picture.  The first two panels (Tab1Panel and Tab2Panel)
            als have a textbox and buttuon used to enter the data and start an event handler that will concatinate the information label with additional text. The final panel(Tab3Pane) has
            an aditional label that asks a quesiton and a button for a yes repson and a button for a no response that when pressed willconcatinate the information label with a response
            based on if yes or no was pressed.--%>
        <asp:Panel ID="Tab1Panel" Visible ="False" runat="server" CssClass="Panel">

            <asp:Label ID="InformationLabel1" runat="server" align="middle" CssClass="InsideTabLabels"></asp:Label>
            <br />
            <br />
            <img alt="One" class="auto-style1"  src="http://images.clipartpanda.com/number-one-clipart-847-blue-number-one-clip-art.png" />
            <asp:Button ID="ButtonInPanel1" Visible ="False" runat="server" Text="Enter your Location:" Width="242px" />
            <asp:TextBox ID="TextBoxInPanel1" Visible ="False" runat="server"></asp:TextBox>
            <br />
            <br />

        </asp:Panel>

        <asp:Panel ID="Tab2Panel" Visible ="False" runat="server" CssClass="Panel">

            <asp:Label ID="InformationLabel2" runat="server" CssClass="InsideTabLabels"></asp:Label>
            <br />
            <br />
            <img alt="One" class="auto-style1" src="https://img.clipartfest.com/793e850a38ae570c9675694c556d5182_767bf05949e4a4b5cdcaf00a4e9382-clipart-two_300-300.png" />
            <asp:Button ID="ButtonInPanel2" Visible ="False" runat="server" Text="Enter an Author:" />
            <asp:TextBox ID="TextBoxInPanel2" Visible ="False" runat="server"></asp:TextBox>
            <br />
            <br />

        </asp:Panel>

        <asp:Panel ID="Tab3Panel" Visible ="False" runat="server" CssClass="Panel">

            <asp:Label ID="InformationLabel3" runat="server" CssClass="InsideTabLabels"></asp:Label>
            <br />
            <br />
            <img alt="One" class="auto-style1"  src="http://cdn.mysitemyway.com/etc-mysitemyway/icons/legacy-previews/icons-256/blue-jelly-icons-alphanumeric/069575-blue-jelly-icon-alphanumeric-n3-solid.png" />
            <asp:Label ID="QuestionLabelInsidePanel3" Visible ="False" runat="server" Text="."></asp:Label>
            <asp:Button ID="Panel3YesButton" Visible ="False" runat="server" Text="Yes" />
            <asp:Button ID="Panel3NoButton" Visible ="False" runat="server" Text="No" />
            <br />
            <br />

        </asp:Panel>

    </form>

    <p></p>

</body>

</html>
