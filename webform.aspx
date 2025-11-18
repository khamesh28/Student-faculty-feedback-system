<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="FeedbackProject.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Feedback Submitted</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            text-align: center; 
            padding: 20px;
        }
        .center {
            display: block;
            margin-left: auto;
            margin-right: auto;
            width: 50%; 
        }
        h1 {
            margin-bottom: 20px;
        }
        p {
            margin-bottom: 20px;
        }
    </style>
</head>
<body>
      <asp:Image ID="Image1" runat="server" ImageUrl="~/html/new-sriher-logo.png" style="width:1500px;height:130px"/>
    

    <h1>Thank You!</h1>
    <h2>Your feedback has been submitted successfully. We appreciate your time and effort in helping us improve our teaching.</h2>
</body>

</html>
