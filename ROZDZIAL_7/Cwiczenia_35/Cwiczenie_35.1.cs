using System.Windows.Forms;
using System;

public class MainForm:Form
{
    public MainForm()
    {
        Text = "Moja aplikacja";
        Width = 320;
        Height = 100;
    }

    public static void Main()
    {
        Application.Run(new MainForm());
        Console.ReadKey();
    }
}
