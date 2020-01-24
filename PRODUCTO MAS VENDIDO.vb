Public Class PRODUCTO_MAS_VENDIDO

    Private Sub PRODUCTO_MAS_VENDIDO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AGROPECUARIADataSet3.REGIS_PRODUCTO' Puede moverla o quitarla según sea necesario.
        Me.REGIS_PRODUCTOTableAdapter.Fill(Me.AGROPECUARIADataSet3.REGIS_PRODUCTO)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.REGIS_PRODUCTOTableAdapter.FillBy(Me.AGROPECUARIADataSet3.REGIS_PRODUCTO, TextBox1.Text)
        TextBox1.Clear()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class