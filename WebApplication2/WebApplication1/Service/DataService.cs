using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Service
{
    public class DataService
    {
        public List<Models.Album> LoadAllAlbum()
        {
            List<Models.Album> list = new List<Models.Album>();


            var item = new Models.Album();

            item.Genre = "1103105306";
            item.Title = "劉郁心";
            item.Price = 8;

            list.Add(item);

            var item2 = new Models.Album();

            item2.Genre = "1103105322";
            item2.Title = "陳怡君";
            item2.Price = 20;
            list.Add(item2);

            var item3 = new Models.Album();

            item3.Genre = "1103105327";
            item3.Title = "李偲瑋";
            item3.Price = 20;
            list.Add(item3);

            var item4 = new Models.Album();

            item4.Genre = "1103105344";
            item4.Title = "林佑宗";
            item4.Price = 20;
            list.Add(item4);

            return list;
        }

    }
}