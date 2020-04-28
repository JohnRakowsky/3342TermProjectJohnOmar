<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="_3342TermProjectJohnOmar.ProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>
    <title>User Profile</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="navbar">
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
                            <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" runat="server" visible="true">
                                Account Management
                            </a>
                            <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                                <a class="dropdown-item" href="ProfilePage.aspx" runat="server">User Profile</a>
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
        <div>
        <div class="container-fluid padding" id="viewProfile" runat="server">
            <div class="row">
                <div class="col-1"></div>
                <div class="col-9">
                    <h3 runat="server" id="ttlName">User Name</h3>
                </div>
                <div class="col-2">
                    <asp:Button ID="btnLike" runat="server" Text="Like Profile" CssClass="form-control" OnClick="btnLike_Click"/>
                    <asp:Button ID="btnPass" runat="server" Text="Pass Profile" CssClass="form-control" OnClick="btnPass_Click" />
                    <asp:Button ID="btnEditProfile" runat="server" Text="Edit Profile" CssClass="form-control" OnClick="btnEditProfile_Click" />
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12 col-md-6 mr-auto "> <!--left-->
                    <div class="row">
                        <div class="col-12 offset-2">
                            <div class="row padding"> <!--top--->
                               <div class="col-12">
                                    <asp:Image ID="imgOldProfilePic" runat="server" />             
                                </div>
                            </div><!--/top--->
                                 <!--Bio-->
                                <div class="row padding"><!--bottom--->
                                    <div class="col-9">
                                     <div class="form-group green-border-focus">
                                        <h3>Bio</h3>
                                         <asp:TextBox ID="txtOldBio" runat="server" TextMode="MultiLine" Rows="7" cols="80" CssClass="form-control" placeholder="Write your Bio here!" ReadOnly="true"></asp:TextBox>
                                    </div>
                                </div>  
                            </div><!--/bottom--->
                        </div>
                    </div>
                </div><!--/left-->
                <div class="col-sm-12 col-md-6 mr-auto "><!--right-->
                    <div class="row">
                        <div class="col-12 ">
                          <br />     <!----Personal Information-----> 
                           <div class="row">
                               <div class="col-md-3">
                                 <label for="txtPreference">Partner Preference</label>
                                   <asp:Label ID="lblPreference" runat="server" Text="Preference" CssClass="form-control"></asp:Label>
                                </div>
                              <div class="col-md-4 offset-md-3">
                                 <label for="txtAge">Age</label>
                                 <asp:Label ID="lblAge" runat="server" Text="Age" CssClass="form-control"></asp:Label>
                              </div>
                            </div>  
                            

                            <div class="row">
                                <div class="col-md-6">
                                  <label for="txtEmail">Email Address</label>
                                  <asp:Label ID="lblEmail" runat="server" Text="Email" CssClass="form-control"></asp:Label>
                                </div>
                                <div class="col-md-6">
                                  <label for="txtPhoneNumber">Phone Number</label>
                                  <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number" CssClass="form-control"></asp:Label>
                                </div>
                           </div>
                    
                           

                                                       
                            <!----Fluff Info--->
                              <div class="row">
                                <div class="col-md-6">
                                  <label for="txtEmail">Where did you go to school?</label>
                                  <asp:Label ID="lblSchool" runat="server" Text="Schooling" CssClass="form-control"></asp:Label>
                                </div>
                                <div class="col-md-6">
                                  <label for="txtKids">Plans for kids?</label>
                                  <asp:Label ID="lblKids" runat="server" Text="Kids" CssClass="form-control"></asp:Label>
                                </div>
                              </div>

                            
                            <br />
                    
                    </div>
                </div><!--/right-->
            </div>            
        </div>
        </div>


        <div class="container-fluid padding" id="editProfile" runat="server" visible="false">
            <div class="row">
                <div class="col-sm-12 col-md-6 mr-auto "> <!--left-->
                    <div class="row">
                        <div class="col-12 offset-2">
                            <div class="row padding"> <!--top--->
                               <div class="col-12">
                                    <asp:Image ID="imgNewProfilePic" runat="server" />             
                                    <div class="form-group">
                                    <label for="txtProfilePic">Upload Photo</label>
                                        <asp:TextBox ID="txtProfilePic" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div><!--/top--->
                                 <!--Bio-->
                                <div class="row padding"><!--bottom--->
                                    <div class="col-9">
                                     <div class="form-group green-border-focus">
                                        <h3>Bio</h3>
                                         <asp:TextBox ID="txtBio" runat="server" TextMode="MultiLine" Rows="7" cols="80" CssClass="form-control" placeholder="Write your Bio here!"></asp:TextBox>
                                    </div>
                                </div>  
                            </div><!--/bottom--->
                        </div>
                    </div>
                </div><!--/left-->
                <div class="col-sm-12 col-md-6 mr-auto "><!--right-->
                    <div class="row">
                        <div class="col-12 ">
                          <br />     <!----Personal Information-----> 
                           <div class="form-row">
                               <div class="form-group col-md-3">
                                 <label for="txtPreference">Partner Preference</label>
                                 <asp:TextBox ID="txtPreference" runat="server" CssClass="form-control" placeholder="Partner Preference"></asp:TextBox>
                                </div>
                              <div class="form-group col-md-4 offset-md-3">
                                 <label for="txtAge">Age</label>
                                 <asp:TextBox ID="txtAge" runat="server" CssClass="form-control" placeholder="Age"></asp:TextBox>
                              </div>
                            </div>  
                            

                            <div class="form-row">
                                <div class="form-group col-md-6">
                                  <label for="txtEmail">Email Address</label>
                                  <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email Address"></asp:TextBox>
                                </div>
                                <div class="form-group col-md-6">
                                  <label for="txtPhoneNumber">Phone Number</label>
                                  <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="form-control" placeholder="Phone Number"></asp:TextBox>
                                </div>
                           </div>
                    
                           

                                                       
                            <!----Fluff Info--->
                              <div class="form-row">
                                <div class="form-group col-md-6">
                                  <label for="txtEmail">Where did you go to school?</label>
                                  <asp:TextBox ID="txtSchool" runat="server" CssClass="form-control" placeholder="School or University"></asp:TextBox>
                                </div>
                                <div class="form-group col-md-6">
                                  <label for="txtKids">Plans for kids?</label>
                                  <asp:TextBox ID="txtKids" runat="server" CssClass="form-control" placeholder="Plans for Kids"></asp:TextBox>
                                </div>
                              </div>

                            
                            <br />
                                  
                            <div class="row">
                                <div class="col offset-4" >                            
                                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="btn btn-light btn-outline-dark"/>
                                    <asp:Button ID="btnCancel" runat="server" Text="Cancel"  OnClick="btnCancel_Click" CssClass="btn btn-light btn-outline-dark"/>
                                </div>
                            </div>
                    
                    </div>
                </div><!--/right-->
            </div>            
        </div>
        </div>
        </div>
    </form>
     <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</body>
</html>
