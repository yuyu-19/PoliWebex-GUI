﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartupForm
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
        Me.Question = New System.Windows.Forms.Label()
        Me.localmode = New System.Windows.Forms.Button()
        Me.downloadmode = New System.Windows.Forms.Button()
        Me.CreditLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Question
        '
        Me.Question.Location = New System.Drawing.Point(324, 19)
        Me.Question.Name = "Question"
        Me.Question.Size = New System.Drawing.Size(39, 13)
        Me.Question.TabIndex = 0
        Me.Question.Text = "This is a test to see how the text displays"
        '
        'localmode
        '
        Me.localmode.Location = New System.Drawing.Point(656, 46)
        Me.localmode.Name = "localmode"
        Me.localmode.Size = New System.Drawing.Size(77, 19)
        Me.localmode.TabIndex = 1
        Me.localmode.Text = "Button1"
        Me.localmode.UseVisualStyleBackColor = True
        '
        'downloadmode
        '
        Me.downloadmode.Location = New System.Drawing.Point(3, 46)
        Me.downloadmode.Name = "downloadmode"
        Me.downloadmode.Size = New System.Drawing.Size(77, 19)
        Me.downloadmode.TabIndex = 2
        Me.downloadmode.Text = "Button2"
        Me.downloadmode.UseVisualStyleBackColor = True
        '
        'CreditLabel
        '
        Me.CreditLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditLabel.Location = New System.Drawing.Point(201, 46)
        Me.CreditLabel.Name = "CreditLabel"
        Me.CreditLabel.Size = New System.Drawing.Size(299, 42)
        Me.CreditLabel.TabIndex = 3
        Me.CreditLabel.Text = "PoliWebex and PoliDown by @sup3rgiu GUI by @yuyu-19"
        '
        'StartupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 89)
        Me.Controls.Add(Me.CreditLabel)
        Me.Controls.Add(Me.downloadmode)
        Me.Controls.Add(Me.localmode)
        Me.Controls.Add(Me.Question)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "StartupForm"
        Me.Text = "PoliDL-GUI"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Question As Label
    Friend WithEvents localmode As Button
    Friend WithEvents downloadmode As Button
    Friend WithEvents CreditLabel As Label
End Class
