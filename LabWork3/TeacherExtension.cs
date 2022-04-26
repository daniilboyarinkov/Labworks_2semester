namespace LabWork3.Extensions
{
    public static class TeacherExtension
    {
        public static string Print(this Teacher teacher)
        {
            if (teacher.FIO is null)
                throw new ArgumentException("ФИО задано в неверном формате");

            string[] FIO = teacher.FIO.Split(' ');

            if (FIO.Length != 3)
                throw new ArgumentException("ФИО задано в неверном формате");

            return $"{FIO[0]} {FIO[1][0]}. {FIO[2][0]}.";
        }
    }
}
