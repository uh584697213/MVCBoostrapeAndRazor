﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Razor.Models
{
    public class Cards
    {
        public int Id { get; set; }
        public string Name { get; set; }    //名字
        public string Brief { get; set; }   //簡介
        public string Photo { get; set; }   //照片
        public string WikiUrl { get; set; } //Wiki的Url
    }
}