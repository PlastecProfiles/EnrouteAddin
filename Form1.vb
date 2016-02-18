﻿Public Class Form1
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
    Dim b1y As Double
    Dim c1y As Double
    Dim c1z As Double
    Dim c2x As Double
    Dim c2y As Double
    Dim c2z As Double
    Dim dia As Decimal
    Dim w0 As Double
    Dim w1 As Double
    Dim w2 As Double
    Dim w3 As Double
    Dim totalArea As Double
    Dim bit As Decimal
    Dim bit2 As Decimal
    Dim bit3 As Decimal



    Private Sub Circle_move_Click(sender As Object, e As EventArgs) Handles Circle_move.Click
        Enr = New EnRoute3.EnrouteApp
        doc = Enr.ActiveDrawing
        totalArea = 0.0

        If doc Is Nothing Then
            MsgBox("No Active File")
            End
        End If
        layer = doc.ActiveLayer
        selec = doc.Selection
        group = layer.CreateGroup
        If selec.Count = 0 Then
            MsgBox("Select an object")
        End If

        bit = NumericUpDown1.Value
        Dim ddd = selec.MaxX - selec.MinX
        dia = ddd - bit
        ' Dim bit2 = bit / 2
        selec.Copy()
        contour = group.CreateRect(selec.MinX, selec.MinY, 0, selec.MinX, selec.MaxY - bit + 0.0001, 0)

        contour.RotateXY(-60, selec.MinX, selec.MinY)
        w1 = contour.MaxX
        w2 = contour.MaxY
        selec.Paste()

        selec.MoveToTarget(w1, w2, 0, 0, 0, 0)

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

        Dim iii = 0
        ID = selec.Members.Item(iii).MemberHandle
        group = doc.FindGroup(ID)
        MsgBox(group.MaxX)
        MsgBox(group.MaxY)

    End Sub

    Private Sub Circle_Click(sender As Object, e As EventArgs) Handles Circle.Click
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
        group = layer.CreateGroup
        Dim xxx = selec.MaxX - selec.MinX
        Dim yyy = selec.MaxY - selec.MinY
        Dim ccx = selec.MaxX - xxx / 2
        Dim ccy = selec.MaxY - yyy / 2
        If xxx < yyy Then
            group.CreateCircle(ccx, ccy, 0, yyy / 2)
        Else
            group.CreateCircle(ccx, ccy, 0, xxx / 2)

        End If
        selec.DeleteMembers()
    End Sub

    Private Sub Gapat_Click(sender As Object, e As EventArgs) Handles Gapat.Click
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

        c1x = 0
        c1y = 0
        bit = NumericUpDown1.Value
        ID = selec.Members.Item(0).MemberHandle
        group = doc.FindGroup(ID)
        Dim minx = group.MinX
        Dim maxx = group.MaxX
        Dim miny = group.MinY
        Dim maxy = group.MaxY
        Dim gap = gapsize.Value


        Dim iii = 1



        Dim yyy = 0

        Dim xxx = 0
        While iii < selec.Count
            ID = selec.Members.Item(iii).MemberHandle
            group = doc.FindGroup(ID)
            Dim xxx2 = group.MinX
            Dim yyy2 = group.MinY

            If yyy2 > yyy Then
                yyy = yyy2 + bit - gap
                xxx = minx
            Else

                yyy = miny
            End If

            If xxx2 > xxx Then
                xxx = xxx2 + bit - gap
                yyy = miny
            Else
                xxx = minx

            End If




            bit = NumericUpDown1.Value
            xxx = xxx - bit + gap
            yyy = yyy - bit + gap
            group.MoveToTarget(xxx, yyy, 0, 0, 0, 0)

                xxx = group.MaxX
                yyy = group.MaxY

            maxx = group.MaxX
            minx = group.MinX
            maxy = group.MaxY
            miny = group.MinY
            iii = iii + 1
        End While




    End Sub

    Private Sub selection_Click(sender As Object, e As EventArgs) Handles selection.Click
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
        Dim aaa = 0
        Dim selection = 0
        Dim bbb = NumericUpDown2.Value
        While aaa < selec.Count
            ID = selec.Members.Item(aaa).MemberHandle
            group = doc.FindGroup(ID)
            Dim group2 = 0
            Dim size = group.MaxX - group.MinX
            If size = bbb Then
                group2 = group.Select + group2

            End If
        End While



    End Sub

    Private Sub moveallx_Click(sender As Object, e As EventArgs) Handles moveallx.Click
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
        Dim iterate1 = 0
        Dim xxx = selec.MinX + NumericUpDown1.Value - 0.0001
        While iterate1 < selec.Count
            ID = selec.Members.Item(iterate1).MemberHandle
            group = doc.FindGroup(ID)
            group.MoveToTarget(xxx - NumericUpDown1.Value + 0.0001, selec.MinY, 0, 0, 0, 0)
            xxx = group.MaxX
            iterate1 = iterate1 + 1
        End While

    End Sub

    Private Sub moveally_Click(sender As Object, e As EventArgs) Handles moveally.Click
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
        Dim iterate2 = 0
        Dim yyy = selec.MinY + NumericUpDown1.Value - 0.0001
        While iterate2 < selec.Count
            ID = selec.Members.Item(iterate2).MemberHandle
            group = doc.FindGroup(ID)
            group.MoveToTarget(selec.MinX, yyy - NumericUpDown1.Value + 0.0001, 0, 0, 0, 0)
            yyy = group.MaxY
            iterate2 = iterate2 + 1
        End While
    End Sub
End Class