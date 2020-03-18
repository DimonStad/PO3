namespace _1_lab
{
    /// <summary>
    /// Класс для чтения txt файла
    /// </summary>
    public class Reader
    {
        private string path;
        private string data;
        /// <summary>
        ///Constructor
        /// </summary>
        /// <param name="_path">File path</param>
        /// <param name="_data">String that will writed to the file</param>
        public Reader(string _path,string _data=null)
        {
            this.path = _path;
            this.data=_data;
        }
        /// <summary>
        ///Constructor without args
        /// </summary>
        public Reader()
        {
            this.path=null;
            this.data=null;
        }
        /// <summary>
        ///Set file path
        /// </summary>
        /// <param name="_path">File path</param>
        public void Path(string _path)
        {
            this.path = _path;
        }
        /// <summary>
        /// String that will be writed to file
        /// </summary>
        /// <param name="_data">String</param>
        public void Data(string _data)
        {
            this.data = _data;
        }
                /// <summary>
        ///Confert txt file to string
        /// </summary>
        /// <returns></returns>
        public string FileToString()
        {
            string s = System.IO.File.ReadAllText(path).Replace("\n", " ");
            return s;
        }


    }
}