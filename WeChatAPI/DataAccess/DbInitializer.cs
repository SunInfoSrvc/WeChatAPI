using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeChatAPI.Models;

namespace WeChatAPI.DataAccess
{
    public static class DbInitializer
    {
        public static void Initialize(SunInfoContext context)
        {
            context.Database.EnsureCreated();

            if (context.Apps.Any())
            {
                return;  
            }

            var apps = new App[]
            {
                new App{Id=1,Name="周末逛西安", Url="xian"},
                new App{Id=2,Name="秦岭猕猴桃", Url="kiwi"},
                new App{Id=3,Name="聚会小游戏", Url="game"},

                new App{Id=4,Name="约饭小助手", Url="party"},
                new App{Id=5,Name="征信小助手", Url="credit"},
                new App{Id=6,Name="验房小助手", Url="house"},

                new App{Id=7,Name="Scrum Pocker", Url="scrum"},
            };

            foreach (App a in apps)
            {
                context.Apps.Add(a);
            }
            context.SaveChanges();

        }
    }
}

