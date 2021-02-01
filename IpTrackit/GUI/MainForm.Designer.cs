
namespace IpTrackit.GUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ipLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ipMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ipLabel
            // 
            resources.ApplyResources(this.ipLabel, "ipLabel");
            this.ipLabel.BackColor = System.Drawing.Color.Transparent;
            this.ipLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Click += new System.EventHandler(this.ipLabel_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.ForeColor = System.Drawing.Color.SkyBlue;
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.resultRichTextBox, "resultRichTextBox");
            this.resultRichTextBox.ForeColor = System.Drawing.Color.SkyBlue;
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.ReadOnly = true;
            this.resultRichTextBox.TextChanged += new System.EventHandler(this.resultRichTextBox_TextChanged);
            // 
            // ipMaskedTextBox
            // 
            resources.ApplyResources(this.ipMaskedTextBox, "ipMaskedTextBox");
            this.ipMaskedTextBox.ForeColor = System.Drawing.Color.SkyBlue;
            this.ipMaskedTextBox.Name = "ipMaskedTextBox";
            this.ipMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.ipMaskedTextBox_MaskInputRejected);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::IpTrackit.Properties.Resources.dark_abstract;
            this.Controls.Add(this.ipMaskedTextBox);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.ipLabel);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.MaskedTextBox ipMaskedTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}