Public Class ComboBoxItem
    Public id As Long
    Public name As String
    Public Overrides Function ToString() As String
        Return name
    End Function
End Class
