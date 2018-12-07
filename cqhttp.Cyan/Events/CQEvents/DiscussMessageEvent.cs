using cqhttp.Cyan.Events.Base;
using cqhttp.Cyan.Messages;
using Newtonsoft.Json.Linq;

namespace cqhttp.Cyan.Events.CQEvents {
    public class DiscussMessageEvent : MessageEvent {
        long discuss_id;
        public DiscussMessageEvent (
                long time,
                Message message,
                Sender sender,
                int message_id,
                long discuss_id
            ):
            base (time, Enums.MessageType.group_, sender, message, message_id) {
                this.discuss_id = discuss_id;
            }
        public DiscussMessageEvent () : base () { }
    }
}