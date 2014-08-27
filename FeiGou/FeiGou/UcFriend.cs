using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FeiGou
{
    public partial class UcFriend : UserControl
    {
        private FormMain form;

        public FormMain Form 
        {
            get { return form;}
            set { form = value; }
        }

        private Friend curFriend;

        public Friend CurFriend 
        {
            get { return curFriend; }
            set{
                 curFriend =value;
                 this.lalNickName.Text=value.NickName;
                 this.lalshuoshuo.Text=value.shuoshuo;
                 this.picHeadImage.Image = this.form.ilHeadImages.Images[value.HeadImageIndex];

            }
        }

        public UcFriend()
        {
            InitializeComponent();
        }

        private void UcFriend_Load(object sender, EventArgs e)
        {

        }
    }
}
