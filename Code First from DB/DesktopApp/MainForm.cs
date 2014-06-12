using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Close the program/form
        }

        private void regionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Open a form as a dialog box
            ViewRegions frm = new ViewRegions();

            frm.ShowDialog(); // Execution of this method will PAUSE here until the dialog box (ViewRegions) is closed
            // resume after the dialog box is closed

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          // Set the application's startup date/time in the status bar
         // StartTimeStatus.Text = "App started on " + DateTime.Now.ToString();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

      private void LaunchOrActivate<T>() where T : Form, new()

    {
      T theForm = new T();
      if (theForm == null)

    {
      theForm = new T();
      theForm.MdiParent = this;
      theForm.WindowState = FormWindowState.Maximized;
      theForm.Show();


    }

  else {

  theForm.WindowState = FormWindowState.Maximized;
  theForm.Focus();

}
      }

  private T GetChildForm<T>() where T : Form
  {
  
    foreach (var childForm in MdiChildren)
      {
        if (childForm is T)
          {
            return (T)childForm;
          }
      }
      

return null;

}

      private void clickHereToolStripMenuItem_Click(object sender, EventArgs e)
      {
        // LaunchOrActivate<ProjectSalesForm>();
      }



    }


      // AboutApp theForm = new AboutApp();
      // theForm.Text = "Glad you asked!";
      // theForm.ShowDialog(); // we pause in this method until the 
      // AboutApp form is closed.

      // MessageBox.Show("Thanks for asking!");
      
      // ViewShippers theForm = new ViewShippers();
      // theForm.MdiParent = this;
  
      // theForm.WindowState = FromWindowState.Maximized;
      // theForm.Show();  // we do not pause here as we show the form..
      // message.show("Here's the ViewShipper's form");

    }
