<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastrogeralpastas.aspx.cs" Inherits="MDM.cadastrogeralpastas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 37px">
        </div>
        <asp:Label ID="Label1" runat="server" Text="Cadastro Geral de Liberação"></asp:Label>
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="159px" Width="425px">
            <asp:Label ID="Label6" runat="server" Text="Competência"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Mês: "></asp:Label>
            <asp:TextBox ID="txbMes" runat="server" Width="40px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Ano: "></asp:Label>
            <asp:TextBox ID="txbAno" runat="server" Width="59px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Cadastrar" OnClick="Button1_Click" />
        </asp:Panel>
        <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </form>
</body>
</html>
