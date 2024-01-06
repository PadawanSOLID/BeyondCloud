﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondCloud.Models
{
    public partial class Machine : LowerComputerBase
    {
        [ObservableProperty]
        string icon;
    }
}
