<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoCentralaPaczki.aspx.cs" Inherits="Kurier.Views.Menu.CentralaPaczki" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>CENTRALA Paczki</h1>
       
       <asp:Button Text="Szczegóły" OnClick="onClickDetails" runat="server"/>
        <table>
            <asp:Repeater ID="rptPaczki" runat="server">
            <HeaderTemplate>
                <div id="divPaczki">
            </HeaderTemplate>
            <ItemTemplate>
                   <tr>
                       <td><%# Eval("Id") %></td>
                       <td>
                           <asp:Placeholder ID="placeholderBlaBlaBla" runat="server" Visible='<%# Convert.ToInt32(Eval("Status.KodStatusu")) == 1 %>'>
                               Nadana
                            </asp:Placeholder>
                           <asp:Placeholder ID="placeholder1" runat="server" Visible='<%# Convert.ToInt32(Eval("Status.KodStatusu")) == 0 %>'>
                               Doręczona
                            </asp:Placeholder>
                       </td>
                       <td><asp:Button Text="Szczegóły" OnClick="onClickDetails" runat="server"/></td>
                       <td><asp:Button Text="Kurier" OnClick="onClickKurier" runat="server"/></td>
                   </tr>
               
            </ItemTemplate>
            <AlternatingItemTemplate>   
                   <tr>
                       <td><%# Eval("Id") %></td>
                       <td>
                           <asp:Placeholder ID="placeholderBlaBlaBla" runat="server" Visible='<%# Convert.ToInt32(Eval("Status.KodStatusu")) == 0 %>'>
                               Nadana
                            </asp:Placeholder>
                           <asp:Placeholder ID="placeholder1" runat="server" Visible='<%# Convert.ToInt32(Eval("Status.KodStatusu")) == 1 %>'>
                               Doręczona
                            </asp:Placeholder>
                       </td>
                       <td><asp:Button Text="Szczegóły" OnClick="onClickDetails" runat="server"/></td>
                       <td><asp:Button Text="Kurier" OnClick="onClickKurier" runat="server"/></td>
                   </tr>
            </AlternatingItemTemplate>
            <FooterTemplate>
                </div>
            </FooterTemplate>
        </asp:Repeater>
        </table>
    </div>
    </form>
</body>
</html>
