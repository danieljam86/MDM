<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consultageral.aspx.cs" Inherits="MDM.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Tela inicial" Width="161px" />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cadastro" Width="161px" />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Liberação Conciliação" Width="161px" />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Liberação Gerentes" Width="161px" />
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Cad Usu" Width="161px" />
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" Height="179px">
                <asp:Label ID="Label2" runat="server" Text="PENDENTES" Font-Bold="True" Font-Size="X-Large" ForeColor="#000099"></asp:Label>
                <br />
                <br />
                CONCILIAÇÃO (1ª Liberação) -
                <asp:Label ID="lblc1" runat="server" BackColor="Yellow" BorderColor="#CC0000" Font-Bold="True" ForeColor="Red"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CONCILIAÇÃO (2ª Liberação) -
                <asp:Label ID="lblc2" runat="server" BackColor="Yellow" BorderColor="#CC0000" Font-Bold="True" ForeColor="Red"></asp:Label>
                <br />
                <br />
                GERENTE (1ª Liberação) -&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblg1" runat="server" BackColor="Yellow" BorderColor="#CC0000" Font-Bold="True" ForeColor="Red"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; GERENTE (2ª Liberação) -&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblg2" runat="server" BackColor="Yellow" BorderColor="#CC0000" Font-Bold="True" ForeColor="Red"></asp:Label>
                <br />
                <br />
                PRÉVIA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -
                <asp:Label ID="lblp" runat="server" BackColor="Yellow" BorderColor="#CC0000" Font-Bold="True" ForeColor="Red"></asp:Label>
                <br />
            </asp:Panel>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Usuário que acessou: "></asp:Label>
            <asp:DropDownList ID="carteira" runat="server">
                <asp:ListItem Selected="True">TODOS</asp:ListItem>
                <asp:ListItem>ALESSANDRA</asp:ListItem>
                <asp:ListItem>CINTIA</asp:ListItem>
                <asp:ListItem>DAYANA</asp:ListItem>
                <asp:ListItem>JAIR</asp:ListItem>
                <asp:ListItem>MARLENE</asp:ListItem>
                <asp:ListItem>ANGÉLICA</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Atualizar" />
            <br />
            <br />
            <br />
            Selecione o mês e o ano para consultar:
            <asp:TextBox ID="txmes" runat="server" Width="27px"></asp:TextBox>
&nbsp;/
            <asp:TextBox ID="txano" runat="server" Width="48px"></asp:TextBox>
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="cod" OnRowCommand="GridView1_RowCommand" style="margin-top: 0px" HorizontalAlign="Center" AllowSorting="True" OnDataBound="GridView1_DataBound" OnRowDataBound="GridView1_RowDataBound" ShowFooter="True" OnRowCreated="GridView1_RowCreated">
            <Columns>
                <asp:BoundField DataField="carteira" HeaderText="Carteira" SortExpression="carteira" />
                <asp:BoundField DataField="cod" HeaderText="Cód." ReadOnly="True" SortExpression="cod">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="cond" HeaderText="Nome" SortExpression="cond"></asp:BoundField>
                <asp:BoundField DataField="dataLib" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Liberação para Conferência" SortExpression="dataLib">
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="dataLibG1" DataFormatString="{0:dd/MM/yyyy}" HeaderText="1ª Liberação Gerente" SortExpression="dataLibG1">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="dataLibP" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Liberação Prévia" SortExpression="dataLibP">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="dataLibC2" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Liberação Conciliação" SortExpression="dataLibC2">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="dataLibG2" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Visto do Gerente no Portal" SortExpression="dataLibG2">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="prioridade" HeaderText="Prioridade" SortExpression="prioridade" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <asp:SqlDataSource ID="db_mariodalmaso" runat="server" ConnectionString="<%$ ConnectionStrings:dados_mdmConnectionString %>" SelectCommand="SELECT * FROM [Liberacao] ORDER BY [carteira], [cod]"></asp:SqlDataSource>
    </form>
</body>
</html>
