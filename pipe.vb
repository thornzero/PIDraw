Option Explicit On
Option Strict On

Public Class pipe : Inherits element
    Private Property points As Point()
    Private Property pen As New Pen(Color.Black, 1.0F)

    'initialize pipe object
    Public Sub New(startPoint As Point, endPoint As Point, type As Integer)
        Me.points = Array.Empty(Of Point)
        Me.points(0) = startPoint
        Me.points(3) = endPoint
        Me.type = type
    End Sub


    Public Sub New(startPoint As Point, endpoint As Point, type As Integer, color As Color, size As Single)
        Me.points = Array.Empty(Of Point)
        Me.points(0) = startPoint
        Me.points(3) = endpoint
        Me.type = type
        Me.pen = New Pen(color, size)
    End Sub


    ''' <summary>
    '''     Takes a start and an end point and calculates the direction of the vector
    '''     in percent of Tau (0.0τ - 1.0τ)
    ''' </summary>
    ''' <param name="s">Starting point as a Point(x,y)</param>
    ''' <param name="e">Ending point as a Point(x,y)</param>
    ''' <returns>a Double value from 0.0 to 1.0</returns>
    Private Function getDirection(s As Point, e As Point) As Double
        Dim a As Double

        a = Math.Atan2(Convert.ToDouble(e.Y - s.Y), Convert.ToDouble(e.X - s.X))
        a /= Math.Tau

        If a < 0.0R Then a += 1.0R

        Return a

    End Function

    Private Sub updatePoints()
        Dim direction As Double = getDirection(points(0), points(4))
        Dim deltaX As delta
        Dim deltaY As delta

        'calculate the halfway point between the start and end points in the x direction
        deltaX.fromStart = New Point(CInt(points(4).X / 2), points(0).Y)
        deltaX.fromEnd = New Point(CInt(points(4).X / 2), points(4).Y)

        'calculate the halfway point between the start and end points in the y direction
        deltaY.fromStart = New Point(points(0).X, CInt(points(4).Y / 2))
        deltaY.fromEnd = New Point(points(4).X, CInt(points(4).Y / 2))

        'if direction is between 0.0 and 0.125 then start from the top side
        ' octant 0
        If direction > 0.0R And direction <= 0.125R Then
            points(1) = deltaX.fromStart
            points(2) = deltaX.fromEnd
        End If

        'if direction is between 0.125τ and 0.25τ then start from the right side
        ' octant 1
        If direction > 0.125R And direction <= 0.25R Then
            points(1) = deltaY.fromStart
            points(2) = deltaY.fromEnd
        End If

        'if direction is between 0.25τ and 0.375τ then start from the left side
        ' octant 2
        If direction > 0.25R And direction <= 0.375R Then
            points(1) = deltaY.fromStart
            points(2) = deltaY.fromEnd
        End If

        'if direction is between 0.375τ and 0.5τ then start from the bottom side
        ' octant 3
        If direction > 0.375R And direction <= 0.5R Then
            points(1) = deltaX.fromStart
            points(2) = deltaX.fromEnd
        End If

        'if direction is between 0.5τ and 0.625τ then start from the top side
        ' octant 4
        If direction > 0.5R And direction <= 0.625R Then
            points(1) = deltaX.fromStart
            points(2) = deltaX.fromEnd
        End If

        'if direction is between 0.625τ and 0.75τ then start from the right side
        ' octant 5
        If direction > 0.625R And direction <= 0.75R Then
            points(1) = deltaY.fromStart
            points(2) = deltaY.fromEnd
        End If

        'if direction is between 0.75τ and 0.875τ then start from the left side
        ' octant 6
        If direction > 0.75R And direction <= 0.875R Then
            points(1) = deltaY.fromStart
            points(2) = deltaY.fromEnd
        End If

        'if direction is between 0.875τ and 1.0τ then start from the bottom side
        ' octant 7
        If direction > 0.875R And direction <= 1.0R Then
            points(1) = deltaX.fromStart
            points(2) = deltaX.fromEnd
        End If

    End Sub

    Public Sub update()
        updatePoints()
    End Sub

    Public Sub draw(ByRef g As Graphics)
        g.DrawBezier(pen, points(0), points(1), points(2), points(3))

    End Sub
End Class
