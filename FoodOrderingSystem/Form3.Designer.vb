<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Full_NameLabel As System.Windows.Forms.Label
        Dim AdressLabel As System.Windows.Forms.Label
        Dim BirthLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim Email_AdressLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MemberDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemberDataSet = New FoodOrderingSystem.MemberDataSet()
        Me.Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AdressTextBox = New System.Windows.Forms.TextBox()
        Me.Email_AdressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.GenderCheckBox = New System.Windows.Forms.CheckBox()
        Me.MemberTableAdapter = New FoodOrderingSystem.MemberDataSetTableAdapters.MemberTableAdapter()
        Me.TableAdapterManager = New FoodOrderingSystem.MemberDataSetTableAdapters.TableAdapterManager()
        Full_NameLabel = New System.Windows.Forms.Label()
        AdressLabel = New System.Windows.Forms.Label()
        BirthLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        Email_AdressLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.MemberDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Full_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Full_NameLabel.Location = New System.Drawing.Point(20, 48)
        Full_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(75, 17)
        Full_NameLabel.TabIndex = 2
        Full_NameLabel.Text = "Full Name:"
        '
        'AdressLabel
        '
        AdressLabel.AutoSize = True
        AdressLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        AdressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AdressLabel.Location = New System.Drawing.Point(20, 117)
        AdressLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        AdressLabel.Name = "AdressLabel"
        AdressLabel.Size = New System.Drawing.Size(64, 17)
        AdressLabel.TabIndex = 4
        AdressLabel.Text = "Address:"
        AddHandler AdressLabel.Click, AddressOf Me.AdressLabel_Click
        '
        'BirthLabel
        '
        BirthLabel.AutoSize = True
        BirthLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        BirthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BirthLabel.Location = New System.Drawing.Point(309, 123)
        BirthLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        BirthLabel.Name = "BirthLabel"
        BirthLabel.Size = New System.Drawing.Size(41, 17)
        BirthLabel.TabIndex = 12
        BirthLabel.Text = "Birth:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneLabel.Location = New System.Drawing.Point(20, 88)
        PhoneLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(53, 17)
        PhoneLabel.TabIndex = 6
        PhoneLabel.Text = "Phone:"
        '
        'Email_AdressLabel
        '
        Email_AdressLabel.AutoSize = True
        Email_AdressLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Email_AdressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Email_AdressLabel.Location = New System.Drawing.Point(309, 88)
        Email_AdressLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Email_AdressLabel.Name = "Email_AdressLabel"
        Email_AdressLabel.Size = New System.Drawing.Size(102, 17)
        Email_AdressLabel.TabIndex = 10
        Email_AdressLabel.Text = "Email Address:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(309, 50)
        GenderLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(60, 17)
        GenderLabel.TabIndex = 8
        GenderLabel.Text = "Gender:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(22, 202)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(177, 202)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "DELETE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(314, 202)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 28)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "UPDATE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(470, 202)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 28)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "CLEAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.MemberDataGridView)
        Me.Panel1.Controls.Add(Full_NameLabel)
        Me.Panel1.Controls.Add(Me.Full_NameTextBox)
        Me.Panel1.Controls.Add(Me.BirthDateTimePicker)
        Me.Panel1.Controls.Add(AdressLabel)
        Me.Panel1.Controls.Add(BirthLabel)
        Me.Panel1.Controls.Add(Me.AdressTextBox)
        Me.Panel1.Controls.Add(Me.Email_AdressTextBox)
        Me.Panel1.Controls.Add(PhoneLabel)
        Me.Panel1.Controls.Add(Email_AdressLabel)
        Me.Panel1.Controls.Add(Me.PhoneTextBox)
        Me.Panel1.Controls.Add(Me.GenderCheckBox)
        Me.Panel1.Controls.Add(GenderLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 499)
        Me.Panel1.TabIndex = 7
        '
        'MemberDataGridView
        '
        Me.MemberDataGridView.AutoGenerateColumns = False
        Me.MemberDataGridView.BackgroundColor = System.Drawing.Color.MistyRose
        Me.MemberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MemberDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.MemberDataGridView.DataSource = Me.MemberBindingSource
        Me.MemberDataGridView.GridColor = System.Drawing.SystemColors.Control
        Me.MemberDataGridView.Location = New System.Drawing.Point(22, 236)
        Me.MemberDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MemberDataGridView.Name = "MemberDataGridView"
        Me.MemberDataGridView.RowTemplate.Height = 24
        Me.MemberDataGridView.Size = New System.Drawing.Size(539, 223)
        Me.MemberDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Full Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Full Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Gender"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Gender"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Email Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Birth"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Birth"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'MemberBindingSource
        '
        Me.MemberBindingSource.DataMember = "Member"
        Me.MemberBindingSource.DataSource = Me.MemberDataSet
        '
        'MemberDataSet
        '
        Me.MemberDataSet.DataSetName = "MemberDataSet"
        Me.MemberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Full_NameTextBox
        '
        Me.Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "Full Name", True))
        Me.Full_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Full_NameTextBox.Location = New System.Drawing.Point(115, 48)
        Me.Full_NameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Full_NameTextBox.Name = "Full_NameTextBox"
        Me.Full_NameTextBox.Size = New System.Drawing.Size(151, 23)
        Me.Full_NameTextBox.TabIndex = 3
        '
        'BirthDateTimePicker
        '
        Me.BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MemberBindingSource, "Birth", True))
        Me.BirthDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BirthDateTimePicker.Location = New System.Drawing.Point(407, 123)
        Me.BirthDateTimePicker.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BirthDateTimePicker.Name = "BirthDateTimePicker"
        Me.BirthDateTimePicker.Size = New System.Drawing.Size(151, 23)
        Me.BirthDateTimePicker.TabIndex = 13
        '
        'AdressTextBox
        '
        Me.AdressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "Adress", True))
        Me.AdressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdressTextBox.Location = New System.Drawing.Point(115, 117)
        Me.AdressTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AdressTextBox.Name = "AdressTextBox"
        Me.AdressTextBox.Size = New System.Drawing.Size(151, 23)
        Me.AdressTextBox.TabIndex = 5
        '
        'Email_AdressTextBox
        '
        Me.Email_AdressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "Email Adress", True))
        Me.Email_AdressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_AdressTextBox.Location = New System.Drawing.Point(407, 82)
        Me.Email_AdressTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Email_AdressTextBox.Name = "Email_AdressTextBox"
        Me.Email_AdressTextBox.Size = New System.Drawing.Size(151, 23)
        Me.Email_AdressTextBox.TabIndex = 11
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "Phone", True))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTextBox.Location = New System.Drawing.Point(115, 85)
        Me.PhoneTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(151, 23)
        Me.PhoneTextBox.TabIndex = 7
        '
        'GenderCheckBox
        '
        Me.GenderCheckBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GenderCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MemberBindingSource, "Gender", True))
        Me.GenderCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderCheckBox.Location = New System.Drawing.Point(407, 45)
        Me.GenderCheckBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GenderCheckBox.Name = "GenderCheckBox"
        Me.GenderCheckBox.Size = New System.Drawing.Size(150, 20)
        Me.GenderCheckBox.TabIndex = 9
        Me.GenderCheckBox.Text = "Male"
        Me.GenderCheckBox.UseVisualStyleBackColor = False
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MemberTableAdapter = Me.MemberTableAdapter
        Me.TableAdapterManager.UpdateOrder = FoodOrderingSystem.MemberDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(606, 499)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form3"
        Me.Text = "Member Registration"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MemberDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents MemberDataSet As MemberDataSet
    Friend WithEvents MemberBindingSource As BindingSource
    Friend WithEvents MemberTableAdapter As MemberDataSetTableAdapters.MemberTableAdapter
    Friend WithEvents TableAdapterManager As MemberDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BirthDateTimePicker As DateTimePicker
    Friend WithEvents Email_AdressTextBox As TextBox
    Friend WithEvents GenderCheckBox As CheckBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents AdressTextBox As TextBox
    Friend WithEvents Full_NameTextBox As TextBox
    Friend WithEvents MemberDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
