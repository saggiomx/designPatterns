﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.Liskov
{
    public class Square : Rectangle
    {
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }
        public override int Height
        {
            set { base.Height = base.Width = value; }
        }
    }
}
