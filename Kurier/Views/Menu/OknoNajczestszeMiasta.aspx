<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoNajczestszeMiasta.aspx.cs" Inherits="Kurier.Views.Menu.OknoNajczestszeMiasta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>Najczęstsze miasta docelowe</header>
        <article>
            <table>
                <tr>
                    <td>Miasto</td>
                    <td>Ilość paczek</td>
                </tr>
                <asp:Repeater ID="rptMiasta" runat="server">
                    <ItemTemplate>
                         <tr>
                             <td><%# Eval("NazwaObszaru") %></td>
                            <td><%# Eval("IloscPaczek") %></td>
                        </tr>
                    </ItemTemplate>
              </asp:Repeater>
            </table>  
        </article>
    </form>
</body>
</html>