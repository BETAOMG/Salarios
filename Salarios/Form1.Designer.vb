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
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 15)
        Label1.TabIndex = 0
        Label1.Text = "Numero de empleados:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(177, 22)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(54, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(41, 65)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ScrollBars = ScrollBars.Vertical
        TextBox2.Size = New Size(205, 202)
        TextBox2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 288)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 15)
        Label2.TabIndex = 3
        Label2.Text = "Total de retencion recaudada"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 317)
        Label3.Name = "Label3"
        Label3.Size = New Size(153, 15)
        Label3.TabIndex = 4
        Label3.Text = "Total de subsidios aplicados"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Location = New Point(37, 343)
        Label4.Name = "Label4"
        Label4.Size = New Size(349, 15)
        Label4.TabIndex = 5
        Label4.Text = "Salario promedio de los empleados que ganan mas de 3 millones"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(218, 288)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(137, 23)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(218, 317)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(137, 23)
        TextBox4.TabIndex = 7
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(405, 340)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(133, 23)
        TextBox5.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(37, 376)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 9
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(118, 376)
        Button2.Name = "Button2"
        Button2.Size = New Size(91, 23)
        Button2.TabIndex = 10
        Button2.Text = "Calcular otro"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(218, 376)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 11
        Button3.Text = "Cerrar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(942, 483)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
