namespace mandelbrot
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown_yOffset = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_xOffset = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Iterations = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_zoom = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_yOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_xOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Iterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_zoom)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDown_yOffset);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDown_xOffset);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDown_Iterations);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDown_zoom);
            this.splitContainer1.Size = new System.Drawing.Size(908, 751);
            this.splitContainer1.SplitterDistance = 750;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 751);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // numericUpDown_yOffset
            // 
            this.numericUpDown_yOffset.DecimalPlaces = 10;
            this.numericUpDown_yOffset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_yOffset.Location = new System.Drawing.Point(4, 105);
            this.numericUpDown_yOffset.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_yOffset.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.numericUpDown_yOffset.Name = "numericUpDown_yOffset";
            this.numericUpDown_yOffset.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_yOffset.TabIndex = 3;
            this.numericUpDown_yOffset.ValueChanged += new System.EventHandler(this.numericUpDown_yOffset_ValueChanged);
            // 
            // numericUpDown_xOffset
            // 
            this.numericUpDown_xOffset.DecimalPlaces = 10;
            this.numericUpDown_xOffset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_xOffset.Location = new System.Drawing.Point(3, 78);
            this.numericUpDown_xOffset.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_xOffset.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.numericUpDown_xOffset.Name = "numericUpDown_xOffset";
            this.numericUpDown_xOffset.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_xOffset.TabIndex = 2;
            this.numericUpDown_xOffset.ValueChanged += new System.EventHandler(this.numericUpDown_xOffset_ValueChanged);
            // 
            // numericUpDown_Iterations
            // 
            this.numericUpDown_Iterations.Location = new System.Drawing.Point(2, 38);
            this.numericUpDown_Iterations.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Iterations.Name = "numericUpDown_Iterations";
            this.numericUpDown_Iterations.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Iterations.TabIndex = 1;
            this.numericUpDown_Iterations.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_Iterations.ValueChanged += new System.EventHandler(this.numericUpDown_Iterations_ValueChanged);
            // 
            // numericUpDown_zoom
            // 
            this.numericUpDown_zoom.DecimalPlaces = 10;
            this.numericUpDown_zoom.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_zoom.Location = new System.Drawing.Point(3, 12);
            this.numericUpDown_zoom.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_zoom.Name = "numericUpDown_zoom";
            this.numericUpDown_zoom.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_zoom.TabIndex = 0;
            this.numericUpDown_zoom.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_zoom.ValueChanged += new System.EventHandler(this.numericUpDown_zoom_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 751);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_yOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_xOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Iterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_zoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_xOffset;
        private System.Windows.Forms.NumericUpDown numericUpDown_Iterations;
        private System.Windows.Forms.NumericUpDown numericUpDown_zoom;
        private System.Windows.Forms.NumericUpDown numericUpDown_yOffset;
    }
}

