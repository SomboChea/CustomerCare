namespace SMLOGX.Core
{
    public class BaseSystem : IBaseSystem
    {
        public BaseSystem()
        {
        }

        public enum AutoCheck
        {
            SixMonth,
            OneMonth,
            OneWeek
        };

        public static void AlertAt(AutoCheck type, string msg)
        {
        }

        public void Auto()
        {
        }
    }
}