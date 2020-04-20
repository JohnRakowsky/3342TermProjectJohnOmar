<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="_3342TermProjectJohnOmar.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtStreetAddress" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
            <br />
            
            <br />
            <br />
            <asp:DropDownList ID="ddlQuestion1" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:TextBox ID="txtAnswer1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:DropDownList ID="ddlQuestion2" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:TextBox ID="txtAnswer2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:DropDownList ID="ddlQuestion3" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:TextBox ID="txtAnswer3" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnRegister runat="server" Text="btnRegister" />
            <br />
        </div>
    </form>
</body>
</html>
