namespace EventPlayground
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnChangeText = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.comboColors = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();

            this.btnChangeColor.Location = new System.Drawing.Point(40, 150);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(150, 40);
            this.btnChangeColor.TabIndex = 0;
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);

            this.btnChangeText.Location = new System.Drawing.Point(220, 150);
            this.btnChangeText.Name = "btnChangeText";
            this.btnChangeText.Size = new System.Drawing.Size(150, 40);
            this.btnChangeText.TabIndex = 1;
            this.btnChangeText.Text = "Change Text";
            this.btnChangeText.UseVisualStyleBackColor = true;
            this.btnChangeText.Click += new System.EventHandler(this.btnChangeText_Click);


            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelMessage.Location = new System.Drawing.Point(40, 30);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(226, 28);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "Welcome to Events Lab";


            this.comboColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboColors.FormattingEnabled = true;
            this.comboColors.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.comboColors.Location = new System.Drawing.Point(40, 100);
            this.comboColors.Name = "comboColors";
            this.comboColors.Size = new System.Drawing.Size(150, 28);
            this.comboColors.TabIndex = 3;


            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 240);
            this.Controls.Add(this.comboColors);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.btnChangeText);
            this.Controls.Add(this.btnChangeColor);
            this.Name = "Form1";
            this.Text = "Event Playground";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnChangeText;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.ComboBox comboColors;
    }
}
