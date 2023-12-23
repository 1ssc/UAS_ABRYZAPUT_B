Imports System.Data.Odbc
Module Module1
    Public conn As New OdbcConnection
    Public da As New OdbcDataAdapter
    Public ds As New DataSet

    Public Sub koneksi()
        conn = New OdbcConnection("dsn=dsn_razkajus")
        ds = New DataSet()
    End Sub
End Module