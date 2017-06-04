<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Web Mail Application</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" AssociatedControlID="MailTo" Text="An:"></asp:Label>
        <asp:TextBox ID="MailTo" runat="server" Width="333px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" AssociatedControlID="MailSubject" 
            Text="Betreff:"></asp:Label>
        <asp:TextBox ID="MailSubject" runat="server" Width="331px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" AssociatedControlID="MailBody" 
            Text="Inhalt"></asp:Label>
        <br />
        <asp:TextBox ID="MailBody" runat="server" Height="134px" TextMode="MultiLine" 
            Width="432px"></asp:TextBox>
        <br />
        <asp:Label ID="Status" runat="server"></asp:Label>
        <br />
        <asp:Button ID="SendMail" runat="server" Text="Senden" />
        <asp:Button ID="CancelMail" runat="server" Text="Abbrechen" />
    
    </div>
    </form>
</body>
</html>
