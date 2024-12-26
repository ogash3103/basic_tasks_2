
// task 1 start

System.Console.Write("Son kirgizing agar son tub bo'lsa tub deb chiqadi: ");

int input = Convert.ToInt32(Console.ReadLine());

bool isPrime = true;

if(input <= 1)
{
    isPrime = false;
} else
{
  for(int i = 2; i <= Math.Sqrt(input); i++)
  {
     if(input % i == 0)
     {
        isPrime = false;
        break;
     }
  }

}

if(isPrime) System.Console.WriteLine("Tub");
 else System.Console.WriteLine("Tub emas!");

// tast 1 end

// task 2 start

System.Console.Write("Sonni kiriting: ");

int son = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Bo'luvchilari...: ");
for(int i = 2; i <= 10; i++)
{
  if(son % i == 0) Console.Write(i + " ");
}

// task 2 end

System.Console.WriteLine();

// task 3 start


System.Console.Write("Sonni kiriting: ");
int son2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Darajasini kiriting: ");
int daraja = Convert.ToInt32(Console.ReadLine());

  if (daraja > 0)
    {
       double natija = Math.Pow(son2, daraja); 
       Console.WriteLine("Natija: " + natija);
    }
  else
    {
       Console.WriteLine("Daraja musbat butun son bo'lishi kerak.");
    }

// task 3 end 



// task 4 start 

Console.Write("Nechta miqdor kiritasiz? ");
        int n = int.Parse(Console.ReadLine()!); 
        
        int yigindi = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Miqdor " + i + "ni kiriting: ");
            int miqdor = int.Parse(Console.ReadLine()!); 
            yigindi += miqdor; 
        }

        Console.WriteLine("Yig'indisi: " + yigindi);
    

// task 4 end

System.Console.WriteLine();

// task 5 start

        Console.Write("Sonni kiriting: ");
        int son3 = int.Parse(Console.ReadLine()!); 

        int originalSon = son3;
        int daraja2 = son3.ToString().Length;
        int yigindi2 = 0;

        while (son3 > 0)
        {
            int raqam = son3 % 10; 
            yigindi2 += (int)Math.Pow(raqam, daraja2); 
            son3 /= 10; 
        }

        if (yigindi2 == originalSon)
        {
            Console.WriteLine(originalSon + " Armstrong son");
        }
        else
        {
          Console.WriteLine(originalSon + " Armstrong son emas");
        }
// task 5 end



// task 6 start

 Console.Write("Son kiriting: ");
        int num = int.Parse(Console.ReadLine()!);

        int count = 0;
        
            for (int i = 1; i < num / 2; i++) 
            {
                if (num % i == 0) 
                {
                    Console.Write(i + " ");
                    count++;
                }
            }

        Console.WriteLine($"Sifatli bo'luvchilar soni: {count}");

// task 6 end