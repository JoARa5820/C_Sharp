/*
using System;

class Sample1
{
    public static void Main()
    {
        Console.WriteLine("어서오세요! C#의 세계로!");
    }
}
;
*/

/*
using System;

class Sample1
{
    public static void Main()
    {
        // 화면에 문자를 출력한다
        Console.WriteLine("어서 오세요! C#으로!");
        Console.WriteLine("C#을 시작합니다!");
    }
}
*/

/*
using System.Windows.Forms;

class Sample2
{
    public static void Main()
    {
        Form fm;
        fm = new Form();

        fm.Text = "어서오세용!";

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;

class Sample3
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "어서오세요!";

        Label lb = new Label();
        lb.Width = 1500;
        lb.Text = "C#을 시작합니다!";
        lb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;
using System.Drawing;

class Sample4
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile("C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\baby_doma.bmp");
        pb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;
using System.Drawing;

class Sample1
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile("C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\baby_doma.bmp");
        pb.Top = 100;

        pb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;
using System.Drawing;

class Sample2
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Height = 400;
        fm.Width = 600;
        fm.Text = "샘플";

        PictureBox pb = new PictureBox();

        pb.Height = 5000;
        pb.Width = 5000;

        pb.Image = Image.FromFile(@"C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\baby_doma.bmp");

        //pb.Top = 100;
        //pb.Left = pb.Width;

        pb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;
using System.Drawing;

class Sample3
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";

        int w;
        w = 100;

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile(@"C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\baby_doma.bmp");
        pb.Top = w;

        pb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;
using System.Drawing;

class Sample4
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile(@"C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\baby_doma.bmp");
        pb.Top = pb.Top + 10;
        pb.Left = pb.Left + 10;

        pb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;
using System.Drawing;

class Sample5
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile(@"C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\baby_doma.bmp");
        pb.Top = (fm.Height - pb.Height) / 2;
        pb.Left = (fm.Width - pb.Width) / 2;

        pb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;
using System.Drawing;

class Sample1
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 300;
        fm.Height = 200;

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile(@"C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\baby_doma.bmp");
        pb.Left = 200;

        Label lb = new Label();
        lb.Top = pb.Bottom;
        lb.Width = 170;
        lb.Text = "자동차임.";

        if (pb.Left >= 150)
        {
            lb.Text = "자동차는 동쪽에 있음";
        }

        pb.Parent = fm;
        lb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;
using System.Drawing;

class Sample2
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 300;
        fm.Height = 200;

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile(@"C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\baby_doma.bmp");
        pb.Left = 100;

        Label lb = new Label();
        lb.Top = pb.Bottom;
        lb.Width = 170;
        lb.Text = "자동차임";

        if (pb.Left >= 150)
        {
            lb.Text = "자동차는 동쪽에 있음";
        }
        else if (pb.Left <= 20)
        {
            lb.Text = "자동차는 서쪽에 있음";
        }
        else
        {
            lb.Text = "자동차는 중앙에 있음";
        }

        pb.Parent = fm;
        lb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;
using System.Drawing;

class Sample3
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 300;
        fm.Height = 200;

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile(@"C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\baby_doma.bmp");
        pb.Left = 150;

        Label lb = new Label();
        lb.Top = pb.Bottom;
        lb.Width = 170;
        lb.Text = "자동차임";

        switch (pb.Left)
        {
            case 20:
                lb.Text = "서쪽의 주유소임";
                break;
            case 150:
                lb.Text = "동쪽의 주유소임";
                break;
            default:
                lb.Text = "주행중임";
                break;
        }

        pb.Parent = fm;
        lb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;
using System.Drawing;

class Sample4
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 300;
        fm.Height = 200;

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile(@"C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\baby_doma.bmp");
        pb.Left = 100;

        Label lb = new Label();
        lb.Top = pb.Bottom;
        lb.Width = 170;
        lb.Text = "자동차임";

        if (pb.Left >= 0 && pb.Left <= fm.Width)
        {
            lb.Text = "자동차는 화면 안에 있음";
        }
        else
        {
            lb.Text = "자동차는 화면 밖에 있음";
        }

        pb.Parent = fm;
        lb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;

class Sample5
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 300;
        fm.Height = 150;

        Label lb = new Label();
        lb.Width = fm.Width;
        lb.Height = fm.Height;

        for (int i = 0; i < 5; i++)
        {
            lb.Text += i + "호 자동차를 표시함\n";
        }

        lb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;
using System.Drawing;

class Sample6
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";

        PictureBox[] pb = new PictureBox[5];

        for (int i = 0; i < pb.Length; i++)
        {
            pb[i] = new PictureBox();
            pb[i].Image = Image.FromFile(@"C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\baby_doma.bmp");
            pb[i].Top = i * pb[i].Height;
            pb[i].Parent = fm;
        }

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;

class Sample7
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 250;
        fm.Height = 100;

        Label lb = new Label();
        lb.Width = fm.Width;
        lb.Height = fm.Height;

        string[] str = new string[3] { "연필", "지우개", "자" };

        foreach (string s in str)
        {
            lb.Text += s + "\n";
        }

        lb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;

class Sample8
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 250;
        fm.Height = 100;

        string[,] str = new string[4, 3]
        {
            {"서울","data1","1"},
            {"대전","data2","2"},
            {"대구","data3","3"},
            {"부산","data4","4"}
        };

        Label lb = new Label();
        lb.Width = fm.Width;
        lb.Height = fm.Height;

        string tmp = "";

        for (int i = 0; i < 4; i++)
        {
            tmp += "(";
            for (int j = 0; j < 3; j++)
            {
                tmp += str[i, j];

                if (j == 2)
                {
                    continue;  // else절만 존재해도 됨. continue 쓰나 안쓰나 똑같음 
                }
                else
                {
                    tmp += ",";
                }
            }
            tmp += ")\n";
        }

        lb.Text = tmp;
        lb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;

class Sample9
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 250;
        fm.Height = 100;

        string[][] str = new string[4][]
        {
            new string[]{"서울","da1","da11","data111","1"},
            new string[]{"대전","da2","da21","data211","2"},
            new string[]{"대구","da3","da31","data311","3"},
            new string[]{"부산","da4","da41","data411","4"}
        };

        Label lb = new Label();
        lb.Width = fm.Width;
        lb.Height = fm.Height;

        string tmp = "";

        for (int i = 0; i < str.Length; i++)
        {
            tmp += "(";

            for (int j = 0; j < str[i].Length; j++)
            {
                tmp += str[i][j];

                if (j != (str[i].Length - 1))
                {
                    tmp += ",";
                }
            }

            tmp += ")\n";
        }

        lb.Text = tmp;
        lb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;
using System.Drawing;

class Sample3
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 250;
        fm.Height = 100;

        Label lb = new Label();

        Car c1 = new Car();
        Car c2 = new Car();

        lb.Width = 170;
        lb.Text = Car.CountCar();

        lb.Parent = fm;

        Application.Run(fm);
    }
}
class Car
{
    public static int Count = 0;
    private Image img;
    private int top;
    private int left;

    public Car()
    {
        Count++;
        img = Image.FromFile(@"C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\baby_doma.bmp");
        top = 0;
        left = 0;
    }
    public static string CountCar()
    {
        return "자동차는 " + Count + "대 있음";
    }
    public void Move()
    {
        top = top + 10;
        left = left + 10;
    }
    public void SetImage(Image i)
    {
        img = i;
    }
    public Image GetImage()
    {
        return img;
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

/*
using System.Windows.Forms;
using System.Drawing;

class Sample4
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 300;
        fm.Height = 200;

        PictureBox[] pb = new PictureBox[2];

        for(int i = 0; i < pb.Length; i++)
        {
            pb[i] = new PictureBox();
            pb[i].Parent = fm;
        }

        Car[] c = new Car[2];

        c[0] = new Car();
        c[1] = new RacingCar();

        for(int i = 0; i < c.Length; i++)
        {
            c[i].Move();
            pb[i].Image = c[i].GetImage();
            pb[i].Top = c[i].Top;
            pb[i].Left = c[i].Left;
        }
        Application.Run(fm);
    }
}
class Car
{
    private Image img;
    protected int top;
    protected int left;

    public Car()
    {
        img = Image.FromFile(@"C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\baby_doma.bmp");
        top = 0;
        left = 0;
    }
    virtual public void Move()
    {
        top = top + 10;
        left = left + 10;
    }
    public void SetImage(Image i)
    {
        img = i;
    }
    public Image GetImage()
    {
        return img;
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
class RacingCar : Car
{
    public override void Move()
    {
        top = top + 100;
        left = left + 100;
    }
}
*/

/*
using System.Windows.Forms;
using System.Drawing;

class Sample5 : Form
{
    public static void Main()
    {
        Application.Run(new Sample5());
    }
    public Sample5()
    {
        this.Text = "샘플";
        this.Width = 400;
        this.Height = 200;
        this.BackgroundImage = Image.FromFile(@"C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\baby_doma.bmp");
    }
}
*/

/*
using System;
using System.Windows.Forms;

class Sample1 : Form
{
    private Label lb;
    public static void Main()
    {
        Application.Run(new Sample1());
    }
    public Sample1()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";

        lb.Parent = this;

        this.Click += new EventHandler(fm_Click);
    }
    public void fm_Click(Object sender, EventArgs e)
    {
        lb.Text = "안녕하세요";
    }
}
*/

