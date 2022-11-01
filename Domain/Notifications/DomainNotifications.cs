using Domain.Interfaces.Bus;
using System;

namespace Domain.Notifications
{
    public class DomainNotification : IMediatorEventBase
    {
        public Guid DomainNotificationId { get; private set; }
        public string Key { get; private set; }
        public string Value { get; private set; }
        public int Version { get; private set; }
        public Exception Exception { get; private set; }

        public DomainNotification(string key, string value, Exception exception = null)
        {
            DomainNotificationId = Guid.NewGuid();
            Version = 1;
            Key = key;
            Value = value;
            Exception = exception;
        }
    }
}
