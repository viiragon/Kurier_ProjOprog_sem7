<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoSzczegolowSamochodu.aspx.cs" Inherits="Kurier.Views.Menu.OknoSzczegolowSamochodu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>Szczegóły samochodu</header>
        <article>
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

                <asp:Repeater ID="rptSamochody" runat="server">
                    <ItemTemplate>
                         <tr>
                            <td>Id: <%# Eval("Id") %></td>
                            <td><%# Eval("Marka") %></td>
                            <td><%# Eval("Model") %></td>
                            <td><%# Eval("NumRejestracyjny") %></td>
                            <td><%# Eval("Stan") %></td>
                             <td>Maciej Kowalski</td>
                             <td><%# Eval("DataKontroli") %></td>
                            <td>
                               <asp:Button Text="Edytuj" OnClick="onClickBtCarEdit" runat="server" /></td>
                            <td>
                               <asp:Button Text="Usuń" OnClick="onClickBtDelete" runat="server" /></td>
                        </tr>
                    </ItemTemplate>
              </asp:Repeater>

           
            </table>
            <asp:Button Text="Wyślij zlecenie do serwisu" OnClick="onClickBtSend" runat="server" />
        </article>
    </form>
</body>
</html>
