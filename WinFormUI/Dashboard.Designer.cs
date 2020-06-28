namespace WinFormUI
{
    partial class Dashboard
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
            this.savingsTransactions = new System.Windows.Forms.ListBox();
            this.recordTransactionsButton = new System.Windows.Forms.Button();
            this.checkingTransactions = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.savingsBalanceValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkingBalanceValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.denyOverdraft = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // savingsTransactions
            // 
            this.savingsTransactions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsTransactions.FormattingEnabled = true;
            this.savingsTransactions.ItemHeight = 28;
            this.savingsTransactions.Location = new System.Drawing.Point(898, 181);
            this.savingsTransactions.Name = "savingsTransactions";
            this.savingsTransactions.Size = new System.Drawing.Size(398, 452);
            this.savingsTransactions.TabIndex = 25;
            // 
            // recordTransactionsButton
            // 
            this.recordTransactionsButton.Location = new System.Drawing.Point(120, 526);
            this.recordTransactionsButton.Name = "recordTransactionsButton";
            this.recordTransactionsButton.Size = new System.Drawing.Size(218, 117);
            this.recordTransactionsButton.TabIndex = 24;
            this.recordTransactionsButton.Text = "Record Transactions";
            this.recordTransactionsButton.UseVisualStyleBackColor = true;
            this.recordTransactionsButton.Click += new System.EventHandler(this.recordTransactionsButton_Click);
            // 
            // checkingTransactions
            // 
            this.checkingTransactions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkingTransactions.FormattingEnabled = true;
            this.checkingTransactions.ItemHeight = 28;
            this.checkingTransactions.Location = new System.Drawing.Point(472, 182);
            this.checkingTransactions.Name = "checkingTransactions";
            this.checkingTransactions.Size = new System.Drawing.Size(398, 452);
            this.checkingTransactions.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(891, 141);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(287, 38);
            this.label10.TabIndex = 22;
            this.label10.Text = "Savings Transactions";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(465, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(307, 38);
            this.label9.TabIndex = 21;
            this.label9.Text = "Checking Transactions";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(465, 66);
            this.errorMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(631, 38);
            this.errorMessage.TabIndex = 20;
            this.errorMessage.Text = "You have an overdraft protection transfer of $0.00";
            this.errorMessage.Visible = false;
            this.errorMessage.Click += new System.EventHandler(this.errorMessage_Click);
            // 
            // savingsBalanceValue
            // 
            this.savingsBalanceValue.AutoSize = true;
            this.savingsBalanceValue.Location = new System.Drawing.Point(322, 401);
            this.savingsBalanceValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.savingsBalanceValue.Name = "savingsBalanceValue";
            this.savingsBalanceValue.Size = new System.Drawing.Size(83, 38);
            this.savingsBalanceValue.TabIndex = 19;
            this.savingsBalanceValue.Text = "$0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 401);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 38);
            this.label6.TabIndex = 18;
            this.label6.Text = "Savings Balance";
            // 
            // checkingBalanceValue
            // 
            this.checkingBalanceValue.AutoSize = true;
            this.checkingBalanceValue.Location = new System.Drawing.Point(322, 289);
            this.checkingBalanceValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.checkingBalanceValue.Name = "checkingBalanceValue";
            this.checkingBalanceValue.Size = new System.Drawing.Size(83, 38);
            this.checkingBalanceValue.TabIndex = 17;
            this.checkingBalanceValue.Text = "$0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 38);
            this.label4.TabIndex = 16;
            this.label4.Text = "Checking Balance";
            // 
            // customerText
            // 
            this.customerText.AutoSize = true;
            this.customerText.Location = new System.Drawing.Point(313, 181);
            this.customerText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.customerText.Name = "customerText";
            this.customerText.Size = new System.Drawing.Size(118, 38);
            this.customerText.TabIndex = 15;
            this.customerText.Text = "<none>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 38);
            this.label2.TabIndex = 14;
            this.label2.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 54);
            this.label1.TabIndex = 13;
            this.label1.Text = "Banking Demo";
            // 
            // denyOverdraft
            // 
            this.denyOverdraft.AutoSize = true;
            this.denyOverdraft.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denyOverdraft.Location = new System.Drawing.Point(107, 463);
            this.denyOverdraft.Name = "denyOverdraft";
            this.denyOverdraft.Size = new System.Drawing.Size(231, 42);
            this.denyOverdraft.TabIndex = 26;
            this.denyOverdraft.Text = "Stop Overdrafts";
            this.denyOverdraft.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 685);
            this.Controls.Add(this.denyOverdraft);
            this.Controls.Add(this.savingsTransactions);
            this.Controls.Add(this.recordTransactionsButton);
            this.Controls.Add(this.checkingTransactions);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.savingsBalanceValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkingBalanceValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Dashboard";
            this.Text = "Banking Dashboard - A C# Events Demo by TimCorey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox savingsTransactions;
        private System.Windows.Forms.Button recordTransactionsButton;
        private System.Windows.Forms.ListBox checkingTransactions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Label savingsBalanceValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label checkingBalanceValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label customerText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox denyOverdraft;
    }
}