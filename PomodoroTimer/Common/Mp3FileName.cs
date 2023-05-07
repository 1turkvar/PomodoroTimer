using System.Windows.Forms;

namespace PomodoroTimer
{
    internal class Mp3FileName
    {
        public static void FillComboBoxWithFileNames(string folderPath, ComboBox comboBox)
        {
            string[] fileNames = System.IO.Directory.GetFiles(folderPath);

            foreach (string fileName in fileNames)
            {
                comboBox.Items.Add(System.IO.Path.GetFileName(fileName));
            }
        }

    }
}
