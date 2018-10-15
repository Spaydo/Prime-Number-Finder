namespace Prime_Number_Finder
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtIn = new System.Windows.Forms.TextBox();
            this.BtnFind = new System.Windows.Forms.Button();
            this.TxtAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtIn
            // 
            this.TxtIn.Font = new System.Drawing.Font("新細明體", 12F);
            this.TxtIn.Location = new System.Drawing.Point(12, 28);
            this.TxtIn.Name = "TxtIn";
            this.TxtIn.Size = new System.Drawing.Size(144, 27);
            this.TxtIn.TabIndex = 0;
            // 
            // BtnFind
            // 
            this.BtnFind.Font = new System.Drawing.Font("新細明體", 12F);
            this.BtnFind.Location = new System.Drawing.Point(162, 26);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(54, 27);
            this.BtnFind.TabIndex = 1;
            this.BtnFind.Text = "查詢";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // TxtAnswer
            // 
            this.TxtAnswer.Enabled = false;
            this.TxtAnswer.Font = new System.Drawing.Font("新細明體", 12F);
            this.TxtAnswer.Location = new System.Drawing.Point(12, 77);
            this.TxtAnswer.Multiline = true;
            this.TxtAnswer.Name = "TxtAnswer";
            this.TxtAnswer.ReadOnly = true;
            this.TxtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAnswer.Size = new System.Drawing.Size(400, 300);
            this.TxtAnswer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "下方輸入 二 ~ 四十億 整數(依電腦性能建議最高不超過一千萬)";
            // 
            // TxtSum
            // 
            this.TxtSum.Font = new System.Drawing.Font("新細明體", 12F);
            this.TxtSum.Location = new System.Drawing.Point(376, 28);
            this.TxtSum.Name = "TxtSum";
            this.TxtSum.ReadOnly = true;
            this.TxtSum.Size = new System.Drawing.Size(100, 27);
            this.TxtSum.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(222, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "範圍內質數數量為 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "下列顯示找到的質數(由於耗效能此功能暫時關閉)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 57);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAnswer);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.TxtIn);
            this.Name = "Form1";
            this.Text = "質數查詢器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIn;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.TextBox TxtAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

