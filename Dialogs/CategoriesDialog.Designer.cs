namespace SubcategoriesMerger.Dialogs
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
            this.Table_Main = new System.Windows.Forms.TableLayoutPanel();
            this.Table_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.Table_Main.SuspendLayout();
            this.Table_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubcategoriesList
            // 
            this.SubcategoriesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubcategoriesList.CheckOnClick = true;
            this.SubcategoriesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubcategoriesList.FormattingEnabled = true;
            this.SubcategoriesList.HorizontalScrollbar = true;
            this.SubcategoriesList.Location = new System.Drawing.Point(3, 95);
            this.SubcategoriesList.Name = "SubcategoriesList";
            this.SubcategoriesList.Size = new System.Drawing.Size(328, 206);
            this.SubcategoriesList.TabIndex = 0;
            // 
            // CategoriesDropdown
            // 
            this.CategoriesDropdown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CategoriesDropdown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoriesDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriesDropdown.FormattingEnabled = true;
            this.CategoriesDropdown.Location = new System.Drawing.Point(3, 35);
            this.CategoriesDropdown.Name = "CategoriesDropdown";
            this.CategoriesDropdown.Size = new System.Drawing.Size(328, 21);
            this.CategoriesDropdown.TabIndex = 1;
            this.CategoriesDropdown.SelectedIndexChanged += new System.EventHandler(this.CategoriesDropdown_SelectedIndexChanged);
            // 
            // MergeButton
            // 
            this.MergeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MergeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MergeButton.FlatAppearance.BorderSize = 0;
            this.MergeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MergeButton.Location = new System.Drawing.Point(181, 3);
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.Size = new System.Drawing.Size(144, 28);
            this.MergeButton.TabIndex = 2;
            this.MergeButton.Text = "Replace";
            this.MergeButton.UseVisualStyleBackColor = false;
            this.MergeButton.Click += new System.EventHandler(this.MergeButton_Click);
            // 
            // SubCategoriesDropDown
            // 
            this.SubCategoriesDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SubCategoriesDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SubCategoriesDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubCategoriesDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubCategoriesDropDown.FormattingEnabled = true;
            this.SubCategoriesDropDown.Location = new System.Drawing.Point(3, 334);
            this.SubCategoriesDropDown.Name = "SubCategoriesDropDown";
            this.SubCategoriesDropDown.Size = new System.Drawing.Size(328, 21);
            this.SubCategoriesDropDown.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Replace";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "With";
            // 
            // DeleteCheckBox
            // 
            this.DeleteCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteCheckBox.AutoSize = true;
            this.DeleteCheckBox.Location = new System.Drawing.Point(3, 3);
            this.DeleteCheckBox.Name = "DeleteCheckBox";
            this.DeleteCheckBox.Size = new System.Drawing.Size(101, 28);
            this.DeleteCheckBox.TabIndex = 7;
            this.DeleteCheckBox.Text = "Delete replaced";
            this.DeleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // Table_Main
            // 
            this.Table_Main.ColumnCount = 1;
            this.Table_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table_Main.Controls.Add(this.Table_Buttons, 0, 6);
            this.Table_Main.Controls.Add(this.SubcategoriesList, 0, 3);
            this.Table_Main.Controls.Add(this.SubCategoriesDropDown, 0, 5);
            this.Table_Main.Controls.Add(this.label3, 0, 4);
            this.Table_Main.Controls.Add(this.label2, 0, 2);
            this.Table_Main.Controls.Add(this.label1, 0, 0);
            this.Table_Main.Controls.Add(this.CategoriesDropdown, 0, 1);
            this.Table_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_Main.Location = new System.Drawing.Point(0, 0);
            this.Table_Main.Name = "Table_Main";
            this.Table_Main.RowCount = 7;
            this.Table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.Table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.Table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.Table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.Table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Table_Main.Size = new System.Drawing.Size(334, 411);
            this.Table_Main.TabIndex = 8;
            // 
            // Table_Buttons
            // 
            this.Table_Buttons.ColumnCount = 2;
            this.Table_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.Table_Buttons.Controls.Add(this.MergeButton, 1, 0);
            this.Table_Buttons.Controls.Add(this.DeleteCheckBox, 0, 0);
            this.Table_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_Buttons.Location = new System.Drawing.Point(3, 374);
            this.Table_Buttons.Name = "Table_Buttons";
            this.Table_Buttons.RowCount = 1;
            this.Table_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table_Buttons.Size = new System.Drawing.Size(328, 34);
            this.Table_Buttons.TabIndex = 0;
            // 
            // CategoriesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.Table_Main);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "CategoriesDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Subcategories";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.CategoriesDialog_HelpButtonClicked);
            this.Table_Main.ResumeLayout(false);
            this.Table_Main.PerformLayout();
            this.Table_Buttons.ResumeLayout(false);
            this.Table_Buttons.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel Table_Main;
        private System.Windows.Forms.TableLayoutPanel Table_Buttons;
    }
}