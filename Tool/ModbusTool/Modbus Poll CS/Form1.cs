using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using System.IO;
using System.Globalization;
//using Bond;
using System.Runtime.InteropServices;
using System.Threading;

namespace Modbus_Poll_CS
{

    public partial class Form1 : Form
    {
        DataRegister dataRegister = new DataRegister();
        modbus mb = new modbus();
        SerialPort sp = new SerialPort();
        System.Timers.Timer timer = new System.Timers.Timer();
        bool isPolling = false;
        int pollCount;
        float[] mbValue = new float[50];

        float[] chartValue = new float[1000];
        bool relayStatus = true;

        int startAddrChartValue = 5000;
        int startAddrMbRead = 0;
        int startAddrMbWrite = 500;

        double[] chartArray1 = new double[400];
        double[] chartArray2 = new double[400];
        double[] chartArray3 = new double[400];
        double[] chartArray4 = new double[400];
        double rateChart = 0;
        int volumeChart = 800;

        Series series1 = new Series();
        Series series2 = new Series();
        Series series3 = new Series();
        Series series4 = new Series();
    #region GUI Delegate Declarations
    public delegate void GUIDelegate();
        public delegate void GUIClear();
        public delegate void GUIStatus(string paramString);
        public delegate void GUITEXTBOX(TextBox txt, string paramString);
        #endregion
        
        public Form1()
        {
            InitializeComponent();
            LoadListboxes();
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);

            DoGUICombobox();

        }

        #region Delegate Functions
        public void DoGUIClear()
        {
            if (this.InvokeRequired)
            {
                GUIClear delegateMethod = new GUIClear(this.DoGUIClear);
                this.Invoke(delegateMethod);
            }
            //else
            //    this.lstRegisterValues.Items.Clear();
        }
        public void DoGUIStatus(string paramString)
        {
            if (this.InvokeRequired)
            {
                GUIStatus delegateMethod = new GUIStatus(this.DoGUIStatus);
                this.Invoke(delegateMethod, new object[] { paramString });
            }
            else
                this.lblStatus.Text = paramString;
        }

        public void DoGUITextbox(TextBox txt, string paramString)
        {
            if (this.InvokeRequired)
            {
                GUITEXTBOX delegateMethod = new GUITEXTBOX(this.DoGUITextbox);
                this.Invoke(delegateMethod, new object[] { txt, paramString });
            }
            else
                txt.Text = paramString;
        }
        public void DoGUICombobox()
        {
            if (this.InvokeRequired)
            {
                GUIDelegate delegateMethod = new GUIDelegate(this.DoGUICombobox);
                this.Invoke(delegateMethod, new object[] { });
            }
            else
            {
                cbbLineChart.Items.Clear();
                cbbLineChart.Items.Add("Line 1");
                cbbLineChart.Items.Add("Line 2");
                cbbLineChart.Items.Add("Line 3");
                cbbLineChart.Items.Add("Line 4");

                cbbParam.Items.Clear();
                cbbParam.Items.Add("Vpv1");
                cbbParam.Items.Add("Vpv2");
                cbbParam.Items.Add("Vbus");
                cbbParam.Items.Add("Vac");
                cbbParam.Items.Add("Vgrid");
                cbbParam.Items.Add("Ipv1");
                cbbParam.Items.Add("Ipv2");
                cbbParam.Items.Add("Igrid");
                cbbParam.Items.Add("Ileak");
            }
        }
        void Update_Var_To_Object(ref string obj_string, VarType type, VarAddr addr)
        {
            if (type == VarType.Float)
            {
                byte[] data;
                int intValue = (int)dataRegister.data_source[(int)addr * 2 + 1];
                intValue <<= 16;
                intValue |= (int)(dataRegister.data_source[(int)addr * 2] & 0x0000ffff);
                data = BitConverter.GetBytes(intValue);
                obj_string = BitConverter.ToSingle(data, 0).ToString();
            }
            if (type == VarType.Int)
            {
                long intValue = (long)dataRegister.data_source[(int)addr * 2 + 1];
                intValue <<= 16;
                intValue = intValue & 0xffff0000;
                intValue |= (long)(dataRegister.data_source[(int)addr * 2] & 0x0000ffff);
                obj_string = intValue.ToString();
            }
        }

        void Update_Var_To_Object(ref int obj_int,VarAddr addr)
        {
            int intValue = dataRegister.data_source[(int)addr * 2 + 1];
            intValue <<= 16;
            intValue = (int)(intValue & 0xffff0000);
            intValue |= (int)(dataRegister.data_source[(int)addr * 2] & 0x0000ffff);
            obj_int = intValue;
        }

        void Update_Var_To_Object(ref float obj_float,VarAddr addr)
        {
                byte[] data;
                int intValue = (int)dataRegister.data_source[(int)addr * 2 + 1];
                intValue <<= 16;
                intValue |= (int)(dataRegister.data_source[(int)addr * 2] & 0x0000ffff);
                data = BitConverter.GetBytes(intValue);
                obj_float = BitConverter.ToSingle(data, 0);
        }

