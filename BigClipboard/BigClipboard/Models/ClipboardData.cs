﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigClipboard.Models
{
    [Serializable]
    public class ClipboardData
    {
        public Guid Id { get; set; }
        public DateTime CreateTime { get; set; }
        public string MD5 { get; set; }
        public string Text { get; set; }
        public Image Image { get; set; }
        public byte[] RichText { get; set; }
        public long Size { get; set; }
    }
}
