// ユニークビジョンプログラミングコンテスト2022 夏
// (AtCoder Beginner Contest 268)
using System;

/* A問題
class Problem_A
{
    static void Main(string[] args)
    {
        int num_count = 0;
        int num_ans = 5;

        var pack = System.Console.ReadLine().Split(' ');

        Array.Sort(pack);
        for(int i = 0; i < pack.Length -1; i++)
        {
            if(pack[i] == pack[i+1])
            {
                num_count++;
            }
        }
        num_ans = num_ans - num_count;

        Console.WriteLine(num_ans);
    }
}
*/

/* B問題
class Problem_B
{
    static void Main(string[] args)
    {
        string txt_S = Console.ReadLine();
        string txt_T = Console.ReadLine();
        string txt_ans;
        bool checker = false;

        for(int i = 0; i < txt_T.Length +1; i++)
        {
            if(txt_S == txt_T.Substring(0,i))
            {
                checker = true;
            }
        }
        txt_ans = (checker == true) ? "Yes" : "No";

        Console.WriteLine(txt_ans);
    }
}
*/

class Problem_C
{
    static void Main(string[] args)
    {
        // 入力
        int num_N = int.Parse(Console.ReadLine());
        var pack = System.Console.ReadLine().Split(' ');

        int num_ans = 0;

        for (int i = 0; i < num_N; i++)
        {
            num_ans += Checker(i,int.Parse(pack[i]),num_N);
        }


        // 出力
        Console.WriteLine(num_ans);
    }

    static int Checker(int num_man, int num_p, int num_all)
    {
        int num_ans_this = 0;


        if (num_p == AmodN(num_man - 1, num_all))
        {
            num_ans_this++;
        }
        else if (num_p == AmodN(num_man, num_all))
        {
            num_ans_this++;
        }
        else if(num_p == AmodN(num_man+1, num_all))
        {
            num_ans_this++;
        }
        
        return num_ans_this;
    }

    static int AmodN(int a, int n)
    {
        int num_return;

        if(a == -1)
        {
            num_return = n;
        }
        if(a == n+1)
        {
            num_return = 0;
        }
        else
        {
            num_return = a;
        }


        return num_return;
    }
}