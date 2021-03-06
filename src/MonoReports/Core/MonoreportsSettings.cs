// 
// MonoreportsSettings.cs
//  
// Author:
//       Tomasz Kubacki <tomasz (dot) kubacki (at) gmail (dot ) com>
// 
// Copyright (c) 2011 Tomasz Kubacki
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using MonoReports.Model;

namespace MonoReports.Core
{
	public class MonoreportsSettings
	{
		
		internal static bool debugMode;
		public bool DebugMode {
			get {
				return debugMode; }
			
			set { 
				debugMode = value; 
				Extensions.CairoExtensions.CairoExtensions.DebugTextBlock = debugMode;
			}
		}
		
		
		internal static UnitType unit = UnitType.px;
		public  UnitType Unit {
			get { return unit; }
			
			set { 
				unit = value;				
			}
		}
		
		
			
	}
	
	
	
	public static class MonoreportsExtensions {
		
		public static string ToUnitString(this double val) {
			
			switch (MonoreportsSettings.unit) {			
			case UnitType.mm:
				return String.Format("{0:0.00}mm", val.Tomm());
			case UnitType.cm:
				return String.Format("{0:0.00}cm", val.Tocm());
			case UnitType.inch:
				return String.Format("{0:0.00}in", val.Toinch());
			case UnitType.pt:
				return String.Format("{0:0.00}pt", val.Topt());
			case UnitType.px :
				return String.Format("{0:0.00}px", val);
			default:	
				return val.ToString();
			}
					
		}
	}
}

