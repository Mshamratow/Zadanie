namespace Zadanie
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            File.WriteAllText("Candidats.txt", "Петров;Василий;4;Ответственный,стаж 10 лет\r\nКузьмина;Валерия;2;Работала в банке\r\nСидорова;Ольга;7;Бывший адвокат\r\nПтичкин;Семён;1;Бэкенд разработчик");
            File.WriteAllText("Positions.txt", "1;Программист\r\n2;Экономист\r\n3;Бухгалтер\r\n4;Слесарь\r\n5;Уборщик\r\n6;Директор\r\n7;Юрист");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}