using LabWork5.Components;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace LabWork5.DB
{
    public class DB
    {
        static public string PathToFile { get; set; } = "F:/Projects/Proga/LabWork5/LabWork5/DB/config.txt";

        static public ObservableCollection<Subject> GetSubjects()
        {
            List<Subject> _subjects = new();
            string[] arr = File.ReadAllLines(PathToFile);
            foreach (string s in arr)
            {
                string name = s.Split(",")[0].Trim();
                bool isDone = bool.TryParse(s.Split(",")[1].Trim(), out isDone) && isDone;

                if (name.Length > 0)
                    _subjects.Add(new Subject() { Name = name, IsDone = isDone });
            }
            return new ObservableCollection<Subject>(_subjects);
        }

        static async public void SetSubjects(ObservableCollection<Subject> subjects)
        {
            string result = string.Empty;
            foreach (Subject subject in subjects)
            {
                result += $"{subject.Name}, {subject.IsDone} \n";
            }
            await File.WriteAllTextAsync(PathToFile, result);
        }
    }
}
