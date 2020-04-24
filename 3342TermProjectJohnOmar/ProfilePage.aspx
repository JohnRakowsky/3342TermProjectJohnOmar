<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="_3342TermProjectJohnOmar.ProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Profile</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server">
                <Items>
                    <asp:MenuItem Text="Home Page" Value="Home Page"></asp:MenuItem>
                    <asp:MenuItem Text="User Search" Value="User Search"></asp:MenuItem>
                    <asp:MenuItem Text="Premium Membership" Value="Premium Membership"></asp:MenuItem>
                    <asp:MenuItem Text="Log Out" Value="Log Out"></asp:MenuItem>
                </Items>
            </asp:Menu>

            <br />
            <br />
            <br />
            <table>
                <tr>
                    <td>
                        <asp:Image ID="imgProfilePic" runat="server" />
                    </td>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lblAge" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lblPreference" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lblCity" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
            
            




        </div>
    </form>
</body>
</html>
