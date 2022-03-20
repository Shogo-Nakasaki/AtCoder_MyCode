using System;
class Untitled
{
	static void Main(string[] args)
	{
		// 入力フェーズ
		string get_N = Console.ReadLine();
		string get_T = Console.ReadLine();
		
		// 見ている方向を数字で表す、東:0/南:1/西:2/北:3
		int point_look = 0;
		int now_X = 0;
		int now_Y = 0;
		for(int i = 0; i < int.Parse(get_N); i++)
		{
			// Rが入力されたら方向を変える
			if(get_T[i] == 'R')
			{
				point_look = (point_look == 3)?0:point_look + 1;
			}
			// Sが入力されたら前進する
			if(get_T[i] == 'S')
			{
				now_X = (point_look == 0) ? now_X + 1 :
						(point_look == 2) ? now_X - 1 :
						now_X;
				now_Y = (point_look == 3) ? now_Y + 1 :
						(point_look == 1) ? now_Y - 1 :
						now_Y;
			}
		}
		// 回答出力
		Console.WriteLine(now_X + " " + now_Y);
	}
}