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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(302, 150)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 27)
        Label1.TabIndex = 0
        Label1.Text = "Enter your Age"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(233, 192)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(324, 36)
        TextBox1.TabIndex = 1
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(253, 261)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 34)
        Button1.TabIndex = 2
        Button1.Text = "Clear"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(359, 261)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 34)
        Button2.TabIndex = 3
        Button2.Text = "Submit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImageLayout = ImageLayout.None
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(460, 261)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 34)
        Button3.TabIndex = 4
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(790, 454)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Age Limit Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
