<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoSzczegolowSamochodu.aspx.cs" Inherits="Kurier.Views.Menu.OknoSzczegolowSamochodu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <h3>Szczegóły samochodu</h3>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>Id</td>
            <td>Marka</td>
            <td>Model</td>
            <td>Nr rejestracyjny</td>
            <td>stan</td>
            <td>Kurier</td>
            <td>Data kontroli</td>
            <td></td>
            <td></td>
        </tr>
        <tr>
                <td>Id: 2</td>
                <td>Peugeot</td>
                <td>Boxer</td>
                <td>PO L74B6</td>
                <td>Uszkodzony</td>
                <td>Maciej Kowalski</td>
                <td>15.03.2017</td>
                <td><asp:Button Text="Edytuj" OnClick="onClickBtCarEdit" runat="server"/></td>
                <td><asp:Button Text="Usuń" OnClick="onClickBtDelete" runat="server"/></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
