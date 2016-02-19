<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="solarform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 368px; width: 862px">
    <form id="form1" runat="server">
        <p>
            Average Solar Energy Intensity</p>
    <div>
    
        Longitude</div>
        <p>
        <asp:TextBox ID="txt_Long" runat="server"></asp:TextBox>
        </p>
        <p>
            Latitude</p>
        <p>
            <asp:TextBox ID="txt_Lat" runat="server" style="text-align:center"></asp:TextBox>
            </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Solar Intensity" Width="366px" />
        </p>
        <p>
            &nbsp;</p>
            <asp:Label ID="solLabel" runat="server" Text="The average solar Intensity is :" style="text-align: center"></asp:Label>
        <asp:Label ID="ansL" runat="server" Text="-"></asp:Label>
        <p>
            <asp:Label ID="Label1" runat="server" Text="The solar energy panel would be"></asp:Label>
            <asp:Label ID="ansLabel" runat="server" Text="-"></asp:Label>
        </p>
    </form>
</body>
</html>
