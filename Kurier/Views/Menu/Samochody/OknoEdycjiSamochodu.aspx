<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoEdycjiSamochodu.aspx.cs" Inherits="Kurier.Views.Menu.OknoEdycjiSamochodu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>Edycja samochodu</header>
        <article>
            <p>
                <asp:Label ID="lError" runat="server"></asp:Label>
            </p>
            <asp:Repeater ID="rptSamochody" runat="server">
                    <ItemTemplate>
            <p>
                Marka:  
                <asp:TextBox runat="server" Text='<%# Eval("Marka") %>'></asp:TextBox>
            </p>
            <p>
                Model:
                <asp:TextBox  runat="server" Text='<%# Eval("Model") %>'></asp:TextBox>
            </p>
            <p>
                Nr rejestracyjny:
                <asp:TextBox  runat="server" Text='<%# Eval("NumRejestracyjny") %>'></asp:TextBox>
            </p>
            <p>
                Data kontroli:
                <asp:TextBox runat="server" Text='<%# Eval("DataKontroli") %>'></asp:TextBox>
            </p>
            <p>
                Stan:
                <asp:TextBox runat="server" Text='<%# Eval("Stan") %>'></asp:TextBox>
            </p>
            <p>
                Kurier:
                <asp:TextBox runat="server"></asp:TextBox>
            </p>
           
                    </ItemTemplate>
              </asp:Repeater>
            <p>
                <asp:Button Text="Zapisz" OnClick="onClickSave" runat="server" />
            </p> 
        </article>
    </form>
</body>
</html>
