<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DGV_Team_Results = New System.Windows.Forms.DataGridView()
        Me.Lbl_Student_Name = New System.Windows.Forms.Label()
        Me.Txt_Student_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_School_Name = New System.Windows.Forms.Label()
        Me.Txt_School_Team = New System.Windows.Forms.TextBox()
        Me.GroupBox_Student_Info = New System.Windows.Forms.GroupBox()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.GroupBox_Team_Results = New System.Windows.Forms.GroupBox()
        Me.Btn_Ranking = New System.Windows.Forms.Button()
        Me.Btn_Reset = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.GroupBox_Data = New System.Windows.Forms.GroupBox()
        Me.Lbl_LP = New System.Windows.Forms.Label()
        Me.Lbl_BW = New System.Windows.Forms.Label()
        Me.Txt_LP = New System.Windows.Forms.TextBox()
        Me.Lbl_Mdr = New System.Windows.Forms.Label()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.Txt_BW = New System.Windows.Forms.TextBox()
        Me.Txt_MDR = New System.Windows.Forms.TextBox()
        Me.Btn_Update2 = New System.Windows.Forms.Button()
        Me.GroupBox_Buttons = New System.Windows.Forms.GroupBox()
        Me.DGV_Team_Rank = New System.Windows.Forms.DataGridView()
        Me.School_Name_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Score_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rank_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox_Final_Rank = New System.Windows.Forms.GroupBox()
        Me.Lst_BW = New System.Windows.Forms.ListBox()
        Me.Btn_Input = New System.Windows.Forms.Button()
        Me.Btn_Max = New System.Windows.Forms.Button()
        Me.Btn_Clear2 = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Button()
        Me.Txt_BDEF = New System.Windows.Forms.TextBox()
        Me.Lbl_BDEF = New System.Windows.Forms.Label()
        Me.Lst_LP = New System.Windows.Forms.ListBox()
        Me.Lst_MDR = New System.Windows.Forms.ListBox()
        Me.Btn_updatee = New System.Windows.Forms.Button()
        Me.School_Team = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BW_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LR_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MDRR_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BDEF_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV_Team_Results, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Student_Info.SuspendLayout()
        Me.GroupBox_Team_Results.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Data.SuspendLayout()
        Me.GroupBox_Buttons.SuspendLayout()
        CType(Me.DGV_Team_Rank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Final_Rank.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1850, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DGV_Team_Results
        '
        Me.DGV_Team_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Team_Results.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.School_Team, Me.BW_1, Me.LR_1, Me.MDRR_1, Me.BDEF_1, Me.Total_1})
        Me.DGV_Team_Results.Location = New System.Drawing.Point(0, 21)
        Me.DGV_Team_Results.Name = "DGV_Team_Results"
        Me.DGV_Team_Results.RowHeadersWidth = 51
        Me.DGV_Team_Results.RowTemplate.Height = 24
        Me.DGV_Team_Results.Size = New System.Drawing.Size(1791, 343)
        Me.DGV_Team_Results.TabIndex = 2
        '
        'Lbl_Student_Name
        '
        Me.Lbl_Student_Name.AutoSize = True
        Me.Lbl_Student_Name.Location = New System.Drawing.Point(23, 44)
        Me.Lbl_Student_Name.Name = "Lbl_Student_Name"
        Me.Lbl_Student_Name.Size = New System.Drawing.Size(110, 17)
        Me.Lbl_Student_Name.TabIndex = 3
        Me.Lbl_Student_Name.Text = "Student Name"
        '
        'Txt_Student_Name
        '
        Me.Txt_Student_Name.Location = New System.Drawing.Point(137, 41)
        Me.Txt_Student_Name.Name = "Txt_Student_Name"
        Me.Txt_Student_Name.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Student_Name.TabIndex = 5
        '
        'Lbl_School_Name
        '
        Me.Lbl_School_Name.AutoSize = True
        Me.Lbl_School_Name.Location = New System.Drawing.Point(23, 82)
        Me.Lbl_School_Name.Name = "Lbl_School_Name"
        Me.Lbl_School_Name.Size = New System.Drawing.Size(114, 17)
        Me.Lbl_School_Name.TabIndex = 3
        Me.Lbl_School_Name.Text = "School (Team)"
        '
        'Txt_School_Team
        '
        Me.Txt_School_Team.Location = New System.Drawing.Point(137, 77)
        Me.Txt_School_Team.Name = "Txt_School_Team"
        Me.Txt_School_Team.Size = New System.Drawing.Size(100, 22)
        Me.Txt_School_Team.TabIndex = 5
        '
        'GroupBox_Student_Info
        '
        Me.GroupBox_Student_Info.Controls.Add(Me.Btn_Add)
        Me.GroupBox_Student_Info.Controls.Add(Me.Lbl_Student_Name)
        Me.GroupBox_Student_Info.Controls.Add(Me.Lbl_School_Name)
        Me.GroupBox_Student_Info.Controls.Add(Me.Txt_Student_Name)
        Me.GroupBox_Student_Info.Controls.Add(Me.Txt_School_Team)
        Me.GroupBox_Student_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Student_Info.Location = New System.Drawing.Point(27, 0)
        Me.GroupBox_Student_Info.Name = "GroupBox_Student_Info"
        Me.GroupBox_Student_Info.Size = New System.Drawing.Size(259, 149)
        Me.GroupBox_Student_Info.TabIndex = 6
        Me.GroupBox_Student_Info.TabStop = False
        Me.GroupBox_Student_Info.Text = "Student Info"
        '
        'Btn_Add
        '
        Me.Btn_Add.Location = New System.Drawing.Point(162, 116)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Add.TabIndex = 6
        Me.Btn_Add.Text = "Add"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'GroupBox_Team_Results
        '
        Me.GroupBox_Team_Results.Controls.Add(Me.DGV_Team_Results)
        Me.GroupBox_Team_Results.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Team_Results.Location = New System.Drawing.Point(27, 513)
        Me.GroupBox_Team_Results.Name = "GroupBox_Team_Results"
        Me.GroupBox_Team_Results.Size = New System.Drawing.Size(1811, 387)
        Me.GroupBox_Team_Results.TabIndex = 7
        Me.GroupBox_Team_Results.TabStop = False
        Me.GroupBox_Team_Results.Text = "Results"
        '
        'Btn_Ranking
        '
        Me.Btn_Ranking.Location = New System.Drawing.Point(19, 21)
        Me.Btn_Ranking.Name = "Btn_Ranking"
        Me.Btn_Ranking.Size = New System.Drawing.Size(100, 30)
        Me.Btn_Ranking.TabIndex = 8
        Me.Btn_Ranking.Text = "Rank"
        Me.Btn_Ranking.UseVisualStyleBackColor = True
        '
        'Btn_Reset
        '
        Me.Btn_Reset.Location = New System.Drawing.Point(153, 21)
        Me.Btn_Reset.Name = "Btn_Reset"
        Me.Btn_Reset.Size = New System.Drawing.Size(100, 30)
        Me.Btn_Reset.TabIndex = 9
        Me.Btn_Reset.Text = "Reset"
        Me.Btn_Reset.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Location = New System.Drawing.Point(407, 21)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(100, 30)
        Me.Btn_Delete.TabIndex = 10
        Me.Btn_Delete.Text = "Delete"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Clear
        '
        Me.Btn_Clear.Location = New System.Drawing.Point(529, 21)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(100, 30)
        Me.Btn_Clear.TabIndex = 11
        Me.Btn_Clear.Text = "Clear"
        Me.Btn_Clear.UseVisualStyleBackColor = True
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Location = New System.Drawing.Point(656, 21)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(100, 30)
        Me.Btn_Exit.TabIndex = 12
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'GroupBox_Data
        '
        Me.GroupBox_Data.Controls.Add(Me.Btn_updatee)
        Me.GroupBox_Data.Controls.Add(Me.Lbl_BDEF)
        Me.GroupBox_Data.Controls.Add(Me.Txt_BDEF)
        Me.GroupBox_Data.Controls.Add(Me.Lbl_LP)
        Me.GroupBox_Data.Controls.Add(Me.Lbl_BW)
        Me.GroupBox_Data.Controls.Add(Me.Txt_LP)
        Me.GroupBox_Data.Controls.Add(Me.Lbl_Mdr)
        Me.GroupBox_Data.Controls.Add(Me.Btn_Update)
        Me.GroupBox_Data.Controls.Add(Me.Txt_BW)
        Me.GroupBox_Data.Controls.Add(Me.Txt_MDR)
        Me.GroupBox_Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Data.Location = New System.Drawing.Point(337, 12)
        Me.GroupBox_Data.Name = "GroupBox_Data"
        Me.GroupBox_Data.Size = New System.Drawing.Size(411, 209)
        Me.GroupBox_Data.TabIndex = 19
        Me.GroupBox_Data.TabStop = False
        Me.GroupBox_Data.Text = "Data"
        '
        'Lbl_LP
        '
        Me.Lbl_LP.AutoSize = True
        Me.Lbl_LP.Location = New System.Drawing.Point(18, 73)
        Me.Lbl_LP.Name = "Lbl_LP"
        Me.Lbl_LP.Size = New System.Drawing.Size(27, 17)
        Me.Lbl_LP.TabIndex = 3
        Me.Lbl_LP.Text = "LP"
        Me.Lbl_LP.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl_BW
        '
        Me.Lbl_BW.AutoSize = True
        Me.Lbl_BW.Location = New System.Drawing.Point(18, 44)
        Me.Lbl_BW.Name = "Lbl_BW"
        Me.Lbl_BW.Size = New System.Drawing.Size(32, 17)
        Me.Lbl_BW.TabIndex = 3
        Me.Lbl_BW.Text = "BW"
        '
        'Txt_LP
        '
        Me.Txt_LP.Location = New System.Drawing.Point(132, 73)
        Me.Txt_LP.Name = "Txt_LP"
        Me.Txt_LP.Size = New System.Drawing.Size(100, 22)
        Me.Txt_LP.TabIndex = 5
        '
        'Lbl_Mdr
        '
        Me.Lbl_Mdr.AutoSize = True
        Me.Lbl_Mdr.Location = New System.Drawing.Point(18, 116)
        Me.Lbl_Mdr.Name = "Lbl_Mdr"
        Me.Lbl_Mdr.Size = New System.Drawing.Size(42, 17)
        Me.Lbl_Mdr.TabIndex = 3
        Me.Lbl_Mdr.Text = "MDR"
        '
        'Btn_Update
        '
        Me.Btn_Update.Location = New System.Drawing.Point(268, 37)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(100, 30)
        Me.Btn_Update.TabIndex = 9
        Me.Btn_Update.Text = "Update"
        Me.Btn_Update.UseVisualStyleBackColor = True
        '
        'Txt_BW
        '
        Me.Txt_BW.Location = New System.Drawing.Point(132, 39)
        Me.Txt_BW.Name = "Txt_BW"
        Me.Txt_BW.Size = New System.Drawing.Size(100, 22)
        Me.Txt_BW.TabIndex = 5
        '
        'Txt_MDR
        '
        Me.Txt_MDR.Location = New System.Drawing.Point(132, 111)
        Me.Txt_MDR.Name = "Txt_MDR"
        Me.Txt_MDR.Size = New System.Drawing.Size(100, 22)
        Me.Txt_MDR.TabIndex = 5
        '
        'Btn_Update2
        '
        Me.Btn_Update2.Location = New System.Drawing.Point(281, 21)
        Me.Btn_Update2.Name = "Btn_Update2"
        Me.Btn_Update2.Size = New System.Drawing.Size(100, 30)
        Me.Btn_Update2.TabIndex = 6
        Me.Btn_Update2.Text = "Update"
        Me.Btn_Update2.UseVisualStyleBackColor = True
        '
        'GroupBox_Buttons
        '
        Me.GroupBox_Buttons.Controls.Add(Me.Btn_Update2)
        Me.GroupBox_Buttons.Controls.Add(Me.Btn_Clear)
        Me.GroupBox_Buttons.Controls.Add(Me.Btn_Ranking)
        Me.GroupBox_Buttons.Controls.Add(Me.Btn_Exit)
        Me.GroupBox_Buttons.Controls.Add(Me.Btn_Reset)
        Me.GroupBox_Buttons.Controls.Add(Me.Btn_Delete)
        Me.GroupBox_Buttons.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Buttons.Location = New System.Drawing.Point(1025, 906)
        Me.GroupBox_Buttons.Name = "GroupBox_Buttons"
        Me.GroupBox_Buttons.Size = New System.Drawing.Size(772, 64)
        Me.GroupBox_Buttons.TabIndex = 20
        Me.GroupBox_Buttons.TabStop = False
        Me.GroupBox_Buttons.Text = "Buttons"
        '
        'DGV_Team_Rank
        '
        Me.DGV_Team_Rank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Team_Rank.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.School_Name_2, Me.Score_2, Me.Rank_2})
        Me.DGV_Team_Rank.Location = New System.Drawing.Point(19, 21)
        Me.DGV_Team_Rank.Name = "DGV_Team_Rank"
        Me.DGV_Team_Rank.RowHeadersWidth = 51
        Me.DGV_Team_Rank.RowTemplate.Height = 24
        Me.DGV_Team_Rank.Size = New System.Drawing.Size(566, 373)
        Me.DGV_Team_Rank.TabIndex = 23
        '
        'School_Name_2
        '
        Me.School_Name_2.HeaderText = "School (Team)"
        Me.School_Name_2.MinimumWidth = 6
        Me.School_Name_2.Name = "School_Name_2"
        Me.School_Name_2.Width = 125
        '
        'Score_2
        '
        Me.Score_2.HeaderText = "Total Score"
        Me.Score_2.MinimumWidth = 6
        Me.Score_2.Name = "Score_2"
        Me.Score_2.Width = 125
        '
        'Rank_2
        '
        Me.Rank_2.HeaderText = "Rank"
        Me.Rank_2.MinimumWidth = 6
        Me.Rank_2.Name = "Rank_2"
        Me.Rank_2.Width = 125
        '
        'GroupBox_Final_Rank
        '
        Me.GroupBox_Final_Rank.Controls.Add(Me.DGV_Team_Rank)
        Me.GroupBox_Final_Rank.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Final_Rank.Location = New System.Drawing.Point(1212, 15)
        Me.GroupBox_Final_Rank.Name = "GroupBox_Final_Rank"
        Me.GroupBox_Final_Rank.Size = New System.Drawing.Size(606, 415)
        Me.GroupBox_Final_Rank.TabIndex = 24
        Me.GroupBox_Final_Rank.TabStop = False
        Me.GroupBox_Final_Rank.Text = "Final Rank"
        '
        'Lst_BW
        '
        Me.Lst_BW.FormattingEnabled = True
        Me.Lst_BW.ItemHeight = 16
        Me.Lst_BW.Location = New System.Drawing.Point(158, 234)
        Me.Lst_BW.Name = "Lst_BW"
        Me.Lst_BW.Size = New System.Drawing.Size(137, 196)
        Me.Lst_BW.TabIndex = 25
        '
        'Btn_Input
        '
        Me.Btn_Input.Location = New System.Drawing.Point(12, 234)
        Me.Btn_Input.Name = "Btn_Input"
        Me.Btn_Input.Size = New System.Drawing.Size(98, 25)
        Me.Btn_Input.TabIndex = 26
        Me.Btn_Input.Text = "Display"
        Me.Btn_Input.UseVisualStyleBackColor = True
        '
        'Btn_Max
        '
        Me.Btn_Max.Location = New System.Drawing.Point(12, 273)
        Me.Btn_Max.Name = "Btn_Max"
        Me.Btn_Max.Size = New System.Drawing.Size(98, 31)
        Me.Btn_Max.TabIndex = 29
        Me.Btn_Max.Text = "Max & Min"
        Me.Btn_Max.UseVisualStyleBackColor = True
        '
        'Btn_Clear2
        '
        Me.Btn_Clear2.Location = New System.Drawing.Point(12, 321)
        Me.Btn_Clear2.Name = "Btn_Clear2"
        Me.Btn_Clear2.Size = New System.Drawing.Size(98, 23)
        Me.Btn_Clear2.TabIndex = 30
        Me.Btn_Clear2.Text = "Clear"
        Me.Btn_Clear2.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(12, 360)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(140, 117)
        Me.lblMessage.TabIndex = 31
        Me.lblMessage.UseVisualStyleBackColor = True
        '
        'Txt_BDEF
        '
        Me.Txt_BDEF.Location = New System.Drawing.Point(132, 145)
        Me.Txt_BDEF.Name = "Txt_BDEF"
        Me.Txt_BDEF.Size = New System.Drawing.Size(100, 22)
        Me.Txt_BDEF.TabIndex = 10
        '
        'Lbl_BDEF
        '
        Me.Lbl_BDEF.AutoSize = True
        Me.Lbl_BDEF.Location = New System.Drawing.Point(18, 150)
        Me.Lbl_BDEF.Name = "Lbl_BDEF"
        Me.Lbl_BDEF.Size = New System.Drawing.Size(48, 17)
        Me.Lbl_BDEF.TabIndex = 11
        Me.Lbl_BDEF.Text = "BDEF"
        '
        'Lst_LP
        '
        Me.Lst_LP.FormattingEnabled = True
        Me.Lst_LP.ItemHeight = 16
        Me.Lst_LP.Location = New System.Drawing.Point(337, 234)
        Me.Lst_LP.Name = "Lst_LP"
        Me.Lst_LP.Size = New System.Drawing.Size(137, 196)
        Me.Lst_LP.TabIndex = 32
        '
        'Lst_MDR
        '
        Me.Lst_MDR.FormattingEnabled = True
        Me.Lst_MDR.ItemHeight = 16
        Me.Lst_MDR.Location = New System.Drawing.Point(516, 234)
        Me.Lst_MDR.Name = "Lst_MDR"
        Me.Lst_MDR.Size = New System.Drawing.Size(137, 196)
        Me.Lst_MDR.TabIndex = 33
        '
        'Btn_updatee
        '
        Me.Btn_updatee.Location = New System.Drawing.Point(268, 73)
        Me.Btn_updatee.Name = "Btn_updatee"
        Me.Btn_updatee.Size = New System.Drawing.Size(100, 23)
        Me.Btn_updatee.TabIndex = 12
        Me.Btn_updatee.Text = "Button1"
        Me.Btn_updatee.UseVisualStyleBackColor = True
        '
        'School_Team
        '
        Me.School_Team.HeaderText = "School (Team)"
        Me.School_Team.MinimumWidth = 6
        Me.School_Team.Name = "School_Team"
        Me.School_Team.Width = 300
        '
        'BW_1
        '
        Me.BW_1.HeaderText = "BWR"
        Me.BW_1.MinimumWidth = 6
        Me.BW_1.Name = "BW_1"
        Me.BW_1.Width = 125
        '
        'LR_1
        '
        Me.LR_1.HeaderText = "LPR"
        Me.LR_1.MinimumWidth = 6
        Me.LR_1.Name = "LR_1"
        Me.LR_1.Width = 125
        '
        'MDRR_1
        '
        Me.MDRR_1.HeaderText = "MDRR"
        Me.MDRR_1.MinimumWidth = 6
        Me.MDRR_1.Name = "MDRR_1"
        Me.MDRR_1.Width = 125
        '
        'BDEF_1
        '
        Me.BDEF_1.HeaderText = "BDEF"
        Me.BDEF_1.MinimumWidth = 6
        Me.BDEF_1.Name = "BDEF_1"
        Me.BDEF_1.Width = 125
        '
        'Total_1
        '
        Me.Total_1.HeaderText = "Total Score"
        Me.Total_1.MinimumWidth = 6
        Me.Total_1.Name = "Total_1"
        Me.Total_1.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1850, 1055)
        Me.Controls.Add(Me.Lst_MDR)
        Me.Controls.Add(Me.Lst_LP)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.Btn_Clear2)
        Me.Controls.Add(Me.Btn_Max)
        Me.Controls.Add(Me.Btn_Input)
        Me.Controls.Add(Me.Lst_BW)
        Me.Controls.Add(Me.GroupBox_Final_Rank)
        Me.Controls.Add(Me.GroupBox_Buttons)
        Me.Controls.Add(Me.GroupBox_Data)
        Me.Controls.Add(Me.GroupBox_Team_Results)
        Me.Controls.Add(Me.GroupBox_Student_Info)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGV_Team_Results, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Student_Info.ResumeLayout(False)
        Me.GroupBox_Student_Info.PerformLayout()
        Me.GroupBox_Team_Results.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Data.ResumeLayout(False)
        Me.GroupBox_Data.PerformLayout()
        Me.GroupBox_Buttons.ResumeLayout(False)
        CType(Me.DGV_Team_Rank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Final_Rank.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DGV_Team_Results As DataGridView
    Friend WithEvents Lbl_Student_Name As Label
    Friend WithEvents Txt_Student_Name As TextBox
    Friend WithEvents Lbl_School_Name As Label
    Friend WithEvents Txt_School_Team As TextBox
    Friend WithEvents GroupBox_Student_Info As GroupBox
    Friend WithEvents GroupBox_Team_Results As GroupBox
    Friend WithEvents Btn_Ranking As Button
    Friend WithEvents Btn_Reset As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Btn_Clear As Button
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents Btn_Add As Button
    Friend WithEvents GroupBox_Data As GroupBox
    Friend WithEvents Lbl_LP As Label
    Friend WithEvents Lbl_BW As Label
    Friend WithEvents Txt_LP As TextBox
    Friend WithEvents Lbl_Mdr As Label
    Friend WithEvents Txt_BW As TextBox
    Friend WithEvents Txt_MDR As TextBox
    Friend WithEvents GroupBox_Buttons As GroupBox
    Friend WithEvents Btn_Update As Button
    Friend WithEvents DGV_Team_Rank As DataGridView
    Friend WithEvents GroupBox_Final_Rank As GroupBox
    Friend WithEvents School_Name_2 As DataGridViewTextBoxColumn
    Friend WithEvents Score_2 As DataGridViewTextBoxColumn
    Friend WithEvents Rank_2 As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Update2 As Button
    Friend WithEvents Lst_BW As ListBox
    Friend WithEvents Btn_Input As Button
    Friend WithEvents Btn_Max As Button
    Friend WithEvents Btn_Clear2 As Button
    Friend WithEvents lblMessage As Button
    Friend WithEvents Lbl_BDEF As Label
    Friend WithEvents Txt_BDEF As TextBox
    Friend WithEvents Lst_LP As ListBox
    Friend WithEvents Lst_MDR As ListBox
    Friend WithEvents Btn_updatee As Button
    Friend WithEvents School_Team As DataGridViewTextBoxColumn
    Friend WithEvents BW_1 As DataGridViewTextBoxColumn
    Friend WithEvents LR_1 As DataGridViewTextBoxColumn
    Friend WithEvents MDRR_1 As DataGridViewTextBoxColumn
    Friend WithEvents BDEF_1 As DataGridViewTextBoxColumn
    Friend WithEvents Total_1 As DataGridViewTextBoxColumn
End Class
