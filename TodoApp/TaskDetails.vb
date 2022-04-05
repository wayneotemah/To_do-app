Imports System.Data.SQLite

Public Class TaskDetails
    Dim dbName As String = "ToDo.db"
    Dim dbpath As String = Application.StartupPath & "\" & dbName
    Dim connStr As String = "Data Source=" & dbName & ";Version=3;"


    Dim SQLiteConn As New SQLiteConnection(connStr)
    Dim SQLitecmd As New SQLiteCommand("", SQLiteConn)

    Private Sub TaskDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'open db
            SQLiteConn.Open()
            If SQLiteConn.State = ConnectionState.Open Then
                SQLitecmd.Connection = SQLiteConn
                SQLitecmd.CommandText = "SELECT * FROM Task WHERE User='" & TaskDetailsAccUsername.Text & "' AND Task_Title = '" & TaskDetailTitleLBL.Text & "'  "
                Dim SQLiteReader As SQLiteDataReader = SQLitecmd.ExecuteReader()
                Dim ActivityBTN_Item As New ListViewItem

                Using SQLiteReader

                    While (SQLiteReader.Read())

                        TaskDetailsInfo.Text = SQLiteReader.GetString(2)

                        TaskDetailsDate.Text = SQLiteReader.GetString(3)

                        If SQLiteReader.GetString(4) = "No" Then
                            TaskDetailsStatus.Text = "Not Completed"
                        Else
                            TaskDetailsStatus.Text = "Completed"

                        End If
                    End While

                End Using
            End If
            SQLiteConn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub TaskDetailsBack_Click(sender As Object, e As EventArgs) Handles TaskDetailsBack.Click

        Form1.Show()
        Me.Close()

    End Sub
End Class