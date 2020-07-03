using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTDL_Bai2
{
    public partial class frmBalance : Form
    {
        //Properties
        frmStack formStack;
        //Constructor
        public frmBalance(frmStack frm)
        {
            InitializeComponent();
            formStack = frm;
        }
        //Hàm xử lý sự kiện thoát khỏi chương trình
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        //Xử lý sự kiện click button chuyển đổi
        private void btnChuyenDoi_Click(object sender, EventArgs e)
        {

            string s = txtInput.Text;//Lay bieu thuc sau khi nhap
            s = s.Trim();
            //KiemTra dau vao voi chuc nang loai bo nguoi dung nhap ký tự hoặc biểu thức tiên tự 
            if (!KiemTraDauVao(s))
            {
                MessageBox.Show("Vui lòng nhập phương thức hợp lệ");
            }
            else if (cbSelect.SelectedIndex == 0)//Trung tố sang hậu tố 
            {
                string result = "";//Chuỗi tạm thời để lưu chuỗi kết quả sau khi thực hiện chuyển đổi
                TrungSangHau(s, ref result);//Hàm thực hiện chuyển đổi biểu thức trung tố sang hậu tố
                txtResult.Text = result;//Gán chuỗi tạm thời vào field kết quả hiển thị sau khi chuyển đổi
                lbValue.Text = TinhGiaTriBieuThuc(result).ToString();
                //Thực hiện tính toán biểu thức sau khi chuyển đổi sau đó gán vào field 
                //kết quả giá trị để hiển thị
            }
            else if (cbSelect.SelectedIndex == 1)//Hậu tố sang trung tố
            {
                if (KiemTraBieuThuc(s))
                {
                    string result = "";//Chuỗi tạm thời để lưu chuỗi kết quả sau khi thực hiện chuyển đổi
                    lbValue.Text = TinhGiaTriBieuThuc(s).ToString();//Thực hiện tính toán biểu thức sau khi 
                    //chuyển đổi sau đó gán vào field kết quả giá trị để hiển thị
                    HauSangTrung(s, ref result);//Hàm thực hiện chuyển từ hậu tố sang trung tố
                    txtResult.Text = result;//Gán chuỗi tạm thời vào field kết quả hiển thị sau khi chuyển đổi
                }
                else
                {
                    MessageBox.Show("Lưu ý bạn chuyển từ hậu tố sang trung tố !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                DialogResult diaKetQua = MessageBox.Show("Vui lòng chọn phương thức", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                //Thông báo nếu bạn không chọn lựa chọn trong menu phương thức thì nó sẽ thông báo lỗi.
            }
        }

        private void TrungSangHau(string s, ref string result)
        {
            STACK<char> myStack = new STACK<char>();//Khởi tạo ngăn xếp
            myStack.Push('N');//Đặt 'N' là cờ đáy.
            int length = s.Count();//Lấy độ dài của biểu thức
            string ketQua = "";//Kết quả 
            for (int i = 0; i < length; i++)
            {
                if (LaSoHang(s[i]))//Kiểm tra nếu phần tử là số hạng
                {
                    ketQua += s[i];//Cho số đó vào biến kết quả
                }
                else if (s[i] == '(')//Nếu gặp dấu ngoặc đơn 
                {
                    myStack.Push('(');//Cho dấu ngoặc đơn vào ngăn xếp
                }
                else if (s[i] == ')')//nếu gặp dấu ngoặc đơn đóng kết thúc một biểu thức
                {
                    //Xử lý lấy các dấu còn lại trong biểu thức ưu tiên (trong ngoặc đơn)
                    while ((char)myStack.Peak() != 'N')
                    {
                        char c = (char)myStack.Peak();
                        myStack.Pop();
                        if (c != '(')
                            ketQua += c;//Thêm toán tử vào biểu thức kết quả
                    }
                }
                else
                {
                    ketQua += ' ';
                    while ((char)myStack.Peak() != 'N' && LaToanHang(s[i]) <= LaToanHang((char)myStack.Peak()))//Kiểm tra  toán tử ưu tiên
                    {   //Nếu trong ngăn xếp lấy ra dâu nhân còn s[i] là - thì thõa man vì phép toán thì nhân chia trước công trừ sau .
                        char c = (char)myStack.Peak();
                        myStack.Pop();
                        ketQua += c;//Cho toán tử ưu tiên vào kết quả
                    }
                    myStack.Push(s[i]);//Cho toán tử vào ngăn xếp
                }
            }
            //Lấy toán tử còn lại thực hiện 
            while ((char)myStack.Peak() != 'N')
            {
                char c = (char)myStack.Peak();
                myStack.Pop();
                ketQua += c;//Cho toan tu con cuối cùng vào biểu thức
            }
            result = ketQua;//Đưa ra kết quả 
        }
        //Hàm chuyển từ hậu tố sang trung tố
        private void HauSangTrung(string s, ref string result)
        {
            STACK<string> myStack = new STACK<string>();//Khởi tạo ngăn xếp
            for (int i = 0; i < s.Count(); i++)
            {
                if (LaSoHang(s[i]))//Kiểm tra phần tử có phải là số hang hay không
                {
                    double soHang = 0;
                    while (LaSoHang(s[i]))//Xu lý với số hạng lớn hơn hai bằng hai chữ số
                    {
                        soHang = soHang * 10 + (double)(s[i] - '0');//Xử lý để được một số hạng nếu số hạng đó lớn hơn hai chữ số.
                        i++;//Bước nhảy này nhầm kiểm tra phần tử tiếp theo có phải số hạng hay không
                    }
                    i--;
                    myStack.Push(soHang.ToString());//Cho chuỗi vào ngăn xếp
                }
                else if (s[i] == ' ')//' ' dùng để phân cách hai số hạng khác nhau nếu gặp ' ' thì bỏ qua tiếp tục vòng lặp tiếp theo
                {
                    continue;//Tiếp tục vòng lặp với i mới
                }
                else//Nếu s[i] là một toán tử thì làm
                {
                    string soHang1 = (string)myStack.Peak();//Lấy số hạng thứ 1 trong ngăn xếp từ trên xuống 
                    myStack.Pop();//Hủy bỏ số hạng đầu tiên
                    string soHang2 = (string)myStack.Peak();//Lấy số hạng thứ 2 trong ngăn xếp 
                    myStack.Pop();//Hủy bỏ số hạng thứ 2 trong ngăn xếp
                    myStack.Push("(" + soHang2 + s[i] +
                        soHang1 + ")");//Cho biểu thức số hạng vào ngăn xếp
                }

                result = (string)myStack.Peak();//Sau khi xử lý bên trên ta được một biểu thức kết quả trong ngăn xếp ....Bây giờ ra gán kết quả đó cho result
            }
        }
        //Hàm tính giá trị của biểu thức
        private double TinhGiaTriBieuThuc(string result)
        {
            STACK<double> myStack = new STACK<double>();//Khởi tạo ngăn xếp 
            int i;
            for (i = 0; i < result.Count(); i++)
            {
                if (result[i] == ' ')//Nếu gặp ' ' bỏ qua đến vòng lặp tiếp theo
                {
                    continue;
                }
                else if (LaSoHang(result[i]))
                {
                    double soHang = 0;
                    while (LaSoHang(result[i]))//Xử lý với số hạng lớn hơn hai bằng hai chữ số
                    {
                        soHang = soHang * 10 + (double)(result[i] - '0');//Xử lý để được một số hạng nếu số hạng đó lớn hơn hai chữ số.
                        i++;//Bước nhảy này nhầm kiểm tra phần tử tiếp theo có phải số hạng hay không
                    }
                    i--;

                    myStack.Push(soHang);//Cho phần tử vào ngăn xếp
                }
                else
                {
                    double soThu1 = (double)myStack.Pop();
                    double soThu2 = (double)myStack.Pop();
                    switch (result[i])
                    {
                        //Thực hiện tính toán tại sao là soThu2 truoc vi khi cho vao ngan xep thi so dung truoc cho vao truoc nen khi lay
                        //ra thi se lay sau vi the khi tinh toan thi so thu hai dung truoc.
                        case '+':
                            myStack.Push(soThu2 + soThu1);
                            break;
                        case '-':
                            myStack.Push(soThu2 - soThu1);
                            break;
                        case '*':
                            myStack.Push(soThu2 * soThu1);
                            break;
                        case '/':
                            myStack.Push(soThu2 / soThu1);
                            break;
                        case '^':
                            myStack.Push(Math.Pow(soThu2, soThu1));
                            break;

                    }
                }
            }

            return (double)myStack.Pop();//Trả kết quả
        }
        //Hàm kiểm tra có phải là toán hạng không
        private int LaToanHang(char c)
        {
            if (c == '^')
                return 3;
            else if (c == '*' || c == '/')
                return 2;
            else if (c == '+' || c == '-')
                return 1;
            else
                return -1;
        }
        //Kiểm tra có phải là số hạng không 
        private bool LaSoHang(char c)
        {
            return (c >= '0' && c <= '9');
        }
        private bool KiemTraDauVao(string s)
        {
            for (int i = 0; i < s.Count(); i++)
            {
                if (s[i] != '^' && s[i] != '-' && s[i] != '+'
                    && s[i] != '*' && s[i] != '/'
                    && s[i] != ' ' && s[i] != '(' && s[i] != ')'
                    && (s[i] < 47 || s[i] > 57))
                    return false;
            }
            return true;
        }
        //Hàm kiểm tra biểu thức
        private bool KiemTraBieuThuc(string s)
        {
            for (int i = 0; i < s.Count() - 3; i++)
            {
                if (LaSoHang(s[i]) && LaToanHang(s[i + 1]) > 0 && LaSoHang(s[i + 2]))
                {
                    return false;
                }
            }
            return true;
        }
        //Nhóm hàm xử lý các sự kiện nhấn menu
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            formStack.Show();
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            formStack.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult alertExit = MessageBox.Show("Bạn có muốn thoát chương trình không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (alertExit == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        //
    }
}
