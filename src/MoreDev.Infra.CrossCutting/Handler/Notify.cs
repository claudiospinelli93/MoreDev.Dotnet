using System.Collections.Generic;
using System.Linq;
using MoreDev.Infra.CrossCutting.Dto.Handler;

namespace MoreDev.Infra.CrossCutting.Handler
{
    public class Notify : INotify
    {
        private readonly List<NotifyDto> _notifications;

        public Notify()
        {
            _notifications = new List<NotifyDto>();
        }

        public void Handle(NotifyDto notify)
        {
            _notifications.Add(notify);
        }

        public List<NotifyDto> GetNotifications()
        {
            return _notifications;
        }

        public bool AnyNotifications()
        {
            return _notifications.Any();
        }
    }
}
