// Based on https://github.com/sstixrud/WeaponCore/blob/master/Data/Scripts/WeaponCore/Support/Spawn.cs
// Copyright
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// That the Software is used exclusively for the game Space Engineers created by Keen Software House for non-commercial purposes. The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using Sandbox.ModAPI;
using VRage.Utils;

namespace SERO
{
    public static class Log
    {
        public static void Error(Exception exception)
        {
            Line($"{exception.StackTrace} {exception.Source} {exception.TargetSite} {exception.Message}");
        }
        public static void Line(string v)
        {
            MyLog.Default.WriteLine(v);
            MyAPIGateway.Utilities.ShowMessage("LOG", v);
        }
    }
}