        int selected_tab = 0;
        bool request_coef_flag = true;
        bool requett_config_flag = true;
        bool request_controler_coef = true;
        bool request_start_dlog = true;
        public void DoGUIUpdate()
        {
            if (this.InvokeRequired)
            {
                GUIDelegate delegateMethod = new GUIDelegate(this.DoGUIUpdate);
                this.Invoke(delegateMethod, new object[] { });
            }
            else
            {
                string data = "";
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Etotal);
                textBox_etoday.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Pin);
                textBox_Pin.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Pout);
                textBox_Pout.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Pmax);
                textBox_Pmax.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Vrms);
                textBox_Vrms.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Irms);
                textBox_Irms.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Freq);
                textBox_Freq.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.PF);
                textBox_Pf.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Vpv1);
                textBox_vpv1.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Ipv1);
                textBox_ipv1.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Vpv2);
                textBox_vpv2.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Ipv2);
                textBox_ipv2.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Ileak);
                textBox_ileak.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Temp);
                textBox_temp.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Cum);
                textBox_e_total.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Time);
                textBox_time.Text = data;
                Update_Var_To_Object(ref data, VarType.Int, VarAddr.Date);
                DateTime time = UnixTimeStampToDateTime(Convert.ToInt32(data));
                textBox_date.Text = time.ToString();
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Err);
                textBox_ErrCode.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Vbus);
                textBox_Vbus.Text = data;

                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Vpv1Gain);
                textBox_gain_vpv1.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Vpv1Offset);
                textBox_offset_vpv1.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Ipv1Gain);
                textBox_gain_ipv1.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Ipv1Offset);
                textBox_offset_ipv1.Text = data;

                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Vpv2Gain);
                textBox_gain_vpv2.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Vpv2Offset);
                textBox_offset_vpv2.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Ipv2Gain);
                textBox_gain_ipv2.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Ipv2Offset);
                textBox_offset_ipv2.Text = data;

                Update_Var_To_Object(ref data, VarType.Float, VarAddr.VbusGain);
                textBox_gain_vbus.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.VbusOffset);
                textBox_offset_vbus.Text = data;

                Update_Var_To_Object(ref data, VarType.Float, VarAddr.VgridGain);
                textBox_gain_vgrid.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.VgridOffset);
                textBox_offset_vgrid.Text = data;

                Update_Var_To_Object(ref data, VarType.Float, VarAddr.VacGain);
                textBox_gain_vac.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.VacOffset);
                textBox_offset_vac.Text = data;

                Update_Var_To_Object(ref data, VarType.Float, VarAddr.IgridGain);
                textBox_gain_igrid.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.IgridOffset);
                textBox_offset_igrid.Text = data;

                Update_Var_To_Object(ref data, VarType.Float, VarAddr.IleakGain);
                textBox_gain_ileak.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.IleakOffset);
                textBox_offset_ileak.Text = data;

                Update_Var_To_Object(ref data, VarType.Float, VarAddr.KpVol);
                textBox_kp_vol_loop.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.KiVol);
                textBox_ki_vol_loop.Text = data;

                Update_Var_To_Object(ref data, VarType.Float, VarAddr.PrKp);
                textBox_kp_pr.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.PrKi1);
                textBox_ki_pr1.Text = data;

                Update_Var_To_Object(ref data, VarType.Float, VarAddr.PrKi3);
                textBox_ki_pr3.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.PrKi5);
                textBox_ki_pr5.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.PrKi7);
                textBox_ki_pr7.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.PrKi9);
                textBox_ki_pr9.Text = data;



                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Config_Pmax);
                textBox_PGioiHan.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Config_Vmax);
                textBox_VMax.Text = data;
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.Config_File_Vesion);
                textBox_version_config.Text = data;
                
                selected_tab = tabControl_value.SelectedIndex;
            }
        }
        #endregion

        #region Timer Elapsed Event Handler
        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (selected_tab == 0)
                PollFunction(0, 38);
            if (selected_tab == 1 && request_coef_flag == true)
            {
                PollFunction(500, 40);
                request_coef_flag = false;
            }
            if (selected_tab == 2 && request_controler_coef == true)
            {
                PollFunction(1000, 18);
                request_controler_coef = false;
            }
            if (selected_tab == 3 && request_start_dlog == true)
            {
                PollFunction(2000, 28);
                request_start_dlog = false;
            }
            if (selected_tab == 7 && requett_config_flag == true)
            {
                PollFunction(9000, 60);
                requett_config_flag = false;
            }
            
        }
        #endregion

        #region Load Listboxes
        private void LoadListboxes()
        {
            //Three to load - ports, baudrates, datetype.  Also set default textbox values:
            //1) Available Ports:
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                lstPorts.Items.Add(port);
            }

            //lstPorts.SelectedIndex = 6;

            //2) Baudrates:
            string[] baudrates = { "300", "600", "1200", "2400", "4800", "9600", "19200" };

            foreach (string baudrate in baudrates)
            {
                lstBaudrate.Items.Add(baudrate);
            }

            lstBaudrate.SelectedIndex = 1;
            txtSlaveID.Text = "118";
            txtStartAddr.Text = "0";
        }
        #endregion

        #region Start and Stop Procedures
        private void StartPoll()
        {
            pollCount = 0;

            //Open COM port using provided settings:
            if (mb.Open(lstPorts.SelectedItem.ToString(), Convert.ToInt32(lstBaudrate.SelectedItem.ToString()), 8, Parity.None, StopBits.One))
            {
                //Disable double starts:
                btnStart.Enabled = false;

                //Set polling flag:
                isPolling = true;

                //Start timer using provided values:
                timer.AutoReset = true;
                    timer.Interval = 1000;
                timer.Start();
            }

            lblStatus.Text = mb.modbusStatus;
            lbl_status.Text = "Connected";
        }
        private void StopPoll()
        {
            //Stop timer and close COM port:
            isPolling = false;
            timer.Stop();
            mb.Close();

            btnStart.Enabled = true;

            lblStatus.Text = mb.modbusStatus;
            lbl_status.Text = "DisConnected";
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartPoll();
            request_coef_flag = true;
            request_controler_coef = true;
            request_start_dlog = true;
            requett_config_flag = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopPoll();
        }
        #endregion

        #region Poll Function
        private bool PollFunction(ushort pollStart, ushort pollLength)
        {
            //Update GUI:
            DoGUIClear();
            pollCount++;
            DoGUIStatus("Poll count: " + pollCount.ToString());

            //Read registers and display data in desired format:
            try
            {
                for (int i = 10; i > 0; i--)
                {
                    if (mb.SendFc3(Convert.ToByte(txtSlaveID.Text), pollStart, pollLength, ref dataRegister.data_source))
                    {
                        i = 0;
                        DoGUIUpdate();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception err)
            {
                DoGUIStatus("Error in modbus read: " + err.Message);
            }
            return false;
        }
        #endregion

        #region Write Function
        private bool WriteFunction(ushort start, float value)
        {
            //StopPoll();
            mb.modbusStatus = "Writting...";
            if (txtSlaveID.Text != "")
            {
                byte address = Convert.ToByte(txtSlaveID.Text);
                byte[] bytes_tmp = new byte[4];
                byte[] bytes = new byte[4];
                bytes_tmp = BitConverter.GetBytes(value);
                bytes[3] = bytes_tmp[2];
                bytes[2] = bytes_tmp[3];
                bytes[1] = bytes_tmp[0];
                bytes[0] = bytes_tmp[1];

                try
                {
                    for (int i = 100; i > 0; i--)
                    {
                        if (mb.SendFc16(address, start, (ushort)2, bytes))
                        {
                            i = 0;
                            DoGUIStatus(mb.modbusStatus);
                            return true;
                        }
                    }
                    return false;
                }
                catch (Exception err)
                {
                    DoGUIStatus("Error in write function: " + err.Message);
                }
                DoGUIStatus(mb.modbusStatus);
            }
            else
                DoGUIStatus("Enter all fields before attempting a write");

            return false;
        }

        private bool WriteFunctionLong(ushort start, int value)
        {
            //StopPoll();
            mb.modbusStatus = "Writting...";
            if (txtSlaveID.Text != "")
            {
                byte address = Convert.ToByte(txtSlaveID.Text);
                byte[] bytes = new byte[4];
                int val = (value % 0x10000) * 0x10000 + (value / 0x10000);
                bytes = BitConverter.GetBytes(val);
                Array.Reverse(bytes);
                try
                {
                    for (int i = 100; i > 0; i--)
                    {
                        if (mb.SendFc16(address, start, (ushort)2, bytes))
                        {
                            DoGUIStatus(mb.modbusStatus);
                            return true;
                        }
                        i = 0;
                    }
                    DoGUIStatus(mb.modbusStatus);
                }
                catch (Exception err)
                {
                    DoGUIStatus("Error in write function: " + err.Message);
                }
            }
            else
                DoGUIStatus("Enter all fields before attempting a write");
            return false;
            //StartPoll();
        }

        private bool WriteFunction16Bit(ushort start, int value)
        {
            //StopPoll();
            mb.modbusStatus = "Writting...";
            if (txtSlaveID.Text != "")
            {
                byte address = Convert.ToByte(txtSlaveID.Text);
                byte[] bytes = new byte[2];
                bytes = BitConverter.GetBytes(value);

                try
                {
                    for (int i = 100; i > 0; i--)
                    {
                        if (mb.SendFc16(address, start, (ushort)1, bytes))
                        {
                            DoGUIStatus(mb.modbusStatus);
                            return true;
                        }
                        i = 0;
                    }
                    DoGUIStatus(mb.modbusStatus);
                }
                catch (Exception err)
                {
                    DoGUIStatus("Error in write function: " + err.Message);
                }
            }
            else
                DoGUIStatus("Enter all fields before attempting a write");
            return false;
            //StartPoll();
        }


        private void btnWrite_Click(object sender, EventArgs e)
        {
            timer.Stop();
            //WriteFunction();
            timer.Start();
        }
        #endregion

        private void Button3_Click(object sender, EventArgs e)
        {
            DrawChart(series1, series2, series3, series4);
        }

        public void DrawChart(Series series1, Series series2, Series series3, Series series4)
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 400;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 1000;
            chart1.ChartAreas[0].AxisY.Minimum = -1000;
            series1 = new Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };

            series2 = new Series
            {
                Name = "Series2",
                Color = System.Drawing.Color.Red,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };

            series3 = new Series
            {
                Name = "Series3",
                Color = System.Drawing.Color.Blue,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };

            series4 = new Series
            {
                Name = "Series4",
                Color = System.Drawing.Color.Black,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);

            chart1.Series["Series1"].BorderWidth = 3;
            chart1.Series["Series2"].BorderWidth = 3;
            chart1.Series["Series3"].BorderWidth = 3;
            chart1.Series["Series4"].BorderWidth = 3;

            for (int i = 0; i < 400; i++)
            {
                int chartValue1;
                chartValue1 = (int)dataRegister.data_source[(int)((int)VarAddr.dataDlog1 * 2 + i * 2 + 1)] << 16;
                chartValue1 |= ((int)dataRegister.data_source[((int)VarAddr.dataDlog1 + i) * 2] & 0x0000FFFF);
                chartArray1[i] = BitConverter.ToSingle(BitConverter.GetBytes(chartValue1), 0);
            }
            txtMinChart1.Text = chartArray1.Min().ToString();
            txtMaxChart1.Text = chartArray1.Max().ToString();
            double offset_value = (chartArray1.Min() + chartArray1.Max()) / 2;
            if (0 != chartArray1.Max())
            {
                rateChart = Math.Abs(volumeChart / (chartArray1.Max() - offset_value));
            }
            if (0 != chartArray1.Min())
            {
                if (rateChart > Math.Abs(volumeChart / (offset_value - chartArray1.Min())))
                    rateChart = Math.Abs(volumeChart / (offset_value -chartArray1.Min()));
            }
            for (int i = 0; i < 400; i++)
            {
                series1.Points.AddXY(i, (chartArray1[i] - offset_value )* rateChart);
            }

            for (int i = 0; i < 400; i++)
            {
                int chartValue1;
                chartValue1 = (int)dataRegister.data_source[(int)((int)VarAddr.dataDlog2 * 2 + i * 2 + 1)] << 16;
                chartValue1 |= ((int)dataRegister.data_source[((int)VarAddr.dataDlog2 + i) * 2] & 0x0000FFFF);

                chartArray2[i] = BitConverter.ToSingle(BitConverter.GetBytes(chartValue1), 0);
            }

            txtMinChart2.Text = chartArray2.Min().ToString();
            txtMaxChart2.Text = chartArray2.Max().ToString();
            offset_value = (chartArray2.Min() + chartArray2.Max()) / 2;
            if (0 != chartArray2.Max())
            {
                rateChart = Math.Abs(volumeChart / (chartArray2.Max() - offset_value));
            }
            if (0 != chartArray2.Min())
            {
                if (rateChart > Math.Abs(volumeChart / (offset_value - chartArray2.Min())))
                    rateChart = Math.Abs(volumeChart / (offset_value - chartArray2.Min()));
            }
            for (int i = 0; i < 400; i++)
            {
                series2.Points.AddXY(i, (chartArray2[i] - offset_value) * rateChart);
            }

            for (int i = 0; i < 400; i++)
            {
                int chartValue1;
                chartValue1 = (int)dataRegister.data_source[(int)((int)VarAddr.dataDlog3 * 2 + i * 2 + 1)] << 16;
                chartValue1 |= ((int)dataRegister.data_source[((int)VarAddr.dataDlog3 + i) * 2] & 0x0000FFFF);
                chartArray3[i] = BitConverter.ToSingle(BitConverter.GetBytes(chartValue1), 0);
            }
            txtMinChart3.Text = chartArray3.Min().ToString();
            txtMaxChart3.Text = chartArray3.Max().ToString();
            offset_value = (chartArray3.Min() + chartArray3.Max()) / 2;
            if (0 != chartArray3.Max())
            {
                rateChart = Math.Abs(volumeChart / (chartArray3.Max() - offset_value));
            }
            if (0 != chartArray3.Min())
            {
                if (rateChart > Math.Abs(volumeChart / (offset_value - chartArray3.Min())))
                    rateChart = Math.Abs(volumeChart / (offset_value - chartArray3.Min()));
            }
            for (int i = 0; i < 400; i++)
            {
                series3.Points.AddXY(i, (chartArray3[i] - offset_value) * rateChart);
            }

            for (int i = 0; i < 400; i++)
            {
                int chartValue1;
                chartValue1 = (int)dataRegister.data_source[(int)((int)VarAddr.dataDlog4 * 2 + i * 2 + 1)] << 16;
                chartValue1 |= ((int)dataRegister.data_source[((int)VarAddr.dataDlog4 + i) * 2] & 0x0000FFFF);
                chartArray4[i] = BitConverter.ToSingle(BitConverter.GetBytes(chartValue1), 0);
            }
            txtMinChart4.Text = chartArray4.Min().ToString();
            txtMaxChart4.Text = chartArray4.Max().ToString();
            offset_value = (chartArray4.Min() + chartArray4.Max()) / 2;
            if (0 != chartArray4.Max())
            {
                rateChart = Math.Abs(volumeChart / (chartArray4.Max() - offset_value));
            }
            if (0 != chartArray4.Min())
            {
                if (rateChart > Math.Abs(volumeChart / (offset_value - chartArray4.Min())))
                    rateChart = Math.Abs(volumeChart / (offset_value - chartArray4.Min()));
            }
            for (int i = 0; i < 400; i++)
            {
                series4.Points.AddXY(i, (chartArray4[i] - offset_value) * rateChart);
            }

        }
        private void tabControl_value_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_tab = tabControl_value.SelectedIndex;
        }

        private void button_set_gain_vpv1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2*(ushort)(VarAddr.Vpv1Gain), float.Parse(textBox_gain_vpv1.Text));
            timer.Start();
        }

        private void button_ReadCoeff_Click(object sender, EventArgs e)
        {
            request_coef_flag = true;
        }

        private void button_set_offset_vpv1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.Vpv1Offset), float.Parse(textBox_offset_vpv1.Text));
            timer.Start();
        }

        private void button_set_gain_ipv1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.Ipv1Gain), float.Parse(textBox_gain_ipv1.Text));
            timer.Start();
        }

        private void button_set_offset_ipv1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.Ipv1Offset), float.Parse(textBox_offset_ipv1.Text));
            timer.Start();
        }

        private void button_set_gain_vpv2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.Vpv2Gain), float.Parse(textBox_gain_vpv2.Text));
            timer.Start();
        }

        private void button_set_offset_vpv2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.Vpv2Offset), float.Parse(textBox_offset_vpv2.Text));
            timer.Start();
        }

        private void button_set_gain_ipv2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.Ipv2Gain), float.Parse(textBox_gain_ipv2.Text));
            timer.Start();
        }

        private void button_set_offset_ipv2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.Ipv2Offset), float.Parse(textBox_offset_ipv2.Text));
            timer.Start();
        }

        private void button_set_gain_vgrid_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.VgridGain), float.Parse(textBox_gain_vgrid.Text));
            timer.Start();
        }

        private void button_set_offset_vgrid_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.VgridOffset), float.Parse(textBox_offset_vgrid.Text));
            timer.Start();
        }

        private void button_set_gain_igrid_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.IgridGain), float.Parse(textBox_gain_igrid.Text));
            timer.Start();
        }

        private void button_set_offset_igrid_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.IgridOffset), float.Parse(textBox_offset_igrid.Text));
            timer.Start();
        }

        private void button_set_gain_vac_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.VacGain), float.Parse(textBox_gain_vac.Text));
            timer.Start();
        }

        private void button_set_offset_vac_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.VacOffset), float.Parse(textBox_offset_vac.Text));
            timer.Start();
        }

        private void button_set_gain_ileak_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.IleakGain), float.Parse(textBox_gain_ileak.Text));
            timer.Start();
        }

        private void button1_set_offset_ileak_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.IleakOffset), float.Parse(textBox_offset_ileak.Text));
            timer.Start();
        }

        private void button_set_gain_vbus_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.VbusGain), float.Parse(textBox_gain_vbus.Text));
            timer.Start();
        }

        private void button_set_offset_vbus_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.VbusOffset), float.Parse(textBox_offset_vbus.Text));
            timer.Start();
        }

        private void button_read_controller_Click(object sender, EventArgs e)
        {
            request_controler_coef = true;
        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int intValue = 0;
            string var_name = "";
            string line_selected = m_combo.Text;//.SelectedItem.ToString();
            string[] data_value = line_selected.Split(new char[] {' '});
            try
            {
                var_name = data_value[0];
                intValue = Convert.ToInt32(data_value[1], 16);
            }
            catch
            {
                MessageBox.Show("Fomat Hex wrong");
            }

            if (cbbLineChart.Text == "Line 1")
            {
                timer.Stop();
                if (WriteFunctionLong(2 * (ushort)(VarAddr.DlogIn1), intValue) == true)
                {
                    txtLineChart1.Text = var_name;
                }
                timer.Start();
            }
            if (cbbLineChart.Text == "Line 2")
            {
                timer.Stop();
                if(WriteFunctionLong(2 * (ushort)(VarAddr.DlogIn2), intValue) == true)
                {
                    txtLineChart2.Text = var_name;
                }
                timer.Start();
            }
            if (cbbLineChart.Text == "Line 3")
            {
                timer.Stop();
                if(WriteFunctionLong(2 * (ushort)(VarAddr.DlogIn3), intValue) == true)
                {
                    txtLineChart3.Text = var_name;
                }
                timer.Start();
            }
            if (cbbLineChart.Text == "Line 4")
            {
                timer.Stop();
                if(WriteFunctionLong(2 * (ushort)(VarAddr.DlogIn4), intValue) == true)
                {
                    txtLineChart4.Text = var_name;
                }
                timer.Start();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int time_wait;
            timer.Stop();
            btnRunChart.Enabled = false;
            if (checkBox_Trigger.Checked == true)
            {
                timer.Stop();
                if(WriteFunction(2 * (ushort)(VarAddr.trigerValue), float.Parse(textBox_Trigger.Text)) == false)
                {
                    MessageBox.Show("Get data fail!!!");
                    return;
                }
                if (WriteFunctionLong(2 * (ushort)(VarAddr.Enable), 3) == false)
                {
                    MessageBox.Show("Get data fail!!!");
                    return;
                }
                timer.Start();
            }
            else
            {
                if (WriteFunctionLong(2 * (ushort)(VarAddr.Enable), 1) == false)
                {
                    MessageBox.Show("Get data fail!!!");
                    return;
                }
            }
            timer.Start();
            if (checkBox_Trigger.Checked == true)
            {
                time_wait = Convert.ToInt32(textBox_timewaittrigger.Text);
                if (time_wait <= 0) time_wait = 100;
            }
            else
                time_wait = 100;
            for (int i = time_wait; i > 0; i--)
            {
                if (PollFunction(2 * (ushort)VarAddr.Status, 2) == true)
                {
                    Thread.Sleep(500);
                    int intValue = (int)dataRegister.data_source[((int)VarAddr.Status) * 2 + 1];
                    intValue <<= 16;
                    intValue |= (int)(dataRegister.data_source[((int)VarAddr.Status) * 2] & 0x0000ffff);
                    if (0 != BitConverter.ToSingle(BitConverter.GetBytes(intValue), 0))
                    {
                        if (txtLineChart1.Text != "")
                        {
                            for (int j = 0; j < 40; j++)
                            {
                                if (PollFunction((ushort)((ushort)VarAddr.dataDlog1 * 2 + j * 20), 20) == false)
                                    goto error;
                            }
                        }

                        if (txtLineChart2.Text != "")
                        {
                            for (int j = 0; j < 40; j++)
                            {
                                if (PollFunction((ushort)((ushort)VarAddr.dataDlog2 * 2 + j * 20), 20) == false)
                                    goto error;
                            }
                        }

                        if (txtLineChart3.Text != "")
                        {
                            for (int j = 0; j < 40; j++)
                            {
                                if (PollFunction((ushort)((ushort)VarAddr.dataDlog3 * 2 + j * 20), 20) == false)
                                    goto error;
                            }
                        }

                        if (txtLineChart4.Text != "")
                        {
                            for (int j = 0; j < 40; j++)
                            {
                                if (PollFunction((ushort)((ushort)VarAddr.dataDlog4 * 2 + j * 20), 20) == false)
                                    goto error;
                            }
                        }

                        btnRunChart.Enabled = true;
                        return;
                    }
                }
            }
        error:
            MessageBox.Show("Get data fail!!!");
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
                chart1.Series[0].Enabled = false;
            else
                chart1.Series[0].Enabled = true;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                chart1.Series[1].Enabled = false;
            else
                chart1.Series[1].Enabled = true;
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                chart1.Series[2].Enabled = false;
            else
                chart1.Series[2].Enabled = true;
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                chart1.Series[3].Enabled = false;
            else
                chart1.Series[3].Enabled = true;
        }


        private void button_restore_data_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunctionLong(2 * (ushort)(VarAddr.CoeffApply), 3);
            timer.Start();
        }

        private void button_save_coef_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunctionLong(2 * (ushort)(VarAddr.CoeffApply), 2);
            timer.Start();
        }

        private void button28_Click(object sender, EventArgs e)
        {
        }

        private void button_set_kp_vol_loop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.KpVol), float.Parse(textBox_kp_vol_loop.Text));
            timer.Start();
        }

        private void button_set_ki_vol_loop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.KiVol), float.Parse(textBox_ki_vol_loop.Text));
            timer.Start();
        }

        private void button_set_kp_pr_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.PrKp), float.Parse(textBox_kp_pr.Text));
            timer.Start();
        }

        private void button_set_ki_pr1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.PrKi1), float.Parse(textBox_ki_pr1.Text));
            timer.Start();
        }

        private void button_set_ki_pr3_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.PrKi3), float.Parse(textBox_ki_pr3.Text));
            timer.Start();
        }

        private void button_set_ki_pr5_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.PrKi5), float.Parse(textBox_ki_pr5.Text));
            timer.Start();
        }

        private void button_set_ki_pr7_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.PrKi7), float.Parse(textBox_ki_pr7.Text));
            timer.Start();
        }

        private void button_set_ki_pr9_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.PrKi9), float.Parse(textBox_ki_pr9.Text));
            timer.Start();
        }

        private void button_apply_controller_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunctionLong(2 * (ushort)(VarAddr.ControlerApply), 2);
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunctionLong(2 * (ushort)(VarAddr.PreScalar), Convert.ToInt32(textBox_scale.Text));
            timer.Start();
        }

        private void button_saveFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            SaveFileDialog sfd = new SaveFileDialog();
            //Display dialog and see if OK button was pressed
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(sfd.FileName + "1.txt");
                for (int i = 0; i < 400; i++)
                {
                    int chartValue1;
                    chartValue1 = (int)dataRegister.data_source[(ushort)((ushort)VarAddr.dataDlog1 * 2 + i * 2 + 1)] << 16;
                    chartValue1 |= ((int)dataRegister.data_source[((ushort)VarAddr.dataDlog1 + i) * 2] & 0xFFFF);
                    float value = BitConverter.ToSingle(BitConverter.GetBytes(chartValue1), 0);
                    string data_save = value.ToString();
                    writer.WriteLine(data_save);
                }
                writer.Close();
                StreamWriter writer2 = new StreamWriter(sfd.FileName + "2.txt");
                for (int i = 0; i < 400; i++)
                {
                    int chartValue1;
                    chartValue1 = (int)dataRegister.data_source[(ushort)((ushort)VarAddr.dataDlog2 * 2 + i * 2 + 1)] << 16;
                    chartValue1 |= ((int)dataRegister.data_source[((ushort)VarAddr.dataDlog2 + i) * 2] & 0xFFFF);
                    float value = BitConverter.ToSingle(BitConverter.GetBytes(chartValue1), 0);
                    string data_save = value.ToString();
                    writer2.WriteLine(data_save);
                }
                writer2.Close();
                StreamWriter writer3 = new StreamWriter(sfd.FileName + "3.txt");
                for (int i = 0; i < 400; i++)
                {
                    int chartValue1;
                    chartValue1 = (int)dataRegister.data_source[(ushort)((ushort)VarAddr.dataDlog3 * 2 + i * 2 + 1)] << 16;
                    chartValue1 |= ((int)dataRegister.data_source[((ushort)VarAddr.dataDlog3 + i) * 2] & 0xFFFF);
                    float value = BitConverter.ToSingle(BitConverter.GetBytes(chartValue1), 0);
                    string data_save = value.ToString();
                    writer3.WriteLine(data_save);
                }
                writer3.Close();
                StreamWriter writer4 = new StreamWriter(sfd.FileName + "4.txt");
                for (int i = 0; i < 400; i++)
                {
                    int chartValue1;
                    chartValue1 = (int)dataRegister.data_source[(ushort)((ushort)VarAddr.dataDlog4 * 2 + i * 2 + 1)] << 16;
                    chartValue1 |= ((int)dataRegister.data_source[((ushort)VarAddr.dataDlog4 + i) * 2] & 0xFFFF);
                    float value = BitConverter.ToSingle(BitConverter.GetBytes(chartValue1), 0);
                    string data_save = value.ToString();
                    writer4.WriteLine(data_save);
                }
                writer4.Close();
            }
        }

        private void button_set_kp_pi_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.KpCur), float.Parse(textBox_kp_pi.Text));
            timer.Start();
        }

        private void button_set_ki_pi_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.KiCur), float.Parse(textBox_ki_pi.Text));
            timer.Start();
        }

        private void button_ClearData_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunctionLong(2 * (ushort)(VarAddr.NVDataApply), 2);
            timer.Start();
        }
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Int32 unixTimestamp;
            CultureInfo provider = CultureInfo.InvariantCulture;
            provider = new CultureInfo("fr-FR");
            DateTime date_time = DateTime.ParseExact(textBox_time_setup.Text, "MM/dd/yyyy HH:mm:ss", provider);
            unixTimestamp = (Int32)(date_time.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            timer.Stop();
            WriteFunctionLong(2 * (ushort)(VarAddr.UpdateTime), unixTimestamp);
            timer.Start();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox_time_setup.Text = DateTime.UtcNow.ToString("MM/dd/yyyy HH:mm:ss");
        }

        [StructLayout(LayoutKind.Explicit)]
        struct LogEvenntData
        {
            [FieldOffset(0)] public UInt16 Data_Type;
            [FieldOffset(2)] public UInt16 So_thu_tu;
            [FieldOffset(4)] public UInt32 DateTime;
            [FieldOffset(8)] public UInt16 log_type;
            [FieldOffset(10)] public UInt32 guiErrCode;
            [FieldOffset(14)] public float guiPin;
            [FieldOffset(18)] public float guiVrms;
            [FieldOffset(22)] public float guiIrms;
            [FieldOffset(24)] public float guiFreqAvg;
            [FieldOffset(28)] public float guiPowerFactor;
            [FieldOffset(30)] public float guiVpv1;
            [FieldOffset(34)] public float guiIpv1;
            [FieldOffset(38)] public float guiVpv2;
            [FieldOffset(42)] public float guiIpv2;
            [FieldOffset(46)] public float guiTempt;
            [FieldOffset(50)] public float guiCum;
            [FieldOffset(54)] public float guiVbus;
        }

        private void ReadLog_Click(object sender, EventArgs e)
        {
            richTextBox_Log.Clear();
            for (int i = Convert.ToInt32(textBox_logStart.Text); i <= Convert.ToInt32(textBox_logEnd.Text); i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (WriteFunctionLong(2 * (ushort)(VarAddr.logeventindex), (int)(i | 0x80000000)) == false)
                    {
                        continue;
                    }
                    break;
                }
                if (PollFunction((ushort)((ushort)VarAddr.logeventdata * 2), 64) == false)
                    return;
                if (LogDataProcess() == false)
                    return;
                Thread.Sleep(50);
            }
        }

        private bool LogDataProcess()
        {
            int Data_Type = 0;
            Update_Var_To_Object(ref Data_Type, VarAddr.logeventdata);
            if(Data_Type == 0x3456) // Data
            {
                int Stt = 0;  Update_Var_To_Object(ref Stt, VarAddr.logStt);
                int DateTime = 0; Update_Var_To_Object(ref DateTime, VarAddr.logDateTime);
                int LogType = 0; Update_Var_To_Object(ref LogType, VarAddr.logType);
                DateTime time = UnixTimeStampToDateTime(Convert.ToInt32(DateTime));
                if(LogType == 0) // Data
                {
                    float logguiErrCode = 0.0F;
                    Update_Var_To_Object(ref logguiErrCode, VarAddr.logguiErrCode);
                    float logguiPin = 0.0F;
                    Update_Var_To_Object(ref logguiPin, VarAddr.logguiPin);
                    float logguiVrms = 0.0F;
                    Update_Var_To_Object(ref logguiVrms, VarAddr.logguiVrms);
                    float logguiIrms = 0.0F;
                    Update_Var_To_Object(ref logguiIrms, VarAddr.logguiIrms);
                    float logguiFreqAvg = 0.0F;
                    Update_Var_To_Object(ref logguiFreqAvg, VarAddr.logguiFreqAvg);
                    float logguiPowerFactor = 0.0F;
                    Update_Var_To_Object(ref logguiPowerFactor, VarAddr.logguiPowerFactor);
                    float logguiVpv1 = 0.0F;
                    Update_Var_To_Object(ref logguiVpv1, VarAddr.logguiVpv1);
                    float logguiIpv1 = 0.0F;
                    Update_Var_To_Object(ref logguiIpv1, VarAddr.logguiIpv1);
                    float logguiVpv2 = 0.0F;
                    Update_Var_To_Object(ref logguiVpv2, VarAddr.logguiVpv2);
                    float logguiIpv2 = 0.0F;
                    Update_Var_To_Object(ref logguiIpv2, VarAddr.logguiIpv2);
                    float logguiTempt = 0.0F;
                    Update_Var_To_Object(ref logguiTempt, VarAddr.logguiTempt);
                    float logguiCum = 0.0F;
                    Update_Var_To_Object(ref logguiCum, VarAddr.logguiCum);
                    float logguiVbus = 0.0F;
                    Update_Var_To_Object(ref logguiVbus, VarAddr.logguiVbus);
                    richTextBox_Log.AppendText(time.ToString() +   "### STT= " + Stt + " | ErrorCode= " + logguiErrCode + " | Pin= " + logguiPin + " | Vrms= " + logguiVrms + " | Irms= " + logguiIrms + " | Freq= " 
                                                                                            + logguiFreqAvg + " | PF= " + logguiPowerFactor + " | Vpv1= " + logguiVpv1 + " | Ipv1= " + logguiIpv1 + " | Vpv2= " 
                                                                                            + logguiVpv2 + " | Ipv2= " + logguiIpv2 + " | Temp= " + logguiTempt + " | SLLK= " + logguiCum + " | Vbus= " + logguiVbus + Environment.NewLine);
                }
                else if(LogType == 1) //Event
                {
                    byte[] data = new byte[120];
                    for(int i = 0; i < 120; i++)
                        data[i] = (byte)dataRegister.data_source[(int)VarAddr.logguiErrCode * 2 + i];
                    string str = System.Text.Encoding.UTF8.GetString(data);
                    richTextBox_Log.AppendText(time.ToString() + "### STT= " + Stt + " ===== "+ str);
                    richTextBox_Log.AppendText(Environment.NewLine);
                }
                else if(LogType == -1)
                {
                    return false;
                }
            }
            if (Data_Type == -1) // Data
                 return false;
            return true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WriteFunctionLong(2 * (ushort)(VarAddr.logeventindex), -1);
        }

        private void richTextBox_Log_TextChanged(object sender, EventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            // set the current caret position to the end
            rtb.SelectionStart = rtb.Text.Length;
            // scroll it automatically
            rtb.ScrollToCaret();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string infoString = textBoxSerial.Text + textBoxDevKey.Text + textBoxSwKey.Text;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(infoString);
            int len = infoString.Length;
            int sleep = 15;

            for (int i = 0; i < len; i++)
            {
                UInt16 j = Convert.ToUInt16(VarAddr.DeviceInfo);
                j = Convert.ToUInt16(2 * j + Convert.ToUInt16(i));
                Thread.Sleep(sleep);
                timer.Stop();

                if(false == WriteFunctionLong(j, asciiBytes[i]))
                {
                    MessageBox.Show("Send data fail", "Error");
                    return;
                }
                timer.Start();
            }

            Thread.Sleep(sleep);
            timer.Stop();
            if (false == WriteFunctionLong(2 * (ushort)(VarAddr.DeviceState), 0x00010001))
            {
                MessageBox.Show("Send data fail", "Error");
                return;
            }
            timer.Start();

            Thread.Sleep(sleep);
            MessageBox.Show("Send data success!", "Success");
            
            return;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string data = "";

            ///////////////////////////-Doc thong tin
            if (false == PollFunction(8800, 40))
            {
                MessageBox.Show("Read Information Fail!", "Fail");
                return;
            }
            Update_Var_To_Object(ref data, VarType.Int, VarAddr.DeviceReadInfo);

            string str, str1, str2;
            int i, value;
            string serial = "";

            for (int j = 0; j < 14; j++)
            {
                Update_Var_To_Object(ref data, VarType.Int, VarAddr.DeviceReadInfo + j);
                str = int.Parse(data).ToString("X4");
                i = str.Length;

                if (i >= 2)
                {
                    if (i <= 4)
                    {
                        str1 = str.Substring(0, i - 1);
                        value = Convert.ToInt32(str1);
                        serial += Char.ConvertFromUtf32(value);
                    }
                    else
                    {
                        str1 = str.Substring(i - 4, i - 2);
                        value = Convert.ToInt32(str1, 16);
                        serial += Char.ConvertFromUtf32(value);

                        str2 = str.Substring(0, i - 4);
                        value = Convert.ToInt32(str2, 16);
                        serial += Char.ConvertFromUtf32(value);
                    }
                }
            }

            //MessageBox.Show(serial.Substring(0, 12), "Device Information");
            int len = serial.Length;
            txtSerialReadInfo.Text = serial.Substring(0, 12);
            txtSerialReadDvKey.Text = serial.Substring(12, 8);
            txtSerialReadSwKey.Text = serial.Substring(20, 7);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBoxSerial.Text = "VTSL12345678";
            textBoxDevKey.Text = "abcd1234";
            textBoxSwKey.Text = "a1b2c3d4";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            int index = cbbParam.SelectedIndex;

            if (false == PollFunction(9200, 20))
            {
                MessageBox.Show("Read Information Fail!", "Fail");
                return;
            }

            string data = "";

            if(index == 8)
            {
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.DeviceAdc + index);
                txtGetAdc1.Text = data;
            }
            else
            {
                Update_Var_To_Object(ref data, VarType.Int, VarAddr.DeviceAdc + index);
                txtGetAdc1.Text = data;
            }

            return;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            int index = cbbParam.SelectedIndex;

            if (false == PollFunction(9200, 40))
            {
                MessageBox.Show("Read Information Fail!", "Fail");
                return;
            }

            string data = "";

            if (index == 8)
            {
                Update_Var_To_Object(ref data, VarType.Float, VarAddr.DeviceAdc + index);
                txtGetAdc2.Text = data;
            }
            else
            {
                Update_Var_To_Object(ref data, VarType.Int, VarAddr.DeviceAdc + index);
                txtGetAdc2.Text = data;
            }

            return;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            int sleep = 15;
            float param1, param2;
            int index = cbbParam.SelectedIndex;

            param1 = (float.Parse(txtParam1.Text) - float.Parse(txtParam2.Text)) / (float.Parse(txtGetAdc1.Text) - float.Parse(txtGetAdc2.Text));
            param2 = float.Parse(txtGetAdc1.Text) * param1 - float.Parse(txtParam1.Text);

            Thread.Sleep(sleep);
            timer.Stop();

            if (false == WriteFunction(Convert.ToUInt16(2 * Convert.ToUInt16(VarAddr.DeviceAdcParam) + Convert.ToUInt16(index) * 4), param1))
            {
                MessageBox.Show("Send data fail", "Error");
                return;
            }
            timer.Start();

            Thread.Sleep(sleep);
            timer.Stop();
            if (false == WriteFunction(Convert.ToUInt16(2 * Convert.ToUInt16(VarAddr.DeviceAdcParam) + Convert.ToUInt16(index) * 4 + 2), param2))
            {
                MessageBox.Show("Send data fail", "Error");
                return;
            }
            timer.Start();

            Thread.Sleep(sleep);
            timer.Stop();
            if (false == WriteFunctionLong(2 * (ushort)(VarAddr.DeviceState), 0x00020002 + Convert.ToInt32(index * (0x00100000))))
            {
                MessageBox.Show("Send data fail", "Error");
                return;
            }
            timer.Start();

            return;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (false == WriteFunctionLong(2 * (ushort)(VarAddr.DeviceState), 0x00F20002))
            {
                MessageBox.Show("Send data fail", "Error");
                return;
            }
            timer.Start();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            int index = cbbParam.SelectedIndex;

            if (false == PollFunction(10000, 40))
            {
                MessageBox.Show("Read Information Fail!", "Fail");
                return;
            }

            string data = "";
            Update_Var_To_Object(ref data, VarType.Float, VarAddr.DeviceAdc + index);
            txtCheckValue.Text = data;

            return;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (false == WriteFunctionLong(2 * (ushort)(VarAddr.DeviceDuty), Int32.Parse(txtDuty.Text)))
            {
                MessageBox.Show("Send data fail", "Error");
                return;
            }
            timer.Start();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            txtParam1.Text = "";
            txtParam2.Text = "";
            txtGetAdc1.Text = "";
            txtGetAdc2.Text = "";
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (relayStatus == true)
            {
                if (false == WriteFunctionLong(2 * (ushort)(VarAddr.DeviceRelay), 1))
                {
                    MessageBox.Show("Send data fail", "Error");
                    return;
                }
                relayStatus = false;
                btnRelay.Text = "Open Relay";
            }
            else
            {
                if (false == WriteFunctionLong(2 * (ushort)(VarAddr.DeviceRelay), 0))
                {
                    MessageBox.Show("Send data fail", "Error");
                    return;
                }
                relayStatus = true;
                btnRelay.Text = "Close Relay";
            }

            timer.Start();
        }

        private void Button18_Click_1(object sender, EventArgs e)
        {
            txtSerialReadInfo.Text = "";
            txtSerialReadDvKey.Text = "";
            txtSerialReadSwKey.Text = "";
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            if (false == PollFunction(8000, 2))
            {
                MessageBox.Show("Read Information Fail!", "Fail");
                return;
            }

            string data = "";
            Update_Var_To_Object(ref data, VarType.Int, VarAddr.DeviceState);

            if (0 == int.Parse(data))
            {
                MessageBox.Show("Write Information Success!", "Success");
            }
            else
            {
                MessageBox.Show("Write Information Fail!", "Fail");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            requett_config_flag = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.Config_Pmax), float.Parse(textBox_PGioiHan.Text));
            timer.Start();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.Config_Vmax), float.Parse(textBox_VMax.Text));
            timer.Start();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunctionLong(2 * (ushort)(VarAddr.Config_Apply), 2);
            timer.Start();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunctionLong(2 * (ushort)(VarAddr.Config_Apply), 3);
            timer.Start();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WriteFunction(2 * (ushort)(VarAddr.Config_File_Vesion), float.Parse(textBox_version_config.Text));
            timer.Start();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            string data = "";
            byte[] data_read;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    data_read = File.ReadAllBytes(filePath);
                    UpdateDataFromFile(ref data, data_read, 4);
                    textBox_PGioiHan.Text = data;
                    UpdateDataFromFile(ref data, data_read, 8);
                    textBox_VMax.Text = data;
                    UpdateDataFromFile(ref data, data_read, 0);
                    textBox_version_config.Text = data;
                }
            }
        }

        private void UpdateDataFromFile(ref string data_out, byte[] data_source, int index)
        {
            byte[] data = new byte[4];
            data[0] = data_source[index+1];
            data[1] = data_source[index];
            data[2] = data_source[index+3];
            data[3] = data_source[index+2];
            data_out = BitConverter.ToSingle(data, 0).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            byte[] data_to_save_file = new byte[120];
            byte[] bytes = new byte[4];
            bytes = BitConverter.GetBytes(float.Parse(textBox_version_config.Text));


            CopyFloatArray(bytes, 0, data_to_save_file, 0, 4);
            bytes = BitConverter.GetBytes(float.Parse(textBox_PGioiHan.Text));
            CopyFloatArray(bytes, 0, data_to_save_file, 4, 4);
            bytes = BitConverter.GetBytes(float.Parse(textBox_VMax.Text));
            CopyFloatArray(bytes, 0, data_to_save_file, 8, 4);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                File.WriteAllBytes(saveFileDialog.FileName, data_to_save_file);
        }

        private void CopyFloatArray(byte[] source, int index_src, byte[] dest, int index_des, int len)
        {
            dest[index_des + 1] = source[index_src];
            dest[index_des] = source[index_src + 1];
            dest[index_des+3] = source[index_src + 2];
            dest[index_des+2] = source[index_src + 3];
        }

        private void cbbDataType_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_openMapFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            m_combo.Items.Clear();
            OpenFileDialog sfd = new OpenFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.StreamReader OpenFile = new System.IO.StreamReader(sfd.FileName);
                  
                    while (!OpenFile.EndOfStream)
                    {
                        string name_var = "";
                        string address = "";
                        string file_name = "";
                        string line = OpenFile.ReadLine();
                        char[] separate = { ',', ' ', '.'};
                        string[] split_var = line.Split(separate, StringSplitOptions.RemoveEmptyEntries);

                        for (int i = 0; i < split_var.Length; i++)
                        {
                            if ((split_var[i] == "data") || (split_var[i] == "bss"))
                            {
                                try
                                {
                                    if (split_var[i + 1].Contains("0x0000000")) { }
                                    else
                                    {
                                        name_var = split_var[i + 1];

                                        if (i + 2 < split_var.Length)
                                        {
                                            address = split_var[i + 2];
                                            file_name = split_var[i + 4];
                                            char[] separe_file = { '/' };
                                            string[] file_name_split = file_name.Split(separe_file);
                                            m_combo.Items.Add(name_var + " " + address + " " + file_name_split[file_name_split.Length-1]);
                                        }
                                        else
                                        {
                                            string next_line = OpenFile.ReadLine();
                                            string[] next_separate = next_line.Split(separate, StringSplitOptions.RemoveEmptyEntries);
                                            file_name = next_separate[2];
                                            char[] separe_file = { '/' };
                                            string[] file_name_split = file_name.Split(separe_file);
                                            m_combo.Items.Add(name_var + " " + next_separate[0] + " " + file_name_split[file_name_split.Length - 1]);
                                        }

                                    }
                                }
                                catch { }
                            }
                        }
/*
                        if (line.Contains(".data") || line.Contains(".bss"))
                        {
                            if (line.Contains("0x0000000000000000"))
                            {

                            }
                            else {
                                if(line.Contains("0x000000"))
                                {
                                    m_combo.Items.Add(line);
                                }
                                else
                                {
                                    string next_line = OpenFile.ReadLine();
                                    if (next_line.Contains("0x0000000000000000"))
                                    {

                                    }
                                    else if (next_line.Contains("0x000000"))
                                    {
                                        m_combo.Items.Add(line + " " + next_line);
                                    }
                                }
                            }
                        }*/
                        
                    }
                    OpenFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }


        double[] FftValues;


        private void GetFFT(string name_signal, double[] AudioValues, int SampleRate, int num_data)
        {
            double[] paddedAudio = FftSharp.Pad.ZeroPad(AudioValues);
            double[] fftMag = FftSharp.Transform.FFTmagnitude(paddedAudio);
            double total_power = 0.0;
            FftValues = new double[fftMag.Length];

            double fftPeriod = FftSharp.Transform.FFTfreqPeriod(SampleRate, fftMag.Length);


            for (int i = 0; i < fftMag.Length; i++)
            {
                total_power += fftMag[i] * fftMag[i];
            }

            for (int i = 0; i < fftMag.Length; i++)
            {
                FftValues[i] += 100*(fftMag[i] * fftMag[i]) / total_power;
            }


            // find the frequency peak
            int peakIndex = 0;
            for (int i = 0; i < fftMag.Length; i++)
            {
                if (fftMag[i] > fftMag[peakIndex])
                    peakIndex = i;
            }
            fftPeriod = FftSharp.Transform.FFTfreqPeriod(SampleRate, fftMag.Length);
            double peakFrequency = fftPeriod * peakIndex;

            double fftPeakMag = fftMag.Max();

            series1 = new Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
            };
            chart_thd.ChartAreas[0].AxisX.Maximum = fftMag.Length;
            chart_thd.ChartAreas[0].AxisX.Minimum = 0;
            chart_thd.ChartAreas[0].AxisY.Maximum = 100;
            chart_thd.ChartAreas[0].AxisY.Minimum = 0;

            chart_thd.Series.Clear();
            for (int i = 0; i < fftMag.Length; i++)
            {
                series1.Points.AddXY(Math.Round(i* fftPeriod), ((float)Math.Round(10*FftValues[i]))/10);
            }

           

            chart_thd.Series.Add(series1);
            var chartArea = chart_thd.ChartAreas[series1.ChartArea];
            chartArea.CursorX.AutoScroll = true;

            // let's zoom to [0,blockSize] (e.g. [0,100])
            chartArea.AxisX.ScaleView.Zoomable = true;

            chart_thd.Series["Series1"].IsValueShownAsLabel = true;
            chart_thd.Series["Series1"].LabelFormat = ".#";

            chart_thd.Series["Series1"].BorderWidth = 3;
        }

        private void comboBox_LineTHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            double[] data_in = new double[256];
            int chartValue;

            if (comboBox_LineTHD.Text == "Line 1")
            {
                for (int i = 0; i < 256; i++)
                {
                    chartValue = (int)dataRegister.data_source[(ushort)((ushort)VarAddr.dataDlog1 * 2 + i * 2 + 1)] << 16;
                    chartValue |= ((int)dataRegister.data_source[((ushort)VarAddr.dataDlog1 + i) * 2] & 0xFFFF);
                    float value = BitConverter.ToSingle(BitConverter.GetBytes(chartValue), 0);
                    data_in[i] = (double)value;
                }
            }
            if (comboBox_LineTHD.Text == "Line 2")
            {
                for (int i = 0; i < 256; i++)
                {
                    chartValue = (int)dataRegister.data_source[(ushort)((ushort)VarAddr.dataDlog2 * 2 + i * 2 + 1)] << 16;
                    chartValue |= ((int)dataRegister.data_source[((ushort)VarAddr.dataDlog2 + i) * 2] & 0xFFFF);
                    float value = BitConverter.ToSingle(BitConverter.GetBytes(chartValue), 0);
                    data_in[i] = (double)value;
                }
            }
            if (comboBox_LineTHD.Text == "Line 3")
            {
                for (int i = 0; i < 256; i++)
                {
                    chartValue = (int)dataRegister.data_source[(ushort)((ushort)VarAddr.dataDlog3 * 2 + i * 2 + 1)] << 16;
                    chartValue |= ((int)dataRegister.data_source[((ushort)VarAddr.dataDlog3 + i) * 2] & 0xFFFF);
                    float value = BitConverter.ToSingle(BitConverter.GetBytes(chartValue), 0);
                    data_in[i] = (double)value;
                }
            }
            if (comboBox_LineTHD.Text == "Line 4")
            {
                for (int i = 0; i < 256; i++)
                {
                    chartValue = (int)dataRegister.data_source[(ushort)((ushort)VarAddr.dataDlog4 * 2 + i * 2 + 1)] << 16;
                    chartValue |= ((int)dataRegister.data_source[((ushort)VarAddr.dataDlog4 + i) * 2] & 0xFFFF);
                    float value = BitConverter.ToSingle(BitConverter.GetBytes(chartValue), 0);
                    data_in[i] = (double)value;
                }
            }

            GetFFT(comboBox_LineTHD.SelectedItem.ToString(), data_in, 1600, 400);
        }

        private void tabPage_graph_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}