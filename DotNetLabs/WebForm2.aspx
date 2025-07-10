<!-- Create an ASP.NET web application in C# for a registration form and fill in the details. 
    When you click the submit button, it should display the details in a message box. -->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="DotNetLabs.WebForm2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 300px; margin: auto;">

            <h2>Registration Form</h2>

            <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label><br />
            <asp:TextBox ID="txtName" runat="server" /><br /><br />

            <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label><br />
            <asp:TextBox ID="txtEmail" runat="server" /><br /><br />

            <asp:Label ID="lblAge" runat="server" Text="Age:"></asp:Label><br />
            <asp:TextBox ID="txtAge" runat="server" /><br /><br />

            <asp:Label ID="lblGender" runat="server" Text="Gender:"></asp:Label><br />
            <asp:DropDownList ID="ddlGender" runat="server">
                <asp:ListItem Text="--Select--" />
                <asp:ListItem Text="Male" />
                <asp:ListItem Text="Female" />
                <asp:ListItem Text="Other" />
            </asp:DropDownList><br /><br />

            <asp:Label ID="lblCountry" runat="server" Text="Country:"></asp:Label><br />
            <asp:DropDownList ID="ddlCountry" runat="server">
                <asp:ListItem Text="--Select--" />
                <asp:ListItem Text="Nepal" />
                <asp:ListItem Text="India" />
                <asp:ListItem Text="USA" />
            </asp:DropDownList><br /><br />

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /><br /><br />

            <asp:Label ID="lblResult" runat="server" Font-Bold="true" ForeColor="Green"></asp:Label>

        </div>
    </form>
</body>
</html>
