namespace HeadFirst
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnBuilde = new System.Windows.Forms.Button();
            this.btnDrive = new System.Windows.Forms.Button();
            this.btnAbstract = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuilde
            // 
            this.btnBuilde.Location = new System.Drawing.Point(397, 51);
            this.btnBuilde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuilde.Name = "btnBuilde";
            this.btnBuilde.Size = new System.Drawing.Size(100, 29);
            this.btnBuilde.TabIndex = 0;
            this.btnBuilde.Text = "生成器";
            this.btnBuilde.UseVisualStyleBackColor = true;
            this.btnBuilde.Click += new System.EventHandler(this.btnBuilde_Click);
            // 
            // btnDrive
            // 
            this.btnDrive.Location = new System.Drawing.Point(229, 51);
            this.btnDrive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDrive.Name = "btnDrive";
            this.btnDrive.Size = new System.Drawing.Size(100, 29);
            this.btnDrive.TabIndex = 1;
            this.btnDrive.Text = "工厂模式";
            this.btnDrive.UseVisualStyleBackColor = true;
            this.btnDrive.Click += new System.EventHandler(this.btnDrive_Click);
            // 
            // btnAbstract
            // 
            this.btnAbstract.Location = new System.Drawing.Point(61, 51);
            this.btnAbstract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbstract.Name = "btnAbstract";
            this.btnAbstract.Size = new System.Drawing.Size(100, 29);
            this.btnAbstract.TabIndex = 2;
            this.btnAbstract.Text = "抽象工厂";
            this.btnAbstract.UseVisualStyleBackColor = true;
            this.btnAbstract.Click += new System.EventHandler(this.btnAbstract_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 118);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbstract);
            this.Controls.Add(this.btnDrive);
            this.Controls.Add(this.btnBuilde);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuilde;
        private System.Windows.Forms.Button btnDrive;
        private System.Windows.Forms.Button btnAbstract;
        private System.Windows.Forms.Label label1;
    }
}

