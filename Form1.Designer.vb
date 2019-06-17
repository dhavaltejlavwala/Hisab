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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NameCB = New System.Windows.Forms.ComboBox()
        Me.AmountTB = New System.Windows.Forms.TextBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.AnswerRTB = New System.Windows.Forms.RichTextBox()
        Me.HisabBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AddPersonBtn = New System.Windows.Forms.Button()
        Me.AddPersonTB = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameCB
        '
        Me.NameCB.FormattingEnabled = True
        resources.ApplyResources(Me.NameCB, "NameCB")
        Me.NameCB.Name = "NameCB"
        '
        'AmountTB
        '
        resources.ApplyResources(Me.AmountTB, "AmountTB")
        Me.AmountTB.Name = "AmountTB"
        '
        'AddBtn
        '
        resources.ApplyResources(Me.AddBtn, "AddBtn")
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ResetBtn)
        Me.Panel1.Controls.Add(Me.AnswerRTB)
        Me.Panel1.Controls.Add(Me.HisabBtn)
        Me.Panel1.Controls.Add(Me.AddBtn)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'ResetBtn
        '
        resources.ApplyResources(Me.ResetBtn, "ResetBtn")
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.UseVisualStyleBackColor = True
        '
        'AnswerRTB
        '
        resources.ApplyResources(Me.AnswerRTB, "AnswerRTB")
        Me.AnswerRTB.Name = "AnswerRTB"
        '
        'HisabBtn
        '
        resources.ApplyResources(Me.HisabBtn, "HisabBtn")
        Me.HisabBtn.Name = "HisabBtn"
        Me.HisabBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.AddPersonBtn)
        Me.Panel2.Controls.Add(Me.AddPersonTB)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'AddPersonBtn
        '
        resources.ApplyResources(Me.AddPersonBtn, "AddPersonBtn")
        Me.AddPersonBtn.Name = "AddPersonBtn"
        Me.AddPersonBtn.UseVisualStyleBackColor = True
        '
        'AddPersonTB
        '
        resources.ApplyResources(Me.AddPersonTB, "AddPersonTB")
        Me.AddPersonTB.Name = "AddPersonTB"
        '
        'BackgroundWorker
        '
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.AmountTB)
        Me.Controls.Add(Me.NameCB)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameCB As System.Windows.Forms.ComboBox
    Friend WithEvents AmountTB As System.Windows.Forms.TextBox
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents AddPersonBtn As System.Windows.Forms.Button
    Friend WithEvents AddPersonTB As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents HisabBtn As System.Windows.Forms.Button
    Friend WithEvents AnswerRTB As System.Windows.Forms.RichTextBox
    Friend WithEvents ResetBtn As System.Windows.Forms.Button

End Class
