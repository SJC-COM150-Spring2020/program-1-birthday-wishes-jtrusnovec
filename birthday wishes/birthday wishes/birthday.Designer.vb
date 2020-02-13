<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class birthday
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(birthday))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picBirthday = New System.Windows.Forms.PictureBox()
        CType(Me.picBirthday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(21, 32)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(357, 39)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Please enter your name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(28, 87)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(318, 34)
        Me.txtName.TabIndex = 1
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Navy
        Me.btnEnter.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.Location = New System.Drawing.Point(28, 149)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(126, 42)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'lstOut
        '
        Me.lstOut.BackColor = System.Drawing.Color.White
        Me.lstOut.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOut.ForeColor = System.Drawing.Color.Black
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 23
        Me.lstOut.Location = New System.Drawing.Point(29, 239)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(349, 188)
        Me.lstOut.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Navy
        Me.btnClear.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(28, 472)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 41)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Navy
        Me.btnExit.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(210, 472)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 41)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picBirthday
        '
        Me.picBirthday.Image = CType(resources.GetObject("picBirthday.Image"), System.Drawing.Image)
        Me.picBirthday.Location = New System.Drawing.Point(384, -2)
        Me.picBirthday.Name = "picBirthday"
        Me.picBirthday.Size = New System.Drawing.Size(342, 557)
        Me.picBirthday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBirthday.TabIndex = 6
        Me.picBirthday.TabStop = False
        '
        'birthday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(724, 542)
        Me.Controls.Add(Me.picBirthday)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "birthday"
        Me.Text = "birthday"
        CType(Me.picBirthday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents lstOut As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picBirthday As PictureBox
End Class
