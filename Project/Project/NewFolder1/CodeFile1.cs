/*
// 2-1
using System;

class Sample1
{
    public static void Main()
    {
        Console.WriteLine("안녕하세요");
        Console.WriteLine("안녕히 계세요");
    }
}
*/

/*
// 2-2
using System.Windows.Forms;

class Sample2
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";

        Label lb = new Label();
        lb.Text = "또 만납시다!";

        lb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
// 3-1
using System.Windows.Forms;

class Sample1
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";

        fm.Width = 300;
        fm.Height = 200;

        Label lb = new Label();
        lb.Text = "안녕하세요";

        lb.Top = (fm.Height - lb.Height) / 2 ;
        lb.Left = (fm.Width - lb.Width) / 2 ;

        lb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
// 3-2
using System.Windows.Forms;

class Sample2
{
    public static void Main()
    {
        Form fm = new Form();

        fm.Text = "샘플";

        fm.Width = 300;
        fm.Height = 200;

        Label lb1 = new Label();
        Label lb2 = new Label();

        lb1.Text = "안녕하세요";
        lb1.Left = 0;

        lb2.Text = "안녕히 가세요";
        lb2.Left = lb1.Left + 100;

        lb1.Parent = fm;
        lb2.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
// 4-1
using System.Windows.Forms;

class Sample1
{
    public static void Main()
    {
        Form fm = new Form();

        fm.Text = "샘플";

        fm.Width = 250;
        fm.Height = 150;

        Label lb = new Label();

        lb.Width = fm.Width;
        lb.Height = fm.Height;

        for (int num = 1; num <= 5; num++)
        {
            lb.Text += (2*num) + "을(를) 표시합니다.\n";
        }

        lb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
// 4-2
using System.Windows.Forms;
using System.Drawing;

class Sample2
{
    public static void Main()
    {
        Form fm = new Form();
        
        fm.Text = "샘플";
        fm.Width = 600;
        fm.Height = 300;

        PictureBox[,] pb = new PictureBox[5,5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                pb[i, j] = new PictureBox();
                pb[i, j].Image = Image.FromFile(@"C:\Users\82109\Desktop\C_SHAP\car_picture.jpg");

                pb[i, j].Left = pb[i, j].Width * i;
                pb[i, j].Top = pb[i, j].Height * j;
                pb[i, j].Parent = fm;
            }
        }

        Application.Run(fm);
    }
}
*/

/*
// 5-1
using System.Windows.Forms;

class Sample1
{
    public static void Main()
    {
        Form fm = new Form();

        fm.Text = "샘플";
        fm.Width = 400;
        fm.Height = 250;

        Label lb = new Label();

        Ball bl = new Ball();
        bl.Move();

        lb.Text = "공의 위치는\nTop : " + bl.Top + ", Left : " + bl.Left + "입니다.";

        lb.Parent = fm;

        Application.Run(fm);
    }
}
class Ball
{
    private int top;
    private int left;

    public Ball()
    {
        top = 0;
        left = 0;
    }
    public void Move()
    {
        top = top + 10;
        left = left + 10;
    }
    public int Top
    {
        set { top = value; }
        get { return top; }
    }
    public int Left
    {
        set { left = value; }
        get { return left; }
    }
}
*/







































