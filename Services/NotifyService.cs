using System;
using System.Threading.Tasks;

namespace cam.Services
{
    public class NotifyService
    {
        // Can be called from anywhere
        public async Task Delete()
        {
            if (NotifyDelete != null)
            {
                await NotifyDelete.Invoke();
            }
        }
        public void OnChange(string arg)
        {
            if (NotifyChange != null)
            {
                NotifyChange(arg);
            }
        }

        public event Func<Task> NotifyDelete;
        public event Action<string> NotifyChange;
    }
}