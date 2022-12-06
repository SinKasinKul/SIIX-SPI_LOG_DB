namespace SPI_LOG_DB
{
    partial class MainForm
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label3 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.timerSQL = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.lbLine99 = new System.Windows.Forms.Label();
            this.rTBResult = new System.Windows.Forms.RichTextBox();
            this.bgWorkerSPI = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNamePath = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbSide = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btSettingSet = new System.Windows.Forms.Button();
            this.btSettingSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cBConnectSocock = new System.Windows.Forms.CheckBox();
            this.tBSocketIP = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tBSocketPort = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPassword1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbServer1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUser1 = new System.Windows.Forms.TextBox();
            this.tbDBName1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSMT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSPIPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btClearSocket = new System.Windows.Forms.Button();
            this.cBKeepAlive = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.rTBResultRecceive = new System.Windows.Forms.RichTextBox();
            this.rTBResultStatus = new System.Windows.Forms.RichTextBox();
            this.lbSocketStatus = new System.Windows.Forms.Label();
            this.btSocketStop = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btSocket = new System.Windows.Forms.Button();
            this.bgWSocketConnest = new System.ComponentModel.BackgroundWorker();
            this.label12 = new System.Windows.Forms.Label();
            this.lbLastDate = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(297, 227);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(213, 9);
            label1.TabIndex = 14;
            label1.Text = "Copyright© 2019 SIIX EMS (Thailand) CO.,LTD.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "SPI : ";
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btStart.Location = new System.Drawing.Point(322, 103);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(80, 39);
            this.btStart.TabIndex = 12;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // btStop
            // 
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btStop.Location = new System.Drawing.Point(408, 103);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(80, 39);
            this.btStop.TabIndex = 13;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.BtStop_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbResult.Location = new System.Drawing.Point(79, 39);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(34, 20);
            this.lbResult.TabIndex = 15;
            this.lbResult.Text = ".....";
            // 
            // timerSQL
            // 
            this.timerSQL.Tick += new System.EventHandler(this.TimerSQL_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Result :";
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btExit.Location = new System.Drawing.Point(322, 148);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(166, 31);
            this.btExit.TabIndex = 16;
            this.btExit.Text = "EXIT";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // lbLine99
            // 
            this.lbLine99.AutoSize = true;
            this.lbLine99.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLine99.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbLine99.Location = new System.Drawing.Point(71, 3);
            this.lbLine99.Name = "lbLine99";
            this.lbLine99.Size = new System.Drawing.Size(40, 24);
            this.lbLine99.TabIndex = 21;
            this.lbLine99.Text = ".....";
            // 
            // rTBResult
            // 
            this.rTBResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBResult.Location = new System.Drawing.Point(6, 66);
            this.rTBResult.Name = "rTBResult";
            this.rTBResult.ReadOnly = true;
            this.rTBResult.Size = new System.Drawing.Size(311, 114);
            this.rTBResult.TabIndex = 47;
            this.rTBResult.Text = "";
            // 
            // bgWorkerSPI
            // 
            this.bgWorkerSPI.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerSPI_DoWork_1);
            this.bgWorkerSPI.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerSPI_RunWorkerCompleted_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(332, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Qty :";
            // 
            // lbNamePath
            // 
            this.lbNamePath.AutoSize = true;
            this.lbNamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamePath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNamePath.Location = new System.Drawing.Point(384, 60);
            this.lbNamePath.Name = "lbNamePath";
            this.lbNamePath.Size = new System.Drawing.Size(19, 20);
            this.lbNamePath.TabIndex = 49;
            this.lbNamePath.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(171, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Model :";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbModel.Location = new System.Drawing.Point(244, 9);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(12, 15);
            this.lbModel.TabIndex = 51;
            this.lbModel.Text = "-";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(502, 212);
            this.tabControl1.TabIndex = 52;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage1.Controls.Add(this.lbLastDate);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.lbSide);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.rTBResult);
            this.tabPage1.Controls.Add(this.lbModel);
            this.tabPage1.Controls.Add(this.btStart);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btStop);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btExit);
            this.tabPage1.Controls.Add(this.lbResult);
            this.tabPage1.Controls.Add(this.lbNamePath);
            this.tabPage1.Controls.Add(this.lbLine99);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(494, 186);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SPI Log";
            // 
            // lbSide
            // 
            this.lbSide.AutoSize = true;
            this.lbSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSide.Location = new System.Drawing.Point(384, 80);
            this.lbSide.Name = "lbSide";
            this.lbSide.Size = new System.Drawing.Size(15, 20);
            this.lbSide.TabIndex = 53;
            this.lbSide.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(323, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 52;
            this.label13.Text = "Side :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btSettingSet);
            this.tabPage2.Controls.Add(this.btSettingSave);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(494, 186);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Socket Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btSettingSet
            // 
            this.btSettingSet.Location = new System.Drawing.Point(342, 154);
            this.btSettingSet.Name = "btSettingSet";
            this.btSettingSet.Size = new System.Drawing.Size(70, 23);
            this.btSettingSet.TabIndex = 13;
            this.btSettingSet.Text = "Set";
            this.btSettingSet.UseVisualStyleBackColor = true;
            this.btSettingSet.Click += new System.EventHandler(this.btSettingSet_Click);
            // 
            // btSettingSave
            // 
            this.btSettingSave.Location = new System.Drawing.Point(418, 154);
            this.btSettingSave.Name = "btSettingSave";
            this.btSettingSave.Size = new System.Drawing.Size(70, 23);
            this.btSettingSave.TabIndex = 12;
            this.btSettingSave.Text = "Save";
            this.btSettingSave.UseVisualStyleBackColor = true;
            this.btSettingSave.Click += new System.EventHandler(this.btSettingSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.cBConnectSocock);
            this.groupBox4.Controls.Add(this.tBSocketIP);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.tBSocketPort);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(226, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 85);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Socket Server";
            // 
            // cBConnectSocock
            // 
            this.cBConnectSocock.AutoSize = true;
            this.cBConnectSocock.Enabled = false;
            this.cBConnectSocock.Location = new System.Drawing.Point(38, 41);
            this.cBConnectSocock.Name = "cBConnectSocock";
            this.cBConnectSocock.Size = new System.Drawing.Size(66, 17);
            this.cBConnectSocock.TabIndex = 12;
            this.cBConnectSocock.Text = "Socket";
            this.cBConnectSocock.UseVisualStyleBackColor = true;
            // 
            // tBSocketIP
            // 
            this.tBSocketIP.Enabled = false;
            this.tBSocketIP.Location = new System.Drawing.Point(38, 12);
            this.tBSocketIP.Name = "tBSocketIP";
            this.tBSocketIP.Size = new System.Drawing.Size(107, 20);
            this.tBSocketIP.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(6, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "IP ::";
            // 
            // tBSocketPort
            // 
            this.tBSocketPort.Enabled = false;
            this.tBSocketPort.Location = new System.Drawing.Point(192, 12);
            this.tBSocketPort.Name = "tBSocketPort";
            this.tBSocketPort.Size = new System.Drawing.Size(61, 20);
            this.tBSocketPort.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label21.Location = new System.Drawing.Point(151, 15);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Port ::";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tbPassword1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbServer1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbUser1);
            this.groupBox2.Controls.Add(this.tbDBName1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 120);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DB Server";
            // 
            // tbPassword1
            // 
            this.tbPassword1.Enabled = false;
            this.tbPassword1.Location = new System.Drawing.Point(74, 91);
            this.tbPassword1.Name = "tbPassword1";
            this.tbPassword1.PasswordChar = '*';
            this.tbPassword1.Size = new System.Drawing.Size(134, 20);
            this.tbPassword1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(30, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "User ::";
            // 
            // tbServer1
            // 
            this.tbServer1.Enabled = false;
            this.tbServer1.Location = new System.Drawing.Point(74, 13);
            this.tbServer1.Name = "tbServer1";
            this.tbServer1.Size = new System.Drawing.Size(134, 20);
            this.tbServer1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(42, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "IP ::";
            // 
            // tbUser1
            // 
            this.tbUser1.Enabled = false;
            this.tbUser1.Location = new System.Drawing.Point(74, 65);
            this.tbUser1.Name = "tbUser1";
            this.tbUser1.Size = new System.Drawing.Size(134, 20);
            this.tbUser1.TabIndex = 3;
            // 
            // tbDBName1
            // 
            this.tbDBName1.Enabled = false;
            this.tbDBName1.Location = new System.Drawing.Point(74, 39);
            this.tbDBName1.Name = "tbDBName1";
            this.tbDBName1.Size = new System.Drawing.Size(134, 20);
            this.tbDBName1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(6, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "DB Name ::";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(6, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Password ::";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbSMT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbSPIPath);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 45);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // tbSMT
            // 
            this.tbSMT.Enabled = false;
            this.tbSMT.Location = new System.Drawing.Point(91, 13);
            this.tbSMT.Name = "tbSMT";
            this.tbSMT.Size = new System.Drawing.Size(60, 20);
            this.tbSMT.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(23, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "SMT Line ::";
            // 
            // tbSPIPath
            // 
            this.tbSPIPath.Enabled = false;
            this.tbSPIPath.Location = new System.Drawing.Point(222, 13);
            this.tbSPIPath.Name = "tbSPIPath";
            this.tbSPIPath.Size = new System.Drawing.Size(254, 20);
            this.tbSPIPath.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(157, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "SPI Path ::";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btClearSocket);
            this.tabPage3.Controls.Add(this.cBKeepAlive);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.rTBResultRecceive);
            this.tabPage3.Controls.Add(this.rTBResultStatus);
            this.tabPage3.Controls.Add(this.lbSocketStatus);
            this.tabPage3.Controls.Add(this.btSocketStop);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.btSocket);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(494, 186);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Socket Log";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btClearSocket
            // 
            this.btClearSocket.Location = new System.Drawing.Point(190, 3);
            this.btClearSocket.Name = "btClearSocket";
            this.btClearSocket.Size = new System.Drawing.Size(55, 23);
            this.btClearSocket.TabIndex = 50;
            this.btClearSocket.Text = "Clear";
            this.btClearSocket.UseVisualStyleBackColor = true;
            this.btClearSocket.Click += new System.EventHandler(this.btClearSocket_Click);
            // 
            // cBKeepAlive
            // 
            this.cBKeepAlive.AutoSize = true;
            this.cBKeepAlive.Location = new System.Drawing.Point(252, 7);
            this.cBKeepAlive.Name = "cBKeepAlive";
            this.cBKeepAlive.Size = new System.Drawing.Size(74, 17);
            this.cBKeepAlive.TabIndex = 49;
            this.cBKeepAlive.Text = "KeepAlive";
            this.cBKeepAlive.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(229, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 13);
            this.label22.TabIndex = 48;
            this.label22.Text = "Receive";
            // 
            // rTBResultRecceive
            // 
            this.rTBResultRecceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBResultRecceive.Location = new System.Drawing.Point(232, 45);
            this.rTBResultRecceive.Name = "rTBResultRecceive";
            this.rTBResultRecceive.Size = new System.Drawing.Size(256, 135);
            this.rTBResultRecceive.TabIndex = 47;
            this.rTBResultRecceive.Text = "";
            // 
            // rTBResultStatus
            // 
            this.rTBResultStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBResultStatus.Location = new System.Drawing.Point(6, 45);
            this.rTBResultStatus.Name = "rTBResultStatus";
            this.rTBResultStatus.Size = new System.Drawing.Size(220, 135);
            this.rTBResultStatus.TabIndex = 46;
            this.rTBResultStatus.Text = "";
            // 
            // lbSocketStatus
            // 
            this.lbSocketStatus.AutoSize = true;
            this.lbSocketStatus.BackColor = System.Drawing.Color.Red;
            this.lbSocketStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lbSocketStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSocketStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbSocketStatus.Location = new System.Drawing.Point(3, 3);
            this.lbSocketStatus.Name = "lbSocketStatus";
            this.lbSocketStatus.Size = new System.Drawing.Size(69, 22);
            this.lbSocketStatus.TabIndex = 45;
            this.lbSocketStatus.Text = "Offline";
            // 
            // btSocketStop
            // 
            this.btSocketStop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btSocketStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSocketStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSocketStop.Location = new System.Drawing.Point(413, 6);
            this.btSocketStop.Name = "btSocketStop";
            this.btSocketStop.Size = new System.Drawing.Size(75, 33);
            this.btSocketStop.TabIndex = 44;
            this.btSocketStop.Text = "Stop";
            this.btSocketStop.UseVisualStyleBackColor = false;
            this.btSocketStop.Click += new System.EventHandler(this.btSocketStop_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Status";
            // 
            // btSocket
            // 
            this.btSocket.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btSocket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSocket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSocket.Location = new System.Drawing.Point(332, 6);
            this.btSocket.Name = "btSocket";
            this.btSocket.Size = new System.Drawing.Size(75, 33);
            this.btSocket.TabIndex = 42;
            this.btSocket.Text = "Socket";
            this.btSocket.UseVisualStyleBackColor = false;
            this.btSocket.Click += new System.EventHandler(this.btSocket_Click);
            // 
            // bgWSocketConnest
            // 
            this.bgWSocketConnest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWSocketConnest_DoWork);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(243, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 54;
            this.label12.Text = "Date :";
            // 
            // lbLastDate
            // 
            this.lbLastDate.AutoSize = true;
            this.lbLastDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbLastDate.Location = new System.Drawing.Point(307, 39);
            this.lbLastDate.Name = "lbLastDate";
            this.lbLastDate.Size = new System.Drawing.Size(15, 20);
            this.lbLastDate.TabIndex = 55;
            this.lbLastDate.Text = "-";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(524, 245);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Traceability Log SPI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Timer timerSQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbLine99;
        private System.Windows.Forms.RichTextBox rTBResult;
        private System.ComponentModel.BackgroundWorker bgWorkerSPI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNamePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cBConnectSocock;
        private System.Windows.Forms.TextBox tBSocketIP;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tBSocketPort;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbPassword1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbServer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUser1;
        private System.Windows.Forms.TextBox tbDBName1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSMT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSPIPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btSettingSet;
        private System.Windows.Forms.Button btSettingSave;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbSocketStatus;
        private System.Windows.Forms.Button btSocketStop;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btSocket;
        private System.ComponentModel.BackgroundWorker bgWSocketConnest;
        private System.Windows.Forms.Button btClearSocket;
        private System.Windows.Forms.CheckBox cBKeepAlive;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RichTextBox rTBResultRecceive;
        private System.Windows.Forms.RichTextBox rTBResultStatus;
        private System.Windows.Forms.Label lbSide;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbLastDate;
        private System.Windows.Forms.Label label12;
    }
}

