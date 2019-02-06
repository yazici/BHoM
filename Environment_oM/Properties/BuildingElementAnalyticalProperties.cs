﻿/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2018, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BH.oM.Environment.Interface;

namespace BH.oM.Environment.Properties
{
    public class BuildingElementAnalyticalProperties : IBHoMExtendedProperties
    {
        public double Altitude { get; set; } = 0;
        public double AnltitudeRange { get; set; } = 0;
        public double Inclination { get; set; } = 0;
        public double InclinationRange { get; set; } = 0;
        public double Orientation { get; set; } = 0;
        public double GValue { get; set; } = 0;
        public double LTValue { get; set; } = 0;
        public double UValue { get; set; } = 0;
    }
}