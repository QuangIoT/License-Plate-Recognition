namespace LPR_Laptrinhvb
{
    partial class FrmMain
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._Rb_recv = new System.Windows.Forms.RichTextBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._lb_checkcar = new System.Windows.Forms.Label();
            this._lb_Status = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._Bt_connect = new System.Windows.Forms.Button();
            this._CB_COM = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.videoShow2 = new System.Windows.Forms.PictureBox();
            this.videoShow1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoShow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoShow1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(24, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 68);
            this.textBox1.TabIndex = 7;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.ForeColor = System.Drawing.Color.Black;
            this.lblNumber.Location = new System.Drawing.Point(13, 27);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(123, 13);
            this.lblNumber.TabIndex = 11;
            this.lblNumber.Text = "License plate to text";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._Rb_recv);
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(741, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 642);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // _Rb_recv
            // 
            this._Rb_recv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Rb_recv.Location = new System.Drawing.Point(6, 517);
            this._Rb_recv.Name = "_Rb_recv";
            this._Rb_recv.Size = new System.Drawing.Size(346, 119);
            this._Rb_recv.TabIndex = 19;
            this._Rb_recv.Text = "";
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(6, 32);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(346, 224);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(6, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._lb_checkcar);
            this.groupBox2.Controls.Add(this._lb_Status);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this._Bt_connect);
            this.groupBox2.Controls.Add(this._CB_COM);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lblNumber);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(1105, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 642);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // _lb_checkcar
            // 
            this._lb_checkcar.AutoSize = true;
            this._lb_checkcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lb_checkcar.ForeColor = System.Drawing.Color.Black;
            this._lb_checkcar.Location = new System.Drawing.Point(49, 383);
            this._lb_checkcar.Name = "_lb_checkcar";
            this._lb_checkcar.Size = new System.Drawing.Size(78, 16);
            this._lb_checkcar.TabIndex = 20;
            this._lb_checkcar.Text = "Check Car";
            // 
            // _lb_Status
            // 
            this._lb_Status.AutoSize = true;
            this._lb_Status.Location = new System.Drawing.Point(78, 446);
            this._lb_Status.Name = "_lb_Status";
            this._lb_Status.Size = new System.Drawing.Size(71, 13);
            this._lb_Status.TabIndex = 19;
            this._lb_Status.Text = "Disconnect";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Status: ";
            // 
            // _Bt_connect
            // 
            this._Bt_connect.ForeColor = System.Drawing.Color.Green;
            this._Bt_connect.Location = new System.Drawing.Point(24, 524);
            this._Bt_connect.Name = "_Bt_connect";
            this._Bt_connect.Size = new System.Drawing.Size(139, 97);
            this._Bt_connect.TabIndex = 17;
            this._Bt_connect.Text = "Connect";
            this._Bt_connect.UseVisualStyleBackColor = true;
            this._Bt_connect.Click += new System.EventHandler(this._Bt_connect_Click);
            // 
            // _CB_COM
            // 
            this._CB_COM.FormattingEnabled = true;
            this._CB_COM.Location = new System.Drawing.Point(24, 477);
            this._CB_COM.Name = "_CB_COM";
            this._CB_COM.Size = new System.Drawing.Size(139, 21);
            this._CB_COM.TabIndex = 16;
            this._CB_COM.SelectedIndexChanged += new System.EventHandler(this._CB_COM_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(24, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 31);
            this.button2.TabIndex = 15;
            this.button2.Text = "Camera2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(24, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Camera1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(24, 257);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(139, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.videoShow2);
            this.groupBox3.Controls.Add(this.videoShow1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(723, 642);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Camera2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(654, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Camera1";
            // 
            // videoShow2
            // 
            this.videoShow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.videoShow2.Location = new System.Drawing.Point(6, 341);
            this.videoShow2.Name = "videoShow2";
            this.videoShow2.Size = new System.Drawing.Size(711, 295);
            this.videoShow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.videoShow2.TabIndex = 1;
            this.videoShow2.TabStop = false;
            // 
            // videoShow1
            // 
            this.videoShow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.videoShow1.Location = new System.Drawing.Point(6, 32);
            this.videoShow1.Name = "videoShow1";
            this.videoShow1.Size = new System.Drawing.Size(711, 287);
            this.videoShow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.videoShow1.TabIndex = 0;
            this.videoShow1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 679);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart parking system - Version 1.0";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoShow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoShow1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblNumber;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox videoShow2;
        private System.Windows.Forms.PictureBox videoShow1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _Bt_connect;
        private System.Windows.Forms.ComboBox _CB_COM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label _lb_Status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox _Rb_recv;
        private System.Windows.Forms.Label _lb_checkcar;
    }
}

