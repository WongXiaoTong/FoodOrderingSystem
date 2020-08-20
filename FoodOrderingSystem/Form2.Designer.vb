<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim User_TypeLabel As System.Windows.Forms.Label
        Dim User_NameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.ADD = New System.Windows.Forms.Button()
        Me.DELETE = New System.Windows.Forms.Button()
        Me.UPDATE = New System.Windows.Forms.Button()
        Me.CLEAR = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StaffDataGridView = New System.Windows.Forms.DataGridView()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SatffDataSet = New FoodOrderingSystem.SatffDataSet()
        Me.User_TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.User_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.StaffTableAdapter = New FoodOrderingSystem.SatffDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New FoodOrderingSystem.SatffDataSetTableAdapters.TableAdapterManager()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTypeDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        User_TypeLabel = New System.Windows.Forms.Label()
        User_NameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.StaffDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SatffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'User_TypeLabel
        '
        User_TypeLabel.AutoSize = True
        User_TypeLabel.BackColor = System.Drawing.Color.Linen
        User_TypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_TypeLabel.Location = New System.Drawing.Point(124, 55)
        User_TypeLabel.Name = "User_TypeLabel"
        User_TypeLabel.Size = New System.Drawing.Size(109, 25)
        User_TypeLabel.TabIndex = 19
        User_TypeLabel.Text = "User Type:"
        '
        'User_NameLabel
        '
        User_NameLabel.AutoSize = True
        User_NameLabel.BackColor = System.Drawing.Color.Linen
        User_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_NameLabel.Location = New System.Drawing.Point(124, 108)
        User_NameLabel.Name = "User_NameLabel"
        User_NameLabel.Size = New System.Drawing.Size(116, 25)
        User_NameLabel.TabIndex = 21
        User_NameLabel.Text = "User Name:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.BackColor = System.Drawing.Color.Linen
        PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(124, 158)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(104, 25)
        PasswordLabel.TabIndex = 23
        PasswordLabel.Text = "Password:"
        '
        'ADD
        '
        Me.ADD.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ADD.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADD.Location = New System.Drawing.Point(67, 239)
        Me.ADD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ADD.Name = "ADD"
        Me.ADD.Size = New System.Drawing.Size(165, 50)
        Me.ADD.TabIndex = 6
        Me.ADD.Text = "ADD"
        Me.ADD.UseVisualStyleBackColor = False
        '
        'DELETE
        '
        Me.DELETE.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DELETE.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETE.Location = New System.Drawing.Point(248, 239)
        Me.DELETE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DELETE.Name = "DELETE"
        Me.DELETE.Size = New System.Drawing.Size(165, 50)
        Me.DELETE.TabIndex = 7
        Me.DELETE.Text = "DELETE"
        Me.DELETE.UseVisualStyleBackColor = False
        '
        'UPDATE
        '
        Me.UPDATE.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.UPDATE.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPDATE.Location = New System.Drawing.Point(431, 239)
        Me.UPDATE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UPDATE.Name = "UPDATE"
        Me.UPDATE.Size = New System.Drawing.Size(165, 50)
        Me.UPDATE.TabIndex = 8
        Me.UPDATE.Text = "UPDATE"
        Me.UPDATE.UseVisualStyleBackColor = False
        '
        'CLEAR
        '
        Me.CLEAR.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CLEAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLEAR.Location = New System.Drawing.Point(613, 239)
        Me.CLEAR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CLEAR.Name = "CLEAR"
        Me.CLEAR.Size = New System.Drawing.Size(165, 50)
        Me.CLEAR.TabIndex = 9
        Me.CLEAR.Text = "CLEAR"
        Me.CLEAR.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'StaffDataGridView
        '
        Me.StaffDataGridView.AutoGenerateColumns = False
        Me.StaffDataGridView.BackgroundColor = System.Drawing.Color.MistyRose
        Me.StaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.UserTypeDataGridViewCheckBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn})
        Me.StaffDataGridView.DataSource = Me.StaffBindingSource
        Me.StaffDataGridView.Location = New System.Drawing.Point(188, 314)
        Me.StaffDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StaffDataGridView.Name = "StaffDataGridView"
        Me.StaffDataGridView.RowTemplate.Height = 24
        Me.StaffDataGridView.Size = New System.Drawing.Size(446, 210)
        Me.StaffDataGridView.TabIndex = 17
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.SatffDataSet
        '
        'SatffDataSet
        '
        Me.SatffDataSet.DataSetName = "SatffDataSet"
        Me.SatffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'User_TypeComboBox
        '
        Me.User_TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "User Type", True))
        Me.User_TypeComboBox.FormattingEnabled = True
        Me.User_TypeComboBox.Items.AddRange(New Object() {"EMPLOYEE", "ADMIN"})
        Me.User_TypeComboBox.Location = New System.Drawing.Point(273, 57)
        Me.User_TypeComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.User_TypeComboBox.Name = "User_TypeComboBox"
        Me.User_TypeComboBox.Size = New System.Drawing.Size(293, 24)
        Me.User_TypeComboBox.TabIndex = 20
        '
        'User_NameTextBox
        '
        Me.User_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "User Name", True))
        Me.User_NameTextBox.Location = New System.Drawing.Point(273, 112)
        Me.User_NameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.User_NameTextBox.Name = "User_NameTextBox"
        Me.User_NameTextBox.Size = New System.Drawing.Size(409, 22)
        Me.User_NameTextBox.TabIndex = 22
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(273, 162)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(409, 22)
        Me.PasswordTextBox.TabIndex = 24
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.UpdateOrder = FoodOrderingSystem.SatffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.WhatsApp_Image_2020_07_18_at_7_05_23_PM
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.StaffDataGridView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(841, 535)
        Me.Panel1.TabIndex = 25
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'UserTypeDataGridViewCheckBoxColumn
        '
        Me.UserTypeDataGridViewCheckBoxColumn.DataPropertyName = "User Type"
        Me.UserTypeDataGridViewCheckBoxColumn.HeaderText = "User Type"
        Me.UserTypeDataGridViewCheckBoxColumn.Name = "UserTypeDataGridViewCheckBoxColumn"
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "User Name"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "User Name"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 535)
        Me.Controls.Add(User_TypeLabel)
        Me.Controls.Add(Me.User_TypeComboBox)
        Me.Controls.Add(User_NameLabel)
        Me.Controls.Add(Me.User_NameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.CLEAR)
        Me.Controls.Add(Me.UPDATE)
        Me.Controls.Add(Me.DELETE)
        Me.Controls.Add(Me.ADD)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form2"
        Me.Text = "Staff Module"
        CType(Me.StaffDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SatffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ADD As Button
    Friend WithEvents DELETE As Button
    Friend WithEvents UPDATE As Button
    Friend WithEvents CLEAR As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SatffDataSet As SatffDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As SatffDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As SatffDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffDataGridView As DataGridView
    Friend WithEvents User_TypeComboBox As ComboBox
    Friend WithEvents User_NameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserTypeDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
