using System.Collections.Generic;

namespace ObserverPattern
{
    // KONKRETNY SUBJECT
    public class HenryCavill : ICelebrity
    {
        private readonly List<IFan> _fans = new List<IFan>();
        private string _tweet;                                      
        
        public HenryCavill(string tweet)
        {
            _tweet = tweet;
        }

        public string FullName => "Henry Cavill";
        public string Tweet
        {
            get
            {
                return _tweet;
            }

            set
            {
                Notify(value);
            }
        }

        public void AddFollower(IFan fan) {
            _fans.Add(fan);
        }

        public void RemoveFollower(IFan fan) {
            _fans.Remove(fan);
        }

        public void Notify(string tweet)
        {
            _tweet = tweet;
            foreach (var fan in _fans)
            {
                fan.Update(this);
            }
        }
    }
}
