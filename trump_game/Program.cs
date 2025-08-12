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

            //入力した4つのトランプのカードの番号を確認し、判定する
            if (trumps[0] == trumps[1] && trumps[0] == trumps[2] && trumps[0] == trumps[3])
            {
                Console.WriteLine("フォーカード");
            }
            else if (trumps[0] == trumps[1] && trumps[0] == trumps[2] && trumps[0] != trumps[3] || trumps[1] == trumps[2] && trumps[1] == trumps[3] && trumps[1] != trumps[0] || trumps[2]  == trumps[0] && trumps[2] == trumps[3] && trumps[2] != trumps[1] || trumps[3] == trumps[0] && trumps[3] == trumps[1] && trumps[3] != trumps[2])
            {
                Console.WriteLine("スリーカード");
            }
            else if (trumps[0] == trumps[1] && trumps[2] == trumps[3] || trumps[0] == trumps[3] && trumps[1] == trumps[2] || trumps[0] == trumps[2] && trumps[1] == trumps[3])
            {
                Console.WriteLine("ツーペア");
            }
            else if (trumps[0] == trumps[1] && trumps[0] != trumps[2] && trumps[0] != trumps[3] || trumps[1] == trumps[2] && trumps[1] != trumps[3] && trumps[1] != trumps[0] || trumps[2] == trumps[3] && trumps[2] != trumps[1] && trumps[2] != trumps[0] || trumps[0] == trumps[3] && trumps[0] != trumps[1] && trumps[0] != trumps[2] || trumps[0] == trumps[2] && trumps[0] != trumps[1] && trumps[0] != trumps[3] || trumps[1] == trumps[3] && trumps[1] != trumps[0] && trumps[1] != trumps[2])
            {
                Console.WriteLine("ワンペア");
            }
            else
            {
                Console.WriteLine("ノーペア");
            }

            Console.ReadLine();

            //改めて判定結果を出力
            Console.WriteLine("判定結果");
            if (trumps[0] == trumps[1] && trumps[0] == trumps[2] && trumps[0] == trumps[3])
            {
                Console.WriteLine($"一つ目のトランプの数値:{trumps[0]}");
                Console.WriteLine($"二つ目のトランプの数値:{trumps[1]}");
                Console.WriteLine($"三つ目のトランプの数値:{trumps[2]}");
                Console.WriteLine($"四つ目のトランプの数値:{trumps[3]}");
                Console.WriteLine("4つの数値が全て同じなのでフォーカード");
            }
            else if (trumps[0] == trumps[1] && trumps[0] == trumps[2] && trumps[0] != trumps[3] || trumps[1] == trumps[2] && trumps[1] == trumps[3] && trumps[1] != trumps[0] || trumps[2] == trumps[0] && trumps[2] == trumps[3] && trumps[2] != trumps[1] || trumps[3] == trumps[0] && trumps[3] == trumps[1] && trumps[3] != trumps[2])
            {
                Console.WriteLine($"一つ目のトランプの数値:{trumps[0]}");
                Console.WriteLine($"二つ目のトランプの数値:{trumps[1]}");
                Console.WriteLine($"三つ目のトランプの数値:{trumps[2]}");
                Console.WriteLine($"四つ目のトランプの数値:{trumps[3]}");
                Console.WriteLine("4つの内、3つの数値が同じなのでスリーカード");
            }
            else if (trumps[0] == trumps[1] && trumps[2] == trumps[3] || trumps[0] == trumps[3] && trumps[1] == trumps[2] || trumps[0] == trumps[2] && trumps[1] == trumps[3])
            {
                Console.WriteLine($"一つ目のトランプの数値:{trumps[0]}");
                Console.WriteLine($"二つ目のトランプの数値:{trumps[1]}");
                Console.WriteLine($"三つ目のトランプの数値:{trumps[2]}");
                Console.WriteLine($"四つ目のトランプの数値:{trumps[3]}");
                Console.WriteLine("4つの内、2つの数値が綺麗に2つ揃っているのでツーペア");
            }
            else if (trumps[0] == trumps[1] && trumps[0] != trumps[2] && trumps[0] != trumps[3] || trumps[1] == trumps[2] && trumps[1] != trumps[3] && trumps[1] != trumps[0] || trumps[2] == trumps[3] && trumps[2] != trumps[1] && trumps[2] != trumps[0] || trumps[0] == trumps[3] && trumps[0] != trumps[1] && trumps[0] != trumps[2] || trumps[0] == trumps[2] && trumps[0] != trumps[1] && trumps[0] != trumps[3] || trumps[1] == trumps[3] && trumps[1] != trumps[0] && trumps[1] != trumps[2])
            {
                Console.WriteLine($"一つ目のトランプの数値:{trumps[0]}");
                Console.WriteLine($"二つ目のトランプの数値:{trumps[1]}");
                Console.WriteLine($"三つ目のトランプの数値:{trumps[2]}");
                Console.WriteLine($"四つ目のトランプの数値:{trumps[3]}");
                Console.WriteLine("4つの内、2つの数値が同じなのでワンペア");
            }
            else
            {
                Console.WriteLine($"一つ目のトランプの数値:{trumps[0]}");
                Console.WriteLine($"二つ目のトランプの数値:{trumps[1]}");
                Console.WriteLine($"三つ目のトランプの数値:{trumps[2]}");
                Console.WriteLine($"四つ目のトランプの数値:{trumps[3]}");
                Console.WriteLine("4つの内、どの数値も同じじゃないのでノーペア");
            }

            Console.ReadLine();
        }
    }
}
