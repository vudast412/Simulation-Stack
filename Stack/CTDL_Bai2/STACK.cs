using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CTDL_Bai2
{  
    class STACK<T>
    {
        //Properties
        public NODE<T> Top;
        //Constructor
        public STACK()
        {
            Top = null;
        }
        //Method
        public Object Peak()
        {
            if (this.IsEmptyStack())
            {
                MessageBox.Show("Stack is empty!");
                return null;
            }
            else
                return this.Top.Info;
        }
        public void Push(T x)
        {
            NODE<T> p = new NODE<T>(x);
            p.Next = Top;
            Top = p;  
        }
        public T Pop()
        {
            T x = Top.Info;
            Top = Top.Next;
            return x;
        }
        public void InitStack(STACK<T> mS)
        {
            mS.Top = null;
        }
        public string PrintStack()
        {
            string kq = "";
            for (NODE<T> p = this.Top; p != null; p = p.Next)
                kq += p.Info.ToString()+ " ";
            return kq;
        }
        public bool IsEmptyStack()
        {
            return (this.Top == null);
        }
    }
}
