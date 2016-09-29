<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.compPuertoSerie = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.be = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bpSenal = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bePModem = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bePRedMovil = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bePID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.linkURL = New System.Windows.Forms.LinkLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.sfd1 = New System.Windows.Forms.SaveFileDialog()
        Me.tabConfiguracionModem = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtTiempoEspera = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTamanoBufferEscritura = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTamanoBufferLectura = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btDefecto = New System.Windows.Forms.Button()
        Me.lsControlFlujo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lsBitsParada = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lsParidad = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lsBitDatos = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lsBitPorSegundo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btPIN = New System.Windows.Forms.Button()
        Me.txtPIN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btConectar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPuerto = New System.Windows.Forms.ComboBox()
        Me.btObtenerPuertos = New System.Windows.Forms.Button()
        Me.tabEnviarAT = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btEnviarATPrueba = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtComandoAT = New System.Windows.Forms.TextBox()
        Me.tabLLamadas = New System.Windows.Forms.TabPage()
        Me.gbDestinos = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEspera = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvrDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pausa1DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Opcion1DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pausa2DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PinDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pausa3DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConfiguracionLlamadasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registros = New CALL_DATAGRID.Registros()
        Me.btnColgar = New System.Windows.Forms.Button()
        Me.btnLlamar = New System.Windows.Forms.Button()
        Me.tabPes = New System.Windows.Forms.TabControl()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pausa1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Opcion1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pausa2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pausa3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfiguracionLlamadasTableAdapter = New CALL_DATAGRID.RegistrosTableAdapters.ConfiguracionLlamadasTableAdapter()
        Me.TableAdapterManager = New CALL_DATAGRID.RegistrosTableAdapters.TableAdapterManager()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3.SuspendLayout()
        Me.be.SuspendLayout()
        Me.tabConfiguracionModem.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabEnviarAT.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tabLLamadas.SuspendLayout()
        Me.gbDestinos.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfiguracionLlamadasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPes.SuspendLayout()
        CType(Me.RegistrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'compPuertoSerie
        '
        Me.compPuertoSerie.WriteTimeout = 500
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btnLog)
        Me.GroupBox3.Controls.Add(Me.txtResultado)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 432)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(847, 129)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultado "
        '
        'btnLog
        '
        Me.btnLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLog.Location = New System.Drawing.Point(12, 100)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(75, 23)
        Me.btnLog.TabIndex = 20
        Me.btnLog.Text = "Guardar Log"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResultado.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtResultado.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.ForeColor = System.Drawing.SystemColors.Info
        Me.txtResultado.Location = New System.Drawing.Point(13, 19)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResultado.Size = New System.Drawing.Size(828, 79)
        Me.txtResultado.TabIndex = 19
        '
        'be
        '
        Me.be.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.bpSenal, Me.ToolStripStatusLabel2, Me.bePModem, Me.ToolStripStatusLabel3, Me.bePRedMovil, Me.ToolStripStatusLabel4, Me.bePID})
        Me.be.Location = New System.Drawing.Point(0, 591)
        Me.be.Name = "be"
        Me.be.Size = New System.Drawing.Size(873, 22)
        Me.be.TabIndex = 12
        Me.be.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel1.Text = "Señal:"
        '
        'bpSenal
        '
        Me.bpSenal.Name = "bpSenal"
        Me.bpSenal.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(19, 17)
        Me.ToolStripStatusLabel2.Text = " |  "
        '
        'bePModem
        '
        Me.bePModem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bePModem.Name = "bePModem"
        Me.bePModem.Size = New System.Drawing.Size(134, 17)
        Me.bePModem.Text = "Estado del módem GSM"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(19, 17)
        Me.ToolStripStatusLabel3.Text = " |  "
        '
        'bePRedMovil
        '
        Me.bePRedMovil.Name = "bePRedMovil"
        Me.bePRedMovil.Size = New System.Drawing.Size(60, 17)
        Me.bePRedMovil.Text = "Red móvil"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(19, 17)
        Me.ToolStripStatusLabel4.Text = " |  "
        '
        'bePID
        '
        Me.bePID.Name = "bePID"
        Me.bePID.Size = New System.Drawing.Size(78, 17)
        Me.bePID.Text = "ID dispositivo"
        '
        'linkURL
        '
        Me.linkURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkURL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkURL.Location = New System.Drawing.Point(12, 570)
        Me.linkURL.Name = "linkURL"
        Me.linkURL.Size = New System.Drawing.Size(845, 13)
        Me.linkURL.TabIndex = 21
        Me.linkURL.TabStop = True
        Me.linkURL.Text = "Informar de algún error o falla"
        Me.linkURL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Timer2
        '
        '
        'tabConfiguracionModem
        '
        Me.tabConfiguracionModem.BackColor = System.Drawing.SystemColors.Control
        Me.tabConfiguracionModem.Controls.Add(Me.GroupBox5)
        Me.tabConfiguracionModem.Controls.Add(Me.GroupBox1)
        Me.tabConfiguracionModem.Location = New System.Drawing.Point(4, 22)
        Me.tabConfiguracionModem.Name = "tabConfiguracionModem"
        Me.tabConfiguracionModem.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConfiguracionModem.Size = New System.Drawing.Size(841, 388)
        Me.tabConfiguracionModem.TabIndex = 1
        Me.tabConfiguracionModem.Text = "Configuración puerto y módem GSM "
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtTiempoEspera)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.txtTamanoBufferEscritura)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtTamanoBufferLectura)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.btDefecto)
        Me.GroupBox5.Controls.Add(Me.lsControlFlujo)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.lsBitsParada)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.lsParidad)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.lsBitDatos)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.lsBitPorSegundo)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Location = New System.Drawing.Point(19, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(627, 119)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Configuración del puerto "
        '
        'txtTiempoEspera
        '
        Me.txtTiempoEspera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTiempoEspera.Location = New System.Drawing.Point(547, 62)
        Me.txtTiempoEspera.Name = "txtTiempoEspera"
        Me.txtTiempoEspera.Size = New System.Drawing.Size(60, 20)
        Me.txtTiempoEspera.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(469, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Tiempo espera"
        '
        'txtTamanoBufferEscritura
        '
        Me.txtTamanoBufferEscritura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTamanoBufferEscritura.Location = New System.Drawing.Point(547, 35)
        Me.txtTamanoBufferEscritura.Name = "txtTamanoBufferEscritura"
        Me.txtTamanoBufferEscritura.Size = New System.Drawing.Size(60, 20)
        Me.txtTamanoBufferEscritura.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(469, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Buffer escritura"
        '
        'txtTamanoBufferLectura
        '
        Me.txtTamanoBufferLectura.Location = New System.Drawing.Point(327, 94)
        Me.txtTamanoBufferLectura.Name = "txtTamanoBufferLectura"
        Me.txtTamanoBufferLectura.Size = New System.Drawing.Size(80, 20)
        Me.txtTamanoBufferLectura.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(249, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Buffer lectura"
        '
        'btDefecto
        '
        Me.btDefecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btDefecto.Location = New System.Drawing.Point(442, 88)
        Me.btDefecto.Name = "btDefecto"
        Me.btDefecto.Size = New System.Drawing.Size(167, 25)
        Me.btDefecto.TabIndex = 9
        Me.btDefecto.Text = " &Establecer valores por defecto"
        Me.btDefecto.UseVisualStyleBackColor = True
        '
        'lsControlFlujo
        '
        Me.lsControlFlujo.FormattingEnabled = True
        Me.lsControlFlujo.Items.AddRange(New Object() {"Hardware", "Xon / Xoff", "Hardware y Xon/Xoff", "Ninguno"})
        Me.lsControlFlujo.Location = New System.Drawing.Point(107, 89)
        Me.lsControlFlujo.Name = "lsControlFlujo"
        Me.lsControlFlujo.Size = New System.Drawing.Size(111, 21)
        Me.lsControlFlujo.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Control de flujo"
        '
        'lsBitsParada
        '
        Me.lsBitsParada.FormattingEnabled = True
        Me.lsBitsParada.Items.AddRange(New Object() {"1", "1.5", "2", "Ninguno"})
        Me.lsBitsParada.Location = New System.Drawing.Point(327, 65)
        Me.lsBitsParada.Name = "lsBitsParada"
        Me.lsBitsParada.Size = New System.Drawing.Size(80, 21)
        Me.lsBitsParada.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(244, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Bits de parada"
        '
        'lsParidad
        '
        Me.lsParidad.FormattingEnabled = True
        Me.lsParidad.Items.AddRange(New Object() {"Par", "Impar", "Ninguno", "Marca", "Espacio"})
        Me.lsParidad.Location = New System.Drawing.Point(107, 62)
        Me.lsParidad.Name = "lsParidad"
        Me.lsParidad.Size = New System.Drawing.Size(111, 21)
        Me.lsParidad.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(56, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Paridad"
        '
        'lsBitDatos
        '
        Me.lsBitDatos.FormattingEnabled = True
        Me.lsBitDatos.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.lsBitDatos.Location = New System.Drawing.Point(327, 38)
        Me.lsBitDatos.Name = "lsBitDatos"
        Me.lsBitDatos.Size = New System.Drawing.Size(80, 21)
        Me.lsBitDatos.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(251, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Bits de datos"
        '
        'lsBitPorSegundo
        '
        Me.lsBitPorSegundo.FormattingEnabled = True
        Me.lsBitPorSegundo.Items.AddRange(New Object() {"110", "300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400", "460800", "921600"})
        Me.lsBitPorSegundo.Location = New System.Drawing.Point(107, 35)
        Me.lsBitPorSegundo.Name = "lsBitPorSegundo"
        Me.lsBitPorSegundo.Size = New System.Drawing.Size(111, 21)
        Me.lsBitPorSegundo.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Bits por segundo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btPIN)
        Me.GroupBox1.Controls.Add(Me.txtPIN)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btConectar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPuerto)
        Me.GroupBox1.Controls.Add(Me.btObtenerPuertos)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(627, 82)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de conexión módem GSM "
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(441, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "PIN de la tarjeta SIM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Puerto serie (COM) con módem GSM"
        '
        'btPIN
        '
        Me.btPIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btPIN.Location = New System.Drawing.Point(506, 26)
        Me.btPIN.Name = "btPIN"
        Me.btPIN.Size = New System.Drawing.Size(111, 28)
        Me.btPIN.TabIndex = 5
        Me.btPIN.Text = "Establecer PIN"
        Me.btPIN.UseVisualStyleBackColor = True
        '
        'txtPIN
        '
        Me.txtPIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPIN.Location = New System.Drawing.Point(444, 30)
        Me.txtPIN.Name = "txtPIN"
        Me.txtPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPIN.Size = New System.Drawing.Size(57, 20)
        Me.txtPIN.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(417, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "PIN"
        '
        'btConectar
        '
        Me.btConectar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btConectar.Location = New System.Drawing.Point(251, 26)
        Me.btConectar.Name = "btConectar"
        Me.btConectar.Size = New System.Drawing.Size(82, 27)
        Me.btConectar.TabIndex = 3
        Me.btConectar.Text = "Conectar"
        Me.btConectar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Puerto"
        '
        'txtPuerto
        '
        Me.txtPuerto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPuerto.FormattingEnabled = True
        Me.txtPuerto.Location = New System.Drawing.Point(67, 30)
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.Size = New System.Drawing.Size(101, 21)
        Me.txtPuerto.TabIndex = 1
        '
        'btObtenerPuertos
        '
        Me.btObtenerPuertos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btObtenerPuertos.Location = New System.Drawing.Point(174, 26)
        Me.btObtenerPuertos.Name = "btObtenerPuertos"
        Me.btObtenerPuertos.Size = New System.Drawing.Size(71, 27)
        Me.btObtenerPuertos.TabIndex = 2
        Me.btObtenerPuertos.Text = "<< Obtener"
        Me.btObtenerPuertos.UseVisualStyleBackColor = True
        '
        'tabEnviarAT
        '
        Me.tabEnviarAT.BackColor = System.Drawing.SystemColors.Control
        Me.tabEnviarAT.Controls.Add(Me.GroupBox4)
        Me.tabEnviarAT.Location = New System.Drawing.Point(4, 22)
        Me.tabEnviarAT.Name = "tabEnviarAT"
        Me.tabEnviarAT.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEnviarAT.Size = New System.Drawing.Size(841, 388)
        Me.tabEnviarAT.TabIndex = 2
        Me.tabEnviarAT.Text = "Enviar comando AT "
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.btEnviarATPrueba)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtComandoAT)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(798, 123)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Enviar comando AT al módem GSM "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(96, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(485, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "El resultado de la ejecución del comando AT (si lo hay) aparecerá en ""Resultado"" " &
    "(en la parte inferior)"
        '
        'btEnviarATPrueba
        '
        Me.btEnviarATPrueba.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btEnviarATPrueba.Location = New System.Drawing.Point(664, 26)
        Me.btEnviarATPrueba.Name = "btEnviarATPrueba"
        Me.btEnviarATPrueba.Size = New System.Drawing.Size(115, 27)
        Me.btEnviarATPrueba.TabIndex = 2
        Me.btEnviarATPrueba.Text = "Enviar comando AT"
        Me.btEnviarATPrueba.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Comando AT"
        '
        'txtComandoAT
        '
        Me.txtComandoAT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComandoAT.Location = New System.Drawing.Point(99, 30)
        Me.txtComandoAT.Name = "txtComandoAT"
        Me.txtComandoAT.Size = New System.Drawing.Size(559, 20)
        Me.txtComandoAT.TabIndex = 1
        '
        'tabLLamadas
        '
        Me.tabLLamadas.AutoScroll = True
        Me.tabLLamadas.BackColor = System.Drawing.SystemColors.Control
        Me.tabLLamadas.Controls.Add(Me.gbDestinos)
        Me.tabLLamadas.Location = New System.Drawing.Point(4, 22)
        Me.tabLLamadas.Name = "tabLLamadas"
        Me.tabLLamadas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLLamadas.Size = New System.Drawing.Size(841, 388)
        Me.tabLLamadas.TabIndex = 3
        Me.tabLLamadas.Text = "Realiza llamada"
        '
        'gbDestinos
        '
        Me.gbDestinos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDestinos.BackColor = System.Drawing.Color.Transparent
        Me.gbDestinos.Controls.Add(Me.btnAgregar)
        Me.gbDestinos.Controls.Add(Me.Label2)
        Me.gbDestinos.Controls.Add(Me.txtEspera)
        Me.gbDestinos.Controls.Add(Me.DGV)
        Me.gbDestinos.Controls.Add(Me.btnColgar)
        Me.gbDestinos.Controls.Add(Me.btnLlamar)
        Me.gbDestinos.Controls.Add(Me.Panel1)
        Me.gbDestinos.Location = New System.Drawing.Point(19, 19)
        Me.gbDestinos.Name = "gbDestinos"
        Me.gbDestinos.Size = New System.Drawing.Size(806, 339)
        Me.gbDestinos.TabIndex = 0
        Me.gbDestinos.TabStop = False
        Me.gbDestinos.Text = "Destinos"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(624, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Espera:"
        '
        'txtEspera
        '
        Me.txtEspera.Location = New System.Drawing.Point(670, 146)
        Me.txtEspera.Name = "txtEspera"
        Me.txtEspera.Size = New System.Drawing.Size(41, 20)
        Me.txtEspera.TabIndex = 38
        Me.txtEspera.Text = "5"
        Me.txtEspera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.AutoGenerateColumns = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.IvrDataGridViewTextBoxColumn1, Me.Pausa1DataGridViewTextBoxColumn1, Me.Opcion1DataGridViewTextBoxColumn1, Me.Pausa2DataGridViewTextBoxColumn1, Me.PinDataGridViewTextBoxColumn1, Me.Pausa3DataGridViewTextBoxColumn1, Me.DestinoDataGridViewTextBoxColumn1, Me.TimeDataGridViewTextBoxColumn1})
        Me.DGV.DataSource = Me.ConfiguracionLlamadasBindingSource1
        Me.DGV.Location = New System.Drawing.Point(6, 19)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(705, 124)
        Me.DGV.TabIndex = 37
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'IvrDataGridViewTextBoxColumn1
        '
        Me.IvrDataGridViewTextBoxColumn1.DataPropertyName = "ivr"
        Me.IvrDataGridViewTextBoxColumn1.HeaderText = "ivr"
        Me.IvrDataGridViewTextBoxColumn1.Name = "IvrDataGridViewTextBoxColumn1"
        Me.IvrDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Pausa1DataGridViewTextBoxColumn1
        '
        Me.Pausa1DataGridViewTextBoxColumn1.DataPropertyName = "pausa1"
        Me.Pausa1DataGridViewTextBoxColumn1.HeaderText = "pausa1"
        Me.Pausa1DataGridViewTextBoxColumn1.Name = "Pausa1DataGridViewTextBoxColumn1"
        Me.Pausa1DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Opcion1DataGridViewTextBoxColumn1
        '
        Me.Opcion1DataGridViewTextBoxColumn1.DataPropertyName = "opcion1"
        Me.Opcion1DataGridViewTextBoxColumn1.HeaderText = "opcion1"
        Me.Opcion1DataGridViewTextBoxColumn1.Name = "Opcion1DataGridViewTextBoxColumn1"
        Me.Opcion1DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Pausa2DataGridViewTextBoxColumn1
        '
        Me.Pausa2DataGridViewTextBoxColumn1.DataPropertyName = "pausa2"
        Me.Pausa2DataGridViewTextBoxColumn1.HeaderText = "pausa2"
        Me.Pausa2DataGridViewTextBoxColumn1.Name = "Pausa2DataGridViewTextBoxColumn1"
        Me.Pausa2DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PinDataGridViewTextBoxColumn1
        '
        Me.PinDataGridViewTextBoxColumn1.DataPropertyName = "pin"
        Me.PinDataGridViewTextBoxColumn1.HeaderText = "pin"
        Me.PinDataGridViewTextBoxColumn1.Name = "PinDataGridViewTextBoxColumn1"
        Me.PinDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Pausa3DataGridViewTextBoxColumn1
        '
        Me.Pausa3DataGridViewTextBoxColumn1.DataPropertyName = "pausa3"
        Me.Pausa3DataGridViewTextBoxColumn1.HeaderText = "pausa3"
        Me.Pausa3DataGridViewTextBoxColumn1.Name = "Pausa3DataGridViewTextBoxColumn1"
        Me.Pausa3DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DestinoDataGridViewTextBoxColumn1
        '
        Me.DestinoDataGridViewTextBoxColumn1.DataPropertyName = "destino"
        Me.DestinoDataGridViewTextBoxColumn1.HeaderText = "destino"
        Me.DestinoDataGridViewTextBoxColumn1.Name = "DestinoDataGridViewTextBoxColumn1"
        Me.DestinoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TimeDataGridViewTextBoxColumn1
        '
        Me.TimeDataGridViewTextBoxColumn1.DataPropertyName = "time"
        Me.TimeDataGridViewTextBoxColumn1.HeaderText = "time"
        Me.TimeDataGridViewTextBoxColumn1.Name = "TimeDataGridViewTextBoxColumn1"
        Me.TimeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ConfiguracionLlamadasBindingSource1
        '
        Me.ConfiguracionLlamadasBindingSource1.DataMember = "ConfiguracionLlamadas"
        Me.ConfiguracionLlamadasBindingSource1.DataSource = Me.Registros
        '
        'Registros
        '
        Me.Registros.DataSetName = "Registros"
        Me.Registros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnColgar
        '
        Me.btnColgar.Enabled = False
        Me.btnColgar.Location = New System.Drawing.Point(87, 303)
        Me.btnColgar.Name = "btnColgar"
        Me.btnColgar.Size = New System.Drawing.Size(75, 30)
        Me.btnColgar.TabIndex = 18
        Me.btnColgar.Text = "Colgar"
        Me.btnColgar.UseVisualStyleBackColor = True
        '
        'btnLlamar
        '
        Me.btnLlamar.Location = New System.Drawing.Point(6, 303)
        Me.btnLlamar.Name = "btnLlamar"
        Me.btnLlamar.Size = New System.Drawing.Size(75, 30)
        Me.btnLlamar.TabIndex = 17
        Me.btnLlamar.Text = "Llamar"
        Me.btnLlamar.UseVisualStyleBackColor = True
        '
        'tabPes
        '
        Me.tabPes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabPes.Controls.Add(Me.tabLLamadas)
        Me.tabPes.Controls.Add(Me.tabConfiguracionModem)
        Me.tabPes.Controls.Add(Me.tabEnviarAT)
        Me.tabPes.Location = New System.Drawing.Point(12, 12)
        Me.tabPes.Name = "tabPes"
        Me.tabPes.SelectedIndex = 0
        Me.tabPes.Size = New System.Drawing.Size(849, 414)
        Me.tabPes.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'IvrDataGridViewTextBoxColumn
        '
        Me.IvrDataGridViewTextBoxColumn.DataPropertyName = "ivr"
        Me.IvrDataGridViewTextBoxColumn.HeaderText = "ivr"
        Me.IvrDataGridViewTextBoxColumn.Name = "IvrDataGridViewTextBoxColumn"
        '
        'Pausa1DataGridViewTextBoxColumn
        '
        Me.Pausa1DataGridViewTextBoxColumn.DataPropertyName = "pausa1"
        Me.Pausa1DataGridViewTextBoxColumn.HeaderText = "pausa1"
        Me.Pausa1DataGridViewTextBoxColumn.Name = "Pausa1DataGridViewTextBoxColumn"
        '
        'Opcion1DataGridViewTextBoxColumn
        '
        Me.Opcion1DataGridViewTextBoxColumn.DataPropertyName = "opcion1"
        Me.Opcion1DataGridViewTextBoxColumn.HeaderText = "opcion1"
        Me.Opcion1DataGridViewTextBoxColumn.Name = "Opcion1DataGridViewTextBoxColumn"
        '
        'Pausa2DataGridViewTextBoxColumn
        '
        Me.Pausa2DataGridViewTextBoxColumn.DataPropertyName = "pausa2"
        Me.Pausa2DataGridViewTextBoxColumn.HeaderText = "pausa2"
        Me.Pausa2DataGridViewTextBoxColumn.Name = "Pausa2DataGridViewTextBoxColumn"
        '
        'PinDataGridViewTextBoxColumn
        '
        Me.PinDataGridViewTextBoxColumn.DataPropertyName = "pin"
        Me.PinDataGridViewTextBoxColumn.HeaderText = "pin"
        Me.PinDataGridViewTextBoxColumn.Name = "PinDataGridViewTextBoxColumn"
        '
        'Pausa3DataGridViewTextBoxColumn
        '
        Me.Pausa3DataGridViewTextBoxColumn.DataPropertyName = "pausa3"
        Me.Pausa3DataGridViewTextBoxColumn.HeaderText = "pausa3"
        Me.Pausa3DataGridViewTextBoxColumn.Name = "Pausa3DataGridViewTextBoxColumn"
        '
        'DestinoDataGridViewTextBoxColumn
        '
        Me.DestinoDataGridViewTextBoxColumn.DataPropertyName = "destino"
        Me.DestinoDataGridViewTextBoxColumn.HeaderText = "destino"
        Me.DestinoDataGridViewTextBoxColumn.Name = "DestinoDataGridViewTextBoxColumn"
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "time"
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "time"
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ivr"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ivr"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "pausa1"
        Me.DataGridViewTextBoxColumn3.HeaderText = "pausa1"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "opcion1"
        Me.DataGridViewTextBoxColumn4.HeaderText = "opcion1"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "pausa2"
        Me.DataGridViewTextBoxColumn5.HeaderText = "pausa2"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "pin"
        Me.DataGridViewTextBoxColumn6.HeaderText = "pin"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "pausa3"
        Me.DataGridViewTextBoxColumn7.HeaderText = "pausa3"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "destino"
        Me.DataGridViewTextBoxColumn8.HeaderText = "destino"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "time"
        Me.DataGridViewTextBoxColumn9.HeaderText = "time"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'RegistrosBindingSource
        '
        Me.RegistrosBindingSource.DataSource = Me.Registros
        Me.RegistrosBindingSource.Position = 0
        '
        'ConfiguracionLlamadasTableAdapter
        '
        Me.ConfiguracionLlamadasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ConfiguracionLlamadasTableAdapter = Me.ConfiguracionLlamadasTableAdapter
        Me.TableAdapterManager.UpdateOrder = CALL_DATAGRID.RegistrosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(6, 149)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 30)
        Me.btnAgregar.TabIndex = 40
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = Global.CALL_DATAGRID.My.Resources.Resources.claroooo
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(717, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(83, 84)
        Me.Panel1.TabIndex = 0
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(873, 613)
        Me.Controls.Add(Me.linkURL)
        Me.Controls.Add(Me.tabPes)
        Me.Controls.Add(Me.be)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generador de llamadas <<Claro>> V.2016.1"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.be.ResumeLayout(False)
        Me.be.PerformLayout()
        Me.tabConfiguracionModem.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabEnviarAT.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tabLLamadas.ResumeLayout(False)
        Me.gbDestinos.ResumeLayout(False)
        Me.gbDestinos.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfiguracionLlamadasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPes.ResumeLayout(False)
        CType(Me.RegistrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents compPuertoSerie As System.IO.Ports.SerialPort
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtResultado As System.Windows.Forms.TextBox
    Friend WithEvents be As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bpSenal As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bePModem As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bePRedMovil As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bePID As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents linkURL As System.Windows.Forms.LinkLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents sfd1 As SaveFileDialog
    Friend WithEvents btnLog As Button
    Friend WithEvents tabConfiguracionModem As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtTiempoEspera As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtTamanoBufferEscritura As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTamanoBufferLectura As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btDefecto As Button
    Friend WithEvents lsControlFlujo As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lsBitsParada As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lsParidad As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lsBitDatos As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lsBitPorSegundo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btPIN As Button
    Friend WithEvents txtPIN As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btConectar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPuerto As ComboBox
    Friend WithEvents btObtenerPuertos As Button
    Friend WithEvents tabEnviarAT As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btEnviarATPrueba As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtComandoAT As TextBox
    Friend WithEvents tabLLamadas As TabPage
    Friend WithEvents gbDestinos As GroupBox
    Friend WithEvents btnColgar As Button
    Friend WithEvents btnLlamar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tabPes As TabControl
    Friend WithEvents ConfiguracionLlamadasBindingSource As BindingSource
    Friend WithEvents Registros As Registros
    Friend WithEvents RegistrosBindingSource As BindingSource
    Friend WithEvents DGV As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IvrDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Pausa1DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Opcion1DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Pausa2DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PinDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Pausa3DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DestinoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ConfiguracionLlamadasBindingSource1 As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IvrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Pausa1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Opcion1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Pausa2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Pausa3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DestinoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConfiguracionLlamadasTableAdapter As RegistrosTableAdapters.ConfiguracionLlamadasTableAdapter
    Friend WithEvents TableAdapterManager As RegistrosTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEspera As TextBox
    Friend WithEvents btnAgregar As Button
End Class
