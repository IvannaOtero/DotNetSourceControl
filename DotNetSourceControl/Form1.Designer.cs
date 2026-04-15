namespace DotNetSourceControl
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
            btnGreeting = new Button();
            SuspendLayout();
            // 
            // btnGreeting
            // 
            btnGreeting.Location = new Point(56, 60);
            btnGreeting.Name = "btnGreeting";
            btnGreeting.Size = new Size(343, 133);
            btnGreeting.TabIndex = 0;
            btnGreeting.Text = "Click This Button";
            btnGreeting.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 260);
            Controls.Add(btnGreeting);
            Name = "Form1";
            Text = "Source Control ";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGreeting;
    }
}
