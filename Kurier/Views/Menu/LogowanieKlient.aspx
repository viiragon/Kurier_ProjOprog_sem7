<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogowanieKlient.aspx.cs" Inherits="Kurier.Views.Menu.LogowanieKlient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Logowanie Klient</h1>
            <p>
                <asp:Label ID="lError" runat="server"></asp:Label>    
            </p>
            <p>
                Login : <asp:TextBox ID="tbLogin" runat="server"></asp:TextBox>
            </p>
            <p>
                Hasło : <asp:TextBox ID="tbPassword" type="password" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button Text="Zaloguj" OnClick="onClickBtLogin" runat="server"/>
            </p>
            <p>
                <asp:Button Text="Nadaj paczkę bez logowania" OnClick="onClickBtNoLogin" runat="server"/>
            </p>
        </div>
    </form>
</body>
</html>
