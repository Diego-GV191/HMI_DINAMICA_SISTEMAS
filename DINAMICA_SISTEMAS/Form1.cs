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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
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
                    lblEstadoConexion.Text = "ONLINE";
                    btnConexion.Text = "Desconectar";
                }
                catch (Exception ex)
                {
                    cmbPort.Enabled = true;
                    cmbBaudRate.Enabled = true;
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
                }
                catch (Exception ex)
                {
                    if (Debug) MessageBox.Show(ex.StackTrace);
                    else MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
