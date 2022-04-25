namespace MyLirarySystem
{
    partial class FrmManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManage));
            this.label1 = new System.Windows.Forms.Label();
            this.tetShow = new System.Windows.Forms.RichTextBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "图书借阅管理制度";
            // 
            // tetShow
            // 
            this.tetShow.Location = new System.Drawing.Point(28, 42);
            this.tetShow.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tetShow.Name = "tetShow";
            this.tetShow.ReadOnly = true;
            this.tetShow.Size = new System.Drawing.Size(435, 419);
            this.tetShow.TabIndex = 20;
            this.tetShow.Text = resources.GetString("tetShow.Text");
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(393, 469);
            this.btnYes.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(67, 39);
            this.btnYes.TabIndex = 21;
            this.btnYes.Text = "确 定";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // FrmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 569);
            this.ControlBox = false;
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.tetShow);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(491, 569);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(491, 569);
            this.Name = "FrmManage";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tetShow;
        private System.Windows.Forms.Button btnYes;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}