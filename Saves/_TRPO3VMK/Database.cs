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
        // Специализация
        public static List<string> VSpecializeList = new List<string>();
        // Откуда поступил
        public static List<string> From = new List<string>();
        // Пол
        public static List<string> Sex = new List<string>();
        // Диагноз
        public static List<string> Diag = new List<string>();
        // Причина выписки
        public static List<string> Reason = new List<string>();
        // Больной
        public static List<string> FIO = new List<string>();
        public static List<string> Pol = new List<string>();
        public static List<string> NomerPolisa = new List<string>();
        public static List<string> DataBirth = new List<string>();
        public static List<string> Diagnoz = new List<string>();
        public static List<string> BolFrom = new List<string>();
        public static List<string> BolVrach = new List<string>();
        public static List<string> DataReg = new List<string>();
        public static List<string> Bolnitsa = new List<string>();
        public static List<string> DataVipiski = new List<string>();
        public static List<string> PrichinaVipiski = new List<string>();
        public static List<bool> OnPlace = new List<bool>();
    }

}
