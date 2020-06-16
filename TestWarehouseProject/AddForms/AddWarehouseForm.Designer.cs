namespace TestWarehouseProject
{
    partial class AddWarehouseForm
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
            this.WarehouseName_label = new System.Windows.Forms.Label();
            this.WarehouseName_textBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WarehouseName_label
            // 
            this.WarehouseName_label.AutoSize = true;
            this.WarehouseName_label.Location = new System.Drawing.Point(13, 59);
            this.WarehouseName_label.Name = "WarehouseName_label";
            this.WarehouseName_label.Size = new System.Drawing.Size(96, 13);
            this.WarehouseName_label.TabIndex = 0;
            this.WarehouseName_label.Text = "Название склада";
            // 
            // WarehouseName_textBox
            // 
            this.WarehouseName_textBox.Location = new System.Drawing.Point(116, 59);
            this.WarehouseName_textBox.Name = "WarehouseName_textBox";
            this.WarehouseName_textBox.Size = new System.Drawing.Size(144, 20);
            this.WarehouseName_textBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(16, 141);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(169, 140);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 232);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.WarehouseName_textBox);
            this.Controls.Add(this.WarehouseName_label);
            this.Name = "AddWarehouseForm";
            this.Text = "AddWarehouseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WarehouseName_label;
        private System.Windows.Forms.TextBox WarehouseName_textBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
    }
}