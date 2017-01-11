<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoWyslaniaZleceniaDoSerwisu.aspx.cs" Inherits="Kurier.Views.Menu.OknoWyslaniaZleceniaDoSerwisu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>CENTRALA SAMOCHODY</header>
        <article>
            <p>
                <asp:Label ID="lError" runat="server"></asp:Label>
                <asp:Label ID="lSuccess" runat="server"></asp:Label>
            </p>
            <p>
                Informacja dla serwisu: <br />
                <textarea id="tbInfo" cols="50" rows="10" runat="server"></textarea>
            </p>
            <p>
                <asp:Button Text="Wyślij" OnClick="onClickBtSend" runat="server" />
            </p>
          
        </article>
    </form>
</body>
</html>
