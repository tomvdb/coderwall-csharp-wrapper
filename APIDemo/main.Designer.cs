namespace APIDemo
{
  partial class main
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
      this.userNameField = new System.Windows.Forms.Label();
      this.userNameTextBox = new System.Windows.Forms.TextBox();
      this.retrieveButton = new System.Windows.Forms.Button();
      this.nameLabel = new System.Windows.Forms.Label();
      this.locationLabel = new System.Windows.Forms.Label();
      this.endorsementsLabel = new System.Windows.Forms.Label();
      this.nameValueLabel = new System.Windows.Forms.Label();
      this.locationValueLabel = new System.Windows.Forms.Label();
      this.endorsementsValueLabel = new System.Windows.Forms.Label();
      this.listView1 = new System.Windows.Forms.ListView();
      this.SuspendLayout();
      // 
      // userNameField
      // 
      this.userNameField.AutoSize = true;
      this.userNameField.Location = new System.Drawing.Point(18, 14);
      this.userNameField.Name = "userNameField";
      this.userNameField.Size = new System.Drawing.Size(58, 13);
      this.userNameField.TabIndex = 0;
      this.userNameField.Text = "Username:";
      // 
      // userNameTextBox
      // 
      this.userNameTextBox.Location = new System.Drawing.Point(82, 11);
      this.userNameTextBox.Name = "userNameTextBox";
      this.userNameTextBox.Size = new System.Drawing.Size(240, 20);
      this.userNameTextBox.TabIndex = 1;
      // 
      // retrieveButton
      // 
      this.retrieveButton.Location = new System.Drawing.Point(328, 9);
      this.retrieveButton.Name = "retrieveButton";
      this.retrieveButton.Size = new System.Drawing.Size(75, 23);
      this.retrieveButton.TabIndex = 2;
      this.retrieveButton.Text = "Retrieve";
      this.retrieveButton.UseVisualStyleBackColor = true;
      this.retrieveButton.Click += new System.EventHandler(this.retrieveButton_Click);
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Location = new System.Drawing.Point(18, 51);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(41, 13);
      this.nameLabel.TabIndex = 3;
      this.nameLabel.Text = "Name: ";
      // 
      // locationLabel
      // 
      this.locationLabel.AutoSize = true;
      this.locationLabel.Location = new System.Drawing.Point(18, 64);
      this.locationLabel.Name = "locationLabel";
      this.locationLabel.Size = new System.Drawing.Size(51, 13);
      this.locationLabel.TabIndex = 4;
      this.locationLabel.Text = "Location:";
      // 
      // endorsementsLabel
      // 
      this.endorsementsLabel.AutoSize = true;
      this.endorsementsLabel.Location = new System.Drawing.Point(18, 77);
      this.endorsementsLabel.Name = "endorsementsLabel";
      this.endorsementsLabel.Size = new System.Drawing.Size(77, 13);
      this.endorsementsLabel.TabIndex = 5;
      this.endorsementsLabel.Text = "Endorsements:";
      // 
      // nameValueLabel
      // 
      this.nameValueLabel.AutoSize = true;
      this.nameValueLabel.Location = new System.Drawing.Point(105, 51);
      this.nameValueLabel.Name = "nameValueLabel";
      this.nameValueLabel.Size = new System.Drawing.Size(0, 13);
      this.nameValueLabel.TabIndex = 6;
      // 
      // locationValueLabel
      // 
      this.locationValueLabel.AutoSize = true;
      this.locationValueLabel.Location = new System.Drawing.Point(105, 64);
      this.locationValueLabel.Name = "locationValueLabel";
      this.locationValueLabel.Size = new System.Drawing.Size(0, 13);
      this.locationValueLabel.TabIndex = 7;
      // 
      // endorsementsValueLabel
      // 
      this.endorsementsValueLabel.AutoSize = true;
      this.endorsementsValueLabel.Location = new System.Drawing.Point(105, 77);
      this.endorsementsValueLabel.Name = "endorsementsValueLabel";
      this.endorsementsValueLabel.Size = new System.Drawing.Size(0, 13);
      this.endorsementsValueLabel.TabIndex = 8;
      // 
      // listView1
      // 
      this.listView1.Location = new System.Drawing.Point(21, 112);
      this.listView1.Name = "listView1";
      this.listView1.ShowItemToolTips = true;
      this.listView1.Size = new System.Drawing.Size(660, 289);
      this.listView1.TabIndex = 9;
      this.listView1.UseCompatibleStateImageBehavior = false;
      // 
      // main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(702, 413);
      this.Controls.Add(this.listView1);
      this.Controls.Add(this.endorsementsValueLabel);
      this.Controls.Add(this.locationValueLabel);
      this.Controls.Add(this.nameValueLabel);
      this.Controls.Add(this.endorsementsLabel);
      this.Controls.Add(this.locationLabel);
      this.Controls.Add(this.nameLabel);
      this.Controls.Add(this.retrieveButton);
      this.Controls.Add(this.userNameTextBox);
      this.Controls.Add(this.userNameField);
      this.Name = "main";
      this.Text = "Coderwall API Demo";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label userNameField;
    private System.Windows.Forms.TextBox userNameTextBox;
    private System.Windows.Forms.Button retrieveButton;
    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.Label locationLabel;
    private System.Windows.Forms.Label endorsementsLabel;
    private System.Windows.Forms.Label nameValueLabel;
    private System.Windows.Forms.Label locationValueLabel;
    private System.Windows.Forms.Label endorsementsValueLabel;
    private System.Windows.Forms.ListView listView1;
  }
}

