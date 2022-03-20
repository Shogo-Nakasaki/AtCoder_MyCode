using System;
class Untitled
{
	static void Main(string[] args)
	{
		// 入力フェーズ
		string get_N = Console.ReadLine();
		string get_S = Console.ReadLine();
		// 変数の型を変える
		int num1 = int.Parse(get_N);
		//　回答用変数に入力
		string ans = get_S.Substring(num1-1);
		Console.WriteLine(ans);
	}
}