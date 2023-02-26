using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public enum ItemType { Beer, Wine, Spirit }
        public int ItemStock { get; set; }    // menu item 
        public double ItemPrice { get; set; }

        public ItemType itemType { get; set; }
    }
}
