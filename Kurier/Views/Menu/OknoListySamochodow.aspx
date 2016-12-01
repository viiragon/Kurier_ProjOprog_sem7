<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoListySamochodow.aspx.cs" Inherits="Kurier.Views.Menu.OknoListySamochodow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
            <td>Id</td>
            <td>Marka</td>
            <td>Model</td>
            <td>Nr rejestracyjny</td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
            <tr>
                <td>Id: 1</td>
                <td>Citroen</td>
                <td>Jumper</td>
                <td>PO 6478A</td>
                <td><asp:Button Text="Szczegóły" OnClick="onClickBtCarDetails" runat="server"/></td>
                <td><asp:Button Text="Edytuj" OnClick="onClickBtCarEdit" runat="server"/></td>
                <td><asp:Button Text="Usuń" OnClick="onClickBtDelete" runat="server"/></td>
            </tr>
             <tr>
                <td>Id: 2</td>
                <td>Peugeot</td>
                <td>Boxer</td>
                <td>PO L74B6</td>
                <td><asp:Button Text="Szczegóły" OnClick="onClickBtCarDetails" runat="server"/></td>
                <td><asp:Button Text="Edytuj" OnClick="onClickBtCarEdit" runat="server"/></td>
                <td><asp:Button Text="Usuń" OnClick="onClickBtDelete" runat="server"/></td>
            </tr>
        </table>
        <p><asp:Button Text="Dodaj nowy samochód" OnClick="onClickBtAddCar" runat="server"/></p>
        <p><asp:Button Text="Wyślij zlecenie do serwisu" runat="server"/></p>
    </div>
    </form>
</body>
</html>
