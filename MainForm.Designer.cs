/*
 * Created by SharpDevelop.
 * User: Ads
 * Date: 6/16/2008
 * Time: 6:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Resistance_Calculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.cbo2 = new System.Windows.Forms.ComboBox();
            this.cbo3 = new System.Windows.Forms.ComboBox();
            this.cbo4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo5 = new System.Windows.Forms.ComboBox();
            this.txtOhm = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtOhmKilo = new System.Windows.Forms.TextBox();
            this.txtOhmMega = new System.Windows.Forms.TextBox();
            this.txtMinMega = new System.Windows.Forms.TextBox();
            this.txtMinKilo = new System.Windows.Forms.TextBox();
            this.txtMinOhm = new System.Windows.Forms.TextBox();
            this.txtMaxMega = new System.Windows.Forms.TextBox();
            this.txtMaxKilo = new System.Windows.Forms.TextBox();
            this.txtMaxOhm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo1
            // 
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White"});
            this.cbo1.Location = new System.Drawing.Point(12, 36);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(64, 21);
            this.cbo1.TabIndex = 0;
            // 
            // cbo2
            // 
            this.cbo2.FormattingEnabled = true;
            this.cbo2.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White"});
            this.cbo2.Location = new System.Drawing.Point(82, 36);
            this.cbo2.Name = "cbo2";
            this.cbo2.Size = new System.Drawing.Size(64, 21);
            this.cbo2.TabIndex = 1;
            // 
            // cbo3
            // 
            this.cbo3.FormattingEnabled = true;
            this.cbo3.Items.AddRange(new object[] {
            "(None)",
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White",
            "--------",
            "Gold",
            "Silver"});
            this.cbo3.Location = new System.Drawing.Point(152, 36);
            this.cbo3.Name = "cbo3";
            this.cbo3.Size = new System.Drawing.Size(64, 21);
            this.cbo3.TabIndex = 2;
            // 
            // cbo4
            // 
            this.cbo4.FormattingEnabled = true;
            this.cbo4.Items.AddRange(new object[] {
            "(None)",
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White"});
            this.cbo4.Location = new System.Drawing.Point(222, 36);
            this.cbo4.Name = "cbo4";
            this.cbo4.Size = new System.Drawing.Size(64, 21);
            this.cbo4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "1st Strip";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(82, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "2nd Strip";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(152, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "3rd Strip";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(222, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "4th Strip";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(292, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tolerance";
            // 
            // cbo5
            // 
            this.cbo5.FormattingEnabled = true;
            this.cbo5.Items.AddRange(new object[] {
            "(None)",
            "Gold",
            "Silver",
            "No Color",
            "Red",
            "Brown",
            "Violet"});
            this.cbo5.Location = new System.Drawing.Point(292, 36);
            this.cbo5.Name = "cbo5";
            this.cbo5.Size = new System.Drawing.Size(64, 21);
            this.cbo5.TabIndex = 9;
            // 
            // txtOhm
            // 
            this.txtOhm.Location = new System.Drawing.Point(12, 87);
            this.txtOhm.Name = "txtOhm";
            this.txtOhm.ReadOnly = true;
            this.txtOhm.Size = new System.Drawing.Size(108, 21);
            this.txtOhm.TabIndex = 10;
            this.txtOhm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(119, 208);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(128, 29);
            this.btnCalc.TabIndex = 11;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalcClick);
            // 
            // txtOhmKilo
            // 
            this.txtOhmKilo.Location = new System.Drawing.Point(129, 87);
            this.txtOhmKilo.Name = "txtOhmKilo";
            this.txtOhmKilo.ReadOnly = true;
            this.txtOhmKilo.Size = new System.Drawing.Size(108, 21);
            this.txtOhmKilo.TabIndex = 12;
            this.txtOhmKilo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOhmMega
            // 
            this.txtOhmMega.Location = new System.Drawing.Point(246, 87);
            this.txtOhmMega.Name = "txtOhmMega";
            this.txtOhmMega.ReadOnly = true;
            this.txtOhmMega.Size = new System.Drawing.Size(108, 21);
            this.txtOhmMega.TabIndex = 13;
            this.txtOhmMega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinMega
            // 
            this.txtMinMega.Location = new System.Drawing.Point(246, 127);
            this.txtMinMega.Name = "txtMinMega";
            this.txtMinMega.ReadOnly = true;
            this.txtMinMega.Size = new System.Drawing.Size(108, 21);
            this.txtMinMega.TabIndex = 16;
            this.txtMinMega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinKilo
            // 
            this.txtMinKilo.Location = new System.Drawing.Point(129, 127);
            this.txtMinKilo.Name = "txtMinKilo";
            this.txtMinKilo.ReadOnly = true;
            this.txtMinKilo.Size = new System.Drawing.Size(108, 21);
            this.txtMinKilo.TabIndex = 15;
            this.txtMinKilo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinOhm
            // 
            this.txtMinOhm.Location = new System.Drawing.Point(12, 127);
            this.txtMinOhm.Name = "txtMinOhm";
            this.txtMinOhm.ReadOnly = true;
            this.txtMinOhm.Size = new System.Drawing.Size(108, 21);
            this.txtMinOhm.TabIndex = 14;
            this.txtMinOhm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaxMega
            // 
            this.txtMaxMega.Location = new System.Drawing.Point(246, 168);
            this.txtMaxMega.Name = "txtMaxMega";
            this.txtMaxMega.ReadOnly = true;
            this.txtMaxMega.Size = new System.Drawing.Size(108, 21);
            this.txtMaxMega.TabIndex = 19;
            this.txtMaxMega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaxKilo
            // 
            this.txtMaxKilo.Location = new System.Drawing.Point(129, 168);
            this.txtMaxKilo.Name = "txtMaxKilo";
            this.txtMaxKilo.ReadOnly = true;
            this.txtMaxKilo.Size = new System.Drawing.Size(108, 21);
            this.txtMaxKilo.TabIndex = 18;
            this.txtMaxKilo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaxOhm
            // 
            this.txtMaxOhm.Location = new System.Drawing.Point(12, 168);
            this.txtMaxOhm.Name = "txtMaxOhm";
            this.txtMaxOhm.ReadOnly = true;
            this.txtMaxOhm.Size = new System.Drawing.Size(108, 21);
            this.txtMaxOhm.TabIndex = 17;
            this.txtMaxOhm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(44, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 14);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ohms";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(152, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 14);
            this.label7.TabIndex = 21;
            this.label7.Text = "Kilo Ohms";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(263, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 14);
            this.label8.TabIndex = 22;
            this.label8.Text = "Mega Ohms";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(141, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 14);
            this.label9.TabIndex = 23;
            this.label9.Text = "Minimum Value";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(141, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 14);
            this.label10.TabIndex = 24;
            this.label10.Text = "Maximum Value";
            // 
            // btnAbt
            // 
            this.btnAbt.Location = new System.Drawing.Point(324, 213);
            this.btnAbt.Name = "btnAbt";
            this.btnAbt.Size = new System.Drawing.Size(30, 23);
            this.btnAbt.TabIndex = 25;
            this.btnAbt.Text = "?";
            this.btnAbt.UseVisualStyleBackColor = true;
            this.btnAbt.Click += new System.EventHandler(this.BtnAbtClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 249);
            this.Controls.Add(this.btnAbt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaxMega);
            this.Controls.Add(this.txtMaxKilo);
            this.Controls.Add(this.txtMaxOhm);
            this.Controls.Add(this.txtMinMega);
            this.Controls.Add(this.txtMinKilo);
            this.Controls.Add(this.txtMinOhm);
            this.Controls.Add(this.txtOhmMega);
            this.Controls.Add(this.txtOhmKilo);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtOhm);
            this.Controls.Add(this.cbo5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo4);
            this.Controls.Add(this.cbo3);
            this.Controls.Add(this.cbo2);
            this.Controls.Add(this.cbo1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resistance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button btnAbt;
		private System.Windows.Forms.TextBox txtMinOhm;
		private System.Windows.Forms.TextBox txtOhm;
		private System.Windows.Forms.TextBox txtOhmKilo;
		private System.Windows.Forms.TextBox txtOhmMega;
		private System.Windows.Forms.TextBox txtMinMega;
		private System.Windows.Forms.TextBox txtMinKilo;
		private System.Windows.Forms.TextBox txtMaxMega;
		private System.Windows.Forms.TextBox txtMaxKilo;
		private System.Windows.Forms.TextBox txtMaxOhm;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.ComboBox cbo5;
		private System.Windows.Forms.ComboBox cbo4;
		private System.Windows.Forms.ComboBox cbo3;
		private System.Windows.Forms.ComboBox cbo2;
		private System.Windows.Forms.ComboBox cbo1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		

	}
}
