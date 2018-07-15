using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerSide.Shared.Models
{
    public class ToDoListItem
    {
        public int ID { get; set; }
        public string Item { get; set; } = "";
    }
}
