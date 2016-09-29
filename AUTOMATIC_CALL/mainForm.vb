Imports System.Data.SqlClient
Imports System.Data


Public Class mainForm

    Dim Contador1 As Integer = 0
    Dim Contador2 As Integer = 0
    Dim Contador3 As Integer = 0
    Dim Contador4 As Integer = 0
    Dim Contador5 As Integer = 0

    Dim reader As SqlDataReader

    Dim conexion As Conexion = New Conexion()

    'Función para quitar los saltos de línea de un texto
    Private Function quitarSaltosLinea(ByVal texto As String, caracterReemplazar As String) As String
        quitarSaltosLinea = Replace(Replace(texto, Chr(10), caracterReemplazar), Chr(13), caracterReemplazar)
    End Function

    Private Function obtenerCobertura(
                      ByVal texto As String) As Double
        Dim pos As Integer
        Dim textoTemp As String

        texto = quitarSaltosLinea(texto, " ")
        pos = texto.IndexOf("CSQ:") + Len("CSQ:") + 1
        textoTemp = Mid(texto, pos, Len(texto))
        textoTemp = Trim(Replace(textoTemp, "OK", ""))

        obtenerCobertura = CDbl(Replace(textoTemp, ",", "."))
    End Function

    'Obtener los puertos Serie (COM) disponibles en el PC
    Function obtenerPuertosSeriePC() As List(Of String)
        Dim puertosSerie As List(Of String)

        puertosSerie = New List(Of String)
        Try
            puertosSerie = New List(Of String)
            For Each puertosSerieObtenidos As String
                        In My.Computer.Ports.SerialPortNames
                puertosSerie.Add(puertosSerieObtenidos)
            Next
            obtenerPuertosSeriePC = puertosSerie
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            obtenerPuertosSeriePC = puertosSerie
        End Try
    End Function

    'Abre el puerto serie pasado como parámetro
    Sub abrirPuertoSerie(ByVal puerto As String)
        Try
            With compPuertoSerie
                If .IsOpen Then
                    .Close()
                End If

                .PortName = puerto
                .BaudRate = CInt(lsBitPorSegundo.Text)
                .DataBits = CInt(lsBitDatos.Text)
                Select Case lsBitsParada.Text
                    Case "1"
                        .StopBits = IO.Ports.StopBits.One
                    Case "1.5"
                        .StopBits = IO.Ports.StopBits.OnePointFive
                    Case "2"
                        .StopBits = IO.Ports.StopBits.Two
                    Case "Ninguno"
                        .StopBits = IO.Ports.StopBits.None
                End Select

                Select Case lsParidad.Text
                    Case "Par"
                        .Parity = IO.Ports.Parity.Even
                    Case "Impar"
                        .Parity = IO.Ports.Parity.Odd
                    Case "Ninguno"
                        .Parity = IO.Ports.Parity.None
                    Case "Marca"
                        .Parity = IO.Ports.Parity.Mark
                    Case "Espacio"
                        .Parity = IO.Ports.Parity.Space
                End Select

                Select Case lsControlFlujo.Text
                    Case "Hardware"
                        .Handshake = IO.Ports.Handshake.RequestToSend
                    Case "Xon / Xoff"
                        .Handshake = IO.Ports.Handshake.XOnXOff
                    Case "Ninguno"
                        .Handshake = IO.Ports.Handshake.None
                    Case "Hardware y Xon/Xoff"
                        .Handshake = IO.Ports.Handshake.RequestToSendXOnXOff
                End Select

                .DtrEnable = False

                .ReadBufferSize = CInt(txtTamanoBufferLectura.Text)
                .WriteBufferSize = CInt(txtTamanoBufferEscritura.Text)
                .WriteTimeout = CInt(txtTiempoEspera.Text)
                .RtsEnable = True
                .Encoding = System.Text.Encoding.Default
                .Open()
            End With

        Catch ex As Exception
            MsgBox("Error al abrir el puerto serie: " &
                   ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub btObtenerPuertos_Click(sender As System.Object,
                  e As System.EventArgs) Handles btObtenerPuertos.Click
        Dim puertosSerie As List(Of String)
        Dim i As Integer

        txtPuerto.Items.Clear()

        puertosSerie = obtenerPuertosSeriePC()
        For i = 0 To puertosSerie.Count - 1
            txtPuerto.Items.Add(puertosSerie(i).ToString)
        Next

        If txtPuerto.Items.Count >= 1 Then
            txtPuerto.Text = txtPuerto.Items(0)
        Else
            txtPuerto.Text = ""
        End If

        If puertosSerie.Count = 0 Then
            MsgBox("No se han detectado puertos serie en su equipo, " +
                   "asegúrese de que están correctamente configurados.",
                   MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        End If
    End Sub


    Private Sub btConectar_Click(sender As System.Object,
                  e As System.EventArgs) Handles btConectar.Click
        Dim posBusqueda As Integer
        Dim resultadoDevuelto As String

        Try
            If btConectar.Text = "Conectar" Then
                If txtPuerto.Text = "" Or
                        txtTamanoBufferEscritura.Text = "" Or
                        txtTamanoBufferLectura.Text = "" Or
                        txtTiempoEspera.Text = "" Or
                        lsBitDatos.Text = "" Or
                        lsBitPorSegundo.Text = "" Or
                        lsBitsParada.Text = "" Or
                        lsControlFlujo.Text = "" Or
                        lsParidad.Text = "" Then
                    MsgBox("Antes de conectar con el puerto serie debe introducir los datos " &
                            "de conexión con el módem GSM y la tarjeta SIM.",
                            MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Else
                    abrirPuertoSerie(txtPuerto.Text)

                    'Comprobar si hay un módem GSM conectado al puerto serie
                    compPuertoSerie.Write("AT" & Chr(13))
                    'Esperamos un segundo para dar tiempo a 
                    'las comunicaciones serie
                    System.Threading.Thread.Sleep(1000)
                    'Si el comando AT devuelve OK es que hay módem GSM
                    If compPuertoSerie.ReadExisting().IndexOf("OK") Then
                        bePModem.Text = "Módem GSM activo"
                        bePModem.ForeColor = Color.Green
                    Else
                        bePModem.Text = "Módem GSM no encontrado"
                        bePModem.ForeColor = Color.Red
                    End If
                    'Limpiamos el bugger de datos de entrada 
                    'devueltos por el módem GSM
                    compPuertoSerie.DiscardInBuffer()

                    'Comprobar si el módem módem GSM está conectado a una red GSM
                    compPuertoSerie.Write("AT+CREG?" & Chr(13))
                    System.Threading.Thread.Sleep(1000)
                    'Si el comando AT+CREG? devuelve 0,1 es que hay red móvil
                    If compPuertoSerie.ReadExisting().IndexOf("0,1") Then
                        bePRedMovil.Text = "Red móvil disponible"
                        bePRedMovil.ForeColor = Color.Green
                    Else
                        bePRedMovil.Text = "No hay red móvil"
                        bePRedMovil.ForeColor = Color.Red
                    End If
                    compPuertoSerie.DiscardInBuffer()

                    'Obtener la intensidad de la señal (cobertura) del módem GSM
                    'máximo: 31.99
                    compPuertoSerie.Write("AT+CSQ" & Chr(13))
                    System.Threading.Thread.Sleep(1000)
                    resultadoDevuelto = compPuertoSerie.ReadExisting()
                    posBusqueda = resultadoDevuelto.IndexOf("+CSQ: ")
                    If posBusqueda >= 0 Then
                        bpSenal.Minimum = 0
                        bpSenal.Maximum = 39
                        bpSenal.Value = obtenerCobertura(resultadoDevuelto)
                    Else
                        bpSenal.Minimum = 0
                        bpSenal.Value = 0
                        bpSenal.Minimum = 39
                    End If
                    compPuertoSerie.DiscardInBuffer()

                    'Obtener ID del dispositivo GSM (IMEI)
                    compPuertoSerie.Write("AT+CGSN" & Chr(13))
                    System.Threading.Thread.Sleep(1000)
                    resultadoDevuelto = compPuertoSerie.ReadExisting()
                    posBusqueda = resultadoDevuelto.IndexOf("CGSN")
                    If posBusqueda >= 0 Then
                        resultadoDevuelto =
                            quitarSaltosLinea(resultadoDevuelto, " ")
                        bePID.Text = "IMEI: " &
                            Replace(Mid(resultadoDevuelto, posBusqueda + Len("CGSN") + 1,
                            Len(resultadoDevuelto)), "OK", "")
                    End If

                    btConectar.Text = "Desconectar"
                End If
            Else
                If compPuertoSerie.IsOpen Then
                    System.Threading.Thread.Sleep(1000)
                    compPuertoSerie.Close()
                End If
                System.Threading.Thread.Sleep(500)
                btConectar.Text = "Conectar"
                bpSenal.Value = 0
                System.Threading.Thread.Sleep(500)
                bePID.Text = ""
                bePRedMovil.Text = "Red móvil"
                System.Threading.Thread.Sleep(500)
                bePRedMovil.ForeColor = Color.Black
                bePModem.Text = "Estado del Modem GSM"
                System.Threading.Thread.Sleep(500)
                bePModem.ForeColor = Color.Black
            End If
        Catch ex As Exception
            MsgBox("Error al abrir el puerto serial: " &
                   ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btEnviarATPrueba_Click(sender As System.Object,
                     e As System.EventArgs) _
                     Handles btEnviarATPrueba.Click
        Try
            compPuertoSerie.Write(txtComandoAT.Text & Chr(13))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical +
                   MsgBoxStyle.OkOnly)
        End Try
    End Sub

    'NOTA: este evento del SerialPort se ejecuta en un Thread 
    'diferente al de la aplicación, por lo que los datos devueltos 
    'por el puerto serie no tienen por qué ser instantáneos, puede que tengan retraso
    Private Sub compPuertoSerie_DataReceived(sender As System.Object,
            e As System.IO.Ports.SerialDataReceivedEventArgs) _
            Handles compPuertoSerie.DataReceived

        Dim resultadoModemGSM As String

        Try
            'Obtener el resultado devuelto por el puerto serie
            resultadoModemGSM = compPuertoSerie.ReadExisting.Trim().ToString

            If txtResultado.Text <> "" Then
                txtResultado.Text += EscribeLog("Respuesta MODEM: " + resultadoModemGSM)
                If Not resultadoModemGSM.IndexOf("NO CARRIER") Then
                    txtResultado.Text += EscribeLog("LLAMADA NO CONESTADA O ABORTADA...")
                End If

            Else
                txtResultado.Text = EscribeLog("INIZIALIZACIÓN : " + resultadoModemGSM)
            End If

            'Mostrar última línea del TextBox
            txtResultado.Select(txtResultado.Text.Length, 0)
            txtResultado.ScrollToCaret()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical +
                   MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub formEnvioSMS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Registros.ConfiguracionLlamadas' Puede moverla o quitarla según sea necesario.
        Me.ConfiguracionLlamadasTableAdapter.Fill(Me.Registros.ConfiguracionLlamadas)
        Dim con As New SqlConnection(My.Settings.ConnLocal)
        Dim sql As String = "SELECT id, ivr, pausa1, opcion1, pausa2, pin, pausa3, destino, time from ConfiguracionLlamadas"
        Dim cmd As New SqlCommand(sql, con)

        Try
            con.Open()

            Dim reader As SqlDataReader = cmd.ExecuteReader

            If reader.HasRows Then
                Console.WriteLine("Ingreso al segundo metodo de lectura")
                Dim i As Integer = 1
                'Do While reader.Read()
                'MsgBox("Cadena " & i & ": " &
                'reader("ivr").ToString() &
                'Pausa(reader("pausa1").ToString) &
                'reader("opcion1").ToString &
                'Pausa(reader("pausa2").ToString) &
                'reader("pin").ToString &
                'Pausa(reader("pausa3").ToString) &
                'reader("destino").ToString() &
                'reader("time").ToString
                '          )

                'i = i + 1

                'Console.WriteLine(reader.GetString(1) & vbTab & reader.GetString(2))
                'Loop
            Else
                Console.WriteLine("No rows found.")
            End If

            reader.Close()
            con.Close()

            'conexion.conectar()

            MostrarDatos()



        Catch ex As SqlException
            Console.WriteLine("Error: " & ex.ToString())
        End Try

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "ConfiguracionLlamadas")
            Me.DGV.DataSource = ds.Tables("ConfiguracionLlamadas")

            Me.DGV.Columns(0).HeaderText = "ID"
            Me.DGV.Columns(1).HeaderText = "IVR"
            Me.DGV.Columns(2).HeaderText = "PAUSA 1"
            Me.DGV.Columns(3).HeaderText = "OPCION 1"
            Me.DGV.Columns(4).HeaderText = "PAUSA 2"
            Me.DGV.Columns(5).HeaderText = "PIN"
            Me.DGV.Columns(6).HeaderText = "PAUSA 3"
            Me.DGV.Columns(7).HeaderText = "DESTINO"
            Me.DGV.Columns(8).HeaderText = "DURACION"


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'TODO: esta línea de código carga datos en la tabla 'DataSetLlamadas.ConfiguracionLlamadas' Puede moverla o quitarla según sea necesario.
        'Me.ConfiguracionLlamadasTableAdapter.Fill(Me.DataSetLlamadas.ConfiguracionLlamadas)
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Public Sub MostrarDatos()
        conexion.consulta("Select * from ConfiguracionLlamadas", "ConfiguracionLlamadas")
        DGV.DataSource = conexion.ds.Tables("ConfiguracionLlamadas")
    End Sub


    Private Sub btPIN_Click(sender As System.Object,
                e As System.EventArgs) Handles btPIN.Click
        Try
            'Enviar PIN a tarjeta SIM del dispositivo módem GSM
            compPuertoSerie.Write("AT+CPIN=" &
                                  txtPIN.Text & Chr(13))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical +
                   MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btnLlamar_Click(sender As Object, e As EventArgs) Handles btnLlamar.Click
        Try
            Dim con As New SqlConnection(My.Settings.ConnLocal)
            Dim sql As String = "SELECT id, ivr, pausa1, opcion1, pausa2, pin, pausa3, destino, time from ConfiguracionLlamadas"
            Dim cmd As New SqlCommand(sql, con)

            con.Open()
            reader = cmd.ExecuteReader

            If Not compPuertoSerie.IsOpen Then
                tabPes.SelectedTab = tabConfiguracionModem
                MsgBox("Antes de poder realizar una llamada debe introducir los datos " &
                        "de conexión con el módem GSM y la tarjeta SIM y " &
                        "conectar con el puerto serie.",
                        MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Else
                btnLlamar.Enabled = False
                If reader.HasRows Then
                    llamar(reader)
                End If
            End If

            reader.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical +
                   MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub llamar(registro As SqlDataReader)
        Try
            Timer2.Enabled = False

            Dim strRegistro As String

            If registro.HasRows Then
                Do While registro.Read()
                    Dim i As Integer = 0
                    strRegistro = (registro("ivr").ToString() &
                           Pausa(registro("pausa1").ToString) &
                           registro("opcion1").ToString &
                           Pausa(registro("pausa2").ToString) &
                           registro("pin").ToString &
                           Pausa(registro("pausa3").ToString) &
                           registro("destino").ToString()
                           )

                    Timer1.Interval = registro("time").ToString * 1000
                    Timer1.Enabled = True

                    compPuertoSerie.Write("ATD " & strRegistro & ";" & Chr(13))

                    'Si el comando ATD devuelve OK es que realizó la marcación 
                    If compPuertoSerie.ReadExisting().IndexOf("OK") Then
                        txtResultado.Text += EscribeLog("Marcando: " & strRegistro)
                        btnColgar.Enabled = True

                    End If

                Loop

            Else
                MsgBox("No hay datos por leer...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)

            End If

        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        Catch ex2 As Exception
            MsgBox(ex2.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub btnColgar_Click(sender As Object, e As EventArgs) Handles btnColgar.Click
        Try
            compPuertoSerie.Write("AT+CHUP" & Chr(13))
            'Si el comando AT+CHUP devuelve OK es que se colgo la llamada
            If compPuertoSerie.ReadExisting().IndexOf("OK") Then
                txtResultado.Text += EscribeLog("Prueba finalizada...")
            End If

            btnLlamar.Enabled = True
            btnColgar.Enabled = False
            txtEspera.Enabled = True

            Timer1.Enabled = False
            Timer2.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical +
               MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub colgar()
        Try
            'Timer1.Enabled = False
            Timer2.Interval = (txtEspera.Text * 1000)
            Timer2.Enabled = True

            Console.WriteLine("Entro al metodo colgar " & Now.ToString)

            compPuertoSerie.Write("AT+CHUP" & Chr(13))
            'Si el comando AT+CHUP devuelve OK es que se colgo la llamada
            If compPuertoSerie.ReadExisting().IndexOf("OK") Then
                txtResultado.Text += EscribeLog("Instrucción enviada: Colgar")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            EscribeLog(ex.Message)

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Console.WriteLine("Entro al timer1 que llama al metodo colgar() " & Now.ToString)
        Timer1.Enabled = False
        colgar()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        llamar(reader)
        Console.WriteLine("Entro al timer 2, que vuleve a llamar() " & Now.ToString)
    End Sub

    ' Rutinas de validacion, ayuda y control...

    Private Sub btDefecto_Click(sender As System.Object,
               e As System.EventArgs) Handles btDefecto.Click
        lsBitPorSegundo.Text = "9600"
        lsBitDatos.Text = "8"
        lsParidad.Text = "Ninguno"
        lsBitsParada.Text = "1"
        lsControlFlujo.Text = "Ninguno"
        txtTamanoBufferLectura.Text = "1024"
        txtTamanoBufferEscritura.Text = "1024"
        txtTiempoEspera.Text = "500"
    End Sub

    Private Sub btnExportLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        sfd1.Filter = "TXT Files (*.txt)|*.txt"
        sfd1.Title = "Guardar archivo Log"

        If sfd1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(sfd1.FileName, txtResultado.Text, False)
        End If

    End Sub

    Function EscribeLog(Msj As String)

        Return ">> " & Now.ToString & ": " & Msj & vbCrLf

        'Mostrar última línea del TextBox
        txtResultado.Select(txtResultado.Text.Length, 0)
        txtResultado.ScrollToCaret()

    End Function

    Private Sub linkURL_LinkClicked(sender As System.Object,
               e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) _
               Handles linkURL.LinkClicked
        System.Diagnostics.Process.Start("mailto:lggarciao@claro.com.gt")
    End Sub

    Private Function Pausa(dato As Integer) As String
        ' variable que contendra la concatenación de comas (pausas) entre un marcado y otro
        Dim separador As String = ""

        Dim ajuste As Integer = 0
        ' Esto es para realizar el ajuste, ya que cada coma (,) equivale casi a 2 segundos de pausa
        ajuste = (dato / 2)

        For i = 1 To ajuste
            separador += ","
        Next

        Return separador

    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        InsertarRegistro.Show()

    End Sub
End Class
