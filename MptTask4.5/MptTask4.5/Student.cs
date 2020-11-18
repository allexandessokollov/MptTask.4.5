using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MptTask4._5
{
    class Student
    {
        private string surname;
        private string name;
        private string dateOfBirth;
        private double[] marks = new double[8];
        private int course;
        private double group;


        public void setDataFromFile(string path)
        {
            StreamReader sr = null;
            string str = "";
            char[] ch = str.ToCharArray();
            int[] entrys = new int[13];

            Console.WriteLine("Data format: Surmane Name date of birth (17.04.2001) marks (4.1 3 3.6 4.2 5 4.5 3.8 4.9)" +
                " course (2) group (12.2)");

            try
            {
                sr = new StreamReader(path, Encoding.Default);
                str += sr.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            for (int i = 0; i < entrys.Length; i++)
                entrys[i] = -1;

            for (int j = 0; j < entrys.Length; j++)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                        continue;
                    else if (entrys[j] != -1)
                        continue;
                    else
                    {
                        entrys[j] = i;
                    }
                }
            }

            this.surname = getText(str, entrys[0]);
            this.name = getText(str, entrys[1]);
            this.dateOfBirth = getText(str, entrys[2]);
            for (int i = 0, x = 3; i < marks.Length; i++, x++)   
                marks[i] = Convert.ToDouble(getText(str, entrys[x]));
            this.course = Convert.ToInt32(getText(str, entrys[12]));
            this.group = Convert.ToDouble(getText(str, entrys[13]));


        }

        private string getText(string str, int entry)
        {
            string ret = "";
            for (int i = entry; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    break;
                else
                    ret += str[i];
            }
            return ret;
        }


        public void getAverageMark(double[] marks)
        {
            double average = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                average += marks[i];
                if (i == marks.Length - 1)
                    average = average / i;
            }
        }
    }
}
