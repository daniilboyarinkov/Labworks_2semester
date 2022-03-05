namespace LabWork3
{
    public abstract class Institute
    {
        public abstract List<Student> Students  { get; set; } 
        public abstract string InstituteName    { get; } 

        public abstract void MedicalCenter_Alarm(object sender, AlarmEventArgs args);
    }
}
