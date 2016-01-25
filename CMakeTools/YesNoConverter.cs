﻿/* ****************************************************************************
 * 
 * Copyright (C) 2012-2016 by David Golub.  All rights reserved.
 * 
 * This software is subject to the Microsoft Reciprocal License (Ms-RL).
 * A copy of the license can be found in the License.txt file included
 * in this distribution.
 * 
 * You must not remove this notice, or any other, from this software.
 * 
 * **************************************************************************/

using System.Collections.Generic;

namespace CMakeTools
{
    class YesNoConverter : EnumToDisplayNameConverter<bool>
    {
        private static readonly Dictionary<bool, string> _map =
            new Dictionary<bool, string>()
        {
            { true, CMakeStrings.Yes },
            { false, CMakeStrings.No }
        };

        public YesNoConverter()
            : base(_map) {}
    }
}
