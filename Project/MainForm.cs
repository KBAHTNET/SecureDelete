using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using CustomDesign;
using CustomDesign.Controls;

namespace Project
{
    public partial class MainForm : ShadowedForm, IMainFormMethods
    {

        private string pathFileDelete; //путь к удаляемому файлу

        private int countToRewrite;//кол-во перезаписей

        #region Важные методы
        public void FileRenameAndDelete(string path)
        {
            Random rand = new Random();

            string newFileName = "";

            string onlyPath = "";
            int partCout = 0;
            foreach (string pathPart in path.Split('\\'))
            {
                if (path.Split('\\').Length - 1 != partCout)
                    onlyPath += pathPart + "\\";
                else break;
                partCout++;
            }

            newFileName = GenerateRandomString();
            File.Move(path, onlyPath + newFileName);
            pathToFile.Text = onlyPath + newFileName;
            pathToFile.Select();
            pathFileDelete = pathToFile.Text;
            File.Delete(pathFileDelete);
        }
        public string GenerateRandomString()
        {
            Random random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789.;{} абвгдежзийклм" +
                "нопрстуфхцчшщъыьэюяАБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ☺☻♥♦♣♠•◘○◙♂♀♪♫-☼►◄↕‼¶§▬↨↑↓→←∟↔▲▼ !#$%&()╞]$";
            var stringChars = new char[random.Next() % 60 + 1];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }
        #endregion

        #region Конструкторы
        public MainForm()
        {
            countToRewrite = Program.countRewrite;

            InitializeComponent();

            Animator.Start();

            comboBox1.SelectedIndex = Convert.ToInt32(File.ReadAllText
                (Application.StartupPath + "\\DeleteSettings.ini")
                .Split('\n')[0].Split(':')[1]) - 1;

            string[] Drivers = Environment.GetLogicalDrives();
            foreach (string Drive in Drivers)
            {
                DriversComboBox.Items.Add(Drive);
            }

            countRewriteTextBox.Text = countToRewrite.ToString();
        }

        public MainForm(string args)
        {
            countToRewrite = 1;

            InitializeComponent();

            Animator.Start();

            comboBox1.SelectedIndex = 0;

            string[] Drivers = Environment.GetLogicalDrives();
            foreach (string Drive in Drivers)
            {
                DriversComboBox.Items.Add(Drive);
            }
            pathFileDelete = args;
            pathToFile.Text = args;
            pathToFile.Select();
            countRewriteTextBox.Text = countToRewrite.ToString();
            DeleteFileButton_Click(this, EventArgs.Empty);
            Application.Exit();
        }
        #endregion

