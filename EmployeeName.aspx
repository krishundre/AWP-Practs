<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeName.aspx.cs" Inherits="Practon12th.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" SelectionMode="Multiple">
                <asp:ListItem>Krish</asp:ListItem>
                <asp:ListItem>Jack</asp:ListItem>
                <asp:ListItem>Ross</asp:ListItem>
                <asp:ListItem>Rachel</asp:ListItem>
                <asp:ListItem>Pheeby</asp:ListItem>
                <asp:ListItem>Gunther</asp:ListItem>
                <asp:ListItem>Chandler</asp:ListItem>
                <asp:ListItem>Joey</asp:ListItem>
                <asp:ListItem>Emily</asp:ListItem>
                <asp:ListItem>Pam</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" placeholder="output" TextMode="MultiLine"></asp:TextBox>
        </div>
    </form>
</body>
</html>
