// This file is part of iRacingSDK.
//
// Copyright 2020 Merlin Cooper
// https://github.com/vipoo/iRacingSDK.Net
//
// iRacingSDK is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// iRacingSDK is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with iRacingSDK.  If not, see <http://www.gnu.org/licenses/>.

//Sample Car-Position prints every 5 seconds the position of every car on track.

using iRacingSDK;
using iRacingSDK.Support;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Sample
{
    public static class SampleDriverList
    {
        public static void Sample()
        {
            var iracing = new iRacingConnection();
            var firstDataSample = iracing.GetDataFeed().First();

            foreach (var driverInfo in firstDataSample.SessionData.DriverInfo.CompetingDrivers)
            {
                Trace.WriteLine("AbbrevName: {0}, TeamName: {1}, UserName: {2}".F(driverInfo.AbbrevName, driverInfo.TeamName, driverInfo.UserName));
            }

            Thread.Sleep(10000);
            }
        }
    }

