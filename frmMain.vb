Public Class frmMain

    Private Const GRID_SPACING As Integer = 20

    ' True while we are drawing the new line.
    Private m_Drawing As Boolean

    ' Buffer for erasing rubberband lines.
    Private bmpBuffer As Bitmap
    Private gfxBuffer As Graphics

    Private bmpFrames(3) As Bitmap

    ' The mouse position.
    Private m_X1 As Integer
    Private m_Y1 As Integer
    Private m_X2 As Integer
    Private m_Y2 As Integer

    Private Sub saveSnapshot()
        Dim new_bitmap As Bitmap

        ' Make a new bitmap that fits the PictureBox.
        new_bitmap = New Bitmap(picCanvas.Size.Width, picCanvas.Size.Height)
        gfxBuffer = Graphics.FromImage(new_bitmap)

        ' Clear the new bitmap.
        gfxBuffer.Clear(picCanvas.BackColor)

        ' Draw the positioning grid.
        drawGrid(new_bitmap)

        ' Copy the existing bitmap's contents into
        ' the new bitmap.
        If bmpBuffer IsNot Nothing Then
            gfxBuffer.DrawImage(bmpBuffer, 0, 0)
        End If

        ' Save the new bitmap and graphics objects.
        bmpBuffer = new_bitmap
    End Sub

    ' Redraw the saved buffer.
    Private Sub drawPicture(ByVal gr As Graphics)
        If Not (bmpBuffer Is Nothing) Then _
        gr.DrawImage(bmpBuffer, 0, 0)
    End Sub

    ' Start drawing a rubberband line.
    Private Sub picCanvas_MouseDown(ByVal sender As Object,
    ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
    picCanvas.MouseDown
        ' Do nothing if this isn'tthe left mouse button.
        If e.Button <> MouseButtons.Left Then Exit Sub
        m_Drawing = True

        ' Save a snapshot of the form.
        saveSnapshot()

        ' Save the current mouse position.
        m_X1 = e.X
        m_Y1 = e.Y
        snapToGrid(m_X1, m_Y1)
        m_X2 = m_X1
        m_Y2 = m_Y1
    End Sub

    ' Continue drawing the rubberband line.
    Private Sub picCanvas_MouseMove(ByVal sender As Object,
    ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
    picCanvas.MouseMove
        ' Do nothing if we're not drawing.
        If Not m_Drawing Then Exit Sub

        ' Save the new point.
        m_X2 = e.X
        m_Y2 = e.Y
        snapToGrid(m_X2, m_Y2)

        ' Erase the previous line.
        Dim gr As Graphics = picCanvas.CreateGraphics()
        drawPicture(gr)

        ' Draw the new line directly on the PictureBox.
        gr.DrawLine(Pens.Gray, m_X1, m_Y1, m_X2, m_Y2)
    End Sub

    ' Finish drawing the new line.
    Private Sub picCanvas_MouseUp(ByVal sender As Object, ByVal _
    e As System.Windows.Forms.MouseEventArgs) Handles _
    picCanvas.MouseUp
        ' Do nothing if we're not drawing.
        If Not m_Drawing Then Exit Sub
        m_Drawing = False

        ' Draw the new line permanently on the buffer.
        gfxBuffer.DrawLine(
        Pens.Blue, m_X1, m_Y1, m_X2, m_Y2)

        ' Redraw to show the new line.
        drawPicture(picCanvas.CreateGraphics())
    End Sub

    ' Snap the point to the grid.
    Private Shared Sub snapToGrid(ByRef X As Integer, ByRef Y As _
    Integer)
        X = GRID_SPACING * CInt(X / GRID_SPACING)
        Y = GRID_SPACING * CInt(Y / GRID_SPACING)
    End Sub

    ' Draw the positioning grid.
    Private Shared Sub drawGrid(ByVal bm As Bitmap)
        For Y As Integer = 0 To bm.Height - 1 Step GRID_SPACING
            For X As Integer = 0 To bm.Width - 1 Step _
            GRID_SPACING
                bm.SetPixel(X, Y, Color.Black)
            Next X
        Next Y
    End Sub

    ' Redraw the picture.
    Private Sub picCanvas_Paint(ByVal sender As Object, ByVal e _
    As System.Windows.Forms.PaintEventArgs) Handles _
    picCanvas.Paint
        drawPicture(e.Graphics)
    End Sub

    ' Make the initial grid.
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As _
    System.EventArgs) Handles MyBase.Load
        saveSnapshot()
    End Sub

    ' Make the new grid.
    Private Sub picCanvas_Resize(ByVal sender As Object, ByVal _
    e As System.EventArgs) Handles picCanvas.Resize
        saveSnapshot()
    End Sub

End Class
