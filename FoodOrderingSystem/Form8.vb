Public Class Form8
    Dim US_Dollar As Double = 5.01
    Dim Philippine_Peso As Double = 71.74
    Dim Indian_Rupee As Double = 101.71
    Dim Singapore_Sing As Double = 4.3

    Private Sub CalculationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CalculationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CalculationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CalculationDataSet)

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MemberDataSet.Member' table. You can move, or remove it, as needed.
        'Me.MemberTableAdapter.Fill(Me.MemberDataSet.Member)
        'TODO: This line of code loads data into the 'CalculationDataSet.Calculation' table. You can move, or remove it, as needed.
        'Me.CalculationTableAdapter.Fill(Me.CalculationDataSet.Calculation)

        cmbCurreny.Text = "Choose One....."
        cmbCurreny.Items.Add("USA")
        cmbCurreny.Items.Add("Philippine")
        cmbCurreny.Items.Add("India")
        cmbCurreny.Items.Add("Singapore")
    End Sub

    Private Sub btn_Calculate_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click
        Form1.Show()
        'Order_Date_TextBox = Today
        'Order_TimeTextBox = TimeOfDay
        Dim decTotalQuantity, decDiscount, decAfterDiscount, decOrderSubTotal, decServicesTax, decTotalPrice, decCash, decChange As Decimal


        decTotalQuantity = Integer.Parse(TotalQuantityLabel.Text)
        decOrderSubTotal = Decimal.Parse(OrderSubTotalLabel.Text)
        decDiscount = Decimal.Parse(Discount_Label.Text)
        decAfterDiscount = Decimal.Parse(AfterDiscountLabel.Text)
        decServicesTax = Decimal.Parse(ServicesTaxLabel.Text)
        decTotalPrice = Decimal.Parse(TotalPriceLabel.Text)
        decCash = Decimal.Parse(Cash_TextBox.Text)
        decChange = Decimal.Parse(Change_Label.Text)

        decTotalQuantity = Form1.txtLava.Text + Form1.txtCheese.Text + Form1.txtStraw.Text + Form1.txtMango.Text + Form1.txtFrench.Text + Form1.txtOnion.Text + Form1.txtPineapple.Text + Form1.txtFloss.Text + Form1.txtTart1.Text + Form1.txtTart2.Text + Form1.txtTart3.Text + Form1.txtTart4.Text
        decOrderSubTotal = Form1.SubTotalLava.Text + Form1.SubTotalCheese.Text + Form1.SubTotalPudding.Text + Form1.SubTotalMango.Text + Form1.SubTotalFrench.Text + Form1.SubTotalOnion.Text + Form1.SubTotalButter.Text + Form1.SubTotalFloss.Text + Form1.SubTotalStraw.Text + Form1.SubTotalMini.Text + Form1.SubTotalEgg.Text + Form1.SubTotalBlue.Text
        If decOrderSubTotal >= 20 And decOrderSubTotal <= 49 Then
            decDiscount = decOrderSubTotal * 0.005
        ElseIf decOrderSubTotal >= 50 And decOrderSubTotal <= 99 Then
            decDiscount = decOrderSubTotal * 0.01
        ElseIf decOrderSubTotal >= 100 Then
            decDiscount = decOrderSubTotal * 0.02
        Else
            decDiscount = 0
        End If


        decAfterDiscount = decOrderSubTotal - decDiscount
        decServicesTax = decAfterDiscount * 0.06
        decTotalPrice = decAfterDiscount - decServicesTax
        decChange = decCash - decTotalPrice

        OrderSubTotalLabel.Text = decDiscount.ToString("N2")
        Discount_Label.Text = decDiscount.ToString("N2")
        AfterDiscountLabel.Text = decDiscount.ToString("N2")
        ServicesTaxLabel.Text = decServicesTax.ToString("N2")
        TotalPriceLabel.Text = decTotalPrice.ToString("N2")
        Change_Label.Text = decChange.ToString("N2")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        btnCC.Visible = True
        lblCurrent.Text = ""
        txtCash.Text = ""
        lblChange.Text = ""
        cmbCurreny.Text = "Choose one..."

    End Sub

    Private Sub btnCC_Click(sender As Object, e As EventArgs) Handles btnCC.Click
        btnCC.Visible = False
    End Sub

    Function CuConverter(ByVal money As Double) As Double

        If cmbCurreny.Text = "USA" Then
            Return Math.Round(US_Dollar * money, 2)
        ElseIf cmbCurreny.Text = "Philippine" Then
            Return Math.Round(Philippine_Peso * money, 2)
        ElseIf cmbCurreny.Text = "India" Then
            Return Math.Round(Indian_Rupee * money, 2)
        ElseIf cmbCurreny.Text = "Singapore" Then
            Return Math.Round(Singapore_Sing * money, 2)
        End If

    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblCurrent.Text = ""
        txtCash.Text = ""
        lblChange.Text = ""
        cmbCurreny.Text = "Choose One..."

    End Sub

    Private Sub btnConvert_Click_1(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim Malaysia_RM As Double = CDbl(lblChange.Text)
        lblChange.Text = CStr(CuConverter(Malaysia_RM))

        If cmbCurreny.Text = "USA" Then
            lblCurrent.Text = "$" & "" & Val(lblCurrent.Text)
        ElseIf cmbCurreny.Text = "Philippine" Then
            lblCurrent.Text = "PHP" & "" & Val(lblCurrent.Text)
        ElseIf cmbCurreny.Text = "India" Then
            lblCurrent.Text = "IDR" & "" & Val(lblCurrent.Text)
        ElseIf cmbCurreny.Text = "Singapore" Then
            lblCurrent.Text = "SGP" & "" & Val(lblCurrent.Text)
        ElseIf cmbCurreny.Text = "Choose One..." Then
            MsgBox("Select a country of your choice", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub btn_calculate_current_Click(sender As Object, e As EventArgs) Handles btn_calculate_current.Click
        Dim Malaysia_RM As Double = CDbl(lblCurrent.Text)
        lblCurrent.Text = CStr(CuConverter(Malaysia_RM))
        lblChange.Text = txtCash.Text - lblCurrent.Text

        If cmbCurreny.Text = "USA" Then
            lblCurrent.Text = "$" & txtCash.Text = "$"
        ElseIf cmbCurreny.Text = "Philippine" Then
            lblChange.Text = "PHP" & txtCash.Text = "PHP"
        ElseIf cmbCurreny.Text = "India" Then
            lblChange.Text = "IDR" & txtCash.Text = "IDR"
        ElseIf cmbCurreny.Text = "Singapore" Then
            lblChange.Text = "SGP" & txtCash.Text = "SGR"
        End If

    End Sub


End Class