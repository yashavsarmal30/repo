<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="DBConnect.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          Name:-<asp:TextBox ID="tbName" runat="server"></asp:TextBox>  
        <br /> Department:-<asp:TextBox ID="tbdept" runat="server"></asp:TextBox>  
        <br /> City:-<asp:TextBox ID="tbcity" runat="server"></asp:TextBox>  
        <br /> Salary:-<asp:TextBox ID="tbsal" runat="server"></asp:TextBox>  
        <br />
      <asp:Button ID="Register" runat="server" OnClick="Register_Click" Text="Registration" />  
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RegConnectionString %>" ProviderName="<%$ ConnectionStrings:RegConnectionString.ProviderName %>" SelectCommand="SELECT [name], [department], [city], [Salary] FROM [Employee]"></asp:SqlDataSource>
    </form>
</body>
</html>
