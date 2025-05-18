namespace Server
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnStart = new Button();
			btnStop = new Button();
			lblServer = new Label();
			SuspendLayout();
			// 
			// btnStart
			// 
			//btnStart.BackgroundImage = Server.Properties.Resources.pexels_elina_araja_1743227_3377405;
			btnStart.Location = new Point(28, 63);
			btnStart.Margin = new Padding(0);
			btnStart.Name = "btnStart";
			btnStart.Size = new Size(130, 29);
			btnStart.TabIndex = 0;
			btnStart.Text = "Pokreni server";
			btnStart.UseVisualStyleBackColor = true;
			btnStart.Click += btnStart_Click;
			// 
			// btnStop
			// 
			//btnStop.BackgroundImage = Server.Properties.Resources.pexels_elina_araja_1743227_3377405;
			btnStop.Location = new Point(664, 63);
			btnStop.Margin = new Padding(0);
			btnStop.Name = "btnStop";
			btnStop.Size = new Size(124, 29);
			btnStop.TabIndex = 1;
			btnStop.Text = "Zaustavi server";
			btnStop.UseVisualStyleBackColor = true;
			// 
			// lblServer
			// 
			lblServer.AutoSize = true;
			lblServer.BackColor = SystemColors.ButtonFace;
			lblServer.Location = new Point(372, 19);
			lblServer.Name = "lblServer";
			lblServer.Size = new Size(33, 20);
			lblServer.TabIndex = 2;
			lblServer.Text = "aaa";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaptionText;
			//BackgroundImage = Server.Properties.Resources.Audi_RS6_Transparent_File;
			ClientSize = new Size(800, 450);
			Controls.Add(lblServer);
			Controls.Add(btnStop);
			Controls.Add(btnStart);
			MaximizeBox = false;
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnStart;
		private Button btnStop;
		private Label lblServer;
	}
}
