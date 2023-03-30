<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="records.aspx.cs" Inherits="aspnewbasic.records" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            RECORDS OF EMPLOYEE<br />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="DISPLAY RECORDS" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="INSERT" Width="55px" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="margin-left: 50px" Text="DELETE" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="margin-left: 52px" Text="UPDATE" />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="201px" Visible="False">
            <asp:Label ID="Label1" runat="server" Text="INSERT DATA TO EMPLOYEE"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="eid"></asp:Label>
            <asp:TextBox ID="eid" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 64px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="ename"></asp:Label>
            <asp:TextBox ID="ename" runat="server" style="margin-left: 47px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="insert" />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="304px" Visible="False">
            <asp:Label ID="Label5" runat="server" Text="DELETE A RECORD"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="eid"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="eidd" runat="server"></asp:TextBox>
            &nbsp;<br />
            <br />
            <br />
&nbsp;<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="delete" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /><br /><br /></asp:Panel>
        <asp:Panel ID="Panel3" runat="server" Visible="False" Height="756px">
            <asp:Label ID="Label7" runat="server" Text="UPDATE "></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="eid"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="ename"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button7" runat="server" Text="update" OnClick="Button7_Click" />
            <br />
        </asp:Panel>
        <br />
    </form>
</body>
</html>
