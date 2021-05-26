using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TRPO3VMK
{
    [Serializable]
    class DynamicBlock
    {
        // Отделение больницы
        public List<string> BName = new List<string>();
        public List<string> BPhone = new List<string>();
        public List<string> BPalataNum = new List<string>();
        // Врач
        public List<string> VFIO = new List<string>();
        public List<string> VSpecialize = new List<string>();
        // Специализация
        public List<string> VSpecializeList = new List<string>();
        // Откуда поступил
        public List<string> From = new List<string>();
        // Пол
        public List<string> Sex = new List<string>();
        // Диагноз
        public List<string> Diag = new List<string>();
        // Причина выписки
        public List<string> Reason = new List<string>();
        // Больной
        public List<string> FIO = new List<string>();
        public List<string> Pol = new List<string>();
        public List<string> NomerPolisa = new List<string>();
        public List<string> DataBirth = new List<string>();
        public List<string> Diagnoz = new List<string>();
        public List<string> BolFrom = new List<string>();
        public List<string> BolVrach = new List<string>();
        public List<string> DataReg = new List<string>();
        public List<string> Bolnitsa = new List<string>();
        public List<string> DataVipiski = new List<string>();
        public List<string> PrichinaVipiski = new List<string>();
        public List<bool> OnPlace = new List<bool>();
    }
}
