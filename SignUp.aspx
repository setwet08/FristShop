<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="sampleEco.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

    <title>SignUP</title>
       <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title -ecommerce</title>
    

    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <link href="~/Content/MyMainLayOut.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <!----signup--->
        <div class="center -page">   

            <label> username:</label>
            <asp:TextBox ID="txtUname" runat="server" Class="Form-control" placeholder="enter your name"></asp:TextBox>

            <label class> username:</label>
            <asp:TextBox ID="TextBox1" runat="server" Class="Form-control" placeholder="enter your name"></asp:TextBox>
        </div>
    </form>
</body>
</html>
