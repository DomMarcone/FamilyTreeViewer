// Copyright (C) 2025 Dom Marcone. All rights reserved

using System.Collections.Generic;
using System.Windows.Forms;

namespace FamilyTreeViewer
{
  public partial class Editor : Form
  {
    private PeopleCollection people;
    private Person selectedPerson;
    private Viewer viewer;
    private string filename;
    private bool unsavedChanges;
    private bool pauseEvents;

    private void updatePersonSelector()
    {
      this.personSelector.Items.Clear();

      foreach(var person in people)
      {
        this.personSelector.Items.Add(person);
      }
    }

    private void refreshParentSelector(ComboBox selector)
    {
      selector.Items.Clear();

      selector.Items.Add("");

      foreach (var person in people)
      {
        selector.Items.Add(person);
      }
    }

    private void refreshParentSelectors()
    {
      this.refreshParentSelector(this.parentSelector0);
      this.refreshParentSelector(this.parentSelector1);
    }

    private void initParentSelector(ComboBox selector, int index)
    {
      refreshParentSelector(selector);

      selector.SelectedIndexChanged += (object sndr, System.EventArgs e) =>
      {
        if (this.pauseEvents) // Programmatic update
        {
          return;
        }

        if (this.selectedPerson == null)
        {
          return;
        }

        if (selector.SelectedItem is Person)
        {
          this.selectedPerson.Parents[index] = 
            ((Person)selector.SelectedItem).Id;
        } 
        else
        {
          this.selectedPerson.Parents[index] = null;
        }

        this.markUnsaved();
        this.refreshViewer();
      };
    }

    private void updateParentSelector(ComboBox selector, int index)
    {
      this.pauseEvents = true;
      
      if (this.selectedPerson == null) 
      {
        selector.SelectedItem = "";
        this.pauseEvents = false;
        return;
      }

      if (this.selectedPerson.Parents[index] == null)
      {
        selector.SelectedItem = "";
        this.pauseEvents = false;
        return;
      }

      string parnentId = this.selectedPerson.Parents[index];
      Person person = people.GetPersonById(parnentId);

      selector.SelectedItem = person;
      this.pauseEvents = false;
    }

    private void updateParentSelectors()
    {
      updateParentSelector(this.parentSelector0, 0);
      updateParentSelector(this.parentSelector1, 1);
    }

    private void updateName()
    {
      this.pauseEvents = true;
      if (this.selectedPerson == null)
      {
        this.txtName.Text = "";
        this.pauseEvents = false;
        return;
      }

      this.txtName.Text = this.selectedPerson.Name;
      this.pauseEvents = false;
    }

    private void initEvent(TextBox date, TextBox evt, int index)
    {
      System.EventHandler evtHandler = (object sender, System.EventArgs e) =>
      {
        if (this.pauseEvents) // Programmatic update
        {
          return;
        }

        if (this.selectedPerson == null)
        {
          return;
        }

        while (this.selectedPerson.Events.Count <= index)
        {
          this.selectedPerson.Events.Add(new KeyValuePair<string, string>("", ""));
        }

        this.selectedPerson.Events[index] =
          new KeyValuePair<string, string>(date.Text, evt.Text);

        this.markUnsaved();
        this.updatePersonSelector();
        this.refreshViewer();
      };

      date.TextChanged += evtHandler;
      evt.TextChanged += evtHandler;
    }

    private void updateEvent(TextBox date, TextBox evt, int index)
    {
      this.pauseEvents = true;
      if (this.selectedPerson == null)
      {
        date.Text = "";
        evt.Text = "";
        this.pauseEvents = false;
        return;
      }

      if (this.selectedPerson.Events.Count <= index)
      {
        date.Text = "";
        evt.Text = "";
        this.pauseEvents = false;
        return;
      }

      var kvp = this.selectedPerson.Events[index];

      if (!date.ContainsFocus) // TODO : double check this logic
      {
        date.Text = kvp.Key;
      }

      if (!evt.ContainsFocus) // TODO : double check this logic
      {
        evt.Text = kvp.Value;
      }
      this.pauseEvents = false;
    }

