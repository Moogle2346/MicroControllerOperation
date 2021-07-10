using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;

namespace MicroControllerOperation.Communication
{
    class UARTClass : ICommunication
    {
        #region メンバー変数

        private SerialPort SerialPort = new SerialPort();
        private int __baudrate;
        public int Baudrate
        {
            get { return __baudrate; }
            set { if ((0 < value) || (value <= 19200)) __baudrate = value; }
        }
        public int DataBits { get; set; }
        public StopBits StopBits { get; set; }
        public Parity Parity { get; set; }
        public string Derimiter{ get; set; }
        private bool isReceived = false;

        #endregion


        #region メンバー関数

        public UARTClass()
        {
            Baudrate = 9600;
            DataBits = 8;
            StopBits = StopBits.One;
            Parity = Parity.None;
            Derimiter = "\n";

            SerialPort.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            isReceived = true;
        }

        public UARTClass(int baudrate, int databits, StopBits stopBits, Parity parity, string derimiter)
        {
            Baudrate = baudrate;
            DataBits = databits;
            StopBits = stopBits;
            Parity = parity;
            Derimiter = derimiter;
        }

        /// <summary>
        /// ポートを開きます
        /// </summary>
        public void Open(string portName)
        {
            SerialPort.PortName = portName;
            SerialPort.BaudRate = this.Baudrate;
            SerialPort.DataBits = this.DataBits;
            SerialPort.StopBits = this.StopBits;
            SerialPort.DataBits = this.DataBits;

            try
            {
                if (SerialPort.IsOpen == true)
                {
                    return;
                }
                SerialPort.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// ポートを閉じます
        /// </summary>
        public void Close()
        {
            try
            {
                SerialPort.Close();
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// 文字列を送信します
        /// </summary>
        /// <param name="message">送信データ</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="TimeoutException"></exception>
        public void Send(string message)
        {
            try
            {
                SerialPort.WriteLine(message);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        /// <exception cref="Timeout"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public byte[] Send(byte[] buffer, int start, int length)
        {
            try
            {
                //バッファのクリア
                isReceived = false;
                SerialPort.DiscardInBuffer();
                
                //データの送信
                SerialPort.Write(buffer, start, length);

                //受信処理
                Stopwatch sw = new Stopwatch();
                sw.Start();
                
                while(!isReceived)
                {
                    if(sw.ElapsedMilliseconds > 1000)
                    {
                        sw.Stop();
                        throw new Exception("タイムアウトしました。");
                    }
                }
                sw.Stop();

                byte[] data = new byte[SerialPort.BytesToRead];
                SerialPort.Read(data, 0, SerialPort.BytesToRead);

                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 文字列を受信します
        /// </summary>
        /// <returns>受信データ</returns>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="TimeoutException"></exception>
        public byte[] Receive()
        {
            byte[] data = new byte[1];
            try
            {
                //data = SerialPort.Read();
            }
            catch (Exception)
            {

                throw;
            }

            return data;
        }


        #endregion
    }
}
