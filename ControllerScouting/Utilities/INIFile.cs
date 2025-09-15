using System.Runtime.InteropServices;
using System.Text;

namespace ControllerScouting.Utilities
{
    public class INIFile(string path)
    {
        public string Path { get; private set; } = path;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder retVal, int size, string filePath);

        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, Path);
        }

        public string Read(string section, string key, string defaultValue = "")
        {
            var retVal = new StringBuilder(3825);
            GetPrivateProfileString(section, key, defaultValue, retVal, 3825, Path);
            return retVal.ToString();
        }
        public void DeleteKey(string section, string key)
        {
            Write(section, key, null);
        }

        public void DeleteSection(string section)
        {
            Write(section, null, null);
        }

        public bool KeyExists(string section, string key)
        {
            return Read(section, key).Length > 0;
        }
    }
}