namespace Local
{
    //如果需要任何语句，直接从Word中获取对应的内容
    public class Word
    {
        private static Word _instance;
        public static Word Instance => _instance ?? (_instance = new Word());
        private static string _language;
        
        public static string Langauge 
        {
            get => _language;
            set
            {
                _language = value;
                _instance.ChangeLanguage();                
            }
        }

        public void ChangeLanguage()
        {
            
        }

        private void Load()
        {
            
        }
    }
}