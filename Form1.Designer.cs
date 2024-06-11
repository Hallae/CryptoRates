namespace CryptoRates
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
            BinanceLabel = new Label();
            BybitLabel = new Label();
            KucoinLabel = new Label();
            BitgetLabel = new Label();
            SuspendLayout();
            // 
            // BinanceLabel
            // 
            BinanceLabel.AutoSize = true;
            BinanceLabel.Font = new Font("Segoe UI", 24F);
            BinanceLabel.Location = new Point(18, 9);
            BinanceLabel.Margin = new Padding(9, 0, 9, 0);
            BinanceLabel.Name = "BinanceLabel";
            BinanceLabel.Size = new Size(161, 54);
            BinanceLabel.TabIndex = 0;
            BinanceLabel.Text = "Binance";
            BinanceLabel.Click += BinanceLabel_Click;
            // 
            // BybitLabel
            // 
            BybitLabel.AutoSize = true;
            BybitLabel.Font = new Font("Segoe UI", 24F);
            BybitLabel.Location = new Point(18, 63);
            BybitLabel.Margin = new Padding(9, 0, 9, 0);
            BybitLabel.Name = "BybitLabel";
            BybitLabel.Size = new Size(113, 54);
            BybitLabel.TabIndex = 1;
            BybitLabel.Text = "Bybit";
            BybitLabel.Click += BybitLabel_Click;
            // 
            // KucoinLabel
            // 
            KucoinLabel.AutoSize = true;
            KucoinLabel.Font = new Font("Segoe UI", 24F);
            KucoinLabel.Location = new Point(7, 117);
            KucoinLabel.Margin = new Padding(9, 0, 9, 0);
            KucoinLabel.Name = "KucoinLabel";
            KucoinLabel.Size = new Size(154, 54);
            KucoinLabel.TabIndex = 2;
            KucoinLabel.Text = " Kucoin";
            KucoinLabel.Click += KucoinLabel_Click;
            // 
            // BitgetLabel
            // 
            BitgetLabel.AutoSize = true;
            BitgetLabel.Font = new Font("Segoe UI", 24F);
            BitgetLabel.Location = new Point(18, 171);
            BitgetLabel.Name = "BitgetLabel";
            BitgetLabel.Size = new Size(129, 54);
            BitgetLabel.TabIndex = 2;
            BitgetLabel.Text = "Bitget";
            BitgetLabel.Click += BitgetLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(23F, 57F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 333);
            Controls.Add(BitgetLabel);
            Controls.Add(KucoinLabel);
            Controls.Add(BybitLabel);
            Controls.Add(BinanceLabel);
            Font = new Font("Segoe UI", 25F);
            Margin = new Padding(9);
            Name = "Form1";
            Text = "Usdt Platform Rates";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BinanceLabel;
        private Label BybitLabel;
        private Label KucoinLabel;
        private Label BitgetLabel;
    }
}