<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserLogout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserLogout))
        Me.lblLoginUN = New System.Windows.Forms.Label()
        Me.btnTotalR = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTDout = New System.Windows.Forms.Label()
        Me.lblTDin = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblLoginUN
        '
        Me.lblLoginUN.AutoSize = True
        Me.lblLoginUN.Location = New System.Drawing.Point(503, 74)
        Me.lblLoginUN.Name = "lblLoginUN"
        Me.lblLoginUN.Size = New System.Drawing.Size(45, 17)
        Me.lblLoginUN.TabIndex = 18
        Me.lblLoginUN.Text = "Name"
        '
        'btnTotalR
        '
        Me.btnTotalR.BackColor = System.Drawing.Color.LightGray
        Me.btnTotalR.Location = New System.Drawing.Point(503, 338)
        Me.btnTotalR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTotalR.Name = "btnTotalR"
        Me.btnTotalR.Size = New System.Drawing.Size(123, 39)
        Me.btnTotalR.TabIndex = 17
        Me.btnTotalR.Text = "Total Revenue"
        Me.btnTotalR.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.Location = New System.Drawing.Point(191, 338)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 39)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblTDout
        '
        Me.lblTDout.AutoSize = True
        Me.lblTDout.Location = New System.Drawing.Point(500, 205)
        Me.lblTDout.Name = "lblTDout"
        Me.lblTDout.Size = New System.Drawing.Size(142, 17)
        Me.lblTDout.TabIndex = 15
        Me.lblTDout.Text = "Time and date logout"
        '
        'lblTDin
        '
        Me.lblTDin.AutoSize = True
        Me.lblTDin.Location = New System.Drawing.Point(500, 141)
        Me.lblTDin.Name = "lblTDin"
        Me.lblTDin.Size = New System.Drawing.Size(135, 17)
        Me.lblTDin.TabIndex = 14
        Me.lblTDin.Text = "Time and Date login"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(158, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Time Logout"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Time Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Login User Name"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblLoginUN)
        Me.Controls.Add(Me.btnTotalR)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTDout)
        Me.Controls.Add(Me.lblTDin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form4"
        Me.Text = "User Logout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLoginUN As Label
    Friend WithEvents btnTotalR As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTDout As Label
    Friend WithEvents lblTDin As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer2 As Timer
End Class
