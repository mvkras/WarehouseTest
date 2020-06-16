namespace TestWarehouseProject.UpdateForms
{
    partial class UpdatePicketForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateNumber_Of_Picket_textbox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.UpdatePicket_id_comboBox = new System.Windows.Forms.ComboBox();
            this.Update_id_Warehouse_in_Picket_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберете id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер пикета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "id_Склада";
            // 
            // UpdateNumber_Of_Picket_textbox
            // 
            this.UpdateNumber_Of_Picket_textbox.Location = new System.Drawing.Point(129, 90);
            this.UpdateNumber_Of_Picket_textbox.Name = "UpdateNumber_Of_Picket_textbox";
            this.UpdateNumber_Of_Picket_textbox.Size = new System.Drawing.Size(121, 20);
            this.UpdateNumber_Of_Picket_textbox.TabIndex = 4;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(168, 191);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(16, 191);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 6;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            // 
            // UpdatePicket_id_comboBox
            // 
            this.UpdatePicket_id_comboBox.FormattingEnabled = true;
            this.UpdatePicket_id_comboBox.Location = new System.Drawing.Point(129, 45);
            this.UpdatePicket_id_comboBox.Name = "UpdatePicket_id_comboBox";
            this.UpdatePicket_id_comboBox.Size = new System.Drawing.Size(121, 21);
            this.UpdatePicket_id_comboBox.TabIndex = 8;
            // 
            // Update_id_Warehouse_in_Picket_comboBox
            // 
            this.Update_id_Warehouse_in_Picket_comboBox.FormattingEnabled = true;
            this.Update_id_Warehouse_in_Picket_comboBox.Location = new System.Drawing.Point(129, 133);
            this.Update_id_Warehouse_in_Picket_comboBox.Name = "Update_id_Warehouse_in_Picket_comboBox";
            this.Update_id_Warehouse_in_Picket_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Update_id_Warehouse_in_Picket_comboBox.TabIndex = 9;
            // 
            // UpdatePicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 277);
            this.Controls.Add(this.Update_id_Warehouse_in_Picket_comboBox);
            this.Controls.Add(this.UpdatePicket_id_comboBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.UpdateNumber_Of_Picket_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePicketForm";
            this.Text = "UpdatePicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UpdateNumber_Of_Picket_textbox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.ComboBox UpdatePicket_id_comboBox;
        private System.Windows.Forms.ComboBox Update_id_Warehouse_in_Picket_comboBox;
    }
}