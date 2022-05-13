using GalaSoft.MvvmLight.Command;
using LabWork5.Components;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LabWork5
{
    internal class Logic : INotifyPropertyChanged
    {
            
        public ObservableCollection<Subject> Subjects = new(DB.DB.GetSubjects());

        private ObservableCollection<Subject> _filterdSubjects = new(DB.DB.GetSubjects());
        public ObservableCollection<Subject> FilterdSubjects
        {
            get => _filterdSubjects;
            set { _filterdSubjects = value; NotifyPropertyChanged("FilterdSubjects"); }
        }
        public Subject? NewSubject { get; set; } = new();
        public Subject? SelectedSubject { get; set; }

        public string? Filter { get; set; } = "all";

        public void FilterSubjects()
        {
            if (Filter == "all")
                FilterdSubjects = new ObservableCollection<Subject>(Subjects);
            else if (Filter == "passed")
                FilterdSubjects = new ObservableCollection<Subject>(Subjects.Where(el => el.IsDone));
            else if (Filter == "failed")
                FilterdSubjects = new ObservableCollection<Subject>(Subjects.Where(el => !el.IsDone));
        }

        private RelayCommand? _deleteSubject;
        private RelayCommand? _addSubject;
        private RelayCommand? _changeIsDone;
        private RelayCommand? _filterAll;
        private RelayCommand? _filterPassed;
        private RelayCommand? _filterFailed;
        private RelayCommand? _saveSubjects;

        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string prop = " ") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        public RelayCommand SaveSubjects => _saveSubjects
            ??= new RelayCommand(() => DB.DB.SetSubjects(Subjects));

        public RelayCommand DeleteSubject => _deleteSubject
                    ??= new RelayCommand(() =>
                    {
                        Subjects.Remove(SelectedSubject);
                        FilterSubjects();
                    });

        public RelayCommand AddSubject => _addSubject
            ??= new RelayCommand(
                () =>
                {
                    if (NewSubject == null) return;
                    if (NewSubject.Name == null) return;
                    Subjects.Add(new Subject() { Name = NewSubject?.Name, IsDone = NewSubject.IsDone });
                    FilterSubjects();
                });

        public RelayCommand ChangeIsDone => _changeIsDone
            ??= new RelayCommand(() =>
            {
                if (SelectedSubject == null) return;
                SelectedSubject.IsDone = !SelectedSubject.IsDone;
                FilterSubjects();
            });

        public RelayCommand FilterAll => _filterAll
                    ??= new RelayCommand(() =>
                    {
                        Filter = "all";
                        FilterSubjects();
                    });
        public RelayCommand FilterPassed => _filterPassed
                    ??= new RelayCommand(() =>
                    {
                        Filter = "passed";
                        FilterSubjects();
                    });
        public RelayCommand FilterFailed => _filterFailed
                    ??= new RelayCommand(() =>
                    {
                        Filter = "failed";
                        FilterSubjects();
                    });
    }
}
