namespace demmo07
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnLtriangle = new System.Windows.Forms.RadioButton();
            this.rbtArrow = new System.Windows.Forms.RadioButton();
            this.rbtnPentadram = new System.Windows.Forms.RadioButton();
            this.rbtnPolygon = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.rbtnEllipse = new System.Windows.Forms.RadioButton();
            this.rbtnFreeLine = new System.Windows.Forms.RadioButton();
            this.rbtnRect = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnLtriangle);
            this.groupBox1.Controls.Add(this.rbtArrow);
            this.groupBox1.Controls.Add(this.rbtnPentadram);
            this.groupBox1.Controls.Add(this.rbtnPolygon);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnRetry);
            this.groupBox1.Controls.Add(this.rbtnEllipse);
            this.groupBox1.Controls.Add(this.rbtnFreeLine);
            this.groupBox1.Controls.Add(this.rbtnRect);
            this.groupBox1.Location = new System.Drawing.Point(31, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtnLtriangle
            // 
            this.rbtnLtriangle.AutoSize = true;
            this.rbtnLtriangle.Location = new System.Drawing.Point(3, 172);
            this.rbtnLtriangle.Name = "rbtnLtriangle";
            this.rbtnLtriangle.Size = new System.Drawing.Size(103, 19);
            this.rbtnLtriangle.TabIndex = 8;
            this.rbtnLtriangle.TabStop = true;
            this.rbtnLtriangle.Text = "直角三角形";
            this.rbtnLtriangle.UseVisualStyleBackColor = true;
            // 
            // rbtArrow
            // 
            this.rbtArrow.AutoSize = true;
            this.rbtArrow.Location = new System.Drawing.Point(3, 146);
            this.rbtArrow.Name = "rbtArrow";
            this.rbtArrow.Size = new System.Drawing.Size(58, 19);
            this.rbtArrow.TabIndex = 7;
            this.rbtArrow.TabStop = true;
            this.rbtArrow.Text = "箭头";
            this.rbtArrow.UseVisualStyleBackColor = true;
            // 
            // rbtnPentadram
            // 
            this.rbtnPentadram.AutoSize = true;
            this.rbtnPentadram.Location = new System.Drawing.Point(3, 121);
            this.rbtnPentadram.Name = "rbtnPentadram";
            this.rbtnPentadram.Size = new System.Drawing.Size(73, 19);
            this.rbtnPentadram.TabIndex = 6;
            this.rbtnPentadram.TabStop = true;
            this.rbtnPentadram.Text = "五边形";
            this.rbtnPentadram.UseVisualStyleBackColor = true;
            // 
            // rbtnPolygon
            // 
            this.rbtnPolygon.AutoSize = true;
            this.rbtnPolygon.Location = new System.Drawing.Point(3, 96);
            this.rbtnPolygon.Name = "rbtnPolygon";
            this.rbtnPolygon.Size = new System.Drawing.Size(73, 19);
            this.rbtnPolygon.TabIndex = 5;
            this.rbtnPolygon.TabStop = true;
            this.rbtnPolygon.Text = "三角形";
            this.rbtnPolygon.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(0, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "撤销";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(97, 233);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(75, 23);
            this.btnRetry.TabIndex = 3;
            this.btnRetry.Text = "重做";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // rbtnEllipse
            // 
            this.rbtnEllipse.AutoSize = true;
            this.rbtnEllipse.Location = new System.Drawing.Point(3, 71);
            this.rbtnEllipse.Name = "rbtnEllipse";
            this.rbtnEllipse.Size = new System.Drawing.Size(58, 19);
            this.rbtnEllipse.TabIndex = 2;
            this.rbtnEllipse.TabStop = true;
            this.rbtnEllipse.Text = "椭圆";
            this.rbtnEllipse.UseVisualStyleBackColor = true;
            // 
            // rbtnFreeLine
            // 
            this.rbtnFreeLine.AutoSize = true;
            this.rbtnFreeLine.Location = new System.Drawing.Point(3, 46);
            this.rbtnFreeLine.Name = "rbtnFreeLine";
            this.rbtnFreeLine.Size = new System.Drawing.Size(58, 19);
            this.rbtnFreeLine.TabIndex = 1;
            this.rbtnFreeLine.TabStop = true;
            this.rbtnFreeLine.Text = "曲线";
            this.rbtnFreeLine.UseVisualStyleBackColor = true;
            // 
            // rbtnRect
            // 
            this.rbtnRect.AutoSize = true;
            this.rbtnRect.Location = new System.Drawing.Point(3, 21);
            this.rbtnRect.Name = "rbtnRect";
            this.rbtnRect.Size = new System.Drawing.Size(58, 19);
            this.rbtnRect.TabIndex = 0;
            this.rbtnRect.TabStop = true;
            this.rbtnRect.Text = "矩形";
            this.rbtnRect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFreeLine;
        private System.Windows.Forms.RadioButton rbtnRect;
        private System.Windows.Forms.RadioButton rbtnEllipse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.RadioButton rbtnPolygon;
        private System.Windows.Forms.RadioButton rbtnPentadram;
        private System.Windows.Forms.RadioButton rbtArrow;
        private System.Windows.Forms.RadioButton rbtnLtriangle;
    }
}

