//Данный метод не возвращает и не принимает переменные
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();// вызов метода

//Данный метод не возращает, но принимает переменные
void Method2(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
    Console.WriteLine(msg);
    i++;
    }
}
Method2("Text", 4); //вызов метода
Method2(count:4, msg:"TEST"); // если выразить входящие переменные явно, то их можно располагать в любом порядке

//Данный метод возвращает, но не принимает значения

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3(); //вызов метода
Console.WriteLine(year);

//Данный метод возращает одно значение и принимает значения

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(text:"пушкагонка",count:5); //вызов метода
Console.WriteLine(res);

//данный метод аналгиче предыдущему, только с циклом for

string Method4For(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string resFor = Method4For(text:"капушкагон",count:3); //вызов метода
Console.WriteLine(resFor);

//пример вложенного цикла
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine("-------------");
}

//

