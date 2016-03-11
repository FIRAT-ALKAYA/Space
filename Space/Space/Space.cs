using System;

namespace Space
{
    class Mat
    {
        //Sayının Asal Olup Olmadıgını Kontrol Eden Kod Blogu
        public static bool IsPrime(int n)
        {
            if(n <= 1) return false;
            if(n == 2) return true;
            if(n % 2 == 0) return false;
            double m = Math.Sqrt(n);

            for(int i = 3; i <= m; i += 2)
                if(n % i == 0)
                    return false;

            return true;
        }

        public static bool[] Sieve(int n)
        {
            bool[] prime = new bool[n + 1];
            prime[0] = true;
            prime[1] = true;
            double m = Math.Sqrt(n);

            for(int i = 2; i <= m; i++)
                if(!prime[i])
                    for(int k = i * i; k <= n; k += i)
                        prime[k] = true;

            return prime;
        }

        public static int GCD(int a, int b)
        {
            if(b == 0) return a;
            return GCD(b, a % b);
        }

        public static int LCM(int a, int b)
        {
            return b * a / GCD(a, b);
        }
    }
}
