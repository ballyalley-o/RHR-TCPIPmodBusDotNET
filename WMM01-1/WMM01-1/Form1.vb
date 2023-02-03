Public Class Form1

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

        'read coil status value 
        Dim CoilStatusArray As Boolean() = modbusClient.ReadCoils(4, 1)

        If (CoilStatusArray(0) = True) Then
            lblValueCS.Text = "ON"
        Else
            lblValueCS.Text = "OFF"
        End If


        'disconnect
        modbusClient.Disconnect()

    End Sub

    Private Sub btnWSR_Click(sender As Object, e As EventArgs) Handles btnWSR.Click

        Dim regval As Integer

        'creates an instance of ModSIM constructor via this IP
        Dim modbusClient As New EasyModbus.ModbusClient("192.168.0.187", 502)

        'attempt a connection
        modbusClient.Connect()

        regval = CInt(txtRegVal.Text)

        modbusClient.WriteSingleRegister(4, regval)


        'disconnect
        modbusClient.Disconnect()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim coilVal As Boolean

        'creates an instance of ModSIM constructor via this IP
        Dim modbusClient As New EasyModbus.ModbusClient("192.168.0.187", 502)

        'attempt a connection
        modbusClient.Connect()

        If (txtCoilVal.Text = "1") Then
            coilVal = True
        Else
            coilVal = False
        End If

        'display the coil val
        modbusClient.WriteSingleCoil(3, coilVal)

        'disconnect
        modbusClient.Disconnect()

    End Sub
End Class
