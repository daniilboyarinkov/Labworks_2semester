using LabWork3;
using LabWork3.Institutes;

// Medical center
MedicalCenter medicalCenter                     = new();

// Institutes
InstituteOfSpaceAnfInformationTechnolohy IKIT   = new();
HumanitarianInstitute HI                        = new();
MilitaryEngeneeringInstitute MI                 = new();

List<Institute> institutes = new() { IKIT, HI, MI};


// Вывод всех студентов
institutes.ForEach(institute => 
{
    Console.WriteLine($"\n{institute.InstituteName}");
    institute.Students.ForEach(student => Console.WriteLine($"{student.Name}\t{student.GroupName}"));
});


// Все институты подписываются на событие Мед центра
institutes.ForEach(institute => medicalCenter.Alarm += institute.MedicalCenter_Alarm);

Student student = HI.Students[0];

//  Выводим студента
Console.WriteLine($"\n{student.Name}\nGroup: {student.GroupName}");

medicalCenter.OnAlarm(student, HI);

// Выводим тех, кто ушел на дистант вместе с больным:
Console.WriteLine("Ушли на дистант вместе с больным: ");
institutes.ForEach(institute =>
    {
        institute.Students.ForEach(student => {
            if (student.IsStudyDistance) 
                System.Console.WriteLine($"{student.Name}\tGroup:{student.GroupName}\t\t{student.InstituteName}"); 
        });
    });
