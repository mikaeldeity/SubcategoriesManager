namespace SubcategoriesMerger
{
    partial class UnusedCatsDialog
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
            this.UnusedTreeView = new System.Windows.Forms.TreeView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UnusedTreeView
            // 
            this.UnusedTreeView.Dock = System.Windows.Forms.DockStyle.Top;
            this.UnusedTreeView.Location = new System.Drawing.Point(0, 0);
            this.UnusedTreeView.Name = "UnusedTreeView";
            this.UnusedTreeView.Size = new System.Drawing.Size(273, 300);
            this.UnusedTreeView.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(183, 313);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(78, 28);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // UnusedCatsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 356);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UnusedTreeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnusedCatsDialog";
            this.Text = "Unused Subcategories";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DeleteButton;
        public System.Windows.Forms.TreeView UnusedTreeView;
    }
}