namespace TestWarehouseProject.UpdateForms
{
    partial class UpdateWarehouseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateWarehouseNumber_textbox = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.UpdateWarehouse_id_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберете id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Новое  название";
            // 
            // UpdateWarehouseNumber_textbox
            // 
            this.UpdateWarehouseNumber_textbox.Location = new System.Drawing.Point(139, 101);
            this.UpdateWarehouseNumber_textbox.Name = "UpdateWarehouseNumber_textbox";
            this.UpdateWarehouseNumber_textbox.Size = new System.Drawing.Size(131, 20);
            this.UpdateWarehouseNumber_textbox.TabIndex = 3;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(43, 160);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 4;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(195, 160);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // UpdateWarehouse_id_comboBox
            // 
            this.UpdateWarehouse_id_comboBox.FormattingEnabled = true;
            this.UpdateWarehouse_id_comboBox.Location = new System.Drawing.Point(140, 51);
            this.UpdateWarehouse_id_comboBox.Name = "UpdateWarehouse_id_comboBox";
            this.UpdateWarehouse_id_comboBox.Size = new System.Drawing.Size(130, 21);
            this.UpdateWarehouse_id_comboBox.TabIndex = 6;
            // 
            // UpdateWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 241);
            this.Controls.Add(this.UpdateWarehouse_id_comboBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.UpdateWarehouseNumber_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateWarehouseForm";
            this.Text = "UpdateWarehouseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UpdateWarehouseNumber_textbox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ComboBox UpdateWarehouse_id_comboBox;
    }
}