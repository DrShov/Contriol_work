Console.WriteLine("Введите слова/сочетания символов для программы (каждое с новой строки):");

string[] array = new string[5];
string[] arraySecond = new string[5];
int count = 0;

while(count < array.Length)
{
    string s = Console.ReadLine();
    
        if (s.Length <= 3)
        {
            arraySecond[count] = s;
        }

    array[count] = s;

    count++;
}

Console.WriteLine("Предложенный массив из слов/сочетания символов: " + array[0] + " " + array[1] + " " + array[2] + " " + array[3] + " " + array[4]);
Console.WriteLine("Отсортированный массив согласно условию задачи: " + arraySecond[0] + " " + arraySecond[1] + " " + arraySecond[2] + " " + arraySecond[3] + " " + arraySecond[4]);


