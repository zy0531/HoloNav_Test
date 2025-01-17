﻿/*
* 
* VR Rehab, Inc Confidential
* __________________
* 
*  Copyright 2016 - VR Rehab, Inc
*  All Rights Reserved.
* 
* NOTICE:  All information contained herein is, and remains
* the property of VR Rehab, Inc and its subsidiaries,
* if any.  The intellectual and technical concepts contained
* herein are proprietary to VR Rehab, Inc
* and its subsidiaries and may be covered by U.S. and Foreign Patents,
* patents in process, and are protected by trade secret or copyright law.
* Dissemination of this information or reproduction of this material
* is strictly forbidden unless prior written permission is obtained
* from VR Rehab, Inc.
* contact: smann@virtualrealityrehab.com
*
*/
using VRR.GPSModule;

namespace VRR.HoloNav
{
    public class TelemetryReceievedEventArgs : System.EventArgs
    {
        public TelemetryReceievedEventArgs(ModuleData data)
        {
            Data = data;
        }

        public ModuleData Data { get; private set; }
    }
}
