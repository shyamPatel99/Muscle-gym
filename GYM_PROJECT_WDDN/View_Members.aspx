<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Members.aspx.cs" Inherits="GYM_PROJECT_WDDN.View_Members" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            margin-left: 0px;
        }

        body {
        color:azure;
  background-image: url('bg.jpg');
    background-repeat: no-repeat;
    /*background-attachment: fixed;*/
    background-size: cover;
}
        th, td {
  border-bottom: 1px solid #ddd;
}

        .GridView1{
  display: grid;
  justify-content: space-evenly;
}


    </style>
</head>
<body>
    <form id="form1" runat="server">
        <header style="float:right;">
            <asp:Button runat="server" ID="btn_logout" Text="Logout" OnClick="btn_logout_Click"/>
            </header>
        <div>
            <h2 align="center">Gym Members</h2>
                        <asp:GridView ID="GridView1" runat="server" Height="180px" Width="701px" AlternatingRowStyle-Font-Bold="true" BorderStyle="Double">
                        </asp:GridView>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Edit_Registration" CssClass="auto-style2" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
            </div>
    </form>
</body>
</html>