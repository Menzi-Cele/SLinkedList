﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyKaraoke
{
    class CustomNode
    {
        public CustomNode Next;
        public string data;
        
        public CustomNode()
        {

        }

        public CustomNode(string data)
        {
            this.data = data;
        }
    }
}
