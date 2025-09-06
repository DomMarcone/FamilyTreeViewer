// Copyright (C) 2025 Dom Marcone. All rights reserved

using System;
using System.Windows.Forms;
using System.Drawing;

namespace FamilyTreeViewer
{
  public static class FamilyTreeViewerTheme
  {
    public static class Theme
    {
      // bootstrap colors
      public static Color ColorPrimary   = Hex2Color("007bff");
      public static Color ColorSecondary = Hex2Color("6c757d");
      public static Color ColorSuccess   = Hex2Color("28a745");
      public static Color ColorDanger    = Hex2Color("dc3545");
      public static Color ColorWarning   = Hex2Color("ffc107");
      public static Color ColorInfo      = Hex2Color("17a2b8");
      public static Color ColorLight     = Hex2Color("f8f9fa");
      public static Color ColorDark      = Hex2Color("343a40");
      public static Color ColorWhite     = Hex2Color("ffffff");

      static Color Hex2Color(string hex)
      {
        int result = Convert.ToInt32("FF" + hex, 16);

        return Color.FromArgb(result);
      }

      public static Color FormBackColor = ColorWhite;
      public static Color ButtonBackColor = ColorWhite;
      public static Color ButtonForeColor = ColorDark;

      public static Font Font = new Font("Helvetica", 10, FontStyle.Regular);
    }

    public static void Apply(Form form)
    {
      form.BackColor = Theme.FormBackColor;
      form.FormBorderStyle = FormBorderStyle.FixedSingle;

      Apply(form.Controls);
    }

    public static void Apply(Control control)
    {
      control.BackColor = Theme.ColorWhite;
      control.ForeColor = Theme.ColorDark;
      control.Font = Theme.Font;

      if (control is Form form)
      {
        Apply((Form)control);
      }
      else if (control is Button button)
      {
        button.BackColor = Theme.ButtonBackColor;
        button.ForeColor = Theme.ButtonForeColor;
        button.FlatStyle = FlatStyle.Flat;
      }
      // Add more conditions for other control types
      else if (control is TextBox textBox)
      {
        textBox.BorderStyle = BorderStyle.FixedSingle;
      }
      if (control.HasChildren)
      {
        Apply(control.Controls); // Recursively apply to child controls
      }
    }

    public static void Apply(Control.ControlCollection container)
    {
      foreach (Control control in container)
      {
        Apply(control);
      }
    }
  }
}
