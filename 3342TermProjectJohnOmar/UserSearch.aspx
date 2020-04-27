<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserSearch.aspx.cs" Inherits="_3342TermProjectJohnOmar.UserSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Search</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>

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
                                <a class="nav-link" href="#">User Search</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="#">Premium Membership</a>
                            </li>
                            <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle" href="#" id="navbarAccount" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" runat="server" visible="true">
                                Account Management
                            </a>
                            <div class="dropdown-menu" aria-labelledby="navbarAccount">
                                <a class="dropdown-item" href="ProfilePage.aspx" runat="server" id="manageAccount">User Profile</a>
                                <a class="dropdown-item" href="#">Manage Account</a>
                                <a class="dropdown-item" href="#">Log Out</a>
                            </div>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="LogIn.aspx" id="navbarLogIn" runat="server">Log In</a>
                            </li>
                     </ul>
                </div>
            </nav>
        </div>
        <br />
        <br />
        <br />
        <div class="container">
            <div class="row">
                <div class="input-group   ">
                        <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control bg-light border-0 small" placeholder="Search for..." aria-label="Search" aria-describedby="basic-addon2"></asp:TextBox>
                        <div class="input-group-append">
                            <button class="btn btn-danger" type="button">
                                <i class="fas fa-search fa-sm"></i>
                            </button>
                        </div>
                    </div>
                </div>

            <br />
            <br />
        <div id ="searchResults" runat="server">
            <asp:GridView ID="gvSearchResults" runat="server" ShowHeader="false" GridLines="None" AutoGenerateColumns="false" CssClass="table- AllowPaging="True" AllowCustomPaging="False" hover">
            <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <table>
                        <tr>
                            <td style="width: 200px">
                                <asp:Image ID="imgProfilePic" 
                                    ImageUrl='<%# Eval("userProfilePic")%>' 
                                    runat="server" />
                                </td>
                                    <td style="width: 200px">
                                        <table>
                                                <tr>
                                                    <td>
                                                    <b>Name:</b>
                                                    </td>
                                                    <td>
                                                    <asp:Label ID="lblFirstName" 
                                                    runat="server" 
                                                    Text='<%#Eval("userFirstName") %>'>
                                                    </asp:Label>
                                                    <asp:Label ID="lblLastName" 
                                                    runat="server" 
                                                    Text='<%#Eval("userLastName") %>'>
                                                    </asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                    <b>Age: </b>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lblAge" 
                                                        runat="server" 
                                                        Text='<%#Eval("userAge") %>'>
                                                        </asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <b>Preference:</b>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lblPreference" 
                                                        runat="server" 
                                                        Text='<%#Eval("userPreference") %>'>
                                                        </asp:Label>
                                                    </td>
                                               </tr>
                                               
                                                <tr>
                                                    <td>
                                                       
                                                    </td>
                                                    <td>
                                                        <asp:Button ID="btnViewProfile" runat="server" Text="Manage Class"  OnClick="btnViewProfile_Click" CssClass="btn btn-outline-dark  btn-light"/>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>



        </div>
        </div>
     </form>
     <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
     <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</body>
</html>
