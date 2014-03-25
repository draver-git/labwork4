using System;/*< Подключается область имен "System"*/
struct SimpleStruct  /*< Описание структуры "SimpleStruct"*/
{
    private int xval; //!< Обявление переменной xval
    public int X //!< Обявление переменной X 
    {
        get 
        {
            return xval;
        } //!< Функция взятия переменной
        set 
        {
            if (value < 100)
                xval = value;
        } //!< Функция установки переменной
    }
    public void DisplayX() //! обьявление метода
    {
        Console.WriteLine("The stored value is: {0}", xval);
    }
}

class TestClass /*<Создается класс "TestClass"*/
{
    public static void Main()/*< Вызывается функция "Main"*/
    {
        SimpleStruct ss = new SimpleStruct();//! Создается элемент структуры  "SimpleStruct"
        ss.X = 5; //! Переменной X элемента структуры ss приравнивается значение
        ss.DisplayX(); //! Выводит значение элемента структуры
    }
}

