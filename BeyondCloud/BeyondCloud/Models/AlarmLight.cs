﻿using CommunityToolkit.Mvvm.ComponentModel;
using BeyondCloud.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondCloud.Models
{
   public partial  class AlarmLight:LowerComputerBase
    {
        [ObservableProperty]
        AlarmState state;
    }
}