/*
using System;
using System.Windows.Forms;

class Sample2 : Form
{
    private Label lb;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample2());
    }
    public Sample2()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 100;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Width = 150;

        bt = new Button();
        bt.Text = "구입";
        bt.Top = this.Top + lb.Height;
        bt.Width = lb.Width;

        bt.Parent = this;
        lb.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        lb.Text = "고맙습니다";
    }
}
*/

/*
using System;
using System.Windows.Forms;

class Sample3 : Form
{
    private Label lb;

    public static void Main()
    {
        Application.Run(new Sample3());
    }
    public Sample3()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";

        lb.Parent = this;

        this.MouseEnter += new EventHandler(fm_MouseEnter);
        this.MouseLeave += new EventHandler(fm_MouseLeave);
    }
    public void fm_MouseEnter(Object sender, EventArgs e)
    {
        lb.Text = "안녕하세요";
    }
    public void fm_MouseLeave(Object sender, EventArgs e)
    {
        lb.Text = "안녕히가세요";
    }
}
*/

/*
using System;
using System.Windows.Forms;

class Sample4 : Form
{
    private Label lb1, lb2;

    public static void Main()
    {
        Application.Run(new Sample4());
    }
    public Sample4()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 100;

        lb1 = new Label();
        lb1.Text = "방향키로 선택하세요";
        lb1.Width = this.Width;

        lb2 = new Label();
        lb2.Top = lb1.Bottom;

        lb1.Parent = this;
        lb2.Parent = this;

        this.KeyDown += new KeyEventHandler(fm_KeyDown);
    }
    public void fm_KeyDown(Object sender, KeyEventArgs e)
    {
        String str;
        if(e.KeyCode == Keys.Up)
        {
            str = "위쪽";
        }
        else if(e.KeyCode == Keys.Down)
        {
            str = "아래쪽";
        }
        else if(e.KeyCode == Keys.Right)
        {
            str = "오른쪽";
        }
        else if(e.KeyCode == Keys.Left)
        {
            str = "왼쪽";
        }
        else
        {
            str = "다른 키";
        }
        lb2.Text = str + "입니다.";
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Drawing;

class Sample8 : Form
{
    private Image img;
    private int i;

    public static void Main()
    {
        Application.Run(new Sample8());
    }

    public Sample8()
    {
        this.Text = "샘플";
        this.Width = 400;
        this.Height = 300;
        this.DoubleBuffered = true;  // 더블 버퍼 이용

        img = Image.FromFile(@"C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\baby_doma.bmp");

        i = 0;

        Timer tm = new Timer();
        tm.Start();

        tm.Tick += new EventHandler(tm_Tick);
        this.Paint += new PaintEventHandler(fm_Paint);
    }

    public void tm_Tick(Object sender, EventArgs e)
    {
        if (i > img.Width + 200)
        {
            i = 0;  // 전부 그려지면 그리는 폭을 0으로 되돌림
        }
        else
        {
            i = i + 10;  // 그려지는 이미지의 폭을 크게 하기
        }

        this.Invalidate();
    }

    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        g.DrawImage(img, new Rectangle(0, 0, i, img.Height), 0, 0, i, img.Height, GraphicsUnit.Pixel);  // 지정폭만큼 그리기
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Drawing;

class Sample9 : Form
{
    private Label lb;

    public static void Main()
    {
        Application.Run(new Sample9());
    }

    public Sample9()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 100;

        Timer tm = new Timer();
        tm.Interval = 1000;  // 1초로 설정
        tm.Start();

        lb = new Label();
        lb.Font = new Font("Courier", 20, FontStyle.Regular);
        lb.Dock = DockStyle.Fill;

        lb.Parent = this;

        tm.Tick += new EventHandler(tm_Tick);
    }

    public void tm_Tick(Object sender, EventArgs e)
    {
        DateTime dt = DateTime.Now;  // DateTime 구조체의 Now 프로퍼티 : 현재 시각을 설정

        lb.Text = dt.ToLongTimeString();  // 현재 DATETIME 개체의 값을 긴 시간 문자열로 표현 : ToLongTimeString() 메서드에 의해 "시:분:초"의 형식으로 함
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Drawing;

class Sample4 : Form
{
    private Ball bl;
    private Cart ct;
    private Image img;
    private int dx, dy;
    private bool isOver;  // 게임이 종료되었는지를 판단하기 위한 isOver
    private bool isIn;  // 카트 위에서 반사했는지 판단하기 위한 isIn

    public static void Main()
    {
        Application.Run(new Sample4());
    }

    public Sample4()
    {
        this.Text = "샘플";
        this.ClientSize = new Size(600, 300);
        this.DoubleBuffered = true;

        this.FormBorderStyle = FormBorderStyle.FixedSingle;  // 폼의 크기를 변경할 수 없게 함
        this.MaximizeBox = false;  // 폼의 크기를 변경할 수 없게 함 : 오른쪽 위에 "최대화 버튼" 생김
        this.MinimizeBox = false;  // 폼의 크기를 변경할 수 없게 함 : 오른쪽 위에 "최소화 버튼" 생김

        img = Image.FromFile(@"C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\sky.png");

        isOver = false;
        isIn = false;

        bl = new Ball();

        Point blp = new Point(0, 0);  // 볼 시작점 설정 : 이 볼이 사과임
        Image bim = Image.FromFile(@"C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\apple.png");  // 볼의 이미지를 사과로 만듦

        bl.Point = blp;
        bl.Image = bim;

        dx = 10;  // 사과 움직이는 속도
        dy = 10;  // 사과 움직이는 속도

        ct = new Cart();

        Point ctp = new Point(this.ClientSize.Width / 2, this.ClientSize.Height - 55);  // 카트 시작점 위치
        Image cim = Image.FromFile(@"C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\cart.png");

        ct.Point = ctp;
        ct.Image = cim;

        Timer tm = new Timer();
        tm.Interval = 100;

        tm.Start();

        this.Paint += new PaintEventHandler(fm_Paint);
        tm.Tick += new EventHandler(tm_Tick);
        this.KeyDown += new KeyEventHandler(fm_KeyDown);
    }

    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        // 배경 그리기
        g.DrawImage(img, 0, 0, img.Width, img.Height);

        // 사과 그리기
        Point blp = bl.Point;
        Image bim = bl.Image;
        g.DrawImage(bl.Image, blp.X, blp.Y, bim.Width, bim.Height);

        // 카트 그리기
        Point ctp = ct.Point;
        Image cim = ct.Image;
        g.DrawImage(ct.Image, ctp.X, ctp.Y, cim.Width, cim.Height);

        if (isOver == true)
        {
            Font f = new Font("SansSerif", 30);
            SizeF s = g.MeasureString("Game Over", f);

            float cx = (this.ClientSize.Width - s.Width) / 2;
            float cy = (this.ClientSize.Height - s.Height) / 2;

            g.DrawString("Game Over", f, new SolidBrush(Color.Blue), cx, cy);
        }
    }

    public void tm_Tick(Object sender, EventArgs e)
    {
        Point blp = bl.Point;
        Point ctp = ct.Point;

        Image bim = bl.Image;
        Image cim = ct.Image;

        if (blp.X < 0 || blp.X > this.ClientSize.Width - bim.Width)  // 왼쪽 또는 오른쪽 벽에 닿으면 반사함
        {
            dx = -dx;
        }
        if (blp.Y < 0)  // 위의 벽에 닿으면 반사함
        {
            dy = -dy;
        }
        if ((isIn == false) && (blp.X > ctp.X - bim.Width && blp.X < ctp.X + cim.Width) && (blp.Y > ctp.Y - bim.Height && blp.Y < ctp.Y - bim.Height / 2))  // isIn이 false 그리고 카트에 닿으면 반사함
        {
            isIn = true;  // 연속해서 카트에 반사하지 않도록 isIn을 true로 함
            dy = -dy;
        }
        if (blp.Y < ctp.Y - bim.Height)
        {
            isIn = false;
        }
        if (blp.Y > this.ClientSize.Height)  // 게임 오버 시에 타이머를 정지함
        {
            isOver = true;
            Timer t = (Timer)sender;
            t.Stop();
        }

        blp.X = blp.X + dx;
        blp.Y = blp.Y + dy;

        bl.Point = blp;

        this.Invalidate();
    }

    public void fm_KeyDown(Object sender, KeyEventArgs e)
    {
        Point ctp = ct.Point;
        Image cim = ct.Image;

        if (e.KeyCode == Keys.Right)  // 오른쪽 키를 눌렀을 때의 처리
        {
            ctp.X = ctp.X + 2;
            if (ctp.X > this.ClientSize.Width - cim.Width)  // 오른쪽 벽에 닿은 채로 계속 오른쪽 키를 누르면
            {
                ctp.X = this.ClientSize.Width - cim.Width;  // 그대로 오른쪽 벽에 막혀있음
            }
        }
        else if (e.KeyCode == Keys.Left)  // 왼쪽 키를 눌렀을 때의 처리
        {
            ctp.X = ctp.X - 2;
            if (ctp.X < 0)  // 왼쪽 벽에 닿은 채로 계속 왼쪽 키를 누르면
            {
                ctp.X = 0;  // 그대로 왼쪽 벽에 막혀있음
            }
        }
        ct.Point = ctp;
        this.Invalidate();
    }
}
class Ball
{
    public Image Image;
    public Point Point;
}
class Cart
{
    public Image Image;
    public Point Point;
}
*/

