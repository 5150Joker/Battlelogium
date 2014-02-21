﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Battlelogium.Core;
using Battlelogium.Core.UI;
namespace Battlelogium.UI.BF4
{
    public class Battlefield4 : Battlelog
    {
        public Battlefield4(UIWindow battlelogiumWindow)
            : base("http://battlelog.battlefield.com/bf4/", "Battlefield 4", "BF4", "bf4.exe", "00000", "http://localhost/battlelogium/battlelog.bf4.inject.min.js", battlelogiumWindow)
        {
        }
    }
}
