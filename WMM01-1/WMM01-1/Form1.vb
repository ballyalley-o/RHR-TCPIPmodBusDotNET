Public Class Form1
    Private Sub btnRHR_Click(sender As Object, e As EventArgs) Handles btnRHR.Click

        'creates an instance of ModSIM constructor via this IP
        Dim modbusClient As New EasyModbus.ModbusClient("192.168.0.187", 502)

        'attempt a connection
        modbusClient.Connect()

        'read the first holding register and return the value
        Dim HoldingRegistersArray As Integer() = modbusClient.ReadHoldingRegisters(0, 5)

        'receive and display the value
        lblValueHR.Text = HoldingRegistersArray(0).ToString

        'disconnect
        modbusClient.Disconnect()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'creates an instance of ModSIM constructor via this IP
        Dim modbusClient As New EasyModbus.ModbusClient("192.168.0.187", 502)

        'attempt a connection
        modbusClient.Connect()

        'read the first holding register and return the value
        Dim HoldingRegistersArray As Integer() = modbusClient.ReadHoldingRegisters(0, 1)

        'receive and display the value
        lblValueHR.Text = HoldingRegistersArray(0).ToString

        'input register
        Dim InputRegistersArray As Integer() = modbusClient.ReadInputRegisters(2, 1)

        'display the input register value
        lblValueIR.Text = InputRegistersArray(0).ToString

        'read input status array as boolean
        Dim InputStatusArray As Boolean() = modbusClient.ReadDiscreteInputs(1, 1)

        If (InputStatusArray(0) = True) Then
            lblValueIS.Text = "ON"
        Else
            lblValueIS.Text = "OFF"
        End If

        'disconnect
        modbusClient.Disconnect()

    End Sub

End Class
