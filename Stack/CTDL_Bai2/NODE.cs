using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace CTDL_Bai2
{
    class NODE<T>
    {
        //Properties
        public T Info;
        public NODE<T> Next;
        public Rectangle rectangle;
        public Label label;
        //Constructor
        public NODE()
        {
            Next = null;
        }
        public NODE(T x)
        {
            Info = x;
            Next = null;
            label = new Label
            {
                Size = new Size(94, 18),
                AutoSize = true,
                Font = new Font("Times new roman", 14f, FontStyle.Bold),
                BackColor = Color.White,
                Text = x.ToString(),

            };
        }
    }
}
