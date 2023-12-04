Imports System.Data.SqlClient
Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms

Module SQLServerConnect
    Public userLogged As String
    Public path = Application.StartupPath & "\Banco\db_pizzaria.mdf"
    Public ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= '" & path & "';Connect Timeout=60"

    Function UseSQL(sql As String) As DataTable
        Dim connection As New SqlConnection
        Dim adapter As SqlDataAdapter
        Dim dt As New DataTable

        connection.ConnectionString = ConnectionString
        connection.Open()

        adapter = New SqlDataAdapter(sql, connection)
        adapter.Fill(dt)

        connection.Close()
        connection = Nothing

        Return dt
    End Function

    Public Sub load_data(table As String, name As String, datagridview As Object)
        Dim SQL As String = "SELECT * FROM " & table & " ORDER BY " & name & " ASC"
        Dim UserData As DataTable = UseSQL(SQL)

        With datagridview
            .Rows.Clear()

            For Each row As DataRow In UserData.Rows
                Dim newRow As New List(Of Object)

                For Each col As DataColumn In UserData.Columns
                    newRow.Add(row(col))
                Next
                .Rows.Add(newRow.ToArray())
            Next
        End With
    End Sub
End Module