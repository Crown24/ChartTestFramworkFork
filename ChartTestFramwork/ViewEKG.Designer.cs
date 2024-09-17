namespace ChartTestFramwork
{
    partial class ViewECG
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCOMPorts = new System.Windows.Forms.ComboBox();
            this.serialPortalt = new System.IO.Ports.SerialPort(this.components);
            this.buttonStartLiveData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxLagetyp = new System.Windows.Forms.TextBox();
            this.textBoxFrequenz = new System.Windows.Forms.TextBox();
            this.textBoxRythmus = new System.Windows.Forms.TextBox();
            this.textBoxSinusTachykardie = new System.Windows.Forms.TextBox();
            this.textBoxSinusbradykardie = new System.Windows.Forms.TextBox();
            this.textBoxSTEMI = new System.Windows.Forms.TextBox();
            this.textBoxVES = new System.Windows.Forms.TextBox();
            this.textBoxSVES = new System.Windows.Forms.TextBox();
            this.textBoxAVBI = new System.Windows.Forms.TextBox();
            this.textBoxAVBII = new System.Windows.Forms.TextBox();
            this.textBoxAVBIII = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxPRI = new System.Windows.Forms.TextBox();
            this.textBoxPRS = new System.Windows.Forms.TextBox();
            this.textBoxPQDauer = new System.Windows.Forms.TextBox();
            this.textBoxQRSDauer = new System.Windows.Forms.TextBox();
            this.textBoxQTDauer = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Black;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.Black;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Black;
            this.chart1.BorderlineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Lime;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.Maximum = 1024D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(376, 103);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackSecondaryColor = System.Drawing.Color.Yellow;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.LabelBackColor = System.Drawing.Color.Cyan;
            series1.LabelBorderColor = System.Drawing.Color.Red;
            series1.LabelForeColor = System.Drawing.Color.Lime;
            series1.Name = "Live EKG";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(781, 447);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM-Port";
            // 
            // comboBoxCOMPorts
            // 
            this.comboBoxCOMPorts.BackColor = System.Drawing.Color.Black;
            this.comboBoxCOMPorts.ForeColor = System.Drawing.Color.Lime;
            this.comboBoxCOMPorts.FormattingEnabled = true;
            this.comboBoxCOMPorts.Location = new System.Drawing.Point(71, 6);
            this.comboBoxCOMPorts.Name = "comboBoxCOMPorts";
            this.comboBoxCOMPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCOMPorts.TabIndex = 2;
            this.comboBoxCOMPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxCOMProts_SelectedIndexChanged);
            // 
            // buttonStartLiveData
            // 
            this.buttonStartLiveData.BackColor = System.Drawing.Color.Black;
            this.buttonStartLiveData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartLiveData.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonStartLiveData.Location = new System.Drawing.Point(71, 33);
            this.buttonStartLiveData.Name = "buttonStartLiveData";
            this.buttonStartLiveData.Size = new System.Drawing.Size(121, 23);
            this.buttonStartLiveData.TabIndex = 3;
            this.buttonStartLiveData.Text = "start Live Data";
            this.buttonStartLiveData.UseVisualStyleBackColor = false;
            this.buttonStartLiveData.Click += new System.EventHandler(this.buttonStartLiveData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Frequenz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(12, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "VES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SVES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rythmus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(12, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sinustachykardie (>100/min)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(12, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Lagetyp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "P";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "PR-Interval";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "PR-Segment";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "AV-Block I (PQ-I >200ms)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 478);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "PQ-Dauer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 506);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "QRS-Dauer";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 533);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "QT-Dauer";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 350);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(247, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "AV-Block II: verlängerung/PQ/Ausfall AV Überleitung";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 372);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(247, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "AV-Block III: Vorhof/Kammer unabhängiger Rythmus";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Lime;
            this.label17.Location = new System.Drawing.Point(12, 211);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Sinusbradykardie (<60/min)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Lime;
            this.label18.Location = new System.Drawing.Point(12, 238);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "STEMI (Anhebung ST)";
            // 
            // textBoxLagetyp
            // 
            this.textBoxLagetyp.BackColor = System.Drawing.Color.Black;
            this.textBoxLagetyp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLagetyp.ForeColor = System.Drawing.Color.Lime;
            this.textBoxLagetyp.Location = new System.Drawing.Point(71, 103);
            this.textBoxLagetyp.Name = "textBoxLagetyp";
            this.textBoxLagetyp.Size = new System.Drawing.Size(281, 21);
            this.textBoxLagetyp.TabIndex = 21;
            this.textBoxLagetyp.Text = "0";
            // 
            // textBoxFrequenz
            // 
            this.textBoxFrequenz.BackColor = System.Drawing.Color.Black;
            this.textBoxFrequenz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFrequenz.ForeColor = System.Drawing.Color.Lime;
            this.textBoxFrequenz.Location = new System.Drawing.Point(71, 129);
            this.textBoxFrequenz.Name = "textBoxFrequenz";
            this.textBoxFrequenz.Size = new System.Drawing.Size(281, 21);
            this.textBoxFrequenz.TabIndex = 22;
            // 
            // textBoxRythmus
            // 
            this.textBoxRythmus.BackColor = System.Drawing.Color.Black;
            this.textBoxRythmus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRythmus.ForeColor = System.Drawing.Color.Lime;
            this.textBoxRythmus.Location = new System.Drawing.Point(71, 155);
            this.textBoxRythmus.Name = "textBoxRythmus";
            this.textBoxRythmus.Size = new System.Drawing.Size(281, 21);
            this.textBoxRythmus.TabIndex = 23;
            // 
            // textBoxSinusTachykardie
            // 
            this.textBoxSinusTachykardie.BackColor = System.Drawing.Color.Black;
            this.textBoxSinusTachykardie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSinusTachykardie.ForeColor = System.Drawing.Color.Lime;
            this.textBoxSinusTachykardie.Location = new System.Drawing.Point(160, 181);
            this.textBoxSinusTachykardie.Name = "textBoxSinusTachykardie";
            this.textBoxSinusTachykardie.Size = new System.Drawing.Size(192, 21);
            this.textBoxSinusTachykardie.TabIndex = 24;
            // 
            // textBoxSinusbradykardie
            // 
            this.textBoxSinusbradykardie.BackColor = System.Drawing.Color.Black;
            this.textBoxSinusbradykardie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSinusbradykardie.ForeColor = System.Drawing.Color.Lime;
            this.textBoxSinusbradykardie.Location = new System.Drawing.Point(160, 208);
            this.textBoxSinusbradykardie.Name = "textBoxSinusbradykardie";
            this.textBoxSinusbradykardie.Size = new System.Drawing.Size(192, 21);
            this.textBoxSinusbradykardie.TabIndex = 25;
            // 
            // textBoxSTEMI
            // 
            this.textBoxSTEMI.BackColor = System.Drawing.Color.Black;
            this.textBoxSTEMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSTEMI.ForeColor = System.Drawing.Color.Lime;
            this.textBoxSTEMI.Location = new System.Drawing.Point(160, 235);
            this.textBoxSTEMI.Name = "textBoxSTEMI";
            this.textBoxSTEMI.Size = new System.Drawing.Size(192, 21);
            this.textBoxSTEMI.TabIndex = 26;
            // 
            // textBoxVES
            // 
            this.textBoxVES.BackColor = System.Drawing.Color.Black;
            this.textBoxVES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVES.ForeColor = System.Drawing.Color.Lime;
            this.textBoxVES.Location = new System.Drawing.Point(160, 263);
            this.textBoxVES.Name = "textBoxVES";
            this.textBoxVES.Size = new System.Drawing.Size(192, 21);
            this.textBoxVES.TabIndex = 27;
            // 
            // textBoxSVES
            // 
            this.textBoxSVES.BackColor = System.Drawing.Color.Black;
            this.textBoxSVES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSVES.ForeColor = System.Drawing.Color.Lime;
            this.textBoxSVES.Location = new System.Drawing.Point(160, 289);
            this.textBoxSVES.Name = "textBoxSVES";
            this.textBoxSVES.Size = new System.Drawing.Size(192, 21);
            this.textBoxSVES.TabIndex = 28;
            // 
            // textBoxAVBI
            // 
            this.textBoxAVBI.BackColor = System.Drawing.Color.Black;
            this.textBoxAVBI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAVBI.ForeColor = System.Drawing.Color.Lime;
            this.textBoxAVBI.Location = new System.Drawing.Point(160, 316);
            this.textBoxAVBI.Name = "textBoxAVBI";
            this.textBoxAVBI.Size = new System.Drawing.Size(192, 21);
            this.textBoxAVBI.TabIndex = 29;
            // 
            // textBoxAVBII
            // 
            this.textBoxAVBII.BackColor = System.Drawing.Color.Black;
            this.textBoxAVBII.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAVBII.ForeColor = System.Drawing.Color.Lime;
            this.textBoxAVBII.Location = new System.Drawing.Point(276, 343);
            this.textBoxAVBII.Name = "textBoxAVBII";
            this.textBoxAVBII.Size = new System.Drawing.Size(76, 21);
            this.textBoxAVBII.TabIndex = 30;
            // 
            // textBoxAVBIII
            // 
            this.textBoxAVBIII.BackColor = System.Drawing.Color.Black;
            this.textBoxAVBIII.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAVBIII.ForeColor = System.Drawing.Color.Lime;
            this.textBoxAVBIII.Location = new System.Drawing.Point(276, 369);
            this.textBoxAVBIII.Name = "textBoxAVBIII";
            this.textBoxAVBIII.Size = new System.Drawing.Size(76, 21);
            this.textBoxAVBIII.TabIndex = 31;
            // 
            // textBoxP
            // 
            this.textBoxP.BackColor = System.Drawing.Color.Black;
            this.textBoxP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxP.ForeColor = System.Drawing.Color.Lime;
            this.textBoxP.Location = new System.Drawing.Point(71, 396);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(281, 21);
            this.textBoxP.TabIndex = 32;
            // 
            // textBoxPRI
            // 
            this.textBoxPRI.BackColor = System.Drawing.Color.Black;
            this.textBoxPRI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPRI.ForeColor = System.Drawing.Color.Lime;
            this.textBoxPRI.Location = new System.Drawing.Point(160, 422);
            this.textBoxPRI.Name = "textBoxPRI";
            this.textBoxPRI.Size = new System.Drawing.Size(192, 21);
            this.textBoxPRI.TabIndex = 33;
            // 
            // textBoxPRS
            // 
            this.textBoxPRS.BackColor = System.Drawing.Color.Black;
            this.textBoxPRS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPRS.ForeColor = System.Drawing.Color.Lime;
            this.textBoxPRS.Location = new System.Drawing.Point(160, 449);
            this.textBoxPRS.Name = "textBoxPRS";
            this.textBoxPRS.Size = new System.Drawing.Size(192, 21);
            this.textBoxPRS.TabIndex = 34;
            // 
            // textBoxPQDauer
            // 
            this.textBoxPQDauer.BackColor = System.Drawing.Color.Black;
            this.textBoxPQDauer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPQDauer.ForeColor = System.Drawing.Color.Lime;
            this.textBoxPQDauer.Location = new System.Drawing.Point(160, 476);
            this.textBoxPQDauer.Name = "textBoxPQDauer";
            this.textBoxPQDauer.Size = new System.Drawing.Size(192, 21);
            this.textBoxPQDauer.TabIndex = 35;
            // 
            // textBoxQRSDauer
            // 
            this.textBoxQRSDauer.BackColor = System.Drawing.Color.Black;
            this.textBoxQRSDauer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQRSDauer.ForeColor = System.Drawing.Color.Lime;
            this.textBoxQRSDauer.Location = new System.Drawing.Point(160, 503);
            this.textBoxQRSDauer.Name = "textBoxQRSDauer";
            this.textBoxQRSDauer.Size = new System.Drawing.Size(192, 21);
            this.textBoxQRSDauer.TabIndex = 36;
            // 
            // textBoxQTDauer
            // 
            this.textBoxQTDauer.BackColor = System.Drawing.Color.Black;
            this.textBoxQTDauer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQTDauer.ForeColor = System.Drawing.Color.Lime;
            this.textBoxQTDauer.Location = new System.Drawing.Point(160, 530);
            this.textBoxQTDauer.Name = "textBoxQTDauer";
            this.textBoxQTDauer.Size = new System.Drawing.Size(192, 21);
            this.textBoxQTDauer.TabIndex = 37;
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.Black;
            this.buttonLoad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonLoad.Location = new System.Drawing.Point(71, 62);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(121, 23);
            this.buttonLoad.TabIndex = 38;
            this.buttonLoad.Text = "load 24h Data";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(198, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "start save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewECG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1171, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxQTDauer);
            this.Controls.Add(this.textBoxQRSDauer);
            this.Controls.Add(this.textBoxPQDauer);
            this.Controls.Add(this.textBoxPRS);
            this.Controls.Add(this.textBoxPRI);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.textBoxAVBIII);
            this.Controls.Add(this.textBoxAVBII);
            this.Controls.Add(this.textBoxAVBI);
            this.Controls.Add(this.textBoxSVES);
            this.Controls.Add(this.textBoxVES);
            this.Controls.Add(this.textBoxSTEMI);
            this.Controls.Add(this.textBoxSinusbradykardie);
            this.Controls.Add(this.textBoxSinusTachykardie);
            this.Controls.Add(this.textBoxRythmus);
            this.Controls.Add(this.textBoxFrequenz);
            this.Controls.Add(this.textBoxLagetyp);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStartLiveData);
            this.Controls.Add(this.comboBoxCOMPorts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewECG";
            this.Text = "EKG-Viewer 0.1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCOMPorts;
        private System.IO.Ports.SerialPort serialPortalt;
        private System.Windows.Forms.Button buttonStartLiveData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxLagetyp;
        private System.Windows.Forms.TextBox textBoxFrequenz;
        private System.Windows.Forms.TextBox textBoxRythmus;
        private System.Windows.Forms.TextBox textBoxSinusTachykardie;
        private System.Windows.Forms.TextBox textBoxSinusbradykardie;
        private System.Windows.Forms.TextBox textBoxSTEMI;
        private System.Windows.Forms.TextBox textBoxVES;
        private System.Windows.Forms.TextBox textBoxSVES;
        private System.Windows.Forms.TextBox textBoxAVBI;
        private System.Windows.Forms.TextBox textBoxAVBII;
        private System.Windows.Forms.TextBox textBoxAVBIII;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxPRI;
        private System.Windows.Forms.TextBox textBoxPRS;
        private System.Windows.Forms.TextBox textBoxPQDauer;
        private System.Windows.Forms.TextBox textBoxQRSDauer;
        private System.Windows.Forms.TextBox textBoxQTDauer;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button button1;
    }
}

