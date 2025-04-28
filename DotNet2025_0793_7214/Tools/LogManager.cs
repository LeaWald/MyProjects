using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class LogManager
    {
        private static string logDirPath = "Log";
        private static DirectoryInfo CurrentDir;
        /// <summary>
        /// יצירת תקיה של החודש הנוכחית,רק אם לא קיים כבר
        /// </summary>
        /// <returns>מחזיר ניתוב של התקיה</returns>
        private static string GetMonthFolderName()
        {
            string folderPath = @$"{logDirPath}\{DateTime.Now.Year}_{DateTime.Now.Month}";
            CurrentDir = new DirectoryInfo(logDirPath);
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            return folderPath;
        }
        /// <summary>
        /// יצירת קובץ של היום הנוכחי, רק אם לא קיים כבר, אם קיים משרשר לתוכו
        /// </summary>
        /// <returns>מחזיר ניתוב של הקובץ</returns>
        private static string GetTodayFileName()
        {
            string filePath = @$"{GetMonthFolderName()}\{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}.txt";
            if (!File.Exists(filePath))
                File.Create(filePath).Close();
            return filePath;
        }

        /// <summary>
        /// כתיבת תעוד לקובץ
        /// </summary>
        /// <param name="project">שם הפרויקט</param>
        /// <param name="func">שם הפונקציה</param>
        /// <param name="message">תאור</param>
        public static void WriteToLog(string project,string func, string message)
        {
            using (StreamWriter sw = new StreamWriter(GetTodayFileName(), true))
            {
   
                sw.WriteLine($"{DateTime.Now}\t{project}\t{func}\t{message}");
            }
        }

        /// <summary>
        /// ניקוי תקיות ישנות- כל התקיות מלפי חודשיים ומעלה
        /// </summary>
        public static void ClearLog()
        {
            DirectoryInfo[] dirInfo = CurrentDir.GetDirectories();
            foreach (DirectoryInfo dir in dirInfo)
            {
                DateTime date = dir.CreationTime;
                if (date >= DateTime.Now.AddMonths(-2))
                    dir.Delete(true);
            }
        }
    }
}
