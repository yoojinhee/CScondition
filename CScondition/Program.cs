﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CScondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력 :");
            var input = int.Parse(Console.ReadLine());

            /*if (input % 2 == 0)
            {
                Console.WriteLine("짝수");
            }else if (input % 2 == 1)
            {
                Console.WriteLine("홀수");
            }*/
            switch (input % 2)
            {
                case 0:
                    Console.WriteLine("짝수");
                    break;
                case 1:
                    Console.WriteLine("홀수");
                    break;
            }
            Console.WriteLine(input % 2 == 0 ? "짝수" : "홀수");
            
            //현재 시간 구하기
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            //오전 오후 구분
            if (DateTime.Now.Hour < 11)
            {
            Console.WriteLine("아침 먹을 시간입니다");
            }
            else if(DateTime.Now.Hour<15)
            {
                Console.WriteLine("점심 먹을 시간입니다");
            }
            else
            {
                Console.WriteLine("저녁 먹을 시간입니다");
            }
            Console.Write("이번달은 몇 월 인가요:");
            int input2 = int.Parse(Console.ReadLine());
            switch (input2)
            {
                case 12:case 1:case 2:
                    Console.WriteLine("겨울"); break;
                case 3: case 4: case 5:
                    Console.WriteLine("봄"); break;
                case 6: case 7: case 8:
                    Console.WriteLine("여름"); break;
                case 9:case 10: case 11:
                    Console.WriteLine("봄"); break;
                default:
                    Console.WriteLine("당신이 사는곳은 혹시 행성?!");break;
            }
            Console.Write("입력");
            String line = Console.ReadLine();
            if(line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요");
            }
            else
            {
                Console.WriteLine("인사 똑바로 해^^");
            }
            ConsoleKeyInfo info = Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("위로 이동");break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("아래로 이동"); break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("왼쪽으로 이동"); break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("오른쪽으로 이동"); break;
                default:Console.WriteLine("다른 키를 누르셨습니다");break;
            }
            switch (info.KeyChar)
            {
                /*case (char)38:
                    Console.WriteLine("위로 이동");break;*/
                case '가':
                    Console.WriteLine("가 입력하셨습니다");break;
                default:
                    Console.WriteLine("다른 키를 누르셨습니다"); break;

            }
        }
    }
}