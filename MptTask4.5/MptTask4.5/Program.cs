using System;

namespace MptTask4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();

            st.setDataFromFile("C:/Git/MptTask.4.5/MptTask4.5/text.txt");
            double temp = st.getAverageMark();
            Console.WriteLine(temp);
            Console.WriteLine("\n\n\npress 1 to close");
            int one = 0;
            while (one == 0)
                one = Convert.ToInt32(Console.ReadLine());
        }
    }
}
