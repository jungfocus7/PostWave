Imports System
Imports System.Net
Imports System.Collections.Specialized
Imports System.Diagnostics
Imports System.Text
Imports System.Threading



Public NotInheritable Class CFrmRoot
    Public Sub New()
        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

    End Sub


    Protected Overrides Sub OnLoad(tea As EventArgs)
        MyBase.OnLoad(tea)
    End Sub


    Private Sub pf_Invork(tact As Action)
        If Me.InvokeRequired Then
            Me.Invoke(tact)
        Else
            tact()
        End If
    End Sub

    Private Sub pf_Work()
        Using twc As New WebClient()
            Try
                Dim tsb As New StringBuilder()
                tsb.Append("hand=1234")
                tsb.Append("&"c)
                tsb.Append("gate=0987")

                Dim tres As String
                tres = twc.UploadString("http://127.0.0.1:5000/", "POST", "")
                pf_Invork( _
                    Sub()
                        '_txb1.Text = tres
                        _txb1.AppendText(tres & vbNewLine)
                    End Sub)
            Catch tex As Exception
                'MsgBox(tex.ToString())
                Return
            End Try
            'MsgBox("Completed")
        End Using
    End Sub

    Private Sub pf_btn1_Click(tsd As Object, tea As EventArgs) Handles _btn1.Click
        ThreadPool.QueueUserWorkItem( _
            Sub(tsi As Object)
                pf_Work()
            End Sub)






        'ThreadPool.QueueUserWorkItem( _
        '    Sub(tsi As Object)
        '        Using twc As New WebClient()
        '            Try
        '                'Dim tnvc As New NameValueCollection()
        '                'tnvc.Add("hand", "1234")
        '                'tnvc.Add("gate", "0987")
        '                'Debug.WriteLine(tnvc.ToString())



        '                twc.Headers(HttpRequestHeader.ContentType) = "application/x-www-form-urlencoded"

        '                Dim tsb As New StringBuilder()
        '                tsb.Append("hand=1234")
        '                tsb.Append("&"c)
        '                tsb.Append("gate=0987")

        '                Dim tres As Object
        '                'tres = twc.UploadString("https://postman-echo.com/post", "POST", "hand=1234")
        '                tres = twc.UploadString("http://localhost", "POST", tsb.ToString())
        '                'If Me.InvokeRequired Then
        '                '    Me.Invoke( _
        '                '        Sub()
        '                '            _txb1.Text = tres
        '                '        End Sub)
        '                'Else
        '                '    _txb1.Text = tres
        '                'End If
        '            Catch tex As Exception
        '                'Debug.WriteLine("TimeOut")
        '                'MsgBox("TimeOut")
        '                MsgBox(tex)
        '                Return
        '            End Try
        '            MsgBox("Completed")
        '        End Using
        '    End Sub)


        'Using twc As New WebClient()
        '    Try
        '        'Dim tnvc As New NameValueCollection()
        '        'tnvc.Add("hand", "1234")
        '        'tnvc.Add("gate", "0987")
        '        'Debug.WriteLine(tnvc.ToString())



        '        'twc.Headers(HttpRequestHeader.ContentType) = "application/x-www-form-urlencoded"

        '        Dim tsb As New StringBuilder()
        '        tsb.Append("hand=1234")
        '        tsb.Append("&"c)
        '        tsb.Append("gate=0987")

        '        Dim tres As String
        '        'tres = twc.UploadString("https://postman-echo.com/post", "POST", "hand=1234")
        '        'tres = twc.UploadString("http://localhost", "POST", tsb.ToString())
        '        'tres = twc.UploadString("http://127.0.0.1:5000/", "GET", tsb.ToString())
        '        'tres = twc.DownloadString("http://127.0.0.1:5000/")
        '        'tres = twc.UploadData("http://127.0.0.1:5000/", "POST", New Byte() {})
        '        tres = twc.UploadString("http://127.0.0.1:5000/", "POST", "")
        '        pf_Invork( _
        '            Sub()
        '                _txb1.Text = tres
        '            End Sub)
        '        Debug.WriteLine("~~~~")
        '    Catch tex As Exception
        '        'Debug.WriteLine("TimeOut")
        '        'MsgBox("TimeOut")
        '        MsgBox(tex.ToString())
        '        Return
        '    End Try
        '    MsgBox("Completed")
        'End Using



        'Dim thwr As HttpWebRequest = CType(HttpWebRequest.Create("http://127.0.0.1:5000"), HttpWebRequest)
        'thwr.Method = "POST"
        'thwr.ContentType = "application/json"
        'thwr.Timeout = 30 * 1000

    End Sub

End Class
