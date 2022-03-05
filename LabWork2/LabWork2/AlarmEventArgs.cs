namespace LabWork3
{
    public class AlarmEventArgs : EventArgs
    {
        public string InstituteName { get; set; } = String.Empty;
        public string GroupName     { get; set; } = String.Empty;
        public string StudentName   { get; set; } = String.Empty;

        public AlarmEventArgs(Student student, Institute institute)
        {
            StudentName     = student.Name;
            GroupName       = student.GroupName;
            InstituteName   = institute.InstituteName;
        }
        
    }
}
