namespace SMLOGX.Core
{
    public class AutoAlert : IAutoAlert
    {
        private string msg;
        private string when;

        public void Alert(string message, string when)
        {
            this.msg = message;
            this.when = when;
        }
    }
}