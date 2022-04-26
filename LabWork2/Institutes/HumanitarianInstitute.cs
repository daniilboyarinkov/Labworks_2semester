namespace LabWork3.Institutes
{
    public class HumanitarianInstitute : Institute
    {
        public override string InstituteName { get; } = "Humanitarian Institute";
        public override List<Student> Students { get; set; } = new() { 
            new Student() { Name = "Вася", GroupName = "ГИ2-2", InstituteName = "Humanitarian Institute" }, 
            new Student() { Name = "Вася", GroupName = "ГИ2-2", InstituteName = "Humanitarian Institute" }, 
            new Student() { Name = "Вася", GroupName = "ГИ2-3", InstituteName = "Humanitarian Institute" }, 
            new Student() { Name = "Вася", GroupName = "ГИ2-3", InstituteName = "Humanitarian Institute" }, 
            new Student() { Name = "Вася", GroupName = "ГИ2-3", InstituteName = "Humanitarian Institute" }, 
            new Student() { Name = "Вася", GroupName = "ГИ2-3", InstituteName = "Humanitarian Institute" }, 
            new Student() { Name = "Вася", GroupName = "ГИ2-2", InstituteName = "Humanitarian Institute" }, 
            new Student() { Name = "Вася", GroupName = "ГИ2-2", InstituteName = "Humanitarian Institute" }, 
            new Student() { Name = "Вася", GroupName = "ГИ2-2", InstituteName = "Humanitarian Institute" }, 
        };
        public override void MedicalCenter_Alarm(object sender, AlarmEventArgs args)
        {
            // отправляем всех студентов группы на дистант
            Students
                .FindAll(student => student.GroupName == args.GroupName)
                .ForEach(student => student.IsStudyDistance = true );
        }
    }
}
