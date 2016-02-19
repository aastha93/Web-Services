<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="CrimeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 988px;
            width: 1048px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="CRIME DATA"></asp:Label>
    
    </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Longitude"></asp:Label>
        </p>
        <asp:TextBox ID="txt_Long" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Latitude"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txt_Lat" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btn_Crime" runat="server" Text="Get Crime Data" OnClick="btn_Crime_Click" />
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Robbery"></asp:Label>
        </p>
        <p>
            <asp:Label ID="crLabel" runat="server" Text="-"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Rape"></asp:Label>
        </p>
        <p>
            <asp:Label ID="rpLabel" runat="server" Text="-"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Burglary"></asp:Label>
        </p>
        <p>
            <asp:Label ID="bglLabel" runat="server" Text="-"></asp:Label>
        </p>
        <p>
            Larceny Theft</p>
        <p>
            <asp:Label ID="ltLabel" runat="server" Text="-"></asp:Label>
        </p>
    </form>
</body>
</html>
