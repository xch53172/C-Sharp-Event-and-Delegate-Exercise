using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Event_and_Delegate_Exercise
{
    public class Forum
    {
        public delegate void ForumNotifyEventHandler(object source, ForumEventArgs args);
        public event ForumNotifyEventHandler ForumNotified;
        public void Notified(Article forum)
        {
            Console.WriteLine("準備發送通知.");
            OnForumNotified(forum);
        }
        
        public virtual void OnForumNotified(Article forum)
        {
            if (forum != null)
                ForumNotified(this, new ForumEventArgs() { Article= forum });
        }

    }
}
