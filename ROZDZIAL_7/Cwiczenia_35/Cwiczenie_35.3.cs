using System.Windows.Forms;
using System;
using System.IO;

public class MainForm:Form
{
    public MainForm()
    { 
        StartPosition=FormStartPosition.Manual;
        Left = Convert.ToInt32(Console.ReadLine());
        Top = Convert.ToInt32(Console.ReadLine());
        Text = "Moja aplikacja";
    }

    public static void Main()
    {
        Application.Run(new MainForm());        
        Console.ReadKey();
    }
}
