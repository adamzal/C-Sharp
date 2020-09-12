using System.Windows.Forms;
using System;
using System.IO;

public class MainForm:Form
{
    public MainForm()
    {
        string plik=Console.ReadLine();
        StreamReader sr=new StreamReader(plik);            
        try
        {
            Text = sr.ReadLine();
        }
        catch(Exception)
        {
            Text = "Moja aplikacja";
        }
        try
        {
            Width = Convert.ToInt32(sr.ReadLine());
        }
        catch (Exception)
        {
            Width=350;          
        }
        try
        {
            Height=Convert.ToInt32(sr.ReadLine());
        }
        catch (Exception)
        {
            Height = 200;
        }
    }

    public static void Main()
    {
        Application.Run(new MainForm());        
        Console.ReadKey();
    }
}
