Public Class Cientifica

    Private Sub EstandarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstandarToolStripMenuItem.Click
        Estandar.Show()
        Me.Close()
    End Sub

    Dim num1, num2, Resultado As Double
    Dim Operador As Double
    Dim ms, mmas, mmenos As Double


    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub AcerdaDeCalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcerdaDeCalculadoraToolStripMenuItem.Click
        MessageBox.Show("Calculadora de Lautaro Martinez, Mayo 2020", "Acerda de")
    End Sub
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtNumero.Text <> "0" And txtNumero.Text <> "" Then
            txtNumero.Text &= "0"
        Else
            txtNumero.Text = "0"
        End If
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtNumero.Text = "0" Then
            txtNumero.Clear()
            txtNumero.Text = "1"
        Else
            txtNumero.Text &= "1"
        End If
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtNumero.Text = "0" Then
            txtNumero.Clear()
            txtNumero.Text = "2"
        Else
            txtNumero.Text &= "2"
        End If
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtNumero.Text = "0" Then
            txtNumero.Clear()
            txtNumero.Text = "3"
        Else
            txtNumero.Text &= "3"
        End If
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtNumero.Text = "0" Then
            txtNumero.Clear()
            txtNumero.Text = "4"
        Else
            txtNumero.Text &= "4"
        End If
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtNumero.Text = "0" Then
            txtNumero.Clear()
            txtNumero.Text = "5"
        Else
            txtNumero.Text &= "5"
        End If
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtNumero.Text = "0" Then
            txtNumero.Clear()
            txtNumero.Text = "6"
        Else
            txtNumero.Text &= "6"
        End If
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtNumero.Text = "0" Then
            txtNumero.Clear()
            txtNumero.Text = "7"
        Else
            txtNumero.Text &= "7"
        End If
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtNumero.Text = "0" Then
            txtNumero.Clear()
            txtNumero.Text = "8"
        Else
            txtNumero.Text &= "8"
        End If
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtNumero.Text = "0" Then
            txtNumero.Clear()
            txtNumero.Text = "9"
        Else
            txtNumero.Text &= "9"
        End If
    End Sub
    Private Sub btnComa_Click(sender As Object, e As EventArgs) Handles btnComa.Click
        Try
            If txtNumero.Text.IndexOf(",") > 0 Then 'IndexOf para "ENCONTRAR" si hay coma
                Beep() 'Se usa para dar aviso que ya hay coma
            ElseIf txtNumero.Text <> "0" Then
                txtNumero.Text = txtNumero.Text & ","
            Else
                txtNumero.Text = "0,"
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtNumero.Text = "0"
        txtDetalle.Text = String.Empty
        Operador = 0.0
        num1 = 0.0
        num2 = 0.0
    End Sub
    Private Sub btnRetroceso_Click(sender As Object, e As EventArgs) Handles btnRetroceso.Click
        Try
            If txtNumero.Text <> "0" And Len(txtNumero.Text) > 1 Then
                txtNumero.Text = txtNumero.Text.Remove(txtNumero.Text.Length - 1) 'borra el ultimo caracter                                                             )
            Else
                txtNumero.Text = "0" 'cuando queda el ultimo caracter, lo vuelve cero
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Operador = 1
        num1 = txtNumero.Text
        txtNumero.Clear()
        txtDetalle.Text &= num1 & " + "
    End Sub
    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        If txtDetalle.Text.IndexOf("/") Then
            txtNumero.Text = "-" & txtNumero.Text
        Else
            Operador = 2
            num1 = txtNumero.Text
            txtNumero.Clear()
            txtDetalle.Text = num1 & " - "
        End If
    End Sub
    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        Operador = 3
        num1 = txtNumero.Text
        txtNumero.Clear()
        txtDetalle.Text = num1 & " × "
    End Sub
    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Operador = 4
        num1 = txtNumero.Text
        txtNumero.Clear()
        txtDetalle.Text = num1 & " / "
    End Sub
    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        num2 = txtNumero.Text
        Try
            If Operador = 1 Then
                Resultado = num1 + num2
                txtNumero.Text = Resultado
                txtDetalle.Text &= num2
            Else
                If Operador = 2 Then
                    Resultado = num1 - num2
                    txtNumero.Text = Resultado
                    txtDetalle.Text &= num2
                Else
                    If Operador = 3 Then
                        Resultado = num1 * num2
                        txtNumero.Text = Resultado
                        txtDetalle.Text &= num2
                    Else
                        If Operador = 4 Then
                            Resultado = num1 / num2
                            txtNumero.Text = Resultado
                            txtDetalle.Text &= num2
                        Else
                            If Operador = 5 Then
                                Resultado = num1 ^ num2
                                txtNumero.Text = Resultado
                                txtDetalle.Text &= num2
                            Else
                                If Operador = 6 Then
                                    Resultado = num1 Mod num2
                                    txtNumero.Text = Resultado
                                    txtDetalle.Text &= num2
                                Else
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnSobre_Click(sender As Object, e As EventArgs) Handles btnReciproco.Click
        Try
            If txtNumero.Text <> "0" Then
                num1 = Val(txtNumero.Text)
                txtDetalle.Text = txtDetalle.Text & 1 & " / " & num1
                txtNumero.Text = 1 / Val(txtNumero.Text)
            Else
                txtNumero.Text = "Math ERROR"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnCambioSigno_Click(sender As Object, e As EventArgs) Handles btnSigno.Click
        Try
            If txtNumero.Text <> "" Then
                txtNumero.Text = txtNumero.Text * (-1)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnPi_Click(sender As Object, e As EventArgs) Handles btnPi.Click
        Try
            txtNumero.Text = Math.PI
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnX2_Click(sender As Object, e As EventArgs) Handles btnX2.Click
        txtDetalle.Text = "" & txtNumero.Text & "²"
        txtNumero.Text = txtNumero.Text * txtNumero.Text
    End Sub
    Private Sub btnX3_Click(sender As Object, e As EventArgs) Handles btnX3.Click
        num1 = txtNumero.Text
        num1 = num1 * num1 * num1
        txtDetalle.Text = "cubo(" & txtNumero.Text & ")"
        txtNumero.Text = num1
    End Sub
    Private Sub btnXY_Click(sender As Object, e As EventArgs) Handles btnXY.Click
        Operador = 5
        num1 = txtNumero.Text
        txtNumero.Clear()
        txtDetalle.Text = num1 & " ^ "
    End Sub
    Private Sub btnLog_Click(se8nder As Object, e As EventArgs) Handles btnLog.Click
        txtDetalle.Text = "Log10(" & txtNumero.Text & ")"
        txtNumero.Text = Math.Log10(d:=txtNumero.Text)
    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        txtDetalle.Text = "exp" & txtNumero.Text
        txtNumero.Text = Math.Exp(txtNumero.Text)
    End Sub

    Private Sub btn10X_Click(sender As Object, e As EventArgs) Handles btn10X.Click
        num1 = 10
        txtDetalle.Text = "10 ^ " & txtNumero.Text
        num2 = txtNumero.Text
        txtNumero.Text = num1 ^ num2
    End Sub
    Private Sub btnParIzq_Click(sender As Object, e As EventArgs) Handles btnParIzq.Click
        txtNumero.Text = txtNumero.Text & "("
    End Sub

    Private Sub btnParDer_Click(sender As Object, e As EventArgs) Handles btnParDer.Click
        txtNumero.Text = txtNumero.Text & ")"
    End Sub
    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        If txtNumero.Text = "0" Then
            Operador = 6
            num1 = 0
            txtNumero.Clear()
            txtDetalle.Text = num1 & " mod "
        Else
            Operador = 6
            num1 = txtNumero.Text
            txtNumero.Clear()
            txtDetalle.Text = num1 & " mod "
        End If
    End Sub
    Private Sub btnLN_Click(sender As Object, e As EventArgs) Handles btnLN.Click
        txtDetalle.Text = "ln(" & txtNumero.Text & ")"
        txtNumero.Text = Math.Log(txtNumero.Text)
    End Sub

    Private Sub btnMC_Click(sender As Object, e As EventArgs) Handles btnMC.Click
        num1 = 0.0
        num2 = 0.0
        ms = 0
        mmas = 0
        mmenos = 0
        txtNumero.Text = 0
        txtDetalle.Text = ""
    End Sub
    Private Sub btnMR_Click(sender As Object, e As EventArgs) Handles btnMR.Click
        txtNumero.Text = ms
    End Sub
    Private Sub btnMS_Click(sender As Object, e As EventArgs) Handles btnMS.Click
        ms = Val(txtNumero.Text)
        txtDetalle.Text = "M"
    End Sub
    Private Sub btnMmas_Click(sender As Object, e As EventArgs) Handles btnMmas.Click
        mmas = Val(txtNumero.Text) + ms
        txtNumero.Text = mmas
        txtDetalle.Text = "M+"
    End Sub
    Private Sub btnMmenos_Click(sender As Object, e As EventArgs) Handles btnMmenos.Click
        mmenos = Val(txtNumero.Text) - ms
        txtNumero.Text = mmenos
        txtDetalle.Text = "M-"
    End Sub
    Private Sub btn2nd_Click(sender As Object, e As EventArgs) Handles btn2nd.Click
        If btnX2.Text.IndexOf("x²") Then
            btnX2.Text = "²√ₓ"
        Else
            Exit Sub
        End If

    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown 'Codigo para introducir numeros y operaciones por teclado
        Select Case e.KeyData
            Case Keys.NumPad0, Keys.D0
                btn0.Focus()
                btn0.PerformClick()
                btnIgual.Focus()
            Case Keys.NumPad1, Keys.D1
                btn1.Focus()
                btn1.PerformClick()
                btnIgual.Focus()
            Case Keys.NumPad2, Keys.D2
                btn2.Focus()
                btn2.PerformClick()
                btnIgual.Focus()
            Case Keys.NumPad3, Keys.D3
                btn3.Focus()
                btn3.PerformClick()
                btnIgual.Focus()
            Case Keys.NumPad4, Keys.D4
                btn4.Focus()
                btn4.PerformClick()
                btnIgual.Focus()
            Case Keys.NumPad5, Keys.D5
                btn5.Focus()
                btn5.PerformClick()
                btnIgual.Focus()
            Case Keys.NumPad6, Keys.D6
                btn6.Focus()
                btn6.PerformClick()
                btnIgual.Focus()
            Case Keys.NumPad7, Keys.D7
                btn7.Focus()
                btn7.PerformClick()
                btnIgual.Focus()
            Case Keys.NumPad8, Keys.D8
                btn8.Focus()
                btn8.PerformClick()
                btnIgual.Focus()
            Case Keys.NumPad9, Keys.D9
                btn9.Focus()
                btn9.PerformClick()
                btnIgual.Focus()
            Case Keys.Add
                btnSuma.Focus()
                btnSuma.PerformClick()
            Case Keys.Subtract
                btnResta.Focus()
                btnResta.PerformClick()
            Case Keys.Multiply
                btnMultiplicar.Focus()
                btnMultiplicar.PerformClick()
            Case Keys.Divide
                btnDivision.Focus()
                btnDivision.PerformClick()
            Case Keys.Back
                btnRetroceso.Focus()
                btnRetroceso.PerformClick()
            Case Keys.Decimal
                btnComa.Focus()
                btnComa.PerformClick()
        End Select
    End Sub
End Class