/*
using System;
using System.Windows.Forms;
using System.IO;

class Sample1 : Form
{
    private Button bt;
    private Label[] lb = new Label[3];

    [STAThread]
    // STAThread 속성 : 속성은 코드에 정보를 넣는 구조로 파일 다이얼로그 박스를 사용할 때 이 지정을 해야함
    public static void Main()
    {
        Application.Run(new Sample1());
    }

    public Sample1()
    {
        this.Text = "샘플";
        this.Width = 1000;
        this.Height = 200;

        for (int i = 0; i < lb.Length; i++)
        {
            lb[i] = new Label();
            lb[i].Top = i * lb[0].Height;
            lb[i].Width = 1000;
        }

        bt = new Button();
        bt.Text = "표시";
        bt.Dock = DockStyle.Bottom;

        bt.Parent = this;

        for (int i = 0; i < lb.Length; i++)
        {
            lb[i].Parent = this;
        }

        bt.Click += new EventHandler(bt_Click);
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            FileInfo fi = new FileInfo(ofd.FileName);
            lb[0].Text = "파일명은 " + ofd.FileName + "입니다.";
            lb[1].Text = "절대 경로는 " + Path.GetFullPath(ofd.FileName) + "입니다.";
            lb[2].Text = "크기는 " + Convert.ToString(fi.Length) + "입니다.";
        }
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.IO;

class Sample2 : Form
{
    private TextBox tb;
    private Button bt1, bt2;
    private FlowLayoutPanel flp;

    [STAThread]
    public static void Main()
    {
        Application.Run(new Sample2());
    }

    public Sample2()
    {
        this.Text = "샘플";

        tb = new TextBox();
        tb.Multiline = true;
        tb.Width = this.Width;
        tb.Height = this.Height - 100;
        tb.Dock = DockStyle.Top;

        bt1 = new Button();
        bt2 = new Button();

        bt1.Text = "읽어들이기";
        bt2.Text = "저장";

        flp = new FlowLayoutPanel();
        flp.Dock = DockStyle.Bottom;

        bt1.Parent = flp;
        bt2.Parent = flp;

        flp.Parent = this;
        tb.Parent = this;

        bt1.Click += new EventHandler(bt_Click);
        bt2.Click += new EventHandler(bt_Click);
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        if (sender == bt1)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "텍스트 파일|*.txt";  // 파일 필터를 사용함

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName, System.Text.Encoding.Default);  // 스트림 작성
                tb.Text = sr.ReadToEnd();  // 문자 스트림으로부터 읽어들이기
                sr.Close();  // 스트림 닫기
            }
        }
        else if (sender == bt2)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "텍스트 파일|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);  // 스트림 작성
                sw.WriteLine(tb.Text);  // 문자 스트림에 써냄
                sw.Close();  // 스트림 닫기
            }
        }
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.IO;

class Sample3 : Form
{
    private TextBox[] tb = new TextBox[5];
    private Button bt1, bt2;
    private FlowLayoutPanel flp;

    [STAThread]
    public static void Main()
    {
        Application.Run(new Sample3());
    }

    public Sample3()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        for (int i = 0; i < tb.Length; i++)
        {
            tb[i] = new TextBox();
            tb[i].Width = 30;
            tb[i].Height = 30;
            tb[i].Top = 0;
            tb[i].Left = i * tb[i].Width;
            tb[i].Text = Convert.ToString(i);
        }

        bt1 = new Button();
        bt2 = new Button();
        bt1.Text = "읽어들이기";
        bt2.Text = "저장";

        flp = new FlowLayoutPanel();
        flp.Dock = DockStyle.Bottom;

        bt1.Parent = flp;
        bt2.Parent = flp;
        flp.Parent = this;

        for (int i = 0; i < tb.Length; i++)
        {
            tb[i].Parent = this;
        }

        bt1.Click += new EventHandler(bt_Click);
        bt2.Click += new EventHandler(bt_Click);
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        if (sender == bt1)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "바이너리 파일|*.bin";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                BinaryReader br = new BinaryReader(new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read));

                for (int i = 0; i < tb.Length; i++)
                {
                    int num = br.ReadInt32();
                    tb[i].Text = Convert.ToString(num);
                }

                br.Close();
            }
        }
        else if (sender == bt2)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "바이너리 파일|*.bin";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BinaryWriter br = new BinaryWriter(new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write));

                for (int i = 0; i < tb.Length; i++)
                {
                    br.Write(Convert.ToInt32(tb[i].Text));
                }

                br.Close();
            }
        }
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;

class Sample11 : Form
{
    private Label lb;
    private RichTextBox rt;
    private TextBox tb;
    private Button bt;
    private TableLayoutPanel tlp;

    public static void Main()
    {
        Application.Run(new Sample11());
    }

    public Sample11()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 300;

        lb = new Label();
        lb.Dock = DockStyle.Fill;

        rt = new RichTextBox();  // 색을 변경할 수 있는 리치 텍스트박스를 사용
        rt.Dock = DockStyle.Fill;

        tb = new TextBox();
        tb.Dock = DockStyle.Fill;

        bt = new Button();

        tlp = new TableLayoutPanel();
        tlp.RowCount = 3;
        tlp.ColumnCount = 2;
        tlp.Dock = DockStyle.Fill;

        lb.Text = "입력하세요.";
        tlp.SetColumnSpan(lb, 2);

        rt.Multiline = true;
        rt.Height = 100;
        tlp.SetColumnSpan(rt, 2);

        bt.Text = "검색";
        tlp.SetColumnSpan(bt, 2);

        lb.Parent = tlp;
        rt.Parent = tlp;
        tb.Parent = tlp;
        bt.Parent = tlp;

        tlp.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }
    
    public void bt_Click(Object sender, EventArgs e)
    {
        Regex rx = new Regex(tb.Text);  // 검색 문자열 지정
        Match m = null;

        for (m = rx.Match(rt.Text); m.Success; m = m.NextMatch())  // 대상 문자열에 대해 검색 시행 -> 검색이 성공하는 동안 -> 다음 검색 시행
        {
            rt.Select(m.Index, m.Length);  // Select(int start, int length) : 시작 위치와 길이를 지정해서 선택
            rt.SelectionColor = Color.Red;  // 검색이 성공하면 범위를 선택해 빨간색으로 함 : 선택되어 있는 부분의 색을 설정
        }
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

class Sample12 : Form
{
    private ListBox lbx;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample12());
    }

    public Sample12()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        string dir = @"C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\";

        string[] name = Directory.GetFiles(dir);

        lbx = new ListBox();
        lbx.Dock = DockStyle.Top;

        for (int i = 0; i < name.Length; i++)
        {
            lbx.Items.Add(name[i]);
        }

        bt = new Button();
        bt.Text = "실행";
        bt.Dock = DockStyle.Bottom;

        lbx.Parent = this;
        bt.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        string name = lbx.SelectedItem.ToString();

        if (name != null)
        {
            Process.Start(@name);  // 선택된 파일을 연관 지어진 프로그램으로 열기
        }
    }
}
*/

