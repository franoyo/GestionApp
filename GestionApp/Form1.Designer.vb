<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ToolStrip1 = New ToolStrip()
        ToolStripSplitButton1 = New ToolStripSplitButton()
        ToolStripSplitButton2 = New ToolStripSplitButton()
        REGISTRARSEToolStripMenuItem = New ToolStripMenuItem()
        INICIARSESIONToolStripMenuItem = New ToolStripMenuItem()
        PanelRegister = New Panel()
        Xregist = New Button()
        BtnRegist = New Button()
        Label4 = New Label()
        TxtConfirmarContraseña = New TextBox()
        Label5 = New Label()
        TxtContraseña = New TextBox()
        Label3 = New Label()
        TxtEmail = New TextBox()
        Label2 = New Label()
        TxtNombreCompleto = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Xsesion = New Button()
        BtnLogin = New Button()
        TxtLoginContraseña = New TextBox()
        Label8 = New Label()
        TxtLoginEmail = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        Label9 = New Label()
        Label10 = New Label()
        ToolStrip1.SuspendLayout()
        PanelRegister.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripSplitButton1, ToolStripSplitButton2})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(958, 25)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripSplitButton1
        ' 
        ToolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), Image)
        ToolStripSplitButton1.ImageTransparentColor = Color.Magenta
        ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        ToolStripSplitButton1.Size = New Size(58, 22)
        ToolStripSplitButton1.Text = "INICIO"
        ' 
        ' ToolStripSplitButton2
        ' 
        ToolStripSplitButton2.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripSplitButton2.DropDownItems.AddRange(New ToolStripItem() {REGISTRARSEToolStripMenuItem, INICIARSESIONToolStripMenuItem})
        ToolStripSplitButton2.Image = CType(resources.GetObject("ToolStripSplitButton2.Image"), Image)
        ToolStripSplitButton2.ImageTransparentColor = Color.Magenta
        ToolStripSplitButton2.Name = "ToolStripSplitButton2"
        ToolStripSplitButton2.Size = New Size(72, 22)
        ToolStripSplitButton2.Text = "USUARIO"
        ' 
        ' REGISTRARSEToolStripMenuItem
        ' 
        REGISTRARSEToolStripMenuItem.Name = "REGISTRARSEToolStripMenuItem"
        REGISTRARSEToolStripMenuItem.Size = New Size(157, 22)
        REGISTRARSEToolStripMenuItem.Text = "REGISTRARSE"
        ' 
        ' INICIARSESIONToolStripMenuItem
        ' 
        INICIARSESIONToolStripMenuItem.Name = "INICIARSESIONToolStripMenuItem"
        INICIARSESIONToolStripMenuItem.Size = New Size(157, 22)
        INICIARSESIONToolStripMenuItem.Text = "INICIAR SESION"
        ' 
        ' PanelRegister
        ' 
        PanelRegister.BackColor = Color.RoyalBlue
        PanelRegister.Controls.Add(Xregist)
        PanelRegister.Controls.Add(BtnRegist)
        PanelRegister.Controls.Add(Label4)
        PanelRegister.Controls.Add(TxtConfirmarContraseña)
        PanelRegister.Controls.Add(Label5)
        PanelRegister.Controls.Add(TxtContraseña)
        PanelRegister.Controls.Add(Label3)
        PanelRegister.Controls.Add(TxtEmail)
        PanelRegister.Controls.Add(Label2)
        PanelRegister.Controls.Add(TxtNombreCompleto)
        PanelRegister.Controls.Add(Label1)
        PanelRegister.Controls.Add(PictureBox1)
        PanelRegister.Enabled = False
        PanelRegister.Location = New Point(29, 579)
        PanelRegister.Name = "PanelRegister"
        PanelRegister.Size = New Size(550, 459)
        PanelRegister.TabIndex = 1
        PanelRegister.Visible = False
        ' 
        ' Xregist
        ' 
        Xregist.BackColor = Color.DarkCyan
        Xregist.Location = New Point(498, 20)
        Xregist.Name = "Xregist"
        Xregist.Size = New Size(31, 32)
        Xregist.TabIndex = 11
        Xregist.Text = "X"
        Xregist.UseVisualStyleBackColor = False
        ' 
        ' BtnRegist
        ' 
        BtnRegist.BackColor = Color.DarkCyan
        BtnRegist.Location = New Point(216, 380)
        BtnRegist.Name = "BtnRegist"
        BtnRegist.Size = New Size(134, 50)
        BtnRegist.TabIndex = 10
        BtnRegist.Text = "REGISTRARSE"
        BtnRegist.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(216, 300)
        Label4.Name = "Label4"
        Label4.Size = New Size(167, 21)
        Label4.TabIndex = 9
        Label4.Text = "Confirmar Contraseña:"
        ' 
        ' TxtConfirmarContraseña
        ' 
        TxtConfirmarContraseña.Location = New Point(216, 335)
        TxtConfirmarContraseña.Name = "TxtConfirmarContraseña"
        TxtConfirmarContraseña.PasswordChar = "*"c
        TxtConfirmarContraseña.Size = New Size(298, 23)
        TxtConfirmarContraseña.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(216, 239)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 21)
        Label5.TabIndex = 7
        Label5.Text = "Contraseña:"
        ' 
        ' TxtContraseña
        ' 
        TxtContraseña.Location = New Point(216, 274)
        TxtContraseña.Name = "TxtContraseña"
        TxtContraseña.PasswordChar = "*"c
        TxtContraseña.Size = New Size(298, 23)
        TxtContraseña.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(216, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 21)
        Label3.TabIndex = 5
        Label3.Text = "Email:"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(216, 213)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(298, 23)
        TxtEmail.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(216, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 21)
        Label2.TabIndex = 3
        Label2.Text = "Nombre completo:"
        ' 
        ' TxtNombreCompleto
        ' 
        TxtNombreCompleto.Location = New Point(216, 152)
        TxtNombreCompleto.Name = "TxtNombreCompleto"
        TxtNombreCompleto.Size = New Size(298, 23)
        TxtNombreCompleto.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(178, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 54)
        Label1.TabIndex = 1
        Label1.Text = "REGISTRO"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 152)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(165, 156)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkBlue
        Panel1.Controls.Add(Xsesion)
        Panel1.Controls.Add(BtnLogin)
        Panel1.Controls.Add(TxtLoginContraseña)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(TxtLoginEmail)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Enabled = False
        Panel1.Location = New Point(324, 142)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(328, 369)
        Panel1.TabIndex = 2
        Panel1.Visible = False
        ' 
        ' Xsesion
        ' 
        Xsesion.BackColor = Color.DarkCyan
        Xsesion.Location = New Point(286, 3)
        Xsesion.Name = "Xsesion"
        Xsesion.Size = New Size(31, 32)
        Xsesion.TabIndex = 8
        Xsesion.Text = "X"
        Xsesion.UseVisualStyleBackColor = False
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.DarkCyan
        BtnLogin.Location = New Point(96, 275)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(141, 49)
        BtnLogin.TabIndex = 7
        BtnLogin.Text = "LOGIN"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' TxtLoginContraseña
        ' 
        TxtLoginContraseña.Location = New Point(29, 188)
        TxtLoginContraseña.Name = "TxtLoginContraseña"
        TxtLoginContraseña.PasswordChar = "*"c
        TxtLoginContraseña.Size = New Size(271, 23)
        TxtLoginContraseña.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(96, 157)
        Label8.Name = "Label8"
        Label8.Size = New Size(141, 28)
        Label8.TabIndex = 5
        Label8.Text = "CONTRASEÑA:"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TxtLoginEmail
        ' 
        TxtLoginEmail.Location = New Point(34, 111)
        TxtLoginEmail.Name = "TxtLoginEmail"
        TxtLoginEmail.Size = New Size(271, 23)
        TxtLoginEmail.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(131, 80)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 28)
        Label7.TabIndex = 3
        Label7.Text = "EMAIL:"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(52, 13)
        Label6.Name = "Label6"
        Label6.Size = New Size(228, 41)
        Label6.TabIndex = 2
        Label6.Text = "INICIAR SESION"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(371, 93)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(240, 231)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 39F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(180, 327)
        Label9.Name = "Label9"
        Label9.Size = New Size(616, 70)
        Label9.TabIndex = 4
        Label9.Text = "MANAGEMENT ASCEDED"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(189, 553)
        Label10.Name = "Label10"
        Label10.Size = New Size(582, 32)
        Label10.TabIndex = 5
        Label10.Text = "La mejor aplicacion para el manejo de tus empleados"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(44), CByte(39), CByte(35))
        ClientSize = New Size(958, 596)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Controls.Add(PanelRegister)
        Controls.Add(ToolStrip1)
        Name = "Form1"
        Text = "Form1"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        PanelRegister.ResumeLayout(False)
        PanelRegister.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents ToolStripSplitButton2 As ToolStripSplitButton
    Friend WithEvents REGISTRARSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INICIARSESIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelRegister As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombreCompleto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtConfirmarContraseña As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents BtnRegist As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtLoginContraseña As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtLoginEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Xsesion As Button
    Friend WithEvents Xregist As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label

End Class
