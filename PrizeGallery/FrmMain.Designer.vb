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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblPrizeVal = New System.Windows.Forms.Label()
        Me.lblWinnings = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblForfeit = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.picPrize = New System.Windows.Forms.PictureBox()
        Me.timSpin = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picPrize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(26, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(749, 91)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Panther Prize Gallery - Spin To Win Prizes "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblResult.Location = New System.Drawing.Point(47, 104)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(200, 57)
        Me.lblResult.TabIndex = 1
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrizeVal
        '
        Me.lblPrizeVal.BackColor = System.Drawing.Color.White
        Me.lblPrizeVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrizeVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrizeVal.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblPrizeVal.Location = New System.Drawing.Point(47, 233)
        Me.lblPrizeVal.Name = "lblPrizeVal"
        Me.lblPrizeVal.Size = New System.Drawing.Size(201, 57)
        Me.lblPrizeVal.TabIndex = 2
        Me.lblPrizeVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWinnings
        '
        Me.lblWinnings.BackColor = System.Drawing.Color.White
        Me.lblWinnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWinnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinnings.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblWinnings.Location = New System.Drawing.Point(47, 358)
        Me.lblWinnings.Name = "lblWinnings"
        Me.lblWinnings.Size = New System.Drawing.Size(201, 55)
        Me.lblWinnings.TabIndex = 3
        Me.lblWinnings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(44, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Prize Value:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(48, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Your total Winnings"
        '
        'lblForfeit
        '
        Me.lblForfeit.AutoSize = True
        Me.lblForfeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForfeit.ForeColor = System.Drawing.Color.Red
        Me.lblForfeit.Location = New System.Drawing.Point(47, 437)
        Me.lblForfeit.Name = "lblForfeit"
        Me.lblForfeit.Size = New System.Drawing.Size(95, 24)
        Me.lblForfeit.TabIndex = 6
        Me.lblForfeit.Text = "You Lose!"
        '
        'btnStart
        '
        Me.btnStart.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnStart.Location = New System.Drawing.Point(51, 477)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(96, 23)
        Me.btnStart.TabIndex = 7
        Me.btnStart.Text = "Start the spin"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnStop.Location = New System.Drawing.Point(51, 520)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(96, 23)
        Me.btnStop.TabIndex = 8
        Me.btnStop.Text = "Stop the spin"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnQuit.Location = New System.Drawing.Point(51, 567)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(96, 23)
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'picPrize
        '
        Me.picPrize.Image = Global.PrizeGallery.My.Resources.Resources.prize_1
        Me.picPrize.Location = New System.Drawing.Point(291, 104)
        Me.picPrize.Name = "picPrize"
        Me.picPrize.Size = New System.Drawing.Size(172, 261)
        Me.picPrize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPrize.TabIndex = 10
        Me.picPrize.TabStop = False
        '
        'timSpin
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(959, 621)
        Me.Controls.Add(Me.picPrize)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblForfeit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblWinnings)
        Me.Controls.Add(Me.lblPrizeVal)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Mystery Prizes"
        CType(Me.picPrize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents lblPrizeVal As Label
    Friend WithEvents lblWinnings As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblForfeit As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents picPrize As PictureBox
    Friend WithEvents timSpin As Timer
End Class
