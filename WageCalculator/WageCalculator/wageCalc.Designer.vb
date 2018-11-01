<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wageCalc
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
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.txtBoxEmployeeID = New System.Windows.Forms.TextBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.txtBoxRole = New System.Windows.Forms.TextBox()
        Me.lblOvertimeHrs = New System.Windows.Forms.Label()
        Me.txtBoxOvertimeHrs = New System.Windows.Forms.TextBox()
        Me.txtBoxTax = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblWageBefore = New System.Windows.Forms.Label()
        Me.txtBoxWageBefore = New System.Windows.Forms.TextBox()
        Me.lblWageAfter = New System.Windows.Forms.Label()
        Me.txtBoxWageAfter = New System.Windows.Forms.TextBox()
        Me.lblWage = New System.Windows.Forms.Label()
        Me.txtBoxWage = New System.Windows.Forms.TextBox()
        Me.lblOvertimePay = New System.Windows.Forms.Label()
        Me.lblNI = New System.Windows.Forms.Label()
        Me.txtBoxNI = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtBoxOvertimePay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.Location = New System.Drawing.Point(13, 13)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(67, 13)
        Me.lblEmployeeID.TabIndex = 0
        Me.lblEmployeeID.Text = "Employee ID"
        '
        'txtBoxEmployeeID
        '
        Me.txtBoxEmployeeID.Location = New System.Drawing.Point(99, 10)
        Me.txtBoxEmployeeID.Name = "txtBoxEmployeeID"
        Me.txtBoxEmployeeID.Size = New System.Drawing.Size(166, 20)
        Me.txtBoxEmployeeID.TabIndex = 1
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(13, 48)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(86, 13)
        Me.lblRole.TabIndex = 2
        Me.lblRole.Text = "Role in company"
        '
        'txtBoxRole
        '
        Me.txtBoxRole.Location = New System.Drawing.Point(99, 45)
        Me.txtBoxRole.Name = "txtBoxRole"
        Me.txtBoxRole.Size = New System.Drawing.Size(166, 20)
        Me.txtBoxRole.TabIndex = 3
        '
        'lblOvertimeHrs
        '
        Me.lblOvertimeHrs.AutoSize = True
        Me.lblOvertimeHrs.Location = New System.Drawing.Point(13, 88)
        Me.lblOvertimeHrs.Name = "lblOvertimeHrs"
        Me.lblOvertimeHrs.Size = New System.Drawing.Size(80, 13)
        Me.lblOvertimeHrs.TabIndex = 4
        Me.lblOvertimeHrs.Text = "Overtime Hours"
        '
        'txtBoxOvertimeHrs
        '
        Me.txtBoxOvertimeHrs.Location = New System.Drawing.Point(99, 85)
        Me.txtBoxOvertimeHrs.Name = "txtBoxOvertimeHrs"
        Me.txtBoxOvertimeHrs.Size = New System.Drawing.Size(166, 20)
        Me.txtBoxOvertimeHrs.TabIndex = 5
        '
        'txtBoxTax
        '
        Me.txtBoxTax.Location = New System.Drawing.Point(102, 128)
        Me.txtBoxTax.Name = "txtBoxTax"
        Me.txtBoxTax.ReadOnly = True
        Me.txtBoxTax.Size = New System.Drawing.Size(55, 20)
        Me.txtBoxTax.TabIndex = 6
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(13, 131)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(83, 13)
        Me.lblTax.TabIndex = 7
        Me.lblTax.Text = "Tax Percentage"
        '
        'lblWageBefore
        '
        Me.lblWageBefore.AutoSize = True
        Me.lblWageBefore.Location = New System.Drawing.Point(13, 183)
        Me.lblWageBefore.Name = "lblWageBefore"
        Me.lblWageBefore.Size = New System.Drawing.Size(125, 13)
        Me.lblWageBefore.TabIndex = 8
        Me.lblWageBefore.Text = "Wage before Tax and NI"
        '
        'txtBoxWageBefore
        '
        Me.txtBoxWageBefore.Location = New System.Drawing.Point(144, 180)
        Me.txtBoxWageBefore.Name = "txtBoxWageBefore"
        Me.txtBoxWageBefore.ReadOnly = True
        Me.txtBoxWageBefore.Size = New System.Drawing.Size(124, 20)
        Me.txtBoxWageBefore.TabIndex = 9
        '
        'lblWageAfter
        '
        Me.lblWageAfter.AutoSize = True
        Me.lblWageAfter.Location = New System.Drawing.Point(13, 218)
        Me.lblWageAfter.Name = "lblWageAfter"
        Me.lblWageAfter.Size = New System.Drawing.Size(116, 13)
        Me.lblWageAfter.TabIndex = 10
        Me.lblWageAfter.Text = "Wage after Tax and NI"
        '
        'txtBoxWageAfter
        '
        Me.txtBoxWageAfter.Location = New System.Drawing.Point(144, 215)
        Me.txtBoxWageAfter.Name = "txtBoxWageAfter"
        Me.txtBoxWageAfter.ReadOnly = True
        Me.txtBoxWageAfter.Size = New System.Drawing.Size(124, 20)
        Me.txtBoxWageAfter.TabIndex = 11
        '
        'lblWage
        '
        Me.lblWage.AutoSize = True
        Me.lblWage.Location = New System.Drawing.Point(297, 48)
        Me.lblWage.Name = "lblWage"
        Me.lblWage.Size = New System.Drawing.Size(68, 13)
        Me.lblWage.TabIndex = 12
        Me.lblWage.Text = "Yearly Wage"
        '
        'txtBoxWage
        '
        Me.txtBoxWage.Location = New System.Drawing.Point(371, 45)
        Me.txtBoxWage.Name = "txtBoxWage"
        Me.txtBoxWage.ReadOnly = True
        Me.txtBoxWage.Size = New System.Drawing.Size(199, 20)
        Me.txtBoxWage.TabIndex = 13
        '
        'lblOvertimePay
        '
        Me.lblOvertimePay.AutoSize = True
        Me.lblOvertimePay.Location = New System.Drawing.Point(297, 88)
        Me.lblOvertimePay.Name = "lblOvertimePay"
        Me.lblOvertimePay.Size = New System.Drawing.Size(70, 13)
        Me.lblOvertimePay.TabIndex = 14
        Me.lblOvertimePay.Text = "Overtime Pay"
        '
        'lblNI
        '
        Me.lblNI.AutoSize = True
        Me.lblNI.Location = New System.Drawing.Point(297, 131)
        Me.lblNI.Name = "lblNI"
        Me.lblNI.Size = New System.Drawing.Size(154, 13)
        Me.lblNI.TabIndex = 16
        Me.lblNI.Text = "National Insurance Percentage"
        '
        'txtBoxNI
        '
        Me.txtBoxNI.Location = New System.Drawing.Point(457, 128)
        Me.txtBoxNI.Name = "txtBoxNI"
        Me.txtBoxNI.Size = New System.Drawing.Size(113, 20)
        Me.txtBoxNI.TabIndex = 17
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(371, 180)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(199, 55)
        Me.btnCalc.TabIndex = 18
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtBoxOvertimePay
        '
        Me.txtBoxOvertimePay.Location = New System.Drawing.Point(371, 85)
        Me.txtBoxOvertimePay.Name = "txtBoxOvertimePay"
        Me.txtBoxOvertimePay.Size = New System.Drawing.Size(199, 20)
        Me.txtBoxOvertimePay.TabIndex = 15
        '
        'wageCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 262)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtBoxNI)
        Me.Controls.Add(Me.lblNI)
        Me.Controls.Add(Me.txtBoxOvertimePay)
        Me.Controls.Add(Me.lblOvertimePay)
        Me.Controls.Add(Me.txtBoxWage)
        Me.Controls.Add(Me.lblWage)
        Me.Controls.Add(Me.txtBoxWageAfter)
        Me.Controls.Add(Me.lblWageAfter)
        Me.Controls.Add(Me.txtBoxWageBefore)
        Me.Controls.Add(Me.lblWageBefore)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.txtBoxTax)
        Me.Controls.Add(Me.txtBoxOvertimeHrs)
        Me.Controls.Add(Me.lblOvertimeHrs)
        Me.Controls.Add(Me.txtBoxRole)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.txtBoxEmployeeID)
        Me.Controls.Add(Me.lblEmployeeID)
        Me.Name = "wageCalc"
        Me.Text = "Wage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmployeeID As System.Windows.Forms.Label
    Friend WithEvents txtBoxEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents txtBoxRole As System.Windows.Forms.TextBox
    Friend WithEvents lblOvertimeHrs As System.Windows.Forms.Label
    Friend WithEvents txtBoxOvertimeHrs As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxTax As System.Windows.Forms.TextBox
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblWageBefore As System.Windows.Forms.Label
    Friend WithEvents txtBoxWageBefore As System.Windows.Forms.TextBox
    Friend WithEvents lblWageAfter As System.Windows.Forms.Label
    Friend WithEvents txtBoxWageAfter As System.Windows.Forms.TextBox
    Friend WithEvents lblWage As System.Windows.Forms.Label
    Friend WithEvents txtBoxWage As System.Windows.Forms.TextBox
    Friend WithEvents lblOvertimePay As System.Windows.Forms.Label
    Friend WithEvents lblNI As System.Windows.Forms.Label
    Friend WithEvents txtBoxNI As System.Windows.Forms.TextBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents txtBoxOvertimePay As System.Windows.Forms.TextBox
End Class
