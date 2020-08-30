<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LiberacaoConciliacao.aspx.cs" Inherits="MDM.WebForm1" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script language=javascript>
    function ConfirmaExclusao(){
        return confirm('Deseja excluir este registro?');
    }
    </script>
    <link href="style.css" rel="stylesheet" />
</head>    
<body style="height: 479px; width: 938px;">
    <form id="form1" runat="server">
        <div style="width: 936px">
            <asp:Label ID="dataHoje" runat="server"></asp:Label>
            <br />
            <br />
            <div>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Tela inicial" Width="161px" />
                <br />
                <asp:Button ID="Button4" runat="server" OnClick="Button2_Click" Text="Cadastro" Width="161px" />
                <br />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Liberação Conciliação" Width="161px" />
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button4_Click" Text="Liberação Gerente" Width="161px" />
            </div>
            <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center" ScrollBars="Auto">
                <div style="width: 936px">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PLANILHA DE LIBERAÇÃO&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="marcaTodos" runat="server" Font-Size="Smaller" Height="26px" OnClick="marcaTodos_Click" Text="Marcar Todos" Width="120px" />
                    &nbsp;<asp:Button ID="desmarcaTodos" runat="server" Font-Size="Smaller" Height="26px" OnClick="desmarcaTodos_Click" Text="Desmacar Todos" Width="120px" />
                    <br />
                </div>
                <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataKeyNames="id" ForeColor="Black" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-right: 29px" Width="678px" OnRowDataBound="GridView1_RowDataBound">
                    <Columns>
                        <asp:BoundField DataField="Cod" HeaderText="Cod" ReadOnly="True" SortExpression="Cod" ShowHeader="False">
                        <HeaderStyle Font-Underline="False" Wrap="True" />
                        <ItemStyle Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Botão">
                            <ItemTemplate>
                                <asp:CheckBox ID="ProductSelector" runat="server" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="dataLib" HeaderText="Liberação Balancete" DataFormatString="{0:dd/MM/yyyy}" />
                        <asp:TemplateField HeaderText="Operador Anterior (Gerente e Prévia)"></asp:TemplateField>
                        <asp:TemplateField HeaderText="Botão">
                            <ItemTemplate>
                                <asp:CheckBox ID="ProductSelector2" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="dataLibC2" HeaderText="Liberação Pasta Digital" DataFormatString="{0:dd/MM/yyyy}" />
                        <asp:BoundField DataField="prioridade" HeaderText="Prioridade" />
                        <asp:TemplateField HeaderText="Pendencias"></asp:TemplateField>
                        <asp:BoundField DataField="mes" HeaderText="mes" />
                        <asp:BoundField DataField="ano" HeaderText="ano" />
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
                <asp:SqlDataSource ID="DataBase_mdm" runat="server" ConnectionString="<%$ ConnectionStrings:dados_mdmConnectionString %>" SelectCommand="SELECT [cod], [dataLib], [dataLibC2], [pendenciaC], [prioridade], [mes], [ano] FROM [Liberacao]"></asp:SqlDataSource>
                <asp:Button ID="Salvar" runat="server" OnClick="Salvar_Click" Text="Salvar - 1ª Liberação" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Salvar0" runat="server" OnClick="Salvar0_Click" Text="Salvar - 2ª Liberação" />
                <br />
                <br />
                Selecione o mês e ano da liberação:
                <asp:TextBox ID="txmes" runat="server" Width="25px">7</asp:TextBox>
                &nbsp;/
                <asp:TextBox ID="txano" runat="server" Width="54px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnpesquisar" runat="server" Text="Pesquisar" />
            </asp:Panel>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
    </form>
    
</body>
</html>
