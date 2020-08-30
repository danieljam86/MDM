<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="MDM.CadastroUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-top: 15px">
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Cadastro de Usuários"></asp:Label>
            <br />
        </div>
            <asp:Panel ID="Panel1" runat="server" Height="217px" HorizontalAlign="Center">
                <asp:Label ID="Label1" runat="server" Text="Login: "></asp:Label>
                <asp:TextBox ID="login" runat="server" Width="126px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Nome: "></asp:Label>
                <asp:TextBox ID="nome" runat="server" Width="126px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Senha: "></asp:Label>
                <asp:TextBox ID="senha" runat="server" Width="126px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Perfil: "></asp:Label>
                <asp:DropDownList ID="ddlPerfil" runat="server" Height="22px" Width="126px">
                    <asp:ListItem Selected="True">Selecione</asp:ListItem>
                    <asp:ListItem>ADM</asp:ListItem>
                    <asp:ListItem>GERAL</asp:ListItem>
                    <asp:ListItem>ALESSANDRA</asp:ListItem>
                    <asp:ListItem>CINTIA</asp:ListItem>
                    <asp:ListItem>DAYANA</asp:ListItem>
                    <asp:ListItem>JAIR</asp:ListItem>
                    <asp:ListItem>MAILTON</asp:ListItem>
                    <asp:ListItem>MARLENE</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="Button6" runat="server" Text="Salvar" OnClick="Button6_Click" />
        </asp:Panel>
            <br />
            <asp:Panel ID="Panel2" runat="server" Height="197px" HorizontalAlign="Center" ScrollBars="Auto">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="mdmadm" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" HorizontalAlign="Center" Width="713px">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="login_" HeaderText="login_" SortExpression="login_" />
                        <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" />
                        <asp:BoundField DataField="senha" HeaderText="senha" SortExpression="senha" />
                        <asp:BoundField DataField="perfil" HeaderText="perfil" SortExpression="perfil" />
                    </Columns>
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
                <asp:SqlDataSource ID="mdmadm" runat="server" ConnectionString="<%$ ConnectionStrings:mdmadmConnectionString %>" SelectCommand="SELECT * FROM [usuarios]"></asp:SqlDataSource>
        </asp:Panel>
    </form>
</body>
</html>
