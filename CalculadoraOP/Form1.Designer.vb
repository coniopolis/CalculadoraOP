<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estandar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estandar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstandarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CientíficaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdiciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarHistorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarEdiciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerLaAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcerdaDeCalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnComa = New System.Windows.Forms.Button()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btnSobre = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btnPorcentaje = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btnRaiz = New System.Windows.Forms.Button()
        Me.btnCambiarSigno = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnCE = New System.Windows.Forms.Button()
        Me.btnRetroceso = New System.Windows.Forms.Button()
        Me.btnMmenos = New System.Windows.Forms.Button()
        Me.btnMmas = New System.Windows.Forms.Button()
        Me.btnMS = New System.Windows.Forms.Button()
        Me.btnMR = New System.Windows.Forms.Button()
        Me.btnMC = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtNumero)
        Me.Panel1.Location = New System.Drawing.Point(12, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(249, 55)
        Me.Panel1.TabIndex = 62
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.White
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumero.Font = New System.Drawing.Font("Consolas", 22.0!)
        Me.txtNumero.Location = New System.Drawing.Point(3, 13)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(239, 35)
        Me.txtNumero.TabIndex = 0
        Me.txtNumero.Text = "0"
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem, Me.EdiciónToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(273, 24)
        Me.MenuStrip1.TabIndex = 61
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstandarToolStripMenuItem, Me.CientíficaToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'EstandarToolStripMenuItem
        '
        Me.EstandarToolStripMenuItem.Name = "EstandarToolStripMenuItem"
        Me.EstandarToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.EstandarToolStripMenuItem.Text = "Estandar"
        '
        'CientíficaToolStripMenuItem
        '
        Me.CientíficaToolStripMenuItem.Name = "CientíficaToolStripMenuItem"
        Me.CientíficaToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.CientíficaToolStripMenuItem.Text = "Científica"
        '
        'EdiciónToolStripMenuItem
        '
        Me.EdiciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.HistorialToolStripMenuItem1})
        Me.EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        Me.EdiciónToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.EdiciónToolStripMenuItem.Text = "Edición"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar                 Ctrl+C"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar                   Ctrl+V"
        '
        'HistorialToolStripMenuItem1
        '
        Me.HistorialToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarHistorialToolStripMenuItem, Me.EditarToolStripMenuItem, Me.CancelarEdiciónToolStripMenuItem, Me.BorrarToolStripMenuItem})
        Me.HistorialToolStripMenuItem1.Name = "HistorialToolStripMenuItem1"
        Me.HistorialToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.HistorialToolStripMenuItem1.Text = "Historial"
        '
        'CopiarHistorialToolStripMenuItem
        '
        Me.CopiarHistorialToolStripMenuItem.Name = "CopiarHistorialToolStripMenuItem"
        Me.CopiarHistorialToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CopiarHistorialToolStripMenuItem.Text = "Copiar Historial"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'CancelarEdiciónToolStripMenuItem
        '
        Me.CancelarEdiciónToolStripMenuItem.Name = "CancelarEdiciónToolStripMenuItem"
        Me.CancelarEdiciónToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CancelarEdiciónToolStripMenuItem.Text = "Cancelar edición"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerLaAyudaToolStripMenuItem, Me.AcerdaDeCalculadoraToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'VerLaAyudaToolStripMenuItem
        '
        Me.VerLaAyudaToolStripMenuItem.Name = "VerLaAyudaToolStripMenuItem"
        Me.VerLaAyudaToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.VerLaAyudaToolStripMenuItem.Text = "Ver la ayuda"
        '
        'AcerdaDeCalculadoraToolStripMenuItem
        '
        Me.AcerdaDeCalculadoraToolStripMenuItem.Name = "AcerdaDeCalculadoraToolStripMenuItem"
        Me.AcerdaDeCalculadoraToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.AcerdaDeCalculadoraToolStripMenuItem.Text = "Acerca de"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'txtDetalle
        '
        Me.txtDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDetalle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.Location = New System.Drawing.Point(12, 36)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(249, 13)
        Me.txtDetalle.TabIndex = 60
        Me.txtDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.Color.White
        Me.btn0.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(12, 371)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(96, 45)
        Me.btn0.TabIndex = 0
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btnComa
        '
        Me.btnComa.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnComa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnComa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComa.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComa.Location = New System.Drawing.Point(114, 371)
        Me.btnComa.Name = "btnComa"
        Me.btnComa.Size = New System.Drawing.Size(45, 45)
        Me.btnComa.TabIndex = 0
        Me.btnComa.Text = ","
        Me.btnComa.UseVisualStyleBackColor = False
        '
        'btnSuma
        '
        Me.btnSuma.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSuma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuma.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.Location = New System.Drawing.Point(165, 371)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(45, 45)
        Me.btnSuma.TabIndex = 0
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = False
        '
        'btnIgual
        '
        Me.btnIgual.BackColor = System.Drawing.Color.White
        Me.btnIgual.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIgual.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgual.Location = New System.Drawing.Point(216, 320)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(45, 96)
        Me.btnIgual.TabIndex = 0
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = False
        '
        'btnResta
        '
        Me.btnResta.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnResta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResta.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.Location = New System.Drawing.Point(165, 320)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(45, 45)
        Me.btnResta.TabIndex = 0
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.White
        Me.btn3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(114, 320)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(45, 45)
        Me.btn3.TabIndex = 0
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.White
        Me.btn2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(63, 320)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(45, 45)
        Me.btn2.TabIndex = 0
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.White
        Me.btn1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(12, 320)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(45, 45)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btnSobre
        '
        Me.btnSobre.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSobre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSobre.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSobre.Location = New System.Drawing.Point(216, 269)
        Me.btnSobre.Name = "btnSobre"
        Me.btnSobre.Size = New System.Drawing.Size(45, 45)
        Me.btnSobre.TabIndex = 0
        Me.btnSobre.Text = "1/x"
        Me.btnSobre.UseVisualStyleBackColor = False
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMultiplicar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMultiplicar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicar.Location = New System.Drawing.Point(165, 269)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(45, 45)
        Me.btnMultiplicar.TabIndex = 0
        Me.btnMultiplicar.Text = "*"
        Me.btnMultiplicar.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.White
        Me.btn6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(114, 269)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(45, 45)
        Me.btn6.TabIndex = 0
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.White
        Me.btn5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(63, 269)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(45, 45)
        Me.btn5.TabIndex = 0
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.White
        Me.btn4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(12, 269)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(45, 45)
        Me.btn4.TabIndex = 0
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btnPorcentaje
        '
        Me.btnPorcentaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPorcentaje.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPorcentaje.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPorcentaje.Location = New System.Drawing.Point(216, 218)
        Me.btnPorcentaje.Name = "btnPorcentaje"
        Me.btnPorcentaje.Size = New System.Drawing.Size(45, 45)
        Me.btnPorcentaje.TabIndex = 0
        Me.btnPorcentaje.Text = "%"
        Me.btnPorcentaje.UseVisualStyleBackColor = False
        '
        'btnDivision
        '
        Me.btnDivision.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDivision.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDivision.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.Location = New System.Drawing.Point(165, 218)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(45, 45)
        Me.btnDivision.TabIndex = 0
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.White
        Me.btn9.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(114, 218)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(45, 45)
        Me.btn9.TabIndex = 0
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.White
        Me.btn8.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn8.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(63, 218)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(45, 45)
        Me.btn8.TabIndex = 0
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.White
        Me.btn7.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(12, 218)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(45, 45)
        Me.btn7.TabIndex = 0
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btnRaiz
        '
        Me.btnRaiz.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRaiz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRaiz.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaiz.Location = New System.Drawing.Point(216, 167)
        Me.btnRaiz.Name = "btnRaiz"
        Me.btnRaiz.Size = New System.Drawing.Size(45, 45)
        Me.btnRaiz.TabIndex = 0
        Me.btnRaiz.Text = "√"
        Me.btnRaiz.UseVisualStyleBackColor = False
        '
        'btnCambiarSigno
        '
        Me.btnCambiarSigno.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCambiarSigno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCambiarSigno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarSigno.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarSigno.Location = New System.Drawing.Point(165, 167)
        Me.btnCambiarSigno.Name = "btnCambiarSigno"
        Me.btnCambiarSigno.Size = New System.Drawing.Size(45, 45)
        Me.btnCambiarSigno.TabIndex = 0
        Me.btnCambiarSigno.Text = "±"
        Me.btnCambiarSigno.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnC.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.Location = New System.Drawing.Point(114, 167)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(45, 45)
        Me.btnC.TabIndex = 0
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btnCE
        '
        Me.btnCE.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCE.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCE.Location = New System.Drawing.Point(63, 167)
        Me.btnCE.Name = "btnCE"
        Me.btnCE.Size = New System.Drawing.Size(45, 45)
        Me.btnCE.TabIndex = 0
        Me.btnCE.Text = "CE"
        Me.btnCE.UseVisualStyleBackColor = False
        '
        'btnRetroceso
        '
        Me.btnRetroceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRetroceso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRetroceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetroceso.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetroceso.Location = New System.Drawing.Point(12, 167)
        Me.btnRetroceso.Name = "btnRetroceso"
        Me.btnRetroceso.Size = New System.Drawing.Size(45, 45)
        Me.btnRetroceso.TabIndex = 0
        Me.btnRetroceso.Text = "←"
        Me.btnRetroceso.UseVisualStyleBackColor = False
        '
        'btnMmenos
        '
        Me.btnMmenos.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMmenos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMmenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMmenos.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMmenos.Location = New System.Drawing.Point(216, 116)
        Me.btnMmenos.Name = "btnMmenos"
        Me.btnMmenos.Size = New System.Drawing.Size(45, 45)
        Me.btnMmenos.TabIndex = 0
        Me.btnMmenos.Text = "M-"
        Me.btnMmenos.UseMnemonic = False
        Me.btnMmenos.UseVisualStyleBackColor = False
        '
        'btnMmas
        '
        Me.btnMmas.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMmas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMmas.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMmas.Location = New System.Drawing.Point(165, 116)
        Me.btnMmas.Name = "btnMmas"
        Me.btnMmas.Size = New System.Drawing.Size(45, 45)
        Me.btnMmas.TabIndex = 0
        Me.btnMmas.Text = "M+"
        Me.btnMmas.UseVisualStyleBackColor = False
        '
        'btnMS
        '
        Me.btnMS.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMS.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMS.Location = New System.Drawing.Point(114, 116)
        Me.btnMS.Name = "btnMS"
        Me.btnMS.Size = New System.Drawing.Size(45, 45)
        Me.btnMS.TabIndex = 0
        Me.btnMS.Text = "MS"
        Me.btnMS.UseVisualStyleBackColor = False
        '
        'btnMR
        '
        Me.btnMR.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMR.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMR.Location = New System.Drawing.Point(63, 116)
        Me.btnMR.Name = "btnMR"
        Me.btnMR.Size = New System.Drawing.Size(45, 45)
        Me.btnMR.TabIndex = 0
        Me.btnMR.Text = "MR"
        Me.btnMR.UseVisualStyleBackColor = False
        '
        'btnMC
        '
        Me.btnMC.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMC.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMC.Location = New System.Drawing.Point(12, 116)
        Me.btnMC.Name = "btnMC"
        Me.btnMC.Size = New System.Drawing.Size(45, 45)
        Me.btnMC.TabIndex = 0
        Me.btnMC.Text = "MC"
        Me.btnMC.UseVisualStyleBackColor = False
        '
        'Estandar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(273, 426)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnComa)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.btnIgual)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnSobre)
        Me.Controls.Add(Me.btnMultiplicar)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btnPorcentaje)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnRaiz)
        Me.Controls.Add(Me.btnCambiarSigno)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnCE)
        Me.Controls.Add(Me.btnRetroceso)
        Me.Controls.Add(Me.btnMmenos)
        Me.Controls.Add(Me.btnMmas)
        Me.Controls.Add(Me.btnMS)
        Me.Controls.Add(Me.btnMR)
        Me.Controls.Add(Me.btnMC)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(500, 120)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(289, 465)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(289, 465)
        Me.Name = "Estandar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Calculadora"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstandarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CientíficaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CopiarHistorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarEdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerLaAyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcerdaDeCalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents btn0 As Button
    Friend WithEvents btnComa As Button
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnSobre As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnPorcentaje As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnRaiz As Button
    Friend WithEvents btnCambiarSigno As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnCE As Button
    Friend WithEvents btnRetroceso As Button
    Friend WithEvents btnMmenos As Button
    Friend WithEvents btnMmas As Button
    Friend WithEvents btnMS As Button
    Friend WithEvents btnMR As Button
    Friend WithEvents btnMC As Button
End Class
