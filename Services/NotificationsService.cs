using System.Collections.Generic;
using System.Threading.Tasks;
using cam.Models;
using cam.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace cam.Services
{
    public class NotificationsService : INotificationsService

    {
        private readonly ApplicationDbContext context;

        public NotificationsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Notification>> Get()
        {
            return await context.Notifications.ToListAsync();
        }

        public async Task<Notification> Get(string period)
        {
            return await context.Notifications.Where(n => n.Period.ToLower() == period.ToLower()).FirstOrDefaultAsync();
        }


        public async Task<Notification> Insert(Notification notification)
        {
            var not = await context.Notifications.Where(n => n.Period.ToLower() == notification.Period.ToLower()).FirstOrDefaultAsync();
            if(not != null)
            {
                not.Content = notification.Content;
                context.Notifications.Update(not);
            }
            else
            {
                await context.Notifications.AddAsync(notification);
            }
            await context.SaveChangesAsync();

            return notification;
        }
    }

    public interface INotificationsService
    {
        Task<List<Notification>> Get();
        Task<Notification> Get(string period);
        Task<Notification> Insert(Notification notification);
    }
}