/*
using System.Windows.Forms;
using System.Net;

class Sample1 : Form
{
    private Label lb1, lb2;

    public static void Main()
    {
        Application.Run(new Sample1());
    }

    public Sample1()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 100;

        string hn = Dns.GetHostName();  // 실행중인 장치의 호스트명을 얻음
        IPHostEntry ih = Dns.GetHostEntry(hn);  // 인터넷 주소의 리스트 얻기

        IPAddress ia = ih.AddressList[0];  // 호스트명에는 여러 개의 주소가 연관 지어져 있는 경우가 많음 -> 여기서는 주소 리스트 중 첫 주소를 표시

        lb1 = new Label();
        lb2 = new Label();

        lb1.Width = 300;
        lb1.Top = 0;
        lb1.Text = "호스트명 : " + hn;

        lb2.Width = 300;
        lb2.Top = lb1.Bottom;
        lb2.Text = "IP 주소 : " + ia.ToString();

        lb1.Parent = this;
        lb2.Parent = this;
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Net;

class Sample2 : Form
{
    private TextBox tb;
    private Label[] lb = new Label[5];
    private Button bt;
    private TableLayoutPanel tlp;

    public static void Main()
    {
        Application.Run(new Sample2());
    }

    public Sample2()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        tb = new TextBox();
        tb.Dock = DockStyle.Fill;

        bt = new Button();
        bt.Width = this.Width;
        bt.Text = "검색";
        bt.Dock = DockStyle.Bottom;

        tlp = new TableLayoutPanel();
        tlp.Dock = DockStyle.Fill;

        for (int i = 0; i < lb.Length; i++)
        {
            lb[i] = new Label();
            lb[i].Dock = DockStyle.Fill;
        }

        tlp.RowCount = 3;
        tlp.ColumnCount = 2;

        lb[0].Text = "입력하세요";
        lb[1].Text = "호스트명 : ";
        lb[3].Text = "IP 주소 : ";

        lb[0].Parent = tlp;
        tb.Parent = tlp;

        for (int i = 1; i < lb.Length; i++)
        {
            lb[i].Parent = tlp;
        }

        bt.Parent = this;
        tlp.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(object sender, EventArgs e)
    {
        try
        {
            IPHostEntry ih = Dns.GetHostEntry(tb.Text);  // 사용자가 지정한 호스트명 얻기
            IPAddress ia = ih.AddressList[0];

            lb[2].Text = ih.HostName;
            lb[4].Text = ia.ToString();
        }
        catch
        {
            MessageBox.Show("오류가 발생했습니다.");
        }
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Net;

class Sample3 : Form
{
    private TextBox tb;
    private WebBrowser wb;
    private ToolStrip ts;
    private ToolStripButton[] tsb = new ToolStripButton[2];

    [STAThread]
    public static void Main()
    {
        Application.Run(new Sample3());
    }

    public Sample3()
    {
        this.Text = "샘플";
        this.Width = 600;
        this.Height = 400;

        tb = new TextBox();
        tb.Text = "http://";
        tb.Dock = DockStyle.Top;

        wb = new WebBrowser();
        wb.Dock = DockStyle.Fill;

        ts = new ToolStrip();
        ts.Dock = DockStyle.Top;

        for (int i = 0; i < tsb.Length; i++)
        {
            tsb[i] = new ToolStripButton();
        }

        tsb[0].Text = "Go";
        tsb[1].Text = "<-";

        tsb[0].ToolTipText = "이동";
        tsb[1].ToolTipText = "돌아간다";

        tsb[1].Enabled = false;

        for (int i = 0; i < tsb.Length; i++)
        {
            ts.Items.Add(tsb[i]);
        }

        tb.Parent = this;
        wb.Parent = this;
        ts.Parent = this;

        for (int i = 0; i < tsb.Length; i++)
        {
            tsb[i].Click += new EventHandler(bt_Click);
        }

        wb.CanGoBackChanged += new EventHandler(wb_CanGoBackChanged);
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        if (sender == tsb[0])
        {
            try
            {
                Uri uri = new Uri(tb.Text);
                wb.Url = uri;  // 지정 URL 페이지 열기
            }
            catch
            {
                MessageBox.Show("URL을 입력하세요.");
            }
        }
        else if (sender == tsb[1])
        {
            wb.GoBack();  // "돌아간다" 처리 시행
        }
    }
    public void wb_CanGoBackChanged(Object sender, EventArgs e)  // "돌아간다" 이력이 변경되면..
    {
        tsb[1].Enabled = wb.CanGoBack;  // 버튼의 유효/무효를 "돌아간다" 가능 여부와 합침
    }
}
*/

/*
// 서버의 프로그램 작성
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

class Sample4S
{
    public static string HOST = "localhost";
    public static int PORT = 10000;  // 대기하는 포트 번호 지정
    public static void Main()
    {
        IPHostEntry ih = Dns.GetHostEntry(HOST);

        TcpListener tl = new TcpListener(ih.AddressList[0], PORT);  // 서버 소켓 작성
        tl.Start();

        Console.WriteLine("대기합니다.");
        while (true)
        {
            TcpClient tc = tl.AcceptTcpClient();  // 접속 받아들이기
            StreamWriter sw = new StreamWriter(tc.GetStream());  // 출력 스트림 작성
            sw.WriteLine("이쪽은 서버입니다.");

            sw.Flush();
            sw.Close();
            tc.Close();
            break;
        }
    }
}
*/

/*
// 클라이언트의 프로그램 작성
using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

class Sample4C : Form
{
    public static string HOST = "localhost";  // 호스트명 지정
    public static int PORT = 10000;  // 포트 번호 지정

    private TextBox tb;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample4C());
    }

    public Sample4C()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 300;

        tb = new TextBox();

        tb.Multiline = true;
        tb.ScrollBars = ScrollBars.Vertical;
        tb.Height = 150;
        tb.Dock = DockStyle.Top;

        bt = new Button();
        bt.Text = "접속";
        bt.Dock = DockStyle.Bottom;

        tb.Parent = this;
        bt.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }

    public void bt_Click(Object sender, EventArgs e)  // 서버에 접속
    {
        TcpClient tc = new TcpClient(HOST, PORT);

        StreamReader sr = new StreamReader(tc.GetStream());  // 입력 스트림 작성

        String str = sr.ReadLine();
        tb.Text = str;

        sr.Close();
        tc.Close();
    }
}
*/

/*
// 스레드에 의한 프로그램 작성 : 스레드를 다루는 서버를 작성
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

class Sample5S
{
    public static string HOST = "localhost";
    public static int PORT = 10000;

    public static void Main()
    {
        IPHostEntry ih = Dns.GetHostEntry(HOST);

        TcpListener tl = new TcpListener(ih.AddressList[0], PORT);
        tl.Start();

        Console.WriteLine("대기합니다.");
        while (true)
        {
            TcpClient tc = tl.AcceptTcpClient();
            Console.WriteLine("어서오세요.");

            Client c = new Client(tc);
            Thread th = new Thread(c.run);
            th.Start();  // 클라이언트와 주고받기 하는 스레드를 실행
        }
    }
}
class Client
{
    TcpClient tc;

    public Client(TcpClient c)
    {
        tc = c;
    }

    public void run()  // 클라이언트와 주고받기 하는 스레드의 처리
    {
        StreamWriter sw = new StreamWriter(tc.GetStream());
        StreamReader sr = new StreamReader(tc.GetStream());

        while (true)
        {
            try
            {
                String str = sr.ReadLine();
                sw.WriteLine("서버 : " + str + "입니다.");
                sw.Flush();
            }
            catch
            {
                sr.Close();
                sw.Close();
                tc.Close();
                break;
            }
        }
    }
}
*/

/*
// 스레드에 의한 프로그램 작성 : 스레드를 다루는 클라이언트를 작성
using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

class Sample5C : Form
{
    public static string HOST = "localhost";
    public static int PORT = 10000;

    private TextBox tb1, tb2;
    private Button bt;

    private TcpClient tc;
    private StreamReader sr;
    private StreamWriter sw;

    public static void Main()
    {
        Application.Run(new Sample5C());
    }

    public Sample5C()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 300;

        tb1 = new TextBox();
        tb2 = new TextBox();

        tb1.Height = 150;
        tb1.Dock = DockStyle.Top;

        tb2.Multiline = true;
        tb2.ScrollBars = ScrollBars.Vertical;
        tb2.Height = 150;
        tb2.Width = this.Width;
        tb2.Top = tb1.Bottom;

        bt = new Button();

        bt.Text = "송신";
        bt.Dock = DockStyle.Bottom;

        tb1.Parent = this;
        tb2.Parent = this;
        bt.Parent = this;

        Thread th = new Thread(this.run);
        th.Start();  // 서버와 주고받기 하는 스레드를 실행함

        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        String str = tb1.Text;  // 버튼을 눌렀을 때 서버에 문자열을 송신
        sw.WriteLine(str);
        tb2.AppendText(str + "\n");
        sw.Flush();
        tb1.Clear();
    }
    public void run()  // 서버와 주고받기 하는 스레드의 처리
    {
        tc = new TcpClient(HOST, PORT);
        sr = new StreamReader(tc.GetStream());
        sw = new StreamWriter(tc.GetStream());

        while (true)
        {
            try
            {
                String str = sr.ReadLine();  // 서버로부터의 문자열을 계속해서 읽어들이는 처리
                tb2.Invoke((MethodInvoker)delegate { tb2.AppendText(str + "\n");  // 컨트롤의 스레드 상에서 조작이 이뤄지도록 함
                });
            }
            catch
            {
                sr.Close();
                sw.Close();
                tc.Close();
                break;
            }
        }
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections;

class Sample1 : Form
{
    private ListBox lbx;

    public static void Main()
    {
        Application.Run(new Sample1());
    }

    public Sample1()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        lbx = new ListBox();
        lbx.Dock = DockStyle.Fill;

        var 차량표 = new[]
        {
            new{번호 = 2, 이름 = "승용차"},
            new{번호 = 3, 이름 = "오픈카"},
            new{번호 = 4, 이름 = "트럭"},
        };

        IEnumerable qry = from K in 차량표
                          select new { K.이름, K.번호 };

        foreach (var tmp in qry)
        {
            lbx.Items.Add(tmp);
        }

        lbx.Parent = this;
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections;

class Sample2 : Form
{
    private ListBox lbx;

    public static void Main()
    {
        Application.Run(new Sample2());
    }

    public Sample2()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        lbx = new ListBox();
        lbx.Dock = DockStyle.Fill;

        var 차량표 = new[]
        {
            new{ 번호 = 2, 이름 = "승용차"},
            new{ 번호 = 3, 이름 = "오픈카"},
            new{ 번호 = 4, 이름 = "트럭"},
        };

        IEnumerable qry = from K in 차량표
                          where K.번호 <= 3
                          select new { K.이름, K.번호 };

        foreach (var tmp in qry)
        {
            lbx.Items.Add(tmp);
        }

        lbx.Parent = this;
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections;

class Sample3 : Form
{
    private ListBox lbx;

    public static void Main()
    {
        Application.Run(new Sample3());
    }

    public Sample3()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        lbx = new ListBox();
        lbx.Dock = DockStyle.Fill;

        var 차량표 = new[]
        {
            new{ 번호 = 2, 이름 = "승용차"},
            new{ 번호 = 3, 이름 = "오픈카"},
            new{ 번호 = 4, 이름 = "트럭"},
        };

        IEnumerable qry = from K in 차량표
                          where K.번호 <= 3
                          orderby K.번호 descending
                          select new { K.이름, K.번호 };

        foreach (var tmp in qry)
        {
            lbx.Items.Add(tmp);
        }

        lbx.Parent = this;
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Collections;

class Sample4 : Form
{
    private ListBox lbx;

    public static void Main()
    {
        Application.Run(new Sample4());
    }

    public Sample4()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        lbx = new ListBox();
        lbx.Dock = DockStyle.Fill;

        XDocument doc = XDocument.Load("C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\Sample_XML.xml");

        IEnumerable qry = from K in doc.Descendants("car")
                          select K;

        foreach (var tmp in qry)
        {
            lbx.Items.Add(tmp);
        }

        lbx.Parent = this;
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Collections;

class Sample5 : Form
{
    private ListBox lbx;

    public static void Main()
    {
        Application.Run(new Sample5());
    }

    public Sample5()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        lbx = new ListBox();
        lbx.Dock = DockStyle.Fill;

        XDocument doc = XDocument.Load("C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\Sample_XML.xml");

        IEnumerable qry = from K in doc.Descendants("car")
                          where (string)K.Attribute("country") == "한국"
                          select K;

        foreach (var tmp in qry)
        {
            lbx.Items.Add(tmp);
        }

        lbx.Parent = this;
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Collections;

class Sample6 : Form
{
    private ListBox lbx;

    public static void Main()
    {
        Application.Run(new Sample6());
    }

    public Sample6()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        lbx = new ListBox();
        lbx.Dock = DockStyle.Fill;

        XDocument doc = XDocument.Load("C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\Sample_XML.xml");

        IEnumerable qry = from K in doc.Descendants("car")
                          where (int)K.Attribute("id") >= 1005
                          select K.Element("name").Value;

        foreach (var tmp in qry)
        {
            lbx.Items.Add(tmp);
        }

        lbx.Parent = this;
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Collections;

class Sample7 : Form
{
    private ListBox lbx;

    public static void Main()
    {
        Application.Run(new Sample7());
    }

    public Sample7()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        lbx = new ListBox();
        lbx.Dock = DockStyle.Fill;

        XDocument doc = XDocument.Load("C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\Sample_XML.xml");

        IEnumerable qry = from K in doc.Descendants("car")
                          orderby (int)K.Attribute("id")
                          select K.Element("name").Value;

        foreach (var tmp in qry)
        {
            lbx.Items.Add(tmp);
        }

        lbx.Parent = this;
    }
}
*/

