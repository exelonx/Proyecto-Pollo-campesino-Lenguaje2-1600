Public Class Form1
    'Creo instancia de la clase Pedido
    Dim Pedido As New Pedido()
    Private Sub rb_UnCuarto_CheckedChanged(sender As Object, e As EventArgs) Handles rb_UnCuarto.CheckedChanged
        Pedido.seleccionPorcion(50, rb_PolloEntero)
        txt_Precio.Text = Pedido.precio
    End Sub

    Private Sub rb_MitadP_CheckedChanged(sender As Object, e As EventArgs) Handles rb_MitadP.CheckedChanged
        Pedido.seleccionPorcion(80, rb_PolloEntero)
        txt_Precio.Text = Pedido.precio
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub rb_PolloEntero_CheckedChanged(sender As Object, e As EventArgs) Handles rb_PolloEntero.CheckedChanged
        Pedido.seleccionPorcion(150, rb_PolloEntero)
        txt_Precio.Text = Pedido.precio
    End Sub
End Class
