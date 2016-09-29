Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Conexion

    Public conexion As SqlConnection = New SqlConnection("Data Source=LAP-ASG-5TF2062;Initial Catalog=Mydatabase;Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public comando As SqlCommand



    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conexion realiada")
        Catch ex As Exception
            MessageBox.Show("Falló la conexión, favor de revisar")
        Finally
            conexion.Close()
        End Try

    End Sub

    Public Sub consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Function insertar(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery
        If (i > 0) Then
            Return True
        Else
            Return False

        End If

    End Function




End Class
