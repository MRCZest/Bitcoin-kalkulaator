namespace Bitcoin_kalkulaator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyselector = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tulemusLabel = new System.Windows.Forms.Label();
            this.bitcoinamountinput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultlabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currencyselector
            // 
            this.currencyselector.FormattingEnabled = true;
            this.currencyselector.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP",
            "EEK"});
            this.currencyselector.Location = new System.Drawing.Point(199, 158);
            this.currencyselector.Name = "currencyselector";
            this.currencyselector.Size = new System.Drawing.Size(121, 28);
            this.currencyselector.TabIndex = 0;
            this.currencyselector.Text = "Vali valuuta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Arvuta Kurss";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tulemusLabel
            // 
            this.tulemusLabel.AutoSize = true;
            this.tulemusLabel.BackColor = System.Drawing.Color.Turquoise;
            this.tulemusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tulemusLabel.Location = new System.Drawing.Point(195, 256);
            this.tulemusLabel.Name = "tulemusLabel";
            this.tulemusLabel.Size = new System.Drawing.Size(107, 29);
            this.tulemusLabel.TabIndex = 2;
            this.tulemusLabel.Text = "Tulemus";
            this.tulemusLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // bitcoinamountinput
            // 
            this.bitcoinamountinput.Location = new System.Drawing.Point(199, 126);
            this.bitcoinamountinput.Name = "bitcoinamountinput";
            this.bitcoinamountinput.Size = new System.Drawing.Size(121, 26);
            this.bitcoinamountinput.TabIndex = 3;
            this.bitcoinamountinput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Turquoise;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(195, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sisesta bitcoini arv";
            // 
            // resultlabel
            // 
            this.resultlabel.Location = new System.Drawing.Point(199, 288);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(121, 26);
            this.resultlabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 343);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bitcoinamountinput);
            this.Controls.Add(this.tulemusLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currencyselector);
            this.Name = "Form1";
            this.Text = "Bitcoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyselector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tulemusLabel;
        private System.Windows.Forms.TextBox bitcoinamountinput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultlabel;
    }
}

