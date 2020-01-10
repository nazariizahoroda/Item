using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactEmpeek.Models
{
    public class PageInfo
    {
        public int PageNumber { get; set; } // номер текущей страницы
        public int PageSize { get; set; } // кол-во объектов на странице
        public int TotalItems { get; set; } // всего объектов
        public int TotalPages  // всего страниц
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / PageSize); }
        }
    }
    public class ItemViewModel
    {
        public IEnumerable<Item> Items { get; set; }
        public PageInfo PageInfo { get; set; }
    }
    public class ItemStatisticViewModel
    {
        public IEnumerable<ItemStatistic> ItemStatistic { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
