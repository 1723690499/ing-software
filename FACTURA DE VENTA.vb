Imports System.Data.SqlClient
Public Class FACTURA_DE_VENTA
    Dim clsValGlo As New fun_validar
    Dim ResID, y As Integer
    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FACTURA_DE_VENTA_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AGROPECUARIADataSet4.FACTURA_DE_VENTAS' Puede moverla o quitarla según sea necesario.
        Me.FACTURA_DE_VENTASTableAdapter.Fill(Me.AGROPECUARIADataSet4.FACTURA_DE_VENTAS)



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.FACTURA_DE_VENTASTableAdapter.INSAT(TextBox1.Text, TextBox2.Text + TextBox13.Text, TextBox3.Text, DateTimePicker1.Text, TextBox4.Text, TextBox5.Text, ComboBox1.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text)
        Me.FACTURA_DE_VENTASTableAdapter.Fill(Me.AGROPECUARIADataSet4.FACTURA_DE_VENTAS)
        MsgBox("LOS DATOS SE HAN INGRESADO CORRECTAMENTE", vbInformation, "CORRECTO")
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.FACTURA_DE_VENTASTableAdapter.actualizate(TextBox1.Text, TextBox2.Text, TextBox3.Text, DateTimePicker1.Text, TextBox4.Text, TextBox5.Text, ComboBox1.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text)
        Me.FACTURA_DE_VENTASTableAdapter.Fill(Me.AGROPECUARIADataSet4.FACTURA_DE_VENTAS)
        MsgBox("LOS DATOS SE HAN ACTUALIZADO CORRECTAMENTE", vbInformation, "CORRECTO")
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.FACTURA_DE_VENTASTableAdapter.DETE(TextBox1.Text)
        Me.FACTURA_DE_VENTASTableAdapter.Fill(Me.AGROPECUARIADataSet4.FACTURA_DE_VENTAS)
        MsgBox("LOS DATOS SE HAN ELIMINADO CORRECTAMENTE", vbInformation, "CORRECTO")
        TextBox1.Clear()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        'creamos dos variales una total en donde aparecera el valor y otra que es fila
        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In DataGridView1.Rows
            total += Convert.ToDouble(fila.Cells("TOTALDataGridViewTextBoxColumn").Value)
        Next
        TextBox10.Text = Convert.ToString(total)
        'aqui se calcula el iva
        TextBox12.Text = Val(TextBox10.Text) * Val(TextBox11.Text)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim T1 As String
        Dim T2 As String
        T1 = TextBox7.Text
        T2 = TextBox8.Text
        TextBox9.Text = T1 * T2

        TextBox11.Enabled = True
    End Sub

    Private Sub TextBox11_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox11.TextChanged

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
            TextBox13.Focus()
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

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged

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

    Private Sub TextBox6_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
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

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox13_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox13.LostFocus
        If TextBox13.Text.Trim = "" Then
            TextBox13.Focus()
            Exit Sub
        End If

        If clsValGlo.verificardigito(TextBox13) = True Then
            TextBox3.Focus()
        Else
            MsgBox("cedula incorrecta")
            TextBox13.Clear()
            TextBox2.Clear()
            TextBox2.Focus()

        End If

    End Sub

    Private Sub TextBox13_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox13.TextChanged

    End Sub
End Class