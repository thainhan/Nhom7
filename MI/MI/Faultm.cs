﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MI
{
    [DataContract]
    public struct CustomFaultMsg
    {
        [DataMember]
        public string Message { get; set; }
    }
}
