using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace PluginNapa
{
	/// <summary>
	/// Summary description for ctlMain.
	/// </summary>
	public class ctlMain : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Button butMain;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public ctlMain()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.butMain = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butMain
            // 
            this.butMain.BackColor = System.Drawing.Color.Gainsboro;
            this.butMain.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butMain.Location = new System.Drawing.Point(295, 453);
            this.butMain.Name = "butMain";
            this.butMain.Size = new System.Drawing.Size(88, 32);
            this.butMain.TabIndex = 0;
            this.butMain.Text = "&Click Me!";
            this.butMain.UseVisualStyleBackColor = false;
            this.butMain.Click += new System.EventHandler(this.butMain_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PluginNapa.Properties.Resources.FKU;
            this.pictureBox4.Location = new System.Drawing.Point(264, 387);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(140, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PluginNapa.Properties.Resources.pp;
            this.pictureBox3.Location = new System.Drawing.Point(57, 443);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(566, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PluginNapa.Properties.Resources.Miw;
            this.pictureBox2.Location = new System.Drawing.Point(38, 387);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PluginNapa.Properties.Resources._79c2cad61a3a923fa5209209197c9ef3;
            this.pictureBox1.Location = new System.Drawing.Point(145, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ctlMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butMain);
            this.Name = "ctlMain";
            this.Size = new System.Drawing.Size(664, 512);
            this.Resize += new System.EventHandler(this.ctlMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
		int newH = 0;
		int newV = 0;
			
		Random rndH = new Random(20);
		Random rndV = new Random(20);
		
		private void MoveButton()
		{
			newH = rndH.Next(this.Width - 40);
			
			
			newV = rndV.Next(this.Height - 40);
			
			this.butMain.Top = newV;
			this.butMain.Left = newH;
		}
		
		private void butMain_Click(object sender, System.EventArgs e)
		{
			this.MoveButton();			
		}

		private void ctlMain_Resize(object sender, System.EventArgs e)
		{
			this.MoveButton();
		}
	}
}
