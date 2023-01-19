<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConvertUpperCase.aspx.cs" Inherits="Practon12th.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter Username"></asp:Label>
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="#FF6666" OnClick="Button1_Click" Text="UpperCase" />
        </p>
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </form>
</body>
</html>
