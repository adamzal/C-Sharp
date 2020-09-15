using System;
using System.IO;
using System.Windows.Forms;

public class MainForm : Form
{
    private TextBox tb = new TextBox();

    private void OnWrite(object sender, EventArgs ea)
    {
        try
        {
            StreamWriter sw = new StreamWriter("plik.txt");
            sw.Write(tb.Text);
            sw.Close();
        }
        catch(Exception e)
        {
            MessageBox.Show("Wystąpił błąd zapisu danych do pliku.\n" + e.Message);            
        }
    }
    private void OnRead(object sender, EventArgs ea)
    {
        try
        {
            StreamReader sw = new StreamReader("plik.txt");
            tb.Text = sw.ReadToEnd();
            sw.Close();
        }
        catch(Exception e)
        {
            MessageBox.Show("Wystąpił błąd odczytu danych z pliku.\n" + e.Message);
        }        
    }

    public MainForm()
    {
        Width = 320;
        Height = 200;
        Text = "Moja aplikacja";

        MainMenu mm = new MainMenu();
        MenuItem m1 = new MenuItem("Plik");
        MenuItem m2 = new MenuItem("Odczytaj");
        MenuItem m3 = new MenuItem("Zapisz");
        mm.MenuItems.Add(m1);
        m1.MenuItems.Add(m2);
        m1.MenuItems.Add(m3);
        Menu = mm;
        m2.Click += OnRead;
        m3.Click += OnWrite;
        tb.Multiline = true;
        tb.Width = Width -100;
        tb.Height = Height - 100;
        tb.Left = (ClientSize.Width - tb.Width) / 2;
        tb.Top = (ClientSize.Height - tb.Height) / 2;

        Controls.Add(tb);
    }
    public static void Main()
    {
        Application.Run(new MainForm());
    }
}
