namespace DesktopApp
{
  partial class ViewShippers
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.cboShippers = new System.Windows.Forms.ComboBox();
      this.btnLookupShipper = new System.Windows.Forms.Button();
      this.ShipperID = new System.Windows.Forms.TextBox();
      this.CompanyName = new System.Windows.Forms.TextBox();
      this.Phone = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.AddShipper = new System.Windows.Forms.Button();
      this.UpdateShipper = new System.Windows.Forms.Button();
      this.DeleteShippers = new System.Windows.Forms.Button();
      this.ClearShippers = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(34, 74);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Shippers";
      // 
      // cboShippers
      // 
      this.cboShippers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboShippers.FormattingEnabled = true;
      this.cboShippers.Location = new System.Drawing.Point(137, 74);
      this.cboShippers.Name = "cboShippers";
      this.cboShippers.Size = new System.Drawing.Size(132, 21);
      this.cboShippers.TabIndex = 1;
      this.cboShippers.SelectedIndexChanged += new System.EventHandler(this.cboShippers_SelectedIndexChanged);
      // 
      // btnLookupShipper
      // 
      this.btnLookupShipper.Location = new System.Drawing.Point(310, 67);
      this.btnLookupShipper.Name = "btnLookupShipper";
      this.btnLookupShipper.Size = new System.Drawing.Size(97, 32);
      this.btnLookupShipper.TabIndex = 2;
      this.btnLookupShipper.Text = "Lookup Shipper";
      this.btnLookupShipper.UseVisualStyleBackColor = true;
      this.btnLookupShipper.Click += new System.EventHandler(this.btnLookupShipper_Click);
      // 
      // ShipperID
      // 
      this.ShipperID.Location = new System.Drawing.Point(137, 131);
      this.ShipperID.Name = "ShipperID";
      this.ShipperID.Size = new System.Drawing.Size(132, 20);
      this.ShipperID.TabIndex = 3;
      this.ShipperID.TextChanged += new System.EventHandler(this.ShipperID_TextChanged);
      // 
      // CompanyName
      // 
      this.CompanyName.Location = new System.Drawing.Point(137, 192);
      this.CompanyName.Name = "CompanyName";
      this.CompanyName.Size = new System.Drawing.Size(132, 20);
      this.CompanyName.TabIndex = 4;
      this.CompanyName.TextChanged += new System.EventHandler(this.CompanyName_TextChanged);
      // 
      // Phone
      // 
      this.Phone.Location = new System.Drawing.Point(137, 249);
      this.Phone.Name = "Phone";
      this.Phone.Size = new System.Drawing.Size(132, 20);
      this.Phone.TabIndex = 5;
      this.Phone.TextChanged += new System.EventHandler(this.Phone_TextChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(31, 131);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Shipper ID";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(34, 192);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(82, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Company Name";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(34, 249);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(38, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Phone";
      // 
      // AddShipper
      // 
      this.AddShipper.Location = new System.Drawing.Point(34, 320);
      this.AddShipper.Name = "AddShipper";
      this.AddShipper.Size = new System.Drawing.Size(75, 23);
      this.AddShipper.TabIndex = 9;
      this.AddShipper.Text = "Add";
      this.AddShipper.UseVisualStyleBackColor = true;
      this.AddShipper.Click += new System.EventHandler(this.AddShipper_Click);
      // 
      // UpdateShipper
      // 
      this.UpdateShipper.Location = new System.Drawing.Point(154, 320);
      this.UpdateShipper.Name = "UpdateShipper";
      this.UpdateShipper.Size = new System.Drawing.Size(75, 23);
      this.UpdateShipper.TabIndex = 10;
      this.UpdateShipper.Text = "Update";
      this.UpdateShipper.UseVisualStyleBackColor = true;
      this.UpdateShipper.Click += new System.EventHandler(this.UpdateShipper_Click);
      // 
      // DeleteShippers
      // 
      this.DeleteShippers.Location = new System.Drawing.Point(270, 318);
      this.DeleteShippers.Name = "DeleteShippers";
      this.DeleteShippers.Size = new System.Drawing.Size(75, 23);
      this.DeleteShippers.TabIndex = 11;
      this.DeleteShippers.Text = "Delete";
      this.DeleteShippers.UseVisualStyleBackColor = true;
      this.DeleteShippers.Click += new System.EventHandler(this.DeleteShippers_Click);
      // 
      // ClearShippers
      // 
      this.ClearShippers.Location = new System.Drawing.Point(384, 317);
      this.ClearShippers.Name = "ClearShippers";
      this.ClearShippers.Size = new System.Drawing.Size(75, 23);
      this.ClearShippers.TabIndex = 12;
      this.ClearShippers.Text = "Clear";
      this.ClearShippers.UseVisualStyleBackColor = true;
      this.ClearShippers.Click += new System.EventHandler(this.ClearShippers_Click);
      // 
      // ViewShippers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(501, 402);
      this.Controls.Add(this.ClearShippers);
      this.Controls.Add(this.DeleteShippers);
      this.Controls.Add(this.UpdateShipper);
      this.Controls.Add(this.AddShipper);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.Phone);
      this.Controls.Add(this.CompanyName);
      this.Controls.Add(this.ShipperID);
      this.Controls.Add(this.btnLookupShipper);
      this.Controls.Add(this.cboShippers);
      this.Controls.Add(this.label1);
      this.Name = "ViewShippers";
      this.Text = "View/Edit Shippers";
      this.Load += new System.EventHandler(this.ViewShippers_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cboShippers;
    private System.Windows.Forms.Button btnLookupShipper;
    private System.Windows.Forms.TextBox ShipperID;
    private System.Windows.Forms.TextBox CompanyName;
    private System.Windows.Forms.TextBox Phone;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button AddShipper;
    private System.Windows.Forms.Button UpdateShipper;
    private System.Windows.Forms.Button DeleteShippers;
    private System.Windows.Forms.Button ClearShippers;
  }
}