Public Class menuPage
    Dim chocoLava As Decimal
    Dim creamCheese As Decimal
    Dim pudding As Decimal
    Dim mangoFloat As Decimal
    Dim frenchBread As Decimal
    Dim cheeseOnion As Decimal
    Dim pineappleButter As Decimal
    Dim chickenFloss As Decimal
    Dim strawTart As Decimal
    Dim fruitTart As Decimal
    Dim eggTart As Decimal
    Dim blueberry As Decimal
    Const LAVA As Decimal = 6.9
    Const CHEESE As Decimal = 8.9
    Const STRAWBERRY As Decimal = 6.5
    Const MANGO As Decimal = 9.9
    Const FRENCH As Decimal = 5.9
    Const ONION As Decimal = 3.9
    Const PINEAPPLE As Decimal = 4.9
    Const FLOSS As Decimal = 3.9
    Const TART1 As Decimal = 3.9
    Const TART2 As Decimal = 4.9
    Const TART3 As Decimal = 2.5
    Const TART4 As Decimal = 4.9

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        txtLava.Text += 1
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        txtStraw.Text += 1
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        txtMango.Text += 1
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        txtCheese.Text += 1
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        txtFrench.Text += 1
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        txtOnion.Text += 1
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        txtPineapple.Text += 1
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        txtFloss.Text += 1
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        txtTart1.Text += 1
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        txtTart2.Text += 1
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        txtTart3.Text += 1
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        txtTart4.Text += 1
    End Sub

    Private Sub btnLavaMinus_Click(sender As Object, e As EventArgs) Handles btnLavaMinus.Click
        txtLava.Text -= 1

        If txtLava.Text <= 0 Then
            txtLava.Text = 0
        End If
    End Sub

    Private Sub btnCheeseMinus_Click(sender As Object, e As EventArgs) Handles btnCheeseMinus.Click
        txtCheese.Text -= 1

        If txtCheese.Text <= 0 Then
            txtCheese.Text = 0
        End If
    End Sub

    Private Sub btnStrawMinus_Click(sender As Object, e As EventArgs) Handles btnStrawMinus.Click
        txtStraw.Text -= 1

        If txtStraw.Text <= 0 Then
            txtStraw.Text = 0
        End If
    End Sub

    Private Sub btnMangoMinus_Click(sender As Object, e As EventArgs) Handles btnMangoMinus.Click
        txtMango.Text -= 1

        If txtMango.Text <= 0 Then
            txtMango.Text = 0
        End If
    End Sub
    Private Sub btnFrenchMinus_Click(sender As Object, e As EventArgs) Handles btnFrenchMinus.Click
        txtFrench.Text -= 1

        If txtFrench.Text <= 0 Then
            txtFrench.Text = 0
        End If
    End Sub

    Private Sub btnOnionMinus_Click(sender As Object, e As EventArgs) Handles btnOnionMinus.Click
        txtOnion.Text -= 1

        If txtOnion.Text <= 0 Then
            txtOnion.Text = 0
        End If
    End Sub

    Private Sub btnPineMinus_Click(sender As Object, e As EventArgs) Handles btnPineMinus.Click
        txtPineapple.Text -= 1

        If txtPineapple.Text <= 0 Then
            txtPineapple.Text = 0
        End If
    End Sub

    Private Sub btnFlossMinus_Click(sender As Object, e As EventArgs) Handles btnFlossMinus.Click
        txtFloss.Text -= 1

        If txtFloss.Text <= 0 Then
            txtFloss.Text = 0
        End If
    End Sub

    Private Sub btnTartMinus_Click(sender As Object, e As EventArgs) Handles btnTartMinus.Click
        txtTart1.Text -= 1

        If txtTart1.Text <= 0 Then
            txtTart1.Text = 0
        End If
    End Sub

    Private Sub btnTart2Minus_Click(sender As Object, e As EventArgs) Handles btnTart2Minus.Click
        txtTart2.Text -= 1

        If txtTart2.Text <= 0 Then
            txtTart2.Text = 0
        End If
    End Sub

    Private Sub btnTart3Minus_Click(sender As Object, e As EventArgs) Handles btnTart3Minus.Click
        txtTart3.Text -= 1

        If txtTart3.Text <= 0 Then
            txtTart3.Text = 0
        End If
    End Sub

    Private Sub btnTart4Minus_Click(sender As Object, e As EventArgs) Handles btnTart4Minus.Click
        txtTart4.Text -= 1

        If txtTart4.Text <= 0 Then
            txtTart4.Text = 0
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        chocoLava = txtLava.Text * LAVA
        creamCheese = txtCheese.Text * CHEESE
        pudding = txtStraw.Text * STRAWBERRY
        mangoFloat = txtMango.Text * MANGO
        frenchBread = txtFrench.Text * FRENCH
        cheeseOnion = txtOnion.Text * ONION
        pineappleButter = txtPineapple.Text * PINEAPPLE
        chickenFloss = txtFloss.Text * FLOSS
        strawTart = txtTart1.Text * TART1
        fruitTart = txtTart2.Text * TART2
        eggTart = txtTart3.Text * TART3
        blueberry = txtTart4.Text * TART4

        SubTotalLava.Text = chocoLava.ToString("C2")
        SubTotalCheese.Text = creamCheese.ToString("C2")
        SubTotalPudding.Text = pudding.ToString("C2")
        SubTotalMango.Text = mangoFloat.ToString("C2")
        SubTotalFrench.Text = frenchBread.ToString("C2")
        SubTotalOnion.Text = cheeseOnion.ToString("C2")
        SubTotalButter.Text = pineappleButter.ToString("C2")
        SubTotalFloss.Text = chickenFloss.ToString("C2")
        SubTotalStraw.Text = strawTart.ToString("C2")
        SubTotalMini.Text = fruitTart.ToString("C2")
        SubTotalEgg.Text = eggTart.ToString("C2")
        SubTotalBlue.Text = blueberry.ToString("C2")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtLava.Text = ""
        txtCheese.Text = ""
        txtStraw.Text = ""
        txtMango.Text = ""
        txtFrench.Text = ""
        txtOnion.Text = ""
        txtPineapple.Text = ""
        txtFloss.Text = ""
        txtTart1.Text = ""
        txtTart2.Text = ""
        txtTart3.Text = ""
        txtTart4.Text = ""
    End Sub

    Private Sub btnOdrConfirm_Click(sender As Object, e As EventArgs) Handles btnOdrConfirm.Click
        Form8.Show（）
    End Sub
End Class
