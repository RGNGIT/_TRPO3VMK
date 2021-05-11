using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TRPO3VMK
{

    public static class Database
    {
        // Отделение больницы
        public static List<string> BName = new List<string>();
        public static List<string> BPhone = new List<string>();
        public static List<string> BPalataNum = new List<string>();
        // Врач
        public static List<string> VFIO = new List<string>();
        public static List<string> VSpecialize = new List<string>();
        // Откуда поступил
        public static List<string> From = new List<string>();
    }

}
