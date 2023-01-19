<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ColorChanger.aspx.cs" Inherits="Practon12th.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Custom Statement</h3>
            <asp:Label ID="Label1" runat="server" Text="Enter Username"></asp:Label> &nbsp;
            &nbsp; &nbsp; 
            <asp:TextBox ID="TextBox1" runat="server" placeholder="username"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="color" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Red" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="color" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Green" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="True" GroupName="color" OnCheckedChanged="RadioButton3_CheckedChanged" Text="Blue" />
            <br />
            <br />
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Bold" />
            <br />
            <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Italics" />
            <br />
            <asp:CheckBox ID="CheckBox3" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox3_CheckedChanged" Text="Underline" />
            <br />
        </div>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </form>
</body>
</html>
