Public Class Pedido
    'Atributos
    Public nFactura As Integer
    Public Nombre As String
    Public porcion As Integer
    Public presentacion As Integer
    Public tipoEnvio As Integer
    Public extras As Integer
    Public precio, cantidad, subTotal, descuento, impuesto, total As Double
    'Metodos
    Public Sub seleccionPorcion(precioPorcion As Integer, rbPorcion As RadioButton)
        Me.precio = precioPorcion
    End Sub
    Public Sub presentacionPollo(precioPresentacion As Integer)
        Me.presentacion = precioPresentacion
    End Sub
    Public Sub seleccionEnvio(precioEnvio As Integer)
        Me.tipoEnvio = precioEnvio
    End Sub

End Class
