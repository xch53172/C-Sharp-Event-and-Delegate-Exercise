using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Event_and_Delegate_Exercise
{
    public class GoldMembership
    {
        public void OnForumNotified(object source, ForumEventArgs args)
        {
            Console.WriteLine($"黃金會員您好! 討論區有新的文章:{args.Article.ArticleTitle} ,只需支付少許費用即可觀看最新內容!");
        }
    }
}
