Public Class Node
    Public Data As Integer
    Public Left, Right As Node

    Public Sub New(ByVal item As Integer)
        Data = item
        Left = Nothing
        Right = Nothing
    End Sub
End Class
