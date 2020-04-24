<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="_3342TermProjectJohnOmar.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In</title>
</head>
<body>
    <form id="form1" runat="server">
             <table style="margin:auto; border:5px solid white">
                <tr>
                    <td>
                        <asp:Label ID="lblUserEmail" runat="server" Text="Enter your Email:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtUserEmail" runat="server"></asp:TextBox></td>
                </tr>
                  <tr>
                    <td>
                        <asp:Label ID="lblPass" runat="server" Text="Enter your password:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                  <tr>
                    <td>
                      </td>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
<%--                       <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click"/>--%>
                <asp:Button ID="btnRegisterNew" runat="server" Text="Register" OnClick="btnRegisterNew_Click"/>
                        </td>
                  </tr>
                     <td>
                         <asp:CheckBox ID="cbRemember" Text="Remember me" runat="server" Height="16px" />
                         </td>
                <tr>
                    <td></td>
                    <td>
                        <asp:Label ID="lblError" runat="server" Text="Wrong User or password" ForeColor="Red"></asp:Label>
                    </td>
                </tr>

            </table>


        <asp:Label ID ="test" runat="server" Text ="test"></asp:Label>
    </form>
</body>
</html>
