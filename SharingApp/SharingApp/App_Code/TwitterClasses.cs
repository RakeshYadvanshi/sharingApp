using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SharingApp.App_Code
{
    namespace TwitterClasses
    {
        public class TwitterFollowersServer
        {
            public long[] ids { get; set; }
            public int next_cursor { get; set; }
            public string next_cursor_str { get; set; }
            public int previous_cursor { get; set; }
            public string previous_cursor_str { get; set; }
        }
        class TwitterFollowersClient
        {
            private Dictionary<long, bool> _twitterFollowers;

            public Dictionary<long, bool> TwitterFollowers
            {
                get { return _twitterFollowers; }
                set { _twitterFollowers = value; }
            }

            public void Add(KeyValuePair<long, bool> entry)
            {
                _twitterFollowers.Add(entry.Key, entry.Value);
            }
        }
    }
}