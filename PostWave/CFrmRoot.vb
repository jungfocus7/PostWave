Imports System
Imports System.Net
Imports System.Collections.Specialized
Imports System.Diagnostics
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports System.Linq




Public NotInheritable Class CFrmRoot
    Public Sub New()
        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

    End Sub


    Protected Overrides Sub OnLoad(tea As EventArgs)
        MyBase.OnLoad(tea)

        Me.Text = Me.GetType().Namespace

        _fsz = Me.Size
        Me.MinimumSize = _fsz
        pf_btn3_Click(Nothing, Nothing)

        Dim ttfp As String = Environment.GetCommandLineArgs()(0)
        ttfp = Path.Combine(Path.GetDirectoryName(ttfp), "List.txt")
        If File.Exists(ttfp) Then
            Dim tsl() As String = File.ReadAllLines(ttfp)
            tsl = Enumerable.Where(tsl, Function(tx As String) Not String.IsNullOrEmpty(tx.Trim())).ToArray()
            _lstb1.DataSource = tsl
        End If
    End Sub

    Private _fsz As Size



    Private Shared Sub pf_Invork(tc As Control, tact As Action)
        If tc.InvokeRequired Then
            tc.Invoke(tact)
        Else
            tact()
        End If
    End Sub


    Private Sub pf_PutText(str_res As String)
        pf_Invork(Me, _
            Sub()
                '_txb1.Text = tres
                _txb1.AppendText(str_res & vbNewLine)
            End Sub)
    End Sub

    Private Sub pf_Work()
        Using twc As New CWebClient()
            Try
                twc.Headers(HttpRequestHeader.ContentType) = "application/json"

                Dim str_put As String = _txb2.Text
                Dim str_res As String = twc.UploadString("http://127.0.0.1:5000/", "POST", str_put)
                pf_PutText(str_res)
            Catch tex As Exception
                pf_PutText(tex.ToString())
                'Debug.WriteLine(tex.ToString())
                Return
            End Try
            'Debug.WriteLine("Completed")
        End Using
    End Sub

    Private Sub pf_btn1_Click(tsd As Object, tea As EventArgs) Handles _btn1.Click
        ThreadPool.QueueUserWorkItem( _
            Sub(tsi As Object)
                pf_Work()
            End Sub)
    End Sub



    Private Sub pf_btn2_Click(tsd As Object, tea As EventArgs) Handles _btn2.Click
        _txb1.Clear()
    End Sub




    Private Sub pf_btn3_Click(tsd As Object, tea As EventArgs) Handles _btn3.Click
        Me.WindowState = FormWindowState.Normal
        Me.Size = _fsz

        '모니터다 듀얼 이상일때
        Dim tcs As Screen = Screen.FromPoint(Cursor.Position)
        Dim tsb As Rectangle = tcs.Bounds
        Dim tlp As Point = New Point(tsb.Right, tsb.Bottom)
        Dim tws As Size = Me.Size
        tlp.Offset(-(tws.Width + 40), -(tws.Height + 40))
        Me.Location = tlp
    End Sub


    Private Sub pf_lstb1_SelectedIndexChanged(tsd As Object, tea As EventArgs) Handles _lstb1.SelectedIndexChanged
        _txb3.Text = _lstb1.SelectedItem.ToString()
    End Sub

End Class
