namespace LabWork3.Institutes
{
    public class InstituteOfSpaceAnfInformationTechnolohy : Institute
    {
        public override string InstituteName { get; } = "IKIT";
        public override List<Student> Students { get; set; } = new() 
        {
            new Student() { Name = "Ваня", GroupName = "КИ2-2", InstituteName = "IKIT" },
            new Student() { Name = "Ваня", GroupName = "КИ2-2", InstituteName = "IKIT" },
            new Student() { Name = "Ваня", GroupName = "КИ2-2", InstituteName = "IKIT" },
            new Student() { Name = "Ваня", GroupName = "КИ2-2", InstituteName = "IKIT" },
            new Student() { Name = "Ваня", GroupName = "КИ2-3", InstituteName = "IKIT" },
            new Student() { Name = "Ваня", GroupName = "КИ2-3", InstituteName = "IKIT" },
            new Student() { Name = "Ваня", GroupName = "КИ2-3", InstituteName = "IKIT" },
            new Student() { Name = "Ваня", GroupName = "КИ2-2", InstituteName = "IKIT" },
            new Student() { Name = "Ваня", GroupName = "КИ2-2", InstituteName = "IKIT" },
        };

        public override void MedicalCenter_Alarm(object sender, AlarmEventArgs args)
        {
            // отправляем всех студентов на дистант
            Students.ForEach(student => student.IsStudyDistance = true);
        }
    }
}
