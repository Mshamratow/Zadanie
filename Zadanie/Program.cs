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
            File.WriteAllText("Candidats.txt", "������;�������;4;�������������,���� 10 ���\r\n��������;�������;2;�������� � �����\r\n��������;�����;7;������ �������\r\n�������;����;1;������ �����������");
            File.WriteAllText("Positions.txt", "1;�����������\r\n2;���������\r\n3;���������\r\n4;�������\r\n5;�������\r\n6;��������\r\n7;�����");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}