<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="FormValidation.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hello Web page 1</title>
    <script>
        function chkvalidation() {
            var name = document.getElementById("<%=textbox1.ClientID %>").value;
            if (name.length == 0) {
                alert("Name field cannot be empty");
                return false;
            }
            return true;
        }

        function OnlyNumbers() {

            var digits = "0123456789";
            var temp;
            var len = document.getElementById("<%=txtMobile.ClientID%>").value.length;
            for (var i = 0; i < len; i++) {
                temp = document.getElementById("<%=txtMobile.ClientID%>").value.substring(i, i + 1);
                if (digits.indexOf(temp) == -1) {
                    alert("Please enter correct number");
                    document.getElementById("<%=txtMobile.ClientID%>").focus();
                    return false;
                }
            }
            return true;
        }

        function chkEmail() {

            var email = document.getElementById("<%=EmailID.ClientID%>").value;
            var emailExp = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([com\co\.\in])+$/;

            if (!email.match(emailExp)) {

                alert("Invalid Email");
                return false;
            }
        }
    </script>
</head>
<body>
    <h1>Hello my first page</h1>
    <form id="form1" runat="server">
        <div>
        </div>
                <label>UserName :</label>
                <input name="Textbox1" id="textbox1" runat="server" type="text" /><br />
           
                <label>Contact number</label>
                <asp:TextBox ID="txtMobile" runat="server" onkeypress="return OnlyNumbers(event)"></asp:TextBox><br />
                
                <label>Email:</label>
                <asp:TextBox ID="EmailID" placeholder="name@server.com" runat="server" onblur="chkEmail(this)"></asp:TextBox><br />
          
          <asp:Button ID="Button1" runat="server" Text="Click here" OnClick="Button1_Click" OnClientClick="return chkvalidation()"/>
      
    </form>
</body>
</html>
