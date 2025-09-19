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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.cmbBeverage = New System.Windows.Forms.ComboBox()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.chkDiscount = New System.Windows.Forms.CheckBox()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(141, 104)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(138, 150)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(119, 38)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Place Order"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'cmbBeverage
        '
        Me.cmbBeverage.FormattingEnabled = True
        Me.cmbBeverage.Location = New System.Drawing.Point(258, 104)
        Me.cmbBeverage.Name = "cmbBeverage"
        Me.cmbBeverage.Size = New System.Drawing.Size(121, 21)
        Me.cmbBeverage.TabIndex = 2
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(398, 105)
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(120, 20)
        Me.nudQuantity.TabIndex = 3
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(135, 204)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(46, 13)
        Me.lblSubtotal.TabIndex = 4
        Me.lblSubtotal.Text = "Subtotal"
        '
        'chkDiscount
        '
        Me.chkDiscount.AutoSize = True
        Me.chkDiscount.Location = New System.Drawing.Point(211, 194)
        Me.chkDiscount.Name = "chkDiscount"
        Me.chkDiscount.Size = New System.Drawing.Size(133, 17)
        Me.chkDiscount.TabIndex = 5
        Me.chkDiscount.Text = "Apply Loyalty Discount"
        Me.chkDiscount.UseVisualStyleBackColor = True
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(135, 229)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(49, 13)
        Me.lblDiscount.TabIndex = 6
        Me.lblDiscount.Text = "Discount"
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.AutoSize = True
        Me.lblFinalTotal.Location = New System.Drawing.Point(135, 260)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.Size = New System.Drawing.Size(56, 13)
        Me.lblFinalTotal.TabIndex = 7
        Me.lblFinalTotal.Text = "Final Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(270, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Select A Beverage"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Customer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(433, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Quantity"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFinalTotal)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.chkDiscount)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.cmbBeverage)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents cmbBeverage As ComboBox
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents chkDiscount As CheckBox
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblFinalTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
