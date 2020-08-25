<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CFrmRoot
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CFrmRoot))
        Me._btn1 = New System.Windows.Forms.Button()
        Me._txb1 = New System.Windows.Forms.TextBox()
        Me._txb2 = New System.Windows.Forms.TextBox()
        Me._btn2 = New System.Windows.Forms.Button()
        Me._txb3 = New System.Windows.Forms.TextBox()
        Me._lstb1 = New System.Windows.Forms.ListBox()
        Me._btn3 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SuspendLayout()
        '
        '_btn1
        '
        Me._btn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._btn1.Location = New System.Drawing.Point(613, 952)
        Me._btn1.Name = "_btn1"
        Me._btn1.Size = New System.Drawing.Size(75, 23)
        Me._btn1.TabIndex = 5
        Me._btn1.Text = ">>>1"
        Me._btn1.UseVisualStyleBackColor = True
        '
        '_txb1
        '
        Me._txb1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._txb1.Location = New System.Drawing.Point(12, 12)
        Me._txb1.Multiline = True
        Me._txb1.Name = "_txb1"
        Me._txb1.ReadOnly = True
        Me._txb1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me._txb1.Size = New System.Drawing.Size(676, 400)
        Me._txb1.TabIndex = 0
        Me._txb1.WordWrap = False
        '
        '_txb2
        '
        Me._txb2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._txb2.Location = New System.Drawing.Point(12, 418)
        Me._txb2.Multiline = True
        Me._txb2.Name = "_txb2"
        Me._txb2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me._txb2.Size = New System.Drawing.Size(676, 400)
        Me._txb2.TabIndex = 1
        Me._txb2.Text = "{" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & """Name"": ""HobisJung""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._txb2.WordWrap = False
        '
        '_btn2
        '
        Me._btn2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._btn2.Location = New System.Drawing.Point(532, 952)
        Me._btn2.Name = "_btn2"
        Me._btn2.Size = New System.Drawing.Size(75, 23)
        Me._btn2.TabIndex = 4
        Me._btn2.Text = ">>>2"
        Me._btn2.UseVisualStyleBackColor = True
        '
        '_txb3
        '
        Me._txb3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._txb3.Location = New System.Drawing.Point(278, 824)
        Me._txb3.Name = "_txb3"
        Me._txb3.ReadOnly = True
        Me._txb3.Size = New System.Drawing.Size(410, 23)
        Me._txb3.TabIndex = 3
        '
        '_lstb1
        '
        Me._lstb1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._lstb1.FormattingEnabled = True
        Me._lstb1.ItemHeight = 15
        Me._lstb1.Items.AddRange(New Object() {"http://127.0.0.1:5000/Apple", "http://127.0.0.1:5000/Gate", "http://127.0.0.1:5000/XXA", "http://127.0.0.1:5000/XXB", "http://127.0.0.1:5000/XXC", "http://127.0.0.1:5000/XXD"})
        Me._lstb1.Location = New System.Drawing.Point(12, 824)
        Me._lstb1.Name = "_lstb1"
        Me._lstb1.Size = New System.Drawing.Size(260, 139)
        Me._lstb1.TabIndex = 2
        '
        '_btn3
        '
        Me._btn3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._btn3.Location = New System.Drawing.Point(451, 952)
        Me._btn3.Name = "_btn3"
        Me._btn3.Size = New System.Drawing.Size(75, 23)
        Me._btn3.TabIndex = 6
        Me._btn3.Text = ">>>3"
        Me._btn3.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 978)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(700, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'CFrmRoot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BackgroundImage = Global.PostWave.My.Resources.Resources.xxxa
        Me.ClientSize = New System.Drawing.Size(700, 1000)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me._btn3)
        Me.Controls.Add(Me._lstb1)
        Me.Controls.Add(Me._txb3)
        Me.Controls.Add(Me._btn2)
        Me.Controls.Add(Me._txb2)
        Me.Controls.Add(Me._txb1)
        Me.Controls.Add(Me._btn1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CFrmRoot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _btn1 As System.Windows.Forms.Button
    Friend WithEvents _txb1 As System.Windows.Forms.TextBox
    Friend WithEvents _txb2 As System.Windows.Forms.TextBox
    Friend WithEvents _btn2 As System.Windows.Forms.Button
    Friend WithEvents _txb3 As System.Windows.Forms.TextBox
    Friend WithEvents _lstb1 As System.Windows.Forms.ListBox
    Friend WithEvents _btn3 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip

End Class