        #region Обрботка нажатий на кнопки
        public void ChoseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выберите файл";
            ofd.Filter = "Все файлы|*.*";
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathFileDelete = ofd.FileName;
                pathToFile.TextInput = ofd.FileName;
                pathToFile.Select();
            }
        }

        public void DeleteFileButton_Click(object sender, EventArgs e)
        {
            if (pathFileDelete.Length > 1)
            {
                using (FileStream fstream = File.Open(pathFileDelete, FileMode.Open))
                {
                    switch (Program.DeleteMode)
                    {
                        case Program.DeleteModes.Zeros:
                            for (int c = 0; c < countToRewrite; c++)
                            {
                                fstream.Seek(0,SeekOrigin.Begin);
                                for (long i = 0; i < fstream.Length; i++)
                                {
                                    fstream.WriteByte(0x00);
                                }
                            }
                            break;
                        case Program.DeleteModes.OxFF:
                            for (int c = 0; c < countToRewrite; c++)
                            {
                                fstream.Seek(0, SeekOrigin.Begin);
                                for (long i = 0; i < fstream.Length; i++)
                                {
                                    fstream.WriteByte(0xFF);
                                }
                            }
                            break;
                        case Program.DeleteModes.RandomBytes:
                            Random rand = new Random();
                            for (int c = 0; c < countToRewrite; c++)
                            {
                                fstream.Seek(0, SeekOrigin.Begin);
                                byte[] array = new byte[fstream.Length];
                                rand.NextBytes(array);
                                fstream.Write(array, 0, array.Length);
                            }
                            break;
                        default:
                            break;
                    }
                }
                FileRenameAndDelete(pathFileDelete);

                MessageBox.Show("Файл удален", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Файл для удаления не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public async void RewriteDriveButton_Click(object sender, EventArgs e)
        {
            DriveInfo di = new DriveInfo(DriversComboBox.Text);
            long Ffree = di.AvailableFreeSpace;

            string path = DriversComboBox.Text + GenerateRandomString();
            try
            {
                byte[] bytes = new byte[Ffree];
                MessageBox.Show("1" + path);
                for (int i = 0; i < countToRewrite; i++)
                {
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            for (long j = 0; i < Ffree; i++)
                            {
                                bytes[j] = 0x00;
                            }

                            break;
                        case 1:
                            for (long j = 0; i < Ffree; i++)
                            {
                                bytes[j] = 0xFF;
                            }

                            break;
                        case 2:
                            Random rand = new Random();
                            rand.NextBytes(bytes);
                            break;
                        default:
                            break;
                    }
                    File.WriteAllBytes(path, bytes);
                }
            }
            catch
            {
                MessageBox.Show(path);
                await Task.Run(() =>
                {
                    
                    using (FileStream fstream = File.Open(path, FileMode.Create))
                    {
                        fstream.Seek(0, SeekOrigin.Begin);
                        for (long i = 0; i < Ffree; i++)
                        {
                            fstream.WriteByte(0x00);
                        }
                    }
                    File.Delete(pathFileDelete);
                });
            }
        }
        #endregion

        #region Функции интерфейса при работе с текстбоксами
        private void DriversComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DriveInfo driver = new DriveInfo(DriversComboBox.SelectedItem.ToString());
                if (driver.VolumeLabel.Length > 1) textBox1.Text = driver.VolumeLabel;
                else textBox1.Text = driver.Name;
                textBox2.Text = driver.DriveFormat.ToString();
                textBox3.Text = driver.AvailableFreeSpace.ToString() + " байт";
                textBox4.Text = (driver.TotalFreeSpace / 1024 / 1024 / 1024).ToString() + " Гбайт";
                textBox5.Text = driver.TotalSize.ToString() + " байт";
            }
            catch
            {
                MessageBox.Show("Невозможно получить данные о диске", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void countRewriteTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                countToRewrite = Convert.ToInt32(countRewriteTextBox.Text);
            }
            catch
            {
                MessageBox.Show("В текстовом поле должно быть только число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pathToFile_TextChanged(object sender, EventArgs e)
        {
            pathFileDelete = pathToFile.Text;
        }
        #endregion


        private void mainPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string informationDeleteSettings = "Delete Mode:" + Convert.ToString(comboBox1.SelectedIndex + 1) +
                "\nRewrite Counts Before Deleting:" + countToRewrite;
            File.WriteAllText(Application.StartupPath + "\\DeleteSettings.ini", informationDeleteSettings);
        }
    }
}

//private void readbutton_click1(object sender, eventargs e)
//{

//    driveinfo di = new driveinfo(@"e:\");
//    double ffree = (di.availablefreespace / 1024) / 1024 / 1024 / 8;
//    messagebox.show(ffree.tostring("#,##") + " гбайт");

//    запись в файл
//    using (filestream fstream = new filestream(pathtextbox.text, filemode.open))
//    {
//        преобразуем строку в байты
//        byte[] array = system.text.encoding.default.getbytes(text);
//        запись массива байтов в файл
//        fstream.write(array, 0, array.length);
//        console.writeline("текст записан в файл");
//    }

//    чтение из файла
//   openfiledialog ofd = new openfiledialog();
//    ofd.title = "выберите файл";
//    ofd.filter = "текстовые файлы|*.txt|картинки|*.jpg;*.jpeg;*.png|все файлы|*.*";
//    ofd.multiselect = false;
//    if (ofd.showdialog() == dialogresult.ok)
//    {
//        pathtextbox.text = ofd.filename;
//    }
//    using (filestream fstream = file.open("123" /*pathtextbox.text*/, filemode.open))
//    {
//        binarytextbox.text = "";
//        progressbar1.value = 0;
//        преобразуем строку в байты
//        byte[] array = new byte[fstream.length];
//        считываем данные
//        fstream.read(array, 0, array.length);
//        декодируем байты в строку
//        string textfromfile = system.text.encoding.default.getstring(array);

//        binarytextbox.text += "биты до рандомизации\n";
//        for (int i = 0; i < array.length; i++)
//        {
//            binarytextbox.text += convert.tostring(array[i], 16) + " ";
//        }

//        binarytextbox.text += "\nбиты после рандомизации\n";
//        random random = new random();
//        for (int i = 0; i < array.length; i++)
//        {
//            int randint = random.next() % 255;
//            array[i] = convert.tobyte(randint);
//        }

//        for (int i = 0; i < array.length; i++)
//        {
//            binarytextbox.text += convert.tostring(array[i], 16) + " ";
//        }


//        for (int i = 0; i < array.length; i++)
//        {
//            fstream.seek(i, seekorigin.begin);
//            fstream.writebyte(array[i]);
//        }
//        new thread(() =>
//    {
//        int length = array.length;
//        for (int i = 0; i < array.length; i++)
//        {
//            invoke((action)(() =>
//            {
//                binarytextbox.text += convert.tostring(array[i], 16) + " ";
//                try
//                {
//                    progressbar1.value = ((i + 1) * 100 / length);
//                }
//                catch { }
//            }));
//        }
//    }).start();

//    }
//}
