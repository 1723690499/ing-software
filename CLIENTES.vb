Public Class CLIENTES

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

        TextBox1.Clear()
    End Sub

    Private Sub CLIENTES_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AGROPECUARIADataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter.Fill(Me.AGROPECUARIADataSet.CLIENTES)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.CLIENTESTableAdapter.TERMINAR(TextBox1.Text, TextBox2.Text, TextBox3.Text, DateTimePicker1.Text, TextBox4.Text, TextBox5.Text)
        Me.CLIENTESTableAdapter.Fill(Me.AGROPECUARIADataSet.CLIENTES)
        MsgBox("LOS DATOS SE HAN INGRESADOS CORRECTAMENTE", vbInformation, "EXITO")
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.CLIENTESTableAdapter.FINAL(TextBox1.Text, TextBox2.Text, TextBox3.Text, DateTimePicker1.Text, TextBox4.Text, TextBox5.Text)
        Me.CLIENTESTableAdapter.Fill(Me.AGROPECUARIADataSet.CLIENTES)
        MsgBox("LOS DATOS SE HAN ACTUALIZADOS CORRECTAMENTE", vbInformation, "EXITO")
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.CLIENTESTableAdapter.OKEY(TextBox1.Text)
        Me.CLIENTESTableAdapter.Fill(Me.AGROPECUARIADataSet.CLIENTES)
        MsgBox("LOS DATOS SE HAN EIMINADO CORRECTAMENTE", vbInformation, "EXITO")
        TextBox1.Clear()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
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

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox5_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox5.KeyDown

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class