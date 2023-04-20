using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    static class Program
    {
        public enum DeleteModes
        {
            Zeros = 1, //заполнить файл нулями
            OxFF = 2, //заполнить файл 255
            RandomBytes = 3 //заполнить файл рандомными байтами
        }
        private static Dictionary<string, DeleteModes> ModeDict = new Dictionary<string, DeleteModes>
        {
            {"1",DeleteModes.Zeros },
            {"2",DeleteModes.OxFF },
            {"3",DeleteModes.RandomBytes }
        };

        public static DeleteModes DeleteMode;

        public static int countRewrite;//кол-во перезаписей файла перед удалением

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
                bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);

                //if (hasAdministrativeRight == false)
                //{
                //    ProcessStartInfo processInfo = new ProcessStartInfo(); //создаем новый процесс
                //    processInfo.Verb = "runas"; //в данном случае указываем, что процесс должен быть запущен с правами администратора
                //    processInfo.FileName = Application.ExecutablePath; //указываем исполняемый файл (программу) для запуска
                //    try
                //    {
                //        Process.Start(processInfo); //пытаемся запустить процесс
                //    }
                //    catch (Win32Exception)
                //    {
                //        //Ничего не делаем, потому что пользователь, возможно, нажал кнопку "Нет" в ответ на вопрос о запуске программы в окне предупреждения UAC (для Windows 7)
                //    }
                //    Application.Exit(); //закрываем текущую копию программы (в любом случае, даже если пользователь отменил запуск с правами администратора в окне UAC)
                //}
                //else //имеем права администратора, значит, стартуем
                //{
                if (File.Exists(Application.StartupPath + "\\DeleteSettings.ini"))
                {
                    string informationDeleteSettings = File.ReadAllText(Application.StartupPath + "\\DeleteSettings.ini");
                    DeleteMode = ModeDict[informationDeleteSettings.Split('\n')[0].Split(':')[1]];
                    countRewrite = Convert.ToInt32(informationDeleteSettings.Split('\n')[1].Split(':')[1]);
                }
                else
                {
                    string informationDeleteSettings = "Delete Mode:1\nRewrite Counts Before Deleting:1";
                    File.WriteAllText(Application.StartupPath + "\\DeleteSettings.ini", informationDeleteSettings);
                    DeleteMode = DeleteModes.Zeros;
                    countRewrite = 1;
                }

                if (Registry.GetValue(@"HKEY_CLASSES_ROOT\*\shell\SecureDelete\command", "", "").ToString().Length < 2)
                    if (MessageBox.Show("Хотите добавить запись в реестр об возможности удаления файла через контекстное меню?\n" +
                        $"Будет добавлена следующая запись: {Application.ExecutablePath} \"%1\"" +
                        "\nПо пути:\nКомпьютер\\HKEY_CLASSES_ROOT\\*\\shell\\SecureDelete\\command",
                    "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Registry.ClassesRoot.CreateSubKey(@"*\shell\SecureDelete\").SetValue("Icon", Application.ExecutablePath);
                        Registry.ClassesRoot.CreateSubKey(@"*\shell\SecureDelete\").SetValue("MUIVerb", "Secure Delete");
                        Registry.ClassesRoot.CreateSubKey(@"*\shell\SecureDelete\command").SetValue("", Application.ExecutablePath + " \"%1\"");
                    }

                if (Registry.GetValue(@"HKEY_CLASSES_ROOT\*\shell\SecureDelete\command", "", "").ToString() != Application.ExecutablePath + " \"%1\"")
                    if (MessageBox.Show("Хотите перезаписать путь приложения, через которое будет удаляться файл из контекстной?\n" +
                        $"Будет добавлена следующая запись: {Application.ExecutablePath} \"%1\"" +
                        "\nПо пути:\nКомпьютер\\HKEY_CLASSES_ROOT\\*\\shell\\SecureDelete\\command",
                    "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Registry.ClassesRoot.CreateSubKey(@"*\shell\SecureDelete\").SetValue("Icon", Application.ExecutablePath);
                        Registry.ClassesRoot.CreateSubKey(@"*\shell\SecureDelete\").SetValue("MUIVerb", "Secure Delete");
                        Registry.ClassesRoot.CreateSubKey(@"*\shell\SecureDelete\command").SetValue("", Application.ExecutablePath + " \"%1\"");
                    }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
                //}
            }
            else
            {
                Application.Run(new MainForm(args[0]));
            }
        }
    }
}



/*static void Main()
{
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    Application.Run(new MainForm());
}*/
