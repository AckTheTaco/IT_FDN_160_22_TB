// File: WinForm1.cs
using System.Drawing;
using System.Windows.Forms;

class MyForm : Form
{
    public MyForm()
    {
        // Changes the caption of the application
        Text = "Hello World";

    }

    static void Main()
    {
        MyForm myForm = new MyForm();

        myForm.BackColor = Color.DimGray; // CHanges Color

        myForm.MaximizeBox = false; // Removes Maximized Button

        myForm.MinimizeBox = false; // removes Minimized Button

        // ALlows for Transparency to be modified and then setting the opacicty
        myForm.AllowTransparency = true;
        myForm.Opacity = 1f;

        //  myForm.WindowState = FormWindowState.Maximized; //Maximize on run

        myForm.StartPosition = FormStartPosition.Manual;
        myForm.Location = new Point(100, 100); // Picels counded from top left corner of the screen and draws form from top left

        // Displays the form
        Application.Run(myForm);
    }
}