using System;/*< Подключается область имен "System"*/

class TheClass //! Обьявляется класс TheClass
{
    public int x; //! Обьявляется переменная
}

struct TheStruct //! Обьявляется структура TheStruct
{
    public int x; //! Обьявляется переменная
}

class TestClass //! Обьявляется класс TestClass
{
    public static void structtaker(TheStruct s) //! Обьявляется функция класса TestClass
    {
        s.x = 5;//! Элементу структуры s присваивается значение
    }
    public static void classtaker(TheClass c) //! Обьявляется функция класса TestClass
    {
        c.x = 5;//! Элементу класса c присваивается значение
    }
    public static void Main() //! Обьявляется функция класса TestClass
    {
        TheStruct a = new TheStruct(); //! Создается экземпляр структуры TheStruct
        TheClass b = new TheClass();//! Создается экземпляр класса TheClass
        a.x = 0;//! Элементу структуры а присваивается значение
        b.x = 0;//! Элементу класса b присваивается значение
        structtaker(b);//! Вызов функции класса TestClass
        classtaker(a);//! Вызов функции класса TestClass
        Console.WriteLine("b.x = {0}", b.x);
        //! Вызов консоли и вывод результата
        Console.WriteLine("a.x = {0}", a.x);
        //! Вызов консоли и вывод результата
    }
    
}

