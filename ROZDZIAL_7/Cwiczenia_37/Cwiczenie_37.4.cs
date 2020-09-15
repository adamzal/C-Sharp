using System;
using System.Windows.Forms;

public class MainForm : Form
{
    private ComboBox cb = new ComboBox();

    private void OnCbSelect(object sender, EventArgs ea)
    {
        string s = cb.SelectedItem.ToString();
        MessageBox.Show("Wybrano element: " + s, "Komunikat");
    }

    public MainForm()
    {
        Width = 320;
        Height = 200;
        Text = "Moja aplikacja";

        cb.Items.AddRange
        (
          new object[]
          {
        "PHP i MySQL. Dla każdego",
        "PHP5. Praktyczny kurs",
        "Java. Ćwiczenia praktyczne",
        "Java. Praktyczny kurs",
        "Java. Ćwiczenia zaawansowane",
        "SQL. Ćwiczenia praktyczne",
        "JavaScript. Ćwiczenia praktyczne",
        "JavaScript. Praktyczny kurs",
        "Tablice informatyczne. AJAX"
          }
        );

        cb.Left = (ClientSize.Width - cb.Width) / 2;
        cb.Top = 20;
        cb.DropDownWidth = 200;
        cb.SelectedIndexChanged += OnCbSelect;
        Controls.Add(cb);
    }
    public static void Main()
    {
        Application.Run(new MainForm());
    }
}
