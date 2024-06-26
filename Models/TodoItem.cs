﻿using System.ComponentModel.DataAnnotations;

namespace To_Do_List_Application_Back_End.Models
{
    public class TodoItem
    {
        [Key]
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
