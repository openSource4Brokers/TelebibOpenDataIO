namespace TelebibOpenDataIO
{
    partial class FrmTelebibOpenDataIO
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tbHostedConnectionstring = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.rbHosted = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheckHostedSqlServer = new System.Windows.Forms.Button();
            this.tbLocalConnectionstring = new System.Windows.Forms.TextBox();
            this.btnCheckLocalSqlServer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReadMdb = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb2Location = new System.Windows.Forms.TextBox();
            this.btnGetTelebib2Location = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(571, 219);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 23);
            this.btnClose.TabIndex = 121;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // tbHostedConnectionstring
            // 
            this.tbHostedConnectionstring.Location = new System.Drawing.Point(140, 105);
            this.tbHostedConnectionstring.Multiline = true;
            this.tbHostedConnectionstring.Name = "tbHostedConnectionstring";
            this.tbHostedConnectionstring.Size = new System.Drawing.Size(505, 62);
            this.tbHostedConnectionstring.TabIndex = 117;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLocal);
            this.groupBox1.Controls.Add(this.rbHosted);
            this.groupBox1.Location = new System.Drawing.Point(140, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 50);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Server";
            this.groupBox1.Visible = false;
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Location = new System.Drawing.Point(17, 21);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(73, 17);
            this.rbLocal.TabIndex = 85;
            this.rbLocal.Text = "Use Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            this.rbLocal.CheckedChanged += new System.EventHandler(this.RbLocal_CheckedChanged);
            // 
            // rbHosted
            // 
            this.rbHosted.AutoSize = true;
            this.rbHosted.Location = new System.Drawing.Point(96, 21);
            this.rbHosted.Name = "rbHosted";
            this.rbHosted.Size = new System.Drawing.Size(81, 17);
            this.rbHosted.TabIndex = 86;
            this.rbHosted.Text = "Use Hosted";
            this.rbHosted.UseVisualStyleBackColor = true;
            this.rbHosted.CheckedChanged += new System.EventHandler(this.RbHosted_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 119;
            this.label4.Text = "? hosted sqlserver";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCheckHostedSqlServer
            // 
            this.btnCheckHostedSqlServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckHostedSqlServer.Location = new System.Drawing.Point(58, 145);
            this.btnCheckHostedSqlServer.Name = "btnCheckHostedSqlServer";
            this.btnCheckHostedSqlServer.Size = new System.Drawing.Size(76, 22);
            this.btnCheckHostedSqlServer.TabIndex = 118;
            this.btnCheckHostedSqlServer.Text = "Remember";
            this.btnCheckHostedSqlServer.UseVisualStyleBackColor = true;
            this.btnCheckHostedSqlServer.Click += new System.EventHandler(this.BtnCheckHostedSqlServer_Click);
            // 
            // tbLocalConnectionstring
            // 
            this.tbLocalConnectionstring.Location = new System.Drawing.Point(140, 36);
            this.tbLocalConnectionstring.Multiline = true;
            this.tbLocalConnectionstring.Name = "tbLocalConnectionstring";
            this.tbLocalConnectionstring.Size = new System.Drawing.Size(505, 50);
            this.tbLocalConnectionstring.TabIndex = 114;
            // 
            // btnCheckLocalSqlServer
            // 
            this.btnCheckLocalSqlServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckLocalSqlServer.Location = new System.Drawing.Point(58, 64);
            this.btnCheckLocalSqlServer.Name = "btnCheckLocalSqlServer";
            this.btnCheckLocalSqlServer.Size = new System.Drawing.Size(76, 22);
            this.btnCheckLocalSqlServer.TabIndex = 115;
            this.btnCheckLocalSqlServer.Text = "Remember";
            this.btnCheckLocalSqlServer.UseVisualStyleBackColor = true;
            this.btnCheckLocalSqlServer.Click += new System.EventHandler(this.BtnCheckLocalSqlServer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "? local sqlserver";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnReadMdb
            // 
            this.btnReadMdb.Enabled = false;
            this.btnReadMdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadMdb.Location = new System.Drawing.Point(573, 173);
            this.btnReadMdb.Name = "btnReadMdb";
            this.btnReadMdb.Size = new System.Drawing.Size(72, 25);
            this.btnReadMdb.TabIndex = 113;
            this.btnReadMdb.Text = "Start !";
            this.btnReadMdb.UseVisualStyleBackColor = true;
            this.btnReadMdb.Click += new System.EventHandler(this.BtnReadMdb_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 112;
            this.label5.Text = "? Telebib2.mdb";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb2Location
            // 
            this.tb2Location.Location = new System.Drawing.Point(140, 8);
            this.tb2Location.Multiline = true;
            this.tb2Location.Name = "tb2Location";
            this.tb2Location.Size = new System.Drawing.Size(505, 22);
            this.tb2Location.TabIndex = 110;
            // 
            // btnGetTelebib2Location
            // 
            this.btnGetTelebib2Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetTelebib2Location.Location = new System.Drawing.Point(93, 8);
            this.btnGetTelebib2Location.Name = "btnGetTelebib2Location";
            this.btnGetTelebib2Location.Size = new System.Drawing.Size(41, 22);
            this.btnGetTelebib2Location.TabIndex = 111;
            this.btnGetTelebib2Location.Text = "...";
            this.btnGetTelebib2Location.UseVisualStyleBackColor = true;
            this.btnGetTelebib2Location.Click += new System.EventHandler(this.BtnGetTelebib2Location_Click);
            // 
            // FrmTelebibOpenDataIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 245);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbHostedConnectionstring);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheckHostedSqlServer);
            this.Controls.Add(this.tbLocalConnectionstring);
            this.Controls.Add(this.btnCheckLocalSqlServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReadMdb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb2Location);
            this.Controls.Add(this.btnGetTelebib2Location);
            this.Name = "FrmTelebibOpenDataIO";
            this.Text = "Telebib IO";
            this.Load += new System.EventHandler(this.FrmTelebibOpenDataIO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.TextBox tbHostedConnectionstring;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.RadioButton rbHosted;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnCheckHostedSqlServer;
        internal System.Windows.Forms.TextBox tbLocalConnectionstring;
        internal System.Windows.Forms.Button btnCheckLocalSqlServer;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReadMdb;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox tb2Location;
        internal System.Windows.Forms.Button btnGetTelebib2Location;
    }
}

