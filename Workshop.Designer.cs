namespace DataBase_Ass_App
{
    partial class Workshop
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
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // chefToolStripMenuItem
            // 
            this.chefToolStripMenuItem.Name = "chefToolStripMenuItem";
            this.chefToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.chefToolStripMenuItem.Text = "Chef";
            this.chefToolStripMenuItem.Click += new System.EventHandler(this.chefToolStripMenuItem_Click);
            // 
            // kitchenToolStripMenuItem
            // 
            this.kitchenToolStripMenuItem.Name = "kitchenToolStripMenuItem";
            this.kitchenToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.kitchenToolStripMenuItem.Text = "Kitchen";
            this.kitchenToolStripMenuItem.Click += new System.EventHandler(this.kitchenToolStripMenuItem_Click);
            // 
            // stationToolStripMenuItem
            // 
            this.stationToolStripMenuItem.Name = "stationToolStripMenuItem";
            this.stationToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.stationToolStripMenuItem.Text = "Station";
            this.stationToolStripMenuItem.Click += new System.EventHandler(this.stationToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // ingredientToolStripMenuItem
            // 
            this.ingredientToolStripMenuItem.Name = "ingredientToolStripMenuItem";
            this.ingredientToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.ingredientToolStripMenuItem.Text = "Ingredient";
            this.ingredientToolStripMenuItem.Click += new System.EventHandler(this.ingredientToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.chefToolStripMenuItem,
            this.kitchenToolStripMenuItem,
            this.stationToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.ingredientToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Workshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 565);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Workshop";
            this.Text = "Workshop";
            this.Load += new System.EventHandler(this.Workshop_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}