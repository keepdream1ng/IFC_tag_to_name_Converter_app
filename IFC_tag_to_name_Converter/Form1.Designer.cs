namespace IFC_tag_to_name_Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            path_textBox = new TextBox();
            brouse_button = new Button();
            convert_button = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "*.ifc|";
            // 
            // path_textBox
            // 
            path_textBox.Location = new Point(105, 36);
            path_textBox.Name = "path_textBox";
            path_textBox.Size = new Size(275, 23);
            path_textBox.TabIndex = 0;
            // 
            // brouse_button
            // 
            brouse_button.Location = new Point(13, 36);
            brouse_button.Name = "brouse_button";
            brouse_button.Size = new Size(75, 23);
            brouse_button.TabIndex = 1;
            brouse_button.Text = "Browse";
            brouse_button.UseVisualStyleBackColor = true;
            brouse_button.Click += brouse_button_Click;
            // 
            // convert_button
            // 
            convert_button.Location = new Point(398, 36);
            convert_button.Name = "convert_button";
            convert_button.Size = new Size(75, 23);
            convert_button.TabIndex = 2;
            convert_button.Text = "Convert";
            convert_button.UseVisualStyleBackColor = true;
            convert_button.Click += convert_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 86);
            Controls.Add(convert_button);
            Controls.Add(brouse_button);
            Controls.Add(path_textBox);
            Name = "Form1";
            Text = "IFC Tag to Name converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox path_textBox;
        private Button brouse_button;
        private Button convert_button;
    }
}