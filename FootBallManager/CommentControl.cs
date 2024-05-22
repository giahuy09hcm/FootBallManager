using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBallManager
{
    public partial class CommentControl : UserControl
    {
        public CommentControl()
        {
            InitializeComponent();
        }
        public void SetComment(string text, string dateTime)
        {
            lblComment.Text = text;
            // Thiết lập kiểu viền cho lblComment
            lblComment.BorderStyle = BorderStyle.FixedSingle;
            lblDateTime.Text = dateTime;
            lblDateTime.AutoSize = true;
            lblDateTime.AutoEllipsis = false;
            //picAvatar.Image = avatar;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.RowCount = 1;
        }
    }
}
