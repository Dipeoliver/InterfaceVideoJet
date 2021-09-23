using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace VideoJet  // interface scanner e VideoJet
{
    public partial class Form1 : Form
    {
        string Entrada;
        string Impressora;
        private delegate void SetTextDelege(string data);

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbImprimir.BackColor = Color.LimeGreen;
            RS232();

            try
            {
                // abre conecao com as portas e muda cor da label.
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    lblCOM1.ForeColor = Color.Green;
                }

                serialPort2.Open();
                if (serialPort2.IsOpen)
                {
                    lblCOM2.ForeColor = Color.Green;
                }

                serialPort3.Open();
                if (serialPort3.IsOpen)
                {
                    lblCOM3.ForeColor = Color.Green;
                }


                serialPort4.Open();
                if (serialPort4.IsOpen)
                {
                    lblCOM4.ForeColor = Color.Green;
                }
            }
            catch
            {
                // se nao conseguir conexao com a porta muda cor da label e exibe mensagem.
                if (!serialPort1.IsOpen)
                {
                    lblCOM1.ForeColor = Color.Red;
                }

                else if (!serialPort2.IsOpen)
                {
                    lblCOM2.ForeColor = Color.Red;
                }

                else if (!serialPort3.IsOpen)
                {
                    lblCOM3.ForeColor = Color.Red;
                }

                else if (!serialPort4.IsOpen)
                {
                    lblCOM4.ForeColor = Color.Red;
                }

                MessageBox.Show("Porta Serial  ja em Uso", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBox1.Visible = false;
                return;
            }

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            serialPort4.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void RS232() // configura as portas seriais
        {
            serialPort1.PortName = "COM1";   //scanner
            serialPort1.BaudRate = Convert.ToInt16(9600);
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;



            serialPort4.PortName = "COM4";   //scanner
            serialPort4.BaudRate = Convert.ToInt16(9600);
            serialPort4.Parity = Parity.None;
            serialPort4.StopBits = StopBits.One;
            serialPort4.DataBits = 8;


            serialPort2.PortName = "COM2";   //  impressora
            serialPort2.BaudRate = Convert.ToInt32(9600);
            serialPort2.Parity = Parity.None;
            serialPort2.StopBits = StopBits.One;
            serialPort2.DataBits = 8;

            serialPort3.PortName = "COM3";    // gmes
            serialPort3.BaudRate = Convert.ToInt16(9600);
            serialPort3.Parity = Parity.None;
            serialPort3.StopBits = StopBits.One;
            serialPort3.DataBits = 8;


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // fecha as seriais ao finalizar o programa
            serialPort1.Close();
            serialPort2.Close();
            serialPort3.Close();
            serialPort4.Close();
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e) // recebe sinal da serial
        {
            SerialPort sp = (SerialPort)sender;
            System.Threading.Thread.Sleep(250);
            string indata = sp.ReadExisting();

            this.BeginInvoke(new SetTextDelege(DisplayToUI), new object[] { indata });

        }

        private void DisplayToUI(string displayData)  // recebe dados da serial e envia para as seriais 
        {

            Entrada = "";

            Entrada += displayData.Trim();

            lblSaida.Text = Entrada;

            if (Entrada == "CLEAR" || Entrada == "TRACE" || Entrada == "CBPASS")
            {
                serialPort3.WriteLine(Entrada + "\r\n");
                lblCliente.Text = ".......";
                rdbNaoImprimir.Checked = true;

            }
            else
            {
                //---------------------------------------------------------------------------------------------     LG  ---------------------------------------------------------
                if (Entrada.Length == 12) // etiquetas LG tem  12 caracteres. 
                {
                    string V1;
                    string V2;
                    string V3;

                    V1 = Entrada.Substring(0, 3);
                    V2 = Entrada.Substring(3, 4);
                    V3 = Entrada.Substring(7, 5);

                    Impressora = "JDI|1|V1=" + V1 + "|V2=" + V2 + "|V3=" + V3 + "|" + "\r\n";

                    // envia sinal para o GMES e para a impressora
                    if (rdbImprimir.Checked == true)
                    {

                        lblImpressora.Text = Impressora;
                        serialPort2.WriteLine(Impressora);
                        serialPort3.WriteLine(Entrada + "\r\n");
                        lblCliente.Text = "LG";
                        // System.Threading.Thread.Sleep(250);
                    }
                    // envia sinal somente para o GMES 

                    else if (rdbNaoImprimir.Checked == true)
                    {
                        serialPort3.WriteLine(Entrada + "\r\n");
                        lblCliente.Text = "LG";

                    }
                    // envia sinal somente para o impressora
                    else
                    {
                        serialPort2.WriteLine(Impressora);
                        // System.Threading.Thread.Sleep(250);
                        lblCliente.Text = "- REPRINT LG -";
                    }
                }
                //-------------------------------------------------------------------------------------------     HP      ----------------------------------------------------------------

                else if (Entrada.Length == 10) // etiquetas HP tem  10 caracteres.
                {

                    string V1;
                    string V2;
                    string V3;

                    V1 = Entrada.Substring(0, 5);
                    V2 = Entrada.Substring(5, 1);
                    V3 = Entrada.Substring(6, 4);

                    Impressora = "JDI|1|V1=" + V1 + "|V2=" + V2 + "|V3=" + V3 + "|" + "\r\n";

                    // envia sinal para o GMES e para a impressora
                    if (rdbImprimir.Checked == true)
                    {

                        lblImpressora.Text = Impressora;
                        serialPort2.WriteLine(Impressora);
                        serialPort3.WriteLine(Entrada + "\r\n");
                        lblCliente.Text = "HP";
                        // System.Threading.Thread.Sleep(250);
                    }
                    // envia sinal somente para o GMES 

                    else if (rdbNaoImprimir.Checked == true)
                    {
                        serialPort3.WriteLine(Entrada + "\r\n");
                        lblCliente.Text = "HP";
                    }
                    // envia sinal somente para o impressora
                    else
                    {
                        serialPort2.WriteLine(Impressora);
                        //System.Threading.Thread.Sleep(250);
                        lblCliente.Text = "- REPRINT HP -";
                    }

                }
                //---------------------------------------------------------------------------------    POSITIVO   /  DATEN    ----------------------------------------------------------------------

                else if (Entrada.Length == 9) // etiquetas POSITIVO tem  9 caracteres.
                {

                    string V1;
                    string V2;
                    string V3;

                    V1 = Entrada.Substring(0, 4);
                    V2 = Entrada.Substring(4, 5);
                    V3 = "#";

                    Impressora = "JDI|1|V1=" + V1 + "|V2=" + V2 + "|V3=" + V3 + "|" + "\r\n";

                    // envia sinal para o GMES e para a impressora
                    if (rdbImprimir.Checked == true)
                    {

                        lblImpressora.Text = Impressora;
                        serialPort2.WriteLine(Impressora);
                        serialPort3.WriteLine(Entrada + "\r\n");
                        lblCliente.Text = "POSITIVO";
                        // System.Threading.Thread.Sleep(250);
                    }
                    // envia sinal somente para o GMES 

                    else if (rdbNaoImprimir.Checked == true)
                    {
                        serialPort3.WriteLine(Entrada + "\r\n");
                        lblCliente.Text = "POSITIVO";
                    }
                    // envia sinal somente para o impressora
                    else
                    {
                        serialPort2.WriteLine(Impressora);
                        //System.Threading.Thread.Sleep(250);
                        lblCliente.Text = "- REPRINT POSITIVO -";
                    }

                }
            }
        }
        
        //-------    CONFIGURA AS CORES DOS CHECK BOX -------------
        private void rdbImprimir_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbImprimir.Checked == true)
            {
                rdbImprimir.BackColor = Color.LimeGreen;
                rdbNaoImprimir.BackColor = DefaultBackColor;
                rdbReprint.BackColor = DefaultBackColor;
            }
        }

        private void rdbNaoImprimir_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNaoImprimir.Checked == true)
            {
                rdbImprimir.BackColor = DefaultBackColor;
                rdbNaoImprimir.BackColor = Color.OrangeRed;
                rdbReprint.BackColor = DefaultBackColor;
            }
        }

        private void rdbReprint_CheckedChanged(object sender, EventArgs e)
        {
            rdbImprimir.BackColor = DefaultBackColor;
            rdbNaoImprimir.BackColor = DefaultBackColor;
            rdbReprint.BackColor = Color.Yellow;
        }
    }
}
