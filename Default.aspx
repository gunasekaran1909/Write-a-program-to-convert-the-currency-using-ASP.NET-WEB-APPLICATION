<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CurrencyConverterWebApp.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Currency Converter</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Currency Converter</h1>
            <label for="ddlSourceCurrency">Source Currency:</label>
            <asp:DropDownList ID="ddlSourceCurrency" runat="server">
                <asp:ListItem Text="USD" Value="USD" />
                <asp:ListItem Text="EUR" Value="EUR" />
                <asp:ListItem Text="INR" Value="INR" />
            </asp:DropDownList>
            <br />
            <label for="ddlTargetCurrency">Target Currency:</label>
            <asp:DropDownList ID="ddlTargetCurrency" runat="server">
                <asp:ListItem Text="USD" Value="USD" />
                <asp:ListItem Text="EUR" Value="EUR" />
                <asp:ListItem Text="INR" Value="INR" />
            </asp:DropDownList>
            <br />
            <label for="txtAmount">Amount:</label>
            <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnConvert" runat="server" Text="Convert" OnClick="btnConvert_Click" />
            <br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
