<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogowanieCentrali.aspx.cs" Inherits="Kurier.Views.Menu.LogowanieCentrali" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>LOGOWANIE</h1>
            <p>
                Login : <asp:TextBox runat="server"></asp:TextBox>
            </p>
            <p>
                Hasło : <asp:TextBox type="password" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button Text="Zaloguj" OnClick="onClickBtLogin" runat="server"/>
            </p>
        </div>
    </form>
</body>
</html>
