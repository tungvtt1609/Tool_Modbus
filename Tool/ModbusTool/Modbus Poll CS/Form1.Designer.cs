namespace Modbus_Poll_CS
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBaudrate = new System.Windows.Forms.ComboBox();
            this.lstPorts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStartAddr = new System.Windows.Forms.TextBox();
            this.txtSlaveID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl_value = new System.Windows.Forms.TabControl();
            this.tabPage_Signal = new System.Windows.Forms.TabPage();
            this.lbl_status = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Vbus = new System.Windows.Forms.TextBox();
            this.textBox_ErrCode = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.textBox_e_total = new System.Windows.Forms.TextBox();
            this.textBox_temp = new System.Windows.Forms.TextBox();
            this.textBox_ileak = new System.Windows.Forms.TextBox();
            this.textBox_ipv2 = new System.Windows.Forms.TextBox();
            this.textBox_vpv2 = new System.Windows.Forms.TextBox();
            this.textBox_ipv1 = new System.Windows.Forms.TextBox();
            this.textBox_vpv1 = new System.Windows.Forms.TextBox();
            this.textBox_Pf = new System.Windows.Forms.TextBox();
            this.textBox_Freq = new System.Windows.Forms.TextBox();
            this.textBox_Irms = new System.Windows.Forms.TextBox();
            this.textBox_Vrms = new System.Windows.Forms.TextBox();
            this.textBox_Pmax = new System.Windows.Forms.TextBox();
            this.textBox_Pout = new System.Windows.Forms.TextBox();
            this.textBox_Pin = new System.Windows.Forms.TextBox();
            this.textBox_etoday = new System.Windows.Forms.TextBox();
            this.tabPage_Coff = new System.Windows.Forms.TabPage();
            this.button_restore_data = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.button_set_gain_vbus = new System.Windows.Forms.Button();
            this.button_set_offset_vbus = new System.Windows.Forms.Button();
            this.textBox_gain_vbus = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox_offset_vbus = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button_set_gain_ileak = new System.Windows.Forms.Button();
            this.button1_set_offset_ileak = new System.Windows.Forms.Button();
            this.textBox_gain_ileak = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox_offset_ileak = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button_set_gain_vac = new System.Windows.Forms.Button();
            this.button_set_offset_vac = new System.Windows.Forms.Button();
            this.textBox_gain_vac = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_offset_vac = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button_set_gain_igrid = new System.Windows.Forms.Button();
            this.button_set_offset_igrid = new System.Windows.Forms.Button();
            this.textBox_gain_igrid = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_offset_igrid = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button_set_gain_vgrid = new System.Windows.Forms.Button();
            this.button_set_offset_vgrid = new System.Windows.Forms.Button();
            this.textBox_gain_vgrid = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_offset_vgrid = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button_set_gain_ipv2 = new System.Windows.Forms.Button();
            this.button_set_offset_ipv2 = new System.Windows.Forms.Button();
            this.textBox_gain_ipv2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_offset_ipv2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button_set_gain_vpv2 = new System.Windows.Forms.Button();
            this.button_set_offset_vpv2 = new System.Windows.Forms.Button();
            this.textBox_gain_vpv2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_offset_vpv2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_set_gain_ipv1 = new System.Windows.Forms.Button();
            this.button_set_offset_ipv1 = new System.Windows.Forms.Button();
            this.textBox_gain_ipv1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_offset_ipv1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button_set_gain_vpv1 = new System.Windows.Forms.Button();
            this.button_save_coef = new System.Windows.Forms.Button();
            this.button_ReadCoeff = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_set_offset_vpv1 = new System.Windows.Forms.Button();
            this.textBox_gain_vpv1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_offset_vpv1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage_controller = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.button_set_kp_pi = new System.Windows.Forms.Button();
            this.button_set_ki_pi = new System.Windows.Forms.Button();
            this.textBox_kp_pi = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.textBox_ki_pi = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.button_set_ki_pr9 = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox_ki_pr9 = new System.Windows.Forms.TextBox();
            this.button_set_ki_pr7 = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox_ki_pr7 = new System.Windows.Forms.TextBox();
            this.button_set_ki_pr5 = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox_ki_pr5 = new System.Windows.Forms.TextBox();
            this.button_set_ki_pr3 = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox_ki_pr3 = new System.Windows.Forms.TextBox();
            this.button_set_kp_pr = new System.Windows.Forms.Button();
            this.button_set_ki_pr1 = new System.Windows.Forms.Button();
            this.textBox_kp_pr = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox_ki_pr1 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.button_read_controller = new System.Windows.Forms.Button();
            this.button_apply_controller = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.button_set_kp_vol_loop = new System.Windows.Forms.Button();
            this.button_set_ki_vol_loop = new System.Windows.Forms.Button();
            this.textBox_kp_vol_loop = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox_ki_vol_loop = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.button28 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tabPage_graph = new System.Windows.Forms.TabPage();
            this.button_saveFile = new System.Windows.Forms.Button();
            this.comboBox_LineTHD = new System.Windows.Forms.ComboBox();
            this.chart_thd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_openMapFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.m_combo = new SergeUtils.EasyCompletionComboBox();
            this.cbbLineChart = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_timewaittrigger = new System.Windows.Forms.TextBox();
            this.checkBox_Trigger = new System.Windows.Forms.CheckBox();
            this.textBox_Trigger = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_scale = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.txtMaxChart4 = new System.Windows.Forms.TextBox();
            this.txtMinChart4 = new System.Windows.Forms.TextBox();
            this.txtMaxChart3 = new System.Windows.Forms.TextBox();
            this.txtMinChart3 = new System.Windows.Forms.TextBox();
            this.txtMaxChart2 = new System.Windows.Forms.TextBox();
            this.txtMinChart2 = new System.Windows.Forms.TextBox();
            this.txtMaxChart1 = new System.Windows.Forms.TextBox();
            this.txtMinChart1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLineChart4 = new System.Windows.Forms.TextBox();
            this.txtLineChart3 = new System.Windows.Forms.TextBox();
            this.txtLineChart2 = new System.Windows.Forms.TextBox();
            this.txtLineChart1 = new System.Windows.Forms.TextBox();
            this.btnRunChart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_Data = new System.Windows.Forms.TabPage();
            this.label64 = new System.Windows.Forms.Label();
            this.textBox_logEnd = new System.Windows.Forms.TextBox();
            this.textBox_logStart = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.ReadLog = new System.Windows.Forms.Button();
            this.richTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button_ClearData = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_time_setup = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.button18 = new System.Windows.Forms.Button();
            this.label70 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.txtSerialReadSwKey = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.txtSerialReadInfo = new System.Windows.Forms.TextBox();
            this.txtSerialReadDvKey = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.button19 = new System.Windows.Forms.Button();
            this.label67 = new System.Windows.Forms.Label();
            this.textBoxSwKey = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.textBoxDevKey = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.tabPageCalibAdc = new System.Windows.Forms.TabPage();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.btnRelay = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.txtDuty = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.cbbParam = new System.Windows.Forms.ComboBox();
            this.txtCheckValue = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.txtGetAdc2 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.txtGetAdc1 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.label72 = new System.Windows.Forms.Label();
            this.txtParam1 = new System.Windows.Forms.TextBox();
            this.txtParam2 = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.tabPage_Config = new System.Windows.Forms.TabPage();
            this.button34 = new System.Windows.Forms.Button();
            this.textBox_version_config = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.button33 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.label79 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button29 = new System.Windows.Forms.Button();
            this.label80 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button30 = new System.Windows.Forms.Button();
            this.label81 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button31 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.button32 = new System.Windows.Forms.Button();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label76 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button27 = new System.Windows.Forms.Button();
            this.label75 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button21 = new System.Windows.Forms.Button();
            this.label74 = new System.Windows.Forms.Label();
            this.textBox_VMax = new System.Windows.Forms.TextBox();
            this.button20 = new System.Windows.Forms.Button();
            this.textBox_PGioiHan = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl_value.SuspendLayout();
            this.tabPage_Signal.SuspendLayout();
            this.tabPage_Coff.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage_controller.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tabPage_graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_thd)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage_Data.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.tabPageCalibAdc.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.tabPage_Config.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBaudrate);
            this.groupBox1.Controls.Add(this.lstPorts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Info";
            // 
            // lstBaudrate
            // 
            this.lstBaudrate.FormattingEnabled = true;
            this.lstBaudrate.Location = new System.Drawing.Point(90, 40);
            this.lstBaudrate.Name = "lstBaudrate";
            this.lstBaudrate.Size = new System.Drawing.Size(82, 21);
            this.lstBaudrate.TabIndex = 3;
            // 
            // lstPorts
            // 
            this.lstPorts.FormattingEnabled = true;
            this.lstPorts.Location = new System.Drawing.Point(90, 13);
            this.lstPorts.Name = "lstPorts";
            this.lstPorts.Size = new System.Drawing.Size(82, 21);
            this.lstPorts.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStartAddr);
            this.groupBox2.Controls.Add(this.txtSlaveID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Poll Info";
            // 
            // txtStartAddr
            // 
            this.txtStartAddr.Location = new System.Drawing.Point(90, 39);
            this.txtStartAddr.Name = "txtStartAddr";
            this.txtStartAddr.Size = new System.Drawing.Size(82, 20);
            this.txtStartAddr.TabIndex = 6;
            // 
            // txtSlaveID
            // 
            this.txtSlaveID.Location = new System.Drawing.Point(90, 13);
            this.txtSlaveID.Name = "txtSlaveID";
            this.txtSlaveID.Size = new System.Drawing.Size(82, 20);
            this.txtSlaveID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start Addr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Slave ID:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 166);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(82, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(109, 166);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(82, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 457);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1255, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";
            // 
            // tabControl_value
            // 
            this.tabControl_value.Controls.Add(this.tabPage_Signal);
            this.tabControl_value.Controls.Add(this.tabPage_Coff);
            this.tabControl_value.Controls.Add(this.tabPage_controller);
            this.tabControl_value.Controls.Add(this.tabPage_graph);
            this.tabControl_value.Controls.Add(this.tabPage_Data);
            this.tabControl_value.Controls.Add(this.tabPage1);
            this.tabControl_value.Controls.Add(this.tabPageCalibAdc);
            this.tabControl_value.Controls.Add(this.tabPage_Config);
            this.tabControl_value.Location = new System.Drawing.Point(205, 12);
            this.tabControl_value.Name = "tabControl_value";
            this.tabControl_value.SelectedIndex = 0;
            this.tabControl_value.Size = new System.Drawing.Size(1046, 437);
            this.tabControl_value.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_value.TabIndex = 7;
            this.tabControl_value.SelectedIndexChanged += new System.EventHandler(this.tabControl_value_SelectedIndexChanged);
            // 
            // tabPage_Signal
            // 
            this.tabPage_Signal.Controls.Add(this.lbl_status);
            this.tabPage_Signal.Controls.Add(this.status);
            this.tabPage_Signal.Controls.Add(this.label56);
            this.tabPage_Signal.Controls.Add(this.label55);
            this.tabPage_Signal.Controls.Add(this.label54);
            this.tabPage_Signal.Controls.Add(this.label53);
            this.tabPage_Signal.Controls.Add(this.label52);
            this.tabPage_Signal.Controls.Add(this.label51);
            this.tabPage_Signal.Controls.Add(this.label50);
            this.tabPage_Signal.Controls.Add(this.label49);
            this.tabPage_Signal.Controls.Add(this.label48);
            this.tabPage_Signal.Controls.Add(this.label47);
            this.tabPage_Signal.Controls.Add(this.label46);
            this.tabPage_Signal.Controls.Add(this.label45);
            this.tabPage_Signal.Controls.Add(this.label44);
            this.tabPage_Signal.Controls.Add(this.label43);
            this.tabPage_Signal.Controls.Add(this.label42);
            this.tabPage_Signal.Controls.Add(this.label41);
            this.tabPage_Signal.Controls.Add(this.label40);
            this.tabPage_Signal.Controls.Add(this.label39);
            this.tabPage_Signal.Controls.Add(this.label10);
            this.tabPage_Signal.Controls.Add(this.textBox_Vbus);
            this.tabPage_Signal.Controls.Add(this.textBox_ErrCode);
            this.tabPage_Signal.Controls.Add(this.textBox_date);
            this.tabPage_Signal.Controls.Add(this.textBox_time);
            this.tabPage_Signal.Controls.Add(this.textBox_e_total);
            this.tabPage_Signal.Controls.Add(this.textBox_temp);
            this.tabPage_Signal.Controls.Add(this.textBox_ileak);
            this.tabPage_Signal.Controls.Add(this.textBox_ipv2);
            this.tabPage_Signal.Controls.Add(this.textBox_vpv2);
            this.tabPage_Signal.Controls.Add(this.textBox_ipv1);
            this.tabPage_Signal.Controls.Add(this.textBox_vpv1);
            this.tabPage_Signal.Controls.Add(this.textBox_Pf);
            this.tabPage_Signal.Controls.Add(this.textBox_Freq);
            this.tabPage_Signal.Controls.Add(this.textBox_Irms);
            this.tabPage_Signal.Controls.Add(this.textBox_Vrms);
            this.tabPage_Signal.Controls.Add(this.textBox_Pmax);
            this.tabPage_Signal.Controls.Add(this.textBox_Pout);
            this.tabPage_Signal.Controls.Add(this.textBox_Pin);
            this.tabPage_Signal.Controls.Add(this.textBox_etoday);
            this.tabPage_Signal.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Signal.Name = "tabPage_Signal";
            this.tabPage_Signal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Signal.Size = new System.Drawing.Size(1038, 411);
            this.tabPage_Signal.TabIndex = 0;
            this.tabPage_Signal.Text = "Signal";
            this.tabPage_Signal.UseVisualStyleBackColor = true;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(915, 21);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(67, 17);
            this.lbl_status.TabIndex = 48;
            this.lbl_status.Text = "Connect";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Green;
            this.status.Location = new System.Drawing.Point(809, 21);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(54, 17);
            this.status.TabIndex = 47;
            this.status.Text = "Status";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(524, 55);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(45, 13);
            this.label56.TabIndex = 46;
            this.label56.Text = "ErrCode";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(26, 17);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(53, 13);
            this.label55.TabIndex = 45;
            this.label55.Text = "DateTime";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(340, 17);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(53, 13);
            this.label54.TabIndex = 44;
            this.label54.Text = " TimeRun";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(361, 228);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(38, 13);
            this.label53.TabIndex = 43;
            this.label53.Text = "ETotal";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(361, 186);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(34, 13);
            this.label52.TabIndex = 42;
            this.label52.Text = "Temp";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(361, 142);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(30, 13);
            this.label51.TabIndex = 41;
            this.label51.Text = "Ileak";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(361, 98);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(28, 13);
            this.label50.TabIndex = 40;
            this.label50.Text = "Ipv2";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(361, 55);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(32, 13);
            this.label49.TabIndex = 39;
            this.label49.Text = "Vpv2";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(197, 228);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(28, 13);
            this.label48.TabIndex = 38;
            this.label48.Text = "Ipv1";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(197, 186);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(32, 13);
            this.label47.TabIndex = 37;
            this.label47.Text = "Vpv1";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(197, 142);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(20, 13);
            this.label46.TabIndex = 36;
            this.label46.Text = "PF";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(197, 98);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(28, 13);
            this.label45.TabIndex = 35;
            this.label45.Text = "Freq";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(197, 55);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(26, 13);
            this.label44.TabIndex = 34;
            this.label44.Text = "Irms";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(524, 99);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(31, 13);
            this.label43.TabIndex = 33;
            this.label43.Text = "Vbus";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(26, 228);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(30, 13);
            this.label42.TabIndex = 32;
            this.label42.Text = "Vrms";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(26, 186);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(33, 13);
            this.label41.TabIndex = 31;
            this.label41.Text = "Pmax";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(26, 142);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(29, 13);
            this.label40.TabIndex = 30;
            this.label40.Text = "Pout";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(26, 98);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(22, 13);
            this.label39.TabIndex = 29;
            this.label39.Text = "Pin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Etoday";
            // 
            // textBox_Vbus
            // 
            this.textBox_Vbus.Location = new System.Drawing.Point(570, 96);
            this.textBox_Vbus.Name = "textBox_Vbus";
            this.textBox_Vbus.Size = new System.Drawing.Size(81, 20);
            this.textBox_Vbus.TabIndex = 18;
            // 
            // textBox_ErrCode
            // 
            this.textBox_ErrCode.Location = new System.Drawing.Point(570, 52);
            this.textBox_ErrCode.Name = "textBox_ErrCode";
            this.textBox_ErrCode.Size = new System.Drawing.Size(81, 20);
            this.textBox_ErrCode.TabIndex = 17;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(85, 14);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(170, 20);
            this.textBox_date.TabIndex = 16;
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(399, 14);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(81, 20);
            this.textBox_time.TabIndex = 15;
            // 
            // textBox_e_total
            // 
            this.textBox_e_total.Location = new System.Drawing.Point(399, 225);
            this.textBox_e_total.Name = "textBox_e_total";
            this.textBox_e_total.Size = new System.Drawing.Size(81, 20);
            this.textBox_e_total.TabIndex = 14;
            // 
            // textBox_temp
            // 
            this.textBox_temp.Location = new System.Drawing.Point(399, 183);
            this.textBox_temp.Name = "textBox_temp";
            this.textBox_temp.Size = new System.Drawing.Size(81, 20);
            this.textBox_temp.TabIndex = 13;
            // 
            // textBox_ileak
            // 
            this.textBox_ileak.Location = new System.Drawing.Point(399, 139);
            this.textBox_ileak.Name = "textBox_ileak";
            this.textBox_ileak.Size = new System.Drawing.Size(81, 20);
            this.textBox_ileak.TabIndex = 12;
            // 
            // textBox_ipv2
            // 
            this.textBox_ipv2.Location = new System.Drawing.Point(399, 95);
            this.textBox_ipv2.Name = "textBox_ipv2";
            this.textBox_ipv2.Size = new System.Drawing.Size(81, 20);
            this.textBox_ipv2.TabIndex = 11;
            // 
            // textBox_vpv2
            // 
            this.textBox_vpv2.Location = new System.Drawing.Point(399, 52);
            this.textBox_vpv2.Name = "textBox_vpv2";
            this.textBox_vpv2.Size = new System.Drawing.Size(81, 20);
            this.textBox_vpv2.TabIndex = 10;
            // 
            // textBox_ipv1
            // 
            this.textBox_ipv1.Location = new System.Drawing.Point(234, 225);
            this.textBox_ipv1.Name = "textBox_ipv1";
            this.textBox_ipv1.Size = new System.Drawing.Size(81, 20);
            this.textBox_ipv1.TabIndex = 9;
            // 
            // textBox_vpv1
            // 
            this.textBox_vpv1.Location = new System.Drawing.Point(234, 183);
            this.textBox_vpv1.Name = "textBox_vpv1";
            this.textBox_vpv1.Size = new System.Drawing.Size(81, 20);
            this.textBox_vpv1.TabIndex = 8;
            // 
            // textBox_Pf
            // 
            this.textBox_Pf.Location = new System.Drawing.Point(232, 139);
            this.textBox_Pf.Name = "textBox_Pf";
            this.textBox_Pf.Size = new System.Drawing.Size(81, 20);
            this.textBox_Pf.TabIndex = 7;
            // 
            // textBox_Freq
            // 
            this.textBox_Freq.Location = new System.Drawing.Point(234, 95);
            this.textBox_Freq.Name = "textBox_Freq";
            this.textBox_Freq.Size = new System.Drawing.Size(81, 20);
            this.textBox_Freq.TabIndex = 6;
            // 
            // textBox_Irms
            // 
            this.textBox_Irms.Location = new System.Drawing.Point(234, 52);
            this.textBox_Irms.Name = "textBox_Irms";
            this.textBox_Irms.Size = new System.Drawing.Size(81, 20);
            this.textBox_Irms.TabIndex = 5;
            // 
            // textBox_Vrms
            // 
            this.textBox_Vrms.Location = new System.Drawing.Point(72, 225);
            this.textBox_Vrms.Name = "textBox_Vrms";
            this.textBox_Vrms.Size = new System.Drawing.Size(81, 20);
            this.textBox_Vrms.TabIndex = 4;
            // 
            // textBox_Pmax
            // 
            this.textBox_Pmax.Location = new System.Drawing.Point(72, 183);
            this.textBox_Pmax.Name = "textBox_Pmax";
            this.textBox_Pmax.Size = new System.Drawing.Size(81, 20);
            this.textBox_Pmax.TabIndex = 3;
            // 
            // textBox_Pout
            // 
            this.textBox_Pout.Location = new System.Drawing.Point(72, 139);
            this.textBox_Pout.Name = "textBox_Pout";
            this.textBox_Pout.Size = new System.Drawing.Size(81, 20);
            this.textBox_Pout.TabIndex = 2;
            // 
            // textBox_Pin
            // 
            this.textBox_Pin.Location = new System.Drawing.Point(72, 95);
            this.textBox_Pin.Name = "textBox_Pin";
            this.textBox_Pin.Size = new System.Drawing.Size(81, 20);
            this.textBox_Pin.TabIndex = 1;
            // 
            // textBox_etoday
            // 
            this.textBox_etoday.Location = new System.Drawing.Point(72, 52);
            this.textBox_etoday.Name = "textBox_etoday";
            this.textBox_etoday.Size = new System.Drawing.Size(81, 20);
            this.textBox_etoday.TabIndex = 0;
            // 
            // tabPage_Coff
            // 
            this.tabPage_Coff.Controls.Add(this.button_restore_data);
            this.tabPage_Coff.Controls.Add(this.groupBox12);
            this.tabPage_Coff.Controls.Add(this.groupBox11);
            this.tabPage_Coff.Controls.Add(this.groupBox10);
            this.tabPage_Coff.Controls.Add(this.groupBox9);
            this.tabPage_Coff.Controls.Add(this.groupBox8);
            this.tabPage_Coff.Controls.Add(this.groupBox7);
            this.tabPage_Coff.Controls.Add(this.groupBox6);
            this.tabPage_Coff.Controls.Add(this.groupBox5);
            this.tabPage_Coff.Controls.Add(this.button_set_gain_vpv1);
            this.tabPage_Coff.Controls.Add(this.button_save_coef);
            this.tabPage_Coff.Controls.Add(this.button_ReadCoeff);
            this.tabPage_Coff.Controls.Add(this.groupBox4);
            this.tabPage_Coff.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Coff.Name = "tabPage_Coff";
            this.tabPage_Coff.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Coff.Size = new System.Drawing.Size(1038, 411);
            this.tabPage_Coff.TabIndex = 1;
            this.tabPage_Coff.Text = "Coeff";
            this.tabPage_Coff.UseVisualStyleBackColor = true;
            // 
            // button_restore_data
            // 
            this.button_restore_data.Location = new System.Drawing.Point(562, 345);
            this.button_restore_data.Name = "button_restore_data";
            this.button_restore_data.Size = new System.Drawing.Size(75, 23);
            this.button_restore_data.TabIndex = 39;
            this.button_restore_data.Text = "Restore";
            this.button_restore_data.UseVisualStyleBackColor = true;
            this.button_restore_data.Click += new System.EventHandler(this.button_restore_data_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.button_set_gain_vbus);
            this.groupBox12.Controls.Add(this.button_set_offset_vbus);
            this.groupBox12.Controls.Add(this.textBox_gain_vbus);
            this.groupBox12.Controls.Add(this.label27);
            this.groupBox12.Controls.Add(this.textBox_offset_vbus);
            this.groupBox12.Controls.Add(this.label28);
            this.groupBox12.Location = new System.Drawing.Point(20, 267);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(200, 117);
            this.groupBox12.TabIndex = 38;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "VBus";
            // 
            // button_set_gain_vbus
            // 
            this.button_set_gain_vbus.Location = new System.Drawing.Point(161, 28);
            this.button_set_gain_vbus.Name = "button_set_gain_vbus";
            this.button_set_gain_vbus.Size = new System.Drawing.Size(33, 23);
            this.button_set_gain_vbus.TabIndex = 37;
            this.button_set_gain_vbus.Text = "W";
            this.button_set_gain_vbus.UseVisualStyleBackColor = true;
            this.button_set_gain_vbus.Click += new System.EventHandler(this.button_set_gain_vbus_Click);
            // 
            // button_set_offset_vbus
            // 
            this.button_set_offset_vbus.Location = new System.Drawing.Point(161, 64);
            this.button_set_offset_vbus.Name = "button_set_offset_vbus";
            this.button_set_offset_vbus.Size = new System.Drawing.Size(33, 23);
            this.button_set_offset_vbus.TabIndex = 34;
            this.button_set_offset_vbus.Text = "W";
            this.button_set_offset_vbus.UseVisualStyleBackColor = true;
            this.button_set_offset_vbus.Click += new System.EventHandler(this.button_set_offset_vbus_Click);
            // 
            // textBox_gain_vbus
            // 
            this.textBox_gain_vbus.Location = new System.Drawing.Point(55, 29);
            this.textBox_gain_vbus.Name = "textBox_gain_vbus";
            this.textBox_gain_vbus.Size = new System.Drawing.Size(100, 20);
            this.textBox_gain_vbus.TabIndex = 5;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 70);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 13);
            this.label27.TabIndex = 26;
            this.label27.Text = "Offset";
            // 
            // textBox_offset_vbus
            // 
            this.textBox_offset_vbus.Location = new System.Drawing.Point(56, 68);
            this.textBox_offset_vbus.Name = "textBox_offset_vbus";
            this.textBox_offset_vbus.Size = new System.Drawing.Size(100, 20);
            this.textBox_offset_vbus.TabIndex = 6;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(12, 32);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 13);
            this.label28.TabIndex = 25;
            this.label28.Text = "Gain";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button_set_gain_ileak);
            this.groupBox11.Controls.Add(this.button1_set_offset_ileak);
            this.groupBox11.Controls.Add(this.textBox_gain_ileak);
            this.groupBox11.Controls.Add(this.label25);
            this.groupBox11.Controls.Add(this.textBox_offset_ileak);
            this.groupBox11.Controls.Add(this.label26);
            this.groupBox11.Location = new System.Drawing.Point(687, 149);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(200, 117);
            this.groupBox11.TabIndex = 35;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Ileak";
            // 
            // button_set_gain_ileak
            // 
            this.button_set_gain_ileak.Location = new System.Drawing.Point(161, 28);
            this.button_set_gain_ileak.Name = "button_set_gain_ileak";
            this.button_set_gain_ileak.Size = new System.Drawing.Size(33, 23);
            this.button_set_gain_ileak.TabIndex = 35;
            this.button_set_gain_ileak.Text = "W";
            this.button_set_gain_ileak.UseVisualStyleBackColor = true;
            this.button_set_gain_ileak.Click += new System.EventHandler(this.button_set_gain_ileak_Click);
            // 
            // button1_set_offset_ileak
            // 
            this.button1_set_offset_ileak.Location = new System.Drawing.Point(161, 64);
            this.button1_set_offset_ileak.Name = "button1_set_offset_ileak";
            this.button1_set_offset_ileak.Size = new System.Drawing.Size(33, 23);
            this.button1_set_offset_ileak.TabIndex = 34;
            this.button1_set_offset_ileak.Text = "W";
            this.button1_set_offset_ileak.UseVisualStyleBackColor = true;
            this.button1_set_offset_ileak.Click += new System.EventHandler(this.button1_set_offset_ileak_Click);
            // 
            // textBox_gain_ileak
            // 
            this.textBox_gain_ileak.Location = new System.Drawing.Point(55, 29);
            this.textBox_gain_ileak.Name = "textBox_gain_ileak";
            this.textBox_gain_ileak.Size = new System.Drawing.Size(100, 20);
            this.textBox_gain_ileak.TabIndex = 5;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(12, 70);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 13);
            this.label25.TabIndex = 26;
            this.label25.Text = "Offset";
            // 
            // textBox_offset_ileak
            // 
            this.textBox_offset_ileak.Location = new System.Drawing.Point(56, 68);
            this.textBox_offset_ileak.Name = "textBox_offset_ileak";
            this.textBox_offset_ileak.Size = new System.Drawing.Size(100, 20);
            this.textBox_offset_ileak.TabIndex = 6;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(12, 32);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 13);
            this.label26.TabIndex = 25;
            this.label26.Text = "Gain";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.button_set_gain_vac);
            this.groupBox10.Controls.Add(this.button_set_offset_vac);
            this.groupBox10.Controls.Add(this.textBox_gain_vac);
            this.groupBox10.Controls.Add(this.label23);
            this.groupBox10.Controls.Add(this.textBox_offset_vac);
            this.groupBox10.Controls.Add(this.label24);
            this.groupBox10.Location = new System.Drawing.Point(687, 21);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 117);
            this.groupBox10.TabIndex = 37;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Vac";
            // 
            // button_set_gain_vac
            // 
            this.button_set_gain_vac.Location = new System.Drawing.Point(161, 26);
            this.button_set_gain_vac.Name = "button_set_gain_vac";
            this.button_set_gain_vac.Size = new System.Drawing.Size(33, 23);
            this.button_set_gain_vac.TabIndex = 36;
            this.button_set_gain_vac.Text = "W";
            this.button_set_gain_vac.UseVisualStyleBackColor = true;
            this.button_set_gain_vac.Click += new System.EventHandler(this.button_set_gain_vac_Click);
            // 
            // button_set_offset_vac
            // 
            this.button_set_offset_vac.Location = new System.Drawing.Point(161, 64);
            this.button_set_offset_vac.Name = "button_set_offset_vac";
            this.button_set_offset_vac.Size = new System.Drawing.Size(33, 23);
            this.button_set_offset_vac.TabIndex = 34;
            this.button_set_offset_vac.Text = "W";
            this.button_set_offset_vac.UseVisualStyleBackColor = true;
            this.button_set_offset_vac.Click += new System.EventHandler(this.button_set_offset_vac_Click);
            // 
            // textBox_gain_vac
            // 
            this.textBox_gain_vac.Location = new System.Drawing.Point(55, 29);
            this.textBox_gain_vac.Name = "textBox_gain_vac";
            this.textBox_gain_vac.Size = new System.Drawing.Size(100, 20);
            this.textBox_gain_vac.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 70);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 13);
            this.label23.TabIndex = 26;
            this.label23.Text = "Offset";
            // 
            // textBox_offset_vac
            // 
            this.textBox_offset_vac.Location = new System.Drawing.Point(56, 68);
            this.textBox_offset_vac.Name = "textBox_offset_vac";
            this.textBox_offset_vac.Size = new System.Drawing.Size(100, 20);
            this.textBox_offset_vac.TabIndex = 6;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 32);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "Gain";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button_set_gain_igrid);
            this.groupBox9.Controls.Add(this.button_set_offset_igrid);
            this.groupBox9.Controls.Add(this.textBox_gain_igrid);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.textBox_offset_igrid);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Location = new System.Drawing.Point(466, 147);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 117);
            this.groupBox9.TabIndex = 35;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Igrid";
            // 
            // button_set_gain_igrid
            // 
            this.button_set_gain_igrid.Location = new System.Drawing.Point(161, 28);
            this.button_set_gain_igrid.Name = "button_set_gain_igrid";
            this.button_set_gain_igrid.Size = new System.Drawing.Size(33, 23);
            this.button_set_gain_igrid.TabIndex = 35;
            this.button_set_gain_igrid.Text = "W";
            this.button_set_gain_igrid.UseVisualStyleBackColor = true;
            this.button_set_gain_igrid.Click += new System.EventHandler(this.button_set_gain_igrid_Click);
            // 
            // button_set_offset_igrid
            // 
            this.button_set_offset_igrid.Location = new System.Drawing.Point(161, 64);
            this.button_set_offset_igrid.Name = "button_set_offset_igrid";
            this.button_set_offset_igrid.Size = new System.Drawing.Size(33, 23);
            this.button_set_offset_igrid.TabIndex = 34;
            this.button_set_offset_igrid.Text = "W";
            this.button_set_offset_igrid.UseVisualStyleBackColor = true;
            this.button_set_offset_igrid.Click += new System.EventHandler(this.button_set_offset_igrid_Click);
            // 
            // textBox_gain_igrid
            // 
            this.textBox_gain_igrid.Location = new System.Drawing.Point(55, 29);
            this.textBox_gain_igrid.Name = "textBox_gain_igrid";
            this.textBox_gain_igrid.Size = new System.Drawing.Size(100, 20);
            this.textBox_gain_igrid.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "Offset";
            // 
            // textBox_offset_igrid
            // 
            this.textBox_offset_igrid.Location = new System.Drawing.Point(56, 68);
            this.textBox_offset_igrid.Name = "textBox_offset_igrid";
            this.textBox_offset_igrid.Size = new System.Drawing.Size(100, 20);
            this.textBox_offset_igrid.TabIndex = 6;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "Gain";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button_set_gain_vgrid);
            this.groupBox8.Controls.Add(this.button_set_offset_vgrid);
            this.groupBox8.Controls.Add(this.textBox_gain_vgrid);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.textBox_offset_vgrid);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Location = new System.Drawing.Point(466, 21);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 117);
            this.groupBox8.TabIndex = 36;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Vgrid";
            // 
            // button_set_gain_vgrid
            // 
            this.button_set_gain_vgrid.Location = new System.Drawing.Point(161, 26);
            this.button_set_gain_vgrid.Name = "button_set_gain_vgrid";
            this.button_set_gain_vgrid.Size = new System.Drawing.Size(33, 23);
            this.button_set_gain_vgrid.TabIndex = 35;
            this.button_set_gain_vgrid.Text = "W";
            this.button_set_gain_vgrid.UseVisualStyleBackColor = true;
            this.button_set_gain_vgrid.Click += new System.EventHandler(this.button_set_gain_vgrid_Click);
            // 
            // button_set_offset_vgrid
            // 
            this.button_set_offset_vgrid.Location = new System.Drawing.Point(161, 64);
            this.button_set_offset_vgrid.Name = "button_set_offset_vgrid";
            this.button_set_offset_vgrid.Size = new System.Drawing.Size(33, 23);
            this.button_set_offset_vgrid.TabIndex = 34;
            this.button_set_offset_vgrid.Text = "W";
            this.button_set_offset_vgrid.UseVisualStyleBackColor = true;
            this.button_set_offset_vgrid.Click += new System.EventHandler(this.button_set_offset_vgrid_Click);
            // 
            // textBox_gain_vgrid
            // 
            this.textBox_gain_vgrid.Location = new System.Drawing.Point(55, 29);
            this.textBox_gain_vgrid.Name = "textBox_gain_vgrid";
            this.textBox_gain_vgrid.Size = new System.Drawing.Size(100, 20);
            this.textBox_gain_vgrid.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 70);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "Offset";
            // 
            // textBox_offset_vgrid
            // 
            this.textBox_offset_vgrid.Location = new System.Drawing.Point(56, 68);
            this.textBox_offset_vgrid.Name = "textBox_offset_vgrid";
            this.textBox_offset_vgrid.Size = new System.Drawing.Size(100, 20);
            this.textBox_offset_vgrid.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "Gain";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button_set_gain_ipv2);
            this.groupBox7.Controls.Add(this.button_set_offset_ipv2);
            this.groupBox7.Controls.Add(this.textBox_gain_ipv2);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.textBox_offset_ipv2);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Location = new System.Drawing.Point(247, 144);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 117);
            this.groupBox7.TabIndex = 35;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ipv2";
            // 
            // button_set_gain_ipv2
            // 
            this.button_set_gain_ipv2.Location = new System.Drawing.Point(161, 27);
            this.button_set_gain_ipv2.Name = "button_set_gain_ipv2";
            this.button_set_gain_ipv2.Size = new System.Drawing.Size(33, 23);
            this.button_set_gain_ipv2.TabIndex = 35;
            this.button_set_gain_ipv2.Text = "W";
            this.button_set_gain_ipv2.UseVisualStyleBackColor = true;
            this.button_set_gain_ipv2.Click += new System.EventHandler(this.button_set_gain_ipv2_Click);
            // 
            // button_set_offset_ipv2
            // 
            this.button_set_offset_ipv2.Location = new System.Drawing.Point(161, 64);
            this.button_set_offset_ipv2.Name = "button_set_offset_ipv2";
            this.button_set_offset_ipv2.Size = new System.Drawing.Size(33, 23);
            this.button_set_offset_ipv2.TabIndex = 34;
            this.button_set_offset_ipv2.Text = "W";
            this.button_set_offset_ipv2.UseVisualStyleBackColor = true;
            this.button_set_offset_ipv2.Click += new System.EventHandler(this.button_set_offset_ipv2_Click);
            // 
            // textBox_gain_ipv2
            // 
            this.textBox_gain_ipv2.Location = new System.Drawing.Point(55, 29);
            this.textBox_gain_ipv2.Name = "textBox_gain_ipv2";
            this.textBox_gain_ipv2.Size = new System.Drawing.Size(100, 20);
            this.textBox_gain_ipv2.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Offset";
            // 
            // textBox_offset_ipv2
            // 
            this.textBox_offset_ipv2.Location = new System.Drawing.Point(56, 68);
            this.textBox_offset_ipv2.Name = "textBox_offset_ipv2";
            this.textBox_offset_ipv2.Size = new System.Drawing.Size(100, 20);
            this.textBox_offset_ipv2.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "Gain";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button_set_gain_vpv2);
            this.groupBox6.Controls.Add(this.button_set_offset_vpv2);
            this.groupBox6.Controls.Add(this.textBox_gain_vpv2);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.textBox_offset_vpv2);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Location = new System.Drawing.Point(247, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 117);
            this.groupBox6.TabIndex = 35;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Vpv2";
            // 
            // button_set_gain_vpv2
            // 
            this.button_set_gain_vpv2.Location = new System.Drawing.Point(161, 29);
            this.button_set_gain_vpv2.Name = "button_set_gain_vpv2";
            this.button_set_gain_vpv2.Size = new System.Drawing.Size(33, 23);
            this.button_set_gain_vpv2.TabIndex = 35;
            this.button_set_gain_vpv2.Text = "W";
            this.button_set_gain_vpv2.UseVisualStyleBackColor = true;
            this.button_set_gain_vpv2.Click += new System.EventHandler(this.button_set_gain_vpv2_Click);
            // 
            // button_set_offset_vpv2
            // 
            this.button_set_offset_vpv2.Location = new System.Drawing.Point(161, 64);
            this.button_set_offset_vpv2.Name = "button_set_offset_vpv2";
            this.button_set_offset_vpv2.Size = new System.Drawing.Size(33, 23);
            this.button_set_offset_vpv2.TabIndex = 34;
            this.button_set_offset_vpv2.Text = "W";
            this.button_set_offset_vpv2.UseVisualStyleBackColor = true;
            this.button_set_offset_vpv2.Click += new System.EventHandler(this.button_set_offset_vpv2_Click);
            // 
            // textBox_gain_vpv2
            // 
            this.textBox_gain_vpv2.Location = new System.Drawing.Point(55, 29);
            this.textBox_gain_vpv2.Name = "textBox_gain_vpv2";
            this.textBox_gain_vpv2.Size = new System.Drawing.Size(100, 20);
            this.textBox_gain_vpv2.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Offset";
            // 
            // textBox_offset_vpv2
            // 
            this.textBox_offset_vpv2.Location = new System.Drawing.Point(56, 68);
            this.textBox_offset_vpv2.Name = "textBox_offset_vpv2";
            this.textBox_offset_vpv2.Size = new System.Drawing.Size(100, 20);
            this.textBox_offset_vpv2.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Gain";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_set_gain_ipv1);
            this.groupBox5.Controls.Add(this.button_set_offset_ipv1);
            this.groupBox5.Controls.Add(this.textBox_gain_ipv1);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.textBox_offset_ipv1);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(20, 144);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 117);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ipv1";
            // 
            // button_set_gain_ipv1
            // 
            this.button_set_gain_ipv1.Location = new System.Drawing.Point(161, 29);
            this.button_set_gain_ipv1.Name = "button_set_gain_ipv1";
            this.button_set_gain_ipv1.Size = new System.Drawing.Size(33, 23);
            this.button_set_gain_ipv1.TabIndex = 35;
            this.button_set_gain_ipv1.Text = "W";
            this.button_set_gain_ipv1.UseVisualStyleBackColor = true;
            this.button_set_gain_ipv1.Click += new System.EventHandler(this.button_set_gain_ipv1_Click);
            // 
            // button_set_offset_ipv1
            // 
            this.button_set_offset_ipv1.Location = new System.Drawing.Point(161, 64);
            this.button_set_offset_ipv1.Name = "button_set_offset_ipv1";
            this.button_set_offset_ipv1.Size = new System.Drawing.Size(33, 23);
            this.button_set_offset_ipv1.TabIndex = 34;
            this.button_set_offset_ipv1.Text = "W";
            this.button_set_offset_ipv1.UseVisualStyleBackColor = true;
            this.button_set_offset_ipv1.Click += new System.EventHandler(this.button_set_offset_ipv1_Click);
            // 
            // textBox_gain_ipv1
            // 
            this.textBox_gain_ipv1.Location = new System.Drawing.Point(55, 29);
            this.textBox_gain_ipv1.Name = "textBox_gain_ipv1";
            this.textBox_gain_ipv1.Size = new System.Drawing.Size(100, 20);
            this.textBox_gain_ipv1.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Offset";
            // 
            // textBox_offset_ipv1
            // 
            this.textBox_offset_ipv1.Location = new System.Drawing.Point(56, 68);
            this.textBox_offset_ipv1.Name = "textBox_offset_ipv1";
            this.textBox_offset_ipv1.Size = new System.Drawing.Size(100, 20);
            this.textBox_offset_ipv1.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Gain";
            // 
            // button_set_gain_vpv1
            // 
            this.button_set_gain_vpv1.Location = new System.Drawing.Point(181, 49);
            this.button_set_gain_vpv1.Name = "button_set_gain_vpv1";
            this.button_set_gain_vpv1.Size = new System.Drawing.Size(33, 23);
            this.button_set_gain_vpv1.TabIndex = 33;
            this.button_set_gain_vpv1.Text = "W";
            this.button_set_gain_vpv1.UseVisualStyleBackColor = true;
            this.button_set_gain_vpv1.Click += new System.EventHandler(this.button_set_gain_vpv1_Click);
            // 
            // button_save_coef
            // 
            this.button_save_coef.Location = new System.Drawing.Point(466, 345);
            this.button_save_coef.Name = "button_save_coef";
            this.button_save_coef.Size = new System.Drawing.Size(75, 23);
            this.button_save_coef.TabIndex = 32;
            this.button_save_coef.Text = "Save";
            this.button_save_coef.UseVisualStyleBackColor = true;
            this.button_save_coef.Click += new System.EventHandler(this.button_save_coef_Click);
            // 
            // button_ReadCoeff
            // 
            this.button_ReadCoeff.Location = new System.Drawing.Point(385, 345);
            this.button_ReadCoeff.Name = "button_ReadCoeff";
            this.button_ReadCoeff.Size = new System.Drawing.Size(75, 23);
            this.button_ReadCoeff.TabIndex = 31;
            this.button_ReadCoeff.Text = "ReadAll";
            this.button_ReadCoeff.UseVisualStyleBackColor = true;
            this.button_ReadCoeff.Click += new System.EventHandler(this.button_ReadCoeff_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_set_offset_vpv1);
            this.groupBox4.Controls.Add(this.textBox_gain_vpv1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBox_offset_vpv1);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(20, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 117);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vpv1";
            // 
            // button_set_offset_vpv1
            // 
            this.button_set_offset_vpv1.Location = new System.Drawing.Point(161, 64);
            this.button_set_offset_vpv1.Name = "button_set_offset_vpv1";
            this.button_set_offset_vpv1.Size = new System.Drawing.Size(33, 23);
            this.button_set_offset_vpv1.TabIndex = 34;
            this.button_set_offset_vpv1.Text = "W";
            this.button_set_offset_vpv1.UseVisualStyleBackColor = true;
            this.button_set_offset_vpv1.Click += new System.EventHandler(this.button_set_offset_vpv1_Click);
            // 
            // textBox_gain_vpv1
            // 
            this.textBox_gain_vpv1.Location = new System.Drawing.Point(55, 29);
            this.textBox_gain_vpv1.Name = "textBox_gain_vpv1";
            this.textBox_gain_vpv1.Size = new System.Drawing.Size(100, 20);
            this.textBox_gain_vpv1.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Offset";
            // 
            // textBox_offset_vpv1
            // 
            this.textBox_offset_vpv1.Location = new System.Drawing.Point(56, 68);
            this.textBox_offset_vpv1.Name = "textBox_offset_vpv1";
            this.textBox_offset_vpv1.Size = new System.Drawing.Size(100, 20);
            this.textBox_offset_vpv1.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Gain";
            // 
            // tabPage_controller
            // 
            this.tabPage_controller.Controls.Add(this.groupBox15);
            this.tabPage_controller.Controls.Add(this.button_read_controller);
            this.tabPage_controller.Controls.Add(this.button_apply_controller);
            this.tabPage_controller.Controls.Add(this.groupBox14);
            this.tabPage_controller.Controls.Add(this.groupBox13);
            this.tabPage_controller.Location = new System.Drawing.Point(4, 22);
            this.tabPage_controller.Name = "tabPage_controller";
            this.tabPage_controller.Size = new System.Drawing.Size(1038, 411);
            this.tabPage_controller.TabIndex = 3;
            this.tabPage_controller.Text = "Controller";
            this.tabPage_controller.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.button_set_kp_pi);
            this.groupBox15.Controls.Add(this.button_set_ki_pi);
            this.groupBox15.Controls.Add(this.textBox_kp_pi);
            this.groupBox15.Controls.Add(this.label62);
            this.groupBox15.Controls.Add(this.textBox_ki_pi);
            this.groupBox15.Controls.Add(this.label63);
            this.groupBox15.Controls.Add(this.button_set_ki_pr9);
            this.groupBox15.Controls.Add(this.label38);
            this.groupBox15.Controls.Add(this.textBox_ki_pr9);
            this.groupBox15.Controls.Add(this.button_set_ki_pr7);
            this.groupBox15.Controls.Add(this.label37);
            this.groupBox15.Controls.Add(this.textBox_ki_pr7);
            this.groupBox15.Controls.Add(this.button_set_ki_pr5);
            this.groupBox15.Controls.Add(this.label36);
            this.groupBox15.Controls.Add(this.textBox_ki_pr5);
            this.groupBox15.Controls.Add(this.button_set_ki_pr3);
            this.groupBox15.Controls.Add(this.label35);
            this.groupBox15.Controls.Add(this.textBox_ki_pr3);
            this.groupBox15.Controls.Add(this.button_set_kp_pr);
            this.groupBox15.Controls.Add(this.button_set_ki_pr1);
            this.groupBox15.Controls.Add(this.textBox_kp_pr);
            this.groupBox15.Controls.Add(this.label33);
            this.groupBox15.Controls.Add(this.textBox_ki_pr1);
            this.groupBox15.Controls.Add(this.label34);
            this.groupBox15.Location = new System.Drawing.Point(555, 21);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(440, 283);
            this.groupBox15.TabIndex = 30;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Current Loop";
            // 
            // button_set_kp_pi
            // 
            this.button_set_kp_pi.Location = new System.Drawing.Point(385, 31);
            this.button_set_kp_pi.Name = "button_set_kp_pi";
            this.button_set_kp_pi.Size = new System.Drawing.Size(33, 23);
            this.button_set_kp_pi.TabIndex = 53;
            this.button_set_kp_pi.Text = "W";
            this.button_set_kp_pi.UseVisualStyleBackColor = true;
            this.button_set_kp_pi.Click += new System.EventHandler(this.button_set_kp_pi_Click);
            // 
            // button_set_ki_pi
            // 
            this.button_set_ki_pi.Location = new System.Drawing.Point(385, 69);
            this.button_set_ki_pi.Name = "button_set_ki_pi";
            this.button_set_ki_pi.Size = new System.Drawing.Size(33, 23);
            this.button_set_ki_pi.TabIndex = 52;
            this.button_set_ki_pi.Text = "W";
            this.button_set_ki_pi.UseVisualStyleBackColor = true;
            this.button_set_ki_pi.Click += new System.EventHandler(this.button_set_ki_pi_Click);
            // 
            // textBox_kp_pi
            // 
            this.textBox_kp_pi.Location = new System.Drawing.Point(279, 32);
            this.textBox_kp_pi.Name = "textBox_kp_pi";
            this.textBox_kp_pi.Size = new System.Drawing.Size(100, 20);
            this.textBox_kp_pi.TabIndex = 48;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(236, 73);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(16, 13);
            this.label62.TabIndex = 51;
            this.label62.Text = "Ki";
            // 
            // textBox_ki_pi
            // 
            this.textBox_ki_pi.Location = new System.Drawing.Point(280, 71);
            this.textBox_ki_pi.Name = "textBox_ki_pi";
            this.textBox_ki_pi.Size = new System.Drawing.Size(100, 20);
            this.textBox_ki_pi.TabIndex = 49;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(236, 35);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(20, 13);
            this.label63.TabIndex = 50;
            this.label63.Text = "Kp";
            // 
            // button_set_ki_pr9
            // 
            this.button_set_ki_pr9.Location = new System.Drawing.Point(161, 229);
            this.button_set_ki_pr9.Name = "button_set_ki_pr9";
            this.button_set_ki_pr9.Size = new System.Drawing.Size(33, 23);
            this.button_set_ki_pr9.TabIndex = 47;
            this.button_set_ki_pr9.Text = "W";
            this.button_set_ki_pr9.UseVisualStyleBackColor = true;
            this.button_set_ki_pr9.Click += new System.EventHandler(this.button_set_ki_pr9_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(12, 233);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(23, 13);
            this.label38.TabIndex = 46;
            this.label38.Text = "Kr9";
            // 
            // textBox_ki_pr9
            // 
            this.textBox_ki_pr9.Location = new System.Drawing.Point(56, 231);
            this.textBox_ki_pr9.Name = "textBox_ki_pr9";
            this.textBox_ki_pr9.Size = new System.Drawing.Size(100, 20);
            this.textBox_ki_pr9.TabIndex = 45;
            // 
            // button_set_ki_pr7
            // 
            this.button_set_ki_pr7.Location = new System.Drawing.Point(161, 197);
            this.button_set_ki_pr7.Name = "button_set_ki_pr7";
            this.button_set_ki_pr7.Size = new System.Drawing.Size(33, 23);
            this.button_set_ki_pr7.TabIndex = 44;
            this.button_set_ki_pr7.Text = "W";
            this.button_set_ki_pr7.UseVisualStyleBackColor = true;
            this.button_set_ki_pr7.Click += new System.EventHandler(this.button_set_ki_pr7_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(12, 201);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(23, 13);
            this.label37.TabIndex = 43;
            this.label37.Text = "Kr7";
            // 
            // textBox_ki_pr7
            // 
            this.textBox_ki_pr7.Location = new System.Drawing.Point(56, 199);
            this.textBox_ki_pr7.Name = "textBox_ki_pr7";
            this.textBox_ki_pr7.Size = new System.Drawing.Size(100, 20);
            this.textBox_ki_pr7.TabIndex = 42;
            // 
            // button_set_ki_pr5
            // 
            this.button_set_ki_pr5.Location = new System.Drawing.Point(161, 162);
            this.button_set_ki_pr5.Name = "button_set_ki_pr5";
            this.button_set_ki_pr5.Size = new System.Drawing.Size(33, 23);
            this.button_set_ki_pr5.TabIndex = 41;
            this.button_set_ki_pr5.Text = "W";
            this.button_set_ki_pr5.UseVisualStyleBackColor = true;
            this.button_set_ki_pr5.Click += new System.EventHandler(this.button_set_ki_pr5_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(12, 166);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(23, 13);
            this.label36.TabIndex = 40;
            this.label36.Text = "Kr5";
            // 
            // textBox_ki_pr5
            // 
            this.textBox_ki_pr5.Location = new System.Drawing.Point(56, 164);
            this.textBox_ki_pr5.Name = "textBox_ki_pr5";
            this.textBox_ki_pr5.Size = new System.Drawing.Size(100, 20);
            this.textBox_ki_pr5.TabIndex = 39;
            // 
            // button_set_ki_pr3
            // 
            this.button_set_ki_pr3.Location = new System.Drawing.Point(161, 126);
            this.button_set_ki_pr3.Name = "button_set_ki_pr3";
            this.button_set_ki_pr3.Size = new System.Drawing.Size(33, 23);
            this.button_set_ki_pr3.TabIndex = 38;
            this.button_set_ki_pr3.Text = "W";
            this.button_set_ki_pr3.UseVisualStyleBackColor = true;
            this.button_set_ki_pr3.Click += new System.EventHandler(this.button_set_ki_pr3_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(12, 130);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(23, 13);
            this.label35.TabIndex = 37;
            this.label35.Text = "Kr3";
            // 
            // textBox_ki_pr3
            // 
            this.textBox_ki_pr3.Location = new System.Drawing.Point(56, 128);
            this.textBox_ki_pr3.Name = "textBox_ki_pr3";
            this.textBox_ki_pr3.Size = new System.Drawing.Size(100, 20);
            this.textBox_ki_pr3.TabIndex = 36;
            // 
            // button_set_kp_pr
            // 
            this.button_set_kp_pr.Location = new System.Drawing.Point(161, 28);
            this.button_set_kp_pr.Name = "button_set_kp_pr";
            this.button_set_kp_pr.Size = new System.Drawing.Size(33, 23);
            this.button_set_kp_pr.TabIndex = 35;
            this.button_set_kp_pr.Text = "W";
            this.button_set_kp_pr.UseVisualStyleBackColor = true;
            this.button_set_kp_pr.Click += new System.EventHandler(this.button_set_kp_pr_Click);
            // 
            // button_set_ki_pr1
            // 
            this.button_set_ki_pr1.Location = new System.Drawing.Point(161, 66);
            this.button_set_ki_pr1.Name = "button_set_ki_pr1";
            this.button_set_ki_pr1.Size = new System.Drawing.Size(33, 23);
            this.button_set_ki_pr1.TabIndex = 34;
            this.button_set_ki_pr1.Text = "W";
            this.button_set_ki_pr1.UseVisualStyleBackColor = true;
            this.button_set_ki_pr1.Click += new System.EventHandler(this.button_set_ki_pr1_Click);
            // 
            // textBox_kp_pr
            // 
            this.textBox_kp_pr.Location = new System.Drawing.Point(55, 29);
            this.textBox_kp_pr.Name = "textBox_kp_pr";
            this.textBox_kp_pr.Size = new System.Drawing.Size(100, 20);
            this.textBox_kp_pr.TabIndex = 5;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(12, 70);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(23, 13);
            this.label33.TabIndex = 26;
            this.label33.Text = "Kr1";
            // 
            // textBox_ki_pr1
            // 
            this.textBox_ki_pr1.Location = new System.Drawing.Point(56, 68);
            this.textBox_ki_pr1.Name = "textBox_ki_pr1";
            this.textBox_ki_pr1.Size = new System.Drawing.Size(100, 20);
            this.textBox_ki_pr1.TabIndex = 6;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(12, 32);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(20, 13);
            this.label34.TabIndex = 25;
            this.label34.Text = "Kp";
            // 
            // button_read_controller
            // 
            this.button_read_controller.Location = new System.Drawing.Point(50, 326);
            this.button_read_controller.Name = "button_read_controller";
            this.button_read_controller.Size = new System.Drawing.Size(75, 23);
            this.button_read_controller.TabIndex = 35;
            this.button_read_controller.Text = "Read";
            this.button_read_controller.UseVisualStyleBackColor = true;
            this.button_read_controller.Click += new System.EventHandler(this.button_read_controller_Click);
            // 
            // button_apply_controller
            // 
            this.button_apply_controller.Location = new System.Drawing.Point(154, 326);
            this.button_apply_controller.Name = "button_apply_controller";
            this.button_apply_controller.Size = new System.Drawing.Size(75, 23);
            this.button_apply_controller.TabIndex = 36;
            this.button_apply_controller.Text = "Apply";
            this.button_apply_controller.UseVisualStyleBackColor = true;
            this.button_apply_controller.Click += new System.EventHandler(this.button_apply_controller_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.button_set_kp_vol_loop);
            this.groupBox14.Controls.Add(this.button_set_ki_vol_loop);
            this.groupBox14.Controls.Add(this.textBox_kp_vol_loop);
            this.groupBox14.Controls.Add(this.label31);
            this.groupBox14.Controls.Add(this.textBox_ki_vol_loop);
            this.groupBox14.Controls.Add(this.label32);
            this.groupBox14.Location = new System.Drawing.Point(290, 21);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(217, 283);
            this.groupBox14.TabIndex = 29;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Voltage Loop";
            // 
            // button_set_kp_vol_loop
            // 
            this.button_set_kp_vol_loop.Location = new System.Drawing.Point(161, 27);
            this.button_set_kp_vol_loop.Name = "button_set_kp_vol_loop";
            this.button_set_kp_vol_loop.Size = new System.Drawing.Size(33, 23);
            this.button_set_kp_vol_loop.TabIndex = 35;
            this.button_set_kp_vol_loop.Text = "W";
            this.button_set_kp_vol_loop.UseVisualStyleBackColor = true;
            this.button_set_kp_vol_loop.Click += new System.EventHandler(this.button_set_kp_vol_loop_Click);
            // 
            // button_set_ki_vol_loop
            // 
            this.button_set_ki_vol_loop.Location = new System.Drawing.Point(161, 64);
            this.button_set_ki_vol_loop.Name = "button_set_ki_vol_loop";
            this.button_set_ki_vol_loop.Size = new System.Drawing.Size(33, 23);
            this.button_set_ki_vol_loop.TabIndex = 34;
            this.button_set_ki_vol_loop.Text = "W";
            this.button_set_ki_vol_loop.UseVisualStyleBackColor = true;
            this.button_set_ki_vol_loop.Click += new System.EventHandler(this.button_set_ki_vol_loop_Click);
            // 
            // textBox_kp_vol_loop
            // 
            this.textBox_kp_vol_loop.Location = new System.Drawing.Point(55, 29);
            this.textBox_kp_vol_loop.Name = "textBox_kp_vol_loop";
            this.textBox_kp_vol_loop.Size = new System.Drawing.Size(100, 20);
            this.textBox_kp_vol_loop.TabIndex = 5;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(12, 70);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(16, 13);
            this.label31.TabIndex = 26;
            this.label31.Text = "Ki";
            // 
            // textBox_ki_vol_loop
            // 
            this.textBox_ki_vol_loop.Location = new System.Drawing.Point(56, 68);
            this.textBox_ki_vol_loop.Name = "textBox_ki_vol_loop";
            this.textBox_ki_vol_loop.Size = new System.Drawing.Size(100, 20);
            this.textBox_ki_vol_loop.TabIndex = 6;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(12, 32);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(20, 13);
            this.label32.TabIndex = 25;
            this.label32.Text = "Kp";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.button28);
            this.groupBox13.Controls.Add(this.button13);
            this.groupBox13.Controls.Add(this.textBox47);
            this.groupBox13.Controls.Add(this.label29);
            this.groupBox13.Controls.Add(this.textBox48);
            this.groupBox13.Controls.Add(this.label30);
            this.groupBox13.Location = new System.Drawing.Point(35, 21);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(217, 283);
            this.groupBox13.TabIndex = 28;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Mppt";
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(161, 29);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(33, 23);
            this.button28.TabIndex = 37;
            this.button28.Text = "W";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(161, 64);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(33, 23);
            this.button13.TabIndex = 34;
            this.button13.Text = "W";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // textBox47
            // 
            this.textBox47.Location = new System.Drawing.Point(55, 29);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(100, 20);
            this.textBox47.TabIndex = 5;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(12, 70);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(16, 13);
            this.label29.TabIndex = 26;
            this.label29.Text = "Ki";
            // 
            // textBox48
            // 
            this.textBox48.Location = new System.Drawing.Point(56, 68);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(100, 20);
            this.textBox48.TabIndex = 6;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(12, 32);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(20, 13);
            this.label30.TabIndex = 25;
            this.label30.Text = "Kp";
            // 
            // tabPage_graph
            // 
            this.tabPage_graph.Controls.Add(this.button_saveFile);
            this.tabPage_graph.Controls.Add(this.comboBox_LineTHD);
            this.tabPage_graph.Controls.Add(this.chart_thd);
            this.tabPage_graph.Controls.Add(this.groupBox3);
            this.tabPage_graph.Controls.Add(this.label8);
            this.tabPage_graph.Controls.Add(this.textBox_timewaittrigger);
            this.tabPage_graph.Controls.Add(this.checkBox_Trigger);
            this.tabPage_graph.Controls.Add(this.textBox_Trigger);
            this.tabPage_graph.Controls.Add(this.button2);
            this.tabPage_graph.Controls.Add(this.textBox_scale);
            this.tabPage_graph.Controls.Add(this.label61);
            this.tabPage_graph.Controls.Add(this.txtMaxChart4);
            this.tabPage_graph.Controls.Add(this.txtMinChart4);
            this.tabPage_graph.Controls.Add(this.txtMaxChart3);
            this.tabPage_graph.Controls.Add(this.txtMinChart3);
            this.tabPage_graph.Controls.Add(this.txtMaxChart2);
            this.tabPage_graph.Controls.Add(this.txtMinChart2);
            this.tabPage_graph.Controls.Add(this.txtMaxChart1);
            this.tabPage_graph.Controls.Add(this.txtMinChart1);
            this.tabPage_graph.Controls.Add(this.button4);
            this.tabPage_graph.Controls.Add(this.checkBox4);
            this.tabPage_graph.Controls.Add(this.checkBox3);
            this.tabPage_graph.Controls.Add(this.checkBox2);
            this.tabPage_graph.Controls.Add(this.checkBox1);
            this.tabPage_graph.Controls.Add(this.label60);
            this.tabPage_graph.Controls.Add(this.label58);
            this.tabPage_graph.Controls.Add(this.label57);
            this.tabPage_graph.Controls.Add(this.label7);
            this.tabPage_graph.Controls.Add(this.txtLineChart4);
            this.tabPage_graph.Controls.Add(this.txtLineChart3);
            this.tabPage_graph.Controls.Add(this.txtLineChart2);
            this.tabPage_graph.Controls.Add(this.txtLineChart1);
            this.tabPage_graph.Controls.Add(this.btnRunChart);
            this.tabPage_graph.Controls.Add(this.chart1);
            this.tabPage_graph.Location = new System.Drawing.Point(4, 22);
            this.tabPage_graph.Name = "tabPage_graph";
            this.tabPage_graph.Size = new System.Drawing.Size(1038, 411);
            this.tabPage_graph.TabIndex = 2;
            this.tabPage_graph.Text = "Graph";
            this.tabPage_graph.UseVisualStyleBackColor = true;
            this.tabPage_graph.Click += new System.EventHandler(this.tabPage_graph_Click);
            // 
            // button_saveFile
            // 
            this.button_saveFile.Location = new System.Drawing.Point(1190, 379);
            this.button_saveFile.Name = "button_saveFile";
            this.button_saveFile.Size = new System.Drawing.Size(59, 23);
            this.button_saveFile.TabIndex = 40;
            this.button_saveFile.Text = "SaveFile";
            this.button_saveFile.UseVisualStyleBackColor = true;
            this.button_saveFile.Click += new System.EventHandler(this.button_saveFile_Click);
            // 
            // comboBox_LineTHD
            // 
            this.comboBox_LineTHD.FormattingEnabled = true;
            this.comboBox_LineTHD.Items.AddRange(new object[] {
            "Line 1",
            "Line 2",
            "Line 3",
            "Line 4"});
            this.comboBox_LineTHD.Location = new System.Drawing.Point(313, 365);
            this.comboBox_LineTHD.Name = "comboBox_LineTHD";
            this.comboBox_LineTHD.Size = new System.Drawing.Size(57, 21);
            this.comboBox_LineTHD.TabIndex = 50;
            this.comboBox_LineTHD.SelectedIndexChanged += new System.EventHandler(this.comboBox_LineTHD_SelectedIndexChanged);
            // 
            // chart_thd
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_thd.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_thd.Legends.Add(legend1);
            this.chart_thd.Location = new System.Drawing.Point(376, 271);
            this.chart_thd.Name = "chart_thd";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_thd.Series.Add(series1);
            this.chart_thd.Size = new System.Drawing.Size(678, 131);
            this.chart_thd.TabIndex = 51;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button_openMapFile);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.m_combo);
            this.groupBox3.Controls.Add(this.cbbLineChart);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(17, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 99);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select variable";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Line";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Select map file";
            // 
            // button_openMapFile
            // 
            this.button_openMapFile.Location = new System.Drawing.Point(324, 15);
            this.button_openMapFile.Name = "button_openMapFile";
            this.button_openMapFile.Size = new System.Drawing.Size(29, 23);
            this.button_openMapFile.TabIndex = 53;
            this.button_openMapFile.Text = "...";
            this.button_openMapFile.UseVisualStyleBackColor = true;
            this.button_openMapFile.Click += new System.EventHandler(this.button_openMapFile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 52;
            // 
            // m_combo
            // 
            this.m_combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_combo.FormattingEnabled = true;
            this.m_combo.Location = new System.Drawing.Point(102, 43);
            this.m_combo.Name = "m_combo";
            this.m_combo.Size = new System.Drawing.Size(251, 21);
            this.m_combo.TabIndex = 51;
            // 
            // cbbLineChart
            // 
            this.cbbLineChart.FormattingEnabled = true;
            this.cbbLineChart.Location = new System.Drawing.Point(39, 43);
            this.cbbLineChart.Name = "cbbLineChart";
            this.cbbLineChart.Size = new System.Drawing.Size(57, 21);
            this.cbbLineChart.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Time(s)";
            // 
            // textBox_timewaittrigger
            // 
            this.textBox_timewaittrigger.Location = new System.Drawing.Point(227, 273);
            this.textBox_timewaittrigger.Name = "textBox_timewaittrigger";
            this.textBox_timewaittrigger.Size = new System.Drawing.Size(55, 20);
            this.textBox_timewaittrigger.TabIndex = 44;
            this.textBox_timewaittrigger.Text = "10";
            // 
            // checkBox_Trigger
            // 
            this.checkBox_Trigger.AutoSize = true;
            this.checkBox_Trigger.Location = new System.Drawing.Point(29, 273);
            this.checkBox_Trigger.Name = "checkBox_Trigger";
            this.checkBox_Trigger.Size = new System.Drawing.Size(59, 17);
            this.checkBox_Trigger.TabIndex = 43;
            this.checkBox_Trigger.Text = "Trigger";
            this.checkBox_Trigger.UseVisualStyleBackColor = true;
            // 
            // textBox_Trigger
            // 
            this.textBox_Trigger.Location = new System.Drawing.Point(94, 271);
            this.textBox_Trigger.Name = "textBox_Trigger";
            this.textBox_Trigger.Size = new System.Drawing.Size(55, 20);
            this.textBox_Trigger.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "W";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_scale
            // 
            this.textBox_scale.Location = new System.Drawing.Point(78, 232);
            this.textBox_scale.Name = "textBox_scale";
            this.textBox_scale.Size = new System.Drawing.Size(100, 20);
            this.textBox_scale.TabIndex = 37;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(35, 235);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(34, 13);
            this.label61.TabIndex = 38;
            this.label61.Text = "Scale";
            // 
            // txtMaxChart4
            // 
            this.txtMaxChart4.Location = new System.Drawing.Point(313, 194);
            this.txtMaxChart4.Name = "txtMaxChart4";
            this.txtMaxChart4.Size = new System.Drawing.Size(63, 20);
            this.txtMaxChart4.TabIndex = 36;
            // 
            // txtMinChart4
            // 
            this.txtMinChart4.Location = new System.Drawing.Point(227, 195);
            this.txtMinChart4.Name = "txtMinChart4";
            this.txtMinChart4.Size = new System.Drawing.Size(64, 20);
            this.txtMinChart4.TabIndex = 35;
            // 
            // txtMaxChart3
            // 
            this.txtMaxChart3.Location = new System.Drawing.Point(313, 165);
            this.txtMaxChart3.Name = "txtMaxChart3";
            this.txtMaxChart3.Size = new System.Drawing.Size(63, 20);
            this.txtMaxChart3.TabIndex = 34;
            // 
            // txtMinChart3
            // 
            this.txtMinChart3.Location = new System.Drawing.Point(227, 166);
            this.txtMinChart3.Name = "txtMinChart3";
            this.txtMinChart3.Size = new System.Drawing.Size(64, 20);
            this.txtMinChart3.TabIndex = 33;
            // 
            // txtMaxChart2
            // 
            this.txtMaxChart2.Location = new System.Drawing.Point(313, 135);
            this.txtMaxChart2.Name = "txtMaxChart2";
            this.txtMaxChart2.Size = new System.Drawing.Size(63, 20);
            this.txtMaxChart2.TabIndex = 32;
            // 
            // txtMinChart2
            // 
            this.txtMinChart2.Location = new System.Drawing.Point(227, 136);
            this.txtMinChart2.Name = "txtMinChart2";
            this.txtMinChart2.Size = new System.Drawing.Size(64, 20);
            this.txtMinChart2.TabIndex = 31;
            // 
            // txtMaxChart1
            // 
            this.txtMaxChart1.Location = new System.Drawing.Point(313, 105);
            this.txtMaxChart1.Name = "txtMaxChart1";
            this.txtMaxChart1.Size = new System.Drawing.Size(63, 20);
            this.txtMaxChart1.TabIndex = 30;
            // 
            // txtMinChart1
            // 
            this.txtMinChart1.Location = new System.Drawing.Point(227, 106);
            this.txtMinChart1.Name = "txtMinChart1";
            this.txtMinChart1.Size = new System.Drawing.Size(64, 20);
            this.txtMinChart1.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(38, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Get Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(167, 197);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(48, 17);
            this.checkBox4.TabIndex = 25;
            this.checkBox4.Text = "Hide";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(167, 168);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(48, 17);
            this.checkBox3.TabIndex = 24;
            this.checkBox3.Text = "Hide";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(167, 138);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 17);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "Hide";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(167, 108);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Hide";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(26, 109);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(36, 13);
            this.label60.TabIndex = 21;
            this.label60.Text = "Line 1";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(26, 202);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(36, 13);
            this.label58.TabIndex = 16;
            this.label58.Text = "Line 4";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(26, 169);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(36, 13);
            this.label57.TabIndex = 15;
            this.label57.Text = "Line 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Line 2";
            // 
            // txtLineChart4
            // 
            this.txtLineChart4.BackColor = System.Drawing.Color.Black;
            this.txtLineChart4.Location = new System.Drawing.Point(78, 195);
            this.txtLineChart4.Name = "txtLineChart4";
            this.txtLineChart4.Size = new System.Drawing.Size(80, 20);
            this.txtLineChart4.TabIndex = 12;
            // 
            // txtLineChart3
            // 
            this.txtLineChart3.BackColor = System.Drawing.Color.Blue;
            this.txtLineChart3.Location = new System.Drawing.Point(78, 166);
            this.txtLineChart3.Name = "txtLineChart3";
            this.txtLineChart3.Size = new System.Drawing.Size(80, 20);
            this.txtLineChart3.TabIndex = 11;
            // 
            // txtLineChart2
            // 
            this.txtLineChart2.BackColor = System.Drawing.Color.Red;
            this.txtLineChart2.Location = new System.Drawing.Point(78, 136);
            this.txtLineChart2.Name = "txtLineChart2";
            this.txtLineChart2.Size = new System.Drawing.Size(80, 20);
            this.txtLineChart2.TabIndex = 10;
            // 
            // txtLineChart1
            // 
            this.txtLineChart1.BackColor = System.Drawing.Color.Lime;
            this.txtLineChart1.Location = new System.Drawing.Point(78, 106);
            this.txtLineChart1.Name = "txtLineChart1";
            this.txtLineChart1.Size = new System.Drawing.Size(80, 20);
            this.txtLineChart1.TabIndex = 9;
            // 
            // btnRunChart
            // 
            this.btnRunChart.Location = new System.Drawing.Point(142, 322);
            this.btnRunChart.Name = "btnRunChart";
            this.btnRunChart.Size = new System.Drawing.Size(82, 23);
            this.btnRunChart.TabIndex = 8;
            this.btnRunChart.Text = "Run Chart";
            this.btnRunChart.UseVisualStyleBackColor = true;
            this.btnRunChart.Click += new System.EventHandler(this.Button3_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(376, 3);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(678, 268);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage_Data
            // 
            this.tabPage_Data.Controls.Add(this.label64);
            this.tabPage_Data.Controls.Add(this.textBox_logEnd);
            this.tabPage_Data.Controls.Add(this.textBox_logStart);
            this.tabPage_Data.Controls.Add(this.button6);
            this.tabPage_Data.Controls.Add(this.ReadLog);
            this.tabPage_Data.Controls.Add(this.richTextBox_Log);
            this.tabPage_Data.Controls.Add(this.button5);
            this.tabPage_Data.Controls.Add(this.button_ClearData);
            this.tabPage_Data.Controls.Add(this.button3);
            this.tabPage_Data.Controls.Add(this.label6);
            this.tabPage_Data.Controls.Add(this.textBox_time_setup);
            this.tabPage_Data.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Data.Name = "tabPage_Data";
            this.tabPage_Data.Size = new System.Drawing.Size(1038, 411);
            this.tabPage_Data.TabIndex = 4;
            this.tabPage_Data.Text = "Data";
            this.tabPage_Data.UseVisualStyleBackColor = true;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(286, 62);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(16, 13);
            this.label64.TabIndex = 45;
            this.label64.Text = "to";
            // 
            // textBox_logEnd
            // 
            this.textBox_logEnd.Location = new System.Drawing.Point(308, 57);
            this.textBox_logEnd.Name = "textBox_logEnd";
            this.textBox_logEnd.Size = new System.Drawing.Size(53, 20);
            this.textBox_logEnd.TabIndex = 44;
            this.textBox_logEnd.Text = "10";
            // 
            // textBox_logStart
            // 
            this.textBox_logStart.Location = new System.Drawing.Point(227, 57);
            this.textBox_logStart.Name = "textBox_logStart";
            this.textBox_logStart.Size = new System.Drawing.Size(53, 20);
            this.textBox_logStart.TabIndex = 43;
            this.textBox_logStart.Text = "1";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(96, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 42;
            this.button6.Text = "Xóa Log";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ReadLog
            // 
            this.ReadLog.Location = new System.Drawing.Point(15, 55);
            this.ReadLog.Name = "ReadLog";
            this.ReadLog.Size = new System.Drawing.Size(75, 23);
            this.ReadLog.TabIndex = 41;
            this.ReadLog.Text = "Đọc Log";
            this.ReadLog.UseVisualStyleBackColor = true;
            this.ReadLog.Click += new System.EventHandler(this.ReadLog_Click);
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.Location = new System.Drawing.Point(15, 78);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.Size = new System.Drawing.Size(1020, 324);
            this.richTextBox_Log.TabIndex = 40;
            this.richTextBox_Log.Text = "";
            this.richTextBox_Log.TextChanged += new System.EventHandler(this.richTextBox_Log_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(228, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 23);
            this.button5.TabIndex = 39;
            this.button5.Text = "Now";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_ClearData
            // 
            this.button_ClearData.Location = new System.Drawing.Point(387, 25);
            this.button_ClearData.Name = "button_ClearData";
            this.button_ClearData.Size = new System.Drawing.Size(171, 23);
            this.button_ClearData.TabIndex = 38;
            this.button_ClearData.Text = "Xóa Dữ liệu";
            this.button_ClearData.UseVisualStyleBackColor = true;
            this.button_ClearData.Click += new System.EventHandler(this.button_ClearData_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(274, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 23);
            this.button3.TabIndex = 37;
            this.button3.Text = "Cài đặt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Thời gian: ";
            // 
            // textBox_time_setup
            // 
            this.textBox_time_setup.Location = new System.Drawing.Point(75, 22);
            this.textBox_time_setup.Name = "textBox_time_setup";
            this.textBox_time_setup.Size = new System.Drawing.Size(147, 20);
            this.textBox_time_setup.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.groupBox17);
            this.tabPage1.Controls.Add(this.groupBox16);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1038, 411);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "DeviceInfo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(258, 48);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(59, 23);
            this.button9.TabIndex = 39;
            this.button9.Text = "Default";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.button18);
            this.groupBox17.Controls.Add(this.label70);
            this.groupBox17.Controls.Add(this.label69);
            this.groupBox17.Controls.Add(this.txtSerialReadSwKey);
            this.groupBox17.Controls.Add(this.button8);
            this.groupBox17.Controls.Add(this.txtSerialReadInfo);
            this.groupBox17.Controls.Add(this.txtSerialReadDvKey);
            this.groupBox17.Controls.Add(this.label68);
            this.groupBox17.Location = new System.Drawing.Point(393, 21);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(302, 257);
            this.groupBox17.TabIndex = 35;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Device Information";
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(237, 27);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(59, 23);
            this.button18.TabIndex = 40;
            this.button18.Text = "Reset";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.Button18_Click_1);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(24, 104);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(43, 13);
            this.label70.TabIndex = 38;
            this.label70.Text = "Sw Key";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(18, 70);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(62, 13);
            this.label69.TabIndex = 38;
            this.label69.Text = "Device Key";
            // 
            // txtSerialReadSwKey
            // 
            this.txtSerialReadSwKey.Location = new System.Drawing.Point(92, 101);
            this.txtSerialReadSwKey.Name = "txtSerialReadSwKey";
            this.txtSerialReadSwKey.Size = new System.Drawing.Size(123, 20);
            this.txtSerialReadSwKey.TabIndex = 37;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(92, 152);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 23);
            this.button8.TabIndex = 34;
            this.button8.Text = "Read Info";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // txtSerialReadInfo
            // 
            this.txtSerialReadInfo.Location = new System.Drawing.Point(92, 29);
            this.txtSerialReadInfo.Name = "txtSerialReadInfo";
            this.txtSerialReadInfo.Size = new System.Drawing.Size(123, 20);
            this.txtSerialReadInfo.TabIndex = 5;
            // 
            // txtSerialReadDvKey
            // 
            this.txtSerialReadDvKey.Location = new System.Drawing.Point(92, 67);
            this.txtSerialReadDvKey.Name = "txtSerialReadDvKey";
            this.txtSerialReadDvKey.Size = new System.Drawing.Size(123, 20);
            this.txtSerialReadDvKey.TabIndex = 6;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(18, 32);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(33, 13);
            this.label68.TabIndex = 25;
            this.label68.Text = "Serial";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.button19);
            this.groupBox16.Controls.Add(this.label67);
            this.groupBox16.Controls.Add(this.textBoxSwKey);
            this.groupBox16.Controls.Add(this.button7);
            this.groupBox16.Controls.Add(this.textBoxSerial);
            this.groupBox16.Controls.Add(this.label65);
            this.groupBox16.Controls.Add(this.textBoxDevKey);
            this.groupBox16.Controls.Add(this.label66);
            this.groupBox16.Location = new System.Drawing.Point(45, 21);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(278, 257);
            this.groupBox16.TabIndex = 28;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Write Info";
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(173, 152);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(80, 23);
            this.button19.TabIndex = 41;
            this.button19.Text = "Check Result";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.Button19_Click);
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(16, 104);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(43, 13);
            this.label67.TabIndex = 36;
            this.label67.Text = "Sw Key";
            // 
            // textBoxSwKey
            // 
            this.textBoxSwKey.Location = new System.Drawing.Point(84, 101);
            this.textBoxSwKey.Name = "textBoxSwKey";
            this.textBoxSwKey.Size = new System.Drawing.Size(123, 20);
            this.textBoxSwKey.TabIndex = 35;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(84, 152);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 23);
            this.button7.TabIndex = 34;
            this.button7.Text = "Write Info";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Location = new System.Drawing.Point(84, 29);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(123, 20);
            this.textBoxSerial.TabIndex = 5;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(16, 70);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(62, 13);
            this.label65.TabIndex = 26;
            this.label65.Text = "Device Key";
            // 
            // textBoxDevKey
            // 
            this.textBoxDevKey.Location = new System.Drawing.Point(84, 66);
            this.textBoxDevKey.Name = "textBoxDevKey";
            this.textBoxDevKey.Size = new System.Drawing.Size(123, 20);
            this.textBoxDevKey.TabIndex = 6;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(18, 32);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(33, 13);
            this.label66.TabIndex = 25;
            this.label66.Text = "Serial";
            // 
            // tabPageCalibAdc
            // 
            this.tabPageCalibAdc.Controls.Add(this.groupBox18);
            this.tabPageCalibAdc.Location = new System.Drawing.Point(4, 22);
            this.tabPageCalibAdc.Name = "tabPageCalibAdc";
            this.tabPageCalibAdc.Size = new System.Drawing.Size(1038, 411);
            this.tabPageCalibAdc.TabIndex = 6;
            this.tabPageCalibAdc.Text = "CalibAdc";
            this.tabPageCalibAdc.UseVisualStyleBackColor = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.btnRelay);
            this.groupBox18.Controls.Add(this.button17);
            this.groupBox18.Controls.Add(this.txtDuty);
            this.groupBox18.Controls.Add(this.button16);
            this.groupBox18.Controls.Add(this.button10);
            this.groupBox18.Controls.Add(this.cbbParam);
            this.groupBox18.Controls.Add(this.txtCheckValue);
            this.groupBox18.Controls.Add(this.label71);
            this.groupBox18.Controls.Add(this.button15);
            this.groupBox18.Controls.Add(this.button14);
            this.groupBox18.Controls.Add(this.txtGetAdc2);
            this.groupBox18.Controls.Add(this.button12);
            this.groupBox18.Controls.Add(this.txtGetAdc1);
            this.groupBox18.Controls.Add(this.button11);
            this.groupBox18.Controls.Add(this.label72);
            this.groupBox18.Controls.Add(this.txtParam1);
            this.groupBox18.Controls.Add(this.txtParam2);
            this.groupBox18.Controls.Add(this.label73);
            this.groupBox18.Location = new System.Drawing.Point(14, 18);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(683, 257);
            this.groupBox18.TabIndex = 36;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Calib Adc";
            // 
            // btnRelay
            // 
            this.btnRelay.Location = new System.Drawing.Point(232, 183);
            this.btnRelay.Name = "btnRelay";
            this.btnRelay.Size = new System.Drawing.Size(81, 23);
            this.btnRelay.TabIndex = 58;
            this.btnRelay.Text = "Close Relay";
            this.btnRelay.UseVisualStyleBackColor = true;
            this.btnRelay.Click += new System.EventHandler(this.Button18_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(571, 76);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(68, 23);
            this.button17.TabIndex = 57;
            this.button17.Text = "Reset";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Button17_Click);
            // 
            // txtDuty
            // 
            this.txtDuty.Location = new System.Drawing.Point(330, 116);
            this.txtDuty.Name = "txtDuty";
            this.txtDuty.Size = new System.Drawing.Size(94, 20);
            this.txtDuty.TabIndex = 56;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(232, 114);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(81, 23);
            this.button16.TabIndex = 55;
            this.button16.Text = "Set Duty";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Button16_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(571, 109);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(68, 23);
            this.button10.TabIndex = 54;
            this.button10.Text = "Default";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // cbbParam
            // 
            this.cbbParam.FormattingEnabled = true;
            this.cbbParam.Location = new System.Drawing.Point(9, 50);
            this.cbbParam.Name = "cbbParam";
            this.cbbParam.Size = new System.Drawing.Size(121, 21);
            this.cbbParam.TabIndex = 53;
            // 
            // txtCheckValue
            // 
            this.txtCheckValue.Location = new System.Drawing.Point(330, 148);
            this.txtCheckValue.Name = "txtCheckValue";
            this.txtCheckValue.Size = new System.Drawing.Size(94, 20);
            this.txtCheckValue.TabIndex = 52;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(6, 31);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(88, 13);
            this.label71.TabIndex = 51;
            this.label71.Text = "Select Parameter";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(232, 148);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(81, 23);
            this.button15.TabIndex = 49;
            this.button15.Text = "Check Value";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(571, 45);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(68, 23);
            this.button14.TabIndex = 48;
            this.button14.Text = "Set Param";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Button14_Click);
            // 
            // txtGetAdc2
            // 
            this.txtGetAdc2.Location = new System.Drawing.Point(444, 73);
            this.txtGetAdc2.Name = "txtGetAdc2";
            this.txtGetAdc2.Size = new System.Drawing.Size(94, 20);
            this.txtGetAdc2.TabIndex = 47;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(356, 71);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(68, 23);
            this.button12.TabIndex = 46;
            this.button12.Text = "Get Adc 2";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // txtGetAdc1
            // 
            this.txtGetAdc1.Location = new System.Drawing.Point(444, 47);
            this.txtGetAdc1.Name = "txtGetAdc1";
            this.txtGetAdc1.Size = new System.Drawing.Size(94, 20);
            this.txtGetAdc1.TabIndex = 45;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(356, 45);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(68, 23);
            this.button11.TabIndex = 44;
            this.button11.Text = "Get Adc 1";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(185, 76);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(43, 13);
            this.label72.TabIndex = 38;
            this.label72.Text = "Value 2";
            // 
            // txtParam1
            // 
            this.txtParam1.Location = new System.Drawing.Point(232, 47);
            this.txtParam1.Name = "txtParam1";
            this.txtParam1.Size = new System.Drawing.Size(94, 20);
            this.txtParam1.TabIndex = 5;
            // 
            // txtParam2
            // 
            this.txtParam2.Location = new System.Drawing.Point(232, 73);
            this.txtParam2.Name = "txtParam2";
            this.txtParam2.Size = new System.Drawing.Size(94, 20);
            this.txtParam2.TabIndex = 6;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(185, 50);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(43, 13);
            this.label73.TabIndex = 25;
            this.label73.Text = "Value 1";
            // 
            // tabPage_Config
            // 
            this.tabPage_Config.Controls.Add(this.button34);
            this.tabPage_Config.Controls.Add(this.textBox_version_config);
            this.tabPage_Config.Controls.Add(this.label78);
            this.tabPage_Config.Controls.Add(this.button33);
            this.tabPage_Config.Controls.Add(this.button22);
            this.tabPage_Config.Controls.Add(this.groupBox21);
            this.tabPage_Config.Controls.Add(this.groupBox20);
            this.tabPage_Config.Controls.Add(this.groupBox19);
            this.tabPage_Config.Controls.Add(this.button24);
            this.tabPage_Config.Controls.Add(this.button25);
            this.tabPage_Config.Controls.Add(this.button26);
            this.tabPage_Config.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Config.Name = "tabPage_Config";
            this.tabPage_Config.Size = new System.Drawing.Size(1038, 411);
            this.tabPage_Config.TabIndex = 7;
            this.tabPage_Config.Text = "Config";
            this.tabPage_Config.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(14, 6);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(75, 23);
            this.button34.TabIndex = 74;
            this.button34.Text = "Open File";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // textBox_version_config
            // 
            this.textBox_version_config.Location = new System.Drawing.Point(218, 9);
            this.textBox_version_config.Name = "textBox_version_config";
            this.textBox_version_config.Size = new System.Drawing.Size(100, 20);
            this.textBox_version_config.TabIndex = 71;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(170, 12);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(42, 13);
            this.label78.TabIndex = 72;
            this.label78.Text = "Version";
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(324, 7);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(33, 23);
            this.button33.TabIndex = 73;
            this.button33.Text = "W";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(484, 364);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 23);
            this.button22.TabIndex = 70;
            this.button22.Text = "Save To File";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // groupBox21
            // 
            this.groupBox21.Location = new System.Drawing.Point(364, 38);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(671, 305);
            this.groupBox21.TabIndex = 69;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Thông số bảo vệ";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.label79);
            this.groupBox20.Controls.Add(this.textBox5);
            this.groupBox20.Controls.Add(this.button29);
            this.groupBox20.Controls.Add(this.label80);
            this.groupBox20.Controls.Add(this.textBox6);
            this.groupBox20.Controls.Add(this.button30);
            this.groupBox20.Controls.Add(this.label81);
            this.groupBox20.Controls.Add(this.textBox7);
            this.groupBox20.Controls.Add(this.button31);
            this.groupBox20.Controls.Add(this.textBox8);
            this.groupBox20.Controls.Add(this.label82);
            this.groupBox20.Controls.Add(this.button32);
            this.groupBox20.Location = new System.Drawing.Point(21, 205);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(275, 141);
            this.groupBox20.TabIndex = 68;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Thông số đầu vào";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(28, 106);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(21, 13);
            this.label79.TabIndex = 73;
            this.label79.Text = "Isc";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(99, 103);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 71;
            // 
            // button29
            // 
            this.button29.Enabled = false;
            this.button29.Location = new System.Drawing.Point(205, 101);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(33, 23);
            this.button29.TabIndex = 72;
            this.button29.Text = "W";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(28, 77);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(26, 13);
            this.label80.TabIndex = 70;
            this.label80.Text = "Voc";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(99, 74);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 68;
            // 
            // button30
            // 
            this.button30.Enabled = false;
            this.button30.Location = new System.Drawing.Point(205, 72);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(33, 23);
            this.button30.TabIndex = 69;
            this.button30.Text = "W";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(28, 49);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(36, 13);
            this.label81.TabIndex = 67;
            this.label81.Text = "I_Max";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(99, 46);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 65;
            // 
            // button31
            // 
            this.button31.Enabled = false;
            this.button31.Location = new System.Drawing.Point(205, 44);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(33, 23);
            this.button31.TabIndex = 66;
            this.button31.Text = "W";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(99, 19);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 48;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(28, 21);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(37, 13);
            this.label82.TabIndex = 49;
            this.label82.Text = "V-Max";
            // 
            // button32
            // 
            this.button32.Enabled = false;
            this.button32.Location = new System.Drawing.Point(205, 17);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(33, 23);
            this.button32.TabIndex = 50;
            this.button32.Text = "W";
            this.button32.UseVisualStyleBackColor = true;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.label76);
            this.groupBox19.Controls.Add(this.textBox3);
            this.groupBox19.Controls.Add(this.button27);
            this.groupBox19.Controls.Add(this.label75);
            this.groupBox19.Controls.Add(this.textBox2);
            this.groupBox19.Controls.Add(this.button21);
            this.groupBox19.Controls.Add(this.label74);
            this.groupBox19.Controls.Add(this.textBox_VMax);
            this.groupBox19.Controls.Add(this.button20);
            this.groupBox19.Controls.Add(this.textBox_PGioiHan);
            this.groupBox19.Controls.Add(this.label77);
            this.groupBox19.Controls.Add(this.button23);
            this.groupBox19.Location = new System.Drawing.Point(21, 46);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(275, 141);
            this.groupBox19.TabIndex = 67;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Thông số đầu ra";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(28, 106);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(29, 13);
            this.label76.TabIndex = 73;
            this.label76.Text = "Imax";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(99, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 71;
            // 
            // button27
            // 
            this.button27.Enabled = false;
            this.button27.Location = new System.Drawing.Point(205, 101);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(33, 23);
            this.button27.TabIndex = 72;
            this.button27.Text = "W";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(28, 77);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(40, 13);
            this.label75.TabIndex = 70;
            this.label75.Text = "Tần số";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(99, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 68;
            // 
            // button21
            // 
            this.button21.Enabled = false;
            this.button21.Location = new System.Drawing.Point(205, 72);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(33, 23);
            this.button21.TabIndex = 69;
            this.button21.Text = "W";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(28, 49);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(67, 13);
            this.label74.TabIndex = 67;
            this.label74.Text = "Điện áp Max";
            // 
            // textBox_VMax
            // 
            this.textBox_VMax.Location = new System.Drawing.Point(99, 46);
            this.textBox_VMax.Name = "textBox_VMax";
            this.textBox_VMax.Size = new System.Drawing.Size(100, 20);
            this.textBox_VMax.TabIndex = 65;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(205, 44);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(33, 23);
            this.button20.TabIndex = 66;
            this.button20.Text = "W";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // textBox_PGioiHan
            // 
            this.textBox_PGioiHan.Location = new System.Drawing.Point(99, 19);
            this.textBox_PGioiHan.Name = "textBox_PGioiHan";
            this.textBox_PGioiHan.Size = new System.Drawing.Size(100, 20);
            this.textBox_PGioiHan.TabIndex = 48;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(28, 21);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(55, 13);
            this.label77.TabIndex = 49;
            this.label77.Text = "Công suất";
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(205, 17);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(33, 23);
            this.button23.TabIndex = 50;
            this.button23.Text = "W";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(403, 364);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 23);
            this.button24.TabIndex = 62;
            this.button24.Text = "Restore";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(313, 364);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 23);
            this.button25.TabIndex = 61;
            this.button25.Text = "Save";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(226, 364);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(75, 23);
            this.button26.TabIndex = 60;
            this.button26.Text = "ReadAll";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 479);
            this.Controls.Add(this.tabControl_value);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "QUẢN LÝ THÔNG SỐ ĐỒNG HỒ ĐIỆN TỬ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl_value.ResumeLayout(false);
            this.tabPage_Signal.ResumeLayout(false);
            this.tabPage_Signal.PerformLayout();
            this.tabPage_Coff.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage_controller.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.tabPage_graph.ResumeLayout(false);
            this.tabPage_graph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_thd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage_Data.ResumeLayout(false);
            this.tabPage_Data.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.tabPageCalibAdc.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.tabPage_Config.ResumeLayout(false);
            this.tabPage_Config.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox lstBaudrate;
        private System.Windows.Forms.ComboBox lstPorts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStartAddr;
        private System.Windows.Forms.TextBox txtSlaveID;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TabControl tabControl_value;
        private System.Windows.Forms.TabPage tabPage_Signal;
        private System.Windows.Forms.TabPage tabPage_Coff;
        private System.Windows.Forms.TabPage tabPage_graph;
        private System.Windows.Forms.TextBox textBox_Vbus;
        private System.Windows.Forms.TextBox textBox_ErrCode;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.TextBox textBox_e_total;
        private System.Windows.Forms.TextBox textBox_temp;
        private System.Windows.Forms.TextBox textBox_ileak;
        private System.Windows.Forms.TextBox textBox_ipv2;
        private System.Windows.Forms.TextBox textBox_vpv2;
        private System.Windows.Forms.TextBox textBox_ipv1;
        private System.Windows.Forms.TextBox textBox_vpv1;
        private System.Windows.Forms.TextBox textBox_Pf;
        private System.Windows.Forms.TextBox textBox_Freq;
        private System.Windows.Forms.TextBox textBox_Irms;
        private System.Windows.Forms.TextBox textBox_Vrms;
        private System.Windows.Forms.TextBox textBox_Pmax;
        private System.Windows.Forms.TextBox textBox_Pout;
        private System.Windows.Forms.TextBox textBox_Pin;
        private System.Windows.Forms.TextBox textBox_etoday;
        private System.Windows.Forms.TextBox textBox_offset_vpv1;
        private System.Windows.Forms.TextBox textBox_gain_vpv1;
        private System.Windows.Forms.TabPage tabPage_controller;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button button_set_offset_vbus;
        private System.Windows.Forms.TextBox textBox_gain_vbus;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox_offset_vbus;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button button1_set_offset_ileak;
        private System.Windows.Forms.TextBox textBox_gain_ileak;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox_offset_ileak;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button button_set_offset_vac;
        private System.Windows.Forms.TextBox textBox_gain_vac;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox_offset_vac;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button_set_offset_igrid;
        private System.Windows.Forms.TextBox textBox_gain_igrid;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_offset_igrid;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button_set_offset_vgrid;
        private System.Windows.Forms.TextBox textBox_gain_vgrid;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_offset_vgrid;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button_set_offset_ipv2;
        private System.Windows.Forms.TextBox textBox_gain_ipv2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_offset_ipv2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button_set_offset_vpv2;
        private System.Windows.Forms.TextBox textBox_gain_vpv2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_offset_vpv2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_set_offset_ipv1;
        private System.Windows.Forms.TextBox textBox_gain_ipv1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_offset_ipv1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button_set_gain_vpv1;
        private System.Windows.Forms.Button button_save_coef;
        private System.Windows.Forms.Button button_ReadCoeff;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_set_offset_vpv1;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Button button_set_ki_pr9;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBox_ki_pr9;
        private System.Windows.Forms.Button button_set_ki_pr7;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox textBox_ki_pr7;
        private System.Windows.Forms.Button button_set_ki_pr5;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox textBox_ki_pr5;
        private System.Windows.Forms.Button button_set_ki_pr3;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBox_ki_pr3;
        private System.Windows.Forms.Button button_set_kp_pr;
        private System.Windows.Forms.Button button_set_ki_pr1;
        private System.Windows.Forms.TextBox textBox_kp_pr;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBox_ki_pr1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button button_set_kp_vol_loop;
        private System.Windows.Forms.Button button_set_ki_vol_loop;
        private System.Windows.Forms.TextBox textBox_kp_vol_loop;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox_ki_vol_loop;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox48;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button_apply_controller;
        private System.Windows.Forms.Button button_read_controller;
        private System.Windows.Forms.Button button_set_gain_ipv1;
        private System.Windows.Forms.Button button_set_gain_vpv2;
        private System.Windows.Forms.Button button_set_gain_vbus;
        private System.Windows.Forms.Button button_set_gain_ileak;
        private System.Windows.Forms.Button button_set_gain_vac;
        private System.Windows.Forms.Button button_set_gain_igrid;
        private System.Windows.Forms.Button button_set_gain_vgrid;
        private System.Windows.Forms.Button button_set_gain_ipv2;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button btnRunChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLineChart4;
        private System.Windows.Forms.TextBox txtLineChart3;
        private System.Windows.Forms.TextBox txtLineChart2;
        private System.Windows.Forms.TextBox txtLineChart1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbLineChart;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtMaxChart4;
        private System.Windows.Forms.TextBox txtMinChart4;
        private System.Windows.Forms.TextBox txtMaxChart3;
        private System.Windows.Forms.TextBox txtMinChart3;
        private System.Windows.Forms.TextBox txtMaxChart2;
        private System.Windows.Forms.TextBox txtMinChart2;
        private System.Windows.Forms.TextBox txtMaxChart1;
        private System.Windows.Forms.TextBox txtMinChart1;
        private System.Windows.Forms.Button button_restore_data;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_scale;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Button button_saveFile;
        private System.Windows.Forms.Button button_set_kp_pi;
        private System.Windows.Forms.Button button_set_ki_pi;
        private System.Windows.Forms.TextBox textBox_kp_pi;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox textBox_ki_pi;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TabPage tabPage_Data;
        private System.Windows.Forms.Button button_ClearData;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_time_setup;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button ReadLog;
        private System.Windows.Forms.RichTextBox richTextBox_Log;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox textBox_logEnd;
        private System.Windows.Forms.TextBox textBox_logStart;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtSerialReadInfo;
        private System.Windows.Forms.TextBox txtSerialReadDvKey;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox textBoxDevKey;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox textBoxSwKey;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox txtSerialReadSwKey;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TabPage tabPageCalibAdc;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox txtParam1;
        private System.Windows.Forms.TextBox txtParam2;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox txtGetAdc2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox txtGetAdc1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox txtCheckValue;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.ComboBox cbbParam;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox txtDuty;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button btnRelay;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.TabPage tabPage_Config;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox textBox_VMax;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TextBox textBox_PGioiHan;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.TextBox textBox_version_config;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.TextBox textBox_Trigger;
        private System.Windows.Forms.CheckBox checkBox_Trigger;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_timewaittrigger;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private SergeUtils.EasyCompletionComboBox m_combo;
        private System.Windows.Forms.Button button_openMapFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_LineTHD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_thd;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label status;
    }
}