/*
using System;
using System.Windows.Forms;

class Sample1 : Form
{
    private Label lb;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample1());
    }

    public Sample1()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 100;

        lb = new Label();
        lb.Text = "어서오세요.";
        lb.Width = 150;

        bt = new Button();
        bt.Text = "구입";
        bt.Top = this.Top + lb.Height;
        bt.Width = lb.Width;

        lb.Parent = this;
        bt.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        bt.Text = "감사합니다.";
    }
}
*/

/*
using System;
using System.Windows.Forms;

class Sample2 : Form
{
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample2());
    }

    public Sample2()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 100;

        bt = new Button();
        bt.Text = "어서오세요";
        bt.Width = 100;

        bt.Parent = this;

        bt.MouseEnter += new EventHandler(bt_MouseEnter);
        bt.MouseLeave += new EventHandler(bt_MouseLeave);
    }

    public void bt_MouseEnter(Object sender, EventArgs e)
    {
        bt.Text = "안녕하세요.";
    }

    public void bt_MouseLeave(Object sender, EventArgs e)
    {
        bt.Text = "안녕히가세요.";
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Drawing;

class Sample1 : Form
{
    private Label lb;
    private RadioButton rb1, rb2, rb3;
    private GroupBox gb;

    public static void Main()
    {
        Application.Run(new Sample1());
    }

    public Sample1()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Dock = DockStyle.Top;

        rb1 = new RadioButton();
        rb2 = new RadioButton();
        rb3 = new RadioButton();

        rb1.Text = "노란색";
        rb2.Text = "빨간색";
        rb3.Text = "파란색";
        rb1.Checked = true;

        rb1.Dock = DockStyle.Bottom;
        rb2.Dock = DockStyle.Bottom;
        rb3.Dock = DockStyle.Bottom;

        gb = new GroupBox();
        gb.Text = "종류";
        gb.Dock = DockStyle.Bottom;

        rb1.Parent = gb;
        rb2.Parent = gb;
        rb3.Parent = gb;

        lb.Parent = this;
        gb.Parent = this;

        rb1.Click += new EventHandler(rb_Click);
        rb2.Click += new EventHandler(rb_Click);
        rb3.Click += new EventHandler(rb_Click);
    }

    public void rb_Click(Object sender, EventArgs e)
    {
        RadioButton tmp = (RadioButton)sender;

        if (tmp == rb1)
        {
            lb.BackColor = Color.Yellow;
        }
        else if (tmp == rb2)
        {
            lb.BackColor = Color.Red;
        }
        else if (tmp == rb3)
        {
            lb.BackColor = Color.Blue;
        }
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Drawing;

class Sample2 : Form
{
    private Label lb;
    private RadioButton rb1, rb2, rb3;
    private GroupBox gb;

    public static void Main()
    {
        Application.Run(new Sample2());
    }

    public Sample2()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        lb = new Label();
        lb.Text = "Hello";
        lb.Dock = DockStyle.Top;

        rb1 = new RadioButton();
        rb2 = new RadioButton();
        rb3 = new RadioButton();

        rb1.Text = "보통";
        rb2.Text = "볼드체";
        rb3.Text = "이탤릭체";

        rb1.Dock = DockStyle.Bottom;
        rb2.Dock = DockStyle.Bottom;
        rb3.Dock = DockStyle.Bottom;

        rb1.Checked = true;

        gb = new GroupBox();
        gb.Text = "종류";
        gb.Dock = DockStyle.Bottom;

        rb1.Parent = gb;
        rb2.Parent = gb;
        rb3.Parent = gb;

        lb.Parent = this;
        gb.Parent = this;

        rb1.Click += new EventHandler(rb_Click);
        rb2.Click += new EventHandler(rb_Click);
        rb3.Click += new EventHandler(rb_Click);
    }

    public void rb_Click(Object sender, EventArgs e)
    {
        RadioButton tmp = (RadioButton)sender;

        if (tmp == rb1)
        {
            lb.Font = new Font("Arial", 16, FontStyle.Regular);
        }
        else if (tmp == rb2)
        {
            lb.Font = new Font("Arial", 16, FontStyle.Bold);
        }
        else if (tmp == rb3)
        {
            lb.Font = new Font("Arial", 16, FontStyle.Italic);
        }
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Drawing;

class Sample1 : Form
{
    private int[] data;
    
    public static void Main()
    {
        Application.Run(new Sample1());
    }

    public Sample1()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        data = new int[] { 100, 30, 50, 60, 70 };

        this.Paint += new PaintEventHandler(fm_Paint);
    }

    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        for (int i = 0; i < data.Length; i++)
        {
            SolidBrush br = new SolidBrush(Color.Blue);

            g.FillRectangle(br, i * 30, 150 - data[i], 20, data[i]);
        }
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

class Sample2 : Form
{
    private Image img;
    private int i;

    public static void Main()
    {
        Application.Run(new Sample2());
    }

    public Sample2()
    {
        img = Image.FromFile("C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\baby_doma.bmp");

        this.Text = "샘플";
        this.ClientSize = new Size(400, 300);
        this.BackColor = Color.Black;
        this.DoubleBuffered = true;

        i = 0;

        Timer tm = new Timer();
        tm.Start();

        this.Paint += new PaintEventHandler(fm_Paint);
        tm.Tick += new EventHandler(tm_Tick);
    }

    public void tm_Tick(Object sender, EventArgs e)
    {
        if (i == 400)
        {
            Timer tm = (Timer)sender;
            tm.Stop();
        }
        else
        {
            i = i + 10;
        }

        this.Invalidate();
    }

    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        GraphicsPath gp = new GraphicsPath();

        gp.AddEllipse(new Rectangle(0, 0, i, (int)i * 3 / 4));
        Region rg = new Region(gp);
        g.Clip = rg;

        g.DrawImage(img, 0, 0, 400, 300);
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Drawing;

class Sample1 : Form
{
    private int t;

    public static void Main()
    {
        Application.Run(new Sample1());
    }

    public Sample1()
    {
        this.Text = "샘플";
        this.ClientSize = new Size(200, 300);
        this.DoubleBuffered = true;

        t = 0;

        Timer tm = new Timer();
        tm.Interval = 100;
        tm.Start();

        this.Paint += new PaintEventHandler(fm_Paint);
        tm.Tick += new EventHandler(tm_Tick);
    }

    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        int w = this.ClientSize.Width;
        int h = this.ClientSize.Height;

        g.FillRectangle(new SolidBrush(Color.DarkOrchid), 0, 0, w, h);
        g.FillRectangle(new SolidBrush(Color.DeepPink), 0, 0, w, h - (float)0.5 * t);

        string time = t / 10 + ":" + "0" + t % 10;

        Font f = new Font("Courier", 20);
        SizeF ts = g.MeasureString(time, f);

        float tx = (w - ts.Width) / 2;
        float ty = (h - ts.Height) / 2;

        g.DrawString(time, f, new SolidBrush(Color.Black), tx, ty);
    }

    public void tm_Tick(Object sender, EventArgs e)
    {
        t = t + 1;

        if (t > 600)
        {
            t = 0;
        }

        this.Invalidate();
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Drawing;

class Sample2 : Form
{
    private Ball bl;
    private Image img;
    private int dx, dy;
    private int t;

    public static void Main()
    {
        Application.Run(new Sample2());
    }

    public Sample2()
    {
        this.Text = "샘플";
        this.ClientSize = new Size(600, 300);
        this.DoubleBuffered = true;

        img = Image.FromFile("C:\\Users\\82109\\Desktop\\C_Sharp\\Project\\Project\\sky.png");
        bl = new Ball();

        Point p = new Point(0, 300);
        Color c = Color.White;

        dx = 0;
        dy = 0;
        t = 0;

        bl.Point = p;
        bl.Color = c;

        Timer tm = new Timer();
        tm.Interval = 100;
        tm.Start();

        this.Paint += new PaintEventHandler(fm_Paint);
        tm.Tick += new EventHandler(tm_Tick);
    }

    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        g.DrawImage(img, 0, 0, img.Width, img.Height);

        Point p = bl.Point;
        Color c = bl.Color;
        SolidBrush br = new SolidBrush(c);

        g.FillEllipse(br, p.X, p.Y, 10, 10);
    }

    public void tm_Tick(Object sender, EventArgs e)
    {
        Point p = bl.Point;

        t++;

        if (p.X > this.ClientSize.Width)
        {
            dx = 0;
            dy = 0;
            t = 0;
            p.X = 0;
            p.Y = 300;
        }

        dx = (int)(90 * Math.Cos(Math.PI / 4));
        dy = (int)(90 * Math.Sin(Math.PI / 4) - 9.8 * t);

        p.X = p.X + dx;
        p.Y = p.Y - dy;

        bl.Point = p;
        this.Invalidate();
    }
}
class Ball
{
    public Color Color;
    public Point Point;
}
*/

