﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="_3342TermProjectJohnOmar.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>
    <title>Log In</title>
</head>
<body>
    <form id="form1" runat="server">
            <div>
            <nav class="navbar navbar-expand-lg navbar-light bg-light">
                    <a class="navbar-brand" href="MainPage.aspx">Temple Singles</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                    <div class="collapse navbar-collapse" id="navbarNavDropdown">
                        <ul class="navbar-nav">
                            <li class="nav-item active">
                                <a class="nav-link" href="MainPage.aspx">Home <span class="sr-only">(current)</span></a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="UserSearch.aspx">User Search</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="Premium.aspx">Premium Membership</a>
                            </li>
                            
                            <li class="nav-item">
                                <a class="nav-link" href="#" id="navbarLogIn" runat="server">Log In</a>
                            </li>
                     </ul>
                </div>
            </nav>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
            <div>
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
                        <asp:Button ID="btnResetPassword" runat="server" Text="ResetPassword" OnClick="btnResetPassword_Click" />
<%--                       <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click"/>--%>
                <asp:Button ID="btnRegisterNew" runat="server" Text="Register" OnClick="btnRegisterNew_Click"/>
                        </td>
                  </tr>
                <tr>
                    <td><asp:CheckBox ID="cbRemember" Text="Remember me" runat="server" Height="16px" /></td>
                    <td>
                        <asp:Label ID="lblError" runat="server" Text="Wrong User or password" ForeColor="Red"></asp:Label>
                    </td>
                </tr>

            </table>
            </div>
        
    </form>
     <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</body>
</html>
