namespace Tanks
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
            this.textBoxEModel = new System.Windows.Forms.TextBox();
            this.groupBoxEinfo = new System.Windows.Forms.GroupBox();
            this.textBoxEHP = new System.Windows.Forms.TextBox();
            this.groupBox2PCinfo = new System.Windows.Forms.GroupBox();
            this.textBoxPCHP = new System.Windows.Forms.TextBox();
            this.textBoxPCModel = new System.Windows.Forms.TextBox();
            this.groupBoxTankSelect = new System.Windows.Forms.GroupBox();
            this.buttonM46 = new System.Windows.Forms.Button();
            this.buttonT54 = new System.Windows.Forms.Button();
            this.groupBoxAmmo = new System.Windows.Forms.GroupBox();
            this.buttonAPCBC = new System.Windows.Forms.Button();
            this.buttonHEAT = new System.Windows.Forms.Button();
            this.richTextBoxEvent = new System.Windows.Forms.RichTextBox();
            this.Welcome = new System.Windows.Forms.TextBox();
            this.groupBoxEinfo.SuspendLayout();
            this.groupBox2PCinfo.SuspendLayout();
            this.groupBoxTankSelect.SuspendLayout();
            this.groupBoxAmmo.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEModel
            // 
            this.textBoxEModel.Location = new System.Drawing.Point(19, 19);
            this.textBoxEModel.Name = "textBoxEModel";
            this.textBoxEModel.Size = new System.Drawing.Size(160, 20);
            this.textBoxEModel.TabIndex = 2;
            this.textBoxEModel.TextChanged += new System.EventHandler(this.textBoxEModel_TextChanged);
            // 
            // groupBoxEinfo
            // 
            this.groupBoxEinfo.Controls.Add(this.textBoxEHP);
            this.groupBoxEinfo.Controls.Add(this.textBoxEModel);
            this.groupBoxEinfo.Location = new System.Drawing.Point(588, 369);
            this.groupBoxEinfo.Name = "groupBoxEinfo";
            this.groupBoxEinfo.Size = new System.Drawing.Size(200, 75);
            this.groupBoxEinfo.TabIndex = 3;
            this.groupBoxEinfo.TabStop = false;
            this.groupBoxEinfo.Text = "Enemy info";
            this.groupBoxEinfo.Visible = false;
            // 
            // textBoxEHP
            // 
            this.textBoxEHP.Location = new System.Drawing.Point(19, 45);
            this.textBoxEHP.Name = "textBoxEHP";
            this.textBoxEHP.Size = new System.Drawing.Size(160, 20);
            this.textBoxEHP.TabIndex = 3;
            // 
            // groupBox2PCinfo
            // 
            this.groupBox2PCinfo.Controls.Add(this.textBoxPCHP);
            this.groupBox2PCinfo.Controls.Add(this.textBoxPCModel);
            this.groupBox2PCinfo.Location = new System.Drawing.Point(12, 369);
            this.groupBox2PCinfo.Name = "groupBox2PCinfo";
            this.groupBox2PCinfo.Size = new System.Drawing.Size(200, 81);
            this.groupBox2PCinfo.TabIndex = 4;
            this.groupBox2PCinfo.TabStop = false;
            this.groupBox2PCinfo.Text = "PC Info";
            this.groupBox2PCinfo.Visible = false;
            // 
            // textBoxPCHP
            // 
            this.textBoxPCHP.Location = new System.Drawing.Point(19, 45);
            this.textBoxPCHP.Name = "textBoxPCHP";
            this.textBoxPCHP.Size = new System.Drawing.Size(160, 20);
            this.textBoxPCHP.TabIndex = 3;
            this.textBoxPCHP.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBoxPCModel
            // 
            this.textBoxPCModel.Location = new System.Drawing.Point(19, 19);
            this.textBoxPCModel.Name = "textBoxPCModel";
            this.textBoxPCModel.Size = new System.Drawing.Size(160, 20);
            this.textBoxPCModel.TabIndex = 2;
            this.textBoxPCModel.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // groupBoxTankSelect
            // 
            this.groupBoxTankSelect.Controls.Add(this.buttonM46);
            this.groupBoxTankSelect.Controls.Add(this.buttonT54);
            this.groupBoxTankSelect.Location = new System.Drawing.Point(343, 12);
            this.groupBoxTankSelect.Name = "groupBoxTankSelect";
            this.groupBoxTankSelect.Size = new System.Drawing.Size(107, 85);
            this.groupBoxTankSelect.TabIndex = 5;
            this.groupBoxTankSelect.TabStop = false;
            this.groupBoxTankSelect.Text = "TankSelect";
            this.groupBoxTankSelect.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // buttonM46
            // 
            this.buttonM46.Location = new System.Drawing.Point(15, 48);
            this.buttonM46.Name = "buttonM46";
            this.buttonM46.Size = new System.Drawing.Size(75, 23);
            this.buttonM46.TabIndex = 6;
            this.buttonM46.Text = "M48";
            this.buttonM46.UseVisualStyleBackColor = true;
            this.buttonM46.Click += new System.EventHandler(this.button13_Click);
            // 
            // buttonT54
            // 
            this.buttonT54.Location = new System.Drawing.Point(15, 19);
            this.buttonT54.Name = "buttonT54";
            this.buttonT54.Size = new System.Drawing.Size(75, 23);
            this.buttonT54.TabIndex = 1;
            this.buttonT54.Text = "T54";
            this.buttonT54.UseVisualStyleBackColor = true;
            this.buttonT54.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBoxAmmo
            // 
            this.groupBoxAmmo.Controls.Add(this.buttonAPCBC);
            this.groupBoxAmmo.Controls.Add(this.buttonHEAT);
            this.groupBoxAmmo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAmmo.Name = "groupBoxAmmo";
            this.groupBoxAmmo.Size = new System.Drawing.Size(108, 115);
            this.groupBoxAmmo.TabIndex = 8;
            this.groupBoxAmmo.TabStop = false;
            this.groupBoxAmmo.Text = "groupBox1";
            this.groupBoxAmmo.Visible = false;
            // 
            // buttonAPCBC
            // 
            this.buttonAPCBC.Location = new System.Drawing.Point(19, 62);
            this.buttonAPCBC.Name = "buttonAPCBC";
            this.buttonAPCBC.Size = new System.Drawing.Size(75, 23);
            this.buttonAPCBC.TabIndex = 1;
            this.buttonAPCBC.Text = "APCBC";
            this.buttonAPCBC.UseVisualStyleBackColor = true;
            this.buttonAPCBC.Click += new System.EventHandler(this.buttonAPCBC_Click);
            // 
            // buttonHEAT
            // 
            this.buttonHEAT.Location = new System.Drawing.Point(19, 19);
            this.buttonHEAT.Name = "buttonHEAT";
            this.buttonHEAT.Size = new System.Drawing.Size(75, 23);
            this.buttonHEAT.TabIndex = 0;
            this.buttonHEAT.Text = "HEAT";
            this.buttonHEAT.UseVisualStyleBackColor = true;
            this.buttonHEAT.Click += new System.EventHandler(this.buttonHEAT_Click);
            // 
            // richTextBoxEvent
            // 
            this.richTextBoxEvent.Location = new System.Drawing.Point(307, 213);
            this.richTextBoxEvent.Name = "richTextBoxEvent";
            this.richTextBoxEvent.Size = new System.Drawing.Size(215, 221);
            this.richTextBoxEvent.TabIndex = 9;
            this.richTextBoxEvent.Text = "";
            this.richTextBoxEvent.TextChanged += new System.EventHandler(this.richTextBoxEvent_TextChanged);
            // 
            // Welcome
            // 
            this.Welcome.Location = new System.Drawing.Point(319, 107);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(171, 20);
            this.Welcome.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.richTextBoxEvent);
            this.Controls.Add(this.groupBoxAmmo);
            this.Controls.Add(this.groupBoxTankSelect);
            this.Controls.Add(this.groupBox2PCinfo);
            this.Controls.Add(this.groupBoxEinfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxEinfo.ResumeLayout(false);
            this.groupBoxEinfo.PerformLayout();
            this.groupBox2PCinfo.ResumeLayout(false);
            this.groupBox2PCinfo.PerformLayout();
            this.groupBoxTankSelect.ResumeLayout(false);
            this.groupBoxAmmo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxEModel;
        private System.Windows.Forms.GroupBox groupBoxEinfo;
        private System.Windows.Forms.TextBox textBoxEHP;
        private System.Windows.Forms.GroupBox groupBox2PCinfo;
        private System.Windows.Forms.TextBox textBoxPCHP;
        private System.Windows.Forms.TextBox textBoxPCModel;
        private System.Windows.Forms.GroupBox groupBoxTankSelect;
        private System.Windows.Forms.Button buttonT54;
        private System.Windows.Forms.Button buttonM46;
        private System.Windows.Forms.GroupBox groupBoxAmmo;
        private System.Windows.Forms.Button buttonAPCBC;
        private System.Windows.Forms.Button buttonHEAT;
        private System.Windows.Forms.RichTextBox richTextBoxEvent;
        private System.Windows.Forms.TextBox Welcome;
    }
}

