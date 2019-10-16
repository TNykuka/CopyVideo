using System.Collections.Generic;

namespace _6_InterfacesAndPolymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannel;

        public VideoEncoder()
        {
            _notificationChannel = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // Video encoding logic
            // ...

            foreach (var channel in _notificationChannel)
                channel.Send(new Message());
        }
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannel.Add(channel);
        }
    }
}