    private void updateEvents()
    {
      updateEvent(this.txtDate0, this.txtEvent0, 0);
      updateEvent(this.txtDate1, this.txtEvent1, 1);
      updateEvent(this.txtDate2, this.txtEvent2, 2);
      updateEvent(this.txtDate3, this.txtEvent3, 3);
      updateEvent(this.txtDate4, this.txtEvent4, 4);
      updateEvent(this.txtDate5, this.txtEvent5, 5);
      updateEvent(this.txtDate6, this.txtEvent6, 6);
    }

    private void refreshViewer()
    {
      if (this.viewer.IsClosed())
      {
        this.viewer = new Viewer();
      }

      this.viewer.MakeGraph(this.people, this);
    }

    public void SetSelected(Person person)
    {
      this.selectedPerson = person;

      this.lockPerson(false);

      this.updateName();
      this.updateParentSelectors();
      this.updateEvents();
    }

    private void lockPerson(bool lockPerson)
    {
      bool enabled = !lockPerson;

      this.txtName.Enabled = enabled;
      
      this.parentSelector0.Enabled = enabled;
      this.parentSelector1.Enabled = enabled;

      this.txtDate0.Enabled = enabled;
      this.txtDate1.Enabled = enabled;
      this.txtDate2.Enabled = enabled;
      this.txtDate3.Enabled = enabled;
      this.txtDate4.Enabled = enabled;
      this.txtDate5.Enabled = enabled;
      this.txtDate6.Enabled = enabled;

      this.txtEvent0.Enabled = enabled;
      this.txtEvent1.Enabled = enabled;
      this.txtEvent2.Enabled = enabled;
      this.txtEvent3.Enabled = enabled;
      this.txtEvent4.Enabled = enabled;
      this.txtEvent5.Enabled = enabled;
      this.txtEvent6.Enabled = enabled;
    }

    private void refreshComponent()
    {
      this.updatePersonSelector();
      this.updateName();
      this.updateParentSelectors();
      this.updateEvents();
      this.refreshViewer();
      this.lockPerson(true);
    }

    private void initComponent()
    {
      initParentSelector(this.parentSelector0, 0);
      initParentSelector(this.parentSelector1, 1);

      initEvent(this.txtDate0, this.txtEvent0, 0);
      initEvent(this.txtDate1, this.txtEvent1, 1);
      initEvent(this.txtDate2, this.txtEvent2, 2);
      initEvent(this.txtDate3, this.txtEvent3, 3);
      initEvent(this.txtDate4, this.txtEvent4, 4);
      initEvent(this.txtDate5, this.txtEvent5, 5);
      initEvent(this.txtDate6, this.txtEvent6, 6);
    }

    private void markSaved()
    {
      this.unsavedChanges = false;
      this.Text = this.filename ?? "Editor";
    }

    private void markUnsaved()
    {
      this.unsavedChanges = true;
      this.Text = "*" + this.filename ?? "Editor";
    }

    public Editor(string filename = null)
    {
      InitializeComponent();

      FamilyTreeViewerTheme.Apply(this);

      this.people = new PeopleCollection();
      this.selectedPerson = null;
      this.viewer = new Viewer();
      this.filename = filename;
      this.unsavedChanges = false;

      if (!string.IsNullOrEmpty(filename))
      {
        this.people.Load(filename);
      }

      refreshComponent();
      initComponent();
      markSaved();
    }

    private bool promptTo(
      string title,//  = "Save?",
      string text,//  = "Would you like to save before closing?",
      string confimText,// = "Ok",
      string cancelText// = "Don't Save"
    )
    {
      Form prompt = new Form()
      {
        Width = 300,
        Height = 150,
        FormBorderStyle = FormBorderStyle.FixedDialog,
        Text = title,
        StartPosition = FormStartPosition.CenterScreen
      };
      Label textLabel = new Label() { 
        Left = 20, 
        Top = 20, 
        Width = 260,
        Height = 50,
        Text = text };

      Button confirmation = new Button() { 
        Text = confimText, 
        Left = 40, 
        Width = 100, 
        Top = 70, 
        DialogResult = DialogResult.OK };

      Button cancellation = new Button() { 
        Text = cancelText, 
        Left = 160, 
        Width = 100, 
        Top = 70, 
        DialogResult = DialogResult.Cancel };

      confirmation.Click += (sender, e) => { prompt.Close(); };
      prompt.Controls.Add(confirmation);
      prompt.Controls.Add(cancellation);
      prompt.Controls.Add(textLabel);
      prompt.AcceptButton = confirmation;

      return prompt.ShowDialog() == DialogResult.OK;
    }

