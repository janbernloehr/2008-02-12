Imports System.Net.Mail

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub CancelMail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CancelMail.Click
        ' Eingaben löschen
        Response.Redirect("~/default.aspx")
    End Sub

    Protected Sub SendMail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SendMail.Click
        Dim message As MailMessage
        Dim client As SmtpClient

        Try
            ' Email Objekt erstellen
            message = New MailMessage()

            message.To.Add(MailTo.Text)
            message.Body = MailBody.Text
            message.Subject = MailSubject.Text

            ' Nachricht via Smtp versenden
            client = New SmtpClient
            client.Send(message)

            ' Anstatt einer Message Box, muss hier ein Label angezeigt werden.
            Status.CssClass = "success"
            Status.Text = "Die Nachricht wurde erfolgreich versand."
        Catch ex As Exception
            Status.CssClass = "error"
            Status.Text = "Die Nachricht konnte nicht versendet werden."
        End Try
    End Sub
End Class
