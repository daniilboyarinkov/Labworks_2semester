namespace LabWork3
{
    internal class VideoconfIS
    {
        public List<Teacher> Teachers { get; } = new()
        {
            new Teacher() { FIO = "Иванов Иван Иванович", Institute = "ИППС", VideoConfService = "Zoom" },
            new Teacher() { FIO = "Петров Петр Петрович", Institute = "ИППС", VideoConfService = "Zoom" },
            new Teacher() { FIO = "Алексеев Алексей Алексеевич", Institute = "ИКИТ", VideoConfService = "Skype" },
            new Teacher() { FIO = "Лапин Лапен Лапен", Institute = "РЖД", VideoConfService = "Google Meet" },
            new Teacher() { FIO = "Алкен Алкин Алкан", Institute = "ИКИТ", VideoConfService = "Zoom" },
            new Teacher() { FIO = "Жиринов Аристарх Монархович", Institute = "ГИ", VideoConfService = "Skype" },
            new Teacher() { FIO = "Васильев Малазий Мавзолеевич", Institute = "ИКИТ", VideoConfService = "Diskord" },
            new Teacher() { FIO = "Чудакин Игорь Андреевич", Institute = "ИКИТ", VideoConfService = "Diskord" },
            new Teacher() { FIO = "Жабов Аркадий Барсукович", Institute = "ИППС", VideoConfService = "Diskord" },
            new Teacher() { FIO = "Арлекино Арлекино Арлекино", Institute = "ИКИТ", VideoConfService = "Diskord" },
            new Teacher() { FIO = "Бенедикт Бармалей Арлекинович", Institute = "ИКИТ", VideoConfService = "Space X Network" },
            new Teacher() { FIO = "Чукойвский Корней Корнеевич", Institute = "ГИ", VideoConfService = "WebinarSFU" },
        };

        private delegate bool IsCanAddTeacher(string name, List<Teacher> teachers);
        private readonly IsCanAddTeacher isCanAddTeacher = (name, teachers) =>
            !teachers.Exists(teacher => teacher.FIO == name);

        public string AddTeacher(Teacher newTeacher)
        {
            if (newTeacher.FIO is null) return "\nОШИБКА!!!!\nНевозможно добавить того, кого нет";

            newTeacher.FIO = newTeacher.FIO.Trim();
            if (isCanAddTeacher(newTeacher.FIO, Teachers))
            {
                Teachers.Add(newTeacher);
                return $"\n[{newTeacher.FIO}] - Успешно добавлен!";
            }
            else
            {
                return $"\nОШИБКА!!!!\n[{newTeacher.FIO}] - Уже есть. Несите другого.";
            }
        }

        public List<TopServices> TOP()
        {
            return new(
               Teachers
                   .GroupBy(teacher => teacher.VideoConfService)
                   .Select(group => new TopServices { Name = group.Key, NumberOfUsage = group.Count() })
                   .OrderByDescending(group => group.NumberOfUsage).ThenBy(group => group.Name)
                   .Take(3)
                   .ToList()
              );
        }

        public List<string> GetAllServices()
        {
            return Teachers
                .GroupBy(teacher => teacher.VideoConfService)
                .Select(service => service.Key)
                .ToList();
        }
    }
}
