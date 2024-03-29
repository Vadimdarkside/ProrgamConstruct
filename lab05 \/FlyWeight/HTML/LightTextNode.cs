﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.HTML
{
    public class LightTextNode : LightNode
    {
        public string Content { set; get; }
        public LightTextNode(string text) {
            this.Content = text;
        } 
        public LightTextNode(LightTextNode origin)
        {
            this.Content = origin.Content;
        }

        public override string GetContent()
        {
            return $"{Content}\n";
        }
    }
}
