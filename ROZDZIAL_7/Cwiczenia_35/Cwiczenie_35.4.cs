using System.Windows.Forms;
using System;
using System.IO;

public class MainForm:Form
{
    public MainForm()
    {         
        Text = "Moja aplikacja";
        MainMenu mm = new MainMenu();        

        MenuItem m1 = new MenuItem("Opcja 1");        

        MenuItem m1m1 = new MenuItem("Opcja 1:1");        
        MenuItem m1m2 = new MenuItem("Opcja 1:2");       
        MenuItem m1m3 = new MenuItem("Opcja 1:3");       

        MenuItem m1m1m1 = new MenuItem("Opcja 1:1:1");       
        MenuItem m1m1m2 = new MenuItem("Opcja 1:1:2");        
        MenuItem m1m1m3 = new MenuItem("Opcja 1:1:3");        

        MenuItem m1m2m1 = new MenuItem("Opcja 1:2:1");        
        MenuItem m1m2m2 = new MenuItem("Opcja 1:2:2");        
        MenuItem m1m2m3 = new MenuItem("Opcja 1:2:3");       

        MenuItem m1m3m1 = new MenuItem("Opcja 1:3:1");        
        MenuItem m1m3m2 = new MenuItem("Opcja 1:3:2");        
        MenuItem m1m3m3 = new MenuItem("Opcja 1:3:3");        

        m1.MenuItems.Add(m1m1);
        m1.MenuItems.Add(m1m2);
        m1.MenuItems.Add(m1m3);

        m1m1.MenuItems.Add(m1m1m1);
        m1m1.MenuItems.Add(m1m1m2);
        m1m1.MenuItems.Add(m1m1m3);

        m1m2.MenuItems.Add(m1m2m1);
        m1m2.MenuItems.Add(m1m2m2);
        m1m2.MenuItems.Add(m1m2m3);

        m1m3.MenuItems.Add(m1m3m1);
        m1m3.MenuItems.Add(m1m3m2);
        m1m3.MenuItems.Add(m1m3m3);

        mm.MenuItems.Add(m1);

        Menu = mm;
    }

    public static void Main()
    {
        Application.Run(new MainForm());        
        Console.ReadKey();
    }
}
