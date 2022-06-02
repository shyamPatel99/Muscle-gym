<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GYM_PROJECT_WDDN.Register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            background-image: url('bg.jpg');
            color : white;
        }
    </style>
     <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.js"></script>
    <script>
        $(document).ready(function () {
            $("#txt_repwd").keyup(validate);
        });


        function validate() {
            var txt_pwd = $("#txt_pwd").val();
            var txt_repwd = $("#txt_repwd").val();



            if (txt_pwd == txt_repwd) {
                $("#validate-status").text("valid Password");
            }
            else {
                $("#validate-status").text("invalid Password");
            }

        }

    </script>
</head>
<body style="height: 538px">
        
        <form runat="server" id="mem_form" action="#">
            <header style="float:right;">
            <asp:Button runat="server" ID="btn_logout" Text="Logout" OnClick="btn_logout_Click"/>
            </header>
            <div id="container">
                <center>
                    <h1>Membership</h1>
                    <table class="reg_table">
                        
                        <tr>
                            <td class="style_td"><!-- ID : --></td>
                            <td>
                                <asp:TextBox ID="txt_id" runat="server" ReadOnly="true" AutoPostBack="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style_td">Name :</td>
                            <td>
                                <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style_td">Address :</td>
                            <td>                                
                                <asp:TextBox ID="txt_Address" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style_td">Contact :</td>
                            <td>                                
                                <asp:Textbox ID="txt_contact" runat="server" TextMode="Phone"></asp:Textbox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style_td">City :</td>
                            <td>                                
                                <asp:DropDownList ID="ddl_city" runat="server">
                                    <asp:ListItem>Junagadh</asp:ListItem>
                                    <asp:ListItem>Jamnagar</asp:ListItem>
                                    <asp:ListItem>Ahmedabad</asp:ListItem>
                                    <asp:ListItem>Rajkot</asp:ListItem>
                                    <asp:ListItem>Surat</asp:ListItem>
                                    <asp:ListItem>Vadodara</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="style_td">Age :</td>
                            <td>
                                <asp:Textbox ID="txt_age" runat="server" TextMode="Number"></asp:Textbox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style_td">Password :</td>
                            <td>
                                <asp:Textbox ID="txt_pwd" runat="server" TextMode="Password"></asp:Textbox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style_td">ReEnter Password :</td>
                            <td>
                                <asp:Textbox ID="txt_repwd" runat="server" TextMode="Password"></asp:Textbox>
                            </td>
                             <td><p id="validate-status" style="color:red"></p></td>
                        </tr>
                 
                        <tr>
                            <td colspan="2">
                                <center>
                                    <asp:Button runat="server" ID="btn_submit" Text="Submit" OnClick="btn_submit_Click" />
                                    <asp:Button runat="server" ID="btn_cancel_simple" Text="Cancel" OnClick="btn_cancel_simple_Click"/>
                                    <asp:Button runat="server" ID="btn_update" Text="Update" OnClick="btn_update_Click" />
                                    <asp:Button runat="server" ID="btn_cancel" Text="Cancel Membership" OnClick="btn_cancel_Click" />
                                </center>
                            </td>
                        </tr>
                    </table>
                </center>
            </div>



        </form>
    
</body>
</html>
