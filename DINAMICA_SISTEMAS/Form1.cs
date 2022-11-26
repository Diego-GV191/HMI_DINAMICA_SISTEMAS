using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DINAMICA_SISTEMAS
{
    public partial class Form1 : Form
    {
        bool Debug = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void SendData(String data)
        {
            try
            {
                if (serialPort1.IsOpen) serialPort1.WriteLine(data);
            }
            catch (Exception ex)
            {
                if (Debug) MessageBox.Show(ex.StackTrace);
                else MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                cmbPort.Items.Clear();
                cmbPort.Enabled = true;
                cmbBaudRate.Enabled = true;
                btnCap.Enabled = false;
                btnTemp.Enabled = false;

                if (serialPort1.IsOpen)
                {
                    btnConexion.Text = "Conectar";
                }
                else
                {
                    btnConexion.Text = "Escanear";
                }
            }
            catch (Exception ex)
            {
                if (Debug) MessageBox.Show(ex.StackTrace);
                else MessageBox.Show(ex.Message);
            }
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {

            if (btnConexion.Text.Equals("Escanear"))
            {
                lblEstadoConexion.Text = "OFFLINE";
                cmbPort.Items.Clear();
                cmbPort.Enabled = true;
                cmbBaudRate.Enabled = true;
                btnCap.Enabled = false;
                btnTemp.Enabled = false;

                try
                {
                    String[] ports = SerialPort.GetPortNames();
                    foreach (String port in ports)
                    {
                        cmbPort.Items.Add(port);
                    }

                    if (cmbPort.Items.Count > 0)
                    {
                        cmbPort.SelectedIndex = 0;
                        btnConexion.Text = "Conectar";
                    }
                    else
                    {
                        cmbPort.Text = "No Serial";
                        btnConexion.Text = "Escanear";
                    }
                }
                catch (Exception ex)
                {
                    cmbPort.Text = "No Serial";
                    cmbPort.Items.Clear();
                    btnConexion.Text = "Escanear";

                    if (Debug) MessageBox.Show(ex.StackTrace);
                    else MessageBox.Show(ex.Message);
                }
            }
            else if (btnConexion.Text.Equals("Conectar"))
            {
                try
                {
                    serialPort1.PortName = cmbPort.Text;
                    serialPort1.BaudRate = Int32.Parse(cmbBaudRate.Text);
                    serialPort1.ReadTimeout = 100;
                    serialPort1.Open();

                    cmbBaudRate.Enabled = false;
                    cmbPort.Enabled = false;
                    btnCap.Enabled = true;
                    btnTemp.Enabled = true;
                    lblEstadoConexion.Text = "ONLINE";
                    btnConexion.Text = "Desconectar";
                }
                catch (Exception ex)
                {
                    cmbPort.Enabled = true;
                    cmbBaudRate.Enabled = true;
                    btnCap.Enabled = false;
                    btnTemp.Enabled = false;
                    cmbPort.Items.Clear();
                    btnConexion.Text = "Escanear";

                    if (Debug) MessageBox.Show(ex.StackTrace);
                    else MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    cmbPort.Items.Clear();
                    cmbPort.Text = "Serial";
                    btnConexion.Text = "Escanear";
                    lblEstadoConexion.Text = "OFFLINE";
                    cmbPort.Enabled = true;
                    cmbBaudRate.Enabled = true;
                    btnCap.Enabled = false;
                    btnTemp.Enabled = false;
                }
                catch (Exception ex)
                {
                    if (Debug) MessageBox.Show(ex.StackTrace);
                    else MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series.Clear();

                if (lblTemp.Text.Equals("TEMP OFF"))
                {
                    lblTemp.Text = "TEMP ON";
                    SendData("$TEMP_ON");
                }

                if (lblTemp.Text.Equals("TEMP ON"))
                {
                    lblTemp.Text = "TEMP OFF";
                    SendData("$TEMP_OFF");
                }
            }
            catch (Exception ex)
            {
                if (Debug) MessageBox.Show(ex.StackTrace);
                else MessageBox.Show(ex.Message);
            }
        }

        private void btnCap_Click(object sender, EventArgs e)
        {
            try
            {

                if (lblCap.Text.Equals("CAP OFF"))
                {
                    lblCap.Text = "CAP ON";
                    SendData("$SEN_ON");
                }

                if (lblCap.Text.Equals("CAP ON"))
                {
                    lblCap.Text = "CAP OFF";
                    SendData("$SEN_OFF");
                }
            }
            catch (Exception ex)
            {
                if (Debug) MessageBox.Show(ex.StackTrace);
                else MessageBox.Show(ex.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
            {
                String SerialData = serialPort1.ReadLine();
                int value = Convert.ToInt32(SerialData.Trim());
                chart1.Invoke((MethodInvoker)(() => chart1.Series["Value"].Points.AddY(value)));
            }
        }
    }
}
