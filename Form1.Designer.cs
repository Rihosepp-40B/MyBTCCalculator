namespace MyBTCCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bitcoinAmountInput = new TextBox();
            BTCLable = new Label();
            currencySelector = new ComboBox();
            toCurrencyLable = new Label();
            calculateBitcoinPrice = new Button();
            CalcResult = new Label();
            CalcResultLable = new Label();
            SuspendLayout();
            // 
            // bitcoinAmountInput
            // 
            bitcoinAmountInput.Location = new Point(24, 38);
            bitcoinAmountInput.Name = "bitcoinAmountInput";
            bitcoinAmountInput.Size = new Size(175, 23);
            bitcoinAmountInput.TabIndex = 0;
            bitcoinAmountInput.TextChanged += textBox1_TextChanged;
            // 
            // BTCLable
            // 
            BTCLable.AutoSize = true;
            BTCLable.ForeColor = SystemColors.ButtonFace;
            BTCLable.Location = new Point(24, 20);
            BTCLable.Name = "BTCLable";
            BTCLable.Size = new Size(85, 15);
            BTCLable.TabIndex = 1;
            BTCLable.Text = "Bitcoini kogus:";
            // 
            // currencySelector
            // 
            currencySelector.AutoCompleteCustomSource.AddRange(new string[] { "EUR", "USD" });
            currencySelector.FormattingEnabled = true;
            currencySelector.Items.AddRange(new object[] { "USD", "EUR" });
            currencySelector.Location = new Point(24, 96);
            currencySelector.Name = "currencySelector";
            currencySelector.Size = new Size(175, 23);
            currencySelector.TabIndex = 2;
            // 
            // toCurrencyLable
            // 
            toCurrencyLable.AutoSize = true;
            toCurrencyLable.ForeColor = SystemColors.ButtonFace;
            toCurrencyLable.Location = new Point(24, 78);
            toCurrencyLable.Name = "toCurrencyLable";
            toCurrencyLable.Size = new Size(69, 15);
            toCurrencyLable.TabIndex = 3;
            toCurrencyLable.Text = "Sihtvaluuta:";
            // 
            // calculateBitcoinPrice
            // 
            calculateBitcoinPrice.Location = new Point(70, 160);
            calculateBitcoinPrice.Name = "calculateBitcoinPrice";
            calculateBitcoinPrice.Size = new Size(75, 23);
            calculateBitcoinPrice.TabIndex = 4;
            calculateBitcoinPrice.Text = "Arvuta";
            calculateBitcoinPrice.UseVisualStyleBackColor = true;
            calculateBitcoinPrice.Click += button1_Click;
            // 
            // CalcResult
            // 
            CalcResult.AutoSize = true;
            CalcResult.Font = new Font("Segoe UI", 18F);
            CalcResult.ForeColor = SystemColors.ButtonFace;
            CalcResult.Location = new Point(12, 409);
            CalcResult.Name = "CalcResult";
            CalcResult.Size = new Size(78, 32);
            CalcResult.TabIndex = 5;
            CalcResult.Text = "label1";
            // 
            // CalcResultLable
            // 
            CalcResultLable.AutoSize = true;
            CalcResultLable.ForeColor = SystemColors.ButtonFace;
            CalcResultLable.Location = new Point(12, 394);
            CalcResultLable.Name = "CalcResultLable";
            CalcResultLable.Size = new Size(103, 15);
            CalcResultLable.TabIndex = 6;
            CalcResultLable.Text = "Arvutuse tulemus:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(503, 450);
            Controls.Add(CalcResultLable);
            Controls.Add(CalcResult);
            Controls.Add(calculateBitcoinPrice);
            Controls.Add(toCurrencyLable);
            Controls.Add(currencySelector);
            Controls.Add(BTCLable);
            Controls.Add(bitcoinAmountInput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bitcoinAmountInput;
        private Label BTCLable;
        private ComboBox currencySelector;
        private Label toCurrencyLable;
        private Button calculateBitcoinPrice;
        private Label CalcResult;
        private Label CalcResultLable;
    }
}
