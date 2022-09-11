// ユニークビジョンプログラミングコンテスト2022 夏
// (AtCoder Beginner Contest 268)
using System;

class Problem_B
{
    static void Main(string[] args)
    {
        string txt_S = Console.ReadLine();
        string txt_T = Console.ReadLine();
        string txt_ans;
        bool checker = false;

        for (int i = 0; i < txt_T.Length + 1; i++)
        {
            if (txt_S == txt_T.Substring(0, i))
            {
                checker = true;
            }
        }
        txt_ans = (checker == true) ? "Yes" : "No";

        Console.WriteLine(txt_ans);
    }
}