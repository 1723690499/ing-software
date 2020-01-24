Public Class MENUPRINCIPAL

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        CLIENTES.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        FACTURA_DE_VENTA.Show()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        REGIS_PRODUCTO.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        VENTAS.Show()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        PRODUCTO_MAS_VENDIDO.Show()
    End Sub
End Class