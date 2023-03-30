<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="linqsql.aspx.cs" Inherits="linqsqlwebapplication.linqsql" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="DISPLAY" />
            <br />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            eid<br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            ename<br />
            <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            esalary<br />
            <br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            erole<br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="INSERT" />
            <br />
            <br />
            <br />
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            eid</div>
        <p>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            ename</p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="UPDATE" />
        </p>
        <p>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            eid&nbsp;</p>
        <p>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="DELETE" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
