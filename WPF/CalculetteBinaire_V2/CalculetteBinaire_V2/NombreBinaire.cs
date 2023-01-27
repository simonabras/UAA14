using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculetteBinaire_V2
{
    internal class NombreBinaire
    {
        // Methods
        public ushort[] CreateArray(string chaine)
        {
            ushort[] binArray = new ushort[8];
            for (int i = 0; i < 8; i++)
            {
                binArray[i] = 0;
            }
            for (int i = 0; i < chaine.Length; i++)
            {
                binArray[7 - i] = (ushort)(chaine[chaine.Length - i - 1]);
            }
            return binArray;
        }

        public string ConvertArrayToString(ushort[] array)
        {
            string chaine = "";
            for (int i = 0; i < array.Length; i++)
            {
                chaine += array[i].ToString();
            }
            return chaine;
        }

        public bool Addition(ushort[] binArray1, ushort[] binArray2, out ushort[] resultArray)
        {
            resultArray = new ushort[8];
            ushort report = 0;
            bool success = true;
            for (int i = 7; i >= 0; i--)
            {
                ushort result = (ushort)(binArray1[i] + binArray2[i] + report);
                if (result / 2 == 0)
                {
                    report = 0;
                }
                else
                {
                    report = 1;
                }
                if (result == 1)
                {
                    resultArray[i] = 1;
                }
                else
                {
                    if (result % 2 == 1)
                    {
                        resultArray[i] = 1;
                    }
                    else
                    {
                        resultArray[i] = 0;
                    }
                }
            }
            if (report == 1)
            {
                success = false;
            }
            return success;
        }

        public bool Soustraction(ushort[] binArray1, ushort[] binArray2, out ushort[] resultArray)
        {
            resultArray = new ushort[8];
            ushort[] tempArray = new ushort[8];
            bool success = true;
            for (int i = 0; i < 8; i++)
            {
                tempArray[i] = (ushort)(binArray1[i] - binArray2[i]);
            }
            for (int i = 7; i > 0; i--)
            {
                if (tempArray[i] == -1)
                {
                    binArray2[i - 1] = (ushort)(binArray2[i - 1] + 1);
                    binArray1[i] = (ushort)(binArray1[i] + 2);
                }
                if (binArray1[i] < binArray2[i])
                {
                    binArray2[i - 1] = (ushort)(binArray2[i - 1] + 1);
                    binArray1[i] = (ushort)(binArray1[i] + 2);
                    resultArray[i] = (ushort)(binArray1[i] - binArray2[i]);
                }
            }
            if (binArray1[0] >= binArray2[0])
            {
                resultArray[0] = (ushort)(binArray1[0] - binArray2[0]);
            }
            else
            {
                success = false;
            }
            return success;
        }
    }
}
