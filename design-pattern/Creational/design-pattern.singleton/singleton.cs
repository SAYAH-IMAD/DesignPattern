namespace design_pattern.singleton
{
    public class singleton
    {
        private static singleton _instance = null;
        private static readonly object _lock = new object();
        private singleton() { }

        public static singleton Instance {
            get 
            {
                if (_instance is null)
                    lock(_lock)
                        if (_instance is null)
                            _instance = new singleton();
                return _instance;
            } 
        }
    }
}