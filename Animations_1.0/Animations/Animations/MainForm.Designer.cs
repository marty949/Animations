/*
 * Created by SharpDevelop.
 * User: marti
 * Date: 31.12.2021
 * Time: 21:45
 * 

 */
namespace Animations
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button animace1;
		private System.Windows.Forms.Button animace2;
		private System.Windows.Forms.Button animace3;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.ImageList imageList3;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.animace1 = new System.Windows.Forms.Button();
			this.animace2 = new System.Windows.Forms.Button();
			this.animace3 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.imageList3 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 45);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(306, 221);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// animace1
			// 
			this.animace1.Location = new System.Drawing.Point(339, 45);
			this.animace1.Name = "animace1";
			this.animace1.Size = new System.Drawing.Size(104, 60);
			this.animace1.TabIndex = 1;
			this.animace1.Text = "animace1";
			this.animace1.UseVisualStyleBackColor = true;
			this.animace1.Click += new System.EventHandler(this.Animace1Click);
			// 
			// animace2
			// 
			this.animace2.Location = new System.Drawing.Point(339, 111);
			this.animace2.Name = "animace2";
			this.animace2.Size = new System.Drawing.Size(104, 60);
			this.animace2.TabIndex = 2;
			this.animace2.Text = "animace2";
			this.animace2.UseVisualStyleBackColor = true;
			this.animace2.Click += new System.EventHandler(this.Animace2Click);
			// 
			// animace3
			// 
			this.animace3.Location = new System.Drawing.Point(339, 177);
			this.animace3.Name = "animace3";
			this.animace3.Size = new System.Drawing.Size(104, 60);
			this.animace3.TabIndex = 3;
			this.animace3.Text = "animace3";
			this.animace3.UseVisualStyleBackColor = true;
			this.animace3.Click += new System.EventHandler(this.Animace3Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 300;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// timer2
			// 
			this.timer2.Interval = 300;
			this.timer2.Tick += new System.EventHandler(this.Timer2Tick);
			// 
			// timer3
			// 
			this.timer3.Interval = 300;
			this.timer3.Tick += new System.EventHandler(this.Timer3Tick);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "a1.png");
			this.imageList1.Images.SetKeyName(1, "a2.png");
			this.imageList1.Images.SetKeyName(2, "a3.png");
			this.imageList1.Images.SetKeyName(3, "a4.png");
			// 
			// imageList2
			// 
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList2.Images.SetKeyName(0, "a1.png");
			this.imageList2.Images.SetKeyName(1, "a2.png");
			this.imageList2.Images.SetKeyName(2, "a3.png");
			this.imageList2.Images.SetKeyName(3, "a4.png");
			this.imageList2.Images.SetKeyName(4, "a5.png");
			this.imageList2.Images.SetKeyName(5, "a1.png");
			// 
			// imageList3
			// 
			this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
			this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList3.Images.SetKeyName(0, "a1.png");
			this.imageList3.Images.SetKeyName(1, "a2.png");
			this.imageList3.Images.SetKeyName(2, "a3.png");
			this.imageList3.Images.SetKeyName(3, "a4.png");
			this.imageList3.Images.SetKeyName(4, "a5.png");
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 317);
			this.Controls.Add(this.animace3);
			this.Controls.Add(this.animace2);
			this.Controls.Add(this.animace1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "Animations";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
