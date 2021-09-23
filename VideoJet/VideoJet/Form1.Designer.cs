namespace VideoJet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblSaida = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblImpressora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbNaoImprimir = new System.Windows.Forms.RadioButton();
            this.rdbImprimir = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbReprint = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCOM1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCOM4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCOM2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCOM3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort4 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida.ForeColor = System.Drawing.Color.Red;
            this.lblSaida.Location = new System.Drawing.Point(39, 205);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(0, 75);
            this.lblSaida.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "SERIAL";
            // 
            // lblImpressora
            // 
            this.lblImpressora.AutoSize = true;
            this.lblImpressora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpressora.Location = new System.Drawing.Point(583, 50);
            this.lblImpressora.Name = "lblImpressora";
            this.lblImpressora.Size = new System.Drawing.Size(38, 31);
            this.lblImpressora.TabIndex = 7;
            this.lblImpressora.Text = "...";
            this.lblImpressora.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cliente";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(125, 100);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 31);
            this.lblCliente.TabIndex = 0;
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM2";
            // 
            // serialPort3
            // 
            this.serialPort3.PortName = "COM3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::VideoJet.Properties.Resources.Preloader_1;
            this.pictureBox1.Location = new System.Drawing.Point(610, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // rdbNaoImprimir
            // 
            this.rdbNaoImprimir.AutoSize = true;
            this.rdbNaoImprimir.BackColor = System.Drawing.SystemColors.Control;
            this.rdbNaoImprimir.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNaoImprimir.Location = new System.Drawing.Point(271, 12);
            this.rdbNaoImprimir.Name = "rdbNaoImprimir";
            this.rdbNaoImprimir.Size = new System.Drawing.Size(188, 35);
            this.rdbNaoImprimir.TabIndex = 2;
            this.rdbNaoImprimir.Text = "NÃO IMPRIMIR";
            this.rdbNaoImprimir.UseVisualStyleBackColor = false;
            this.rdbNaoImprimir.CheckedChanged += new System.EventHandler(this.rdbNaoImprimir_CheckedChanged);
            // 
            // rdbImprimir
            // 
            this.rdbImprimir.AutoSize = true;
            this.rdbImprimir.Checked = true;
            this.rdbImprimir.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbImprimir.Location = new System.Drawing.Point(12, 12);
            this.rdbImprimir.Name = "rdbImprimir";
            this.rdbImprimir.Size = new System.Drawing.Size(223, 35);
            this.rdbImprimir.TabIndex = 1;
            this.rdbImprimir.TabStop = true;
            this.rdbImprimir.Text = "IMPRIMIR + GMES";
            this.rdbImprimir.UseVisualStyleBackColor = true;
            this.rdbImprimir.CheckedChanged += new System.EventHandler(this.rdbImprimir_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ver.1.05";
            // 
            // rdbReprint
            // 
            this.rdbReprint.AutoSize = true;
            this.rdbReprint.BackColor = System.Drawing.SystemColors.Control;
            this.rdbReprint.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbReprint.Location = new System.Drawing.Point(495, 12);
            this.rdbReprint.Name = "rdbReprint";
            this.rdbReprint.Size = new System.Drawing.Size(130, 35);
            this.rdbReprint.TabIndex = 3;
            this.rdbReprint.Text = "REPRINT";
            this.rdbReprint.UseVisualStyleBackColor = false;
            this.rdbReprint.CheckedChanged += new System.EventHandler(this.rdbReprint_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCOM1,
            this.toolStripStatusLabel1,
            this.lblCOM4,
            this.toolStripStatusLabel2,
            this.lblCOM2,
            this.toolStripStatusLabel4,
            this.lblCOM3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 309);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(659, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCOM1
            // 
            this.lblCOM1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCOM1.Name = "lblCOM1";
            this.lblCOM1.Size = new System.Drawing.Size(95, 17);
            this.lblCOM1.Text = "Scanner   COM1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "/";
            // 
            // lblCOM4
            // 
            this.lblCOM4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCOM4.Name = "lblCOM4";
            this.lblCOM4.Size = new System.Drawing.Size(92, 17);
            this.lblCOM4.Text = "Scanner  COM4";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(24, 17);
            this.toolStripStatusLabel2.Text = "  /  ";
            // 
            // lblCOM2
            // 
            this.lblCOM2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCOM2.Name = "lblCOM2";
            this.lblCOM2.Size = new System.Drawing.Size(112, 17);
            this.lblCOM2.Text = "Impressora   COM2";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(24, 17);
            this.toolStripStatusLabel4.Text = "  /  ";
            // 
            // lblCOM3
            // 
            this.lblCOM3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCOM3.Name = "lblCOM3";
            this.lblCOM3.Size = new System.Drawing.Size(83, 17);
            this.lblCOM3.Text = "GMES   COM3";
            // 
            // serialPort4
            // 
            this.serialPort4.PortName = "COM4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 331);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rdbReprint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbImprimir);
            this.Controls.Add(this.rdbNaoImprimir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblImpressora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSaida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Interface Scanner GMES & VideoJet";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblImpressora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCliente;
        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdbNaoImprimir;
        private System.Windows.Forms.RadioButton rdbImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbReprint;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCOM1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblCOM2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lblCOM3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCOM4;
        private System.IO.Ports.SerialPort serialPort4;
    }
}

