<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="_3342TermProjectJohnOmar.ResetPasswod" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>
    
    <title></title>
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
        <div>
        </div>
        <asp:TextBox ID="txtUeserEmail" runat="server"></asp:TextBox>
        <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset Password" />
        <asp:Label ID="lblErrorMessage" runat="server" ForeColor="#FF3300"></asp:Label>
        <asp:TextBox ID="txtUserAnswer" runat="server" Visible="False"></asp:TextBox>
        <asp:Label ID="lblQuestion" runat="server"></asp:Label>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="submit" Visible="False" />
        <asp:Button ID="btnRPassword" runat="server" OnClick="btnRPassword_Click" Text="Save new Password" Visible="False" />
    </form>
</body>
</html>
