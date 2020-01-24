Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'SE USA LA CONDICIONAL IF Y ELSE AL MOMENTO DE INGRESAR EN EL LOGIN
        If TextBox1.Text = "AGROPECUARIA" And TextBox2.Text = "123456789" Then
            MsgBox("BIENVENIDO AL CENTRO AGROPECUARIO", vbInformation, "EXITO")
            Me.Hide()
            MENUPRINCIPAL.Show()
        Else
            MsgBox("ERROR DE USUARIO O CONTRASEÑA", vbCritical, "ERROR")
            TextBox1.Clear()
            TextBox2.Clear()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        'Declaración de Variable
        Dim mayus As String
        'captura de datos
        mayus = UCase(TextBox1.Text)
        'Salida
        TextBox1.Text = mayus
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load






































































































    End Sub
End Class
