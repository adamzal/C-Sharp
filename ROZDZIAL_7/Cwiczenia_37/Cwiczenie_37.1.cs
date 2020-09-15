using System;
using System.Drawing;
using System.Windows.Forms;

public class Program
{
    
    public class MainForm : Form
    {
        private Button butt1 = new Button();

        private void OnButtClick(object sender, EventArgs ea)
        {
            Application.Exit();
        }
        public MainForm()
        {
            Width = 320;
            Height = 200;
            Text = "Moja aplikacja";
            butt1.Text = "Zamknij";            
            butt1.Left = (ClientSize.Width -butt1.Width)/2;
            butt1.Top = (ClientSize.Height - butt1.Height) / 2;            
            butt1.Click += OnButtClick;
            Controls.Add(butt1);
        }
    }
    public static void Main()
    {
        Application.Run(new MainForm());
    }
}
