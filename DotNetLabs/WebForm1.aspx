<!-- Write a ASP.NET program to demonstrate the concepts of labels, text box and button controls.-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DotNetLabs.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label> <br /> 
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox> <br /> <br /> 

             <asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label> <br /> 
             <asp:TextBox ID="txtAge" runat="server"></asp:TextBox> <br /> <br /> 

            <asp:Button ID="Button1" runat="server" Text="Display" OnClick="Button1_Click" /> <br /> <br /> 
            <asp:Label ID="lblDisplay" runat="server"></asp:Label> <br /> 

        </div>
    </form>
</body>
</html>
