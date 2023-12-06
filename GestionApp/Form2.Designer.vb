<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        TxtNombre = New TextBox()
        Label3 = New Label()
        TxtEmail = New TextBox()
        Label4 = New Label()
        TxtCargo = New TextBox()
        Label5 = New Label()
        TxtFecha = New TextBox()
        Label6 = New Label()
        TxtSueldo = New TextBox()
        Label7 = New Label()
        TxtDocumento = New TextBox()
        Label8 = New Label()
        BtnIngresar = New Button()
        BtnEdit = New Button()
        BtnKill = New Button()
        DataGridViewEmpleados = New DataGridView()
        BtnLogout = New Button()
        TxtId = New TextBox()
        Button1 = New Button()
        CType(DataGridViewEmpleados, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(58, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(241, 37)
        Label1.TabIndex = 0
        Label1.Text = "Gestion Empleado:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nombre Completo:"
        ' 
        ' TxtNombre
        ' 
        TxtNombre.Location = New Point(145, 115)
        TxtNombre.Name = "TxtNombre"
        TxtNombre.Size = New Size(200, 23)
        TxtNombre.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 1
        Label3.Text = "Email:"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(145, 172)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(200, 23)
        TxtEmail.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 231)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 1
        Label4.Text = "Cargo:"
        ' 
        ' TxtCargo
        ' 
        TxtCargo.Location = New Point(145, 232)
        TxtCargo.Name = "TxtCargo"
        TxtCargo.Size = New Size(200, 23)
        TxtCargo.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(12, 295)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 20)
        Label5.TabIndex = 1
        Label5.Text = "Fecha Ingreso:"
        ' 
        ' TxtFecha
        ' 
        TxtFecha.Location = New Point(145, 296)
        TxtFecha.Name = "TxtFecha"
        TxtFecha.Size = New Size(200, 23)
        TxtFecha.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(12, 359)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 20)
        Label6.TabIndex = 1
        Label6.Text = "Sueldo:"
        ' 
        ' TxtSueldo
        ' 
        TxtSueldo.Location = New Point(145, 360)
        TxtSueldo.Name = "TxtSueldo"
        TxtSueldo.Size = New Size(200, 23)
        TxtSueldo.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(12, 431)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 20)
        Label7.TabIndex = 1
        Label7.Text = "Documento:"
        ' 
        ' TxtDocumento
        ' 
        TxtDocumento.Location = New Point(145, 432)
        TxtDocumento.Name = "TxtDocumento"
        TxtDocumento.Size = New Size(200, 23)
        TxtDocumento.TabIndex = 2
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(162, 322)
        Label8.Name = "Label8"
        Label8.Size = New Size(156, 20)
        Label8.TabIndex = 3
        Label8.Text = "Formato: yyyy-mm-dd"
        ' 
        ' BtnIngresar
        ' 
        BtnIngresar.Location = New Point(91, 480)
        BtnIngresar.Name = "BtnIngresar"
        BtnIngresar.Size = New Size(193, 41)
        BtnIngresar.TabIndex = 4
        BtnIngresar.Text = "INGRESAR"
        BtnIngresar.UseVisualStyleBackColor = True
        ' 
        ' BtnEdit
        ' 
        BtnEdit.Location = New Point(91, 543)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(193, 41)
        BtnEdit.TabIndex = 5
        BtnEdit.Text = "MODIFICAR"
        BtnEdit.UseVisualStyleBackColor = True
        ' 
        ' BtnKill
        ' 
        BtnKill.Location = New Point(91, 606)
        BtnKill.Name = "BtnKill"
        BtnKill.Size = New Size(193, 41)
        BtnKill.TabIndex = 6
        BtnKill.Text = "DAR DE BAJA EMPLEADO"
        BtnKill.UseVisualStyleBackColor = True
        ' 
        ' DataGridViewEmpleados
        ' 
        DataGridViewEmpleados.BackgroundColor = Color.LightGray
        DataGridViewEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewEmpleados.Location = New Point(372, 99)
        DataGridViewEmpleados.Name = "DataGridViewEmpleados"
        DataGridViewEmpleados.RowTemplate.Height = 25
        DataGridViewEmpleados.Size = New Size(790, 557)
        DataGridViewEmpleados.TabIndex = 7
        ' 
        ' BtnLogout
        ' 
        BtnLogout.Location = New Point(1034, 39)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(108, 29)
        BtnLogout.TabIndex = 8
        BtnLogout.Text = "Cerrar sesion"
        BtnLogout.UseVisualStyleBackColor = True
        ' 
        ' TxtId
        ' 
        TxtId.Location = New Point(84, 2)
        TxtId.Name = "TxtId"
        TxtId.Size = New Size(200, 23)
        TxtId.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(909, 39)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 29)
        Button1.TabIndex = 10
        Button1.Text = "Nuevo"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(1174, 684)
        Controls.Add(Button1)
        Controls.Add(TxtId)
        Controls.Add(BtnLogout)
        Controls.Add(DataGridViewEmpleados)
        Controls.Add(BtnKill)
        Controls.Add(BtnEdit)
        Controls.Add(BtnIngresar)
        Controls.Add(Label8)
        Controls.Add(TxtDocumento)
        Controls.Add(TxtSueldo)
        Controls.Add(TxtFecha)
        Controls.Add(TxtCargo)
        Controls.Add(TxtEmail)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TxtNombre)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridViewEmpleados, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCargo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSueldo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDocumento As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnKill As Button
    Friend WithEvents DataGridViewEmpleados As DataGridView
    Friend WithEvents BtnLogout As Button
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Button1 As Button
End Class
