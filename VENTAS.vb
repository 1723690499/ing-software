Imports System.Data.SqlClient
Public Class VENTAS
    Dim clsValGlo As New fun_validar
    Dim ResID, y As Integer

    Private Sub VNTS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AGROPECUARIADataSet1.VENTAS' Puede moverla o quitarla según sea necesario.
        Me.VENTASTableAdapter.Fill(Me.AGROPECUARIADataSet1.VENTAS)


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.VENTASTableAdapter.AHORA(TextBox1.Text, TextBox2.Text + TextBox6.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        Me.VENTASTableAdapter.Fill(Me.AGROPECUARIADataSet1.VENTAS)
        MsgBox("LOS DATOS SE HAN INGRESADO CON EXITO", vbInformation, "CORRECTO")
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.VENTASTableAdapter.LIMI(TextBox1.Text)
        Me.VENTASTableAdapter.Fill(Me.AGROPECUARIADataSet1.VENTAS)
        MsgBox("LOS DATOS SE HAN ELIMINADO CON EXITO", vbInformation, "CORRECTO")
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.VENTASTableAdapter.AHORA(TextBox1.Text, TextBox2.Text + TextBox6.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        Me.VENTASTableAdapter.Fill(Me.AGROPECUARIADataSet1.VENTAS)
        MsgBox("LOS DATOS SE HAN ACTUALIZADO CON EXITO", vbInformation, "CORRECTO")
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub TOTAL_Click(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub TextBox8_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox7_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.VENTASTableAdapter.FillBy(Me.AGROPECUARIADataSet1.VENTAS, TextBox1.Text)
        TextBox1.Clear()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        ResID = clsValGlo.calculardigito(TextBox2)
        If Len(TextBox2.Text.Trim) = 9 Then
            TextBox6.Focus()
        End If
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

    Private Sub TextBox6_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox6.LostFocus
        If TextBox6.Text.Trim = "" Then
            TextBox6.Focus()
            Exit Sub
        End If

        If clsValGlo.verificardigito(TextBox6) = True Then
            If clsValGlo.validardni(TextBox2.Text.Trim + TextBox6.Text.Trim) = False Then
                TextBox3.Focus()
            Else
                MessageBox.Show("este usuario ya existe", "registrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox6.Clear()
                TextBox2.Clear()
                TextBox2.Focus()
            End If
        Else
            MsgBox("cedula incorrecta")
            TextBox6.Clear()
            TextBox2.Clear()
            TextBox2.Focus()

        End If



    End Sub

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class
