using System;

namespace _1_lab
{
    class Program
    {
        /// <summary>
        ///Enter-point of program
        /// </summary>
        /// <param name="args">inputed args</param>
        static void Main(string[] args)
        {
            Reader r = new Reader();
            Menu.Title(r);
        }
    }
}
/*СРАВНЕНИЕ ФАЙЛОВ
FC /B [диск1:][путь1]имя_файла1 [диск2:][путь2]имя_файла2 - WINDOWS
$ diff опции файл1 файл2 - LINUX
*/
/*ГОРЯЧИЕ КЛАВИШИ
Ctrl + SHift + A - Блочное комментирование
Ctrl + ` - Открыть терминал
Ctrl + Shift + G - Git
Ctrl + N - Создать новый файл
Ctrl + G - Перейти к строке по номеру
Ctrl + K P - Скопировать путь к заданному файлу
Ctrl + P - Быстрое открытие файла
Ctrl + , - Настройки (пользовательские)
Alt + (Вверз)/(Низ) - Переместить строку вверх/вниз
F8 - перейти к ошибке
Ctrl + H - заменить
*/