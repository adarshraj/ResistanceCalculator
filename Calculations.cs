/*
 * Created by SharpDevelop.
 * User: Ads
 * Date: 6/16/2008
 * Time: 11:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace Resistance_Calculator
{
	/// <summary>
	/// Description of Calculations.
	/// </summary>
	public class Calculations
	{
		public Calculations()
		{
		}	
		
		public decimal FinalResistance(decimal currentResistance, decimal percentage, bool action)
		{
		if (action)
			return currentResistance + ((currentResistance * percentage)/100);
		else
			return currentResistance - ((currentResistance * percentage)/100);
		}
		
		public decimal ResistanceInKilo(decimal currentValue)
		{
			return (currentValue/1000);
		}
		
		public decimal ResistanceInMega(decimal currentValue)
		{
			return (currentValue/1000000);
		}

	}
}
