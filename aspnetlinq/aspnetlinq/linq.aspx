<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="linq.aspx.cs" Inherits="aspnetlinq.linq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="eid" HeaderText="eid" SortExpression="eid" />
                <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
                <asp:BoundField DataField="erole" HeaderText="erole" SortExpression="erole" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:eyConnectionString %>" SelectCommand="SELECT [eid], [ename], [erole] FROM [employee]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
    </form>
</body>
</html>
