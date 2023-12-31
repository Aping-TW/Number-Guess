﻿using Extensions;

var answer = 55;

int intUserAnswer = 0;
int MinNumber = 0;
int MaxNumber = 100;


do
{
    Console.WriteLine($"請輸入介於{MinNumber}~{MaxNumber}之間的終極密碼");
    
    var userAnswer = Console.ReadLine();
    
    if (int.TryParse(userAnswer,out int intConvertCheck))
    {
         intConvertCheck = userAnswer.ToInt();
    }
    else
    {
        Console.WriteLine("輸入的值不是數字，請重新輸入。");
        continue;
    }
    
    intUserAnswer = intConvertCheck;
    
    if (answer == intUserAnswer)
    {
        Console.WriteLine("答對了");
    }

    else if (intUserAnswer > MaxNumber || intUserAnswer < MinNumber)
    {
        Console.WriteLine("輸入的值超出範圍，請重新輸入");
    }
    else
    {
        if (intUserAnswer > answer)
        {
            Console.WriteLine($"答錯了，請輸入 {MinNumber} ~ {intUserAnswer} 之間的數值");

            MaxNumber = intUserAnswer;
        }
        else
        {
            Console.WriteLine($"答錯了，請輸入  {intUserAnswer} ~ {MaxNumber} 之間的數值");
            MinNumber = intUserAnswer;
        }

    }

} while (answer != intUserAnswer);



