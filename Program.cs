// Copyright (C) 2025 Dom Marcone. All rights reserved

using System;
using System.Windows.Forms;

namespace FamilyTreeViewer
{
  public class FamilyTreeViewer
  {

    [STAThread]
    public static int Main(string[] args)
    {
      string filename = null;

      if (args.Length > 0)
      {
        filename = args[0];
      }

      Editor editor = new Editor(filename);

      Application.Run(editor);

      return 0;
    }
  }
}
