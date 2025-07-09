<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="DotNetLabs.WebForm3" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Factorial / Prime / Series</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:300px; margin:auto;">
            <h2>Number Operations</h2>

            <asp:Label ID="lblInput" runat="server" Text="Enter a number:"></asp:Label><br />
            <asp:TextBox ID="txtInput" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="btnFactorial" runat="server" Text="Factorial" OnClick="btnFactorial_Click" />
            <asp:Button ID="btnPrime" runat="server" Text="Prime" OnClick="btnPrime_Click" />
            <asp:Button ID="btnFactorialSeries" runat="server" Text="Factorial Series" OnClick="btnFactorialSeries_Click" /><br /><br />

            <asp:TextBox ID="txtOutput" runat="server" ReadOnly="true" Width="250px" TextMode="MultiLine" Rows="5"></asp:TextBox>
        </div>
    </form>
</body>
</html>
