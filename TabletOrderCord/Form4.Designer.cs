
namespace TabletOrder {
    partial class Form4 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(231, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "合計金額";
            // 
            // money
            // 
            this.money.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.money.Location = new System.Drawing.Point(430, 199);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(80, 24);
            this.money.TabIndex = 1;
            this.money.Text = "0";
            this.money.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(362, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "￥";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(536, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "円";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(231, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "ご利用、誠に有難う御座いました。";
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(235, 273);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(123, 68);
            this.account.TabIndex = 5;
            this.account.Text = "会計";
            this.account.UseVisualStyleBackColor = true;
            this.account.Click += new System.EventHandler(this.Account_Button);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(434, 273);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(123, 68);
            this.back.TabIndex = 6;
            this.back.Text = "戻る";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.Back_Button);
            // 
            // endLabel
            // 
            this.endLabel.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.endLabel.Location = new System.Drawing.Point(147, 82);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(534, 280);
            this.endLabel.TabIndex = 7;
            this.endLabel.Text = "ご利用有難う御座いました。\r\n\r\nまたのお越しをお待ちしております。\r\n";
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.back);
            this.Controls.Add(this.account);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button account;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label endLabel;
    }
}