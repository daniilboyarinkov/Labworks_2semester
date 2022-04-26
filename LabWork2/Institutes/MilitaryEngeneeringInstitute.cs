namespace LabWork3.Institutes
{
    public class MilitaryEngeneeringInstitute : Institute
    {
        public override string InstituteName { get; } = "Military Institute";
        public override List<Student> Students { get; set; } = new()
        {
            new Student() { Name = "Петя", GroupName = "МИ2-2", InstituteName = "Military Institute" },
            new Student() { Name = "Петя", GroupName = "МИ2-3", InstituteName = "Military Institute" },
            new Student() { Name = "Петя", GroupName = "МИ2-3", InstituteName = "Military Institute" },
            new Student() { Name = "Петя", GroupName = "МИ2-3", InstituteName = "Military Institute" },
            new Student() { Name = "Петя", GroupName = "МИ2-3", InstituteName = "Military Institute" },
            new Student() { Name = "Петя", GroupName = "МИ2-3", InstituteName = "Military Institute" },
            new Student() { Name = "Петя", GroupName = "МИ2-2", InstituteName = "Military Institute" },
            new Student() { Name = "Петя", GroupName = "МИ2-2", InstituteName = "Military Institute" },
            new Student() { Name = "Петя", GroupName = "МИ2-2", InstituteName = "Military Institute" },
        };

        public override void MedicalCenter_Alarm(object sender, AlarmEventArgs args)
        {
        }
    }
}
