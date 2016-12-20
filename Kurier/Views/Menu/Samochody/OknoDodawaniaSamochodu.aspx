<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoDodawaniaSamochodu.aspx.cs" Inherits="Kurier.Views.Menu.OknoDodawaniaSamochodu" %>

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
            </p>
            <p>
                Marka:
                <asp:TextBox ID="tbMarka" runat="server"></asp:TextBox>
            </p>
            <p>
                Model:
                <asp:TextBox ID="tbModel" runat="server"></asp:TextBox>
            </p>
            <p>
                Nr rejestracyjny:
                <asp:TextBox ID="tbNumRej" runat="server"></asp:TextBox>
            </p>
            <p>
                Data kontroli:
                <asp:TextBox ID="tbDataKont" runat="server"></asp:TextBox>
            </p>
            <p>
                Stan:
                <asp:TextBox ID="tbStan" runat="server"></asp:TextBox>
            </p>
            <p>
                Kurier:
                <asp:TextBox ID="tbKurier" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button Text="Zapisz" OnClick="onClickSave" runat="server" />
            </p>
          
        </article>
    </form>
</body>
</html>
