﻿/*
 * Copyright (c) 2022 Proton Technologies AG
 *
 * This file is part of ProtonVPN.
 *
 * ProtonVPN is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * ProtonVPN is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with ProtonVPN.  If not, see <https://www.gnu.org/licenses/>.
 */

using System.Runtime.Serialization;

namespace ProtonVPN.Service.Contract.PortForwarding
{
    [DataContract]
    public enum PortMappingStatusContract
    {
        [EnumMember]
        Stopped = 0,

        [EnumMember]
        Error = 1,

        [EnumMember]
        Starting = 2,

        [EnumMember]
        HelloCommunication = 3,

        [EnumMember]
        DestroyPortMappingCommunication = 4,

        [EnumMember]
        PortMappingCommunication = 5,

        [EnumMember]
        SleepingUntilRefresh = 6
    }
}