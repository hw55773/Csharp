using System;

namespace Demo04
{
    partial class lblapp
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
            this.lblNew2 = new System.Windows.Forms.Label();
            this.lblNew1 = new System.Windows.Forms.Label();
            this.lblstring = new System.Windows.Forms.Label();
            this.lbljudge = new System.Windows.Forms.Label();
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.btncuti = new System.Windows.Forms.Button();
            this.btnpanfen = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNew2
            // 
            this.lblNew2.AutoSize = true;
            this.lblNew2.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNew2.Location = new System.Drawing.Point(340, 139);
            this.lblNew2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNew2.Name = "lblNew2";
            this.lblNew2.Size = new System.Drawing.Size(23, 23);
            this.lblNew2.TabIndex = 0;
            this.lblNew2.Text = "0";
            // 
            // lblNew1
            // 
            this.lblNew1.AutoSize = true;
            this.lblNew1.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNew1.Location = new System.Drawing.Point(201, 139);
            this.lblNew1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNew1.Name = "lblNew1";
            this.lblNew1.Size = new System.Drawing.Size(23, 23);
            this.lblNew1.TabIndex = 1;
            this.lblNew1.Text = "0";
            // 
            // lblstring
            // 
            this.lblstring.AutoSize = true;
            this.lblstring.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblstring.Location = new System.Drawing.Point(261, 139);
            this.lblstring.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstring.Name = "lblstring";
            this.lblstring.Size = new System.Drawing.Size(23, 23);
            this.lblstring.TabIndex = 2;
            this.lblstring.Text = "+";
            this.lblstring.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbljudge
            // 
            this.lbljudge.AutoSize = true;
            this.lbljudge.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbljudge.Location = new System.Drawing.Point(421, 139);
            this.lbljudge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbljudge.Name = "lbljudge";
            this.lbljudge.Size = new System.Drawing.Size(23, 23);
            this.lbljudge.TabIndex = 3;
            this.lbljudge.Text = "=";
            // 
            // txtanswer
            // 
            this.txtanswer.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtanswer.Location = new System.Drawing.Point(492, 136);
            this.txtanswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.Size = new System.Drawing.Size(124, 34);
            this.txtanswer.TabIndex = 4;
            // 
            // btncuti
            // 
            this.btncuti.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncuti.Location = new System.Drawing.Point(221, 305);
            this.btncuti.Name = "btncuti";
            this.btncuti.Size = new System.Drawing.Size(127, 49);
            this.btncuti.TabIndex = 5;
            this.btncuti.Text = "出题";
            this.btncuti.UseVisualStyleBackColor = true;
            this.btncuti.Click += new System.EventHandler(this.btncuti_Click);
            // 
            // btnpanfen
            // 
            this.btnpanfen.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnpanfen.Location = new System.Drawing.Point(598, 305);
            this.btnpanfen.Name = "btnpanfen";
            this.btnpanfen.Size = new System.Drawing.Size(143, 56);
            this.btnpanfen.TabIndex = 6;
            this.btnpanfen.Text = "判分";
            this.btnpanfen.UseVisualStyleBackColor = true;
            this.btnpanfen.Click += new System.EventHandler(this.btnpanfen_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(221, 392);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(520, 280);
            this.listBox1.TabIndex = 7;
            // 
            // lblapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 800);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnpanfen);
            this.Controls.Add(this.btncuti);
            this.Controls.Add(this.txtanswer);
            this.Controls.Add(this.lbljudge);
            this.Controls.Add(this.lblstring);
            this.Controls.Add(this.lblNew1);
            this.Controls.Add(this.lblNew2);
            this.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "lblapp";
            this.Text = "测试器";
            this.Load += new System.EventHandler(this.lblapp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblNew2;
        private System.Windows.Forms.Label lblNew1;
        private System.Windows.Forms.Label lblstring;
        private System.Windows.Forms.Label lbljudge;
        private System.Windows.Forms.TextBox txtanswer;
        private System.Windows.Forms.Button btncuti;
        private System.Windows.Forms.Button btnpanfen;
        private System.Windows.Forms.ListBox listBox1;
    }
}

