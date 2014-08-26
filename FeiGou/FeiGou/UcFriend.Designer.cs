namespace FeiGou
{
    partial class UcFriend
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcFriend));
            this.picHeadImage = new System.Windows.Forms.PictureBox();
            this.lalNickName = new System.Windows.Forms.Label();
            this.lalshuoshuo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picHeadImage
            // 
            this.picHeadImage.Image = ((System.Drawing.Image)(resources.GetObject("picHeadImage.Image")));
            this.picHeadImage.Location = new System.Drawing.Point(16, 12);
            this.picHeadImage.Name = "picHeadImage";
            this.picHeadImage.Size = new System.Drawing.Size(43, 43);
            this.picHeadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeadImage.TabIndex = 0;
            this.picHeadImage.TabStop = false;
            // 
            // lalNickName
            // 
            this.lalNickName.AutoSize = true;
            this.lalNickName.Location = new System.Drawing.Point(92, 12);
            this.lalNickName.Name = "lalNickName";
            this.lalNickName.Size = new System.Drawing.Size(41, 12);
            this.lalNickName.TabIndex = 1;
            this.lalNickName.Text = "label1";
            // 
            // lalshuoshuo
            // 
            this.lalshuoshuo.AutoSize = true;
            this.lalshuoshuo.Location = new System.Drawing.Point(92, 43);
            this.lalshuoshuo.Name = "lalshuoshuo";
            this.lalshuoshuo.Size = new System.Drawing.Size(41, 12);
            this.lalshuoshuo.TabIndex = 2;
            this.lalshuoshuo.Text = "label2";
            // 
            // UcFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lalshuoshuo);
            this.Controls.Add(this.lalNickName);
            this.Controls.Add(this.picHeadImage);
            this.Name = "UcFriend";
            this.Size = new System.Drawing.Size(200, 70);
            this.Load += new System.EventHandler(this.UcFriend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeadImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHeadImage;
        private System.Windows.Forms.Label lalNickName;
        private System.Windows.Forms.Label lalshuoshuo;
    }
}
