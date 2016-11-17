<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CentralaSamochody.aspx.cs" Inherits="Kurier.Views.Menu.CentralaSamochody" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>CENTRALA SAMOCHODY</h1>
        <h3>Dodaj nowy samochód</h3>
        <p>
            Nr rejestracyjny: <asp:TextBox runat="server"></asp:TextBox>
        </p>
        <p>
            Stan: <asp:TextBox runat="server"></asp:TextBox>
        </p>
        <p>
            Kurier: <asp:TextBox runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button Text="Dodaj nowy samochód" OnClick="onClickBtAddCar" runat="server"/>
        </p>
    </div>
    </form>
</body>
</html>
