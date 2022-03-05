namespace LabWork3
{
    public class MedicalCenter
    {
        public event AlarmHandler? Alarm;

        public void OnAlarm(Student student, Institute institute)
        {
            student.IsStudyDistance = true;
            Alarm?.Invoke(this, new AlarmEventArgs(student, institute));

        }
    }
}