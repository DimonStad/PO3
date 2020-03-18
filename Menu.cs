namespace _1_lab
{
    /// <summary>
    /// Меню
    /// </summary>
    public static class Menu
    {
        
        private const string titleMessage = "\tМеню:\n1) path - изменить путь к файлу;\n2) data - строка для записи;\n3) read - чтение из файла;\n4) write - запись в файл";
        private const string Message = "\tВведите строку:";
         private const string caseMessage = "1) app - записать в конец файла;\n2) rew - перезаписать файл";
         private const string errMessage = "Выберете из списка!";
         /// <summary>
         ///Menu
         /// </summary>
         /// <param name="r">Inputed Reader</param>
        public static void Title(Reader r)
        {
            System.Console.WriteLine(titleMessage);
            int t = System.Convert.ToInt32(System.Console.ReadLine());
            Execute(t,r);
        }
        /// <summary>
        ///Command execute
        /// </summary>
        /// <param name="command">Command</param>
        /// <param name="r">Reader</param>
        private static void Execute(int command, Reader r)
        {
            string temp;
            switch(command)
            {
                case 1:
                System.Console.WriteLine(Message);
                temp =System.Console.ReadLine();
                r.Path(temp);
                break;
                case 2:
               System.Console.WriteLine(Message);
                temp =System.Console.ReadLine();
                r.Data(temp);
                break;
                case 3:
               System. Console.WriteLine(r.FileToString());
               break;
               case 4:
               System. Console.WriteLine(caseMessage);
               int t = System.Convert.ToInt32(System.Console.ReadLine());
               switch (t)
                {
                    case 1:
                    r.AppendFile();
                    break;
                    case 2:
                   r.StringToNewFile();
                   break;
                   default:
                    System. Console.WriteLine(errMessage);
                    break;
               }
               break;
               default:
                System. Console.WriteLine(errMessage);
                break;
            }
            Title(r);
        }
    }
}