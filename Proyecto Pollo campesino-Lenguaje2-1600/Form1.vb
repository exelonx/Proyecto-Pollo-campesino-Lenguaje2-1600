Public Class Form1
    'Procedimientos
    Public Sub seleccionarLB(indice As Integer)
        lb_Calculo.SelectedIndex = indice
        lb_Envio.SelectedIndex = indice
        lb_Extras.SelectedIndex = indice
        lb_Factura.SelectedIndex = indice
        lb_Pedido.SelectedIndex = indice
    End Sub
    Public Sub eliminarSeleccion(indice As Integer)
        lb_Pedido.Items.RemoveAt(indice)
        lb_Envio.Items.RemoveAt(indice)
        lb_Extras.Items.RemoveAt(indice)
        lb_Factura.Items.RemoveAt(indice)
        lb_Calculo.Items.RemoveAt(indice)
    End Sub
    Public Sub habilitarExtras(ninguno As CheckBox, extra1 As CheckBox, extra2 As CheckBox, extra3 As CheckBox)
        If extra1.Checked = True Or extra2.Checked = True Or extra3.Checked = True Then
            ninguno.Enabled = False
        Else
            ninguno.Enabled = True
        End If
    End Sub
    Public Sub nombExtras(ckb As CheckBox, op As Single)
        Select Case op
            Case 0
                If ckb.Checked = True Then
                    Pedido.nombEnsalada = "Ensalada de repollo"
                Else
                    Pedido.nombEnsalada = ""
                End If
            Case 1
                If ckb.Checked = True Then
                    Pedido.nombTajadas = "Tajadas"
                Else
                    Pedido.nombTajadas = ""
                End If
            Case 2
                If ckb.Checked = True Then
                    Pedido.nombChile = "Chile"
                Else
                    Pedido.nombChile = ""
                End If
        End Select
    End Sub
    'Creo instancia de la clase Pedido
    Dim Pedido As New Pedido()

    Private Sub rb_UnCuarto_CheckedChanged(sender As Object, e As EventArgs) Handles rb_UnCuarto.CheckedChanged
        Pedido.seleccionPorcion(50)
        txt_Precio.Text = Format(Pedido.precio, "0.00")
        Pedido.nombrePorcion = "1/4 de pollo"
    End Sub

    Private Sub rb_MitadP_CheckedChanged(sender As Object, e As EventArgs) Handles rb_MitadP.CheckedChanged
        Pedido.seleccionPorcion(80)
        txt_Precio.Text = Format(Pedido.precio, "0.00")
        Pedido.nombrePorcion = "Mitad de pollo"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pedido.nFactura = 0
        txt_Factura.Text = Pedido.nFactura
    End Sub
    Private Sub rb_PolloEntero_CheckedChanged(sender As Object, e As EventArgs) Handles rb_PolloEntero.CheckedChanged
        Pedido.seleccionPorcion(150)
        txt_Precio.Text = Format(Pedido.precio, "0.00")
        Pedido.nombrePorcion = "Pollo entero"
    End Sub

    Private Sub ckb_Ensalada_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_Ensalada.CheckedChanged
        Pedido.seleccionExtra(60, ckb_Ensalada)
        habilitarExtras(ckb_Ninguno, ckb_Ensalada, ckb_Tajadas, ckb_Chile)
        txt_Precio.Text = Format(Pedido.precio, "0.00")
        nombExtras(ckb_Ensalada, 0)
    End Sub

    Private Sub ckb_Tajadas_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_Tajadas.CheckedChanged
        Pedido.seleccionExtra(40, ckb_Tajadas)
        habilitarExtras(ckb_Ninguno, ckb_Ensalada, ckb_Tajadas, ckb_Chile)
        txt_Precio.Text = Format(Pedido.precio, "0.00")
        nombExtras(ckb_Tajadas, 1)
    End Sub

    Private Sub ckb_Chile_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_Chile.CheckedChanged
        Pedido.seleccionExtra(30, ckb_Chile)
        habilitarExtras(ckb_Ninguno, ckb_Ensalada, ckb_Tajadas, ckb_Chile)
        txt_Precio.Text = Format(Pedido.precio, "0.00")
        nombExtras(ckb_Chile, 2)
    End Sub

    Private Sub txt_NomCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_NomCliente.KeyPress
        'Validar que solo acepte letras
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MessageBox.Show("Tipo de dato inválido, solo texto.", "Dato inválido")
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Cantidad.KeyPress
        'Validar que solo acepte números
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MessageBox.Show("Tipo de dato inválido, solo números.", "Dato inválido")
            e.Handled = True
        End If
    End Sub

    Private Sub cmb_Presentacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Presentacion.SelectedIndexChanged
        Select Case cmb_Presentacion.SelectedIndex
            Case 0
                Pedido.presentacionPollo(20)    'Se eligio Frito
                Pedido.nombrePresentacion = "frito"
                txt_Precio.Text = Format(Pedido.precio, "0.00")
            Case 1
                Pedido.presentacionPollo(50)    'Se eligio Asado
                Pedido.nombrePresentacion = "asado"
                txt_Precio.Text = Format(Pedido.precio, "0.00")
        End Select

    End Sub

    Private Sub cmb_Presentacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_Presentacion.KeyPress
        'Valida que no se puedan ingresar datos al ComboBox
        e.Handled = True
    End Sub

    Private Sub rb_Urbano_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Urbano.CheckedChanged
        If rb_Urbano.Checked = True Then
            Pedido.seleccionEnvio(100)
            txt_Envio.Text = Format(Pedido.tipoEnvio, "0.00")
            Pedido.nombEnvio = "Zona urbana L100"
        End If

    End Sub

    Private Sub rb_OtrasZ_CheckedChanged(sender As Object, e As EventArgs) Handles rb_OtrasZ.CheckedChanged
        If rb_OtrasZ.Checked = True Then
            Pedido.seleccionEnvio(150)
            txt_Envio.Text = Format(Pedido.tipoEnvio, "0.00")
            Pedido.nombEnvio = "Otras zonas L150"
        End If

    End Sub

    Private Sub btn_Calcular_Click(sender As Object, e As EventArgs) Handles btn_Calcular.Click
        'Validaciones
        Pedido.nombExtras = Nothing
        If txt_NomCliente.Text = Nothing Then
            MessageBox.Show("Casilla vacia, ingrese nombre del cliente.", "Falta Requisito")
            Exit Sub
        ElseIf rb_MitadP.Checked = False And rb_PolloEntero.Checked = False And rb_UnCuarto.Checked = False Then
            MessageBox.Show("Seleccione al menos un tamaño de porción de pollo.", "Falta Requisito")
            Exit Sub
        ElseIf cmb_Presentacion.Text = Nothing Then
            MessageBox.Show("Seleccione al menos una opción de presentación.", "Falta Requisito")
            Exit Sub
        ElseIf ckb_Chile.Checked = False And ckb_Ensalada.Checked = False And ckb_Ninguno.Checked = False And ckb_Tajadas.Checked = False Then
            MessageBox.Show("Marque al menos una opción de extras.", "Falta Requisito")
            Exit Sub
        ElseIf rb_OtrasZ.Checked = False And rb_Urbano.Checked = False Then
            MessageBox.Show("Seleccione al menos un tipo de envio.", "Falta Requisito")
            Exit Sub
        ElseIf txt_Cantidad.Text = Nothing Then
            MessageBox.Show("Casilla vacia, ingrese la cantidad deseada.", "Falta Requisito")
            Exit Sub
        End If
        'Calculos
        Pedido.cantidad = txt_Cantidad.Text
        Pedido.subTotal = (Pedido.porcion + Pedido.extra + Pedido.presentacion) * Pedido.cantidad
        txt_SubTotal.Text = Format(Pedido.subTotal, "0.00")
        Pedido.setDescuento(ckb_Membresia)  'calcula descuento
        txt_Desc.Text = Format(Pedido.descuento, "0.00")
        Pedido.impuesto = (Pedido.subTotal - Pedido.descuento) * 0.15
        txt_Impuesto.Text = Format(Pedido.impuesto, "0.00")
        Pedido.total = Pedido.subTotal - Pedido.descuento + Pedido.impuesto + Pedido.tipoEnvio
        txt_Total.Text = Format(Pedido.total, "0.00")
        'Guardar nombres para imprimir extras
        If Pedido.nombEnsalada <> "" Then
            Pedido.nombExtras += Pedido.nombEnsalada
        End If
        If Pedido.nombTajadas <> "" Then
            If Pedido.nombEnsalada = "" Then
                Pedido.nombExtras += Pedido.nombTajadas
            Else
                Pedido.nombExtras += (", " + Pedido.nombTajadas)
            End If
        End If
        If Pedido.nombChile <> "" Then
            If Pedido.nombTajadas = "" And Pedido.nombEnsalada = "" Then
                Pedido.nombExtras += Pedido.nombChile
            Else
                Pedido.nombExtras += (", " + Pedido.nombChile)
            End If
        End If
        If Pedido.nombExtras = "" Then
            Pedido.nombExtras = "Ninguno"
        End If

    End Sub

    Private Sub ckb_Ninguno_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_Ninguno.CheckedChanged
        Pedido.seleccionExtra(0, ckb_Ninguno)
        If ckb_Ninguno.Checked = True Then
            ckb_Chile.Enabled = False
            ckb_Ensalada.Enabled = False
            ckb_Tajadas.Enabled = False
        Else
            ckb_Chile.Enabled = True
            ckb_Ensalada.Enabled = True
            ckb_Tajadas.Enabled = True
        End If
        txt_Precio.Text = Format(Pedido.precio, "0.00")
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        If MsgBox("¿Desea salir del programa?", vbQuestion + vbYesNo, "Pollo Campesino") = vbYes Then
            Close()
        End If
    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        If txt_Total.Text = Nothing Then
            MessageBox.Show("Tiene que calcular primero para poder agregar.", "Falta Requisitos")
        Else
            'Imprimir salidas a los ListBox
            lb_Factura.Items.Add(Pedido.nFactura & " " & txt_NomCliente.Text.Trim)
            lb_Pedido.Items.Add("(" & Pedido.nombrePorcion & " " & Pedido.nombrePresentacion & ") " & "x" & Pedido.cantidad & " L" & (Pedido.porcion + Pedido.presentacion) * Pedido.cantidad)
            lb_Extras.Items.Add("(" & Pedido.nombExtras & ") x" & Pedido.cantidad & " L" & Pedido.extra)
            lb_Envio.Items.Add(Pedido.nombEnvio)
            lb_Calculo.Items.Add("SubTotal(" & Pedido.subTotal & ")-Desc(" & Pedido.descuento & ")+IVA(" & Pedido.impuesto & ")+Envio(" & Pedido.tipoEnvio & ")= L." & txt_Total.Text)
            'limpiar todas las casillas
            txt_NomCliente.Clear()
            txt_Cantidad.Clear()
            txt_SubTotal.Clear()
            txt_Desc.Clear()
            txt_Impuesto.Clear()
            txt_Envio.Clear()
            txt_Total.Clear()
            rb_MitadP.Checked = False
            rb_PolloEntero.Checked = False
            rb_UnCuarto.Checked = False
            rb_Urbano.Checked = False
            rb_OtrasZ.Checked = False
            cmb_Presentacion.Text = Nothing
            ckb_Chile.Checked = False
            ckb_Ensalada.Checked = False
            ckb_Membresia.Checked = False
            ckb_Tajadas.Checked = False
            txt_Precio.Clear()
            'Reinicio de variables importantes
            Pedido.precio = 0
            Pedido.porcion = 0
            Pedido.presentacion = 0
            'Aumentamos el contador de factura
            Pedido.nFactura += 1
            txt_Factura.Text = Pedido.nFactura
        End If

    End Sub

    Private Sub lb_Factura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_Factura.SelectedIndexChanged
        seleccionarLB(lb_Factura.SelectedIndex)
    End Sub

    Private Sub lb_Pedido_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_Pedido.SelectedIndexChanged
        seleccionarLB(lb_Pedido.SelectedIndex)
    End Sub

    Private Sub lb_Extras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_Extras.SelectedIndexChanged
        seleccionarLB(lb_Extras.SelectedIndex)
    End Sub

    Private Sub lb_Envio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_Envio.SelectedIndexChanged
        seleccionarLB(lb_Envio.SelectedIndex)
    End Sub

    Private Sub lb_Calculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_Calculo.SelectedIndexChanged
        seleccionarLB(lb_Calculo.SelectedIndex)
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        If lb_Calculo.SelectedIndex <> -1 Then
            eliminarSeleccion(lb_Calculo.SelectedIndex)
        Else
            MessageBox.Show("Elemento sin seleccionar, seleccione uno.", "Falta Requisitos")
        End If
    End Sub
End Class
