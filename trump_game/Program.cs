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
            //繰り返し遊べるようにwhile文でくくる
            while (true) 
            {
                //まずはタイトル表示からの1～4の数字を4回分入力する
                Console.WriteLine("**トランプゲーム**");
                Console.WriteLine("まずは1～13の値をランダムで入れてくね！");

                //配列を用意
                int[] trumps = new int[4];

                //ランダム関数を用意(範囲は1～13まで)
                Random rnd = new Random();

                for (int i = 0; i < 4; i++)
                {
                    //数字のデータを格納する変数を用意
                    int trumpNumber = rnd.Next(1, 13);
                    trumps[i] = trumpNumber;

                    Console.WriteLine($"{i + 1}枚目のトランプ数値:{trumps[i]}");
                    Console.WriteLine();
                }

                //入力した4つのトランプのカードの番号を確認し、判定する
                if (trumps[0] == trumps[1] && trumps[0] == trumps[2] && trumps[0] == trumps[3])
                {
                    Console.WriteLine("フォーカード");
                }
                else if (trumps[0] == trumps[1] && trumps[0] == trumps[2] && trumps[0] != trumps[3] || trumps[1] == trumps[2] && trumps[1] == trumps[3] && trumps[1] != trumps[0] || trumps[2] == trumps[0] && trumps[2] == trumps[3] && trumps[2] != trumps[1] || trumps[3] == trumps[0] && trumps[3] == trumps[1] && trumps[3] != trumps[2])
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

                Console.WriteLine();
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

                Console.WriteLine();
                Console.ReadLine();

                Console.WriteLine("もう一度、遊んでみる?");
                Console.Write("(はい→1 いいえ→0) > ");
                string selectPlay = Console.ReadLine();
                int selectPlayNum;

                bool selectJuage = int.TryParse(selectPlay, out selectPlayNum);
                while(true)
                {
                    if(!selectJuage || selectPlayNum < 0 || selectPlayNum > 1)
                    {
                        Console.WriteLine("入力範囲外なので、もう一度入力してください");
                        Console.WriteLine("もう一度、遊んでみる?");
                        Console.Write("(はい→1 いいえ→0) > ");
                        selectPlay = Console.ReadLine();
                        selectJuage = int.TryParse(selectPlay, out selectPlayNum);
                        Console.WriteLine();
                    }
                    else if(selectJuage)
                    {
                        Console.WriteLine();
                        break;
                    }
                }

                if(selectPlayNum == 0)
                {
                    Console.WriteLine("OK!また遊ぼうね！");
                    break;
                }
            }
            Console.ReadLine() ;
        }
    }
}