    private void openToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      if (this.unsavedChanges)
      {
        if (promptTo(
            "Save?", "Would  you like to save before opening a new tree?",
            "Save", "Don't Save"
          ))
        {
          if (this.filename == null)
          {
            saveAs();
          }
        }
      }

      OpenFileDialog dialog = new OpenFileDialog()
      {
        Filter = "Xml File of People (*.xml)|*.xml|All Files (*.*)|*.*",
        Title = "Select an Xml file of People",
        Multiselect = true,
      };

      if (dialog.ShowDialog() != DialogResult.OK)
      {
        return;
      }

      this.selectedPerson = null;
      this.people.Clear();

      if (dialog.Multiselect)
      {
        foreach (string filePath in dialog.FileNames)
        {
          this.people.Load(filePath);
        }

        if (dialog.FileNames.Length == 1)
        {
          this.filename = dialog.FileNames[0];
        }
      }
      else
      {
        this.people.Load(dialog.FileName);
        this.filename = dialog.FileName;
      }

      this.markSaved();
      this.refreshComponent();
    }

    private void personSelector_SelectedIndexChanged(object sender, System.EventArgs e)
    { 
      this.SetSelected((Person)personSelector.SelectedItem);
    }

    private void txtName_TextChanged(object sender, System.EventArgs e)
    {
      if (this.pauseEvents) // Programmatic update
      {
        return;
      }

      if (this.selectedPerson == null)
      {
        return;
      }

      this.selectedPerson.Name = this.txtName.Text;

      this.refreshParentSelectors();
      this.updatePersonSelector();

      this.markUnsaved();
    }

    private void newToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      if (this.unsavedChanges)
      {
        if (promptTo(
            "Save?", "Would  you like to save before creating a new tree?", 
            "Save", "Don't Save"
          ))
        {
          if (this.filename == null)
          {
            saveAs();
          }
        }
      }

      this.filename = null;
      this.selectedPerson = null;
      this.people.Clear();

      this.markSaved();
      this.refreshComponent();
    }

    private void saveAs()
    {
      SaveFileDialog dialog = new SaveFileDialog()
      {
        Title = "Save tree",
        Filter = "Xml File of People (*.xml)|*.xml|All Files (*.*)|*.*",
        FileName = "untitled.xml",
        // InitialDirectory = Environment;
      };

      if (dialog.ShowDialog() == DialogResult.OK)
      {
        this.filename = dialog.FileName;
        this.people.Save(dialog.FileName);

        markSaved();
      }
    }

    private void save()
    {
      if (this.filename != null)
      {
        this.people.Save(this.filename);
        markSaved();
        return;
      }

      saveAs();
      markSaved();
    }

    private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      save();
    }

    private void saveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      saveAs();
    }

    private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      if (this.unsavedChanges)
      {
        if (promptTo(
            "Save?", "Would  you like to save before creating a new tree?",
            "Save", "Don't Save"
          ))
        {
          if (this.filename == null)
          {
            saveAs();
          }
        }
      }

      Close();
    }

    private void btnNewPerson_Click(object sender, System.EventArgs e)
    {
      var person = new Person();

      this.people.Add(person);

      this.updatePersonSelector();

      this.selectedPerson = person;
      this.personSelector.SelectedItem = person;

      this.lockPerson(false);

      this.updateName();
      this.refreshParentSelectors();
      this.updateEvents();
    }

    private void btnDeletePerson_Click(object sender, System.EventArgs e)
    {
      if (this.selectedPerson == null)
      {
        return;
      }

      if (!promptTo("Delete Person",
        $"Are you sure you would like to delete {this.selectedPerson.Name}",
        "Delete", "Cancel"
        ))
      {
        return;
      }

      this.people.Remove(this.selectedPerson);

      this.selectedPerson = null;
      this.lockPerson(true);

      this.updateName();
      this.refreshParentSelectors();
      this.updatePersonSelector();
      this.updateEvents();
    }

    private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      // TODO : show version modal
    }
  }
}
