# CinemaInfo
 Bir mvc uygulaması üzerinden sisteme giriş yaparak ilgili API aracışığıyla istenilen filmlerin bilgisini getiren ve kullanıcı doğrulamasını farklı bir API üzerinden gerçekleştirin uygulamadır.


 Test Kullanıcıları ; 
 "demir@yahoo.com","12345"
 "demir@saglik.com","12345"
 "demir@sigorta.com","12345"


  static void Main(string[] args)
        {
            

            List<List<int>> records = new List<List<int>>() {
            new List<int> { 1, 4,7},
            new List<int> { 2, 6,9},
            new List<int> { 8, 4,3}
            };

            var result = Foo(records);
            System.Console.WriteLine(result);

            System.Console.ReadLine();
        }


        static int Foo(List<List<int>> records)
        {
            int sum1 = 0, sum2 = 0;

            System.Console.Write("Matris :\n");
            foreach (var record in records)
            {
                foreach (var number in record)
                {
                    System.Console.Write("{0}  ", number.ToString());
                }
                System.Console.Write("\n");
            }

            int firstColumnNumber = 0;
            int secondColumnNumber = records.Count;
            foreach (var item in records)
            {
                secondColumnNumber = secondColumnNumber - 1;
                for (int i = 0; i < item.Count; i++)
                {
                    if (i == firstColumnNumber)
                    {
                        sum1 = sum1 + item[i];
                    }
                    if (i == secondColumnNumber)
                    {
                        sum2 = sum2 + item[i];
                    }
                }
                firstColumnNumber++;
            }
            int absoluteValue = Math.Abs(sum1 - sum2);
            return absoluteValue;
        }
