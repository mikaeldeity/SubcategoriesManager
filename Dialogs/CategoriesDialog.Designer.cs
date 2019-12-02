namespace SubcategoriesManager.Dialogs
{
    partial class CategoriesDialog
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
            this.SubcategoriesList = new System.Windows.Forms.CheckedListBox();
            this.CategoriesDropdown = new System.Windows.Forms.ComboBox();
            this.MergeButton = new System.Windows.Forms.Button();
            this.SubCategoriesDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SubcategoriesList
            // 
            this.SubcategoriesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubcategoriesList.CheckOnClick = true;
            this.SubcategoriesList.FormattingEnabled = true;
            this.SubcategoriesList.HorizontalScrollbar = true;
            this.SubcategoriesList.Location = new System.Drawing.Point(12, 82);
            this.SubcategoriesList.Name = "SubcategoriesList";
            this.SubcategoriesList.Size = new System.Drawing.Size(249, 167);
            this.SubcategoriesList.TabIndex = 0;
            // 
            // CategoriesDropdown
            // 
            this.CategoriesDropdown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CategoriesDropdown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoriesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriesDropdown.FormattingEnabled = true;
            this.CategoriesDropdown.Location = new System.Drawing.Point(12, 30);
            this.CategoriesDropdown.Name = "CategoriesDropdown";
            this.CategoriesDropdown.Size = new System.Drawing.Size(249, 21);
            this.CategoriesDropdown.TabIndex = 1;
            this.CategoriesDropdown.SelectedIndexChanged += new System.EventHandler(this.CategoriesDropdown_SelectedIndexChanged);
            // 
            // MergeButton
            // 
            this.MergeButton.FlatAppearance.BorderSize = 0;
            this.MergeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MergeButton.Location = new System.Drawing.Point(183, 313);
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.Size = new System.Drawing.Size(78, 28);
            this.MergeButton.TabIndex = 2;
            this.MergeButton.Text = "Replace";
            this.MergeButton.UseVisualStyleBackColor = true;
            this.MergeButton.Click += new System.EventHandler(this.MergeButton_Click);
            // 
            // SubCategoriesDropDown
            // 
            this.SubCategoriesDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SubCategoriesDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SubCategoriesDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubCategoriesDropDown.FormattingEnabled = true;
            this.SubCategoriesDropDown.Location = new System.Drawing.Point(12, 279);
            this.SubCategoriesDropDown.Name = "SubCategoriesDropDown";
            this.SubCategoriesDropDown.Size = new System.Drawing.Size(249, 21);
            this.SubCategoriesDropDown.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Replace";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "With";
            // 
            // DeleteCheckBox
            // 
            this.DeleteCheckBox.AutoSize = true;
            this.DeleteCheckBox.Location = new System.Drawing.Point(15, 321);
            this.DeleteCheckBox.Name = "DeleteCheckBox";
            this.DeleteCheckBox.Size = new System.Drawing.Size(101, 17);
            this.DeleteCheckBox.TabIndex = 7;
            this.DeleteCheckBox.Text = "Delete replaced";
            this.DeleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // CategoriesDialog
            // 
            this.AcceptButton = this.MergeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 356);
            this.Controls.Add(this.DeleteCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubCategoriesDropDown);
            this.Controls.Add(this.MergeButton);
            this.Controls.Add(this.CategoriesDropdown);
            this.Controls.Add(this.SubcategoriesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoriesDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Subcategories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox CategoriesDropdown;
        public System.Windows.Forms.CheckedListBox SubcategoriesList;
        private System.Windows.Forms.Button MergeButton;
        public System.Windows.Forms.ComboBox SubCategoriesDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox DeleteCheckBox;
    }
}