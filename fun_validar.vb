Imports System.Data.SqlClient
Public Class fun_validar
    Dim cn As New SqlConnection(My.Settings.AGROPECUARIAConnectionString)
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim cedula, suma, residuo As Integer
    ''validacion de solo numero
    Public Function Numerico(ByVal txtcontrol As TextBox, ByVal caracter As Char) As Boolean
        If (Char.IsNumber(caracter, 0) = True) Or caracter = Convert.ToChar(8) Then
            Return False
        Else
            Return True
        End If
    End Function
    ''validacion de cedula
    Public Function calculardigito(ByVal txtced As TextBox) As Integer
        cedula = Nothing
        suma = Nothing
        residuo = Nothing
        If Len(txtced.Text.Trim) = 9 Then
            cedula = Convert.ToInt32(txtced.Text)
            For i = 1 To 9
                residuo = cedula Mod 10
                cedula = (cedula - residuo) / 10
                If i Mod 2 = 1 Then
                    residuo *= 2
                    If residuo > 9 Then
                        residuo -= 9

                    End If

                End If
                suma += residuo

            Next i
            residuo = suma Mod 10

            If residuo > 0 Then
                residuo = 10 - residuo
            End If
        End If
        Return (residuo)
    End Function
    Public Function verificardigito(ByVal txtDigVer As TextBox) As Boolean
        'Try
        If residuo = txtDigVer.Text.Trim Then
            Return True
        Else
            Return False
        End If
        'Catch ex As Exception
        'End Try
    End Function

    'para validar cedula 
    Function validardni(ByVal id As String) As Boolean
        Dim resultado As Boolean = False
        Try
            cn.Open()

            cmd = New SqlCommand("Select*from VENTAS where Cedula_Cli='" & id & "'", cn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                resultado = True
            End If
            dr.Close()
            cn.Close()


        Catch ex As Exception
            MsgBox("Error en el procedimiento" + ex.ToString)

        End Try
        Return resultado
    End Function

    Function validarcodigo(ByVal id As String) As String
        Dim resultado As Boolean = False
        Try
            cn.Open()
            cmd = New SqlCommand("Select * from REGIS_PRODUCTO where Codigo ='" & id & "'", cn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                resultado = True
            End If
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox("error en el procedimineto" + ex.ToString)
        End Try
        Return resultado
    End Function

    ' Function validarcodigo2(ByVal id As String) As String
    '   Dim resultado As Boolean = False
    '  Try
    'cn.Open()
    'cmd = New SqlCommand("Select * from CLIENTES where Cog _Cliente ='" & id & "'", cn)
    'dr = cmd.ExecuteReader
    'If dr.Read Then
    'resultado = True
    'End If
    'dr.Close()
    'cn.Close()

    'Catch ex As Exception
    'MsgBox("error en el procedimineto" + ex.ToString)
    'End Try
    'Return resultado
    'End Function

End Class
