Imports System.Data
Imports System.Data.SqlClient

Public Class InsertarRegistro

    Dim conexion As Conexion = New Conexion



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim agregar As String = "Insert into ConfiguracionLlamadas values (" + txtId.Text + "," +
            txtIvr.Text + "," + txtP1.Text + "," + txtOp1.Text + "," + txtP2.Text + "," +
            txtPin.Text + "," + txtP3.Text + "," + txtDestino.Text + ", 60, 1 );"

        If (conexion.insertar(agregar)) Then
            MessageBox.Show("Registro agregado correctamente...")
            Me.Close()
            mainForm.MostrarDatos()

        Else
            MessageBox.Show("Error al agregar los datos")
        End If
    End Sub

    Private Sub maxId()
        Dim i As Integer = 0
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection
        cn.ConnectionString = "Data Source=LAP-ASG-5TF2062;Initial Catalog=Mydatabase;Integrated Security=True"

        cmd.Connection = cn
        cn.Open()

        cmd.CommandText = "Select max(id) from ConfiguracionLlamadas"



        If IsDBNull(cmd.ExecuteScalar) Then
            i = 1
            txtId.Text = i

        Else
            i = cmd.ExecuteScalar + 1
            txtId.Text = i
        End If

        cmd.Dispose()
        cmd.Connection.Close()
        cmd.Connection.Dispose()



    End Sub

    Private Sub InsertarRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        maxId()
    End Sub

    Private Sub btnGAgregar_Click(sender As Object, e As EventArgs) Handles btnGAgregar.Click

    End Sub
End Class