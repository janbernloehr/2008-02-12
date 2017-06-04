Imports System.Net.Mail

Public Class MainForm

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        ' Anwendung beenden
        Me.Close()
    End Sub

    Private Sub MailSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MailSend.Click
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

            MessageBox.Show("Die Nachricht wurde erfolgreich versand.", "Senden erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Die Nachricht konnte nicht versendet werden.", "Senden fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
