Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim outOne As String
        Dim outTwo As String

        outOne = ""
        outTwo = ""

        Try
            outOne = My.Computer.FileSystem.ReadAllText("C:\Users\srand\Documents\InterestedMovies.txt")
        Catch ex As Exception
            MessageBox.Show("InterestedMovies.txt was unable to be located", "File Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            outTwo = My.Computer.FileSystem.ReadAllText("C:\Users\srand\Documents\WatchedMovies.txt")
        Catch ex As Exception
            MessageBox.Show("WatchedMovies.txt was unable to be located", "File Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        intList.Text = outOne
        wtchList.Text = outTwo
    End Sub

    ' Reloads the Interested List
    Private Sub reloadInterested()
        Dim toPrint As String
        toPrint = My.Computer.FileSystem.ReadAllText("C:\Users\srand\Documents\InterestedMovies.txt")
        intList.Text = toPrint
    End Sub

    ' Checks if a movie is contained in the Interested List
    ' return True if movie is in the list, False if movie is not in the list
    Function intContains(movie As String)
        Return False
    End Function

    ' Decides whether to add movie or not when Add button is pressed
    Private Sub intAdd_Click(sender As Object, e As EventArgs) Handles intAdd.Click
        If (intContains(intText.Text)) Then
            intLabel.Text = intText.Text + " has already been added."
        Else
            My.Computer.FileSystem.WriteAllText("C:\Users\srand\Documents\InterestedMovies.txt", vbCrLf + intText.Text, True)
            reloadInterested()
            intLabel.Text = "Added!"
        End If

    End Sub

    Private Sub intRemove_Click(sender As Object, e As EventArgs) Handles intRemove.Click

    End Sub
End Class
