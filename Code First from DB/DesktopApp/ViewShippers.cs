using NorthwindSystem.BLL;
using NorthwindSystem.Entities;
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
  public partial class ViewShippers : Form
  {
    public ViewShippers()
    {
      InitializeComponent();
    }

    private void ViewShippers_Load(object sender, EventArgs e)
    {
      // try and catch error
      NorthwindManager manager = new NorthwindManager();
      var data = manager.ListShippers();
      // use a fake data item at the top of list the messsage
      data.Insert(0, new Shipper() { ShipperID= -1, CompanyName = "[select a shipper]"});
      cboShippers.DataSource = data;
      cboShippers.DisplayMember = "CompanyName"; // CompanyName is a property of
      // the Shipper class
      cboShippers.ValueMember = "ShipperID"; // ShipperID is the property that
      // represents the Primary key (uniquely distinguishes each shipper in the database)
     
      cboShippers.SelectedIndex = 0; // the first item in the combo box


    }

    private void btnLookupShipper_Click(object sender, EventArgs e)
    {
      // try catch block
      // todo: log exception
      // get data from form
      if (cboShippers.SelectedIndex <= 0)
      {
        MessageBox.Show("Please select a shipper before clicking [Lookup]");
      }

      else
      {
        int shipperId = Convert.ToInt32(cboShippers.SelectedValue);
        
        NorthwindManager mgr = new NorthwindManager();
        Shipper data = mgr.GetShipper(shipperId);
        
        // unpack the data
        ShipperID.Text = data.ShipperID.ToString();
        CompanyName.Text = data.CompanyName;
        Phone.Text = data.Phone;

      }

      
    }

    private void AddShipper_Click(object sender, EventArgs e)
    {
        // try - catch error
      Shipper item = new Shipper()
      {
        CompanyName = CompanyName.Text,
        Phone = Phone.Text


      };
      var mgr = new NorthwindManager();
      item.ShipperID = mgr.AddShipper(item);
      
      // give some feedback to the user..
      // update my combo box
      // my combo box has the right shipper selected
           
      cboShippers.SelectedValue = item.ShipperID;
      // display the id of the added shipper
      ShipperID.Text = item.ShipperID.ToString();


    }

    private void UpdateShipper_Click(object sender, EventArgs e)
    {
      // todo: add logging
      int shipperId;
      if (int.TryParse(ShipperID.Text, out shipperId))
      {
        var info = new Shipper()
        {
          ShipperID = shipperId,
          CompanyName = CompanyName.Text,
          Phone = Phone.Text
        };

        var mgr = new NorthwindManager();
        mgr.UpdateShipper(info);
        //PopulateShippersComboBox();
        cboShippers.SelectedValue = info.ShipperID;

      }
      else
      {
        MessageBox.Show("Please lookup a shipper before trying to update.");
      }
    
    }

    private void DeleteShippers_Click(object sender, EventArgs e)
    {
      int temp;
      if (int.TryParse(ShipperID.Text, out temp))
      {
        var data = new Shipper() { ShipperID = temp };
        var mgr = new NorthwindManager();
        mgr.DeleteShipper(data);
        //PopulateShippersComboBox();
        ShipperID.Text = " ";
        CompanyName.Text = "";
        Phone.Text = "";
      }
      else
      {
        MessageBox.Show("Please lookup a shipper before trying to delete.");

      }
    
    
    }

    private void ClearShippers_Click(object sender, EventArgs e)
    {

    }

    private void cboShippers_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void ShipperID_TextChanged(object sender, EventArgs e)
    {

    }

    private void CompanyName_TextChanged(object sender, EventArgs e)
    {

    }

    private void Phone_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
