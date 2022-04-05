Imports System.Data.SQLite

Public Class AddActivity
    Dim dbName As String = "ToDo.db"
    Dim dbpath As String = Application.StartupPath & "\" & dbName
    Dim connStr As String = "Data Source=" & dbName & ";Version=3;"


    Dim SQLiteConn As New SQLiteConnection(connStr)



    Sub SaveBTN_Click(sender As Object, e As EventArgs) Handles SaveBTN.Click
        If (ActivityNameTXT.Text <> "") Then
            'open db
            SQLiteConn.Open()
            If SQLiteConn.State = ConnectionState.Open Then

                Dim Command As String = "INSERT into Activity (ActivityName,Activity_User) VALUES(@ActivityName,@Activity_User);"
                Dim SQLitecmd As New SQLiteCommand(Command, SQLiteConn)
                SQLitecmd.Parameters.AddWithValue("@ActivityName", ActivityNameTXT.Text)
                SQLitecmd.Parameters.AddWithValue("@Activity_User", AccUserNameLBL.Text)

                SQLitecmd.ExecuteNonQuery()

                MsgBox("Your Task has been created.")
                Task.TaskTitileLBL.Text = ActivityNameTXT.Text
                Task.AccUsernameLBL.Text = AccUserNameLBL.Text
                Me.Close()
                Task.Show()


            Else
                MsgBox("Similar Activity stored")
                ActivityNameTXT.Text = ""

            End If

            SQLiteConn.Close()
        Else
            MsgBox("Fill the details in the form")
            ActivityNameTXT.Text = ""

        End If
    End Sub

    Private Sub CancelBTN_Click(sender As Object, e As EventArgs) Handles CancelBTN.Click
        Form1.AccUsernameTxt.Text = AccUserNameLBL.Text
        Form1.Show()
        Me.Close()
    End Sub
End Class