/*
using System;
using System.Windows.Forms;
using System.IO;

class Sample1 : Form
{
    private Button bt;
    private ListBox lbx;

    [STAThread]
    public static void Main()
    {
        Application.Run(new Sample1());
    }

    public Sample1()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        lbx = new ListBox();
        lbx.Dock = DockStyle.Fill;

        bt = new Button();
        bt.Text = "선택";
        bt.Dock = DockStyle.Bottom;

        lbx.Parent = this;
        bt.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        if (fbd.ShowDialog() == DialogResult.OK)
        {
            lbx.Items.Clear();
            string[] fnlist = Directory.GetFiles(fbd.SelectedPath);

            foreach (string fn in fnlist)
            {
                lbx.Items.Add(fn);
            }
        }
    }
}
*/

/*
using System.Windows.Forms;
using System.IO;

class Sample2 : Form
{
    private TreeView tv;

    public static void Main()
    {
        Application.Run(new Sample2());
    }

    public Sample2()
    {
        this.Text = "샘플";

        tv = new TreeView();
        tv.Dock = DockStyle.Fill;

        string dir = Directory.GetCurrentDirectory();

        TreeNode treeroot = new TreeNode();
        treeroot.Text = Path.GetFileName(dir);
        tv.Nodes.Add(treeroot);

        walk(dir, treeroot);

        tv.Parent = this;
    }

    public static void walk(string d, TreeNode tn)
    {
        string[] dirlist = Directory.GetDirectories(d);
        foreach (string dn in dirlist)
        {
            TreeNode n = new TreeNode();
            tn.Nodes.Add(n);
            walk(dn, n);
            n.Text = Path.GetFileName(dn);
        }

        string[] fnlist = Directory.GetFiles(d);
        foreach (string fn in fnlist)
        {
            TreeNode n = new TreeNode();
            tn.Nodes.Add(n);
            n.Text = Path.GetFileName(fn);
        }
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

class Sample1 : Form
{
    private TextBox tb;
    private Label[] lb = new Label[5];
    private Button bt;
    private TableLayoutPanel tlp;

    public static void Main()
    {
        Application.Run(new Sample1());
    }

    public Sample1()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        tb = new TextBox();
        tb.Dock = DockStyle.Fill;

        bt = new Button();
        bt.Width = this.Width;
        bt.Text = "검색";
        bt.Dock = DockStyle.Bottom;

        tlp = new TableLayoutPanel();
        tlp.Dock = DockStyle.Fill;

        for (int i = 0; i < lb.Length; i++)
        {
            lb[i] = new Label();
            lb[i].Dock = DockStyle.Fill;
        }

        tlp.RowCount = 3;
        tlp.ColumnCount = 2;

        lb[0].Text = "입력하세요.";
        lb[1].Text = "호스트명 : ";
        lb[3].Text = "IP 주소 : ";

        lb[0].Parent = tlp;
        tb.Parent = tlp;
        
        for (int i = 1; i < lb.Length; i++)
        {
            lb[i].Parent = tlp;
        }

        bt.Parent = this;
        tlp.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        try
        {
            IPHostEntry ih = Dns.GetHostEntry(tb.Text);
            IPAddress ia = ih.AddressList[0];

            lb[2].Text = ih.HostName;
            lb[4].Text = ia.ToString();
        }
        catch(SocketException se)
        {
            MessageBox.Show("호스트를 찾을 수 없었습니다.");
        }
        catch
        {
            MessageBox.Show("오류가 발생했습니다.");
        }
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Net;

class Sample2 : Form
{
    private TextBox tb;
    private WebBrowser wb;
    private ToolStrip ts;
    private ToolStripButton[] tsb = new ToolStripButton[4];

    [STAThread]
    public static void Main()
    {
        Application.Run(new Sample2());
    }

    public Sample2()
    {
        this.Text = "샘플";
        this.Width = 600;
        this.Height = 400;

        tb = new TextBox();
        tb.Text = "http://";
        tb.Dock = DockStyle.Top;

        wb = new WebBrowser();
        wb.Dock = DockStyle.Fill;

        ts = new ToolStrip();
        ts.Dock = DockStyle.Fill;

        for (int i = 0; i < tsb.Length; i++)
        {
            tsb[i] = new ToolStripButton();
        }

        tsb[0].Text = "GO";
        tsb[1].Text = "<-";
        tsb[2].Text = "->";
        tsb[3].Text = "Home";

        tsb[0].ToolTipText = "이동";
        tsb[1].ToolTipText = "돌아간다";
        tsb[2].ToolTipText = "진행한다";
        tsb[3].ToolTipText = "Home";

        tsb[1].Enabled = false;
        tsb[2].Enabled = false;

        for (int i = 0; i < tsb.Length; i++)
        {
            ts.Items.Add(tsb[i]);
        }

        tb.Parent = this;
        wb.Parent = this;
        ts.Parent = this;

        for (int i = 0; i < tsb.Length; i++)
        {
            tsb[i].Click += new EventHandler(bt_Click);
        }

        wb.CanGoBackChanged += new EventHandler(wb_CanGoBackChanged);
        wb.CanGoForwardChanged += new EventHandler(wb_CanGoForwardChanged);
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        if (sender == tsb[0])
        {
            try
            {
                Uri uri = new Uri(tb.Text);
                wb.Url = uri;
            }
            catch
            {
                MessageBox.Show("URL을 입력하세요");
            }
        }
        else if (sender == tsb[1])
        {
            wb.GoBack();
        }
        else if (sender == tsb[2])
        {
            wb.GoForward();
        }
        else if (sender == tsb[3])
        {
            wb.GoHome();
        }
    }

    public void wb_CanGoBackChanged(Object sender, EventArgs e)
    {
        tsb[1].Enabled = wb.CanGoBack;
    }

    public void wb_CanGoForwardChanged(Object sender, EventArgs e)
    {
        tsb[2].Enabled = wb.CanGoForward;
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections;

class Sample1 : Form
{
    private ListBox lbx;

    public static void Main()
    {
        Application.Run(new Sample1());
    }

    public Sample1()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        lbx = new ListBox();
        lbx.Dock = DockStyle.Fill;

        var product = new[]
        {
            new{name = "연필", price = 80},
            new{name = "지우개", price = 50},
            new{name = "자", price = 200},
            new{name = "컴퍼스", price = 300},
            new{name = "볼펜", price = 100},
        };

        IEnumerable qry = from p in product
                          select new { p.name, p.price };

        foreach (var tmp in qry)
        {
            lbx.Items.Add(tmp);
        }

        lbx.Parent = this;
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections;

class Sample2 : Form
{
    private ListBox lbx;

    public static void Main()
    {
        Application.Run(new Sample2());
    }

    public Sample2()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        lbx = new ListBox();
        lbx.Dock = DockStyle.Fill;

        var product = new[]
        {
            new { name = "연필", price = 80 },
            new { name = "지우개", price = 50 },
            new { name = "자", price = 200 },
            new { name = "컴퍼스", price = 300 },
            new { name = "볼펜", price = 100 },
        };

        IEnumerable qry = from p in product
                          where p.price >= 200
                          select new { p.name, p.price };

        foreach (var tmp in qry)
        {
            lbx.Items.Add(tmp);
        }

        lbx.Parent = this;
    }
}
*/

