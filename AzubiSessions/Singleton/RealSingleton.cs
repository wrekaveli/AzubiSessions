namespace Singleton
{
    public class RealSingleton
    {
        private static RealSingleton _instance;

        private RealSingleton()
        {

        }

        public static RealSingleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new RealSingleton();
            }

            return _instance;
        }
    }
}
