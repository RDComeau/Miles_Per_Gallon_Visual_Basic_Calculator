<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMilesPerGallon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblGallonsOfGasCarHolds = New System.Windows.Forms.Label()
        Me.lblMilesDrivenFullTank = New System.Windows.Forms.Label()
        Me.lblMpg = New System.Windows.Forms.Label()
        Me.btnCalMpg = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblMpg2 = New System.Windows.Forms.Label()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblGallonsOfGasCarHolds
        '
        Me.lblGallonsOfGasCarHolds.AutoSize = True
        Me.lblGallonsOfGasCarHolds.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallonsOfGasCarHolds.Location = New System.Drawing.Point(1, 20)
        Me.lblGallonsOfGasCarHolds.Name = "lblGallonsOfGasCarHolds"
        Me.lblGallonsOfGasCarHolds.Size = New System.Drawing.Size(260, 22)
        Me.lblGallonsOfGasCarHolds.TabIndex = 0
        Me.lblGallonsOfGasCarHolds.Text = "Gallons of gas the car can hold:"
        '
        'lblMilesDrivenFullTank
        '
        Me.lblMilesDrivenFullTank.AutoSize = True
        Me.lblMilesDrivenFullTank.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilesDrivenFullTank.Location = New System.Drawing.Point(1, 96)
        Me.lblMilesDrivenFullTank.Name = "lblMilesDrivenFullTank"
        Me.lblMilesDrivenFullTank.Size = New System.Drawing.Size(270, 44)
        Me.lblMilesDrivenFullTank.TabIndex = 1
        Me.lblMilesDrivenFullTank.Text = "Number of miles it can be driven" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " on a full tank:"
        '
        'lblMpg
        '
        Me.lblMpg.AutoSize = True
        Me.lblMpg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMpg.Location = New System.Drawing.Point(1, 181)
        Me.lblMpg.Name = "lblMpg"
        Me.lblMpg.Size = New System.Drawing.Size(147, 22)
        Me.lblMpg.TabIndex = 2
        Me.lblMpg.Text = "Miles per gallon:"
        '
        'btnCalMpg
        '
        Me.btnCalMpg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalMpg.Location = New System.Drawing.Point(11, 242)
        Me.btnCalMpg.Name = "btnCalMpg"
        Me.btnCalMpg.Size = New System.Drawing.Size(99, 57)
        Me.btnCalMpg.TabIndex = 4
        Me.btnCalMpg.Text = "Calculate MPG"
        Me.btnCalMpg.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(178, 242)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 57)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(344, 242)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 57)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtGallons
        '
        Me.txtGallons.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGallons.Location = New System.Drawing.Point(277, 20)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(137, 30)
        Me.txtGallons.TabIndex = 7
        '
        'txtMiles
        '
        Me.txtMiles.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiles.Location = New System.Drawing.Point(277, 96)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(137, 30)
        Me.txtMiles.TabIndex = 8
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 303)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(440, 24)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblMpg2
        '
        Me.lblMpg2.AutoSize = True
        Me.lblMpg2.Location = New System.Drawing.Point(274, 186)
        Me.lblMpg2.Name = "lblMpg2"
        Me.lblMpg2.Size = New System.Drawing.Size(0, 17)
        Me.lblMpg2.TabIndex = 11
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 19)
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 19)
        '
        'frmMilesPerGallon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 327)
        Me.Controls.Add(Me.lblMpg2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalMpg)
        Me.Controls.Add(Me.lblMpg)
        Me.Controls.Add(Me.lblMilesDrivenFullTank)
        Me.Controls.Add(Me.lblGallonsOfGasCarHolds)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMilesPerGallon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Miles per Gallon Calculator"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGallonsOfGasCarHolds As Label
    Friend WithEvents lblMpg As Label
    Friend WithEvents lblMilesDrivenFullTank As Label
    Friend WithEvents btnCalMpg As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtGallons As TextBox
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblMpg2 As Label
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblStatus As ToolStripStatusLabel
End Class
