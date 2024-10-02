Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'NumeroEmpleados Numero de empleados
        'SalarioBruto Salario Bruto
        'Nombre Nombre del empleado
        'Codigo codigo del empleado
        'SalarioNeto Salario neto
        'Subsidio Valor del subsidio
        'Retencion Valor de la retencion
        'TotalPagar Total a pagar
        'SumaRetencion Suma de retenciones
        'SumaSubsidios Suma de subsidios
        'SumaSalarios Suma de salarios mayores a 3 millones
        'CuentaSalarios Contador de salarios
        'Hijos Numero de hijos

        Dim NumeroEmpleados, SalarioBruto, Codigo, Hijos, CuentaSalarios, i As Integer
        Dim Nombre As String
        Dim SalarioNeto, Subsidio, Retencion, TotalPagar, SumaRetencion, SumaSubsidios, SumaSalarios As Single

        NumeroEmpleados = TextBox1.Text
        TextBox2.Text = "Salida" + vbCrLf + vbCrLf

        For i = 1 To NumeroEmpleados
            Nombre = InputBox("Ingrese el nombre del empleado " + Str(i))
            Codigo = Val(InputBox("Ingrese el codigo del empleado " + Nombre))
            Hijos = Val(InputBox("Ingrese el numero de hijos del empleado " + Nombre))
            SalarioBruto = Val(InputBox("Ingrese el salario bruto del empleado " + Nombre))
            TextBox2.Text = TextBox2.Text + "Empleado" + Str(i) + vbCrLf
            If SalarioBruto <= 1200000 Then
                Retencion = SalarioBruto * 0.05
            End If
            If SalarioBruto > 1200000 And SalarioBruto <= 3200000 Then
                Retencion = SalarioBruto * 0.15
            End If
            If SalarioBruto > 3200000 Then
                Retencion = SalarioBruto * 0.26
            End If
            SalarioNeto = SalarioBruto - Retencion
            If Hijos <= 5 Then
                Subsidio = (SalarioNeto * 0.03) * Hijos
            End If
            If Hijos > 5 Then
                Subsidio = (SalarioNeto * 0.03) * 5
            End If
            TotalPagar = SalarioNeto + Subsidio
            If TotalPagar > 3000000 Then
                SumaSalarios += TotalPagar
                CuentaSalarios += 1
            End If
            SumaSubsidios += Subsidio
            SumaRetencion += Retencion

            TextBox2.Text = TextBox2.Text + "Nombre:" + Chr(9) + Nombre + vbCrLf + "Codigo:" + Chr(9) + Str(Codigo) + vbCrLf + "Salario bruto:" + Chr(9) + Str(SalarioBruto) + vbCrLf + "Salario neto:" + Chr(9) + Str(SalarioNeto) + vbCrLf
            If Subsidio > 0 Then
                TextBox2.Text = TextBox2.Text + "Subsidio:" + Chr(9) + Str(Subsidio) + vbCrLf
            End If
            TextBox2.Text = TextBox2.Text + "Retención:" + Chr(9) + Str(Retencion) + vbCrLf + "Total a pagar:" + Chr(9) + Str(TotalPagar) + vbCrLf + vbCrLf
        Next

        TextBox3.Text = SumaRetencion
        TextBox4.Text = SumaSubsidios
        TextBox5.Text = SumaSalarios / CuentaSalarios

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
