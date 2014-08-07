Imports System.Web.Http
Imports System.Net

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Home

    Function Index() As ActionResult
        Return View()
    End Function

    'POST: /Home/

    Function SendEmail() As String
        Dim sFailure = ""
        Try
            Dim wrapper = New WebMailWrapper(Request)
            Dim rc As String = wrapper.Send()
            Return "{""Result"":""" & rc & """}"
        Catch ex As Exception
            sFailure = sFailure & ex.Message
        End Try
        Return "{""Result"":""failure: " & sFailure & """}"
    End Function

End Class