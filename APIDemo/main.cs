using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using coderwall_api;

namespace APIDemo
{
  public partial class main : Form
  {
    private CoderwallAPI coderWallData = null;

    public main()
    {
      InitializeComponent();
    }

    private void retrieveButton_Click(object sender, EventArgs e)
    {
      // make sure we have a username
      if (retrieveButton.Text.Length == 0)
        return;

      string userName = userNameTextBox.Text;

      // init class and retrieve info
      try
      {
        coderWallData = new CoderwallAPI(userName);
      }
      catch (coderwall_api.NotFoundException Ex)
      {
        MessageBox.Show(Ex.Message);
        return;
      }

      nameValueLabel.Text = coderWallData.Name;
      locationValueLabel.Text = coderWallData.Location;
      endorsementsValueLabel.Text = coderWallData.Endorsements.ToString();


    }
  }
}
