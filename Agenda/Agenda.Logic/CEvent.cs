﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaLogic
{
    public class CEvent
    {
        public int id { set; get; }
        public string name { set; get; }
        public DateTime date { set; get; }
        public DateTime time { set; get; }
        public string description { set; get; }

        /// <summary>
        /// Class constructor
        /// </summary>
        public CEvent()
        {
            id = default;
            name = "";
            date = DateTimePicker.MinimumDateTime;
            time = DateTimePicker.MinimumDateTime;
            description = "";
        }
    }
}
