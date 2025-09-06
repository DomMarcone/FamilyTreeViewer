// Copyright (C) 2025 Dom Marcone. All rights reserved

using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyTreeViewer
{
  public class Person : IComparable
  {
    public List<KeyValuePair<string, string>> Events;
    public Microsoft.Msagl.Drawing.Node Node;
    public string Id;
    public string Name;

    public string[] Parents;

    public Person()
    {
      Events = new List<KeyValuePair<string, string>>();
      Name = "untitled person";
      Id = Guid.NewGuid().ToString();
      Parents = new string[2];
      Node = null; // Get's a value when it's added to a graph
    }

    public int CompareTo(object obj)
    {
      return this.ToString().CompareTo(obj.ToString());
    }

    public string FindBirthday()
    {
      string[] birthWords = new string[]
      {
        "Born",
        "born",
        "birth",
        "Birth"
      };

      var evts = Events.Where((KeyValuePair<string, string> evt) =>
        {
          return birthWords.Where((string word) => 
            { 
              return evt.Value.Contains(word); 
            }
          ).Count() > 0;
        }
      );

      if (evts.Count() > 0)
      {
        return evts.First().Key;
      }

      return null;
    }

    public override string ToString()
    {
      string suffix = "";

      string birthday = FindBirthday();

      if (!string.IsNullOrEmpty(birthday))
      {
        suffix = " - " + birthday;
      }

      return Name + suffix;
    }
  }
}
