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
        Me.pbCanvas = New System.Windows.Forms.PictureBox()
        Me.pbBall = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pbPadL = New System.Windows.Forms.PictureBox()
        Me.lblScoreR = New System.Windows.Forms.Label()
        Me.lblScoreL = New System.Windows.Forms.Label()
        Me.pbPadR = New System.Windows.Forms.PictureBox()
        CType(Me.pbCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPadL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPadR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbCanvas
        '
        Me.pbCanvas.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbCanvas.Location = New System.Drawing.Point(0, -1)
        Me.pbCanvas.Name = "pbCanvas"
        Me.pbCanvas.Size = New System.Drawing.Size(1535, 716)
        Me.pbCanvas.TabIndex = 0
        Me.pbCanvas.TabStop = False
        '
        'pbBall
        '
        Me.pbBall.Location = New System.Drawing.Point(721, 277)
        Me.pbBall.Name = "pbBall"
        Me.pbBall.Size = New System.Drawing.Size(50, 50)
        Me.pbBall.TabIndex = 1
        Me.pbBall.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'pbPadL
        '
        Me.pbPadL.Location = New System.Drawing.Point(12, 277)
        Me.pbPadL.Name = "pbPadL"
        Me.pbPadL.Size = New System.Drawing.Size(10, 150)
        Me.pbPadL.TabIndex = 2
        Me.pbPadL.TabStop = False
        '
        'lblScoreR
        '
        Me.lblScoreR.AutoSize = True
        Me.lblScoreR.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreR.Location = New System.Drawing.Point(1377, 23)
        Me.lblScoreR.Name = "lblScoreR"
        Me.lblScoreR.Size = New System.Drawing.Size(35, 37)
        Me.lblScoreR.TabIndex = 3
        Me.lblScoreR.Text = "0"
        '
        'lblScoreL
        '
        Me.lblScoreL.AutoSize = True
        Me.lblScoreL.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreL.Location = New System.Drawing.Point(47, 23)
        Me.lblScoreL.Name = "lblScoreL"
        Me.lblScoreL.Size = New System.Drawing.Size(35, 37)
        Me.lblScoreL.TabIndex = 4
        Me.lblScoreL.Text = "0"
        '
        'pbPadR
        '
        Me.pbPadR.Location = New System.Drawing.Point(1513, 277)
        Me.pbPadR.Name = "pbPadR"
        Me.pbPadR.Size = New System.Drawing.Size(10, 150)
        Me.pbPadR.TabIndex = 5
        Me.pbPadR.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1535, 717)
        Me.Controls.Add(Me.pbPadR)
        Me.Controls.Add(Me.lblScoreL)
        Me.Controls.Add(Me.lblScoreR)
        Me.Controls.Add(Me.pbPadL)
        Me.Controls.Add(Me.pbBall)
        Me.Controls.Add(Me.pbCanvas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPadL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPadR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents pbBall As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pbPadL As System.Windows.Forms.PictureBox
    Friend WithEvents lblScoreR As System.Windows.Forms.Label
    Friend WithEvents lblScoreL As System.Windows.Forms.Label
    Friend WithEvents pbPadR As System.Windows.Forms.PictureBox

End Class
