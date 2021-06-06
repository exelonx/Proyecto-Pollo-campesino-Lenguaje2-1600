<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckb_Membresia = New System.Windows.Forms.CheckBox()
        Me.txt_NomCliente = New System.Windows.Forms.TextBox()
        Me.txt_Factura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rb_UnCuarto = New System.Windows.Forms.RadioButton()
        Me.rb_MitadP = New System.Windows.Forms.RadioButton()
        Me.rb_PolloEntero = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ckb_Ninguno = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ckb_Chile = New System.Windows.Forms.CheckBox()
        Me.ckb_Tajadas = New System.Windows.Forms.CheckBox()
        Me.ckb_Ensalada = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rb_OtrasZ = New System.Windows.Forms.RadioButton()
        Me.rb_Urbano = New System.Windows.Forms.RadioButton()
        Me.cmb_Presentacion = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_Total = New System.Windows.Forms.TextBox()
        Me.txt_Impuesto = New System.Windows.Forms.TextBox()
        Me.txt_Envio = New System.Windows.Forms.TextBox()
        Me.txt_Desc = New System.Windows.Forms.TextBox()
        Me.txt_SubTotal = New System.Windows.Forms.TextBox()
        Me.txt_Cantidad = New System.Windows.Forms.TextBox()
        Me.txt_Precio = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lb_Calculo = New System.Windows.Forms.ListBox()
        Me.lb_Envio = New System.Windows.Forms.ListBox()
        Me.lb_Extras = New System.Windows.Forms.ListBox()
        Me.lb_Pedido = New System.Windows.Forms.ListBox()
        Me.lb_Factura = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.btn_Calcular = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckb_Membresia)
        Me.GroupBox1.Controls.Add(Me.txt_NomCliente)
        Me.GroupBox1.Controls.Add(Me.txt_Factura)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'ckb_Membresia
        '
        Me.ckb_Membresia.AutoSize = True
        Me.ckb_Membresia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckb_Membresia.Location = New System.Drawing.Point(72, 72)
        Me.ckb_Membresia.Name = "ckb_Membresia"
        Me.ckb_Membresia.Size = New System.Drawing.Size(79, 17)
        Me.ckb_Membresia.TabIndex = 4
        Me.ckb_Membresia.Text = "Membresía"
        Me.ckb_Membresia.UseVisualStyleBackColor = True
        '
        'txt_NomCliente
        '
        Me.txt_NomCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NomCliente.Location = New System.Drawing.Point(118, 43)
        Me.txt_NomCliente.Name = "txt_NomCliente"
        Me.txt_NomCliente.Size = New System.Drawing.Size(100, 20)
        Me.txt_NomCliente.TabIndex = 3
        '
        'txt_Factura
        '
        Me.txt_Factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Factura.Location = New System.Drawing.Point(118, 17)
        Me.txt_Factura.Name = "txt_Factura"
        Me.txt_Factura.ReadOnly = True
        Me.txt_Factura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Factura.Size = New System.Drawing.Size(33, 20)
        Me.txt_Factura.TabIndex = 2
        Me.txt_Factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Factura:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.cmb_Presentacion)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(244, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 136)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pedido"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.rb_UnCuarto)
        Me.GroupBox6.Controls.Add(Me.rb_MitadP)
        Me.GroupBox6.Controls.Add(Me.rb_PolloEntero)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(8, 20)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(135, 108)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tamaño de porción"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(98, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "L 50"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(98, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "L 80"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(98, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "L150"
        '
        'rb_UnCuarto
        '
        Me.rb_UnCuarto.AutoSize = True
        Me.rb_UnCuarto.Location = New System.Drawing.Point(6, 74)
        Me.rb_UnCuarto.Name = "rb_UnCuarto"
        Me.rb_UnCuarto.Size = New System.Drawing.Size(83, 17)
        Me.rb_UnCuarto.TabIndex = 3
        Me.rb_UnCuarto.Text = "1/4 de Pollo"
        Me.rb_UnCuarto.UseVisualStyleBackColor = True
        '
        'rb_MitadP
        '
        Me.rb_MitadP.AutoSize = True
        Me.rb_MitadP.Location = New System.Drawing.Point(6, 51)
        Me.rb_MitadP.Name = "rb_MitadP"
        Me.rb_MitadP.Size = New System.Drawing.Size(80, 17)
        Me.rb_MitadP.TabIndex = 2
        Me.rb_MitadP.Text = "Medio Pollo"
        Me.rb_MitadP.UseVisualStyleBackColor = True
        '
        'rb_PolloEntero
        '
        Me.rb_PolloEntero.AutoSize = True
        Me.rb_PolloEntero.Location = New System.Drawing.Point(6, 27)
        Me.rb_PolloEntero.Name = "rb_PolloEntero"
        Me.rb_PolloEntero.Size = New System.Drawing.Size(82, 17)
        Me.rb_PolloEntero.TabIndex = 1
        Me.rb_PolloEntero.Text = "Pollo Entero"
        Me.rb_PolloEntero.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ckb_Ninguno)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.ckb_Chile)
        Me.GroupBox3.Controls.Add(Me.ckb_Tajadas)
        Me.GroupBox3.Controls.Add(Me.ckb_Ensalada)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(277, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(172, 109)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Extras"
        '
        'ckb_Ninguno
        '
        Me.ckb_Ninguno.AutoSize = True
        Me.ckb_Ninguno.Location = New System.Drawing.Point(6, 89)
        Me.ckb_Ninguno.Name = "ckb_Ninguno"
        Me.ckb_Ninguno.Size = New System.Drawing.Size(66, 17)
        Me.ckb_Ninguno.TabIndex = 6
        Me.ckb_Ninguno.Text = "Ninguno"
        Me.ckb_Ninguno.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(135, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "L 30"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(135, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "L 40"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(135, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "L 60"
        '
        'ckb_Chile
        '
        Me.ckb_Chile.AutoSize = True
        Me.ckb_Chile.Location = New System.Drawing.Point(6, 66)
        Me.ckb_Chile.Name = "ckb_Chile"
        Me.ckb_Chile.Size = New System.Drawing.Size(49, 17)
        Me.ckb_Chile.TabIndex = 2
        Me.ckb_Chile.Text = "Chile"
        Me.ckb_Chile.UseVisualStyleBackColor = True
        '
        'ckb_Tajadas
        '
        Me.ckb_Tajadas.AutoSize = True
        Me.ckb_Tajadas.Location = New System.Drawing.Point(6, 42)
        Me.ckb_Tajadas.Name = "ckb_Tajadas"
        Me.ckb_Tajadas.Size = New System.Drawing.Size(64, 17)
        Me.ckb_Tajadas.TabIndex = 1
        Me.ckb_Tajadas.Text = "Tajadas"
        Me.ckb_Tajadas.UseVisualStyleBackColor = True
        '
        'ckb_Ensalada
        '
        Me.ckb_Ensalada.AutoSize = True
        Me.ckb_Ensalada.Location = New System.Drawing.Point(6, 19)
        Me.ckb_Ensalada.Name = "ckb_Ensalada"
        Me.ckb_Ensalada.Size = New System.Drawing.Size(119, 17)
        Me.ckb_Ensalada.TabIndex = 0
        Me.ckb_Ensalada.Text = "Ensalada de repollo"
        Me.ckb_Ensalada.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rb_OtrasZ)
        Me.GroupBox5.Controls.Add(Me.rb_Urbano)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(150, 63)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(121, 65)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tipo de envio"
        '
        'rb_OtrasZ
        '
        Me.rb_OtrasZ.AutoSize = True
        Me.rb_OtrasZ.BackColor = System.Drawing.Color.Transparent
        Me.rb_OtrasZ.Location = New System.Drawing.Point(7, 40)
        Me.rb_OtrasZ.Name = "rb_OtrasZ"
        Me.rb_OtrasZ.Size = New System.Drawing.Size(114, 17)
        Me.rb_OtrasZ.TabIndex = 1
        Me.rb_OtrasZ.TabStop = True
        Me.rb_OtrasZ.Text = "Otras zonas   L150"
        Me.rb_OtrasZ.UseVisualStyleBackColor = False
        '
        'rb_Urbano
        '
        Me.rb_Urbano.AutoSize = True
        Me.rb_Urbano.BackColor = System.Drawing.Color.Transparent
        Me.rb_Urbano.Location = New System.Drawing.Point(7, 19)
        Me.rb_Urbano.Name = "rb_Urbano"
        Me.rb_Urbano.Size = New System.Drawing.Size(113, 17)
        Me.rb_Urbano.TabIndex = 0
        Me.rb_Urbano.TabStop = True
        Me.rb_Urbano.Text = "Zona urbana L100"
        Me.rb_Urbano.UseVisualStyleBackColor = False
        '
        'cmb_Presentacion
        '
        Me.cmb_Presentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Presentacion.FormattingEnabled = True
        Me.cmb_Presentacion.Items.AddRange(New Object() {"Frito " & Global.Microsoft.VisualBasic.ChrW(9) & "L 20", "Asado " & Global.Microsoft.VisualBasic.ChrW(9) & "L 50"})
        Me.cmb_Presentacion.Location = New System.Drawing.Point(150, 36)
        Me.cmb_Presentacion.Name = "cmb_Presentacion"
        Me.cmb_Presentacion.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Presentacion.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(147, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Presentación"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txt_Total)
        Me.GroupBox4.Controls.Add(Me.txt_Impuesto)
        Me.GroupBox4.Controls.Add(Me.txt_Envio)
        Me.GroupBox4.Controls.Add(Me.txt_Desc)
        Me.GroupBox4.Controls.Add(Me.txt_SubTotal)
        Me.GroupBox4.Controls.Add(Me.txt_Cantidad)
        Me.GroupBox4.Controls.Add(Me.txt_Precio)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(9, 217)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(229, 188)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Calculos"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(16, 137)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(37, 13)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Envio:"
        '
        'txt_Total
        '
        Me.txt_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(118, 157)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.ReadOnly = True
        Me.txt_Total.Size = New System.Drawing.Size(100, 20)
        Me.txt_Total.TabIndex = 11
        Me.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Impuesto
        '
        Me.txt_Impuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Impuesto.Location = New System.Drawing.Point(118, 111)
        Me.txt_Impuesto.Name = "txt_Impuesto"
        Me.txt_Impuesto.ReadOnly = True
        Me.txt_Impuesto.Size = New System.Drawing.Size(100, 20)
        Me.txt_Impuesto.TabIndex = 10
        Me.txt_Impuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Envio
        '
        Me.txt_Envio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Envio.Location = New System.Drawing.Point(118, 134)
        Me.txt_Envio.Name = "txt_Envio"
        Me.txt_Envio.ReadOnly = True
        Me.txt_Envio.Size = New System.Drawing.Size(100, 20)
        Me.txt_Envio.TabIndex = 12
        Me.txt_Envio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Desc
        '
        Me.txt_Desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Desc.Location = New System.Drawing.Point(118, 88)
        Me.txt_Desc.Name = "txt_Desc"
        Me.txt_Desc.ReadOnly = True
        Me.txt_Desc.Size = New System.Drawing.Size(100, 20)
        Me.txt_Desc.TabIndex = 9
        Me.txt_Desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_SubTotal
        '
        Me.txt_SubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubTotal.Location = New System.Drawing.Point(118, 65)
        Me.txt_SubTotal.Name = "txt_SubTotal"
        Me.txt_SubTotal.ReadOnly = True
        Me.txt_SubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txt_SubTotal.TabIndex = 8
        Me.txt_SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cantidad.Location = New System.Drawing.Point(118, 42)
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_Cantidad.TabIndex = 7
        Me.txt_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Precio
        '
        Me.txt_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Precio.Location = New System.Drawing.Point(118, 19)
        Me.txt_Precio.Name = "txt_Precio"
        Me.txt_Precio.ReadOnly = True
        Me.txt_Precio.Size = New System.Drawing.Size(100, 20)
        Me.txt_Precio.TabIndex = 6
        Me.txt_Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 160)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Total a pagar:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "SubTotal:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Impuesto:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Descuento:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Cantidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Precio:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.Label17)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.lb_Calculo)
        Me.GroupBox7.Controls.Add(Me.lb_Envio)
        Me.GroupBox7.Controls.Add(Me.lb_Extras)
        Me.GroupBox7.Controls.Add(Me.lb_Pedido)
        Me.GroupBox7.Controls.Add(Me.lb_Factura)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(9, 411)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(691, 193)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Salidas"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(542, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 13)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Calculo Final"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(393, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 13)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Tipo de envio"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(244, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 13)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Extras"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(95, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Pedido"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "No. Factura"
        '
        'lb_Calculo
        '
        Me.lb_Calculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Calculo.FormattingEnabled = True
        Me.lb_Calculo.HorizontalScrollbar = True
        Me.lb_Calculo.Location = New System.Drawing.Point(541, 36)
        Me.lb_Calculo.Name = "lb_Calculo"
        Me.lb_Calculo.Size = New System.Drawing.Size(143, 147)
        Me.lb_Calculo.TabIndex = 7
        '
        'lb_Envio
        '
        Me.lb_Envio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Envio.FormattingEnabled = True
        Me.lb_Envio.HorizontalScrollbar = True
        Me.lb_Envio.Location = New System.Drawing.Point(392, 36)
        Me.lb_Envio.Name = "lb_Envio"
        Me.lb_Envio.Size = New System.Drawing.Size(143, 147)
        Me.lb_Envio.TabIndex = 6
        '
        'lb_Extras
        '
        Me.lb_Extras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Extras.FormattingEnabled = True
        Me.lb_Extras.HorizontalScrollbar = True
        Me.lb_Extras.Location = New System.Drawing.Point(243, 36)
        Me.lb_Extras.Name = "lb_Extras"
        Me.lb_Extras.Size = New System.Drawing.Size(143, 147)
        Me.lb_Extras.TabIndex = 5
        '
        'lb_Pedido
        '
        Me.lb_Pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Pedido.FormattingEnabled = True
        Me.lb_Pedido.HorizontalScrollbar = True
        Me.lb_Pedido.Location = New System.Drawing.Point(94, 36)
        Me.lb_Pedido.Name = "lb_Pedido"
        Me.lb_Pedido.Size = New System.Drawing.Size(143, 147)
        Me.lb_Pedido.TabIndex = 1
        '
        'lb_Factura
        '
        Me.lb_Factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Factura.FormattingEnabled = True
        Me.lb_Factura.HorizontalScrollbar = True
        Me.lb_Factura.Location = New System.Drawing.Point(7, 36)
        Me.lb_Factura.Name = "lb_Factura"
        Me.lb_Factura.Size = New System.Drawing.Size(81, 147)
        Me.lb_Factura.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_Salir)
        Me.Panel1.Controls.Add(Me.btn_Eliminar)
        Me.Panel1.Controls.Add(Me.btn_Agregar)
        Me.Panel1.Controls.Add(Me.btn_Calcular)
        Me.Panel1.Location = New System.Drawing.Point(244, 256)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 149)
        Me.Panel1.TabIndex = 5
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.Red
        Me.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_Salir.Location = New System.Drawing.Point(3, 111)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(450, 37)
        Me.btn_Salir.TabIndex = 3
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Eliminar.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btn_Eliminar.Location = New System.Drawing.Point(3, 75)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(450, 37)
        Me.btn_Eliminar.TabIndex = 2
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Agregar
        '
        Me.btn_Agregar.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar.Location = New System.Drawing.Point(3, 39)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(450, 37)
        Me.btn_Agregar.TabIndex = 1
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = False
        '
        'btn_Calcular
        '
        Me.btn_Calcular.BackColor = System.Drawing.Color.Yellow
        Me.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Calcular.Location = New System.Drawing.Point(3, 3)
        Me.btn_Calcular.Name = "btn_Calcular"
        Me.btn_Calcular.Size = New System.Drawing.Size(450, 37)
        Me.btn_Calcular.TabIndex = 0
        Me.btn_Calcular.Text = "Calcular"
        Me.btn_Calcular.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(712, 108)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(712, 612)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Pollo Campesino"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ckb_Membresia As CheckBox
    Friend WithEvents txt_NomCliente As TextBox
    Friend WithEvents txt_Factura As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_Presentacion As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents rb_UnCuarto As RadioButton
    Friend WithEvents rb_MitadP As RadioButton
    Friend WithEvents rb_PolloEntero As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ckb_Chile As CheckBox
    Friend WithEvents ckb_Tajadas As CheckBox
    Friend WithEvents ckb_Ensalada As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rb_OtrasZ As RadioButton
    Friend WithEvents rb_Urbano As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txt_Total As TextBox
    Friend WithEvents txt_Impuesto As TextBox
    Friend WithEvents txt_Desc As TextBox
    Friend WithEvents txt_SubTotal As TextBox
    Friend WithEvents txt_Cantidad As TextBox
    Friend WithEvents txt_Precio As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lb_Extras As ListBox
    Friend WithEvents lb_Pedido As ListBox
    Friend WithEvents lb_Factura As ListBox
    Friend WithEvents lb_Calculo As ListBox
    Friend WithEvents lb_Envio As ListBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Salir As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents btn_Calcular As Button
    Friend WithEvents ckb_Ninguno As CheckBox
    Friend WithEvents txt_Envio As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
