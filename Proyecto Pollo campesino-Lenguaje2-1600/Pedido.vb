Public Class Pedido
    'Atributos
    Public nFactura As Integer
    Public porcion As Integer
    Public presentacion As Integer
    Public tipoEnvio As Integer
    Public extra As Integer
    Public nombrePorcion, nombrePresentacion, nombEnsalada, nombTajadas, nombChile, nombExtras, nombEnvio As String
    Public precio, cantidad, subTotal, descuento, impuesto, total As Double
    'Metodos
    Public Sub seleccionPorcion(precioPorcion As Integer)
        If Me.porcion > 0 Then
            Me.precio -= Me.porcion
            Me.porcion = precioPorcion
            Me.precio += Me.porcion
        Else
            Me.porcion = precioPorcion
            Me.precio += Me.porcion
        End If
    End Sub
    Public Sub presentacionPollo(precioPresentacion As Integer)
        If Me.presentacion > 0 Then
            Me.precio -= Me.presentacion
            Me.presentacion = precioPresentacion
            Me.precio += Me.presentacion
        Else
            Me.presentacion = precioPresentacion
            Me.precio += Me.presentacion
        End If
    End Sub
    Public Sub seleccionEnvio(precioEnvio As Integer)
        Me.tipoEnvio = precioEnvio
    End Sub
    Public Sub seleccionExtra(precioExtra As Integer, ckb_extra As CheckBox)
        If ckb_extra.Checked = True Then
            Me.precio += precioExtra
            Me.extra += precioExtra
        Else
            Me.precio -= precioExtra
            Me.extra -= precioExtra
        End If
    End Sub
    Public Sub setDescuento(ckb_membresia As CheckBox)
        If ckb_membresia.Checked = True Then
            Me.descuento = Me.subTotal * 0.1
        Else
            Me.descuento = 0
        End If
    End Sub
End Class
