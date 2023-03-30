<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form1.aspx.cs" Inherits="aspnewbasic.form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            ENTER NUMBER 1 :
            <asp:TextBox ID="TextBox1" runat="server" Width="127px"></asp:TextBox>
        </p>
        <p>
            ENTER NUMBER 2:<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 13px" Width="119px"></asp:TextBox>
        </p>
        <p>
            RESULT<asp:TextBox ID="TextBox3" runat="server" style="margin-left: 88px" Width="133px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="+" Width="94px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="-" Width="100px" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="*" Width="81px" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="margin-left: 13px" Text="/" Width="89px" />
        <p>
            <asp:Image ID="Image1" runat="server" />
        </p>
        <asp:DropDownList ID="DropDownList1" runat="server" >
            <asp:ListItem>chennai</asp:ListItem>
            <asp:ListItem>bangklore</asp:ListItem>
            <asp:ListItem>hyderabad</asp:ListItem>
            <asp:ListItem Value="67">kochi</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Button" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataSourceID="SqlDataSource4" ForeColor="Black" GridLines="None">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:BoundField DataField="cid" HeaderText="cid" SortExpression="cid" />
                    <asp:BoundField DataField="cname" HeaderText="cname" SortExpression="cname" />
                    <asp:BoundField DataField="cphn" HeaderText="cphn" SortExpression="cphn" />
                </Columns>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource5" runat="server"></asp:SqlDataSource>
            <asp:DataList ID="DataList1" runat="server" CellPadding="4" DataSourceID="SqlDataSource4" ForeColor="#333333">
                <AlternatingItemStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <ItemTemplate>
                    cid:
                    <asp:Label ID="cidLabel" runat="server" Text='<%# Eval("cid") %>' />
                    <br />
                    cname:
                    <asp:Label ID="cnameLabel" runat="server" Text='<%# Eval("cname") %>' />
                    <br />
                    cphn:
                    <asp:Label ID="cphnLabel" runat="server" Text='<%# Eval("cphn") %>' />
                    <br />
                    <br />
                </ItemTemplate>
                <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            </asp:DataList>
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:eyConnectionString %>" SelectCommand="SELECT * FROM [customer] WHERE ([cid] &gt; @cid)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="700" Name="cid" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:eyConnectionString %>" SelectCommand="SELECT * FROM [employee]"></asp:SqlDataSource>
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Button" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
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
            <asp:CheckBox ID="CheckBox1" runat="server" />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="SqlDataSource4" DataTextField="cname" DataValueField="cname">
            </asp:RadioButtonList>
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
        <p>
            <asp:DataList ID="DataList2" runat="server" DataSourceID="SqlDataSource5">
            </asp:DataList>
        </p>
        <p>
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource4" DataTextField="cid" DataValueField="cid">
            </asp:DropDownList>
        </p>
        <p>
            <asp:LinqDataSource ID="LinqDataSource1" runat="server">
            </asp:LinqDataSource>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="list tables" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
        </p>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        </asp:CheckBoxList>
        <asp:RadioButtonList ID="RadioButtonList2" runat="server">
        </asp:RadioButtonList>
        <asp:BulletedList ID="BulletedList1" runat="server">
        </asp:BulletedList>
    </form>
</body>
</html>
