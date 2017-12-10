Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim outOne As String
        Dim outTwo As String

        outOne = ""
        outTwo = ""

        Try
            outOne = My.Computer.FileSystem.ReadAllText("InterestedMovies.txt")
        Catch ex As Exception
            MessageBox.Show("InterestedMovies.txt was unable to be located", "File Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            outTwo = My.Computer.FileSystem.ReadAllText("WatchedMovies.txt")
        Catch ex As Exception
            MessageBox.Show("WatchedMovies.txt was unable to be located", "File Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        intList.Text = outOne
        wtchList.Text = outTwo
    End Sub

    ' Reloads the Interested List
    Private Sub reloadInterested()
        Dim toPrint As String
        toPrint = My.Computer.FileSystem.ReadAllText("InterestedMovies.txt")
        intList.Text = toPrint
    End Sub

    ' Checks if a movie is contained in the Interested List
    ' return True if movie is in the list, False if movie is not in the list
    Function intContains(movie As String) As Boolean
        Dim current As String
        Dim st As IO.StreamReader
        st = My.Computer.FileSystem.OpenTextFileReader("InterestedMovies.txt")
        Do
            current = st.ReadLine()
            If current.Equals(Nothing) Then
                Return False
            Else
                If current.Equals(movie) Then
                    Return True
                End If
            End If
        Loop
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
