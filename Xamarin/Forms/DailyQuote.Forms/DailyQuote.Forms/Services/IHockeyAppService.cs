﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyQuote.Forms.Services
{
    public interface IHockeyAppService
    {
        void Register();
        void TrackEvent(string name);
    }
}