/*
using System.Windows.Forms;
using System.Drawing;

class Sample4
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile(@"C:\\Users\\arajo\\Desktop\\C_SHARP\\Practice\\Practice\\doma.png");
        pb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
using System.Windows.Forms;
using System.Drawing;

class Sample1
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 1000;
        fm.Height = 1000;

        PictureBox pb = new PictureBox();
        pb.Width = fm.Width;
        pb.Height = fm.Height;

        Car c = new Car();
        c.Move();
        c.Move();

        pb.Image = c.img;
        pb.Top = c.top;
        pb.Left = c.left;

        pb.Parent = fm;

        Application.Run(fm);
    }
}
class Car
{
    public Image img;
    public int top;
    public int left;
    public Car()
    {
        img = Image.FromFile(@"C:\\Users\\arajo\\Desktop\\C_SHARP\\Practice\\Practice\\doma.png");
        top = 0;
        left = 0;
    }
    public void Move()
    {
        top = top + 10;
        left = left + 10;
    }
}
*/

/*
using System;
using System.Windows.Forms;

class Sample1 : Form
{
    private Button[] bt = new Button[6];
    private FlowLayoutPanel flp;

    public static void Main()
    {
        Application.Run(new Sample1());
    }
    public Sample1()
    {
        this.Text = "샘플";
        this.Width = 600;
        this.Height = 100;

        flp = new FlowLayoutPanel();
        flp.Dock = DockStyle.Fill;

        for(int i = 0; i < bt.Length; i++)
        {
            bt[i] = new Button();
            bt[i].Text = Convert.ToString(i);
            bt[i].Parent = flp;
        }
        flp.Parent = this;
    }
}
*/

/*
using System;
using System.Windows.Forms;

class Sample2 : Form
{
    private Button[] bt = new Button[6];
    private TableLayoutPanel tlp;

    public static void Main()
    {
        Application.Run(new Sample2());
    }
    public Sample2()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        tlp = new TableLayoutPanel();
        tlp.Dock = DockStyle.Fill;
        tlp.RowCount = 2;
        tlp.ColumnCount = 3;

        for (int i = 0; i < bt.Length; i++)
        {
            bt[i] = new Button();
            bt[i].Text = Convert.ToString(i);
            bt[i].Parent = tlp;
        }
        tlp.Parent = this;
    }
}
*/

/*
using System;
using System.Windows.Forms;

class Sample5 : Form
{
    private Label lb;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample5());
    }

    public Sample5()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 100;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Dock = DockStyle.Top;

        bt = new Button();
        bt.Text = "구입";
        bt.Dock = DockStyle.Bottom;

        bt.Click += new EventHandler(bt_Click);

        lb.Parent = this;
        bt.Parent = this;
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        lb.Text = "구입해주셔서 감사합니다.";
        bt.Enabled = false;
    }
}
*/

/*
using System;
using System.Windows.Forms;

class Sample6 : Form
{
    private Label lb;
    private CheckBox cb1, cb2;
    private FlowLayoutPanel flp;

    public static void Main()
    {
        Application.Run(new Sample6());
    }

    public Sample6()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Dock = DockStyle.Top;

        cb1 = new CheckBox();
        cb2 = new CheckBox();

        cb1.Text = "자동차";
        cb2.Text = "트럭";

        flp = new FlowLayoutPanel();
        flp.Dock = DockStyle.Bottom;

        cb1.Parent = flp;
        cb2.Parent = flp;

        lb.Parent = this;
        flp.Parent = this;

        cb1.CheckedChanged += new EventHandler(cb_CheckedChanged);
        cb2.CheckedChanged += new EventHandler(cb_CheckedChanged);
    }

    public void cb_CheckedChanged(Object sender, EventArgs e)
    {
        CheckBox tmp = (CheckBox)sender;

        if (tmp.Checked == true)
        {
            lb.Text = tmp.Text + "을(를) 선택했습니다.";
        }
        else if (tmp.Checked == false)
        {
            lb.Text = tmp.Text + "을(를) 해제했습니다.";
        }
    }
}
*/

/*
using System;
using System.Windows.Forms;

class Sample7 : Form
{
    private Label lb;
    private RadioButton rb1, rb2;
    private GroupBox gb;

    public static void Main()
    {
        Application.Run(new Sample7());
    }

    public Sample7()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Dock = DockStyle.Top;

        rb1 = new RadioButton();
        rb2 = new RadioButton();

        rb1.Text = "자동차";
        rb2.Text = "트럭";

        //rb1.Checked = true;

        rb1.Dock = DockStyle.Left;
        rb2.Dock = DockStyle.Right;

        gb = new GroupBox();
        gb.Text = "종류";
        gb.Dock = DockStyle.Bottom;

        rb1.Parent = gb;
        rb2.Parent = gb;

        lb.Parent = this;
        gb.Parent = this;

        rb1.Click += new EventHandler(rb_Click);
        rb2.Click += new EventHandler(rb_Click);
    }

    public void rb_Click(Object sender, EventArgs e)
    {
        RadioButton tmp = (RadioButton)sender;
        lb.Text = tmp.Text + "을(를) 선택했습니다.";
    }
}
*/

/*
using System;
using System.Windows.Forms;

class Sample11 : Form
{
    private Label lb;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample11());
    }

    public Sample11()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Dock = DockStyle.Top;

        bt = new Button();
        bt.Text = "구입";
        bt.Dock = DockStyle.Bottom;

        lb.Parent = this;
        bt.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        MessageBox.Show("구입해주셔서 고맙습니다.", "구입");
    }
}
*/

/*
using System;
using System.Windows.Forms;

class Sample13 : Form
{
    private Label lb;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample13());
    }

    public Sample13()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Dock = DockStyle.Top;

        bt = new Button();
        bt.Text = "구입";
        bt.Dock = DockStyle.Bottom;

        lb.Parent = this;
        bt.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }
    
    public void bt_Click(Object sender, EventArgs e)
    {
        SampleForm sf = new SampleForm();
        sf.ShowDialog();
    }
}
class SampleForm : Form
{
    public SampleForm()
    {
        Label lb = new Label();
        Button bt = new Button();

        this.Text = "사례";
        this.Width = 250;
        this.Height = 200;

        lb.Text = "고맙습니다.";
        lb.Dock = DockStyle.Top;

        bt.Text = "OK";
        bt.DialogResult = DialogResult.OK;
        bt.Dock = DockStyle.Bottom;

        lb.Parent = this;
        bt.Parent = this;
    }
}
*/

