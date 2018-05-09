﻿
namespace HoloLens.DevicePortal.Api.Holographic.Perception.SurfaceReconstruction
{
    using System.Runtime.Serialization;

    public enum TrackingState
    {
        [EnumMember(Value = "unavailable")]
        Unavailable = 0,

        [EnumMember(Value = "orientation only")]
        OrientationOnly = 1,

        [EnumMember(Value = "activating")]
        Activating = 2,

        [EnumMember(Value = "active")]
        Active = 3,

        [EnumMember(Value = "inhibited")]
        Inhibited = 4
    }
}
