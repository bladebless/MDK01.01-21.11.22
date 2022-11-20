

using System.Drawing;

namespace mdk_01._01
{
    public partial class Form1 : Form
    {
        Size Screen = SystemInformation.PrimaryMonitorSize; //получаю размеры экрана и ложу их в Screen

        
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // центр
        {
            CenterToScreen(); 
        }

        private void button6_Click(object sender, EventArgs e) // правый верхний угол
        {
            Location = new Point(Screen.Width - Width, 0);
        }

        private void button2_Click(object sender, EventArgs e) //вверх
        {
            Location = new Point((Screen.Width - Width) / 2, 0);
        }

        private void button3_Click(object sender, EventArgs e) //вправо
        {
            Location = new Point(Screen.Width - Width, (Screen.Height - Height) / 2);
        }

        private void button4_Click(object sender, EventArgs e) //влево
        {
            Location = new Point(0, (Screen.Height - Height) / 2);
        }

        private void button5_Click(object sender, EventArgs e) //вниз
        {
            Location = new Point((Screen.Width - Width) / 2, Screen.Height - Height);
        }

        private void button7_Click(object sender, EventArgs e) //левый верхний угол
        {
            Location = new Point(0, 0);
        }

        private void button8_Click(object sender, EventArgs e) // левый нижний угол
        {
            Location = new Point(0, Screen.Height - Height);
        }

        private void button9_Click(object sender, EventArgs e) // правый нижний угол
        {
            Location = new Point(Screen.Width - Width, Screen.Height - Height);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            

        }

        private void button10_Click(object sender, EventArgs e) // развернуть окно
        {
            
            this.WindowState = FormWindowState.Maximized;
            

        }

        private void button11_Click(object sender, EventArgs e) // восстановить окно
        {
            
          
            this.WindowState = FormWindowState.Normal;

        }

        private void button12_Click(object sender, EventArgs e) // свернуть окно
        {
           
            this.WindowState = FormWindowState.Minimized;
            

        }

        private void button17_Click(object sender, EventArgs e)
        {

            this.Size = new Size(Width + 50, Height + 50);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Width = 2000;
            this.Height = 1196;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Width = 1920;
            this.Height = 1116;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Size = new Size(Width - 50, Height - 50);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Size = MinimumSize;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox2.Text = Screen.Width + "x" + Screen.Height;
            this.textBox3.Text = Width + "x" + Height;
            textBox4.Text = SystemInformation.VirtualScreen.Width + "x" + SystemInformation.VirtualScreen.Height;
            button17.Text = "+";
            button16.Text = "-";
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            contextMenuStrip1.Show();

        }

        private void button18_Click(object sender, EventArgs e) //запрет на изменение размера
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /*private void textBox1_TextChanged(object sender, EventArgs e) // вывод разрешения экрана
        {
            textBox1.Text = Screen.Width + "x" + Screen.Height;
        }*/

        
        /*private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            this.textBox1.Text = Screen.Width + "x" + Screen.Height;
        }*/

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void впавпаварToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening_1(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}