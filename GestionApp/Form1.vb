Imports MySql.Data.MySqlClient
Imports BCrypt

Public Class Form1
    Dim connectionString As String = "Server=localhost;Database=management_plus;User=root;Password=;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Puedes realizar alguna inicialización aquí si es necesario
        CrearTablaAdministradores()
        PanelRegister.BringToFront()
        Panel1.BringToFront()
    End Sub

    Private Sub CrearTablaAdministradores()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Crear la tabla de administradores si no existe
                Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS Administradores (" &
                                                "ID INT AUTO_INCREMENT PRIMARY KEY," &
                                                "NombreCompleto NVARCHAR(100)," &
                                                "Email NVARCHAR(255)," &
                                                "Contraseña NVARCHAR(255));"
                Using createTableCommand As New MySqlCommand(createTableQuery, connection)
                    createTableCommand.ExecuteNonQuery()
                End Using
            End Using


        Catch ex As Exception
            MessageBox.Show("Error al crear la tabla de administradores: " & ex.Message)
        End Try
    End Sub

    Private Sub REGISTRARSEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTRARSEToolStripMenuItem.Click
        PanelRegister.Enabled = True
        PanelRegister.Visible = True
        PanelRegister.Location = New Point(210, 85)
    End Sub

    Private Sub BtnRegist_Click(sender As Object, e As EventArgs) Handles BtnRegist.Click
        Dim nombreCompleto As String = TxtNombreCompleto.Text
        Dim email As String = TxtEmail.Text
        Dim contraseña As String = TxtContraseña.Text
        Dim confirmarContraseña As String = TxtConfirmarContraseña.Text

        If Not String.IsNullOrEmpty(nombreCompleto) AndAlso Not String.IsNullOrEmpty(email) AndAlso Not String.IsNullOrEmpty(contraseña) AndAlso Not String.IsNullOrEmpty(confirmarContraseña) Then
            If contraseña = confirmarContraseña Then
                Try
                    Using connection As New MySqlConnection(connectionString)
                        connection.Open()

                        ' Utilizar BCrypt para cifrar la contraseña
                        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(contraseña
                                                                                      )

                        Dim insertQuery As String = "INSERT INTO Administradores (NombreCompleto, Email, Contraseña) VALUES (@NombreCompleto, @Email, @Contraseña)"
                        Using command As New MySqlCommand(insertQuery, connection)
                            ' Utilizar parámetros para evitar SQL Injection
                            command.Parameters.AddWithValue("@NombreCompleto", nombreCompleto)
                            command.Parameters.AddWithValue("@Email", email)
                            command.Parameters.AddWithValue("@Contraseña", hashedPassword) ' Almacenar el hash en lugar de la contraseña

                            ' Ejecutar la consulta
                            command.ExecuteNonQuery()
                        End Using
                    End Using

                    ' Registro exitoso
                    MessageBox.Show("Administrador registrado exitosamente.")
                Catch ex As Exception
                    ' Manejar la excepción
                    MessageBox.Show("Error al registrar administrador: " & ex.Message)
                End Try
            Else
                ' Contraseñas no coinciden
                MessageBox.Show("Las contraseñas no coinciden. Por favor, asegúrate de que ambas contraseñas sean iguales.")
            End If
        Else
            ' Campos vacíos
            MessageBox.Show("Por favor, complete todos los campos.")
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub INICIARSESIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INICIARSESIONToolStripMenuItem.Click
        Panel1.Visible = True
        Panel1.Enabled = True

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim email As String = TxtLoginEmail.Text
        Dim contraseña As String = TxtLoginContraseña.Text

        If Not String.IsNullOrEmpty(email) AndAlso Not String.IsNullOrEmpty(contraseña) Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    Dim selectQuery As String = "SELECT Contraseña FROM Administradores WHERE Email = @Email"
                    Using command As New MySqlCommand(selectQuery, connection)
                        command.Parameters.AddWithValue("@Email", email)

                        ' Obtener la contraseña almacenada para el usuario
                        Dim hashedPassword As String = Convert.ToString(command.ExecuteScalar())

                        ' Verificar la contraseña ingresada con la almacenada
                        If Not String.IsNullOrEmpty(hashedPassword) AndAlso BCrypt.Net.BCrypt.Verify(contraseña, hashedPassword) Then
                            ' Inicio de sesión exitoso
                            MessageBox.Show("Inicio de sesión exitoso.")
                            Me.Hide()
                            Form2.Show()
                        Else
                            ' Contraseña incorrecta
                            MessageBox.Show("Contraseña incorrecta. Por favor, verifica tus credenciales.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                ' Manejar la excepción
                MessageBox.Show("Error al intentar iniciar sesión: " & ex.Message)
            End Try
        Else
            ' Campos vacíos
            MessageBox.Show("Por favor, ingresa tu correo y contraseña.")
        End If

    End Sub

    Private Sub Xsesion_Click(sender As Object, e As EventArgs) Handles Xsesion.Click
        Panel1.Visible = False
        Panel1.Enabled = False
    End Sub

    Private Sub Xregist_Click(sender As Object, e As EventArgs) Handles Xregist.Click
        PanelRegister.Enabled = False
        PanelRegister.Visible = False
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class
