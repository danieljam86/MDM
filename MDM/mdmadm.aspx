<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mdmadm.aspx.cs" Inherits="MDM.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Usuário: "></asp:Label>
        <asp:Label ID="usuario" runat="server"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Data: "></asp:Label>
        <asp:Label ID="data" runat="server"></asp:Label>
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center">
            <asp:Label ID="Label3" runat="server" Text="Selecione clicando no botão abaixo" BackColor="White" BorderColor="Black" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" ForeColor="Black"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="68px">
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" Height="49px" HorizontalAlign="Center" style="margin-bottom: 0px">
            <asp:Button ID="Button1" runat="server" Text="Liberação Pastas" Font-Bold="True" Font-Size="X-Large" Height="49px" OnClick="Button1_Click" Width="494px" />
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server" Height="49px" HorizontalAlign="Center" style="margin-bottom: 0px">
            <asp:Button ID="Button2" runat="server" Text="Consulta Geral" Font-Bold="True" Font-Size="X-Large" Height="49px" OnClick="Button2_Click" Width="494px" />
        </asp:Panel>
        <asp:Panel ID="Panel5" runat="server" Height="49px" HorizontalAlign="Center" style="margin-bottom: 0px">
            <asp:Button ID="Button3" runat="server" Text="Cadastro Liberação" Font-Bold="True" Font-Size="X-Large" Height="49px" OnClick="Button3_Click" Width="494px" />
        </asp:Panel>
        <asp:Panel ID="Panel6" runat="server" Height="49px" HorizontalAlign="Center" style="margin-bottom: 0px">
            <asp:Button ID="Button4" runat="server" Text="Cadastro de Usuários" Font-Bold="True" Font-Size="X-Large" Height="49px" OnClick="Button4_Click" Width="494px" />
        </asp:Panel>
    </form>
</body>
</html>
