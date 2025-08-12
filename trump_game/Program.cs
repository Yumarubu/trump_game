using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trump_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //まずはタイトル表示からの1～4の数字を4回分入力する
            Console.WriteLine("**トランプゲーム**");
            Console.WriteLine("1～4の値を入力してください");

            //配列を用意
            int[] trumps = new int[4];

            for (int i = 0; i < 4; i++) 
            {
                Console.Write($"{i + 1}番目のカードの数字を入力してください > ");
                string trumpNum = Console.ReadLine();

                //数字のデータを格納する変数を用意
                int trumpNumber;
                bool numJuage = int.TryParse(trumpNum, out trumpNumber);

                //結果に応じて、次に進む
                while (true) 
                {
                    if (trumpNumber < 1 || trumpNumber > 4)
                    {
                        Console.WriteLine("入力値が違います");
                        Console.Write("もう一度、カードの値を入力してください > ");
                        trumpNum = Console.ReadLine();
                        numJuage = int.TryParse(trumpNum, out trumpNumber);
                    }
                    else if (numJuage) 
                    { 
                        trumps[i] = trumpNumber;
                        break;
                    }
                }
            }
        }
    }
}
