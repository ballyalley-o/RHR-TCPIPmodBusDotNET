Public Class Form1

    Private Sub btnRHR_Click(sender As Object, e As EventArgs) Handles btnRHR.Click

        Dim modbusClient As New EasyModbus.ModbusClient("192.168.0.187", 502)

        modbusClient.Connect()

        Dim HoldingRegistersArray As Integer() = modbusClient.ReadHoldingRegisters(0, 1)
        lblValue.Text = HoldingRegistersArray(0).ToString
        modbusClient.Disconnect()

    End Sub

End Class
