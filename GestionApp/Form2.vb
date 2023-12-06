Imports System.Globalization
Imports MySql.Data.MySqlClient
Public Class Form2
    Private cmb As MySqlCommandBuilder
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim lista As Byte

    Dim connectionString As String = "Server=localhost;Database=management_plus;User=root;Password=;"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtId.Visible = False
        CrearTablaEmpleados()
        cargarCrud()

    End Sub
    Private Sub cargarCrud()
        datos.Clear()
        Dim consulta As String = "select * from empleados"
        adaptador = New MySqlDataAdapter(consulta, connectionString)
        adaptador.Fill(datos, "empleados")
        DataGridViewEmpleados.DataSource = datos
        DataGridViewEmpleados.DataMember = "empleados"



    End Sub
    Private Sub CrearTablaEmpleados()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Crear la tabla de administradores si no existe
                Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS Empleados (" &
                                 "ID INT AUTO_INCREMENT PRIMARY KEY," &
                                 "NombreCompleto NVARCHAR(100)," &
                                 "Email NVARCHAR(255)," &
                                 "Cargo NVARCHAR(255)," &
                                 "FechaIngreso DATE," &
                                 "Sueldo DECIMAL(10,0)," &
                                 "Documento NVARCHAR(20)," &
                                 "Estado NVARCHAR(20));"
                Using createTableCommand As New MySqlCommand(createTableQuery, connection)
                    createTableCommand.ExecuteNonQuery()
                End Using
            End Using


        Catch ex As Exception
            MessageBox.Show("Error al crear la tabla de Empleado: " & ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim nombreCompleto As String = TxtNombre.Text
        Dim email As String = TxtEmail.Text
        Dim cargo As String = TxtCargo.Text
        Dim fechaIngreso As String = TxtFecha.Text
        Dim sueldo As String = TxtSueldo.Text
        Dim documento As String = TxtDocumento.Text
        Dim estado As String = "Activo"

        ' Validaciones
        If String.IsNullOrWhiteSpace(nombreCompleto) OrElse
           String.IsNullOrWhiteSpace(email) OrElse
           String.IsNullOrWhiteSpace(cargo) OrElse
           String.IsNullOrWhiteSpace(fechaIngreso) OrElse
           String.IsNullOrWhiteSpace(sueldo) OrElse
           String.IsNullOrWhiteSpace(documento) Then
            MessageBox.Show("Todos los campos deben ser completados.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim parsedSueldo As Decimal
        If Not Decimal.TryParse(sueldo, parsedSueldo) Then
            MessageBox.Show("El campo 'Sueldo' debe ser un número válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim parsedFechaIngreso As DateTime
        If Not DateTime.TryParseExact(fechaIngreso, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, parsedFechaIngreso) Then
            MessageBox.Show("El campo 'Fecha de Ingreso' debe tener el formato yyyy-MM-dd.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()


                Dim insertQuery As String = "INSERT INTO Empleados (NombreCompleto, Email, Cargo, FechaIngreso, Sueldo, Documento, Estado) " &
                                            "VALUES (@NombreCompleto, @Email, @Cargo, @FechaIngreso, @Sueldo, @Documento,@Estado)"

                Using command As New MySqlCommand(insertQuery, connection)
                    ' Asignar valores a los parámetros
                    command.Parameters.AddWithValue("@NombreCompleto", nombreCompleto)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Cargo", cargo)
                    command.Parameters.AddWithValue("@FechaIngreso", parsedFechaIngreso.ToString("yyyy-MM-dd"))
                    command.Parameters.AddWithValue("@Sueldo", parsedSueldo)
                    command.Parameters.AddWithValue("@Documento", documento)
                    command.Parameters.AddWithValue("@Estado", estado)


                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Empleado ingresado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cargarCrud()
        Catch ex As Exception
            ' Manejar la excepción
            MessageBox.Show("Error al intentar ingresar empleado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridViewEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewEmpleados.CellClick
        Dim i As Integer = DataGridViewEmpleados.CurrentRow.Index

        TxtId.Text = If(Not IsDBNull(DataGridViewEmpleados(0, i).Value), DataGridViewEmpleados(0, i).Value.ToString(), String.Empty)

        ' Columna 1: Nombre
        TxtNombre.Text = If(Not IsDBNull(DataGridViewEmpleados(1, i).Value), DataGridViewEmpleados(1, i).Value.ToString(), String.Empty)

        ' Columna 2: Email
        TxtEmail.Text = If(Not IsDBNull(DataGridViewEmpleados(2, i).Value), DataGridViewEmpleados(2, i).Value.ToString(), String.Empty)

        ' Columna 3: Cargo
        TxtCargo.Text = If(Not IsDBNull(DataGridViewEmpleados(3, i).Value), DataGridViewEmpleados(3, i).Value.ToString(), String.Empty)

        ' Columna 4: Fecha
        Dim fecha As DateTime
        If DateTime.TryParse(Convert.ToString(DataGridViewEmpleados(4, i).Value), fecha) Then
            TxtFecha.Text = fecha.ToString("yyyy-MM-dd")
        Else
            TxtFecha.Text = String.Empty
        End If

        ' Columna 5: Sueldo
        TxtSueldo.Text = If(Not IsDBNull(DataGridViewEmpleados(5, i).Value), DataGridViewEmpleados(5, i).Value.ToString(), String.Empty)

        ' Columna 6: Documento
        TxtDocumento.Text = If(Not IsDBNull(DataGridViewEmpleados(6, i).Value), DataGridViewEmpleados(6, i).Value.ToString(), String.Empty)

        BtnIngresar.Enabled = False
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        ' Verificar si hay un ID seleccionado
        If String.IsNullOrWhiteSpace(TxtId.Text) Then
            MessageBox.Show("Por favor, selecciona un empleado para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim idEmpleado As Integer = Integer.Parse(TxtId.Text)
        Dim nombreCompleto As String = TxtNombre.Text
        Dim email As String = TxtEmail.Text
        Dim cargo As String = TxtCargo.Text
        Dim fechaIngreso As String = TxtFecha.Text
        Dim sueldo As String = TxtSueldo.Text
        Dim documento As String = TxtDocumento.Text

        ' Validaciones
        If String.IsNullOrWhiteSpace(nombreCompleto) OrElse
           String.IsNullOrWhiteSpace(email) OrElse
           String.IsNullOrWhiteSpace(cargo) OrElse
           String.IsNullOrWhiteSpace(fechaIngreso) OrElse
           String.IsNullOrWhiteSpace(sueldo) OrElse
           String.IsNullOrWhiteSpace(documento) Then
            MessageBox.Show("Todos los campos deben ser completados.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim parsedSueldo As Decimal
        If Not Decimal.TryParse(sueldo, parsedSueldo) Then
            MessageBox.Show("El campo 'Sueldo' debe ser un número válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim parsedFechaIngreso As DateTime
        If Not DateTime.TryParseExact(fechaIngreso, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, parsedFechaIngreso) Then
            MessageBox.Show("El campo 'Fecha de Ingreso' debe tener el formato yyyy-MM-dd.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim updateQuery As String = "UPDATE Empleados SET NombreCompleto = @NombreCompleto, Email = @Email, Cargo = @Cargo, FechaIngreso = @FechaIngreso, Sueldo = @Sueldo, Documento = @Documento WHERE ID = @ID"

                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@ID", idEmpleado)
                    command.Parameters.AddWithValue("@NombreCompleto", nombreCompleto)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Cargo", cargo)
                    command.Parameters.AddWithValue("@FechaIngreso", parsedFechaIngreso.ToString("yyyy-MM-dd"))
                    command.Parameters.AddWithValue("@Sueldo", parsedSueldo)
                    command.Parameters.AddWithValue("@Documento", documento)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Empleado actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cargarCrud()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al intentar actualizar empleado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarCampos()
        ' Limpiar los campos después de editar
        TxtId.Clear()
        TxtNombre.Clear()
        TxtEmail.Clear()
        TxtCargo.Clear()
        TxtFecha.Clear()
        TxtSueldo.Clear()
        TxtDocumento.Clear()

        ' Habilitar el botón de ingresar
        BtnIngresar.Enabled = True
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LimpiarCampos()
        BtnIngresar.Enabled = True
    End Sub

    Private Sub BtnKill_Click(sender As Object, e As EventArgs) Handles BtnKill.Click
        ' Mostrar un cuadro de diálogo de confirmación
        Dim confirmResult As DialogResult = MessageBox.Show("¿Estás seguro de despedir a este empleado?", "Confirmar Despido", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar la respuesta del usuario
        If confirmResult = DialogResult.Yes Then
            ' Usuario hizo clic en 'Sí', proceder con el despido
            Try
                ' Obtener el ID del empleado desde el campo oculto TxtId
                Dim idEmpleado As Integer = If(Integer.TryParse(TxtId.Text, Nothing), Integer.Parse(TxtId.Text), -1)

                If idEmpleado <> -1 Then
                    ' Actualizar el estado del empleado a 'Despedido'
                    Using connection As New MySqlConnection(connectionString)
                        connection.Open()

                        Dim updateQuery As String = "UPDATE Empleados SET Estado = 'Despedido' WHERE ID = @ID"

                        Using command As New MySqlCommand(updateQuery, connection)
                            command.Parameters.AddWithValue("@ID", idEmpleado)
                            command.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Empleado despedido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    cargarCrud()
                    LimpiarCampos()
                End If
            Catch ex As Exception
                MessageBox.Show("Error al intentar despedir al empleado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class