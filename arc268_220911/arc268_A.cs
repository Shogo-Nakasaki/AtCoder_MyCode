// AtCoder Regular Contest 148

// memo
// 1. Ai mod M (M = 1とする)の要素の種類数を求める
// 2.Mの値を2 <= M <= N の範囲で変化できるようにする
// 3.要素の種類数が最も少ない時を求める

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

class Problem_A
{
    static void Main(string[] args)
    {
        // 入力
        int num_N = int.Parse(Console.ReadLine());
        var array_A = System.Console.ReadLine().Split(' ');
        int[] array_ans2 = new int[int.Parse(array_A.Max())];
        int num_i = 0;
        for(int i = 2; i <= int.Parse(array_A.Max()); i++)
        {
            array_ans2[num_i] = AmodM(i,num_N,array_A);
            num_i++;
        }
        int[] array_ans2_count = array_ans2.Distinct().ToArray();
        // Console.WriteLine("要素数は･･････");
        // Console.WriteLine(array_ans2_count.Length);
        Array.Sort(array_ans2_count);
        for(int i = 0; i < array_ans2_count.Length; i++)
        {
            if(array_ans2_count[i] > 0)
            {
                Console.WriteLine(array_ans2_count[i]);
                break;
            }
        }
    }

    static int AmodM(int M, int num_N, string[] array_A)
    {
        int num_type = 1;

        int[] array_ans1 = new int[num_N];

        // int num_M = 2;

        for (int i = 0; i < num_N; i++)
        {
            array_ans1[i] = int.Parse(array_A[i]) % M;
            // Console.WriteLine(array_ans1[i]);
        }
        int[] array_ans1_count = array_ans1.Distinct().ToArray();
        // Console.WriteLine("要素数は・・・");
        // Console.WriteLine(array_ans1.Length);
        num_type = array_ans1_count.Length;

        return num_type;
    }
}