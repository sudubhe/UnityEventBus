﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cn.blockstudio.unityeventbus
{
    [AttributeUsage(AttributeTargets.Method)]
    public class Subscriber : Attribute
    {
        public ExecutePriority CallbackPriority { get; set; }

    }

}


