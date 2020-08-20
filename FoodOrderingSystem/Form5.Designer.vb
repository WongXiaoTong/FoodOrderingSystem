<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.lblLogout = New System.Windows.Forms.Button()
        Me.lbltotalprice = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLogout
        '
        Me.lblLogout.BackColor = System.Drawing.Color.Wheat
        Me.lblLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogout.Image = CType(resources.GetObject("lblLogout.Image"), System.Drawing.Image)
        Me.lblLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLogout.Location = New System.Drawing.Point(464, 270)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(152, 79)
        Me.lblLogout.TabIndex = 8
        Me.lblLogout.Text = "Logout"
        Me.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLogout.UseVisualStyleBackColor = False
        '
        'lbltotalprice
        '
        Me.lbltotalprice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltotalprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalprice.Location = New System.Drawing.Point(479, 101)
        Me.lbltotalprice.Name = "lbltotalprice"
        Me.lbltotalprice.Size = New System.Drawing.Size(119, 30)
        Me.lbltotalprice.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(140, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "All Total Price"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(757, 450)
        Me.Controls.Add(Me.lblLogout)
        Me.Controls.Add(Me.lbltotalprice)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLogout As Button
    Friend WithEvents lbltotalprice As Label
    Friend WithEvents Label2 As Label
End Class
