namespace SerialPortTools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tb_Cmd = new System.Windows.Forms.TextBox();
            this.Lb_Cmd = new System.Windows.Forms.Label();
            this.Tb_Res_Data = new System.Windows.Forms.TextBox();
            this.Lb_Data = new System.Windows.Forms.Label();
            this.Bt_Connect = new System.Windows.Forms.Button();
            this.Bt_Reading = new System.Windows.Forms.Button();
            this.Bt_Input = new System.Windows.Forms.Button();
            this.Cb_Port = new System.Windows.Forms.ComboBox();
            this.Lb_Port = new System.Windows.Forms.Label();
            this.Lb_Rate = new System.Windows.Forms.Label();
            this.Cb_Rate = new System.Windows.Forms.ComboBox();
            this.Lb_Proof = new System.Windows.Forms.Label();
            this.Cb_Proof = new System.Windows.Forms.ComboBox();
            this.Lb_Data_Lenght = new System.Windows.Forms.Label();
            this.Cb_DataLenght = new System.Windows.Forms.ComboBox();
            this.Bt_Send = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Gb_Status = new System.Windows.Forms.GroupBox();
            this.Lb_Status = new System.Windows.Forms.Label();
            this.Lb_StopBits = new System.Windows.Forms.Label();
            this.Cb_StopBits = new System.Windows.Forms.ComboBox();
            this.Gb_Send_Status = new System.Windows.Forms.GroupBox();
            this.Lb_Send_Status = new System.Windows.Forms.Label();
            this.Lk_Help = new System.Windows.Forms.LinkLabel();
            this.Gb_Status.SuspendLayout();
            this.Gb_Send_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_Cmd
            // 
            this.Tb_Cmd.Location = new System.Drawing.Point(15, 268);
            this.Tb_Cmd.Name = "Tb_Cmd";
            this.Tb_Cmd.Size = new System.Drawing.Size(339, 25);
            this.Tb_Cmd.TabIndex = 0;
            // 
            // Lb_Cmd
            // 
            this.Lb_Cmd.AutoSize = true;
            this.Lb_Cmd.Location = new System.Drawing.Point(12, 244);
            this.Lb_Cmd.Name = "Lb_Cmd";
            this.Lb_Cmd.Size = new System.Drawing.Size(71, 15);
            this.Lb_Cmd.TabIndex = 1;
            this.Lb_Cmd.Text = "Send CMD";
            // 
            // Tb_Res_Data
            // 
            this.Tb_Res_Data.Location = new System.Drawing.Point(15, 349);
            this.Tb_Res_Data.Name = "Tb_Res_Data";
            this.Tb_Res_Data.Size = new System.Drawing.Size(339, 25);
            this.Tb_Res_Data.TabIndex = 0;
            // 
            // Lb_Data
            // 
            this.Lb_Data.AutoSize = true;
            this.Lb_Data.Location = new System.Drawing.Point(12, 321);
            this.Lb_Data.Name = "Lb_Data";
            this.Lb_Data.Size = new System.Drawing.Size(39, 15);
            this.Lb_Data.TabIndex = 1;
            this.Lb_Data.Text = "Data";
            // 
            // Bt_Connect
            // 
            this.Bt_Connect.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Bt_Connect.Location = new System.Drawing.Point(661, 40);
            this.Bt_Connect.Name = "Bt_Connect";
            this.Bt_Connect.Size = new System.Drawing.Size(116, 42);
            this.Bt_Connect.TabIndex = 2;
            this.Bt_Connect.Text = "Connect";
            this.Bt_Connect.UseVisualStyleBackColor = true;
            this.Bt_Connect.Click += new System.EventHandler(this.Bt_Connect_Click);
            // 
            // Bt_Reading
            // 
            this.Bt_Reading.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Bt_Reading.Location = new System.Drawing.Point(661, 118);
            this.Bt_Reading.Name = "Bt_Reading";
            this.Bt_Reading.Size = new System.Drawing.Size(116, 42);
            this.Bt_Reading.TabIndex = 2;
            this.Bt_Reading.Text = "Read";
            this.Bt_Reading.UseVisualStyleBackColor = true;
            // 
            // Bt_Input
            // 
            this.Bt_Input.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Bt_Input.Location = new System.Drawing.Point(661, 196);
            this.Bt_Input.Name = "Bt_Input";
            this.Bt_Input.Size = new System.Drawing.Size(116, 42);
            this.Bt_Input.TabIndex = 2;
            this.Bt_Input.Text = "Input";
            this.Bt_Input.UseVisualStyleBackColor = true;
            // 
            // Cb_Port
            // 
            this.Cb_Port.FormattingEnabled = true;
            this.Cb_Port.Location = new System.Drawing.Point(109, 15);
            this.Cb_Port.Name = "Cb_Port";
            this.Cb_Port.Size = new System.Drawing.Size(121, 23);
            this.Cb_Port.TabIndex = 3;
            // 
            // Lb_Port
            // 
            this.Lb_Port.AutoSize = true;
            this.Lb_Port.Location = new System.Drawing.Point(52, 18);
            this.Lb_Port.Name = "Lb_Port";
            this.Lb_Port.Size = new System.Drawing.Size(39, 15);
            this.Lb_Port.TabIndex = 1;
            this.Lb_Port.Text = "Port";
            // 
            // Lb_Rate
            // 
            this.Lb_Rate.AutoSize = true;
            this.Lb_Rate.Location = new System.Drawing.Point(52, 67);
            this.Lb_Rate.Name = "Lb_Rate";
            this.Lb_Rate.Size = new System.Drawing.Size(39, 15);
            this.Lb_Rate.TabIndex = 1;
            this.Lb_Rate.Text = "Rate";
            // 
            // Cb_Rate
            // 
            this.Cb_Rate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Rate.FormattingEnabled = true;
            this.Cb_Rate.Location = new System.Drawing.Point(109, 60);
            this.Cb_Rate.Name = "Cb_Rate";
            this.Cb_Rate.Size = new System.Drawing.Size(121, 23);
            this.Cb_Rate.TabIndex = 3;
            // 
            // Lb_Proof
            // 
            this.Lb_Proof.AutoSize = true;
            this.Lb_Proof.Location = new System.Drawing.Point(44, 111);
            this.Lb_Proof.Name = "Lb_Proof";
            this.Lb_Proof.Size = new System.Drawing.Size(47, 15);
            this.Lb_Proof.TabIndex = 1;
            this.Lb_Proof.Text = "Proof";
            // 
            // Cb_Proof
            // 
            this.Cb_Proof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Proof.FormattingEnabled = true;
            this.Cb_Proof.Location = new System.Drawing.Point(109, 105);
            this.Cb_Proof.Name = "Cb_Proof";
            this.Cb_Proof.Size = new System.Drawing.Size(121, 23);
            this.Cb_Proof.TabIndex = 3;
            // 
            // Lb_Data_Lenght
            // 
            this.Lb_Data_Lenght.AutoSize = true;
            this.Lb_Data_Lenght.Location = new System.Drawing.Point(20, 158);
            this.Lb_Data_Lenght.Margin = new System.Windows.Forms.Padding(0);
            this.Lb_Data_Lenght.Name = "Lb_Data_Lenght";
            this.Lb_Data_Lenght.Size = new System.Drawing.Size(71, 15);
            this.Lb_Data_Lenght.TabIndex = 1;
            this.Lb_Data_Lenght.Text = "Databits";
            // 
            // Cb_DataLenght
            // 
            this.Cb_DataLenght.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_DataLenght.FormattingEnabled = true;
            this.Cb_DataLenght.Location = new System.Drawing.Point(109, 150);
            this.Cb_DataLenght.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Cb_DataLenght.Name = "Cb_DataLenght";
            this.Cb_DataLenght.Size = new System.Drawing.Size(121, 23);
            this.Cb_DataLenght.TabIndex = 3;
            // 
            // Bt_Send
            // 
            this.Bt_Send.Location = new System.Drawing.Point(398, 251);
            this.Bt_Send.Name = "Bt_Send";
            this.Bt_Send.Size = new System.Drawing.Size(92, 42);
            this.Bt_Send.TabIndex = 2;
            this.Bt_Send.Text = "Send";
            this.Bt_Send.UseVisualStyleBackColor = true;
            this.Bt_Send.Click += new System.EventHandler(this.Bt_Send_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(398, 338);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 42);
            this.button5.TabIndex = 2;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Gb_Status
            // 
            this.Gb_Status.Controls.Add(this.Lb_Status);
            this.Gb_Status.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Gb_Status.Location = new System.Drawing.Point(272, 12);
            this.Gb_Status.Name = "Gb_Status";
            this.Gb_Status.Size = new System.Drawing.Size(249, 100);
            this.Gb_Status.TabIndex = 4;
            this.Gb_Status.TabStop = false;
            this.Gb_Status.Text = "Connect Status";
            // 
            // Lb_Status
            // 
            this.Lb_Status.AutoSize = true;
            this.Lb_Status.Location = new System.Drawing.Point(16, 42);
            this.Lb_Status.Name = "Lb_Status";
            this.Lb_Status.Size = new System.Drawing.Size(52, 15);
            this.Lb_Status.TabIndex = 1;
            this.Lb_Status.Text = "未连接";
            // 
            // Lb_StopBits
            // 
            this.Lb_StopBits.AutoSize = true;
            this.Lb_StopBits.Location = new System.Drawing.Point(20, 196);
            this.Lb_StopBits.Margin = new System.Windows.Forms.Padding(0);
            this.Lb_StopBits.Name = "Lb_StopBits";
            this.Lb_StopBits.Size = new System.Drawing.Size(71, 15);
            this.Lb_StopBits.TabIndex = 1;
            this.Lb_StopBits.Text = "StopBits";
            // 
            // Cb_StopBits
            // 
            this.Cb_StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_StopBits.FormattingEnabled = true;
            this.Cb_StopBits.Location = new System.Drawing.Point(109, 193);
            this.Cb_StopBits.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Cb_StopBits.Name = "Cb_StopBits";
            this.Cb_StopBits.Size = new System.Drawing.Size(121, 23);
            this.Cb_StopBits.TabIndex = 3;
            // 
            // Gb_Send_Status
            // 
            this.Gb_Send_Status.Controls.Add(this.Lb_Send_Status);
            this.Gb_Send_Status.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Gb_Send_Status.Location = new System.Drawing.Point(272, 138);
            this.Gb_Send_Status.Name = "Gb_Send_Status";
            this.Gb_Send_Status.Size = new System.Drawing.Size(249, 100);
            this.Gb_Send_Status.TabIndex = 4;
            this.Gb_Send_Status.TabStop = false;
            this.Gb_Send_Status.Text = "Send Status";
            // 
            // Lb_Send_Status
            // 
            this.Lb_Send_Status.AutoSize = true;
            this.Lb_Send_Status.Location = new System.Drawing.Point(16, 44);
            this.Lb_Send_Status.Name = "Lb_Send_Status";
            this.Lb_Send_Status.Size = new System.Drawing.Size(52, 15);
            this.Lb_Send_Status.TabIndex = 1;
            this.Lb_Send_Status.Text = "未连接";
            // 
            // Lk_Help
            // 
            this.Lk_Help.AutoSize = true;
            this.Lk_Help.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Lk_Help.LinkColor = System.Drawing.Color.Red;
            this.Lk_Help.Location = new System.Drawing.Point(658, 352);
            this.Lk_Help.Name = "Lk_Help";
            this.Lk_Help.Size = new System.Drawing.Size(111, 15);
            this.Lk_Help.TabIndex = 5;
            this.Lk_Help.TabStop = true;
            this.Lk_Help.Text = "Help Document";
            this.Lk_Help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lk_Help_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(799, 389);
            this.Controls.Add(this.Lk_Help);
            this.Controls.Add(this.Gb_Send_Status);
            this.Controls.Add(this.Gb_Status);
            this.Controls.Add(this.Cb_StopBits);
            this.Controls.Add(this.Cb_DataLenght);
            this.Controls.Add(this.Cb_Proof);
            this.Controls.Add(this.Cb_Rate);
            this.Controls.Add(this.Cb_Port);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Bt_Send);
            this.Controls.Add(this.Bt_Input);
            this.Controls.Add(this.Bt_Reading);
            this.Controls.Add(this.Bt_Connect);
            this.Controls.Add(this.Lb_Data);
            this.Controls.Add(this.Tb_Res_Data);
            this.Controls.Add(this.Lb_StopBits);
            this.Controls.Add(this.Lb_Data_Lenght);
            this.Controls.Add(this.Lb_Proof);
            this.Controls.Add(this.Lb_Rate);
            this.Controls.Add(this.Lb_Port);
            this.Controls.Add(this.Lb_Cmd);
            this.Controls.Add(this.Tb_Cmd);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tools@By wlcbit.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Gb_Status.ResumeLayout(false);
            this.Gb_Status.PerformLayout();
            this.Gb_Send_Status.ResumeLayout(false);
            this.Gb_Send_Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_Cmd;
        private System.Windows.Forms.Label Lb_Cmd;
        private System.Windows.Forms.TextBox Tb_Res_Data;
        private System.Windows.Forms.Label Lb_Data;
        private System.Windows.Forms.Button Bt_Connect;
        private System.Windows.Forms.Button Bt_Reading;
        private System.Windows.Forms.Button Bt_Input;
        private System.Windows.Forms.Label Lb_Port;
        private System.Windows.Forms.Label Lb_Rate;
        private System.Windows.Forms.Label Lb_Proof;
        private System.Windows.Forms.ComboBox Cb_Proof;
        private System.Windows.Forms.Label Lb_Data_Lenght;
        private System.Windows.Forms.ComboBox Cb_DataLenght;
        private System.Windows.Forms.Button Bt_Send;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox Cb_Port;
        private System.Windows.Forms.GroupBox Gb_Status;
        private System.Windows.Forms.Label Lb_Status;
        private System.Windows.Forms.ComboBox Cb_Rate;
        private System.Windows.Forms.Label Lb_StopBits;
        private System.Windows.Forms.ComboBox Cb_StopBits;
        private System.Windows.Forms.GroupBox Gb_Send_Status;
        private System.Windows.Forms.Label Lb_Send_Status;
        private System.Windows.Forms.LinkLabel Lk_Help;
    }
}

