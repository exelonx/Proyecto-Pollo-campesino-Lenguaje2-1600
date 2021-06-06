Public Class Form1
    'Procedimientos
    Public Sub habilitarExtras(ninguno As CheckBox, extra1 As CheckBox, extra2 As CheckBox, extra3 As CheckBox)
        If extra1.Checked = True Or extra2.Checked = True Or extra3.Checked = True Then
            ninguno.Enabled = False
        Else
            ninguno.Enabled = True
        End If
    End Sub
    'Creo instancia de la clase Pedido
    Dim Pedido As New Pedido()

    Private Sub rb_UnCuarto_CheckedChanged(sender As Object, e As EventArgs) Handles rb_UnCuarto.CheckedChanged
        Pedido.seleccionPorcion(50)
        txt_Precio.Text = Pedido.precio
    End Sub

    Private Sub rb_MitadP_CheckedChanged(sender As Object, e As EventArgs) Handles rb_MitadP.CheckedChanged
        Pedido.seleccionPorcion(80)
        txt_Precio.Text = Pedido.precio
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pedido.nFactura = 0
        txt_Factura.Text = Pedido.nFactura
    End Sub
    Private Sub rb_PolloEntero_CheckedChanged(sender As Object, e As EventArgs) Handles rb_PolloEntero.CheckedChanged
        Pedido.seleccionPorcion(150)
        txt_Precio.Text = Pedido.precio
    End Sub

    Private Sub ckb_Ensalada_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_Ensalada.CheckedChanged
        Pedido.seleccionExtra(60, ckb_Ensalada)
        habilitarExtras(ckb_Ninguno, ckb_Ensalada, ckb_Tajadas, ckb_Chile)
        txt_Precio.Text = Pedido.precio
    End Sub

    Private Sub ckb_Tajadas_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_Tajadas.CheckedChanged
        Pedido.seleccionExtra(40, ckb_Tajadas)
        habilitarExtras(ckb_Ninguno, ckb_Ensalada, ckb_Tajadas, ckb_Chile)
        txt_Precio.Text = Pedido.precio
    End Sub

    Private Sub ckb_Chile_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_Chile.CheckedChanged
        Pedido.seleccionExtra(30, ckb_Chile)
        habilitarExtras(ckb_Ninguno, ckb_Ensalada, ckb_Tajadas, ckb_Chile)
        txt_Precio.Text = Pedido.precio
    End Sub

    Private Sub txt_NomCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_NomCliente.KeyPress
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
            Case 1
                Pedido.presentacionPollo(50)    'Se eligio Asado
        End Select
        txt_Precio.Text = Pedido.precio
    End Sub

    Private Sub cmb_Presentacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_Presentacion.KeyPress
        'Valida que no se puedan ingresar datos al ComboBox
        e.Handled = True
    End Sub

    Private Sub rb_Urbano_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Urbano.CheckedChanged
        Pedido.seleccionEnvio(100)
        txt_Precio.Text = Pedido.precio
    End Sub

    Private Sub rb_OtrasZ_CheckedChanged(sender As Object, e As EventArgs) Handles rb_OtrasZ.CheckedChanged
        Pedido.seleccionEnvio(150)
        txt_Precio.Text = Pedido.precio
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Validaciones
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
        Pedido.setDescuento(ckb_Membresia)  'calcula descuento
        txt_Desc.Text = Pedido.descuento
        Pedido.cantidad = txt_Cantidad.Text
        Pedido.subTotal = (Pedido.porcion * Pedido.cantidad) + Pedido.extra + Pedido.presentacion + Pedido.tipoEnvio
        txt_SubTotal.Text = Pedido.subTotal
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
        txt_Precio.Text = Pedido.precio
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("¿Desea salir del programa?", vbQuestion + vbYesNo, "Pollo Campesino") = vbYes Then
            Close()
        End If
    End Sub
End Class
