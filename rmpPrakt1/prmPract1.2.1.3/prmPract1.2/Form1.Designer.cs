namespace prmPract1._2
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
            this.products_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.product_title_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.product_price_box = new System.Windows.Forms.NumericUpDown();
            this.add_btn = new System.Windows.Forms.Button();
            this.product_count_box = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.product_buy_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buyBtn = new System.Windows.Forms.Button();
            this.response_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_price_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_count_box)).BeginInit();
            this.SuspendLayout();
            // 
            // products_label
            // 
            this.products_label.Location = new System.Drawing.Point(12, 9);
            this.products_label.Name = "products_label";
            this.products_label.Size = new System.Drawing.Size(574, 380);
            this.products_label.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(620, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавить товар";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(620, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // product_title_box
            // 
            this.product_title_box.Location = new System.Drawing.Point(620, 77);
            this.product_title_box.Name = "product_title_box";
            this.product_title_box.Size = new System.Drawing.Size(168, 22);
            this.product_title_box.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(620, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена";
            // 
            // product_price_box
            // 
            this.product_price_box.Location = new System.Drawing.Point(620, 140);
            this.product_price_box.Name = "product_price_box";
            this.product_price_box.Size = new System.Drawing.Size(168, 22);
            this.product_price_box.TabIndex = 5;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(620, 237);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(100, 35);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // product_count_box
            // 
            this.product_count_box.Location = new System.Drawing.Point(620, 199);
            this.product_count_box.Name = "product_count_box";
            this.product_count_box.Size = new System.Drawing.Size(168, 22);
            this.product_count_box.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(620, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Колчество";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(620, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Купить";
            // 
            // product_buy_box
            // 
            this.product_buy_box.Location = new System.Drawing.Point(620, 367);
            this.product_buy_box.Name = "product_buy_box";
            this.product_buy_box.Size = new System.Drawing.Size(168, 22);
            this.product_buy_box.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(620, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Название";
            // 
            // buyBtn
            // 
            this.buyBtn.Location = new System.Drawing.Point(620, 403);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(100, 35);
            this.buyBtn.TabIndex = 12;
            this.buyBtn.Text = "Купить";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // response_label
            // 
            this.response_label.Location = new System.Drawing.Point(12, 412);
            this.response_label.Name = "response_label";
            this.response_label.Size = new System.Drawing.Size(260, 23);
            this.response_label.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.response_label);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.product_buy_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.product_count_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.product_price_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.product_title_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.products_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_price_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_count_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label response_label;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox product_buy_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buyBtn;

        private System.Windows.Forms.NumericUpDown product_count_box;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown product_price_box;
        private System.Windows.Forms.Button add_btn;

        private System.Windows.Forms.TextBox product_title_box;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label products_label;

        #endregion
    }
}