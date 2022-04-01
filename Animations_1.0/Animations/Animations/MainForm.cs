/*
 * Created by SharpDevelop.
 * User: marti
 * Date: 31.12.2021
 * Time: 21:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Animations
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
		
		int num = 0;
		
		void Animace1Click(object sender, EventArgs e)
		{
			timer2.Stop();
			timer3.Stop();
			timer1.Start();
		}
		
		void Animace2Click(object sender, EventArgs e)
		{
			timer1.Stop();
			timer3.Stop();
			timer2.Start();
		}
		
		void Animace3Click(object sender, EventArgs e)
		{
			timer1.Stop();
			timer2.Stop();
			timer3.Start();
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			pictureBox1.Image = imageList1.Images[num];
			if (num == imageList1.Images.Count - 1) {
				num = 0;
			}else{
				num++;
			}
		}
		
		void Timer2Tick(object sender, EventArgs e)
		{
			pictureBox1.Image = imageList2.Images[num];
			if (num == imageList2.Images.Count - 1) {
				num = 0;
			}else{
				num++;
			}
		}
		
		void Timer3Tick(object sender, EventArgs e)
		{
			pictureBox1.Image = imageList3.Images[num];
			if (num == imageList3.Images.Count - 1) {
				num = 0;
			}else{
				num++;
			}
		}
	}
}
