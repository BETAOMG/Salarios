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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 15)
        Label1.TabIndex = 0
        Label1.Text = "Numero de empleados"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(192, 25)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(54, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 15)
        Label2.TabIndex = 2
        Label2.Text = "Nombre del empleado"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(122, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 15)
        Label3.TabIndex = 3
        Label3.Text = "Código"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(45, 173)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 15)
        Label4.TabIndex = 4
        Label4.Text = "Salario bruto"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(45, 210)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 15)
        Label5.TabIndex = 5
        Label5.Text = "Salario neto"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(45, 242)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 15)
        Label6.TabIndex = 6
        Label6.Text = "Valor subsidio"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(324, 108)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 15)
        Label7.TabIndex = 7
        Label7.Text = "Valor de retencion"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(324, 143)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 15)
        Label8.TabIndex = 8
        Label8.Text = "Total a pagar"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(324, 186)
        Label9.Name = "Label9"
        Label9.Size = New Size(159, 15)
        Label9.TabIndex = 9
        Label9.Text = "Total de retencion recaudada"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(324, 214)
        Label10.Name = "Label10"
        Label10.Size = New Size(153, 15)
        Label10.TabIndex = 10
        Label10.Text = "Total de subsidios aplicados"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(324, 242)
        Label11.Name = "Label11"
        Label11.Size = New Size(414, 15)
        Label11.TabIndex = 11
        Label11.Text = "Salario promedo de los empledaos que ganan mas de 3000000 de salario neto"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
