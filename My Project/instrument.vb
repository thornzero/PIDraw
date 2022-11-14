
class instrument
    public property id as integer
    public property name as string
    public property type as string
    public property description as string
    public property location as Point
    public property sprite as Image
    public property spriteSize as Size
    private property nextId as integer

    private enum side as Short
        top = 0
        right = 1
        bottom = 2
        left = 3
    end enum

    private enum dir as Short
        northEast = 0
        southEast = 1
        southWest = 2
        northWest = 3
    end Enum

    Private Sub connectNext(p0 As Point, p0s As side, p1 As Point)
        Dim p(3) As Point ' 4 points
        Dim direction As dir = ((p0.X > p1.X) << 1) Or (p0.Y > p1.Y)
        Dim dx As Integer = p1.X / 2 'half the distance between the two points in the x direction
        Dim dy As Integer = p1.Y / 2 'half the distance between the two points in the y direction

        'start and end stay the same
        p(0) = p0 'start
        p(3) = p1 'end

        Select Case direction
            Case dir.northEast
                If p0s = side.top Then
                    p(1) = New Point(p0.X, dy)
                    p(2) = New Point(p1.X, dy)
                ElseIf p0s = side.right Then
                    p(1) = New Point(dx, p0.Y)
                    p(2) = New Point(dx, p1.Y)
                Else
                    p = Nothing
                End If

            Case dir.southEast
                If p0s = side.right Then
                    p(1) = New Point(dx, p0.Y)
                    p(2) = New Point(dx, p1.Y)
                ElseIf p0s = side.bottom Then
                    p(1) = New Point(p0.X, dy)
                    p(2) = New Point(p1.X, dy)
                Else
                    p = Nothing
                End If

            Case dir.northWest
                If p0s = side.top Then
                    p(1) = New Point(p0.X, dy)
                    p(2) = New Point(p1.X, dy)
                ElseIf p0s = side.left Then
                    p(1) = New Point(dx, p0.Y)
                    p(2) = New Point(dx, p1.Y)
                Else
                    p = Nothing
                End If

            Case dir.southWest
                If p0s = side.left Then
                    p(1) = New Point(dx, p0.Y)
                    p(2) = New Point(dx, p1.Y)
                ElseIf p0s = side.bottom Then
                    p(1) = New Point(p0.X, dy)
                    p(2) = New Point(p1.X, dy)
                Else
                    p = Nothing
                End If

        End Select

    End Sub
End class