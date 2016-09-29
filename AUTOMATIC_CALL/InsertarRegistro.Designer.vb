<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InsertarRegistro
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
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtP1 = New System.Windows.Forms.TextBox()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.txtP3 = New System.Windows.Forms.TextBox()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.txtIvr = New System.Windows.Forms.TextBox()
        Me.txtP2 = New System.Windows.Forms.TextBox()
        Me.txtOp1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGAgregar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(24, 44)
        Me.txtId.Multiline = True
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(30, 30)
        Me.txtId.TabIndex = 1
        '
        'txtP1
        '
        Me.txtP1.Location = New System.Drawing.Point(166, 44)
        Me.txtP1.Multiline = True
        Me.txtP1.Name = "txtP1"
        Me.txtP1.Size = New System.Drawing.Size(51, 30)
        Me.txtP1.TabIndex = 3
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(553, 44)
        Me.txtDestino.Multiline = True
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(100, 30)
        Me.txtDestino.TabIndex = 9
        '
        'txtP3
        '
        Me.txtP3.Location = New System.Drawing.Point(495, 44)
        Me.txtP3.Multiline = True
        Me.txtP3.Name = "txtP3"
        Me.txtP3.Size = New System.Drawing.Size(52, 30)
        Me.txtP3.TabIndex = 7
        '
        'txtPin
        '
        Me.txtPin.Location = New System.Drawing.Point(389, 44)
        Me.txtPin.Multiline = True
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(100, 30)
        Me.txtPin.TabIndex = 6
        '
        'txtIvr
        '
        Me.txtIvr.Location = New System.Drawing.Point(60, 44)
        Me.txtIvr.Multiline = True
        Me.txtIvr.Name = "txtIvr"
        Me.txtIvr.Size = New System.Drawing.Size(100, 30)
        Me.txtIvr.TabIndex = 2
        '
        'txtP2
        '
        Me.txtP2.Location = New System.Drawing.Point(329, 44)
        Me.txtP2.Multiline = True
        Me.txtP2.Name = "txtP2"
        Me.txtP2.Size = New System.Drawing.Size(54, 30)
        Me.txtP2.TabIndex = 5
        '
        'txtOp1
        '
        Me.txtOp1.Location = New System.Drawing.Point(223, 44)
        Me.txtOp1.Multiline = True
        Me.txtOp1.Name = "txtOp1"
        Me.txtOp1.Size = New System.Drawing.Size(100, 30)
        Me.txtOp1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Id. "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(550, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Destino"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(163, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Pausa 1."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(386, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Pin o Código."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(492, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Pausa 3."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(220, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Opción 1."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(326, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Pausa 2."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Ivr."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.btnGAgregar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtOp1)
        Me.GroupBox1.Controls.Add(Me.txtP2)
        Me.GroupBox1.Controls.Add(Me.txtIvr)
        Me.GroupBox1.Controls.Add(Me.txtPin)
        Me.GroupBox1.Controls.Add(Me.txtP3)
        Me.GroupBox1.Controls.Add(Me.txtDestino)
        Me.GroupBox1.Controls.Add(Me.txtP1)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(679, 221)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Registro"
        '
        'btnGAgregar
        '
        Me.btnGAgregar.BackColor = System.Drawing.Color.Red
        Me.btnGAgregar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGAgregar.Location = New System.Drawing.Point(313, 147)
        Me.btnGAgregar.Name = "btnGAgregar"
        Me.btnGAgregar.Size = New System.Drawing.Size(176, 30)
        Me.btnGAgregar.TabIndex = 11
        Me.btnGAgregar.Text = "Guardar y Agregar"
        Me.btnGAgregar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Red
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGuardar.Location = New System.Drawing.Point(192, 147)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(115, 30)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(198, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(258, 26)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "El tiempo de llamada es especificado en el formulario " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "general de manera global " &
    "para todos los registros."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'InsertarRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 238)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "InsertarRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InsertarRegistro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtP1 As TextBox
    Friend WithEvents txtDestino As TextBox
    Friend WithEvents txtP3 As TextBox
    Friend WithEvents txtPin As TextBox
    Friend WithEvents txtIvr As TextBox
    Friend WithEvents txtP2 As TextBox
    Friend WithEvents txtOp1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnGAgregar As Button
    Friend WithEvents btnGuardar As Button
End Class
