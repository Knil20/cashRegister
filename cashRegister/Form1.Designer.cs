namespace cashRegister
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
            this.gameLabel1 = new System.Windows.Forms.Label();
            this.gameLabel2 = new System.Windows.Forms.Label();
            this.gameLabel3 = new System.Windows.Forms.Label();
            this.calcButtton1 = new System.Windows.Forms.Button();
            this.subLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.gameBox1 = new System.Windows.Forms.TextBox();
            this.gameBox2 = new System.Windows.Forms.TextBox();
            this.gameBox3 = new System.Windows.Forms.TextBox();
            this.blackLabel = new System.Windows.Forms.Label();
            this.tendLabel = new System.Windows.Forms.Label();
            this.tendBox = new System.Windows.Forms.TextBox();
            this.calcButton2 = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.changeOutput = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.restartLabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameLabel1
            // 
            this.gameLabel1.AutoSize = true;
            this.gameLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabel1.ForeColor = System.Drawing.Color.White;
            this.gameLabel1.Location = new System.Drawing.Point(12, 29);
            this.gameLabel1.Name = "gameLabel1";
            this.gameLabel1.Size = new System.Drawing.Size(144, 32);
            this.gameLabel1.TabIndex = 0;
            this.gameLabel1.Text = "New Super Mario Bros \r\nDeluxe";
            this.gameLabel1.Click += new System.EventHandler(this.gameLabel1_Click);
            // 
            // gameLabel2
            // 
            this.gameLabel2.AutoSize = true;
            this.gameLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabel2.ForeColor = System.Drawing.Color.White;
            this.gameLabel2.Location = new System.Drawing.Point(12, 61);
            this.gameLabel2.Name = "gameLabel2";
            this.gameLabel2.Size = new System.Drawing.Size(137, 32);
            this.gameLabel2.TabIndex = 1;
            this.gameLabel2.Text = "The Legend Of Zelda \r\nBreath Of The Wild";
            // 
            // gameLabel3
            // 
            this.gameLabel3.AutoSize = true;
            this.gameLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gameLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabel3.ForeColor = System.Drawing.Color.White;
            this.gameLabel3.Location = new System.Drawing.Point(12, 111);
            this.gameLabel3.Name = "gameLabel3";
            this.gameLabel3.Size = new System.Drawing.Size(93, 16);
            this.gameLabel3.TabIndex = 2;
            this.gameLabel3.Text = "Metriod Dread";
            this.gameLabel3.Click += new System.EventHandler(this.gameLabel3_Click);
            // 
            // calcButtton1
            // 
            this.calcButtton1.BackColor = System.Drawing.Color.Transparent;
            this.calcButtton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.calcButtton1.ForeColor = System.Drawing.Color.Red;
            this.calcButtton1.Location = new System.Drawing.Point(71, 161);
            this.calcButtton1.Name = "calcButtton1";
            this.calcButtton1.Size = new System.Drawing.Size(154, 30);
            this.calcButtton1.TabIndex = 3;
            this.calcButtton1.Text = "Calculate Totals";
            this.calcButtton1.UseVisualStyleBackColor = false;
            this.calcButtton1.Click += new System.EventHandler(this.calcButtton1_Click);
            // 
            // subLabel
            // 
            this.subLabel.BackColor = System.Drawing.Color.Transparent;
            this.subLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLabel.ForeColor = System.Drawing.Color.White;
            this.subLabel.Location = new System.Drawing.Point(11, 204);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(100, 23);
            this.subLabel.TabIndex = 4;
            this.subLabel.Text = "Subtotal";
            // 
            // taxLabel
            // 
            this.taxLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.White;
            this.taxLabel.Location = new System.Drawing.Point(11, 238);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(100, 23);
            this.taxLabel.TabIndex = 5;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(11, 278);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total";
            // 
            // subOutput
            // 
            this.subOutput.BackColor = System.Drawing.Color.Transparent;
            this.subOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subOutput.ForeColor = System.Drawing.Color.Green;
            this.subOutput.Location = new System.Drawing.Point(146, 204);
            this.subOutput.Name = "subOutput";
            this.subOutput.Size = new System.Drawing.Size(100, 23);
            this.subOutput.TabIndex = 7;
            this.subOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.Transparent;
            this.taxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.ForeColor = System.Drawing.Color.Green;
            this.taxOutput.Location = new System.Drawing.Point(146, 238);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 23);
            this.taxOutput.TabIndex = 8;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.Transparent;
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.ForeColor = System.Drawing.Color.Green;
            this.totalOutput.Location = new System.Drawing.Point(146, 278);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 23);
            this.totalOutput.TabIndex = 9;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameBox1
            // 
            this.gameBox1.Location = new System.Drawing.Point(192, 30);
            this.gameBox1.Name = "gameBox1";
            this.gameBox1.Size = new System.Drawing.Size(100, 20);
            this.gameBox1.TabIndex = 10;
            // 
            // gameBox2
            // 
            this.gameBox2.Location = new System.Drawing.Point(192, 73);
            this.gameBox2.Name = "gameBox2";
            this.gameBox2.Size = new System.Drawing.Size(100, 20);
            this.gameBox2.TabIndex = 11;
            // 
            // gameBox3
            // 
            this.gameBox3.Location = new System.Drawing.Point(192, 110);
            this.gameBox3.Name = "gameBox3";
            this.gameBox3.Size = new System.Drawing.Size(100, 20);
            this.gameBox3.TabIndex = 12;
            // 
            // blackLabel
            // 
            this.blackLabel.BackColor = System.Drawing.Color.Black;
            this.blackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackLabel.ForeColor = System.Drawing.Color.Black;
            this.blackLabel.Location = new System.Drawing.Point(11, 311);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(281, 23);
            this.blackLabel.TabIndex = 13;
            // 
            // tendLabel
            // 
            this.tendLabel.BackColor = System.Drawing.Color.Transparent;
            this.tendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendLabel.ForeColor = System.Drawing.Color.White;
            this.tendLabel.Location = new System.Drawing.Point(11, 354);
            this.tendLabel.Name = "tendLabel";
            this.tendLabel.Size = new System.Drawing.Size(85, 23);
            this.tendLabel.TabIndex = 14;
            this.tendLabel.Text = "Tendered";
            // 
            // tendBox
            // 
            this.tendBox.Location = new System.Drawing.Point(192, 354);
            this.tendBox.Name = "tendBox";
            this.tendBox.Size = new System.Drawing.Size(100, 20);
            this.tendBox.TabIndex = 15;
            // 
            // calcButton2
            // 
            this.calcButton2.BackColor = System.Drawing.Color.Transparent;
            this.calcButton2.ForeColor = System.Drawing.Color.Red;
            this.calcButton2.Location = new System.Drawing.Point(71, 381);
            this.calcButton2.Name = "calcButton2";
            this.calcButton2.Size = new System.Drawing.Size(154, 25);
            this.calcButton2.TabIndex = 16;
            this.calcButton2.Text = "Calculate Change";
            this.calcButton2.UseVisualStyleBackColor = false;
            this.calcButton2.Click += new System.EventHandler(this.calcButton2_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.White;
            this.changeLabel.Location = new System.Drawing.Point(11, 409);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(100, 23);
            this.changeLabel.TabIndex = 17;
            this.changeLabel.Text = "Change";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(71, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "Print Receipt ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.Transparent;
            this.changeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.ForeColor = System.Drawing.Color.Green;
            this.changeOutput.Location = new System.Drawing.Point(146, 409);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(100, 23);
            this.changeOutput.TabIndex = 19;
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.White;
            this.receiptLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(387, 18);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(292, 388);
            this.receiptLabel.TabIndex = 20;
            this.receiptLabel.Visible = false;
            this.receiptLabel.Click += new System.EventHandler(this.receiptLabel_Click);
            // 
            // restartLabel
            // 
            this.restartLabel.Location = new System.Drawing.Point(477, 436);
            this.restartLabel.Name = "restartLabel";
            this.restartLabel.Size = new System.Drawing.Size(134, 34);
            this.restartLabel.TabIndex = 21;
            this.restartLabel.Text = "Buy Something Else?";
            this.restartLabel.UseVisualStyleBackColor = true;
            this.restartLabel.Click += new System.EventHandler(this.restartLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = global::cashRegister.Properties.Resources.Nintendo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(691, 482);
            this.Controls.Add(this.restartLabel);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calcButton2);
            this.Controls.Add(this.tendBox);
            this.Controls.Add(this.tendLabel);
            this.Controls.Add(this.blackLabel);
            this.Controls.Add(this.gameBox3);
            this.Controls.Add(this.gameBox2);
            this.Controls.Add(this.gameBox1);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.calcButtton1);
            this.Controls.Add(this.gameLabel3);
            this.Controls.Add(this.gameLabel2);
            this.Controls.Add(this.gameLabel1);
            this.Name = "Form1";
            this.Text = "Nintendo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameLabel1;
        private System.Windows.Forms.Label gameLabel2;
        private System.Windows.Forms.Label gameLabel3;
        private System.Windows.Forms.Button calcButtton1;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.TextBox gameBox1;
        private System.Windows.Forms.TextBox gameBox2;
        private System.Windows.Forms.TextBox gameBox3;
        private System.Windows.Forms.Label blackLabel;
        private System.Windows.Forms.Label tendLabel;
        private System.Windows.Forms.TextBox tendBox;
        private System.Windows.Forms.Button calcButton2;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button restartLabel;
    }
}

