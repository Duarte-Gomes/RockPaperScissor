<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RockPaperScissor.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Rock Paper Scissor</h3>
            <h5>Pick a image</h5>
            <div>
                <asp:ImageButton ID="ImageButton1" ImageUrl="~/Images/rock.png" runat="server" OnClick="ImageButton1_Click" Width="200px" />
                <asp:ImageButton ID="ImageButton2" ImageUrl="~/Images/paper.png" runat="server" OnClick="ImageButton2_Click" Width="200px" />
                <asp:ImageButton ID="ImageButton3" ImageUrl="~/Images/scissors.png" runat="server" OnClick="ImageButton3_Click" Width="200px" />
            </div>
            <div>
                <h5>User choice: <asp:TextBox ID="TextBox1" runat="server" BorderColor="White" BackColor="White" BorderStyle="None" Enabled="False"></asp:TextBox></h5>
            </div>
            <div>
                <h5>Computer choice: <asp:TextBox ID="TextBox2" runat="server" BackColor="White" BorderColor="White" BorderStyle="None" Enabled="False"></asp:TextBox></h5>
            </div>
            <div>
                <h1><asp:TextBox ID="TextBox3" runat="server" BackColor="White" BorderColor="White" BorderStyle="None" Enabled="False" Font-Size="X-Large"></asp:TextBox></h1>
            </div>
        </div>
    </form>
</body>
</html>
