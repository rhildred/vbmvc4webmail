Imports System.Web.Helpers

Public Class WebMailWrapper
    Private mRequest = vbNull

    Public Sub New(ByRef request)
        mRequest = request
    End Sub

    Public Function Send() As String
        WebMail.SmtpServer = "smtp.gmail.com"
        WebMail.SmtpPort = 587
        WebMail.EnableSsl = True
        WebMail.UserName = "you"
        WebMail.Password = "your password"
        WebMail.From = "you@gmail.com"
        WebMail.Send("inquiry.recipient@example.com", "inquiry from " & mRequest("email") & " re: " & mRequest("subject"), mRequest("body"))
        Return "email sent from " & mRequest("email")
    End Function


End Class
