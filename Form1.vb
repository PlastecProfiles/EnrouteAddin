Public Class Form1
    Dim Enr As EnRoute3.EnrouteApp
    Dim doc As EnRoute3.IerDrawing
    Dim layer As EnRoute3.IerLayer
    Dim selec As EnRoute3.IerSelection
    Dim strategy As EnRoute3.IerStrategy
    Dim group As EnRoute3.IerGroup
    Dim segment As EnRoute3.IerSegments
    Dim seg As EnRoute3.IerSeg
    Dim members As EnRoute3.IerMembers
    Dim member As EnRoute3.IerMember
    Dim contour As EnRoute3.IerContour
    Dim arc As EnRoute3.IerArcSeg
    Dim bez As EnRoute3.IerBezSeg
    Dim lin As EnRoute3.IerLineSeg
    Dim rbez As EnRoute3.IerRBezSeg
    Dim err As EnRoute3.EErrorCode
    Dim nest As EnRoute3.ENestOptions
    Dim ID As Long
    Dim angle As Double
    Dim startx As Double
    Dim starty As Double
    Dim startz As Double
    Dim centerx As Double
    Dim centery As Double
    Dim centerz As Double
    Dim c1x As Double
    Dim b1x As Double

    Dim c1y As Double
    Dim c1z As Double
    Dim c2x As Double
    Dim c2y As Double
    Dim c2z As Double
    Dim w0 As Double
    Dim w1 As Double
    Dim w2 As Double
    Dim w3 As Double
    Dim totalArea As Double
    Dim bit As Decimal
    Private Sub Move_to_Click(sender As Object, e As EventArgs) Handles Move_to.Click

        Enr = New EnRoute3.EnrouteApp
        doc = Enr.ActiveDrawing
        totalArea = 0.0

        If doc Is Nothing Then
            MsgBox("No Active File")
            End
        End If
        layer = doc.ActiveLayer
        selec = doc.Selection

        If selec.Count = 0 Then
            MsgBox("Select an object")
        End If
        c1x = selec.MaxX
        c1y = selec.MaxY
        bit = NumericUpDown1.Value


    End Sub

    Private Sub Move_x_Click(sender As Object, e As EventArgs) Handles Move_x.Click

        Enr = New EnRoute3.EnrouteApp
        doc = Enr.ActiveDrawing
        totalArea = 0.0

        If doc Is Nothing Then
            MsgBox("No Active File")
            End
        End If
        layer = doc.ActiveLayer
        selec = doc.Selection

        If selec.Count = 0 Then
            MsgBox("Select an object")
        End If
        Dim xxx = CDec(c1x)

        Dim c2y = selec.MinY
        xxx = xxx - bit + 0.0001
        selec.MoveToTarget(xxx, c2y, 0, 0, 0, 0)
    End Sub

    Private Sub Move_y_Click(sender As Object, e As EventArgs) Handles Move_y.Click

        Enr = New EnRoute3.EnrouteApp
        doc = Enr.ActiveDrawing
        totalArea = 0.0

        If doc Is Nothing Then
            MsgBox("No Active File")
            End
        End If
        layer = doc.ActiveLayer
        selec = doc.Selection

        If selec.Count = 0 Then
            MsgBox("Select an object")
        End If
        Dim yyy = CDec(c1y)
        Dim c2x = selec.MinX
        yyy = yyy - bit + 0.0001
        selec.MoveToTarget(c2x, yyy, 0, 0, 0, 0)
    End Sub

    Private Sub Count_Click(sender As Object, e As EventArgs) Handles Count.Click

        Enr = New EnRoute3.EnrouteApp
        doc = Enr.ActiveDrawing
        totalArea = 0.0

        If doc Is Nothing Then
            MsgBox("No Active File")
            End
        End If
        layer = doc.ActiveLayer
        selec = doc.Selection

        If selec.Count = 0 Then
            MsgBox("Select an object")
        End If
        MsgBox(selec.Count)
    End Sub

    Private Sub Edit_Start_Click(sender As Object, e As EventArgs) Handles Edit_Start.Click
        ProgressBar1.PerformStep()

        Enr = New EnRoute3.EnrouteApp
        doc = Enr.ActiveDrawing
        totalArea = 0.0

        If doc Is Nothing Then
            MsgBox("No Active File")
            End
        End If
        layer = doc.ActiveLayer
        selec = doc.Selection

        If selec.Count = 0 Then
            MsgBox("Select an object")
        End If
        selec.ScaleBy(1, 1, 1)
        doc.ReDraw()
    End Sub



    Private Sub Nest__Click_1(sender As Object, e As EventArgs) Handles Nest_.Click

        Enr = New EnRoute3.EnrouteApp
        doc = Enr.ActiveDrawing
        totalArea = 0.0

        If doc Is Nothing Then
            MsgBox("No Active File")
            End
        End If
        layer = doc.ActiveLayer
        selec = doc.Selection

        If selec.Count = 0 Then
            MsgBox("Select an object")
        End If

        c1x = selec.MaxX - selec.MinX
        c1y = selec.MaxY - selec.MinY
        c2x = 0
        c2y = 0
        Dim a2 = 0
        Dim a1 = c1x * c1y

        If a1 > a2 Then
            selec.RotateXY(1, c1x / 2, c1y / 2)
            c2x = selec.MaxX - selec.MinX
            c2y = selec.MaxY - selec.MinY
            selec.MoveToTarget(c1x, c1y, 0, 0, 0, 0)
            a2 = c2x * c2y
        End If
        If a2 > a1 Then
            selec.RotateXY(-1, c1x / 2, c1y / 2)
            selec.MoveToTarget(c1x, c1y, 0, 0, 0, 0)
        End If
        c1x = selec.MaxX - selec.MinX
        c1y = selec.MaxY - selec.MinY
        selec.SelectNone()
        MsgBox("select another item")


    End Sub



    Private Sub Test_Click(sender As Object, e As EventArgs) Handles Test.Click

        Enr = New EnRoute3.EnrouteApp()
        doc = Enr.ActiveDrawing
        totalArea = 0.0

        If doc Is Nothing Then
            MsgBox("No Active File")
            End
        End If
        layer = doc.ActiveLayer
        selec = doc.Selection

        If selec.Count = 0 Then
            MsgBox("Select an object")
        End If
        ' doc.SaveAs("test")




        'selec.Copy()

        ' doc.CreateLayer("Part 1", 2)
        ' doc.CreateLayer("Part 2", 2)
        ' selec.SelectLayer("Part 1")
        'selec.Paste()
        'selec.SelectLayer("Part2")
        ' selec.Paste()





        group = layer.CreateGroup
        ' group.Clone()
        ' contour = group.CreateContour
        'contour.c
        group.CreateText(FontName:="Arial", FontStyle:=1, Height:=1, TheText:="This creates text")
        'seg = contour.Segments
        ' segment = contour.Segments
        ' Dim yyy = arc.CenterX

        ' MsgBox(yyy)
    End Sub


End Class