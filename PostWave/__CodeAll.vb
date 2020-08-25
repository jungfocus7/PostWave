Imports System
Imports System.Net


Public Class CWebClient : Inherits WebClient
    Public Sub New(Optional time As Integer = 100000)
        _time = time
    End Sub

    Protected _time As Integer
    Protected Overrides Function GetWebRequest(address As Uri) As WebRequest
        Dim twr As WebRequest = MyBase.GetWebRequest(address)
        twr.Timeout = _time
        'twr.Timeout = 1000 * 60
        'twr.Timeout = 20 * 60 * 1000
        'CType(twr, HttpWebRequest).ReadWriteTimeout = 20 * 60 * 1000
        Return twr
    End Function
End Class
