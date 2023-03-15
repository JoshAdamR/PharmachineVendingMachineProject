Imports System.Data.OleDb

Public Class DBController
    ' establish connection
    ' database file may be placed anywhere in computer, just specify file path in "Data Source"
    Private DBConn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" &
                                          "Data Source= Database\Pharmachine.mdb;")

    ' DB SQL Commands
    Private DBCmd As OleDbCommand

    ' DB DataAdapter
    ' DataAdapter executes commands on the DB such as filling DataTables or DataSets
    Private DataAdapter As OleDbDataAdapter
    ' DB DataTable
    Public DataTable As DataTable

    ' SQL Query Parameters; for convenience
    Private Params As New List(Of OleDbParameter)

    ' DB Query status
    Public RecordCount As Integer
    Public Exception As String

    ' universal Sub Procedure for DB SQL Commands
    Public Sub RunQuery(Query As String)
        ' Reset Query Stats after every query
        RecordCount = 0
        Exception = ""

        Try
            ' Open the connection
            DBConn.Open()

            ' create command
            DBCmd = New OleDbCommand(Query, DBConn)

            ' Load all parameters into the command
            For Each p As OleDbParameter In Params
                DBCmd.Parameters.Add(p)
            Next

            ' Clear the list of parameters after adding
            Params.Clear()

            ' create Adapter and Table and run the command through the Adapter
            DataTable = New DataTable
            DataAdapter = New OleDbDataAdapter(DBCmd)

            ' Fill the table through the adapter and track number of records obtained
            RecordCount = DataAdapter.Fill(DataTable)
        Catch ex As Exception
            ' if any exceptions, track exception message
            Exception = ex.Message
        End Try

        ' always close connection after done
        If DBConn.State = ConnectionState.Open Then DBConn.Close()
    End Sub

    ' get all tables in the Db
    Public Function GetTables() As List(Of String)
        Dim listTables As New List(Of String)
        Dim restrictions() As String = New String() {Nothing, Nothing, Nothing, "Table"}

        Try
            DBConn.Open()
            DataTable = DBConn.GetSchema("Tables", restrictions)

            For Each Row As DataRow In DataTable.Rows
                listTables.Add(Row("TABLE_NAME"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "DB Error")
        Finally
            If DBConn.State = ConnectionState.Open Then DBConn.Close()
        End Try

        Return listTables
    End Function

    ' get all columns in the table
    Public Function GetTableCols(tableName As String) As List(Of String)
        Dim listCols As New List(Of String)
        Dim restrictions() As String = New String() {Nothing, Nothing, tableName, Nothing}

        Try
            DBConn.Open()

            DataTable = DBConn.GetSchema("Columns", restrictions)

            For Each Row As DataRow In DataTable.Rows
                listCols.Add(Row("COLUMN_NAME"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "DB Error")
        Finally
            If DBConn.State = ConnectionState.Open Then DBConn.Close()
        End Try

        Return listCols
    End Function

    ' function to add parameters
    Public Sub AddParams(paramName As String, value As Object)
        Dim param As New OleDbParameter(paramName, value)
        Params.Add(param)
    End Sub
End Class
