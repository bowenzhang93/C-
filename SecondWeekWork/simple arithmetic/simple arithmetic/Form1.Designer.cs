namespace simple_arithmetic
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grbType = new System.Windows.Forms.GroupBox();
            this.chb10Mul = new System.Windows.Forms.CheckBox();
            this.chbinner100 = new System.Windows.Forms.CheckBox();
            this.chbinner10 = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chbAutoNext = new System.Windows.Forms.CheckBox();
            this.labNummer1 = new System.Windows.Forms.Label();
            this.labOp = new System.Windows.Forms.Label();
            this.labNummer2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnterResult = new System.Windows.Forms.TextBox();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.grbRecord = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbType
            // 
            this.grbType.Controls.Add(this.chb10Mul);
            this.grbType.Controls.Add(this.chbinner100);
            this.grbType.Controls.Add(this.chbinner10);
            this.grbType.Location = new System.Drawing.Point(29, 29);
            this.grbType.Name = "grbType";
            this.grbType.Size = new System.Drawing.Size(479, 63);
            this.grbType.TabIndex = 0;
            this.grbType.TabStop = false;
            this.grbType.Text = "题目类型";
            this.grbType.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chb10Mul
            // 
            this.chb10Mul.AutoSize = true;
            this.chb10Mul.Location = new System.Drawing.Point(326, 24);
            this.chb10Mul.Name = "chb10Mul";
            this.chb10Mul.Size = new System.Drawing.Size(119, 19);
            this.chb10Mul.TabIndex = 1;
            this.chb10Mul.Text = "十以内的乘法";
            this.chb10Mul.UseVisualStyleBackColor = true;
            this.chb10Mul.CheckedChanged += new System.EventHandler(this.chb10Mul_CheckedChanged);
            // 
            // chbinner100
            // 
            this.chbinner100.AutoSize = true;
            this.chbinner100.Location = new System.Drawing.Point(166, 24);
            this.chbinner100.Name = "chbinner100";
            this.chbinner100.Size = new System.Drawing.Size(113, 19);
            this.chbinner100.TabIndex = 1;
            this.chbinner100.Text = "100以内运算";
            this.chbinner100.UseVisualStyleBackColor = true;
            this.chbinner100.CheckedChanged += new System.EventHandler(this.chbinner100_CheckedChanged);
            // 
            // chbinner10
            // 
            this.chbinner10.AutoSize = true;
            this.chbinner10.Location = new System.Drawing.Point(24, 24);
            this.chbinner10.Name = "chbinner10";
            this.chbinner10.Size = new System.Drawing.Size(105, 19);
            this.chbinner10.TabIndex = 1;
            this.chbinner10.Text = "10以内运算";
            this.chbinner10.UseVisualStyleBackColor = true;
            this.chbinner10.CheckedChanged += new System.EventHandler(this.chbinner10_CheckedChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGenerate.Location = new System.Drawing.Point(528, 41);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(171, 51);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "出题";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chbAutoNext
            // 
            this.chbAutoNext.AutoSize = true;
            this.chbAutoNext.Location = new System.Drawing.Point(528, 98);
            this.chbAutoNext.Name = "chbAutoNext";
            this.chbAutoNext.Size = new System.Drawing.Size(134, 19);
            this.chbAutoNext.TabIndex = 2;
            this.chbAutoNext.Text = "自动显示下一题";
            this.chbAutoNext.UseVisualStyleBackColor = true;
            this.chbAutoNext.CheckedChanged += new System.EventHandler(this.chbAutoNext_CheckedChanged);
            // 
            // labNummer1
            // 
            this.labNummer1.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNummer1.Location = new System.Drawing.Point(12, 192);
            this.labNummer1.Name = "labNummer1";
            this.labNummer1.Size = new System.Drawing.Size(205, 136);
            this.labNummer1.TabIndex = 3;
            this.labNummer1.Text = "0";
            this.labNummer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labOp
            // 
            this.labOp.AutoSize = true;
            this.labOp.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOp.Location = new System.Drawing.Point(201, 192);
            this.labOp.Name = "labOp";
            this.labOp.Size = new System.Drawing.Size(125, 136);
            this.labOp.TabIndex = 3;
            this.labOp.Text = "+";
            this.labOp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labNummer2
            // 
            this.labNummer2.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNummer2.Location = new System.Drawing.Point(332, 195);
            this.labNummer2.Name = "labNummer2";
            this.labNummer2.Size = new System.Drawing.Size(198, 136);
            this.labNummer2.TabIndex = 3;
            this.labNummer2.Text = "0";
            this.labNummer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 136);
            this.label3.TabIndex = 3;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEnterResult
            // 
            this.txtEnterResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnterResult.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterResult.Location = new System.Drawing.Point(645, 195);
            this.txtEnterResult.Multiline = true;
            this.txtEnterResult.Name = "txtEnterResult";
            this.txtEnterResult.Size = new System.Drawing.Size(244, 136);
            this.txtEnterResult.TabIndex = 4;
            this.txtEnterResult.Text = "0";
            this.txtEnterResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHistory
            // 
            this.txtHistory.Location = new System.Drawing.Point(126, 365);
            this.txtHistory.Multiline = true;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ReadOnly = true;
            this.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistory.Size = new System.Drawing.Size(673, 238);
            this.txtHistory.TabIndex = 5;
           
            // 
            // grbRecord
            // 
            this.grbRecord.Location = new System.Drawing.Point(100, 333);
            this.grbRecord.Name = "grbRecord";
            this.grbRecord.Size = new System.Drawing.Size(724, 292);
            this.grbRecord.TabIndex = 6;
            this.grbRecord.TabStop = false;
            this.grbRecord.Text = "历史记录";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCheck.Location = new System.Drawing.Point(731, 41);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(171, 51);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "判分";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 60);
            this.label1.TabIndex = 8;
            this.label1.Text = "选择题目类型，点击出题按钮/自动显示下一题复选框，\r\n回答问题，点击判分按钮/直接按回车键。\r\n如果回答正确，则可再次出题；\r\n如果不正确需要继续回答当前问题，直" +
    "到正确为止。\r\n";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(19, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "玩法：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.Location = new System.Drawing.Point(837, 365);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 238);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(19, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "PS：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(76, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(375, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "除法需要输入保留两位小数点后的结果。\r\n例如，5 / 2 = 2.50 为正确解，但是输入2.5则判错。";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 651);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.txtEnterResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labNummer2);
            this.Controls.Add(this.labOp);
            this.Controls.Add(this.labNummer1);
            this.Controls.Add(this.chbAutoNext);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.grbType);
            this.Controls.Add(this.grbRecord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbType.ResumeLayout(false);
            this.grbType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbType;
        private System.Windows.Forms.CheckBox chb10Mul;
        private System.Windows.Forms.CheckBox chbinner100;
        private System.Windows.Forms.CheckBox chbinner10;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chbAutoNext;
        private System.Windows.Forms.Label labNummer1;
        private System.Windows.Forms.Label labOp;
        private System.Windows.Forms.Label labNummer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnterResult;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.GroupBox grbRecord;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

