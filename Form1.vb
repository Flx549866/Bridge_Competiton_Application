Imports System.Data.SqlClient
Imports System.Data

Public Class Form1
    'Dim intMAX_SUBSCRIPT As Integer = InputBox("Enter number of contestants.")
    'Dim intValues(intMAX_SUBSCRIPT) As Integer
    Dim bwArray(3) As Double
    Dim lpArray(3) As Double
    Dim mdrArray(3) As Double
    Dim searchValue As Integer
    Dim searchValue1 As Integer
    Dim searchValue2 As Integer




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Me.WindowState = FormWindowState.Maximized
        searchValue = -1
        searchValue1 = -1
        searchValue2 = -1






    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnApplication_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox_Team_Results.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Team_Results.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox_Student_Info.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Txt_Team_Number_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Txt_LP.TextChanged

    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", "Bridge Competition",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If





    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        Me.DGV_Team_Results.Rows.Clear()
        Me.DGV_Team_Rank.Rows.Clear()
        Me.Txt_BW.Clear()
        Me.Txt_LP.Clear()
        Me.Txt_MDR.Clear()

        Me.Txt_Student_Name.Clear()


    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Dim q As Integer
        If DGV_Team_Results.SelectedRows.Count > 0 Then
            For q = DGV_Team_Results.SelectedRows.Count - 1 To 0 Step -1
                DGV_Team_Results.Rows.RemoveAt(DGV_Team_Results.SelectedRows(q).Index)

            Next
        ElseIf DGV_Team_Rank.SelectedRows.Count > 0 Then
            For i = DGV_Team_Rank.SelectedRows.Count - 1 To 0 Step -1
                DGV_Team_Rank.Rows.RemoveAt(DGV_Team_Rank.SelectedRows(i).Index)
            Next




        Else
            MessageBox.Show("No row selcted")

        End If
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        Dim Number As Integer
        Number = Txt_BW.Text
        If searchValue = 3 Then
            MsgBox("The array is full.", MsgBoxStyle.Information)

            Txt_BW.Text = ""
            Txt_BW.Enabled = False
        Else

            searchValue = searchValue + 1
            bwArray(searchValue) = Number
            Txt_BW.Text = ""
            Txt_BW.Focus()

        End If

        Dim Number1 As Integer
        Number1 = Txt_LP.Text
        If searchValue1 = 3 Then
            MsgBox("The array is full.", MsgBoxStyle.Information)

            Txt_LP.Text = ""
            Txt_LP.Enabled = False
        Else
            searchValue1 = searchValue1 + 1
            lpArray(searchValue1) = Number1
            Txt_LP.Text = ""
            Txt_LP.Focus()

        End If

        Dim Number2 As Integer
        Number2 = Txt_MDR.Text
        If searchValue2 = 3 Then
            MsgBox("The array is full.", MsgBoxStyle.Information)

            Txt_MDR.Text = ""
            Txt_MDR.Enabled = False
        Else
            searchValue2 = searchValue2 + 1
            mdrArray(searchValue2) = Number2
            Txt_MDR.Text = ""
            Txt_MDR.Focus()

        End If



    End Sub

    Private Sub Txt_Load_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btn_Add2_Click(sender As Object, e As EventArgs) Handles Btn_Update2.Click
        'BW calculation
        Dim DBW, BWR, a, b As Double
        Dim Bw, BwMax, BwMin As String, BW1 As Double

        Bw = Txt_BW.Text
        BW1 = CType(Bw, Double)

        BwMax = bwArray.Max
        BwMin = bwArray.Min
        a = CType(BwMax, Double)
        b = CType(BwMin, Double)

        DBW = a - b
        BWR = 1 + ((49 / DBW) * (a - BW1))

        'Lp calculation
        Dim LPR, LPRR, c, d As Double
        Dim Lp, LpMax, LpMin As String, Lp1 As Double

        Lp = Txt_LP.Text
        Lp1 = CType(Lp, Double)

        LpMax = lpArray.Max
        LpMin = lpArray.Min
        c = CType(LpMax, Double)
        d = CType(LpMin, Double)

        LPR = c - d
        LPRR = 1 + ((49 / LPR) * (Lp1 - d))

        'MDR calculation
        Dim MDR1, MDRR, g, f, mdrMax, mdrMIN As Double
        Dim MD As String, M1 As Double
        MD = Txt_MDR.Text
        M1 = CType(MD, Double)
        mdrMax = mdrArray.Max
        mdrMin = mdrArray.Min
        g = CType(mdrMax, Double)
        f = CType(mdrMIN, Double)
        MDR1 = g - f

        MDRR = 1 + ((49 / MDR1) * (g - M1))

        Dim BDEF As String
        Dim BDEF1 As Double
        BDEF = Txt_BDEF.Text
        BDEF1 = CType(BDEF, Double)

        'Total_Score
        Dim Total_Score(3) As Double

        Dim searchValue3 As Integer
        searchValue = -1
        If searchValue3 = 3 Then
            MsgBox("The array is full.", MsgBoxStyle.Information)

        Else
            searchValue3 = searchValue3 + 1
            Total_Score(searchValue3) = BWR + LPRR + MDRR + BDEF
            'Array.Sort(Total_Score)
            DGV_Team_Rank.Rows.Add(Txt_School_Team.Text, Total_Score(searchValue3))


            Txt_MDR.Focus()

        End If
        For AddNext = 0 To searchValue3

            DGV_Team_Rank.Sort(DGV_Team_Rank.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        Next AddNext
        'Array.Sort(Total_Score)
        ' Array.Reverse(Total_Score)


        'Total_Score1 = BWR + LPRR + MDRR + BDEF

        'DGV_Team_Rank.Rows.Add(Txt_School_Team.Text, Total_Score(searchValue3))
        DGV_Team_Results.Rows.Add(Txt_School_Team.Text, BWR, LPRR, MDRR, BDEF1, Total_Score(searchValue3))





    End Sub

    Private Sub Btn_Reset_Click(sender As Object, e As EventArgs) Handles Btn_Reset.Click
        Me.DGV_Team_Rank.Rows.Clear()
        Me.Txt_Student_Name.Clear()
        Me.Txt_School_Team.Clear()
        Me.Txt_BW.Clear()
        Me.Txt_LP.Clear()
        Me.Txt_MDR.Clear()




    End Sub

    Private Sub Txt_School_Team_TextChanged(sender As Object, e As EventArgs) Handles Txt_School_Team.TextChanged

    End Sub

    Private Sub Txt_Rank_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Lbl_Load_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btn_Input_Click(sender As Object, e As EventArgs) Handles Btn_Input.Click
        'BW array
        Dim AddNext As Integer
        Lst_BW.Items.Clear()
        For AddNext = 0 To searchValue
            Lst_BW.Items.Add(bwArray(AddNext))


        Next AddNext
        '  Lst_BW.Sorted = True

        'LP Array

        Lst_LP.Items.Clear()
        For AddNext = 0 To searchValue1
            Lst_LP.Items.Add(lpArray(AddNext))


        Next AddNext
        Lst_LP.Sorted = True

        'MDR Array

        Lst_MDR.Items.Clear()
        For AddNext = 0 To searchValue2
            Dim MDR As Double
            MDR = bwArray(AddNext) / lpArray(AddNext)
            Lst_MDR.Items.Add(mdrArray(AddNext))
        Next AddNext
        'Lst_MDR.Sorted = 



    End Sub

    Private Sub Btn_Max_Click(sender As Object, e As EventArgs) Handles Btn_Max.Click

        'Dim Result1 As Integer = Largest()
        'Dim result2 As Integer = Smallest()

        lblMessage.Text = "Max= " & bwArray.Max & vbCrLf & "Min= " & bwArray.Min & vbCrLf & "Max= " & lpArray.Max & vbCrLf & "Min= " & lpArray.Min & vbCrLf & "Max= " & mdrArray.Max & vbCrLf & "Min= " & mdrArray.Min
        '  lblMessage.Text = "Max= " & lpArray.Max & vbCrLf & "Min= " & lpArray.Min
        'lblMessage.Text = "Max= " & mdrArray.Max & vbCrLf & "Min= " & mdrArray.Min


        'initialize BWR as bridge weight rate
        'Dim BWR as Integer
        'ChangeinBW = bwMAX - bwMIN
        'BWR = 1 + (49/ChangeinBW) * (bwMAX / BW)

        ' *****NEED USER INPUT FOR lpBROKE AND mdrBROKE*****
        ' intialize LP as Load in Pounds amd LPR as Loud Pound Rate
        ' ChangeinLP = lpMAX - lpMIN
        ' LPR = 1 + (49/ChangeinLP) * (lpBROKE - lpMIN)
        'initalizd Model Design Ratio as MDR and Model Design Ratio Rate as MDRR( RANGE IS 1 THROUGH 50)
        'MDR = BW/LP
        'ChangeinMDR = mdrMAX - mdrMIN
        'MDRR = 1 + (49/) * mdrMAX -mdrBROKE
        '
        '



    End Sub



    Private Sub Btn_Clear2_Click(sender As Object, e As EventArgs) Handles Btn_Clear2.Click
        Lst_BW.Items.Clear()
        lblMessage.Text = String.Empty

        Lst_LP.Items.Clear()
        lblMessage.Text = String.Empty

        Lst_MDR.Items.Clear()
        lblMessage.Text = String.Empty
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click

    End Sub

    Private Sub Btn_updatee_Click(sender As Object, e As EventArgs) Handles Btn_updatee.Click

    End Sub
End Class
