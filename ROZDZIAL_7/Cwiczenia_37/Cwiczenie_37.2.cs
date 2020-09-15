using System;
using System.Drawing;
using System.Windows.Forms;

public class Program
{
    
    public class MainForm : Form
    {
        private Button butt1 = new Button();
        private Label lab1 = new Label();

        private void OnButtClick(object sender, EventArgs ea)
        {
            if(lab1.ForeColor==Color.Black)
            {
                lab1.ForeColor = Color.White;
            }
            else
            {
                lab1.ForeColor = Color.Black;
            }
        }
        public MainForm()
        {
            Width = 320;
            Height = 200;
            Text = "Moja aplikacja";
            lab1.Text = "To jest etykieta";
            lab1.Left = (ClientSize.Width - lab1.Width) / 2;
            lab1.Top = 30;
            lab1.TextAlign = ContentAlignment.MiddleCenter;
            butt1.Text = "Zmień";            
            butt1.Left = (ClientSize.Width -butt1.Width)/2;
            butt1.Top = (ClientSize.Height - butt1.Height) / 2;            
            butt1.Click += OnButtClick;
            Controls.Add(butt1);
            Controls.Add(lab1);
        }
    }
    public static void Main()
    {
        Application.Run(new MainForm());
    }
}
