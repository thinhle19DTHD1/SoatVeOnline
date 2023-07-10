namespace CheckQRCode
{
    partial class CheckQRCode
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTpyeDevice = new System.Windows.Forms.ComboBox();
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.tbnStart = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtDecoded = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera";
            // 
            // cbbTpyeDevice
            // 
            this.cbbTpyeDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTpyeDevice.FormattingEnabled = true;
            this.cbbTpyeDevice.Location = new System.Drawing.Point(135, 45);
            this.cbbTpyeDevice.Name = "cbbTpyeDevice";
            this.cbbTpyeDevice.Size = new System.Drawing.Size(292, 33);
            this.cbbTpyeDevice.TabIndex = 1;
            // 
            // pbQRCode
            // 
            this.pbQRCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbQRCode.Location = new System.Drawing.Point(78, 98);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(582, 584);
            this.pbQRCode.TabIndex = 2;
            this.pbQRCode.TabStop = false;
            // 
            // tbnStart
            // 
            this.tbnStart.Location = new System.Drawing.Point(666, 98);
            this.tbnStart.Name = "tbnStart";
            this.tbnStart.Size = new System.Drawing.Size(109, 41);
            this.tbnStart.TabIndex = 3;
            this.tbnStart.Text = "START";
            this.tbnStart.UseVisualStyleBackColor = true;
            this.tbnStart.Click += new System.EventHandler(this.tbnStart_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(820, 98);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(109, 41);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtDecoded
            // 
            this.txtDecoded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecoded.Location = new System.Drawing.Point(666, 159);
            this.txtDecoded.Multiline = true;
            this.txtDecoded.Name = "txtDecoded";
            this.txtDecoded.Size = new System.Drawing.Size(315, 121);
            this.txtDecoded.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CheckQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 694);
            this.Controls.Add(this.txtDecoded);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.tbnStart);
            this.Controls.Add(this.pbQRCode);
            this.Controls.Add(this.cbbTpyeDevice);
            this.Controls.Add(this.label1);
            this.Name = "CheckQRCode";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckQRCode_FormClosing);
            this.Load += new System.EventHandler(this.CheckQRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTpyeDevice;
        private System.Windows.Forms.PictureBox pbQRCode;
        private System.Windows.Forms.Button tbnStart;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtDecoded;
        private System.Windows.Forms.Timer timer1;
    }
}

