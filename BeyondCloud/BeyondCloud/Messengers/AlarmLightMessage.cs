using CommunityToolkit.Mvvm.Messaging.Messages;
using BeyondCloud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondCloud.Messengers
{
    public class AlarmLightMessage : ValueChangedMessage<AlarmLight>
    {
        public AlarmLightMessage(AlarmLight value) : base(value)
        {
        }
    }
}
