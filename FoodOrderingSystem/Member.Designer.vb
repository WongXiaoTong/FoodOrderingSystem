<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Member
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Member))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemberRegistrationDataSet = New FoodOrderingSystem.memberRegistrationDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityComboBox = New System.Windows.Forms.ComboBox()
        Me.Phone_NoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.TableTableAdapter = New FoodOrderingSystem.memberRegistrationDataSetTableAdapters.TableTableAdapter()
        Me.TableAdapterManager = New FoodOrderingSystem.memberRegistrationDataSetTableAdapters.TableAdapterManager()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableBindingNavigator.SuspendLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberRegistrationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.BackColor = System.Drawing.Color.Transparent
        IdLabel.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(84, 89)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(31, 22)
        IdLabel.TabIndex = 3
        IdLabel.Text = "ID:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(31, 121)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(84, 22)
        Label2.TabIndex = 17
        Label2.Text = "Username:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(47, 158)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(68, 22)
        Label3.TabIndex = 18
        Label3.Text = "Address:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(72, 194)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(43, 22)
        Label4.TabIndex = 19
        Label4.Text = "City:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(33, 229)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(82, 22)
        Label6.TabIndex = 21
        Label6.Text = "Phone No:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.BackColor = System.Drawing.Color.Transparent
        Label7.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(279, 121)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(64, 22)
        Label7.TabIndex = 24
        Label7.Text = "Gender:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(289, 232)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(54, 22)
        Label5.TabIndex = 22
        Label5.Text = "Email:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.WhatsApp_Image_2020_07_18_at_6_44_26_PM
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 35)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Member Registration Form"
        '
        'TableBindingNavigator
        '
        Me.TableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TableBindingNavigator.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.WhatsApp_Image_2020_07_18_at_6_44_26_PM
        Me.TableBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableBindingNavigator.BindingSource = Me.TableBindingSource
        Me.TableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TableBindingNavigatorSaveItem})
        Me.TableBindingNavigator.Location = New System.Drawing.Point(0, 35)
        Me.TableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TableBindingNavigator.Name = "TableBindingNavigator"
        Me.TableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TableBindingNavigator.Size = New System.Drawing.Size(577, 25)
        Me.TableBindingNavigator.TabIndex = 1
        Me.TableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.MemberRegistrationDataSet
        '
        'MemberRegistrationDataSet
        '
        Me.MemberRegistrationDataSet.DataSetName = "memberRegistrationDataSet"
        Me.MemberRegistrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TableBindingNavigatorSaveItem
        '
        Me.TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TableBindingNavigatorSaveItem.Image = CType(resources.GetObject("TableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TableBindingNavigatorSaveItem.Name = "TableBindingNavigatorSaveItem"
        Me.TableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TableDataGridView
        '
        Me.TableDataGridView.AutoGenerateColumns = False
        Me.TableDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.TableDataGridView.DataSource = Me.TableBindingSource
        Me.TableDataGridView.Location = New System.Drawing.Point(37, 385)
        Me.TableDataGridView.Name = "TableDataGridView"
        Me.TableDataGridView.Size = New System.Drawing.Size(497, 229)
        Me.TableDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Username"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn4.HeaderText = "City"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Phone No"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Phone No"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(128, 89)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(120, 20)
        Me.IdTextBox.TabIndex = 4
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(128, 121)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(120, 20)
        Me.UsernameTextBox.TabIndex = 6
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(128, 158)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(195, 20)
        Me.AddressTextBox.TabIndex = 8
        '
        'CityComboBox
        '
        Me.CityComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "City", True))
        Me.CityComboBox.FormattingEnabled = True
        Me.CityComboBox.Items.AddRange(New Object() {"Georgetown", "Ipoh", "Malacca", "Kuala Lumpur", "Kuala Selangor", "Kota Kinabalu", "Kota Bahru", "Johor Bahru", "Seremban", "Selangor", "Kuantan", "Pahang"})
        Me.CityComboBox.Location = New System.Drawing.Point(128, 197)
        Me.CityComboBox.Name = "CityComboBox"
        Me.CityComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CityComboBox.TabIndex = 10
        '
        'Phone_NoTextBox
        '
        Me.Phone_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Phone No", True))
        Me.Phone_NoTextBox.Location = New System.Drawing.Point(128, 232)
        Me.Phone_NoTextBox.Name = "Phone_NoTextBox"
        Me.Phone_NoTextBox.Size = New System.Drawing.Size(120, 20)
        Me.Phone_NoTextBox.TabIndex = 14
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(349, 232)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(133, 20)
        Me.EmailTextBox.TabIndex = 16
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.WoodBackground54342
        Me.btnAdd.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(67, 277)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 35)
        Me.btnAdd.TabIndex = 25
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.WoodBackground54342
        Me.btnEdit.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(173, 277)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 35)
        Me.btnEdit.TabIndex = 26
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.WoodBackground54342
        Me.btnUpdate.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(268, 277)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 35)
        Me.btnUpdate.TabIndex = 27
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.WoodBackground54342
        Me.btnDel.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(367, 277)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 35)
        Me.btnDel.TabIndex = 28
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(94, 26)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(349, 120)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(133, 21)
        Me.GenderComboBox.TabIndex = 30
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TableTableAdapter = Me.TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = FoodOrderingSystem.memberRegistrationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnFirst
        '
        Me.btnFirst.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.WoodBackground54342
        Me.btnFirst.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(67, 327)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 35)
        Me.btnFirst.TabIndex = 31
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.WoodBackground54342
        Me.btnLast.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(173, 327)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 35)
        Me.btnLast.TabIndex = 32
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.WoodBackground54342
        Me.btnPrevious.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(268, 327)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 35)
        Me.btnPrevious.TabIndex = 33
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.WoodBackground54342
        Me.btnNext.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(367, 327)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 35)
        Me.btnNext.TabIndex = 34
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.WhatsApp_Image_2020_07_18_at_6_44_26_PM
        Me.btnSearch.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(471, 277)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 35)
        Me.btnSearch.TabIndex = 35
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Member
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.WhatsApp_Image_2020_07_18_at_7_05_23_PM
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(577, 643)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Phone_NoTextBox)
        Me.Controls.Add(Me.CityComboBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.TableDataGridView)
        Me.Controls.Add(Me.TableBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Member"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableBindingNavigator.ResumeLayout(False)
        Me.TableBindingNavigator.PerformLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberRegistrationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MemberRegistrationDataSet As memberRegistrationDataSet
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As memberRegistrationDataSetTableAdapters.TableTableAdapter
    Friend WithEvents TableAdapterManager As memberRegistrationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityComboBox As ComboBox
    Friend WithEvents Phone_NoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnSearch As Button
End Class
