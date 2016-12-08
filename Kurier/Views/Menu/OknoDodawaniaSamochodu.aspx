<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoDodawaniaSamochodu.aspx.cs" Inherits="Kurier.Views.Menu.OknoDodawaniaSamochodu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>CENTRALA SAMOCHODY</h1>
       
        <p>
            Marka: <asp:TextBox runat="server"></asp:TextBox>
        </p>
        <p>
            Model: <asp:TextBox runat="server"></asp:TextBox>
        </p>
        <p>
            Nr rejestracyjny: <asp:TextBox runat="server"></asp:TextBox>
        </p>
        <p>
            Data kontroli: <asp:TextBox runat="server"></asp:TextBox>
        </p>
        <p>
            Stan: <asp:TextBox runat="server"></asp:TextBox>
        </p>
        <p>
            Kurier: <asp:TextBox runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button Text="Zapisz" OnClick="onClickBtAddCar" runat="server"/>
        </p>
    </div>
    </form>
</body>
</html>
