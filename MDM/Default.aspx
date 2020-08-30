<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MDM.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel3" runat="server" Height="62px">
            </asp:Panel>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#5D7B9D" Direction="LeftToRight" Height="23px" HorizontalAlign="Center">
            <asp:Label ID="Label1" runat="server" BackColor="#5D7B9D" BorderColor="#5D7B9D" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="Tela de Login"></asp:Label>
        </asp:Panel>
                    <asp:Panel ID="Panel4" runat="server" Height="51px">
            </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="White" BorderColor="White" Height="172px" HorizontalAlign="Right" style="margin-bottom: 0px" Width="557px">
            <asp:Label ID="Label2" runat="server" Text="Nome do Usuário: " Font-Names="Bahnschrift"></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server" Width="198px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Names="Bahnschrift" Text="Senha: "></asp:Label>
            <asp:TextBox ID="txtSenha" runat="server" Width="198px" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="White" BorderColor="#5D7B9D" ForeColor="#5D7B9D" Text="Fazer Logon" Width="113px" Font-Names="Bahnschrift" OnClick="Button1_Click" />

            <br />
            <br />
            <asp:Label ID="lblmens" runat="server" ForeColor="Red"></asp:Label>

        </asp:Panel>
        <asp:Panel ID="Panel5" runat="server">
            <asp:Label ID="lblPerfil" runat="server" Enabled="False" ForeColor="#CC0000"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
