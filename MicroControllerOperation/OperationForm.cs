using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroControllerOperation.Communication;

namespace MicroControllerOperation
{
    public partial class OperationForm : Form
    {
        UARTClass UART;
        public OperationForm()
        {
            InitializeComponent();
            UART = new UARTClass();
        }

        private void btn_Debug_Click(object sender, EventArgs e)
        {
            UART.Baudrate = 19200;
            txtB_Debug.Text = UART.Baudrate.ToString();
            
            //try
            //{
            //    UART.Send("aiueo");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            
        }
    }
}
