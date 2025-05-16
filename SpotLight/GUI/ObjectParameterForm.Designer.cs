namespace Spotlight
{
    partial class ObjectParameterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectParameterForm));
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelSelectionButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.NewNameTextBox = new System.Windows.Forms.TextBox();
            this.UseProgrammingTermsCheckbox = new System.Windows.Forms.CheckBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NewTypeComboBox = new System.Windows.Forms.ComboBox();
            this.MainEditorControl = new Spotlight.ObjectParameterEditorControl();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(678, 991);
            this.OKButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(138, 42);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // CancelSelectionButton
            // 
            this.CancelSelectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSelectionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelSelectionButton.Location = new System.Drawing.Point(530, 991);
            this.CancelSelectionButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CancelSelectionButton.Name = "CancelSelectionButton";
            this.CancelSelectionButton.Size = new System.Drawing.Size(138, 42);
            this.CancelSelectionButton.TabIndex = 1;
            this.CancelSelectionButton.Text = "Cancel";
            this.CancelSelectionButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(678, 823);
            this.AddButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(132, 42);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NewNameTextBox
            // 
            this.NewNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewNameTextBox.Location = new System.Drawing.Point(279, 827);
            this.NewNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NewNameTextBox.Name = "NewNameTextBox";
            this.NewNameTextBox.Size = new System.Drawing.Size(385, 29);
            this.NewNameTextBox.TabIndex = 3;
            // 
            // UseProgrammingTermsCheckbox
            // 
            this.UseProgrammingTermsCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UseProgrammingTermsCheckbox.AutoSize = true;
            this.UseProgrammingTermsCheckbox.Location = new System.Drawing.Point(25, 22);
            this.UseProgrammingTermsCheckbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UseProgrammingTermsCheckbox.Name = "UseProgrammingTermsCheckbox";
            this.UseProgrammingTermsCheckbox.Size = new System.Drawing.Size(255, 29);
            this.UseProgrammingTermsCheckbox.TabIndex = 5;
            this.UseProgrammingTermsCheckbox.Text = "Use Programming Terms";
            this.UseProgrammingTermsCheckbox.UseVisualStyleBackColor = true;
            this.UseProgrammingTermsCheckbox.CheckedChanged += new System.EventHandler(this.CheckUseProgrammingTerms_CheckedChanged);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(24, 92);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(57, 25);
            this.TypeLabel.TabIndex = 6;
            this.TypeLabel.Text = "Type";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(336, 92);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(64, 25);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name";
            // 
            // NewTypeComboBox
            // 
            this.NewTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NewTypeComboBox.FormattingEnabled = true;
            this.NewTypeComboBox.Location = new System.Drawing.Point(29, 825);
            this.NewTypeComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NewTypeComboBox.Name = "NewTypeComboBox";
            this.NewTypeComboBox.Size = new System.Drawing.Size(235, 32);
            this.NewTypeComboBox.TabIndex = 3;
            // 
            // MainEditorControl
            // 
            this.MainEditorControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainEditorControl.AutoScroll = true;
            this.MainEditorControl.AutoScrollMinSize = new System.Drawing.Size(0, 20);
            this.MainEditorControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainEditorControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainEditorControl.Location = new System.Drawing.Point(22, 126);
            this.MainEditorControl.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.MainEditorControl.Name = "MainEditorControl";
            this.MainEditorControl.Size = new System.Drawing.Size(792, 689);
            this.MainEditorControl.TabIndex = 2;
            // 
            // ObjectParameterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 1056);
            this.Controls.Add(this.NewTypeComboBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.UseProgrammingTermsCheckbox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MainEditorControl);
            this.Controls.Add(this.NewNameTextBox);
            this.Controls.Add(this.CancelSelectionButton);
            this.Controls.Add(this.OKButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(847, 1074);
            this.Name = "ObjectParameterForm";
            this.Text = "OdyLight - Object Parameter Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelSelectionButton;
        private ObjectParameterEditorControl MainEditorControl;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox NewNameTextBox;
        private System.Windows.Forms.CheckBox UseProgrammingTermsCheckbox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox NewTypeComboBox;
    }
}