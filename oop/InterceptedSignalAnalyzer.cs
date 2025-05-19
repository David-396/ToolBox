using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Signal
    {
        private string rawMessage;
        private DateTime timestamp;

        public Signal(string rawMessage, DateTime timestamp)
        {
            this.rawMessage = rawMessage;
            this.timestamp = timestamp;
        }

        public string GetCleanMessage()
        {
            return this.rawMessage.ToLower();
        }

        public bool ContainsWord(string word)
        {
            string[] split_msg = this.rawMessage.Split(' ');
            foreach (string str in split_msg)
            {

                if(str == word)
                {
                    return true;
                }
            }
            return false;
        }

        public DateTime GetTimestamp()
        {
            return timestamp;
        }
    }

    class ThreatDictionary
    {
        private List<string> keywords;

        public void AddKeyword(string keyword)
        {
            this.keywords.Add(keyword);
        }

        public void RemoveKeyword(string keyword)
        {
            this.keywords.Remove(keyword);
        }

        public List<string> GetAllKeywords()
        {
            return this.keywords;
        }

        public bool IsThreat(string message)
        {
            string[] splitMsg = message.Split(' ');
            foreach(string word in splitMsg)
            {
                if (this.keywords.Contains(word))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