/*
using System;
using System.Windows.Forms;

class Sample14 : Form
{
    private Label lb;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample14());
    }

    public Sample14()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Dock = DockStyle.Top;

        bt = new Button();
        bt.Text = "구입";
        bt.Dock = DockStyle.Bottom;

        lb.Parent = this;
        bt.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        SampleForm sf = new SampleForm();
        sf.Show();
    }
}
class SampleForm : Form
{
    public SampleForm()
    {
        Label lb = new Label();
        Button bt = new Button();

        this.Text = "신규";
        this.Width = 250;
        this.Height = 200;

        lb.Text = "새로운 가게를 시작했습니다.";
        lb.Dock = DockStyle.Top;

        bt.Text = "OK";
        bt.Dock = DockStyle.Bottom;

        lb.Parent = this;
        bt.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        this.Close();
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Drawing;

class Sample1 : Form
{
    private Image im;

    public static void Main()
    {
        Application.Run(new Sample1());
    }

    public Sample1()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        im = Image.FromFile(@"C:\\Users\\arajo\\Desktop\\C_SHARP\\Practice\\Practice\\doma.png");

        this.Click += new EventHandler(fm_Click);
        this.Paint += new PaintEventHandler(fm_Paint);  // 그리기 이벤트 핸들러 등록
    }

    public void fm_Click(Object sender, EventArgs e)
    {
        im.RotateFlip(RotateFlipType.Rotate90FlipNone);  // 회전
        this.Invalidate();  // 회전 후의 상태에서 다시 그리기
    }

    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        g.DrawImage(im, 30, 50);  // 30,50은 x,y 좌표
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Drawing;

class Sample2 : Form
{
    private Image img;
    private RadioButton rb1, rb2, rb3;
    private GroupBox gb;
    private int i;

    public static void Main()
    {
        Application.Run(new Sample2());
    }

    public Sample2()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 300;

        img = Image.FromFile(@"C:\\Users\\arajo\\Desktop\\C_SHARP\\Practice\\Practice\\doma.png");

        rb1 = new RadioButton();
        rb2 = new RadioButton();
        rb3 = new RadioButton();

        rb1.Text = "보통";
        rb2.Text = "확대";
        rb3.Text = "축소";

        rb1.Dock = DockStyle.Bottom;
        rb2.Dock = DockStyle.Bottom;
        rb3.Dock = DockStyle.Bottom;

        rb1.Checked = true;

        gb = new GroupBox();
        gb.Text = "종류";
        gb.Dock = DockStyle.Bottom;

        rb1.Parent = gb;
        rb2.Parent = gb;
        rb3.Parent = gb;
        gb.Parent = this;

        rb1.Click += new EventHandler(rb_Click);
        rb2.Click += new EventHandler(rb_Click);
        rb3.Click += new EventHandler(rb_Click);
        this.Paint += new PaintEventHandler(fm_Paint);
    }

    public void rb_Click(Object sender, EventArgs e)
    {
        RadioButton tmp = (RadioButton)sender;

        if (tmp == rb1)
        {
            i = 1;
        }
        else if (tmp == rb2)
        {
            i = 2;
        }
        else if (tmp == rb3)
        {
            i = 3;
        }

        this.Invalidate();
    }

    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        if (i == 1)
        {
            g.DrawImage(img, 0, 0);
        }
        else if (i == 2)
        {
            g.DrawImage(img, 0, 0, img.Width * 2, img.Height * 2);
        }
        else if (i == 3)
        {
            g.DrawImage(img, 0, 0, img.Width / 2, img.Height / 2);
        }
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Drawing;

class Sample3 : Form
{
    private Bitmap bm1, bm2;
    private int i;

    public static void Main()
    {
        Application.Run(new Sample3());
    }

    public Sample3()
    {
        this.Text = "샘플";
        this.Width = 500;
        this.Height = 500;

        bm1 = new Bitmap(@"C:\\Users\\arajo\\Desktop\\C_SHARP\\Practice\\Practice\\pung.png");
        bm2 = new Bitmap(@"C:\\Users\\arajo\\Desktop\\C_SHARP\\Practice\\Practice\\pung.png");

        i = 0;

        this.Click += new EventHandler(fm_Click);
        this.Paint += new PaintEventHandler(fm_Paint);
    }

    public void convert()
    {
        for (int x = 0; x < bm1.Width; x++)
        {
            for (int y = 0; y < bm2.Height; y++)
            {
                Color c = bm1.GetPixel(x, y);  // 픽셀의 색 구하기
                int rgb = c.ToArgb();  // RGB 값으로 변환하기
                int a = (rgb >> 24) & 0xFF;  // RGB 값 꺼내기
                int r = (rgb >> 16) & 0xFF;
                int g = (rgb >> 8) & 0xFF;
                int b = (rgb >> 0) & 0xFF;

                switch (i)
                {
                    case 1:
                        r >>= 2; break;  // 빨간색 성분의 값을 작게 하기
                    case 2:
                        g >>= 2; break;  // 녹색 성분의 값을 작게 하기
                    case 3:
                        b >>= 2; break;  // 파란색 성분의 값을 작게 하기
                }

                rgb = (a << 24) | (r << 16) | (g << 8) | (b << 0);  // RGB 값으로 변환

                c = Color.FromArgb(rgb);

                bm2.SetPixel(x, y, c);  // 픽셀의 값을 설정
            }
        }
    }

    public void fm_Click(Object sender, EventArgs e)
    {
        i++;

        if (i >= 4)
        {
            i = 0;
        }

        convert();  // 이미지 변환 시행
        this.Invalidate();
    }

    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        g.DrawImage(bm2, 0, 0, 500, 500);
    }
}

// 순서 : 원본 -> 파랑 -> 빨강 -> 노랑 -> 원본
*/

/*
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

class Sample4 : Form
{
    private List<Point> ls;

    public static void Main()
    {
        Application.Run(new Sample4());
    }

    public Sample4()
    {
        this.Text = "샘플";

        ls = new List<Point>();

        this.MouseDown += new MouseEventHandler(fm_MouseDown);
        this.Paint += new PaintEventHandler(fm_Paint);
    }

    public void fm_MouseDown(Object sender, MouseEventArgs e)
    {
        Point p = new Point();
        p.X = e.X;
        p.Y = e.Y;
        ls.Add(p);  // 마우스 클릭하면 ls에 포인트를 추가
        this.Invalidate();
    }

    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        Pen dp = new Pen(Color.Red, 10);  // 펜의 색 : Red, 굵기 : 10

        foreach (Point p in ls)  // 마우스 클릭으로 추가된 ls의 값을 Point 형식의 p로 하나씩 가져옴
        {
            g.DrawEllipse(dp, p.X, p.Y, 40, 80);  // X,Y : 좌표 / 40,80 : 원의 크기(가로,세로)  // 펜(dp)으로 위의 ls에 저장되어있던 포인트(p)의 좌표에 그림 그리기
        }
    }
}
*/

/*
using System.Windows.Forms;
using System.Xml;

class Sample7 : Form
{
    private TreeView tv;
    
    public static void Main()
    {
        Application.Run(new Sample7());
    }

    public Sample7()
    {
        this.Text = "샘플";

        tv = new TreeView();
        tv.Dock = DockStyle.Fill;

        XmlDocument doc = new XmlDocument();
        doc.Load(@"C:\\Users\\arajo\\Desktop\\C_SHARP\\Practice\\Practice\\doma.png");

        XmlNode xmlroot = doc.DocumentElement;  // 루트 노드를 얻음
        TreeNode treeroot = new TreeNode();
        treeroot.Text = xmlroot.Name;  // 루트 노드를 트리의 루트로 함
        tv.Nodes.Add(treeroot);

        walk(xmlroot, treeroot);  // 자식의 처리를 시행

        tv.Parent = this;
    }

    public static void walk(XmlNode xn, TreeNode tn)
    {
        for (XmlNode ch = xn.FirstChild;  // 자식 노드에 대해 순서대로 처리함
             ch != null;
             ch = ch.NextSibling)  // NextSibling : 이 노드 바로 다음에 오는 노드를 가져옴
        {
            TreeNode n = new TreeNode();
            tn.Nodes.Add(n);
            walk(ch, n);  // 자식 노드에 대해 같은 처리를 반복함

            if (ch.NodeType == XmlNodeType.Element)  // 요소의 경우에..~
            {
                n.Text = ch.Name;  // 요소명을 트리 노드에 설정함
            }
            else  // 요소 이외의 경우에..~
            {
                n.Text = ch.Value;  // 값을 트리 노드에 설정함
            }
        }
    }
}
*/

/*
using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

class Sample8 : Form
{
    private PictureBox[] pb;
    private TabControl tc;
    private TabPage[] tp;

    public static void Main()
    {
        Application.Run(new Sample8());
    }

    public Sample8()
    {
        this.Text = "샘플";
        this.Width = 1000;
        this.Height = 500;

        tc = new TabControl();

        tc.Width = 1000;
        tc.Height = 500;

        string dir = "C:\\Users\\arajo\\Desktop\\C_SHARP\\Practice\\Practice\\";  // 지정 디렉토리

        string[] fls = Directory.GetFiles(dir, "*.png");  // 파일 리스트 호출
        pb = new PictureBox[fls.Length];
        tp = new TabPage[fls.Length];  // 해당 파일 수의 탭 페이지를 준비

        for (int i = 0; i < fls.Length; i++)
        {
            pb[i] = new PictureBox();
            tp[i] = new TabPage(fls[i]);

            pb[i].Width = 1000;
            pb[i].Height = 500;

            pb[i].Image = Image.FromFile(fls[i]);
            tp[i].Controls.Add(pb[i]);  // 탭 페이지에 이미지 추가
            tc.Controls.Add(tp[i]);  // 탭 컨트롤에 탭 페이지 추가
        }
        tc.Parent = this;
    }
}
*/

/*
using System;

class Sample1
{
    public static void Main()
    {
        Console.WriteLine("안녕하세요.");
        Console.WriteLine("안녕히 계세요.");
    }
}
*/

/*
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

        lb.Top = (fm.Height - lb.Height) / 2;
        lb.Left = (fm.Width - lb.Width) / 2;

        lb.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
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
        lb2.Text = "안녕히가세요";

        lb2.Left = lb1.Left + 100;

        lb1.Parent = fm;
        lb2.Parent = fm;

        Application.Run(fm);
    }
}
*/

/*
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

        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                lb.Text += i + "을(를) 표시합니다.\n";
            }
        }

        lb.Parent = fm;
        Application.Run(fm);
    }
}
*/

/*
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

        PictureBox[,] pb = new PictureBox[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                pb[i, j] = new PictureBox();
                pb[i, j].Image = Image.FromFile(@"C:\\Users\\arajo\\Desktop\\C_SHARP\\Practice\\Practice\\doma.png");
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
using System.Windows.Forms;

class Sample1
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 400;
        fm.Height = 300;

        Label lb = new Label();
        lb.Width = 400;
        lb.Height = 300;

        Ball bl = new Ball();
        bl.Move();

        lb.Text = "공의 위치는 \nTop:" + bl.Top + " / Left:" + bl.Left + " 입니다.";

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

/*
using System.Windows.Forms;
using System.Drawing;

class Sample2 : Form
{
    public static void Main()
    {
        Application.Run(new Sample2());
    }

    public Sample2()
    {
        this.Text = "샘플";
        this.Width = 400;
        this.Height = 200;

        WhiteLabel wl1 = new WhiteLabel();
        wl1.Text = "안녕하세요.";

        WhiteLabel wl2 = new WhiteLabel();
        wl2.Text = "감사합니다.";

        wl2.Left = wl1.Left + 150;

        wl1.Parent = this;
        wl2.Parent = this;
    }
}
class WhiteLabel : Label
{
    public WhiteLabel()
    {
        this.BackColor = Color.White;
    }
}
*/

