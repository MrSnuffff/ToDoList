﻿using SQLite;
using System;

namespace ToDoList
{
    public class item
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string _NameTask { get; set; }
        public DateTime _DP_Time_Tesk { get; set; }
        public byte _Time { get; set; }
        public bool _Block { get; set; }


    }
}
