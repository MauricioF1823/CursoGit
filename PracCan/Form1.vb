Public Class Form1


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Mturnos.FechaInicio = dtp1.Value.ToShortDateString
        Mturnos.FechaFinal = dtp5.Value.ToShortDateString

        CalcularTurno()


    End Sub

    'lblResultado.Text

    Private Sub CalcularTurno()



        Dim cant As Long
        cant = DateDiff(DateInterval.Day, FechaInicio, FechaFinal)
        turnos = cant \ 6
        dias = cant Mod 6

        If turnos = 0 Then
            If dias < 4 Then
                turno = "mañana"
                dias += 1
                MsgBox("Turno mañana, dia: " + dias.ToString)
            Else
                MsgBox("Esta de franco")
            End If
        End If

        If turnos > 0 Then
            If turnos Mod 2 = 0 Then
                turno = "mañana"
            Else
                turno = "tarde"
            End If
            If dias < 4 Then
                dias += 1
                MsgBox("Esta trabajando turno " + turno.ToString)
            Else
                MsgBox("Esta de franco")
            End If
        End If
        lblTurno.Text = turno
        lblDias.Text = dias.ToString
    End Sub

    Private Sub BtnBuscar_MouseHover(sender As Object, e As EventArgs) Handles btnBuscar.MouseHover
        btnBuscar.BackColor = Color.Aqua
    End Sub

    Private Sub BtnBuscar_MouseLeave(sender As Object, e As EventArgs) Handles btnBuscar.MouseLeave
        btnBuscar.BackColor = Color.Transparent
    End Sub
End Class
