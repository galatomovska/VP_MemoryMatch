namespace MemoryGame
{
    partial class Mode
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKids = new System.Windows.Forms.Button();
            this.buttonTeens = new System.Windows.Forms.Button();
            this.buttonAdults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(114, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 111);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a mode";
            // 
            // buttonKids
            // 
            this.buttonKids.BackColor = System.Drawing.Color.Plum;
            this.buttonKids.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKids.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKids.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonKids.Location = new System.Drawing.Point(183, 274);
            this.buttonKids.Name = "buttonKids";
            this.buttonKids.Size = new System.Drawing.Size(609, 49);
            this.buttonKids.TabIndex = 1;
            this.buttonKids.Text = "KIDS";
            this.buttonKids.UseVisualStyleBackColor = false;
            this.buttonKids.Click += new System.EventHandler(this.buttonKids_Click);
            // 
            // buttonTeens
            // 
            this.buttonTeens.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonTeens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTeens.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTeens.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTeens.Location = new System.Drawing.Point(183, 369);
            this.buttonTeens.Name = "buttonTeens";
            this.buttonTeens.Size = new System.Drawing.Size(610, 49);
            this.buttonTeens.TabIndex = 2;
            this.buttonTeens.Text = "TEENS";
            this.buttonTeens.UseVisualStyleBackColor = false;
            this.buttonTeens.Click += new System.EventHandler(this.buttonTeens_Click);
            // 
            // buttonAdults
            // 
            this.buttonAdults.BackColor = System.Drawing.Color.Blue;
            this.buttonAdults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdults.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdults.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdults.Location = new System.Drawing.Point(184, 463);
            this.buttonAdults.Name = "buttonAdults";
            this.buttonAdults.Size = new System.Drawing.Size(609, 49);
            this.buttonAdults.TabIndex = 3;
            this.buttonAdults.Text = "ADULTS";
            this.buttonAdults.UseVisualStyleBackColor = false;
            this.buttonAdults.Click += new System.EventHandler(this.buttonAdults_Click);
            // 
            // Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.mode_wallpaper;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.buttonAdults);
            this.Controls.Add(this.buttonTeens);
            this.Controls.Add(this.buttonKids);
            this.Controls.Add(this.label1);
            this.Name = "Mode";
            this.Text = "Mode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKids;
        private System.Windows.Forms.Button buttonTeens;
        private System.Windows.Forms.Button buttonAdults;
    }
}