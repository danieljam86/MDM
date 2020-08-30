<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastrocond.aspx.cs" Inherits="MDM.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadatro de Clientes</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    <link href="style.css" rel="stylesheet" />
</head>
    <script src="Scripts/jquery-1.9.1.min.js"></script> 
    <script src="Scripts/bootstrap.min.js"></script> 
<body>
    <form id="form1" runat="server">    
        <div style="height: 257px">
            <div>
                <asp:Button ID="Button1" CssClass="Button1" runat="server" OnClick="Button1_Click" Text="Tela inicial" Width="161px" />
                <br />
                <asp:Button ID="Button4" runat="server" OnClick="Button2_Click" Text="Cadastro" Width="161px" style="right: 526px; top: 50px" />
                <br />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Liberação Conciliação" Width="161px" />
                <br />
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Liberação Gerente" Width="161px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            </div>
            <asp:Panel ID="Panel2" runat="server" BackColor="#F7F7DE" Height="105px" HorizontalAlign="Center" Width="831px">
                <asp:Label ID="Label7" runat="server" BorderColor="Black" Text="Cadastro Competência"></asp:Label>
                <br />
                <br />
                Selecione o mês e ano:&nbsp;
                <asp:TextBox ID="txpmes" runat="server" Width="29px"></asp:TextBox>
                &nbsp;/
                <asp:TextBox ID="txpano" runat="server" Width="47px"></asp:TextBox>
                &nbsp;
                <asp:Button ID="Button6" runat="server" BackColor="White" ForeColor="#3399FF" OnClick="Button6_Click" Text="Salvar" Width="66px" />
                <br />
            </asp:Panel>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        </div>
        <asp:Panel ID="Panel3" runat="server" BackColor="White" Height="363px" HorizontalAlign="Center" Width="837px">
            <asp:Label ID="Label8" runat="server" Text="Cadastro Individual"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Código: "></asp:Label>
            <asp:TextBox ID="txbcod" runat="server" Width="85px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="Condomínio: "></asp:Label>
            <asp:TextBox ID="txbcond" runat="server" Height="25px" Width="243px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Text="Carteira: "></asp:Label>
            <asp:TextBox ID="txbgerente" runat="server" Width="243px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label12" runat="server" Text="Prioridade: "></asp:Label>
            <asp:TextBox ID="txPrioridade" runat="server" Width="243px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label13" runat="server" Text="Competência: "></asp:Label>
            <asp:TextBox ID="txmes" runat="server" Width="44px"></asp:TextBox>
            &nbsp;<asp:Label ID="Label6" runat="server" Font-Bold="True" Text="/"></asp:Label>
            &nbsp;<asp:TextBox ID="txano" runat="server" Width="76px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btCadastrar" runat="server" OnClick="btCadastrar_Click" Text="Cadastrar" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server" Height="497px" HorizontalAlign="Justify" Width="826px">
            <asp:GridView ID="gvCadCond" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" HorizontalAlign="Center" Width="706px" DataKeyNames="id">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" InsertVisible="False" ReadOnly="True" />
                    <asp:BoundField DataField="cod" HeaderText="cod" SortExpression="cod" />
                    <asp:BoundField DataField="cond" HeaderText="cond" SortExpression="cond" />
                    <asp:BoundField DataField="carteira" HeaderText="carteira" SortExpression="carteira" />
                    <asp:BoundField DataField="prioridade" HeaderText="prioridade" SortExpression="prioridade" />
                    <asp:BoundField DataField="mes" HeaderText="mes" SortExpression="mes" />
                    <asp:BoundField DataField="ano" HeaderText="ano" SortExpression="ano" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
            <asp:SqlDataSource ID="baseLib" runat="server" ConnectionString="<%$ ConnectionStrings:dados_mdmConnectionString %>" SelectCommand="SELECT [id], [cod], [cond], [carteira], [prioridade], [mes], [ano] FROM [BaseLiberacao]"></asp:SqlDataSource>
        </asp:Panel>
        <br />
        <br />
    </form>
</body>
</html>
