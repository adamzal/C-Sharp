using System;
using System.Drawing;
using System.Windows.Forms;

public class Program
{
    
    public class MainForm : Form
    {
        private Button butt1 = new Button();
        private TextBox tb1 = new TextBox();

        private void OnButtClick(object sender, EventArgs ea)
        {
            Text = tb1.Text;
        }
        public MainForm()
        {
            Width = 320;
            Height = 200;
            Text = "Moja aplikacja";
            tb1.Text = "Jakiś tekst";
            tb1.Top = 30;
            tb1.Left = (ClientSize.Width - tb1.Width) / 2;
            butt1.Text = "Zmień";            
            butt1.Left = (ClientSize.Width -butt1.Width)/2;
            butt1.Top = (ClientSize.Height - butt1.Height) / 2;            
            butt1.Click += OnButtClick;
            Controls.Add(butt1);
            Controls.Add(tb1);
        }
    }
    public static void Main()
    {
        Application.Run(new MainForm());
    }
}
