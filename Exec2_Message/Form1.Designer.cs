namespace Exec2_Message
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.TimeButton = new System.Windows.Forms.Button();
			this.TimeLabel = new System.Windows.Forms.Label();
			this.GreetLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TimeButton
			// 
			this.TimeButton.Location = new System.Drawing.Point(101, 46);
			this.TimeButton.Name = "TimeButton";
			this.TimeButton.Size = new System.Drawing.Size(91, 23);
			this.TimeButton.TabIndex = 0;
			this.TimeButton.Text = "顯示現在時間";
			this.TimeButton.UseVisualStyleBackColor = true;
			this.TimeButton.Click += new System.EventHandler(this.TimeButton_Click);
			// 
			// TimeLabel
			// 
			this.TimeLabel.AutoSize = true;
			this.TimeLabel.Location = new System.Drawing.Point(70, 99);
			this.TimeLabel.Name = "TimeLabel";
			this.TimeLabel.Size = new System.Drawing.Size(55, 12);
			this.TimeLabel.TabIndex = 1;
			this.TimeLabel.Text = "TimeLabel";
			// 
			// GreetLabel
			// 
			this.GreetLabel.AutoSize = true;
			this.GreetLabel.Location = new System.Drawing.Point(122, 132);
			this.GreetLabel.Name = "GreetLabel";
			this.GreetLabel.Size = new System.Drawing.Size(56, 12);
			this.GreetLabel.TabIndex = 2;
			this.GreetLabel.Text = "GreetLabel";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 234);
			this.Controls.Add(this.GreetLabel);
			this.Controls.Add(this.TimeLabel);
			this.Controls.Add(this.TimeButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button TimeButton;
		private System.Windows.Forms.Label TimeLabel;
		private System.Windows.Forms.Label GreetLabel;
	}
}

