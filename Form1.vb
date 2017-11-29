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
    Dim IDNumber(10000) As Long
    Dim angle(10000) As Double
    Dim startx(10000) As Double
    Dim starty(10000) As Double
    Dim startz(10000) As Double
    Dim centerx(10000) As Double
    Dim centery(10000) As Double
    Dim centerz(10000) As Double
    Dim c1x(10000) As Double
    Dim b1x As Double
    Dim b1y As Double
    Dim c1y(10000) As Double
    Dim c1z(10000) As Double
    Dim c2x(10000) As Double
    Dim c2y(10000) As Double
    Dim c2z(10000) As Double
    Dim dia As Decimal
    Dim w0(10000) As Double
    Dim w1(10000) As Double
    Dim w2(10000) As Double
    Dim w3(10000) As Double
    Dim totalArea As Double
    Dim bit As Decimal
    Dim bit2 As Decimal
    Dim bit3 As Decimal

    'Sub Form1_Load() Handles MyBase.Load
    '   Enr = New EnRoute3.EnrouteApp
    ' doc = Enr.ActiveDrawing
    '  totalArea = 0.0

    'If doc Is Nothing Then
    '       MsgBox("No Active File")
    'End
    'End If
    '   layer = doc.ActiveLayer
    '  selec = doc.Selection
    ' group = layer.CreateGroup
    'If selec.Count = 0 Then
    '       MsgBox("Select an object")
    'End If
    'Dim stratiter = 0
    'While stratiter < Enr.Strategies.Count

    '       ComboBox1.Items.Add(Enr.Strategies.Item(stratiter).StrategyId & Enr.Strategies.Item(stratiter).Name)
    'End While
    'End Sub




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
        Dim bbb = X.Value

        Dim size = 0.0
        While aaa < selec.Count

            ID = selec.Members.Item(aaa).MemberHandle
            group = doc.FindGroup(ID)
            size = group.MaxX - group.MinX
            size = size * 10000
            size = Math.Round(size)
            size = size / 10000


            If size <> bbb Then
                group.UnSelect()
            End If
            If size = bbb Then
                aaa = aaa + 1
            End If
        End While
    End Sub

    '  Private Sub UpdateLog(ByVal funcName As String)
    ' Dim objFile As New System.IO.StreamWriter("\\Server\Customer Files\PlastecAddins\ addinlog.txt", True)
    '    objFile.WriteLine(My.User.Name & " " & Today & " " & funcName)
    '   objFile.Close()
    '  objFile.Dispose()
    'End Sub



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

        contour = group.CreateRect(selec.MinX, selec.MinY, 0, selec.MinX, selec.MaxY - bit + gap.Value, 0)

        contour.RotateXY(-60, selec.MinX, selec.MinY)
        Dim xxx = contour.MaxX
        Dim yyy = contour.MaxY
        Dim zzz = selec.MinZ
        selec.MoveToTarget(xxx, yyy, zzz, 0, 0, 0)


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
        selec.SelectAll()

        If selec.Count = 0 Then
            MsgBox("Select an object")
        End If
        group = layer.CreateGroup

        Dim iii = 0
        Dim ooo = 0
        While iii < selec.Count
            contour = selec.Item(iii).Item(iii)
            iii = iii + 1

            While ooo < contour.SegCount

                seg = contour.Seg(ooo)
                ID = seg.SegID
                MsgBox(ooo)
                If ID = 0 Then
                    lin = seg
                    MsgBox(lin.StartX)
                End If

                If ID = 1 Then
                    arc = seg

                    MsgBox(arc.CenterX)
                End If
                If ID = 2 Then
                    bez = seg

                    MsgBox(bez.Control1X)
                End If
                If ID = 3 Then
                    rbez = seg

                    MsgBox(rbez.Weight1)
                End If
                If ID = 4 Then


                    MsgBox("terminater")
                End If
                ooo = ooo + 1
            End While

        End While






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
        Dim iter1 = 0
        While iter1 < selec.Count

            ID = selec.Members.Item(iter1).MemberHandle
            group = doc.FindGroup(ID)
            Dim xxx = group.MaxX - group.MinX
            Dim yyy = group.MaxY - group.MinY

            Dim ccx = group.MaxX - xxx / 2
            Dim ccy = group.MaxY - yyy / 2
            xxx = xxx / 2
            yyy = yyy / 2
            If xxx < yyy Then
                layer.CreateCircle(ccx, ccy, yyy)
            Else
                layer.CreateCircle(ccx, ccy, xxx)

            End If
            iter1 = iter1 + 1
        End While
        selec.DeleteMembers()


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
        Dim xxx = selec.MinX + NumericUpDown1.Value - gap.Value
        While iterate1 < selec.Count
            ID = selec.Members.Item(iterate1).MemberHandle
            group = doc.FindGroup(ID)
            group.MoveToTarget(xxx - NumericUpDown1.Value + gap.Value, selec.MinY, selec.MinZ, 0, 0, 0)
            xxx = group.MaxX
            iterate1 = iterate1 + 1
        End While
        doc.ReDraw()

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
        Dim yyy = selec.MinY + NumericUpDown1.Value - gap.Value
        While iterate2 < selec.Count
            ID = selec.Members.Item(iterate2).MemberHandle
            group = doc.FindGroup(ID)
            group.MoveToTarget(selec.MinX, yyy - NumericUpDown1.Value + gap.Value, selec.MinZ, 0, 0, 0)
            yyy = group.MaxY
            iterate2 = iterate2 + 1
        End While
        doc.ReDraw()


    End Sub



    Private Sub Nest__Click(sender As Object, e As EventArgs) Handles Nest_.Click
        Enr = New EnRoute3.EnrouteApp()
        doc = Enr.ActiveDrawing
        totalArea = 0.0

        If doc Is Nothing Then
            MsgBox("No Active File")
            End
        End If
        layer = doc.ActiveLayer
        selec = doc.Selection
        selec.SelectAll()

        If selec.Count = 0 Then
            MsgBox("Select an object")
        End If
        group = layer.CreateGroup

        Dim iii = 0
        Dim ooo = 0

        While iii < selec.Count
            contour = selec.Item(iii).Item(iii)
            iii = iii + 1

            While ooo < contour.SegCount

                seg = contour.Seg(ooo)
                ID = seg.SegID
                IDNumber(ooo) = ID
                If ID = 0 Then
                    lin = seg
                    startx(ooo) = lin.StartX
                    starty(ooo) = lin.StartY
                    startz(ooo) = lin.StartZ

                End If

                If ID = 1 Then
                    arc = seg
                    startx(ooo) = arc.StartX
                    starty(ooo) = arc.StartY
                    startz(ooo) = arc.StartZ
                    angle(ooo) = arc.SweepAngle
                    centerx(ooo) = arc.CenterX
                    centery(ooo) = arc.CenterY
                    centerz(ooo) = arc.CenterZ

                End If
                If ID = 2 Then
                    bez = seg
                    startx(ooo) = bez.StartX
                    starty(ooo) = bez.StartY
                    startz(ooo) = bez.StartZ
                    c1x(ooo) = bez.Control1X
                    c1y(ooo) = bez.Control1Y
                    c1z(ooo) = bez.Control1Z
                    c2x(ooo) = bez.Control2X
                    c2y(ooo) = bez.Control2Y
                    c2z(ooo) = bez.Control2Z

                End If
                If ID = 3 Then
                    rbez = seg
                    startx(ooo) = rbez.StartX
                    starty(ooo) = rbez.StartY
                    startz(ooo) = rbez.StartZ
                    c1x(ooo) = rbez.Control1X
                    c1y(ooo) = rbez.Control1Y
                    c1z(ooo) = rbez.Control1Z
                    c2x(ooo) = rbez.Control2X
                    c2y(ooo) = rbez.Control2Y
                    c2z(ooo) = rbez.Control2Z
                    w0(ooo) = rbez.Weight0
                    w1(ooo) = rbez.Weight1
                    w2(ooo) = rbez.Weight2
                    w3(ooo) = rbez.Weight3

                End If
                If ID = 4 Then


                    MsgBox("terminater")
                End If
                ooo = ooo + 1
            End While

        End While


    End Sub








    Private Sub block_Click(sender As Object, e As EventArgs) Handles block.Click
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
        Dim iter1 = 0
        While iter1 < selec.Count

            ID = selec.Members.Item(iter1).MemberHandle
            group = doc.FindGroup(ID)
            layer.CreateRectangle(group.MinX, group.MinY, group.MaxX, group.MaxY)
            iter1 = iter1 + 1
        End While



    End Sub

    Private Sub movex1_Click(sender As Object, e As EventArgs) Handles movex1.Click
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
        Dim xxx = selec.MinX + NumericUpDown1.Value - gap.Value
        While iterate1 < selec.Count
            ID = selec.Members.Item(iterate1).MemberHandle
            group = doc.FindGroup(ID)
            group.MoveToTarget(xxx - NumericUpDown1.Value + gap.Value, group.MinY, group.MinZ, 0, 0, 0)
            xxx = group.MaxX
            iterate1 = iterate1 + 1
        End While
        doc.ReDraw()


    End Sub

    Private Sub movey1_Click(sender As Object, e As EventArgs) Handles movey1.Click
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
        Dim yyy = selec.MinY + NumericUpDown1.Value - gap.Value
        While iterate2 < selec.Count
            ID = selec.Members.Item(iterate2).MemberHandle
            group = doc.FindGroup(ID)
            group.MoveToTarget(group.MinX, yyy - NumericUpDown1.Value + gap.Value, group.MinZ, 0, 0, 0)
            yyy = group.MaxY
            iterate2 = iterate2 + 1
        End While
        doc.ReDraw()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        Dim iter1 = 0
        While iter1 < selec.Count

            ID = selec.Members.Item(iter1).MemberHandle
            group = doc.FindGroup(ID)
            Dim xxx = hole.Value


            Dim ccx = group.MaxX - group.MinX
            Dim ccy = group.MaxY - group.MinY
            ccx = ccx / 2
            ccy = ccy / 2
            xxx = xxx / 2



            layer.CreateCircle(group.MinX + ccx, group.MinY + ccy, xxx)
            iter1 = iter1 + 1


        End While
        selec.DeleteMembers()

    End Sub

    Private Sub cmdown_Click(sender As Object, e As EventArgs) Handles cmdown.Click

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

        contour = group.CreateRect(selec.MinX, selec.MinY, 0, selec.MinX, selec.MaxY - bit + gap.Value, 0)

        contour.RotateXY(-120, selec.MinX, selec.MinY)
        Dim xxx = contour.MaxX
        Dim yyy = contour.MinY
        Dim zzz = selec.MinZ

        selec.MoveToTarget(xxx, yyy, zzz, 0, 0, 0)



    End Sub


End Class