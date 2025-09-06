
namespace FamilyTreeViewer
{
  partial class Editor
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
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.parentSelector1 = new System.Windows.Forms.ComboBox();
      this.lblName = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.lblParent0 = new System.Windows.Forms.Label();
      this.lblParent1 = new System.Windows.Forms.Label();
      this.parentSelector0 = new System.Windows.Forms.ComboBox();
      this.lblEvents = new System.Windows.Forms.Label();
      this.lblDate = new System.Windows.Forms.Label();
      this.lblEvent = new System.Windows.Forms.Label();
      this.txtEvent0 = new System.Windows.Forms.TextBox();
      this.txtEvent1 = new System.Windows.Forms.TextBox();
      this.txtEvent2 = new System.Windows.Forms.TextBox();
      this.txtEvent3 = new System.Windows.Forms.TextBox();
      this.txtEvent4 = new System.Windows.Forms.TextBox();
      this.txtEvent5 = new System.Windows.Forms.TextBox();
      this.txtEvent6 = new System.Windows.Forms.TextBox();
      this.txtDate0 = new System.Windows.Forms.TextBox();
      this.txtDate1 = new System.Windows.Forms.TextBox();
      this.txtDate2 = new System.Windows.Forms.TextBox();
      this.txtDate3 = new System.Windows.Forms.TextBox();
      this.txtDate4 = new System.Windows.Forms.TextBox();
      this.txtDate5 = new System.Windows.Forms.TextBox();
      this.txtDate6 = new System.Windows.Forms.TextBox();
      this.btnDeletePerson = new System.Windows.Forms.Button();
      this.btnNewPerson = new System.Windows.Forms.Button();
      this.People = new System.Windows.Forms.Label();
      this.personSelector = new System.Windows.Forms.ListBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Location = new System.Drawing.Point(0, 31);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
      this.splitContainer1.Panel1.Controls.Add(this.btnDeletePerson);
      this.splitContainer1.Panel1.Controls.Add(this.btnNewPerson);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.People);
      this.splitContainer1.Panel2.Controls.Add(this.personSelector);
      this.splitContainer1.Size = new System.Drawing.Size(800, 437);
      this.splitContainer1.SplitterDistance = 476;
      this.splitContainer1.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.08511F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.91489F));
      this.tableLayoutPanel1.Controls.Add(this.parentSelector1, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblParent0, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.lblParent1, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.parentSelector0, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.lblEvents, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.lblDate, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.lblEvent, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.txtEvent0, 1, 5);
      this.tableLayoutPanel1.Controls.Add(this.txtEvent1, 1, 6);
      this.tableLayoutPanel1.Controls.Add(this.txtEvent2, 1, 7);
      this.tableLayoutPanel1.Controls.Add(this.txtEvent3, 1, 8);
      this.tableLayoutPanel1.Controls.Add(this.txtEvent4, 1, 9);
      this.tableLayoutPanel1.Controls.Add(this.txtEvent5, 1, 10);
      this.tableLayoutPanel1.Controls.Add(this.txtEvent6, 1, 11);
      this.tableLayoutPanel1.Controls.Add(this.txtDate0, 0, 5);
      this.tableLayoutPanel1.Controls.Add(this.txtDate1, 0, 6);
      this.tableLayoutPanel1.Controls.Add(this.txtDate2, 0, 7);
      this.tableLayoutPanel1.Controls.Add(this.txtDate3, 0, 8);
      this.tableLayoutPanel1.Controls.Add(this.txtDate4, 0, 9);
      this.tableLayoutPanel1.Controls.Add(this.txtDate5, 0, 10);
      this.tableLayoutPanel1.Controls.Add(this.txtDate6, 0, 11);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 32);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 12;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 383);
      this.tableLayoutPanel1.TabIndex = 5;
      // 
      // parentSelector1
      // 
      this.parentSelector1.FormattingEnabled = true;
      this.parentSelector1.Location = new System.Drawing.Point(182, 67);
      this.parentSelector1.Name = "parentSelector1";
      this.parentSelector1.Size = new System.Drawing.Size(285, 24);
      this.parentSelector1.Sorted = true;
      this.parentSelector1.TabIndex = 4;
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Location = new System.Drawing.Point(3, 0);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(45, 17);
      this.lblName.TabIndex = 2;
      this.lblName.Text = "Name";
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(182, 3);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(285, 22);
      this.txtName.TabIndex = 2;
      this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
      // 
      // lblParent0
      // 
      this.lblParent0.AutoSize = true;
      this.lblParent0.Location = new System.Drawing.Point(3, 32);
      this.lblParent0.Name = "lblParent0";
      this.lblParent0.Size = new System.Drawing.Size(50, 17);
      this.lblParent0.TabIndex = 4;
      this.lblParent0.Text = "Parent";
      // 
      // lblParent1
      // 
      this.lblParent1.AutoSize = true;
      this.lblParent1.Location = new System.Drawing.Point(3, 64);
      this.lblParent1.Name = "lblParent1";
      this.lblParent1.Size = new System.Drawing.Size(50, 17);
      this.lblParent1.TabIndex = 5;
      this.lblParent1.Text = "Parent";
      // 
      // parentSelector0
      // 
      this.parentSelector0.FormattingEnabled = true;
      this.parentSelector0.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3"});
      this.parentSelector0.Location = new System.Drawing.Point(182, 35);
      this.parentSelector0.Name = "parentSelector0";
      this.parentSelector0.Size = new System.Drawing.Size(285, 24);
      this.parentSelector0.Sorted = true;
      this.parentSelector0.TabIndex = 3;
      // 
      // lblEvents
      // 
      this.lblEvents.AutoSize = true;
      this.lblEvents.Location = new System.Drawing.Point(3, 96);
      this.lblEvents.Name = "lblEvents";
      this.lblEvents.Size = new System.Drawing.Size(51, 17);
      this.lblEvents.TabIndex = 8;
      this.lblEvents.Text = "Events";
      // 
      // lblDate
      // 
      this.lblDate.AutoSize = true;
      this.lblDate.Location = new System.Drawing.Point(3, 128);
      this.lblDate.Name = "lblDate";
      this.lblDate.Size = new System.Drawing.Size(38, 17);
      this.lblDate.TabIndex = 9;
      this.lblDate.Text = "Date";
      // 
      // lblEvent
      // 
      this.lblEvent.AutoSize = true;
      this.lblEvent.Location = new System.Drawing.Point(182, 128);
      this.lblEvent.Name = "lblEvent";
      this.lblEvent.Size = new System.Drawing.Size(44, 17);
      this.lblEvent.TabIndex = 10;
      this.lblEvent.Text = "Event";
      // 
      // txtEvent0
      // 
      this.txtEvent0.Location = new System.Drawing.Point(182, 163);
      this.txtEvent0.Name = "txtEvent0";
      this.txtEvent0.Size = new System.Drawing.Size(285, 22);
      this.txtEvent0.TabIndex = 6;
      // 
      // txtEvent1
      // 
      this.txtEvent1.Location = new System.Drawing.Point(182, 195);
      this.txtEvent1.Name = "txtEvent1";
      this.txtEvent1.Size = new System.Drawing.Size(285, 22);
      this.txtEvent1.TabIndex = 8;
      // 
      // txtEvent2
      // 
      this.txtEvent2.Location = new System.Drawing.Point(182, 227);
      this.txtEvent2.Name = "txtEvent2";
      this.txtEvent2.Size = new System.Drawing.Size(285, 22);
      this.txtEvent2.TabIndex = 10;
      // 
      // txtEvent3
      // 
      this.txtEvent3.Location = new System.Drawing.Point(182, 259);
      this.txtEvent3.Name = "txtEvent3";
      this.txtEvent3.Size = new System.Drawing.Size(285, 22);
      this.txtEvent3.TabIndex = 12;
      // 
      // txtEvent4
      // 
      this.txtEvent4.Location = new System.Drawing.Point(182, 291);
      this.txtEvent4.Name = "txtEvent4";
      this.txtEvent4.Size = new System.Drawing.Size(285, 22);
      this.txtEvent4.TabIndex = 14;
      // 
      // txtEvent5
      // 
      this.txtEvent5.Location = new System.Drawing.Point(182, 323);
      this.txtEvent5.Name = "txtEvent5";
      this.txtEvent5.Size = new System.Drawing.Size(285, 22);
      this.txtEvent5.TabIndex = 16;
      // 
      // txtEvent6
      // 
      this.txtEvent6.Location = new System.Drawing.Point(182, 355);
      this.txtEvent6.Name = "txtEvent6";
      this.txtEvent6.Size = new System.Drawing.Size(285, 22);
      this.txtEvent6.TabIndex = 18;
      // 
      // txtDate0
      // 
      this.txtDate0.Location = new System.Drawing.Point(3, 163);
      this.txtDate0.Name = "txtDate0";
      this.txtDate0.Size = new System.Drawing.Size(173, 22);
      this.txtDate0.TabIndex = 5;
      // 
      // txtDate1
      // 
      this.txtDate1.Location = new System.Drawing.Point(3, 195);
      this.txtDate1.Name = "txtDate1";
      this.txtDate1.Size = new System.Drawing.Size(173, 22);
      this.txtDate1.TabIndex = 7;
      // 
      // txtDate2
      // 
      this.txtDate2.Location = new System.Drawing.Point(3, 227);
      this.txtDate2.Name = "txtDate2";
      this.txtDate2.Size = new System.Drawing.Size(173, 22);
      this.txtDate2.TabIndex = 9;
      // 
      // txtDate3
      // 
      this.txtDate3.Location = new System.Drawing.Point(3, 259);
      this.txtDate3.Name = "txtDate3";
      this.txtDate3.Size = new System.Drawing.Size(173, 22);
      this.txtDate3.TabIndex = 11;
      // 
      // txtDate4
      // 
      this.txtDate4.Location = new System.Drawing.Point(3, 291);
      this.txtDate4.Name = "txtDate4";
      this.txtDate4.Size = new System.Drawing.Size(173, 22);
      this.txtDate4.TabIndex = 13;
      // 
      // txtDate5
      // 
      this.txtDate5.Location = new System.Drawing.Point(3, 323);
      this.txtDate5.Name = "txtDate5";
      this.txtDate5.Size = new System.Drawing.Size(173, 22);
      this.txtDate5.TabIndex = 15;
      // 
      // txtDate6
      // 
      this.txtDate6.Location = new System.Drawing.Point(3, 355);
      this.txtDate6.Name = "txtDate6";
      this.txtDate6.Size = new System.Drawing.Size(173, 22);
      this.txtDate6.TabIndex = 17;
      // 
      // btnDeletePerson
      // 
      this.btnDeletePerson.Location = new System.Drawing.Point(159, 3);
      this.btnDeletePerson.Name = "btnDeletePerson";
      this.btnDeletePerson.Size = new System.Drawing.Size(150, 23);
      this.btnDeletePerson.TabIndex = 1;
      this.btnDeletePerson.Text = "Delete Person";
      this.btnDeletePerson.UseVisualStyleBackColor = true;
      this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
      // 
      // btnNewPerson
      // 
      this.btnNewPerson.Location = new System.Drawing.Point(3, 3);
      this.btnNewPerson.Name = "btnNewPerson";
      this.btnNewPerson.Size = new System.Drawing.Size(150, 23);
      this.btnNewPerson.TabIndex = 0;
      this.btnNewPerson.Text = "New Person";
      this.btnNewPerson.UseVisualStyleBackColor = true;
      this.btnNewPerson.Click += new System.EventHandler(this.btnNewPerson_Click);
      // 
      // People
      // 
      this.People.AutoSize = true;
      this.People.Location = new System.Drawing.Point(3, 3);
      this.People.Name = "People";
      this.People.Size = new System.Drawing.Size(52, 17);
      this.People.TabIndex = 1;
      this.People.Text = "People";
      // 
      // personSelector
      // 
      this.personSelector.FormattingEnabled = true;
      this.personSelector.ItemHeight = 16;
      this.personSelector.Location = new System.Drawing.Point(3, 38);
      this.personSelector.Name = "personSelector";
      this.personSelector.Size = new System.Drawing.Size(305, 388);
      this.personSelector.Sorted = true;
      this.personSelector.TabIndex = 0;
      this.personSelector.SelectedIndexChanged += new System.EventHandler(this.personSelector_SelectedIndexChanged);
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 28);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.newToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
      this.newToolStripMenuItem.Text = "New";
      this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
      this.openToolStripMenuItem.Text = "Open";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
      this.saveToolStripMenuItem.Text = "Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // saveAsToolStripMenuItem
      // 
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
      this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
      this.saveAsToolStripMenuItem.Text = "Save As";
      this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // Editor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 474);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.menuStrip1);
      this.Name = "Editor";
      this.Text = "Editor";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.ListBox personSelector;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.Button btnDeletePerson;
    private System.Windows.Forms.Button btnNewPerson;
    private System.Windows.Forms.Label People;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblParent0;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.ComboBox parentSelector1;
    private System.Windows.Forms.Label lblParent1;
    private System.Windows.Forms.ComboBox parentSelector0;
    private System.Windows.Forms.Label lblEvents;
    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.Label lblEvent;
    private System.Windows.Forms.TextBox txtEvent0;
    private System.Windows.Forms.TextBox txtEvent1;
    private System.Windows.Forms.TextBox txtEvent2;
    private System.Windows.Forms.TextBox txtEvent3;
    private System.Windows.Forms.TextBox txtEvent4;
    private System.Windows.Forms.TextBox txtEvent5;
    private System.Windows.Forms.TextBox txtEvent6;
    private System.Windows.Forms.TextBox txtDate0;
    private System.Windows.Forms.TextBox txtDate1;
    private System.Windows.Forms.TextBox txtDate2;
    private System.Windows.Forms.TextBox txtDate3;
    private System.Windows.Forms.TextBox txtDate4;
    private System.Windows.Forms.TextBox txtDate5;
    private System.Windows.Forms.TextBox txtDate6;
  }
}