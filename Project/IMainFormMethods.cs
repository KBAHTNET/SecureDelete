using System;

namespace Project
{
    interface IMainFormMethods
    {
        //генерация случайного имени для файла
        string GenerateRandomString();

        //переименование файла и удаление базовыми способами виндовс
        void FileRenameAndDelete(string path);

        //выбрать файл через explorer
        void ChoseFileButton_Click(object sender, EventArgs e);

        //удаление выбранного файла
        void DeleteFileButton_Click(object sender, EventArgs e);

        //заполнить выбранный диск файлом с указанными настройками(байтами 0х00, 0хFF и случайными) 
        //до остатка свободного места, а затем удалить данный файл
        void RewriteDriveButton_Click(object sender, EventArgs e);
    }
}
