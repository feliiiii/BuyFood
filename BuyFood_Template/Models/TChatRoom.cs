﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BuyFood_Template.Models
{
    public partial class TChatRoom
    {
        public int CChatRoomId { get; set; }
        public int? CMemberId { get; set; }
        public string CContent { get; set; }
        public string CMessageTime { get; set; }
        public DateTime? CSaveTime { get; set; }

        public virtual TMember CMember { get; set; }
    }
}