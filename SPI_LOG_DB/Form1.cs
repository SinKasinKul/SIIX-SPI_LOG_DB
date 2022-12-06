using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SPI_LOG_DB
{
    public partial class MainForm : Form
    {
        ConnectDB ConDB = new ConnectDB();
        string Server, DBNane, User, PW;
        string SMTLine, pahtFileLog;
        string SocketIP, SocketPort, SocketConnect;
        string vProcess = "SPI";
        string vMainModel;
        int vPCBcount = 0;

        private static Socket _ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private const int BUFFER_SIZE = 2048;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];

        public delegate void callrichtext(String ss);
        public callrichtext myDelegateStatus;
        public delegate void callrichtext1(String ss);
        public callrichtext1 myDelegateReceive;
        int vSPIcount = 0;
        public MainForm()
        {
            InitializeComponent();
            AppSetting();
        }
        //Timer timerdate = new Timer();
        private void MainForm_Load(object sender, EventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;

            Int32 TimeInt = 1000;
            timerSQL.Interval = TimeInt;
            timerSQL.Tick += new EventHandler(TimerSQL_Tick);

            lbLine99.Text = SMTLine;
            this.timerSQL.Enabled = true;
            //SPI_LOG_READ();
            lbResult.Text = "Application Start...";
            lbResult.BackColor = Color.Red;

            myDelegateStatus = new callrichtext(ResultStatus);
            myDelegateReceive = new callrichtext1(ResultReceive);
        }
        private void AppSetting()
        {
            var appSettings = ConfigurationManager.AppSettings;
            Server = appSettings.Get("Server");
            DBNane = appSettings.Get("DBNane");
            User = appSettings.Get("User");
            PW = appSettings.Get("PW");

            SMTLine = appSettings.Get("SMTLine");
            pahtFileLog = appSettings.Get("pahtFileLog");

            SocketIP = appSettings.Get("SocketIP");
            SocketPort = appSettings.Get("SocketPort");
            SocketConnect = appSettings.Get("SocketConnect");

            tbServer1.Text = Server;
            tbDBName1.Text = DBNane;
            tbUser1.Text = User;
            tbPassword1.Text = PW;

            tbSMT.Text = SMTLine;
            tbSPIPath.Text = pahtFileLog;

            tBSocketIP.Text = SocketIP;
            tBSocketPort.Text = SocketPort;

            if (SocketConnect == "1")
            {
                cBConnectSocock.Checked = true;
            }
            else
            {
                cBConnectSocock.Checked = false;
            }
        }
        public void PrintResult(string RText)
        {
            string dateLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                rTBResult.AppendText(dateLog + "----> " + RText);
                //rTBResult.Text += RText;
                rTBResult.AppendText(Environment.NewLine);
            }
            catch
            {
                rTBResult.Text = "-";
            }
        }
        public void logError(string Texts)
        {
            string pathApp = Application.StartupPath;
            string Date = DateTime.Now.ToString("yyyyMMdd");
            string timeStemp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            //Clipboard.SetDataObject(Date +"---->"+ Texts);

            string subdir = pathApp + "\\Log_Error\\" + Date;

            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
            try
            {
                File.AppendAllText(subdir + "\\" + "Error_" + Date + ".txt", timeStemp + "--->" + Texts + Environment.NewLine);
            }
            catch
            {
                PrintResult("Can't export file.");
            }
        }
        private void SPI_LOG_READ()
        {
            try
            {
                rTBResult.Text = "";
                var appSettings = ConfigurationManager.AppSettings;

                //string[] entries = Directory.GetDirectories(pahtFileLog);
                //lbResult.Text = "";
                //lbResult.BackColor = Color.Red;

                string[] txtList = Directory.GetFiles(pahtFileLog, "*.txt");
                if (txtList.Length > 0)
                {
                    foreach (string sf in txtList)
                    {
                        PrintResult("Path : " + sf);
                        try
                        {
                            using (StreamReader reader = new StreamReader(File.OpenRead(sf)))
                            {
                                List<string> listA = new List<String>();
                                List<string> listB = new List<String>();
                                List<string> listC = new List<String>();
                                List<string> listD = new List<String>();
                                List<string> listE = new List<String>();
                                List<string> listF = new List<String>();
                                List<string> listG = new List<String>();
                                List<string> listH = new List<String>();
                                List<string> listI = new List<String>();
                                List<string> listJ = new List<String>();
                                List<string> listK = new List<String>();
                                List<string> listL = new List<String>();
                                List<string> listM = new List<String>();
                                List<string> listN = new List<String>();
                                List<string> listO = new List<String>();
                                List<string> listP = new List<String>();
                                List<string> listQ = new List<String>();
                                List<string> listR = new List<String>();
                                List<string> listS = new List<String>();
                                List<string> listT = new List<String>();
                                List<string> listU = new List<String>();
                                List<string> listV = new List<String>();
                                List<string> listW = new List<String>();
                                List<string> listX = new List<String>();
                                List<string> listY = new List<String>();
                                List<string> listZ = new List<String>();
                                List<string> listAA = new List<String>();
                                List<string> listAB = new List<String>();
                                List<string> listAC = new List<String>();
                                List<string> listAD = new List<String>();
                                int C = 0;

                                int cDetail = 0;
                                while (!reader.EndOfStream)
                                {
                                    string line = reader.ReadLine();
                                    if (!String.IsNullOrWhiteSpace(line))
                                    {
                                        string[] values = line.Split(',');
                                        if (values.Length == 9)
                                        {
                                            listA.Add(values[0]);
                                            listB.Add(values[1]);
                                            listC.Add(values[2]);
                                            listD.Add(values[3]);
                                            listE.Add(values[4]);
                                            listF.Add(values[5]);
                                            listG.Add(values[6]);
                                            listH.Add(values[7]);
                                            listI.Add(values[8]);
                                        }
                                        else if (values.Length == 20)
                                        {
                                            listJ.Add(values[0]);
                                            listK.Add(values[1]);
                                            listL.Add(values[2]);
                                            listM.Add(values[3]);
                                            listN.Add(values[4]);
                                            listO.Add(values[5]);
                                            listP.Add(values[6]);
                                            listQ.Add(values[7]);
                                            listR.Add(values[8]);
                                            listS.Add(values[9]);
                                            listT.Add(values[10]);
                                            listU.Add(values[11]);
                                            listV.Add(values[12]);
                                            listW.Add(values[13]);
                                            listX.Add(values[14]);
                                            listY.Add(values[15]);
                                            listZ.Add(values[16]);
                                            listAA.Add(values[17]);
                                            listAB.Add(values[18]);
                                            listAC.Add(values[19]);
                                            cDetail++;
                                        }
                                    }
                                    C++;
                                }
                                string[] vBarcode;
                                string[] InspectionDate;
                                string[] InspectionStartTime;
                                string[] InspectionEndTime;
                                string[] InspectionTestTime;
                                string[] vStatus;
                                string[] vModel;
                                string[] vSide;

                                string InspectionDateStartTime;
                                string InspectionDateEndTime;

                                vBarcode = listB.ToArray();
                                InspectionDate = listC.ToArray();
                                InspectionStartTime = listD.ToArray();
                                InspectionEndTime = listE.ToArray();
                                InspectionTestTime = listF.ToArray();
                                vStatus = listG.ToArray();
                                vModel = listH.ToArray();
                                vSide = listI.ToArray();

                                InspectionDateEndTime = InspectionDate[1] + " " + InspectionEndTime[1];

                                string vBFDateString = lbLastDate.Text;
                                if (vBFDateString == "-")
                                {
                                    vBFDateString = DateTime.Now.ToString();
                                }
                                DateTime vBFDate = DateTime.Parse(vBFDateString);
                                DateTime vAFDate = DateTime.Parse(InspectionDateEndTime);

                                double vCycleTime = (vAFDate - vBFDate).TotalSeconds;
                                int vSec = int.Parse(vCycleTime.ToString());
                                string vTSec = CalculateSec(vSec);

                                if (vModel[1].ToString() != vMainModel)
                                    vPCBcount = 0;

                                vMainModel = vModel[1];
                                vPCBcount++;
                                lbNamePath.Text = vPCBcount.ToString();
                                lbLastDate.Text = InspectionDateEndTime;
                                lbModel.Text = vModel[1];
                                lbSide.Text = vSide[1];

                                try
                                {
                                    InspectionDateStartTime = InspectionDate[1] + " " + InspectionStartTime[1];
                                    InspectionDateEndTime = InspectionDate[1] + " " + InspectionEndTime[1];

                                    string Result = ConDB.MAIN_SPI_INS(vBarcode[1].Trim(), InspectionDateStartTime, InspectionDateEndTime, InspectionTestTime[1], vStatus[1].Trim(), SMTLine);
                                    PrintResult("Barcode :" + vBarcode[1] + "--->" + vStatus[1].Trim());
                                    vSPIcount++;
                                    if (_ClientSocket.Connected)
                                    {
                                        SendText("\"Result\": [{\"Barcode\":\"" + vBarcode[1] + "\",\"Status\":\"" + vStatus[1].Trim() + "\"}]");
                                    }

                                    if(vSPIcount%10 == 0)
                                    {
                                        rTBResult.Clear();
                                        vSPIcount = 0;
                                    }
                                }
                                catch (Exception e)
                                {
                                    PrintResult("Rows : Not Found");
                                    logError(e.ToString());
                                }

                                if (vStatus[1] != "GOOD")
                                {
                                    string[] vBarcodeD;
                                    string[] vPadNo;
                                    string[] vComponentID;
                                    string[] vPadResult;
                                    string[] vPositionX;
                                    string[] vPositionY;
                                    string[] vOffsetX;
                                    string[] vOffsetY;
                                    string[] vArea;
                                    string[] vAreaUpper;
                                    string[] vAreaLower;
                                    string[] vVolume;
                                    string[] vVolumeUpper;
                                    string[] vVolumeLower;
                                    string[] vHeight;
                                    string[] vHeightUpper;
                                    string[] vHeightLower;
                                    string[] vBridgeHeight;
                                    string[] vBridgeDistance;
                                    string[] vInspectionDateTime;

                                    vBarcodeD = listJ.ToArray();
                                    vPadNo = listK.ToArray();
                                    vComponentID = listL.ToArray();
                                    vPadResult = listM.ToArray();
                                    vPositionX = listN.ToArray();
                                    vPositionY = listO.ToArray();
                                    vOffsetX = listP.ToArray();
                                    vOffsetY = listQ.ToArray();
                                    vArea = listR.ToArray();
                                    vAreaUpper = listS.ToArray();
                                    vAreaLower = listT.ToArray();
                                    vVolume = listU.ToArray();
                                    vVolumeUpper = listV.ToArray();
                                    vVolumeLower = listW.ToArray();
                                    vHeight = listX.ToArray();
                                    vHeightUpper = listY.ToArray();
                                    vHeightLower = listZ.ToArray();
                                    vBridgeHeight = listAA.ToArray();
                                    vBridgeDistance = listAB.ToArray();
                                    vInspectionDateTime = listAC.ToArray();

                                    try
                                    {
                                        int i = 1;
                                        int s = 0;
                                        int f = 0;
                                        for (i = 1; i < cDetail; i++)
                                        {
                                            string sResult;
                                            string BarcodeD = vBarcodeD[i].ToString();
                                            string PadNo = vPadNo[i].ToString();
                                            string ComponentID = vComponentID[i].ToString();
                                            string PadResult = vPadResult[i].ToString();
                                            string PositionX = vPositionX[i].ToString();
                                            string PositionY = vPositionY[i].ToString();
                                            string OffsetX = vOffsetX[i].ToString();
                                            string OffsetY = vOffsetY[i].ToString();
                                            string Area = vArea[i].ToString();
                                            string AreaUpper = vAreaUpper[i].ToString();
                                            string AreaLower = vAreaLower[i].ToString();
                                            string Volume = vVolume[i].ToString();
                                            string VolumeUpper = vVolumeUpper[i].ToString();
                                            string VolumeLower = vVolumeLower[i].ToString();
                                            string Height = vHeight[i].ToString();
                                            string HeightUpper = vHeightUpper[i].ToString();
                                            string HeightLower = vHeightLower[i].ToString();
                                            string BridgeHeight = vBridgeHeight[i].ToString();
                                            string BridgeDistance = vBridgeDistance[i].ToString();
                                            string InspectionDateTime = vInspectionDateTime[i].ToString();

                                            if (PadResult != "GOOD")
                                            {
                                                sResult = ConDB.MAIN_SPI_INS_DETAIL(BarcodeD, PadNo, ComponentID, PadResult, PositionX, PositionY, OffsetX, OffsetY, Area, AreaUpper, AreaLower, Volume, VolumeUpper, VolumeLower, Height, HeightUpper, HeightLower, BridgeHeight, BridgeDistance, InspectionDateTime);

                                                if (sResult == "success")
                                                {
                                                    s++;
                                                }
                                                else
                                                {
                                                    f++;
                                                }
                                                lbResult.Text = "Read detail :: " + i + " Rows";
                                                lbResult.BackColor = Color.Red;
                                            }
                                        }
                                        PrintResult("Barcode :" + vBarcode[1] + "--->Success: " + s + " failed: " + f);
                                    }
                                    catch
                                    {
                                        PrintResult("Barcode :" + vBarcode[1] + "--->Detail error.");
                                    }
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            PrintResult("Rows : Not Found!!!");
                            logError(e.ToString());
                        }

                        string fName = sf.Substring(pahtFileLog.Length);

                        string pathBackUp = pahtFileLog + "Backup\\";
                        string Date = DateTime.Now.ToString("yyyyMMdd");
                        string subdir = pathBackUp + Date;

                        if (!Directory.Exists(subdir))
                        {
                            Directory.CreateDirectory(subdir);
                        }

                        try
                        {
                            File.Delete(subdir + "\\" + fName);
                            File.Copy(Path.Combine(pahtFileLog, fName), Path.Combine(subdir, fName));
                            PrintResult("File copy: Success ");
                            File.Delete(sf);
                        }
                        catch (Exception e)
                        {
                            PrintResult("Can't export file.");
                            logError(e.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                PrintResult("Read file error : " + ex);
            }
        }
        private void btSettingSave_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            config.AppSettings.Settings.Remove("Server1");
            config.AppSettings.Settings.Add("Server1", tbServer1.Text);
            config.AppSettings.Settings.Remove("DBNane1");
            config.AppSettings.Settings.Add("DBNane1", tbDBName1.Text);
            config.AppSettings.Settings.Remove("User1");
            config.AppSettings.Settings.Add("User1", tbUser1.Text);
            config.AppSettings.Settings.Remove("PW1");
            config.AppSettings.Settings.Add("PW1", tbPassword1.Text);

            config.AppSettings.Settings.Remove("SMTLine");
            config.AppSettings.Settings.Add("SMTLine", tbSMT.Text);
            config.AppSettings.Settings.Remove("pahtFileLog");
            config.AppSettings.Settings.Add("pahtFileLog", tbSPIPath.Text);

            config.AppSettings.Settings.Remove("SocketIP");
            config.AppSettings.Settings.Add("SocketIP", tBSocketIP.Text);
            config.AppSettings.Settings.Remove("SocketPort");
            config.AppSettings.Settings.Add("SocketPort", tBSocketPort.Text);

            string vSocketConnect;
            if (cBConnectSocock.Checked == true)
            {
                vSocketConnect = "1";
            }
            else
            {
                vSocketConnect = "0";
            }

            config.AppSettings.Settings.Remove("SocketConnect");
            config.AppSettings.Settings.Add("SocketConnect", vSocketConnect);

            tbServer1.Enabled = false;
            tbDBName1.Enabled = false;
            tbUser1.Enabled = false;
            tbPassword1.Enabled = false;

            tbSMT.Enabled = false;
            tbSPIPath.Enabled = false;

            tBSocketIP.Enabled = false;
            tBSocketPort.Enabled = false;
            cBConnectSocock.Enabled = false;


            config.Save(ConfigurationSaveMode.Minimal);
            MessageBox.Show("Save completed", "Setting");
            Application.Restart();
            Environment.Exit(0);
        }
        private void btSettingSet_Click(object sender, EventArgs e)
        {
            tbServer1.Enabled = true;
            tbDBName1.Enabled = true;
            tbUser1.Enabled = true;
            tbPassword1.Enabled = true;

            tbSMT.Enabled = true;
            tbSPIPath.Enabled = true;

            tBSocketIP.Enabled = true;
            tBSocketPort.Enabled = true;
            cBConnectSocock.Enabled = true;
        }
        private void TimerSQL_Tick(object sender, EventArgs e)
        {
            if (bgWorkerSPI.IsBusy != true)
            {
                bgWorkerSPI.RunWorkerAsync();
            }
            else
            {
                lbResult.BackColor = Color.Red;
                lbResult.Text = "Wait...";
            }

            if (cBConnectSocock.Checked == true)
            {
                if (_ClientSocket.Connected == true && cBKeepAlive.Checked == true)
                {
                    SendText("KeepAlive");
                }

                if (bgWSocketConnest.IsBusy != true && _ClientSocket.Connected != true)
                {
                    bgWSocketConnest.RunWorkerAsync();
                }
            }
        }
        private string CalculateSec(int vSec)
        {
            string vTestSec;
            if (vSec < 60)
            {
                vTestSec = vSec + " sec.";
            }
            else if (vSec >= 60)
            {
                int vMin = vSec / 60;
                vTestSec = vMin + " min.";
            }
            else
            {
                vTestSec = "0 sec.";
            }

            return vTestSec;
        }
        private void BtStart_Click(object sender, EventArgs e)
        {
            if (bgWorkerSPI.IsBusy != true)
            {
                bgWorkerSPI.RunWorkerAsync();
            }
            this.timerSQL.Enabled = true;
            lbResult.Text = "Application Start...";
        }
        private void BtStop_Click(object sender, EventArgs e)
        {
            this.timerSQL.Enabled = false;
            lbResult.Text = "Application Stop...";
        }
        private void BtExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void bgWorkerSPI_DoWork_1(object sender, DoWorkEventArgs e)
        {
            try
            {
                SPI_LOG_READ();
            }
            catch
            {
                PrintResult("App error : " + "Error");
            }
        }
        private void bgWorkerSPI_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            PrintResult("Finish...");
        }
        private void btSocket_Click(object sender, EventArgs e)
        {
            if (bgWSocketConnest.IsBusy != true)
            {
                bgWSocketConnest.RunWorkerAsync();
            }
        }
        private void btSocketStop_Click(object sender, EventArgs e)
        {
            if (_ClientSocket.Connected)
            {
                SendText("Offline");
            }
            lbSocketStatus.Text = "Offline";
            lbSocketStatus.BackColor = Color.Red;
            btSocket.BackColor = Color.Red;
        }
        private void btClearSocket_Click(object sender, EventArgs e)
        {
            rTBResultRecceive.Clear();
            rTBResultStatus.Clear();
        }
        public void ResultStatus(string RText)
        {
            string dateLog = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            rTBResultStatus.AppendText(dateLog + "----> " + RText);
            rTBResultStatus.AppendText(Environment.NewLine);
        }
        public void ResultReceive(string RText)
        {
            string dateLog = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            rTBResultRecceive.AppendText(dateLog + "----> " + RText);
            rTBResultRecceive.AppendText("\n");
        }
        private void ConnectToServer()
        {
            int amp = 0;
            while (!_ClientSocket.Connected)
            {
                try
                {
                    rTBResultStatus.Clear();
                    amp++;
                    //ResultStatus("Connecting... (" + amp +")");
                    rTBResultStatus.Invoke(this.myDelegateStatus, new Object[] { "Connecting... (" + amp + ")" });
                    IPEndPoint iep = new IPEndPoint(IPAddress.Parse(SocketIP), int.Parse(SocketPort));
                    _ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    _ClientSocket.Connect(iep);
                    _ClientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _ClientSocket);
                    SendText("\"Status\":\"Online\"");
                    btSocket.Enabled = true;
                    btSocket.BackColor = Color.Green;

                    lbSocketStatus.Text = "Online";
                    lbSocketStatus.BackColor = Color.Green;
                    rTBResultStatus.Invoke(this.myDelegateStatus, new Object[] { "Connected to: " + _ClientSocket.RemoteEndPoint.ToString() });
                }
                catch (SocketException ex)
                {
                    rTBResultStatus.Invoke(this.myDelegateStatus, new Object[] { "Connection : " + _ClientSocket.Connected.ToString() });
                    btSocket.Enabled = true;
                    //rTBResultRecceive.Clear();
                }
            }
        }
        private void ReceiveData(IAsyncResult iar)
        {
            try
            {
                //Socket remote = (Socket)iar.AsyncState;
                int received; //= _ClientSocket.EndReceive(iar);

                try
                {
                    received = _ClientSocket.EndReceive(iar);
                }
                catch (SocketException)
                {
                    return;
                }

                if (received == 0) return;
                var data = new byte[received];
                Array.Copy(buffer, data, received);
                string receivedData = Encoding.ASCII.GetString(data);

                if (receivedData != "1")
                {
                    if (receivedData == "KeepAlive")
                    {
                        rTBResultRecceive.Clear();
                        rTBResultRecceive.Invoke(this.myDelegateReceive, new Object[] { receivedData });
                    }
                    else if (receivedData == "Offline")
                    {
                        rTBResultRecceive.Invoke(this.myDelegateReceive, new Object[] { receivedData });
                        _ClientSocket.Shutdown(SocketShutdown.Both);
                        _ClientSocket.Disconnect(true);
                        _ClientSocket.Dispose();
                        _ClientSocket.Close();
                    }
                    else
                    {
                        rTBResultRecceive.Invoke(this.myDelegateReceive, new Object[] { receivedData });
                    }
                }
            }
            catch (Exception ex)
            {
                string vExReceive = "Failed Receive";
                rTBResultRecceive.Invoke(this.myDelegateReceive, new Object[] { vExReceive });
            }
        }
        private void SendData(IAsyncResult iar)
        {
            //Socket remote = (Socket)iar.AsyncState;
            int sent;// = remote.EndSend(iar);
            try
            {
                sent = _ClientSocket.EndReceive(iar);
            }
            catch (SocketException)
            {
                _ClientSocket.Close();
                return;
            }

            if (sent == 0) return;
            try
            {
                _ClientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _ClientSocket);
            }
            catch (Exception ex)
            {
                ResultStatus(ex.Message);
            }
        }
        private void SendText(string text)
        {
            try
            {
                Wait(500);
                byte[] message = Encoding.ASCII.GetBytes("[{\"Line\":\"" + SMTLine + "\",\"Process\":\"" + vProcess + "\"," + text + "}]");
                _ClientSocket.BeginSend(message, 0, message.Length, SocketFlags.None, new AsyncCallback(SendData), _ClientSocket);
            }
            catch (Exception ex)
            {
                ResultStatus("Error Msg :: " + ex);
            }
        }
        private void bgWSocketConnest_DoWork(object sender, DoWorkEventArgs e)
        {
            ConnectToServer();
        }

        public void Wait(int time)
        {
            Thread thread = new Thread(delegate ()
            {
                System.Threading.Thread.Sleep(time);
            });
            thread.Start();
            while (thread.IsAlive)
                Application.DoEvents();
        }
    }
}
