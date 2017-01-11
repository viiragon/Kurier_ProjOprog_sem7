<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoNajczestsiKlienci.aspx.cs" Inherits="Kurier.Views.Menu.NajczestsiKlienci" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>Stali klienci</header>
        <article>
            <table>
                <tr>
                    <td>Id</td>
                    <td>Imię</td>
                    <td>Nazwisko</td>
                    <td>Lista paczek</td> 
                </tr>
                <asp:Repeater ID="rptKlienci" runat="server">
                    <ItemTemplate>
                         <tr>
                            <td>Id: <%# Eval("DaneKlienta.UserId") %></td>
                            <td><%# Eval("DaneKlienta.Imie") %></td>
                            <td><%# Eval("DaneKlienta.Nazwisko") %></td>
                            <td><%# Eval("LiczbaPaczek") %></td>
                        </tr>
                    </ItemTemplate>
              </asp:Repeater>
            </table>  
        </article>
    </form>
</body>
</html>
