using System;
using System.Collections.Generic;

namespace _2_Indexers
{
    public class HttpCookie
    {
        private Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public void SetItem(string key, string value)
        {

        }

        public string GetItem(string key)
        {
            return key;
        }
        public string this[string Key]
        {
            get
            {
                return _dictionary[Key];
            }
            set
            {
                _dictionary[Key] = value;
            }
        }
    }
}
