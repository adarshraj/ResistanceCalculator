/*
 * Created by SharpDevelop.
 * User: Ads
 * Date: 6/16/2008
 * Time: 6:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Resistance_Calculator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnAbtClick(object sender, System.EventArgs e)
		{
			MessageBox.Show(" Resistance Calculator by Lahar\n ----------------------------------\n Note : If ur third strip is tolerance, select the 3rd strip option. \n Note: Select 'No Color' option for no color tolerance. Not (None)\n --------------------------------------\n It comes with no garantee. Use at own risk. Author is not responsoble for your losses. \n Contact : Laharrush@yahoo.com \n Contact : www.waxcodes.com" );
		}
		
		void BtnCalcClick(object sender, EventArgs e)
		{
			int firstIndex = 0, SecondIndex = 0;
			decimal toleranceIndex = .0M, ohmResult;
			ulong thirdIndex = 0, forthIndex = 0;			
			string  totalResistance;
			Calculations calc = new Calculations();
			
			firstIndex = cbo1.SelectedIndex;
			SecondIndex = cbo2.SelectedIndex;
			
			if(cbo5.SelectedIndex == 1)
				toleranceIndex = 5;
			else if(cbo5.SelectedIndex == 2 )
				toleranceIndex = 10;
			else if(cbo5.SelectedIndex == 3)
				toleranceIndex = 20;
			else if(cbo5.SelectedIndex == 4)
				toleranceIndex = 2;
			else if(cbo5.SelectedIndex == 5)
				toleranceIndex = 1;
			else if(cbo5.SelectedIndex == 6)
				toleranceIndex = 0.1M;
			
		if(cbo1.SelectedIndex >= 0 && cbo2.SelectedIndex >= 0)
		{
			//Resistance wen only two strips are selected
			if(cbo4.SelectedIndex < 1 && cbo5.SelectedIndex < 1)
			{
				decimal thirdStrip = 0.0M;
				
				if(cbo3.SelectedIndex == 12)
					thirdStrip = 0.1M;
				else if (cbo3.SelectedIndex == 13) 
					thirdStrip = 0.01M;
				
				totalResistance = Convert.ToString(firstIndex)+ Convert.ToString(SecondIndex);
				totalResistance = Convert.ToString(Convert.ToDecimal(totalResistance) * thirdStrip);
				txtOhm.Text =  totalResistance;
				txtOhmKilo.Text = Convert.ToString(calc.ResistanceInKilo(Convert.ToDecimal(totalResistance)));
				txtOhmMega.Text = Convert.ToString(calc.ResistanceInMega(Convert.ToDecimal(totalResistance)));

			}
			
			//Resistance when first 3 strips and Tolerance are selected
			else if (cbo4.SelectedIndex < 1) 
			{
				if(cbo5.SelectedIndex >=1)
				{
				switch (cbo3.Text)
				{
					case "Black" : 
									thirdIndex = 0;
									break;
					case "Brown" :
									thirdIndex = 10;
									break;
					case "Red" :
									thirdIndex = 100;
									break;	
					case "Orange" :
									thirdIndex = 1000;
									break;				

					case "Yellow" :
									thirdIndex = 10000;
									break;				

					case "Green" :
									thirdIndex = 100000;
									break;				

					case "Blue" :
									thirdIndex = 1000000;
									break;				

					case "Violet" :
									thirdIndex = 10000000;
									break;				

					case "Gray" :
									thirdIndex = 100000000;
									break;	
					case "White" :
									thirdIndex = 1000000000;
									break;				
						default:
							txtOhm.Text = "i missed";
							break;
				}
				
				//Resistance in Ohm
				thirdIndex = thirdIndex * (ulong)SecondIndex;
				totalResistance = Convert.ToString(firstIndex)+ Convert.ToString(thirdIndex) ;
				txtOhm.Text = totalResistance;
				txtOhmKilo.Text = Convert.ToString(calc.ResistanceInKilo(Convert.ToDecimal(totalResistance)));
				txtOhmMega.Text = Convert.ToString(calc.ResistanceInMega(Convert.ToDecimal(totalResistance)));

				//Minimum Resistance
				ohmResult = calc.FinalResistance(Convert.ToDecimal(totalResistance),toleranceIndex,false);
				txtMinOhm.Text = Convert.ToString(ohmResult);
				txtMinKilo.Text= Convert.ToString(calc.ResistanceInMega(Convert.ToDecimal(ohmResult)));
				txtMinMega.Text = Convert.ToString(calc.ResistanceInMega(Convert.ToDecimal(ohmResult)));
				
				//Maximum Resistance
				ohmResult = calc.FinalResistance(Convert.ToDecimal(totalResistance),toleranceIndex,true);
				txtMaxOhm.Text = Convert.ToString(ohmResult);
				txtMaxKilo.Text= Convert.ToString(calc.ResistanceInMega(Convert.ToDecimal(ohmResult)));
				txtMaxMega.Text = Convert.ToString(calc.ResistanceInMega(Convert.ToDecimal(ohmResult)));
				}
				else
				{
					MessageBox.Show("Select Tolerance");
				}
			}
			
			//Resistance when first 4 strips and Tolerance are selected
			else
			{
				switch (cbo4.Text)
				{
					case "Black" : 
									forthIndex = 0;
									thirdIndex = 0;
									break;
					case "Brown" :
									forthIndex = 10;
									thirdIndex = 1;
									break;
					case "Red" :
									forthIndex = 100;
									thirdIndex  = 2;
									break;	
					case "Orange" :
									forthIndex = 1000;
									thirdIndex = 3;
									break;				

					case "Yellow" :
									forthIndex = 10000;
									thirdIndex = 4;
									break;				

					case "Green" :
									forthIndex = 100000;
									thirdIndex = 5;
									break;				

					case "Blue" :
									forthIndex = 1000000;
									thirdIndex = 6;
									break;				

					case "Violet" :
									forthIndex = 10000000;
									thirdIndex = 7;
									break;				

					case "Gray" :
									forthIndex = 100000000;
									thirdIndex = 8;
									break;	
					case "White" :
									forthIndex = 1000000000;
									thirdIndex = 9;
									break;				
						default:
							txtOhm.Text = "i missed";
							break;
				}
				

				//Resistance in ohm
				forthIndex = forthIndex * thirdIndex;
				totalResistance = Convert.ToString(firstIndex)+ Convert.ToString(SecondIndex) + Convert.ToString(forthIndex);
				txtOhm.Text =  totalResistance;
				txtOhmKilo.Text = Convert.ToString(calc.ResistanceInKilo(Convert.ToDecimal(totalResistance)));
				txtOhmMega.Text = Convert.ToString(calc.ResistanceInMega(Convert.ToDecimal(totalResistance)));

				//Minimum Ohm
				ohmResult = calc.FinalResistance(Convert.ToDecimal(totalResistance),toleranceIndex,false);
				txtMinOhm.Text = Convert.ToString(ohmResult);
				txtMinKilo.Text= Convert.ToString(calc.ResistanceInMega(Convert.ToDecimal(ohmResult)));
				txtMinMega.Text = Convert.ToString(calc.ResistanceInMega(Convert.ToDecimal(ohmResult)));
				
				//Maximum Ohm
				ohmResult = calc.FinalResistance(Convert.ToDecimal(totalResistance),toleranceIndex,true);
				txtMaxOhm.Text = Convert.ToString(ohmResult);
				txtMaxKilo.Text= Convert.ToString(calc.ResistanceInMega(Convert.ToDecimal(ohmResult)));
				txtMaxMega.Text = Convert.ToString(calc.ResistanceInMega(Convert.ToDecimal(ohmResult)));


			}
			}
			else
			{
				MessageBox.Show("Select the necessary items", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		

	}
}
