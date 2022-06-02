<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GYM_PROJECT_WDDN.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    body {
        color:azure;
  background-image: url('bg.jpg');
    background-repeat: no-repeat;
    /*background-attachment: fixed;*/
    background-size: cover;
}
    h1{
        font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
        color: antiquewhite;
    }

    h3{
        font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
        color: antiquewhite;
    }
    #lblerror{
        color:red;
    }

        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>

                <h1>XYZ Gym</h1>
                <h3>Login</h3>

                Username :  <asp:TextBox ID="username" runat="server"></asp:TextBox>  <br /><br />
                Password : 
                <asp:TextBox ID="password" runat="server" type="password"></asp:TextBox>
                <br />
                <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="login" runat="server" Text="Login" OnClick="login_Click" />
                <br />
                <br />
                
                <br />
                <asp:Label ID="lblerror" runat="server" Text=" "></asp:Label>
            </center>
        </div>
    </form>
</body>
</html>
