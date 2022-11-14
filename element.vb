Public Class element
    Property id As Guid
    Property name As String
    Property type As Integer
    Property description As String
    Property location As Point
    Property spriteImage As Bitmap

    Enum side As Short
        top = 0
        right = 1
        bottom = 2
        left = 3
    End Enum

    Enum dType As Integer
        none = 0
        instrument = 1
        valve = 2
        pump = 3
        tank = 4
        sensor = 5
        controller = 6
        actuator = 7
        filter = 8
        converter = 9
    End Enum

    Enum pType As Integer
        undefined = 0
        process = 1
        instrumentSupply = 2
        waveguide = 3
        pneumoCont = 4
        pneumoDisc = 5
        capillaryTube = 6
        hydraulic = 7
        electroCont = 8
        electroDisc = 9
        dataLinkInt = 10
        dataLinkExt = 11
        mechanical = 12
        radioLink = 13
        waveLink = 14
    End Enum

    Structure delta
        Dim fromStart As Point
        Dim fromEnd As Point
    End Structure

    Public Sub loadSprite(spriteSheet As Bitmap, spriteSize As Size, spriteLocation As Point)
        Dim buffer As Graphics = Graphics.FromImage(spriteSheet)

        buffer.DrawImage(spriteImage, 0, 0,
                         New Rectangle(spriteLocation, spriteSize),
                         GraphicsUnit.Pixel)
    End Sub

End Class
