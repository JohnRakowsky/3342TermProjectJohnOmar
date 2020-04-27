 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="_3342TermProjectJohnOmar.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>
     <script>
         function ValidateEmail() {

             var userEmail = document.getElementById("txtEmail").value;
             if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(userEmail)) {
                 return (true)
             }
             alert("You have entered an invalid email address!")
             return (false)
         }</script>
    <title>Registration</title>
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
                                <a class="nav-link" href="LogIn.aspx" >Log In</a>
                            </li>
                     </ul>
                </div>
            </nav>
        </div>
        <div>
            <br />
            <br />
                  <table style="margin:auto; border:5px solid white">
                <tr>
                    <td>
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                           <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label  runat="server" ForeColor="Red" Text="*"></asp:Label>
            <br />
                    </td>
                </tr>
                     <tr>
                    <td>
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            <asp:Label  runat="server" ForeColor="Red" Text="*"></asp:Label>
            <br />

                    </td>
                </tr>
     <tr>
                    <td>
            <asp:Label ID="lblFName" runat="server" Text="First Name"></asp:Label>

                    </td>
                    <td>
            <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label  runat="server" ForeColor="Red" Text="*"></asp:Label>
            <br />

                    </td>
                </tr>
     <tr>
                    <td>
           <asp:Label ID="lblLname" runat="server" Text="Last Name" ></asp:Label>

                    </td>
                    <td>
            <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label  runat="server" ForeColor="Red" Text="*"></asp:Label>
            <br />
                    </td>
                </tr>
                      <tr>
                    <td>
           <asp:Label ID="lblGender" runat="server" Text="Gender" ></asp:Label>

                    </td>
                    <td>
            <asp:TextBox ID="txtGender" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label  runat="server" ForeColor="Red" Text="*"></asp:Label>
            <br />
                    </td>
                </tr>
                      <tr>
                    <td>
           <asp:Label ID="lblPreference" runat="server" Text="Preference" ></asp:Label>

                    </td>
                    <td>
            <asp:TextBox ID="txtPreference" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label  runat="server" ForeColor="Red" Text="*"></asp:Label>
            <br />
                    </td>
                </tr>
     <tr>
                    <td>
            <asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label>

                    </td>
                    <td>
            <asp:TextBox ID="txtAge" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
                    </td>
                </tr>
     <tr>
                    <td>
            <asp:Label ID="lblStreetAddress" runat="server" Text="Street Address"></asp:Label>

                    </td>
                    <td>
            <asp:TextBox ID="txtStreetAddress" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
                    </td>
                </tr>
     <tr>
                    <td>
            <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>

                    </td>
                    <td>
            <asp:TextBox ID="txtCity" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
                    </td>
                </tr>
     <tr>
                    <td>
            <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>

                    </td>
                    <td>
            <asp:DropDownList ID="ddlStates" runat="server" CssClass="form-control">
            </asp:DropDownList>
            <br />
                    </td>
                </tr>

                   <tr>
                    <td>
            <asp:Label ID="lblZip" runat="server" Text="Zip"></asp:Label>


                    </td>
                    <td>
            <asp:TextBox ID="txtZip" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
                    </td>
                </tr>

                   <tr>
                    <td>
           <asp:Label ID="lblQ1" runat="server" Text="Question 1"></asp:Label>
            <br />


                    </td>
                    <td>
            <asp:DropDownList ID="ddlQuestion1" runat="server">
            </asp:DropDownList>
            <br />
                    </td>
                </tr>

                   <tr>
                    <td>
            <asp:Label ID="lblAnswer1" runat="server" Text="Answer 1"></asp:Label>
            <br />

                    </td>
                    <td>

            <asp:TextBox ID="txtAnswer1" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label  runat="server" ForeColor="Red" Text="*"></asp:Label>
            <br />
                    </td>
                </tr>

                   <tr>
                    <td>
         <asp:Label ID="lblQ2" runat="server" Text="Question 2"></asp:Label>
            <br />


                    </td>
                    <td>
            <asp:DropDownList ID="ddlQuestion2" runat="server">
            </asp:DropDownList>
            <br />
                    </td>
                </tr>

                   <tr>
                    <td>
            <asp:Label ID="lblAsnwer2" runat="server" Text="Answer2"></asp:Label>
            <br />

                    </td>
                    <td>
            <asp:TextBox ID="txtAnswer2" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label  runat="server" ForeColor="Red" Text="*"></asp:Label>

            <br />
                    </td>
                </tr>

                   <tr>
                    <td>
            <asp:Label ID="lblQ3" runat="server" Text="Question 3"></asp:Label>
            <br />

                    </td>
                    <td>
            <asp:DropDownList ID="ddlQuestion3" runat="server">
            </asp:DropDownList>
            <br />
                    </td>
                </tr>

                  <tr>
                    <td>
                <asp:Label ID="lblAnswer3" runat="server" Text="Answer 3" ></asp:Label>
            <br />


                    </td>
                    <td>
            <asp:TextBox ID="txtAnswer3" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label  runat="server"  ForeColor="Red" Text="*"></asp:Label>
            <br />
                    </td>
                </tr>


<tr>
    <td>
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CssClass="form-control"/>

    </td>
      
           
                          <td>
            <asp:Button ID="btnRegister" runat="server" Text="Register"  OnClientClick="return ValidateEmail();" OnClick="btnRegister_Click"  CssClass="form-control"/>
            
                      
            <asp:Label ID="lblSuccessMessage" runat="server" ForeColor="#00CC00"></asp:Label>
            <asp:Label ID="lblErrorMessage" runat="server" EnableTheming="True" ForeColor="#FF3300"></asp:Label>
            <br />
                              </td>
                        </tr>
                          </table>
        </div>
    </form>
</body>
</html>
