<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculate.aspx.cs" Inherits="webservices.calculate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="enter a value"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="enter b value"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
            &nbsp;addition result<br />
            <br />
            <asp:Label ID="Label4" runat="server"></asp:Label>
        &nbsp;subtraction result<br />
            <br />
            <asp:Label ID="Label5" runat="server"></asp:Label>
&nbsp;multiplication result<br />
            <br />
            <asp:Label ID="Label6" runat="server"></asp:Label>
&nbsp;division result</div>
    </form>
</body>
</html>
