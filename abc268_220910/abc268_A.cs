// ユニークビジョンプログラミングコンテスト2022 夏
// (AtCoder Beginner Contest 268)
using System;

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