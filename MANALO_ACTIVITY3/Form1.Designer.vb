<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtFirstNum = New TextBox()
        txtSecNum = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        MULTIPLY = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' txtFirstNum
        ' 
        txtFirstNum.Location = New Point(32, 48)
        txtFirstNum.Name = "txtFirstNum"
        txtFirstNum.Size = New Size(145, 23)
        txtFirstNum.TabIndex = 0
        ' 
        ' txtSecNum
        ' 
        txtSecNum.Location = New Point(32, 105)
        txtSecNum.Name = "txtSecNum"
        txtSecNum.Size = New Size(145, 23)
        txtSecNum.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 2
        Label1.Text = "FIRST NUMBER:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 15)
        Label2.TabIndex = 3
        Label2.Text = "SECOND NUMBER:"
        ' 
        ' MULTIPLY
        ' 
        MULTIPLY.Location = New Point(47, 144)
        MULTIPLY.Name = "MULTIPLY"
        MULTIPLY.Size = New Size(92, 20)
        MULTIPLY.TabIndex = 4
        MULTIPLY.Text = "MULTIPLY"
        MULTIPLY.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(67, 188)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(54, 15)
        lblResult.TabIndex = 5
        lblResult.Text = "ANSWER"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResult)
        Controls.Add(MULTIPLY)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtSecNum)
        Controls.Add(txtFirstNum)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstNum As TextBox
    Friend WithEvents txtSecNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MULTIPLY As Button
    Friend WithEvents lblResult As Label
End Class
