namespace FeiGou
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.picHeadImage = new System.Windows.Forms.PictureBox();
            this.lalNickName = new System.Windows.Forms.Label();
            this.lalshuoshuo = new System.Windows.Forms.Label();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnFriendlist = new System.Windows.Forms.Panel();
            this.ilHeadImages = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picHeadImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picHeadImage
            // 
            this.picHeadImage.Image = ((System.Drawing.Image)(resources.GetObject("picHeadImage.Image")));
            this.picHeadImage.Location = new System.Drawing.Point(5, 5);
            this.picHeadImage.Name = "picHeadImage";
            this.picHeadImage.Size = new System.Drawing.Size(80, 80);
            this.picHeadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeadImage.TabIndex = 0;
            this.picHeadImage.TabStop = false;
            this.picHeadImage.WaitOnLoad = true;
            // 
            // lalNickName
            // 
            this.lalNickName.AutoSize = true;
            this.lalNickName.Location = new System.Drawing.Point(115, 20);
            this.lalNickName.Name = "lalNickName";
            this.lalNickName.Size = new System.Drawing.Size(41, 12);
            this.lalNickName.TabIndex = 1;
            this.lalNickName.Text = "label1";
            // 
            // lalshuoshuo
            // 
            this.lalshuoshuo.AutoSize = true;
            this.lalshuoshuo.Location = new System.Drawing.Point(115, 73);
            this.lalshuoshuo.Name = "lalshuoshuo";
            this.lalshuoshuo.Size = new System.Drawing.Size(41, 12);
            this.lalshuoshuo.TabIndex = 2;
            this.lalshuoshuo.Text = "label2";
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(180, 11);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(100, 21);
            this.txtNickName.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(180, 62);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "button1";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnFriendlist
            // 
            this.pnFriendlist.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pnFriendlist.AutoScroll = true;
            this.pnFriendlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFriendlist.Location = new System.Drawing.Point(5, 111);
            this.pnFriendlist.Name = "pnFriendlist";
            this.pnFriendlist.Size = new System.Drawing.Size(267, 139);
            this.pnFriendlist.TabIndex = 5;
            // 
            // ilHeadImages
            // 
            this.ilHeadImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.ilHeadImages.ImageSize = new System.Drawing.Size(80, 80);
            this.ilHeadImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 310);
            this.Controls.Add(this.pnFriendlist);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.lalshuoshuo);
            this.Controls.Add(this.lalNickName);
            this.Controls.Add(this.picHeadImage);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeadImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHeadImage;
        private System.Windows.Forms.Label lalNickName;
        private System.Windows.Forms.Label lalshuoshuo;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnFriendlist;
        private System.Windows.Forms.ImageList ilHeadImages;
    }
}