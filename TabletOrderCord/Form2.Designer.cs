
namespace TabletOrder {
    partial class Form2 {
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
            this.order_get = new System.Windows.Forms.Button();
            this.order_price = new System.Windows.Forms.Label();
            this.order_picture = new System.Windows.Forms.PictureBox();
            this.order_count = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.order_back = new System.Windows.Forms.Button();
            this.order_hit = new System.Windows.Forms.Label();
            this.back_form1 = new System.Windows.Forms.Button();
            this.order_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.order_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // order_get
            // 
            this.order_get.Location = new System.Drawing.Point(465, 328);
            this.order_get.Name = "order_get";
            this.order_get.Size = new System.Drawing.Size(94, 41);
            this.order_get.TabIndex = 1;
            this.order_get.Text = "決定";
            this.order_get.UseVisualStyleBackColor = true;
            this.order_get.Click += new System.EventHandler(this.Confirm_Button);
            // 
            // order_price
            // 
            this.order_price.AutoSize = true;
            this.order_price.Location = new System.Drawing.Point(476, 177);
            this.order_price.Name = "order_price";
            this.order_price.Size = new System.Drawing.Size(52, 18);
            this.order_price.TabIndex = 2;
            this.order_price.Text = "label1";
            // 
            // order_picture
            // 
            this.order_picture.Location = new System.Drawing.Point(76, 89);
            this.order_picture.Name = "order_picture";
            this.order_picture.Size = new System.Drawing.Size(280, 280);
            this.order_picture.TabIndex = 3;
            this.order_picture.TabStop = false;
            // 
            // order_count
            // 
            this.order_count.AutoSize = true;
            this.order_count.Location = new System.Drawing.Point(554, 257);
            this.order_count.Name = "order_count";
            this.order_count.Size = new System.Drawing.Size(17, 18);
            this.order_count.TabIndex = 4;
            this.order_count.Text = "1";
            this.order_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(465, 250);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(52, 33);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Back_Button);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(646, 250);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(52, 33);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.Next_Button);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "人前";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // order_back
            // 
            this.order_back.Location = new System.Drawing.Point(604, 328);
            this.order_back.Name = "order_back";
            this.order_back.Size = new System.Drawing.Size(94, 41);
            this.order_back.TabIndex = 8;
            this.order_back.Text = "戻る";
            this.order_back.UseVisualStyleBackColor = true;
            this.order_back.Click += new System.EventHandler(this.Delete);
            // 
            // order_hit
            // 
            this.order_hit.AutoSize = true;
            this.order_hit.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.order_hit.Location = new System.Drawing.Point(308, 195);
            this.order_hit.Name = "order_hit";
            this.order_hit.Size = new System.Drawing.Size(197, 24);
            this.order_hit.TabIndex = 9;
            this.order_hit.Text = "注文が確定しました";
            this.order_hit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back_form1
            // 
            this.back_form1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.back_form1.Location = new System.Drawing.Point(355, 280);
            this.back_form1.Name = "back_form1";
            this.back_form1.Size = new System.Drawing.Size(104, 40);
            this.back_form1.TabIndex = 10;
            this.back_form1.Text = "元画面へ";
            this.back_form1.UseVisualStyleBackColor = true;
            this.back_form1.Click += new System.EventHandler(this.Delete);
            // 
            // order_name
            // 
            this.order_name.AutoSize = true;
            this.order_name.Location = new System.Drawing.Point(607, 119);
            this.order_name.Name = "order_name";
            this.order_name.Size = new System.Drawing.Size(52, 18);
            this.order_name.TabIndex = 11;
            this.order_name.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.order_name);
            this.Controls.Add(this.back_form1);
            this.Controls.Add(this.order_hit);
            this.Controls.Add(this.order_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.order_count);
            this.Controls.Add(this.order_picture);
            this.Controls.Add(this.order_price);
            this.Controls.Add(this.order_get);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.order_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button order_get;
        private System.Windows.Forms.PictureBox order_picture;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button order_back;
        private System.Windows.Forms.Label order_hit;
        private System.Windows.Forms.Button back_form1;
        public System.Windows.Forms.Label order_price;
        public System.Windows.Forms.Label order_count;
        private System.Windows.Forms.Label order_name;
    }
}