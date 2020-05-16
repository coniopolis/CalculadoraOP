Public Class Cientifica

    Private Sub EstandarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstandarToolStripMenuItem.Click
        Estandar.Show()
        Me.Close()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub VerLaAyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerLaAyudaToolStripMenuItem.Click
        MessageBox.Show("Disponible en la proxima version", "Ayuda")
    End Sub
    Private Sub AcerdaDeCalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcerdaDeCalculadoraToolStripMenuItem.Click
        MessageBox.Show("Calculadora de Lautaro Martinez, Mayo 2020, Version 1.2", "Acerda de")
    End Sub




    Dim num1, num2, Resultado As Double
    Dim Operador As Double
    Dim ms, mmas, mmenos As Double

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        Try
            If txtNumero.Text <> "0" And txtNumero.Text <> "" Then
                txtNumero.Text &= "0"
            Else
                txtNumero.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Try
            If txtNumero.Text = "0" Then
                txtNumero.Clear()
                txtNumero.Text = "1"
            Else
                txtNumero.Text &= "1"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Try
            If txtNumero.Text = "0" Then
                txtNumero.Clear()
                txtNumero.Text = "2"
            Else
                txtNumero.Text &= "2"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Try
            If txtNumero.Text = "0" Then
                txtNumero.Clear()
                txtNumero.Text = "3"
            Else
                txtNumero.Text &= "3"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Try
            If txtNumero.Text = "0" Then
                txtNumero.Clear()
                txtNumero.Text = "4"
            Else
                txtNumero.Text &= "4"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Try
            If txtNumero.Text = "0" Then
                txtNumero.Clear()
                txtNumero.Text = "5"
            Else
                txtNumero.Text &= "5"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Try
            If txtNumero.Text = "0" Then
                txtNumero.Clear()
                txtNumero.Text = "6"
            Else
                txtNumero.Text &= "6"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        Try
            If txtNumero.Text = "0" Then
                txtNumero.Clear()
                txtNumero.Text = "7"
            Else
                txtNumero.Text &= "7"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        Try
            If txtNumero.Text = "0" Then
                txtNumero.Clear()
                txtNumero.Text = "9"
            Else
                txtNumero.Text &= "9"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
    Public Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
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
        txtDetalle.Text = num1 & " + "
    End Sub
    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Try
            If txtNumero.Text = "0" Then
                txtNumero.Clear()
                txtNumero.Text = "-"
                btnIgual.Focus()
            ElseIf Val(txtNumero.Text) < 0 Then
                Operador = 2
                num1 = txtNumero.Text
                txtNumero.Clear()
                txtDetalle.Text = num1 & " - "
                btnIgual.Focus()
            ElseIf Val(txtNumero.Text) > 0 Then
                Operador = 2
                num1 = txtNumero.Text
                txtNumero.Clear()
                txtDetalle.Text = num1 & " - "
                btnIgual.Focus()
            ElseIf txtNumero.Text = "" Then
                txtNumero.Text = "-" & txtNumero.Text
                btnIgual.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
                                    If Operador = 7 Then
                                        Resultado = num1 ^ (1 / num2)
                                        txtNumero.Text = Resultado
                                        txtDetalle.Text = num2 & txtDetalle.Text
                                    Else
                                        If Operador = 8 Then
                                            Resultado = Math.Round(Math.Log((num2), (num1)))
                                            txtNumero.Text = Resultado
                                            txtDetalle.Text &= num2
                                        Else
                                        End If
                                    End If
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
        Try
            If btnX2.Text = "x²" Then
                txtDetalle.Text = "" & txtNumero.Text & "²"
                txtNumero.Text = txtNumero.Text * txtNumero.Text
            Else
                txtDetalle.Text = "²√" & txtNumero.Text
                txtNumero.Text = Math.Sqrt(txtNumero.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnX3_Click(sender As Object, e As EventArgs) Handles btnX3.Click
        Try
            If btnX3.Text = "x³" Then
                num1 = txtNumero.Text
                num1 = num1 * num1 * num1
                txtDetalle.Text = "cubo(" & txtNumero.Text & ")"
                txtNumero.Text = num1
            Else
                txtDetalle.Text = "³√" & txtNumero.Text
                txtNumero.Text = txtNumero.Text ^ (1 / 3)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnXY_Click(sender As Object, e As EventArgs) Handles btnXY.Click
        Try
            If btnXY.Text = "xʸ" Then
                Operador = 5
                num1 = txtNumero.Text
                txtNumero.Clear()
                txtDetalle.Text = num1 & " ^ "
            ElseIf btnXY.Text = "ʸ√ₓ" Then
                Operador = 7
                num1 = txtNumero.Text
                txtDetalle.Text = "√" & txtNumero.Text
                txtNumero.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnLog_Click(se8nder As Object, e As EventArgs) Handles btnLog.Click
        Try
            If btnLog.Text = "log" Then
                txtDetalle.Text = "Log10(" & txtNumero.Text & ")"
                txtNumero.Text = Math.Log10(d:=txtNumero.Text)
            Else
                Operador = 8
                num1 = txtNumero.Text
                txtDetalle.Text = num1 & " base log "
                txtNumero.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn10X_Click(sender As Object, e As EventArgs) Handles btn10X.Click
        Try
            If btn10X.Text = "10ˣ" Then
                num1 = 10
                txtDetalle.Text = "10 ^ " & txtNumero.Text
                num2 = txtNumero.Text
                txtNumero.Text = num1 ^ num2
            Else
                num1 = 2
                txtDetalle.Text = "2 ^ (" & txtNumero.Text & ")"
                num2 = txtNumero.Text
                txtNumero.Text = num1 ^ num2
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnLN_Click(sender As Object, e As EventArgs) Handles btnLN.Click
        Try
            If btnLN.Text = "ln" Then
                txtDetalle.Text = "ln(" & txtNumero.Text & ")"
                txtNumero.Text = Math.Log(txtNumero.Text)
            Else
                num1 = Math.E
                txtDetalle.Text = "e^(" & txtNumero.Text & ")"
                num2 = txtNumero.Text
                txtNumero.Text = num1 ^ num2
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnParIzq_Click(sender As Object, e As EventArgs) Handles btnParIzq.Click
        txtNumero.Text = txtNumero.Text & "("
    End Sub
    Private Sub btnParDer_Click(sender As Object, e As EventArgs) Handles btnParDer.Click
        txtNumero.Text = txtNumero.Text & ")"
    End Sub
    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        txtDetalle.Text = "exp" & txtNumero.Text
        txtNumero.Text = Math.Exp(txtNumero.Text)
    End Sub
    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        txtNumero.Text = Math.E
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        Dim i As Integer
        Try
            num1 = txtNumero.Text
            num2 = 1
            For i = 1 To num1
                num2 = num2 * i
                txtDetalle.Text = "fact(" & num1 & ")"
                txtNumero.Text = num2
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAbs_Click(sender As Object, e As EventArgs) Handles btnAbs.Click
        num1 = txtNumero.Text
        txtDetalle.Text = "|" & num1 & "|"
        txtNumero.Text = Math.Abs(num1)
    End Sub

    Private Sub cbTrigo_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbTrigo.SelectedIndexChanged
        Trigonometria()
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

    Private Sub cbFuncion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFuncion.SelectedIndexChanged

    End Sub

    Private Sub btn2nd_Click(sender As Object, e As EventArgs) Handles btn2nd.Click
        Try
            If btnX2.Text = "x²" Then
                btnX2.Text = "²√ₓ"
                btnX3.Text = "³√ₓ"
                btnXY.Text = "ʸ√ₓ"
                btn10X.Text = "2ˣ"
                btnLog.Text = "logyx"
                btnLN.Text = "eˣ"
            Else
                btnX2.Text = "x²"
                btnX3.Text = "x³"
                btnXY.Text = "Xʸ"
                btn10X.Text = "10ˣ"
                btnLog.Text = "log"
                btnLN.Text = "ln"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Public Sub Trigonometria()
        If cbTrigo.Text = "hyp" Then
            cbTrigo.Items.Clear()
            cbTrigo.Items.Add("Δ Trigonometria")
            'cbTrigo.Items.Add("2nd")
            cbTrigo.Items.Add("sinh")
            cbTrigo.Items.Add("cosh")
            cbTrigo.Items.Add("tanh")
            cbTrigo.Items.Add("sech")
            cbTrigo.Items.Add("csch")
            cbTrigo.Items.Add("coth")
            'ElseIf cbTrigo.Text = "2nd" Then
            '    cbTrigo.Items.Clear()
            '    cbTrigo.Items.Add("Δ Trigonometria")
            '    cbTrigo.Items.Add("hyp")
            '    cbTrigo.Items.Add("sin¯¹")
            '    cbTrigo.Items.Add("cos¯¹")
            '    cbTrigo.Items.Add("tan¯¹")
            '    cbTrigo.Items.Add("sec¯¹")
            '    cbTrigo.Items.Add("csc¯¹")
            '    cbTrigo.Items.Add("cot¯¹")
        ElseIf cbTrigo.Text = "Δ Trigonometria" Then
            cbTrigo.Items.Clear()
            'cbTrigo.Items.Add("2nd")
            cbTrigo.Items.Add("hyp")
            cbTrigo.Items.Add("sin")
            cbTrigo.Items.Add("cos")
            cbTrigo.Items.Add("tan")
            cbTrigo.Items.Add("sec")
            cbTrigo.Items.Add("csc")
            cbTrigo.Items.Add("cot")
        End If

        FuncionesTrigonometricas()
    End Sub

    Public Sub FuncionesTrigonometricas()
        If cbTrigo.Text = "sin" Then
            txtDetalle.Text = "sin₀(" & txtNumero.Text & ")"
            txtNumero.Text = Math.Sin(txtNumero.Text)

        ElseIf cbTrigo.Text = "cos" Then
            txtDetalle.Text = "cos₀(" & txtNumero.Text & ")"
            txtNumero.Text = Math.Cos(txtNumero.Text)

        ElseIf cbTrigo.Text = "tan" Then
            txtDetalle.Text = "tan₀(" & txtNumero.Text & ")"
            txtNumero.Text = Math.Tan(txtNumero.Text)

        ElseIf cbTrigo.Text = "sec" Then
            txtDetalle.Text = "sec₀(" & txtNumero.Text & ")"
            txtNumero.Text = 1 / (Math.Sin(txtNumero.Text))

        ElseIf cbTrigo.Text = "csc" Then
            txtDetalle.Text = "csc₀(" & txtNumero.Text & ")"
            txtNumero.Text = 1 / (Math.Cos(txtNumero.Text))

        ElseIf cbTrigo.Text = "cot" Then
            txtDetalle.Text = "cot₀(" & txtNumero.Text & ")"
            txtNumero.Text = 1 / (Math.Tan(txtNumero.Text))

        ElseIf cbTrigo.Text = "sinh" Then
            txtDetalle.Text = "sinh(" & txtNumero.Text & ")"
            txtNumero.Text = Math.Sinh(txtNumero.Text)

        ElseIf cbTrigo.Text = "cosh" Then
            txtDetalle.Text = "cosh(" & txtNumero.Text & ")"
            txtNumero.Text = Math.Cosh(txtNumero.Text)

        ElseIf cbTrigo.Text = "tanh" Then
            txtDetalle.Text = "tanh(" & txtNumero.Text & ")"
            txtNumero.Text = Math.Tanh(txtNumero.Text)

        ElseIf cbTrigo.Text = "sech" Then
            txtDetalle.Text = "sech(" & txtNumero.Text & ")"
            txtNumero.Text = 1 / (Math.Sinh(txtNumero.Text))

        ElseIf cbTrigo.Text = "csch" Then
            txtDetalle.Text = "csch(" & txtNumero.Text & ")"
            txtNumero.Text = 1 / (Math.Cosh(txtNumero.Text))

        ElseIf cbTrigo.Text = "coth" Then
            txtDetalle.Text = "coth(" & txtNumero.Text & ")"
            txtNumero.Text = 1 / (Math.Tanh(txtNumero.Text))

            'ElseIf cbTrigo.Text = "sin¯¹" Then
            '    txtDetalle.Text = "sin₀¯¹(" & txtNumero.Text & ")"
            '    txtNumero.Text = Math.Asin(txtNumero.Text)

            'ElseIf cbTrigo.Text = "cos¯¹" Then
            '    txtDetalle.Text = "cos₀¯¹(" & txtNumero.Text & ")"
            '    txtNumero.Text = Math.Acos(txtNumero.Text)

            'ElseIf cbTrigo.Text = "tan¯¹" Then
            '    txtDetalle.Text = "tan₀¯¹(" & txtNumero.Text & ")"
            '    txtNumero.Text = Math.Tan(txtNumero.Text)

            'ElseIf cbTrigo.Text = "sec¯¹" Then
            '    txtDetalle.Text = "sec₀¯¹(" & txtNumero.Text & ")"
            '    txtNumero.Text = 1 / (Math.Sin(txtNumero.Text))

            'ElseIf cbTrigo.Text = "csc¯¹" Then
            '    txtDetalle.Text = "csc₀¯¹(" & txtNumero.Text & ")"
            '    txtNumero.Text = 1 / (Math.Cos(txtNumero.Text))

            'ElseIf cbTrigo.Text = "cot¯¹" Then
            '    txtDetalle.Text = "cot₀¯¹(" & txtNumero.Text & ")"
            '    txtNumero.Text = 1 / (Math.(txtNumero.Text))

        End If
    End Sub

End Class