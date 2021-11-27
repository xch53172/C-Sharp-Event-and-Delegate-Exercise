// See https://aka.ms/new-console-template for more information
using C_Sharp_Event_and_Delegate_Exercise;

Article article = new Article() { ArticleTitle = "帥氣跳蚤蛋已在開發代號「帥哥」的遊戲新作,傳言前作帥到爆表的主角將會回歸!?" };  //要發送的資料
Forum forum = new Forum();  //被觀察者
GoldMembership goldMembership = new GoldMembership();   //觀察者
DiamondMembership diamondMembership = new DiamondMembership();  //觀察者

forum.ForumNotified += goldMembership.OnForumNotified;  //訂閱事件
forum.ForumNotified += diamondMembership.OnForumNotified;   //訂閱事件
forum.Notified(article);  //發送通知

