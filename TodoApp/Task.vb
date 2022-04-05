Imports System.Data.SQLite

Public Class Task

    Dim dbName As String = "ToDo.db"
    Dim dbpath As String = Application.StartupPath & "\" & dbName
    Dim connStr As String = "Data Source=" & dbName & ";Version=3;"


    Dim SQLiteConn As New SQLiteConnection(connStr)

    Private Sub SaveTaskBTN_Click(sender As Object, e As EventArgs) Handles SaveTaskBTN.Click
        'Check if files are populates
        If (TaskTXT.Text <> "" And DetailsTXT.Text <> "" And Task_DateTime.Text <> "") Then
            'open db
            SQLiteConn.Open()
            If SQLiteConn.State = ConnectionState.Open Then

                Dim Command As String = "INSERT into Task(Task_Title,Task_Details,Time,User,Task_Activity) VALUES(@Task_Title,@Task_Details,@Time,@User,@Task_Activity);"
                Dim SQLitecmd As New SQLiteCommand(Command, SQLiteConn)
                SQLitecmd.Parameters.AddWithValue("@Task_Title", TaskTXT.Text)
                SQLitecmd.Parameters.AddWithValue("@Task_Details", DetailsTXT.Text)
                SQLitecmd.Parameters.AddWithValue("@Time", Task_DateTime.Text)
                SQLitecmd.Parameters.AddWithValue("@User", AccUsernameLBL.Text)
                SQLitecmd.Parameters.AddWithValue("@Task_Activity", TaskTitileLBL.Text)

                SQLitecmd.ExecuteNonQuery()

                MsgBox("Your Task has been created.")

                Form1.AccUsernameTxt.Text = AccUsernameLBL.Text
                'Form1.accountLKLB.Text = SQLiteReader("Email")

                Task_DateTime.Text = ""
                DetailsTXT.Text = ""
                Task_DateTime.Text = ""


                Me.Close()
                Form1.Show()

            Else
                MsgBox("Database connection problem")
                Task_DateTime.Text = ""
                DetailsTXT.Text = ""
                Task_DateTime.Text = ""
            End If

            SQLiteConn.Close()
        Else
            MsgBox("Fill all the details in the form")
            Task_DateTime.Text = ""
            DetailsTXT.Text = ""
            Task_DateTime.Text = ""
        End If

    End Sub


    Private Sub CancelTaskBTN_Click(sender As Object, e As EventArgs) Handles CancelTaskBTN.Click
        Form1.AccUsernameTxt.Text = AccUsernameLBL.Text
        Form1.Show()
        Me.Close()
    End Sub
End Class