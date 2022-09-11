using System;
class Untitled
{
	static void Main(string[] args)
	{
		// 入力フェーズ
		string get_N = Console.ReadLine();
		string get_enemy;
		int num_prb = int.Parse(get_N) * 2 +2;
		int[] num_choice = new int[num_prb];
		int ans;
		bool check_win = false;
		Random r1 = new System.Random();
		
		for(int i = 0; i < num_prb; i++)
		{
			num_choice[i] = i;
		}
		for(;;)// 勝敗判定でbreak
		{
			for(;;)// 0を引くとbreak リプレイ
			{
				//　答える数字をランダムで生成
				ans = r1.Next(0,num_prb);
				// こたる数字が0だと再生成、0以外だと答える
				if(num_choice[ans] == 0){break;}
				else
				{
					Console.WriteLine(ans);
					Console.Out.Flush();
					num_choice[ans] = 0;
				}
				// 相手の答えた数値を入力
				get_enemy = Console.ReadLine();
				ans = int.Parse(get_enemy);
				// 相手が答えた数値を除外
				num_choice[ans] = 0;
				// 相手が0を答えたか（敗北したか）の判定を返す
				check_win = (ans == 0) ? true : false;
			}
			if(check_win == true){break;}
		}
	}
}