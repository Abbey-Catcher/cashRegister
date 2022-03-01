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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.receiptLabel = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.numberOfRedsLabel = new System.Windows.Forms.Label();
            this.redShoesInput = new System.Windows.Forms.TextBox();
            this.blueShoesInput = new System.Windows.Forms.TextBox();
            this.numberOfBluesLabel = new System.Windows.Forms.Label();
            this.greyShoesInput = new System.Windows.Forms.TextBox();
            this.numberOfGreysLabel = new System.Windows.Forms.Label();
            this.calculateTotalsButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.White;
            this.receiptLabel.Location = new System.Drawing.Point(318, 58);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(277, 381);
            this.receiptLabel.TabIndex = 0;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.Location = new System.Drawing.Point(21, 447);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(280, 42);
            this.printReceiptButton.TabIndex = 1;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = true;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(318, 447);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(280, 42);
            this.newOrderButton.TabIndex = 2;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            // 
            // numberOfRedsLabel
            // 
            this.numberOfRedsLabel.Location = new System.Drawing.Point(27, 58);
            this.numberOfRedsLabel.Name = "numberOfRedsLabel";
            this.numberOfRedsLabel.Size = new System.Drawing.Size(114, 23);
            this.numberOfRedsLabel.TabIndex = 3;
            this.numberOfRedsLabel.Text = "Number of red shoes";
            this.numberOfRedsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redShoesInput
            // 
            this.redShoesInput.Location = new System.Drawing.Point(148, 60);
            this.redShoesInput.Name = "redShoesInput";
            this.redShoesInput.Size = new System.Drawing.Size(119, 20);
            this.redShoesInput.TabIndex = 4;
            // 
            // blueShoesInput
            // 
            this.blueShoesInput.Location = new System.Drawing.Point(148, 92);
            this.blueShoesInput.Name = "blueShoesInput";
            this.blueShoesInput.Size = new System.Drawing.Size(119, 20);
            this.blueShoesInput.TabIndex = 6;
            // 
            // numberOfBluesLabel
            // 
            this.numberOfBluesLabel.Location = new System.Drawing.Point(28, 90);
            this.numberOfBluesLabel.Name = "numberOfBluesLabel";
            this.numberOfBluesLabel.Size = new System.Drawing.Size(114, 23);
            this.numberOfBluesLabel.TabIndex = 5;
            this.numberOfBluesLabel.Text = "Number of blue shoes";
            this.numberOfBluesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greyShoesInput
            // 
            this.greyShoesInput.Location = new System.Drawing.Point(148, 127);
            this.greyShoesInput.Name = "greyShoesInput";
            this.greyShoesInput.Size = new System.Drawing.Size(119, 20);
            this.greyShoesInput.TabIndex = 8;
            // 
            // numberOfGreysLabel
            // 
            this.numberOfGreysLabel.Location = new System.Drawing.Point(28, 125);
            this.numberOfGreysLabel.Name = "numberOfGreysLabel";
            this.numberOfGreysLabel.Size = new System.Drawing.Size(114, 23);
            this.numberOfGreysLabel.TabIndex = 7;
            this.numberOfGreysLabel.Text = "Number of grey shoes";
            this.numberOfGreysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateTotalsButton
            // 
            this.calculateTotalsButton.Location = new System.Drawing.Point(62, 168);
            this.calculateTotalsButton.Name = "calculateTotalsButton";
            this.calculateTotalsButton.Size = new System.Drawing.Size(162, 32);
            this.calculateTotalsButton.TabIndex = 9;
            this.calculateTotalsButton.Text = "Calculate Totals";
            this.calculateTotalsButton.UseVisualStyleBackColor = true;
            this.calculateTotalsButton.Click += new System.EventHandler(this.calculateTotalsButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.Location = new System.Drawing.Point(27, 209);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(79, 23);
            this.subTotalLabel.TabIndex = 10;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.Location = new System.Drawing.Point(27, 249);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(79, 23);
            this.taxLabel.TabIndex = 11;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(27, 289);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(79, 23);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "Total";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Location = new System.Drawing.Point(27, 327);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(79, 23);
            this.tenderedLabel.TabIndex = 13;
            this.tenderedLabel.Text = "Tendered";
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.BackColor = System.Drawing.Color.Silver;
            this.subTotalOutput.ForeColor = System.Drawing.Color.Black;
            this.subTotalOutput.Location = new System.Drawing.Point(187, 209);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(79, 23);
            this.subTotalOutput.TabIndex = 14;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.Silver;
            this.taxOutput.ForeColor = System.Drawing.Color.Black;
            this.taxOutput.Location = new System.Drawing.Point(187, 249);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(79, 23);
            this.taxOutput.TabIndex = 15;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.Silver;
            this.totalOutput.ForeColor = System.Drawing.Color.Black;
            this.totalOutput.Location = new System.Drawing.Point(187, 289);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(79, 23);
            this.totalOutput.TabIndex = 16;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(147, 324);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(119, 20);
            this.tenderedInput.TabIndex = 17;
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.Location = new System.Drawing.Point(62, 354);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(172, 30);
            this.calculateChangeButton.TabIndex = 18;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = true;
            // 
            // changeLabel
            // 
            this.changeLabel.Location = new System.Drawing.Point(28, 407);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(79, 23);
            this.changeLabel.TabIndex = 19;
            this.changeLabel.Text = "Change";
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.Silver;
            this.changeOutput.Location = new System.Drawing.Point(188, 402);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(79, 23);
            this.changeOutput.TabIndex = 20;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Teal;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(620, 43);
            this.titleLabel.TabIndex = 21;
            this.titleLabel.Text = "Shoes Shoes Shoes!!!";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(619, 501);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.calculateTotalsButton);
            this.Controls.Add(this.greyShoesInput);
            this.Controls.Add(this.numberOfGreysLabel);
            this.Controls.Add(this.blueShoesInput);
            this.Controls.Add(this.numberOfBluesLabel);
            this.Controls.Add(this.redShoesInput);
            this.Controls.Add(this.numberOfRedsLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.receiptLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Shoe Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label numberOfRedsLabel;
        private System.Windows.Forms.TextBox redShoesInput;
        private System.Windows.Forms.TextBox blueShoesInput;
        private System.Windows.Forms.Label numberOfBluesLabel;
        private System.Windows.Forms.TextBox greyShoesInput;
        private System.Windows.Forms.Label numberOfGreysLabel;
        private System.Windows.Forms.Button calculateTotalsButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label titleLabel;
    }
}

