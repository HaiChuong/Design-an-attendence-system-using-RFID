using System;
using System.IO.Ports;

public class SerialPortManager
{
    private static SerialPort _serialPort;

    
    private SerialPortManager()
    {
        _serialPort = new SerialPort();
    }

    public static SerialPortManager Instance { get; } = new SerialPortManager();

    public SerialPort SerialPort
    {
        get { return _serialPort; }
    }

    public void OpenPort(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
    {
        if (!_serialPort.IsOpen)
        {
            _serialPort.PortName = portName;
            _serialPort.BaudRate = baudRate;
            _serialPort.Parity = parity;
            _serialPort.DataBits = dataBits;
            _serialPort.StopBits = stopBits;

            _serialPort.Open();
        }
    }

    public void ClosePort()
    {
        if (_serialPort.IsOpen)
        {
            _serialPort.Close();
        }
    }
}