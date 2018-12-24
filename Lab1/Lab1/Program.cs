using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person KarinaVasilkova = new Person("Karina", "Vasilkova", new DateTime(1996, 09, 10));
            Paper firstPapar = new Paper("Title1", KarinaVasilkova, (2018, 09, 31));
            ResearchTeam firstResearchTeam = new ResearchTeam();

            Console.WriteLine("First task is (toShortString):\n" + firstResearchTeam.ToShortString());
            //Console.WriteLine("Second task is (TimeFrame):\n" + TimeFrame.Year + " " + TimeFrame.TwoYears + " " + TimeFrame.Long);

            //firstResearchTeam = new ResearchTeam("My ResearchTeam", TimeFrame.Year, TimeFrame.TwoYears, 10, new[] { firstArtucle });
            Console.WriteLine("Third task is (toString + ResearchTeam all params):\n" + firstResearchTeam);

            firstResearchTeam.AddPaper(firstPapar, firstPapar);
            Console.WriteLine("Fourth task is (toString + AddPaper):\n" + firstResearchTeam.ToString());

            Console.WriteLine("Fifth task is (timer in massifs):\n");
            string inputText = Console.ReadLine();

            int nRows = Int32.Parse(inputText.Split(' ')[0]);
            int mColumns = Int32.Parse(inputText.Split(' ')[1]);

            int sum = 0;
            int size = 0;
            while (sum < nRows * mColumns)
            {
                sum += ++size;
            }

            Paper[] oneDimension = new Paper[nRows * mColumns];
            Paper[,] twoDimension = new Paper[nRows, mColumns];
            Paper[][] cogged = new Paper[size][];

            var timeStart = Environment.TickCount;
            for (int i = 0; i < nRows * mColumns; i++)
            {
                oneDimension[i] = firstPapar;
            }
            var timeEnd = Environment.TickCount;
            Console.WriteLine("\nOne dimension is: " + (timeEnd - timeStart));

            timeStart = Environment.TickCount;
            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < mColumns; j++)
                {
                    twoDimension[i, j] = firstPapar;
                }
            }
            timeEnd = Environment.TickCount;
            Console.WriteLine("\nTwo dimension is: " + (timeEnd - timeStart));

            for (int i = 0; i < size; i++)
            {
                if (i == size - 1)
                {
                    cogged[i] = new Paper[nRows * mColumns - (sum - size)];
                    break;
                }
                cogged[i] = new Paper[i + 1];
            }

            timeStart = Environment.TickCount;
            foreach (var lineArray in cogged)
            {
                for (var j = 0; j < lineArray.Length; j++)
                {
                    lineArray[j] = firstPapar;
                }
            }
            timeEnd = Environment.TickCount;
            Console.WriteLine("\nTwo dimension2 is: " + (timeEnd - timeStart));

            Console.Read();
        }
    }
}
