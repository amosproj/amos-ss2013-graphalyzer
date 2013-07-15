﻿/*
 * Copyright (c) 2006-2009 by Christoph Menzel, Daniel Birkmaier, 
 * Maximilian Madeja, Farruch Kouliev, Stefan Zoettlein
 *
 * This file is part of the GraphalyzerPro application.
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Affero General Public License for more details.
 *
 * You should have received a copy of the GNU Affero General Public
 * License along with this program. If not, see
 * <http://www.gnu.org/licenses/>.
 */

using System.Globalization;
using System.Threading;
using System.Windows;
using ReactiveUI;

namespace GraphalyzerPro
{
    internal static class Bootstrapper
    {
        internal static void InitializeRxBackingFieldNameConventions()
        {
            RxApp.GetFieldNameForPropertyNameFunc = delegate(string name)
                {
                    var nameAsArray = name.ToCharArray();
                    nameAsArray[0] = char.ToLower(nameAsArray[0], CultureInfo.InvariantCulture);
                    return '_' + new string(nameAsArray);
                };
        }

        internal static void ShowSplashScreen()
        {
            var splashScreen = new SplashScreen("Icons\\GraphalyzerPro.png");
            splashScreen.Show(true, true);
            Thread.Sleep(500);
        }
    }
}