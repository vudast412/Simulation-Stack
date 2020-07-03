using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace CTDL_Bai2
{
    public partial class frmStack : Form
    {
        //Properties
        private bool selectPush = false;  //Cho biết button Push được ấn hay không
        private int speed = 15; //Tốc độ mô phỏng chương trình
        private static int MAX_SIZE = 9; //Số lượng node tối đa hiển thị, nếu vượt quá 9 thì tràn stack
        private int MAX_WIDTH; //Cho biết chiều dài tối đa của đường vẽ
        private int topxCurrent = -1, topyCurrent = -1; //Cho biết vị trí của node top hiện tại ở đâu để cập nhật đường trỏ vào top
        private int size; //Cho biết số node hiện tại
        private int nodeX;//Cho biết node cần vẽ hiện tại
        private int nodeY;//Cho biết node cần vẽ hiện tại
        private Graphics g;//Đồ họa
        private STACK<int> myStack; //Lớp stack đã xây dựng
        private Pen pen;//Bút vẽ
        private Random rd;//Hàm chọn số ngẫu nhiên 
        private PictureBox ptbAbout;//Picturebox hiện thị thông tin nhóm khi menu trip home được chọn
        //Constructor
        public frmStack()
        {
            InitializeComponent();
            InitField();
        }
        #region Method
        //Hàm khởi tạo cho các thuộc tính
        private void InitField()
        {
            myStack = new STACK<int>();
            rd = new Random();
            size = 0;
            nodeX = 200;
            nodeY = 502;
            numPush.Select(0, numPush.Value.ToString().Length);
            ptbAbout = new PictureBox()
            {
                Size = new Size(540, 620),
                Location = new Point(0, 22),
                BackColor = Color.White,
            };
            ptbAbout.BackgroundImage = Properties.Resources.about;
            ptbAbout.BackgroundImageLayout = ImageLayout.Center;
            g = pnlCanvas.CreateGraphics();
        }
        //Xử lý sự kiện button Push được nhấn
        private void btnPush_Click(object sender, EventArgs e)
        {      
            //Khi số lượng node chưa vượt quá 9:
            if (size < MAX_SIZE)
            {
                //
                txtHead.Text = "";
                nodeY -= 50;
                selectPush = true; 
                int x = Convert.ToInt32(numPush.Value); 
                myStack.Push(x);
                txtStack.Text = myStack.PrintStack();
                numPush.Focus();                
                numPush.Select(0, numPush.Value.ToString().Length);
                //
                //Đoạn này bắt đầu vẽ
                DrawNode(myStack.Top);
                size++;
            }
            else
                //Ngược lại
                MessageBox.Show("Stack overflow!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //Hàm vẽ một node
        private void DrawNode(NODE<int> node)
        {
            Brush br;
            //Nếu buttonPush được chọn sẽ vẽ màu của node và các đường 
            if (selectPush)
            {
                pen = new Pen(Color.Red, 3);
                br = new SolidBrush(Color.Black);
            }
            //Ngược lại cũng vẽ mà vẽ màu trắng để minh họa xóa các đường
            else
            {
                pen = new Pen(Color.White, 4);
                br = new SolidBrush(Color.White);
            }
            //Vẽ hình vuông biểu diễn 1 ô của node
            node.rectangle = new Rectangle(new Point(nodeX, nodeY), new Size(100, 25));
            g.DrawRectangle(pen, node.rectangle);
            //
            //Nếu selectPush = true , nghĩa là ta đang muốn thực hiện vẽ 1 node
            if (selectPush)
            {
                node.label.Location = new Point(nodeX + 2, nodeY + 2);
                pnlCanvas.Controls.Add(node.label);
                //Tiến hành vẽ mô phỏng animation
                DrawPointer();
            }
            //Ngược lại xóa thông tin node và đường 
            else
            {
                node.label.Dispose();
                node.label = null;
                pnlCanvas.Controls.Remove(node.label);
                //
                //Tiến hành xóa các đường đi
                g.DrawLine(pen, nodeX + 50, nodeY + 25, nodeX + 50, nodeY + 49);
                //Cập nhật là vị trí của node top
                UpdateTop();
            }
            br.Dispose();
        }
        //Hàm update vị trị của ô top
        private void UpdateTop()
        {
            //topxCurrent và topyCurrent sẽ được cập nhật vào mỗi lần ta thêm vào một node mới
            //nghĩa là khi ta push vào một node, thì topxCurrent và topyCurrent sẽ nắm vị trí của
            //node vừa push vào trước đó.
            //Lúc này nếu thỏa điều kiện bên dưới, thì ta xóa đi đường của node trước
            if (topxCurrent != -1 && topyCurrent != -1)
            {
                pen = new Pen(Color.White, 5);
                txtHead.Location = new Point(topxCurrent - 20, topyCurrent - 20);
                txtHead.Text = "";
                g.DrawLine(pen, topxCurrent - 5, topyCurrent, topxCurrent + 69, topyCurrent);
            }
            //Tiến hành cập nhật lại node top và tọa độ của txtHead
            topxCurrent = nodeX - 70;
            topyCurrent = nodeY + 12; 
            txtHead.Location = new Point(nodeX - 90, nodeY - 10);
            //Nếu số lượng node còn lớn hơn 0 thỏa mãn thì hiện txt Top lên
            if (size > 0)
                txtHead.Text = "Top ";          
            pen.Dispose();
        }
        /// <summary>
        /// Hàm vẽ node top
        /// </summary>
        int k = 0;
        private void DrawTop()
        {
            UpdateTop();
            MAX_WIDTH = 70;//Chiều dài tối đa của đường từ trái sang phải là 70
            //Thực hiện timer
            Timer time2 = new Timer();
            time2.Interval = speed;
            time2.Tick += time2_Tick;
            time2.Start();
        }
        void time2_Tick(object sender, EventArgs e)
        {
            if (k == MAX_WIDTH)
            {
                Timer time = sender as Timer;
                time.Stop();              
                k = 0;
                pen.Dispose();
                time.Dispose();
                time = null;
                UnCheckControls();//Sau khi vẽ xong thì mở khóa các button
            }
            else
            {
                pen = new Pen(Color.Red, 2);
                pen.EndCap = LineCap.ArrowAnchor;
                g.DrawLine(pen, nodeX - 70, nodeY + 12, nodeX - 70 + k, nodeY + 12);
                k++;
            }
        }
        //Hàm khóa các button khi đang mô phỏng
        //Người dùng chỉ ấn được khi chương trình mô phỏng xong
        private void UnCheckControls()
        {
           
            btnPeak.Enabled=!btnPeak.Enabled;
            btnPop.Enabled = !btnPop.Enabled;
            btnPush.Enabled=!btnPush.Enabled;
        }

        #region Hàm vẽ mô phỏng push một node vào stack
        private void DrawPointer()
        {

            UnCheckControls();
            MAX_WIDTH = 25;//Chiều dài tối đa của đường vẽ từ trên xuống là 25
            //Thực hiện timer
            Timer time = new Timer();
            time.Interval = speed;
            time.Tick += time_Tick;
            time.Start();
            //
        }
        int l = 0;
        void time_Tick(object sender, EventArgs e)
        {
            if (l == MAX_WIDTH)
            {
                Timer time = sender as Timer;
                time.Stop();           
                l = 0;
                pen.Dispose();
                //Khi vẽ xong đường từ trên xuống, thực hiện vẽ đường từ trái sáng phải
                DrawTop();
                //
                time.Dispose();
                time = null;
            }
            else
            {
                pen = new Pen(Color.Red, 2);
                pen.EndCap = LineCap.ArrowAnchor;
                g.DrawLine(pen, nodeX + 50, nodeY + 25, nodeX + 50, nodeY + 25 + l);
                l++;
            }
        }
        #endregion hàm vẽ mô phỏng push một node vào stack

        //Hàm xử lý sự kiện nhấn button Pop
        private void btnPop_Click(object sender, EventArgs e)
        {
            //Nếu stack khác rỗng thì tiến hành xóa
            if (!myStack.IsEmptyStack())
            {
                
                NODE<int> p;
                //Cho biết selectPush = false để khi vào trong hàm thì nó sẽ gọi
                //dòng lệnh xóa
                selectPush = false;
                p = myStack.Top;
                DrawNode(p);//
                size--;

                //Tọa độ của giảm theo chiều từ trên xuống
                nodeY += 50;
                //Bây giờ mới pop ra theo stack đã xây dựng
                txtPop.Text = myStack.Pop().ToString();
                txtStack.Text = myStack.PrintStack();
                p = myStack.Top;
                //
                //Trả lại nut selectPush = true
                selectPush = true;

                //Nếu size > 0 nghĩa là vẫn con node chua xóa, thực hiện
                //xóa ngược lại cập nhật txtHead = NULL
                if (size > 0)
                {
                    DrawNode(p);
                }
                else
                {
                    txtHead.Text = "Top = NULL";
                }
            }
            else
            {
                txtPop.Text = "";
                MessageBox.Show("Stack is empty!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Hàm xử lý sự kiên ấn button Peak
        private void btnPeak_Click(object sender, EventArgs e)
        {
            if (!myStack.IsEmptyStack())
            {
                txtPeak.Text = myStack.Top.Info.ToString();
                txtStack.Text = myStack.PrintStack();
            }
            else
            {
                txtPeak.Text = "";
                MessageBox.Show("Stack is empty!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Hàm xử lý sự kiện nhấn button Thoát
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want exit?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
        //Hàm random 1 số cho numPush
        private void button2_Click(object sender, EventArgs e)
        {
            numPush.Value = Convert.ToInt32(rd.Next(0, 1000));
        }
        ////Hàm xử lý menu exit được nhấn
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want exit?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
        //Hàm xử lý sự kiện menu about được nhấn
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Add(ptbAbout);
            ptbAbout.BringToFront();
        }
        ////Hàm xử lý sự kiện menu home được nhấn
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(ptbAbout);
        }
        //Hàm xử lý sự kiện thay đổi trackbar sẽ tăng tốc độ mô phỏng của chương trình
        private void tbSpeed_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbSpeed.Value) > 0)
                speed = 35 - Convert.ToInt32(tbSpeed.Value) * 5;
        }
        //Hàm xử lý sự kiện nhấn menu balance sẽ gọi form balance
        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBalance form = new frmBalance(this);
            form.ShowDialog();
        }
    }
        #endregion method
}
