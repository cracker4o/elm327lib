namespace ElmSerialPortTest
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
            this.lbCommands = new System.Windows.Forms.ListBox();
            this.tbResponses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lCommands = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCommands
            // 
            this.lbCommands.FormattingEnabled = true;
            this.lbCommands.HorizontalScrollbar = true;
            this.lbCommands.ItemHeight = 16;
            this.lbCommands.Location = new System.Drawing.Point(12, 28);
            this.lbCommands.Name = "lbCommands";
            this.lbCommands.Size = new System.Drawing.Size(303, 436);
            this.lbCommands.TabIndex = 0;
            this.lbCommands.DoubleClick += new System.EventHandler(this.lbCommands_DoubleClick);
            // 
            // tbResponses
            // 
            this.tbResponses.Location = new System.Drawing.Point(354, 29);
            this.tbResponses.Multiline = true;
            this.tbResponses.Name = "tbResponses";
            this.tbResponses.Size = new System.Drawing.Size(316, 435);
            this.tbResponses.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Responses";
            // 
            // lCommands
            // 
            this.lCommands.AutoSize = true;
            this.lCommands.Location = new System.Drawing.Point(12, 8);
            this.lCommands.Name = "lCommands";
            this.lCommands.Size = new System.Drawing.Size(78, 17);
            this.lCommands.TabIndex = 3;
            this.lCommands.Text = "Commands";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 470);
            this.Controls.Add(this.lCommands);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResponses);
            this.Controls.Add(this.lbCommands);
            this.Name = "Form1";
            this.Text = "ELM TEST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCommands;
        private System.Windows.Forms.TextBox tbResponses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lCommands;
    }
}

