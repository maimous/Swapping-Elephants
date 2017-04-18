namespace Swapping_Elephants
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LloydsButton = new System.Windows.Forms.Button();
            this.LucindasButton = new System.Windows.Forms.Button();
            this.swapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LloydsButton
            // 
            this.LloydsButton.Location = new System.Drawing.Point(62, 26);
            this.LloydsButton.Name = "LloydsButton";
            this.LloydsButton.Size = new System.Drawing.Size(80, 30);
            this.LloydsButton.TabIndex = 0;
            this.LloydsButton.Text = "Lloyd";
            this.LloydsButton.UseVisualStyleBackColor = true;
            this.LloydsButton.Click += new System.EventHandler(this.LloydsButton_Click);
            // 
            // LucindasButton
            // 
            this.LucindasButton.Location = new System.Drawing.Point(62, 91);
            this.LucindasButton.Name = "LucindasButton";
            this.LucindasButton.Size = new System.Drawing.Size(80, 30);
            this.LucindasButton.TabIndex = 1;
            this.LucindasButton.Text = "Lucinda";
            this.LucindasButton.UseVisualStyleBackColor = true;
            this.LucindasButton.Click += new System.EventHandler(this.LucindasButton_Click);
            // 
            // swapButton
            // 
            this.swapButton.Location = new System.Drawing.Point(62, 201);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(80, 30);
            this.swapButton.TabIndex = 2;
            this.swapButton.Text = "Swap!";
            this.swapButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 261);
            this.Controls.Add(this.swapButton);
            this.Controls.Add(this.LucindasButton);
            this.Controls.Add(this.LloydsButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Swapping Elephants";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LloydsButton;
        private System.Windows.Forms.Button LucindasButton;
        private System.Windows.Forms.Button swapButton;
    }
}

