<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Kurier.MainLauncher" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:Button Text="CENTRALA" OnClick="onClickBtCentrala" runat="server" />
            </p>
            <p>
                <asp:Button Text="KURIER" OnClick="onClickBtKurier" runat="server" />
            </p>
            <p>
                <asp:Button Text="NADAWCA" OnClick="onClickBtNadawca" runat="server" />
            </p>
        </div>
    </form>
</body>
</html>
