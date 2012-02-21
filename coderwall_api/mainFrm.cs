using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;


namespace coderwall_api
{
  public partial class mainFrm : Form
  {
    public mainFrm()
    {
      InitializeComponent();
    }

    private void getButton_Click(object sender, EventArgs e)
    {
      // get achievements
      string userName = usernameTextBox.Text;

      CoderwallAPI CoderWallData = new CoderwallAPI(userName);

      textBox1.Text = CoderWallData.Name;
      textBox2.Text = CoderWallData.Location;
      textBox3.Text = CoderWallData.Endorsements.ToString();

      listBox1.Items.Clear();

      for (int c = 0; c < CoderWallData.BadgeCount; c++)
      {
        listBox1.Items.Add(CoderWallData.Badges[c].Name + "-" + CoderWallData.Badges[c].Description);
      }
    }
  }
}
