<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJacobsonPro
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
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculation = New System.Windows.Forms.Button()
        Me.picItems = New System.Windows.Forms.PictureBox()
        Me.lblSalesAmount = New System.Windows.Forms.Label()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotalDueOutput = New System.Windows.Forms.Label()
        Me.txtSaleAmount = New System.Windows.Forms.TextBox()
        CType(Me.picItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(595, 11)
        Me.lblTotalDue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(70, 17)
        Me.lblTotalDue.TabIndex = 0
        Me.lblTotalDue.Text = "Total Due"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(632, 140)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculation
        '
        Me.btnCalculation.Location = New System.Drawing.Point(501, 140)
        Me.btnCalculation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculation.Name = "btnCalculation"
        Me.btnCalculation.Size = New System.Drawing.Size(100, 28)
        Me.btnCalculation.TabIndex = 2
        Me.btnCalculation.Text = "Calculation"
        Me.btnCalculation.UseVisualStyleBackColor = True
        '
        'picItems
        '
        Me.picItems.BackgroundImage = Global._9_10_19.My.Resources.Resources.furniture
        Me.picItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picItems.Location = New System.Drawing.Point(16, 11)
        Me.picItems.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picItems.Name = "picItems"
        Me.picItems.Size = New System.Drawing.Size(160, 158)
        Me.picItems.TabIndex = 3
        Me.picItems.TabStop = False
        '
        'lblSalesAmount
        '
        Me.lblSalesAmount.AutoSize = True
        Me.lblSalesAmount.Location = New System.Drawing.Point(224, 11)
        Me.lblSalesAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalesAmount.Name = "lblSalesAmount"
        Me.lblSalesAmount.Size = New System.Drawing.Size(95, 17)
        Me.lblSalesAmount.TabIndex = 5
        Me.lblSalesAmount.Text = "Sales Amount"
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Location = New System.Drawing.Point(420, 11)
        Me.lblSalesTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(70, 17)
        Me.lblSalesTax.TabIndex = 6
        Me.lblSalesTax.Text = "Sales Tax"
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(424, 27)
        Me.lblTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(133, 28)
        Me.lblTax.TabIndex = 7
        Me.lblTax.Text = "7%"
        '
        'lblTotalDueOutput
        '
        Me.lblTotalDueOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDueOutput.Location = New System.Drawing.Point(599, 28)
        Me.lblTotalDueOutput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalDueOutput.Name = "lblTotalDueOutput"
        Me.lblTotalDueOutput.Size = New System.Drawing.Size(133, 28)
        Me.lblTotalDueOutput.TabIndex = 8
        '
        'txtSaleAmount
        '
        Me.txtSaleAmount.Location = New System.Drawing.Point(228, 28)
        Me.txtSaleAmount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSaleAmount.Name = "txtSaleAmount"
        Me.txtSaleAmount.Size = New System.Drawing.Size(132, 22)
        Me.txtSaleAmount.TabIndex = 9
        '
        'frmJacobsonPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 188)
        Me.Controls.Add(Me.txtSaleAmount)
        Me.Controls.Add(Me.lblTotalDueOutput)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSalesTax)
        Me.Controls.Add(Me.lblSalesAmount)
        Me.Controls.Add(Me.picItems)
        Me.Controls.Add(Me.btnCalculation)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTotalDue)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmJacobsonPro"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RightToLeftLayout = True
        Me.Text = "Jacobson Project"
        CType(Me.picItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalDue As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalculation As Button
    Friend WithEvents picItems As PictureBox
    Friend WithEvents lblSalesAmount As Label
    Friend WithEvents lblSalesTax As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotalDueOutput As Label
    Friend WithEvents txtSaleAmount As TextBox
End Class
