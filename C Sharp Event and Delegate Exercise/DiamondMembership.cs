using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Event_and_Delegate_Exercise
{
    public class DiamondMembership
    {
        public void OnForumNotified(object source, ForumEventArgs args)
        {
            Console.WriteLine($"鑽石會員您好! 討論區有新的文章:{args.Article.ArticleTitle} ,您可免費瀏覽所有最新內容!");
        }
    }
}
