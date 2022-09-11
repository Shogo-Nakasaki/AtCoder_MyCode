// ユニークビジョンプログラミングコンテスト2022 夏
// (AtCoder Beginner Contest 268)
using System;

// 解けなかった
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
            num_ans += Checker(i, int.Parse(pack[i]), num_N);
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
        else if (num_p == AmodN(num_man + 1, num_all))
        {
            num_ans_this++;
        }

        return num_ans_this;
    }

    static int AmodN(int a, int n)
    {
        int num_return;

        if (a == -1)
        {
            num_return = n;
        }
        if (a == n + 1)
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