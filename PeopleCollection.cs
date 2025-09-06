// Copyright (C) 2025 Dom Marcone. All rights reserved

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace FamilyTreeViewer
{
  public class PeopleCollection : List<Person>
  {
    public PeopleCollection()
    {
      // TODO : write whatever goes here
    }

    public Person GetPersonById(string id)
    {
      var matchingPeople = this.Where((Person person) => {
        return person.Id == id;
      });

      if (matchingPeople.Count() == 0)
      {
        return null;
      }

      return matchingPeople.First();
    }

    public Person[] GetChildren(Person person)
    {
      return this.Where((Person other) => {
        return person.Id == other.Parents[0] || person.Id == other.Parents[1];
      }).ToArray();
    }
    
    public Person[] GetSiblings(Person person, bool bothParents = true)
    {
      var parent1Children = this.GetChildren(person);
      var parent2Children = this.GetChildren(person);

      if (bothParents)
      {
        return parent1Children.Intersect(parent2Children).ToArray();
      }

      return parent1Children.Concat(parent2Children).Distinct().ToArray();
    }

    private Person convertXmlToPerson(XmlNode xml)
    {
      if (xml.NodeType != XmlNodeType.Element)
      {
        return null;
      }

      string name = xml.Attributes["name"].Value;
      string nodeId = xml.Attributes["id"].Value;

      var result = new Person()
      {
        Id = nodeId,
        Name = name
      };

      int i = 0;
      foreach (XmlNode item in xml.SelectNodes("parent"))
      {
        result.Parents[i++] = item.InnerXml;
      }

      foreach (XmlNode item in xml.SelectNodes("event"))
      {
        var date = item.Attributes["date"].Value;

        result.Events.Add(new KeyValuePair<string, string>(date, item.InnerText));
      }

      return result;
    }

    public void Load(string filename)
    {
      XmlDocument doc = new XmlDocument();
      FileStream file = File.OpenRead(filename);

      if (!file.CanRead)
      {
        Console.WriteLine($"Unable to open {filename}");
        return;
      }

      doc.Load(file);

      var people = doc["people"];

      foreach (XmlNode person in people.ChildNodes)
      {
        var converted = convertXmlToPerson(person);

        if (converted != null)
        {
          Add(converted);
        }
      }

      // TODO : I still have to convert this into people
    }

    private void writeString(FileStream output, string text)
    {
      var data = Encoding.UTF8.GetBytes(text);
      output.Write(data, 0, data.Length);
    }

    private void writeParentXml(FileStream output, Person person) 
    {
      for(int i=0; i<2; ++i)
      {
        if(!string.IsNullOrEmpty(person.Parents[i]))
        {
          writeString(output, $"    <parent>{person.Parents[i]}</parent>\n");
        }
      }
    }

    private void writeEventXml(FileStream output, Person person)
    {
      for (int i = 0; i < person.Events.Count; ++i)
      {
        if (!string.IsNullOrEmpty(person.Events[i].Value))
        {
          var evt = person.Events[i];
          writeString(output, 
            $"    <event date=\"{evt.Key}\">{evt.Value}</event>\n");
        }
      }
    }

    private void writePersonXml(FileStream output, Person person)
    {
      writeString(output, $"  <person name=\"{person.Name}\" id=\"{person.Id}\" >\n");

      writeParentXml(output, person);
      writeEventXml(output, person);

      writeString(output, "  </person>\n");
    }

    public void Save(string filename)
    {
      var file = File.OpenWrite(filename);

      if (!file.CanWrite) 
      {
        Debug.WriteLine($"Unable to open {filename}");
      }

      writeString(file, "<people>\n");

      foreach(var person in this)
      {
        writePersonXml(file, person);
      }

      writeString(file, "</people>\n");

      file.Close();
    }
  }
}
