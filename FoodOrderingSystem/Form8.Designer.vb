<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim ChangeLabel As System.Windows.Forms.Label
        Dim Cash_Label As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Total_QuantityLabel As System.Windows.Forms.Label
        Dim Order_Sub_TotalLabel As System.Windows.Forms.Label
        Dim DiscountLabel As System.Windows.Forms.Label
        Dim After_DiscountLabel As System.Windows.Forms.Label
        Dim Services_TaxLabel As System.Windows.Forms.Label
        Dim Total_PriceLabel As System.Windows.Forms.Label
        Dim Ref_NoLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim Full_NameLabel As System.Windows.Forms.Label
        Dim Order_TimeLabel As System.Windows.Forms.Label
        Dim Order_Date_Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Order_Date_TextBox = New System.Windows.Forms.TextBox()
        Me.CalculationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CalculationDataSet = New FoodOrderingSystem.CalculationDataSet()
        Me.Order_TimeTextBox = New System.Windows.Forms.TextBox()
        Me.Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemberDataSet = New FoodOrderingSystem.MemberDataSet()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Ref_NoTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TotalPriceLabel = New System.Windows.Forms.Label()
        Me.ServicesTaxLabel = New System.Windows.Forms.Label()
        Me.AfterDiscountLabel = New System.Windows.Forms.Label()
        Me.Discount_Label = New System.Windows.Forms.Label()
        Me.OrderSubTotalLabel = New System.Windows.Forms.Label()
        Me.TotalQuantityLabel = New System.Windows.Forms.Label()
        Me.Change_Label = New System.Windows.Forms.Label()
        Me.Cash_TextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_calculate_current = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.cmbCurreny = New System.Windows.Forms.ComboBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.btnCC = New System.Windows.Forms.Button()
        Me.OrderList = New System.Windows.Forms.GroupBox()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.btn_calculation = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CalculationTableAdapter = New FoodOrderingSystem.CalculationDataSetTableAdapters.CalculationTableAdapter()
        Me.TableAdapterManager = New FoodOrderingSystem.CalculationDataSetTableAdapters.TableAdapterManager()
        Me.CalculationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.CalculationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MemberTableAdapter = New FoodOrderingSystem.MemberDataSetTableAdapters.MemberTableAdapter()
        Me.TableAdapterManager1 = New FoodOrderingSystem.MemberDataSetTableAdapters.TableAdapterManager()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        ChangeLabel = New System.Windows.Forms.Label()
        Cash_Label = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Total_QuantityLabel = New System.Windows.Forms.Label()
        Order_Sub_TotalLabel = New System.Windows.Forms.Label()
        DiscountLabel = New System.Windows.Forms.Label()
        After_DiscountLabel = New System.Windows.Forms.Label()
        Services_TaxLabel = New System.Windows.Forms.Label()
        Total_PriceLabel = New System.Windows.Forms.Label()
        Ref_NoLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Full_NameLabel = New System.Windows.Forms.Label()
        Order_TimeLabel = New System.Windows.Forms.Label()
        Order_Date_Label = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CalculationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalculationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.OrderList.SuspendLayout()
        CType(Me.CalculationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CalculationBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChangeLabel
        '
        ChangeLabel.AutoSize = True
        ChangeLabel.Location = New System.Drawing.Point(44, 255)
        ChangeLabel.Name = "ChangeLabel"
        ChangeLabel.Size = New System.Drawing.Size(61, 17)
        ChangeLabel.TabIndex = 14
        ChangeLabel.Text = "Change:"
        '
        'Cash_Label
        '
        Cash_Label.AutoSize = True
        Cash_Label.Location = New System.Drawing.Point(44, 223)
        Cash_Label.Name = "Cash_Label"
        Cash_Label.Size = New System.Drawing.Size(48, 17)
        Cash_Label.TabIndex = 12
        Cash_Label.Text = "Cash :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(41, 172)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(61, 17)
        Label2.TabIndex = 141
        Label2.Text = "Change:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(50, 128)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(48, 17)
        Label4.TabIndex = 139
        Label4.Text = "Cash :"
        '
        'Total_QuantityLabel
        '
        Total_QuantityLabel.AutoSize = True
        Total_QuantityLabel.Location = New System.Drawing.Point(44, 44)
        Total_QuantityLabel.Name = "Total_QuantityLabel"
        Total_QuantityLabel.Size = New System.Drawing.Size(101, 17)
        Total_QuantityLabel.TabIndex = 15
        Total_QuantityLabel.Text = "Total Quantity:"
        '
        'Order_Sub_TotalLabel
        '
        Order_Sub_TotalLabel.AutoSize = True
        Order_Sub_TotalLabel.Location = New System.Drawing.Point(44, 74)
        Order_Sub_TotalLabel.Name = "Order_Sub_TotalLabel"
        Order_Sub_TotalLabel.Size = New System.Drawing.Size(114, 17)
        Order_Sub_TotalLabel.TabIndex = 16
        Order_Sub_TotalLabel.Text = "Order Sub Total:"
        '
        'DiscountLabel
        '
        DiscountLabel.AutoSize = True
        DiscountLabel.Location = New System.Drawing.Point(44, 100)
        DiscountLabel.Name = "DiscountLabel"
        DiscountLabel.Size = New System.Drawing.Size(67, 17)
        DiscountLabel.TabIndex = 17
        DiscountLabel.Text = "Discount:"
        '
        'After_DiscountLabel
        '
        After_DiscountLabel.AutoSize = True
        After_DiscountLabel.Location = New System.Drawing.Point(44, 130)
        After_DiscountLabel.Name = "After_DiscountLabel"
        After_DiscountLabel.Size = New System.Drawing.Size(101, 17)
        After_DiscountLabel.TabIndex = 18
        After_DiscountLabel.Text = "After Discount:"
        '
        'Services_TaxLabel
        '
        Services_TaxLabel.AutoSize = True
        Services_TaxLabel.Location = New System.Drawing.Point(44, 156)
        Services_TaxLabel.Name = "Services_TaxLabel"
        Services_TaxLabel.Size = New System.Drawing.Size(93, 17)
        Services_TaxLabel.TabIndex = 19
        Services_TaxLabel.Text = "Services Tax:"
        '
        'Total_PriceLabel
        '
        Total_PriceLabel.AutoSize = True
        Total_PriceLabel.Location = New System.Drawing.Point(44, 187)
        Total_PriceLabel.Name = "Total_PriceLabel"
        Total_PriceLabel.Size = New System.Drawing.Size(80, 17)
        Total_PriceLabel.TabIndex = 20
        Total_PriceLabel.Text = "Total Price:"
        '
        'Ref_NoLabel
        '
        Ref_NoLabel.AutoSize = True
        Ref_NoLabel.Location = New System.Drawing.Point(229, 42)
        Ref_NoLabel.Name = "Ref_NoLabel"
        Ref_NoLabel.Size = New System.Drawing.Size(56, 17)
        Ref_NoLabel.TabIndex = 14
        Ref_NoLabel.Text = "Ref No:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(28, 44)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(78, 17)
        IdLabel.TabIndex = 15
        IdLabel.Text = "Member Id:"
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.Location = New System.Drawing.Point(28, 75)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(77, 17)
        Full_NameLabel.TabIndex = 16
        Full_NameLabel.Text = "Cus Name:"
        '
        'Order_TimeLabel
        '
        Order_TimeLabel.AutoSize = True
        Order_TimeLabel.Location = New System.Drawing.Point(19, 140)
        Order_TimeLabel.Name = "Order_TimeLabel"
        Order_TimeLabel.Size = New System.Drawing.Size(84, 17)
        Order_TimeLabel.TabIndex = 18
        Order_TimeLabel.Text = "Order Time:"
        '
        'Order_Date_Label
        '
        Order_Date_Label.AutoSize = True
        Order_Date_Label.Location = New System.Drawing.Point(19, 110)
        Order_Date_Label.Name = "Order_Date_Label"
        Order_Date_Label.Size = New System.Drawing.Size(87, 17)
        Order_Date_Label.TabIndex = 19
        Order_Date_Label.Text = "Order Date :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox2.Controls.Add(Order_Date_Label)
        Me.GroupBox2.Controls.Add(Me.Order_Date_TextBox)
        Me.GroupBox2.Controls.Add(Order_TimeLabel)
        Me.GroupBox2.Controls.Add(Me.Order_TimeTextBox)
        Me.GroupBox2.Controls.Add(Full_NameLabel)
        Me.GroupBox2.Controls.Add(Me.Full_NameTextBox)
        Me.GroupBox2.Controls.Add(IdLabel)
        Me.GroupBox2.Controls.Add(Me.IdTextBox)
        Me.GroupBox2.Controls.Add(Ref_NoLabel)
        Me.GroupBox2.Controls.Add(Me.Ref_NoTextBox)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(332, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 563)
        Me.GroupBox2.TabIndex = 141
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Order_Date_TextBox
        '
        Me.Order_Date_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalculationBindingSource, "Order_Date ", True))
        Me.Order_Date_TextBox.Location = New System.Drawing.Point(112, 110)
        Me.Order_Date_TextBox.Name = "Order_Date_TextBox"
        Me.Order_Date_TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Order_Date_TextBox.TabIndex = 20
        '
        'CalculationBindingSource
        '
        Me.CalculationBindingSource.DataMember = "Calculation"
        Me.CalculationBindingSource.DataSource = Me.CalculationDataSet
        '
        'CalculationDataSet
        '
        Me.CalculationDataSet.DataSetName = "CalculationDataSet"
        Me.CalculationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Order_TimeTextBox
        '
        Me.Order_TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalculationBindingSource, "Order_Time", True))
        Me.Order_TimeTextBox.Location = New System.Drawing.Point(112, 140)
        Me.Order_TimeTextBox.Name = "Order_TimeTextBox"
        Me.Order_TimeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Order_TimeTextBox.TabIndex = 19
        '
        'Full_NameTextBox
        '
        Me.Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "Full Name", True))
        Me.Full_NameTextBox.Location = New System.Drawing.Point(109, 72)
        Me.Full_NameTextBox.Name = "Full_NameTextBox"
        Me.Full_NameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Full_NameTextBox.TabIndex = 17
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
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(109, 39)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IdTextBox.TabIndex = 16
        '
        'Ref_NoTextBox
        '
        Me.Ref_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalculationBindingSource, "Ref_No", True))
        Me.Ref_NoTextBox.Location = New System.Drawing.Point(291, 39)
        Me.Ref_NoTextBox.Name = "Ref_NoTextBox"
        Me.Ref_NoTextBox.Size = New System.Drawing.Size(63, 22)
        Me.Ref_NoTextBox.TabIndex = 15
        '
        'TabControl1
        '
        Me.TabControl1.AccessibleName = ""
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(22, 186)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(326, 342)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Total_PriceLabel)
        Me.TabPage1.Controls.Add(Me.TotalPriceLabel)
        Me.TabPage1.Controls.Add(Services_TaxLabel)
        Me.TabPage1.Controls.Add(Me.ServicesTaxLabel)
        Me.TabPage1.Controls.Add(After_DiscountLabel)
        Me.TabPage1.Controls.Add(Me.AfterDiscountLabel)
        Me.TabPage1.Controls.Add(DiscountLabel)
        Me.TabPage1.Controls.Add(Me.Discount_Label)
        Me.TabPage1.Controls.Add(Order_Sub_TotalLabel)
        Me.TabPage1.Controls.Add(Me.OrderSubTotalLabel)
        Me.TabPage1.Controls.Add(Total_QuantityLabel)
        Me.TabPage1.Controls.Add(Me.TotalQuantityLabel)
        Me.TabPage1.Controls.Add(ChangeLabel)
        Me.TabPage1.Controls.Add(Me.Change_Label)
        Me.TabPage1.Controls.Add(Cash_Label)
        Me.TabPage1.Controls.Add(Me.Cash_TextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(318, 313)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Calculate"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TotalPriceLabel
        '
        Me.TotalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalPriceLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalculationBindingSource, "Total_Price", True))
        Me.TotalPriceLabel.Location = New System.Drawing.Point(164, 187)
        Me.TotalPriceLabel.Name = "TotalPriceLabel"
        Me.TotalPriceLabel.Size = New System.Drawing.Size(100, 23)
        Me.TotalPriceLabel.TabIndex = 21
        '
        'ServicesTaxLabel
        '
        Me.ServicesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ServicesTaxLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalculationBindingSource, "Services_Tax", True))
        Me.ServicesTaxLabel.Location = New System.Drawing.Point(164, 156)
        Me.ServicesTaxLabel.Name = "ServicesTaxLabel"
        Me.ServicesTaxLabel.Size = New System.Drawing.Size(100, 23)
        Me.ServicesTaxLabel.TabIndex = 20
        '
        'AfterDiscountLabel
        '
        Me.AfterDiscountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AfterDiscountLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalculationBindingSource, "After_Discount", True))
        Me.AfterDiscountLabel.Location = New System.Drawing.Point(164, 127)
        Me.AfterDiscountLabel.Name = "AfterDiscountLabel"
        Me.AfterDiscountLabel.Size = New System.Drawing.Size(100, 23)
        Me.AfterDiscountLabel.TabIndex = 19
        '
        'Discount_Label
        '
        Me.Discount_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Discount_Label.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalculationBindingSource, "Discount", True))
        Me.Discount_Label.Location = New System.Drawing.Point(165, 100)
        Me.Discount_Label.Name = "Discount_Label"
        Me.Discount_Label.Size = New System.Drawing.Size(100, 23)
        Me.Discount_Label.TabIndex = 18
        '
        'OrderSubTotalLabel
        '
        Me.OrderSubTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OrderSubTotalLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalculationBindingSource, "Order_Sub_Total", True))
        Me.OrderSubTotalLabel.Location = New System.Drawing.Point(164, 74)
        Me.OrderSubTotalLabel.Name = "OrderSubTotalLabel"
        Me.OrderSubTotalLabel.Size = New System.Drawing.Size(100, 23)
        Me.OrderSubTotalLabel.TabIndex = 17
        '
        'TotalQuantityLabel
        '
        Me.TotalQuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalQuantityLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalculationBindingSource, "Total_Quantity", True))
        Me.TotalQuantityLabel.Location = New System.Drawing.Point(164, 44)
        Me.TotalQuantityLabel.Name = "TotalQuantityLabel"
        Me.TotalQuantityLabel.Size = New System.Drawing.Size(100, 23)
        Me.TotalQuantityLabel.TabIndex = 16
        '
        'Change_Label
        '
        Me.Change_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Change_Label.Location = New System.Drawing.Point(164, 255)
        Me.Change_Label.Name = "Change_Label"
        Me.Change_Label.Size = New System.Drawing.Size(100, 23)
        Me.Change_Label.TabIndex = 15
        '
        'Cash_TextBox
        '
        Me.Cash_TextBox.Location = New System.Drawing.Point(164, 223)
        Me.Cash_TextBox.Name = "Cash_TextBox"
        Me.Cash_TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Cash_TextBox.TabIndex = 13
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(318, 313)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Receipt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox1.Controls.Add(Me.btnCC)
        Me.GroupBox1.Controls.Add(Me.btn_calculate_current)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.lblCurrent)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.lblChange)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.txtCash)
        Me.GroupBox1.Controls.Add(Me.Label66)
        Me.GroupBox1.Controls.Add(Me.cmbCurreny)
        Me.GroupBox1.Controls.Add(Me.btnConvert)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.Label64)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 382)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 270)
        Me.GroupBox1.TabIndex = 144
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculate Counter"
        '
        'btn_calculate_current
        '
        Me.btn_calculate_current.Location = New System.Drawing.Point(78, 226)
        Me.btn_calculate_current.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_calculate_current.Name = "btn_calculate_current"
        Me.btn_calculate_current.Size = New System.Drawing.Size(128, 34)
        Me.btn_calculate_current.TabIndex = 145
        Me.btn_calculate_current.Text = "Calculate Current"
        Me.btn_calculate_current.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(106, 199)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 144
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblCurrent
        '
        Me.lblCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrent.Location = New System.Drawing.Point(145, 82)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(100, 23)
        Me.lblCurrent.TabIndex = 143
        '
        'lblChange
        '
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChange.Location = New System.Drawing.Point(145, 160)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(100, 23)
        Me.lblChange.TabIndex = 142
        '
        'txtCash
        '
        Me.txtCash.Location = New System.Drawing.Point(145, 128)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(100, 22)
        Me.txtCash.TabIndex = 140
        '
        'Label66
        '
        Me.Label66.Location = New System.Drawing.Point(41, 36)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(100, 30)
        Me.Label66.TabIndex = 137
        Me.Label66.Text = "Other Country"
        '
        'cmbCurreny
        '
        Me.cmbCurreny.FormattingEnabled = True
        Me.cmbCurreny.Location = New System.Drawing.Point(147, 37)
        Me.cmbCurreny.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCurreny.Name = "cmbCurreny"
        Me.cmbCurreny.Size = New System.Drawing.Size(106, 24)
        Me.cmbCurreny.TabIndex = 136
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(6, 199)
        Me.btnConvert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(83, 25)
        Me.btnConvert.TabIndex = 133
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(200, 199)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 138
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label64
        '
        Me.Label64.Location = New System.Drawing.Point(41, 82)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(64, 30)
        Me.Label64.TabIndex = 134
        Me.Label64.Text = "Current "
        '
        'btnCC
        '
        Me.btnCC.BackColor = System.Drawing.Color.FloralWhite
        Me.btnCC.Location = New System.Drawing.Point(0, 23)
        Me.btnCC.Name = "btnCC"
        Me.btnCC.Size = New System.Drawing.Size(281, 241)
        Me.btnCC.TabIndex = 143
        Me.btnCC.Text = "Current Counter"
        Me.btnCC.UseVisualStyleBackColor = False
        '
        'OrderList
        '
        Me.OrderList.BackColor = System.Drawing.Color.LemonChiffon
        Me.OrderList.Controls.Add(Me.ListBox1)
        Me.OrderList.Controls.Add(Me.btn_Calculate)
        Me.OrderList.Controls.Add(Me.btn_calculation)
        Me.OrderList.Location = New System.Drawing.Point(31, 65)
        Me.OrderList.Name = "OrderList"
        Me.OrderList.Size = New System.Drawing.Size(281, 311)
        Me.OrderList.TabIndex = 143
        Me.OrderList.TabStop = False
        Me.OrderList.Text = "button"
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Location = New System.Drawing.Point(190, 282)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(75, 23)
        Me.btn_Calculate.TabIndex = 1
        Me.btn_Calculate.Text = "Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'btn_calculation
        '
        Me.btn_calculation.Location = New System.Drawing.Point(190, 327)
        Me.btn_calculation.Name = "btn_calculation"
        Me.btn_calculation.Size = New System.Drawing.Size(98, 23)
        Me.btn_calculation.TabIndex = 0
        Me.btn_calculation.Text = "Calculation"
        Me.btn_calculation.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(26, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(654, 39)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Calculation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CalculationTableAdapter
        '
        Me.CalculationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CalculationTableAdapter = Me.CalculationTableAdapter
        Me.TableAdapterManager.UpdateOrder = FoodOrderingSystem.CalculationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CalculationBindingNavigator
        '
        Me.CalculationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CalculationBindingNavigator.BindingSource = Me.CalculationBindingSource
        Me.CalculationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CalculationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CalculationBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CalculationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CalculationBindingNavigatorSaveItem})
        Me.CalculationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CalculationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CalculationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CalculationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CalculationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CalculationBindingNavigator.Name = "CalculationBindingNavigator"
        Me.CalculationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CalculationBindingNavigator.Size = New System.Drawing.Size(753, 27)
        Me.CalculationBindingNavigator.TabIndex = 145
        Me.CalculationBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'CalculationBindingNavigatorSaveItem
        '
        Me.CalculationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CalculationBindingNavigatorSaveItem.Image = CType(resources.GetObject("CalculationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CalculationBindingNavigatorSaveItem.Name = "CalculationBindingNavigatorSaveItem"
        Me.CalculationBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.CalculationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.MemberTableAdapter = Me.MemberTableAdapter
        Me.TableAdapterManager1.UpdateOrder = FoodOrderingSystem.MemberDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(6, 21)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(269, 244)
        Me.ListBox1.TabIndex = 2
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(753, 656)
        Me.Controls.Add(Me.CalculationBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OrderList)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form8"
        Me.Text = "Form8"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CalculationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalculationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.OrderList.ResumeLayout(False)
        CType(Me.CalculationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CalculationBindingNavigator.ResumeLayout(False)
        Me.CalculationBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Change_Label As Label
    Friend WithEvents Cash_TextBox As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblChange As Label
    Friend WithEvents txtCash As TextBox
    Friend WithEvents Label66 As Label
    Friend WithEvents cmbCurreny As ComboBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label64 As Label
    Friend WithEvents OrderList As GroupBox
    Friend WithEvents btn_calculation As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CalculationDataSet As CalculationDataSet
    Friend WithEvents CalculationBindingSource As BindingSource
    Friend WithEvents CalculationTableAdapter As CalculationDataSetTableAdapters.CalculationTableAdapter
    Friend WithEvents TableAdapterManager As CalculationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CalculationBindingNavigator As BindingNavigator
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
    Friend WithEvents CalculationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Ref_NoTextBox As TextBox
    Friend WithEvents TotalPriceLabel As Label
    Friend WithEvents ServicesTaxLabel As Label
    Friend WithEvents AfterDiscountLabel As Label
    Friend WithEvents Discount_Label As Label
    Friend WithEvents OrderSubTotalLabel As Label
    Friend WithEvents TotalQuantityLabel As Label
    Friend WithEvents MemberDataSet As MemberDataSet
    Friend WithEvents MemberBindingSource As BindingSource
    Friend WithEvents MemberTableAdapter As MemberDataSetTableAdapters.MemberTableAdapter
    Friend WithEvents TableAdapterManager1 As MemberDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Full_NameTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents btn_Calculate As Button
    Friend WithEvents btnCC As Button
    Friend WithEvents lblCurrent As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btn_calculate_current As Button
    Friend WithEvents Order_Date_TextBox As TextBox
    Friend WithEvents Order_TimeTextBox As TextBox
    Friend WithEvents ListBox1 As ListBox
End Class
