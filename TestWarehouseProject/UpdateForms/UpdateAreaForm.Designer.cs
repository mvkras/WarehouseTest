namespace TestWarehouseProject.UpdateForms
{
    partial class UpdateAreaForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.Update_id_Area_comboBox = new System.Windows.Forms.ComboBox();
            this.Update_idPicket_in_Area_comboBox = new System.Windows.Forms.ComboBox();
            this.Update_idWarehouse_in_Area_comboBox = new System.Windows.Forms.ComboBox();
            this.Update_AreaNumber_textBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберете id ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер \r\nплощадки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "id_Склада";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "id_Пикета";
            // 
            // Update_id_Area_comboBox
            // 
            this.Update_id_Area_comboBox.FormattingEnabled = true;
            this.Update_id_Area_comboBox.Location = new System.Drawing.Point(125, 35);
            this.Update_id_Area_comboBox.Name = "Update_id_Area_comboBox";
            this.Update_id_Area_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Update_id_Area_comboBox.TabIndex = 4;
            // 
            // Update_idPicket_in_Area_comboBox
            // 
            this.Update_idPicket_in_Area_comboBox.FormattingEnabled = true;
            this.Update_idPicket_in_Area_comboBox.Location = new System.Drawing.Point(125, 128);
            this.Update_idPicket_in_Area_comboBox.Name = "Update_idPicket_in_Area_comboBox";
            this.Update_idPicket_in_Area_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Update_idPicket_in_Area_comboBox.TabIndex = 5;
            // 
            // Update_idWarehouse_in_Area_comboBox
            // 
            this.Update_idWarehouse_in_Area_comboBox.FormattingEnabled = true;
            this.Update_idWarehouse_in_Area_comboBox.Location = new System.Drawing.Point(125, 170);
            this.Update_idWarehouse_in_Area_comboBox.Name = "Update_idWarehouse_in_Area_comboBox";
            this.Update_idWarehouse_in_Area_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Update_idWarehouse_in_Area_comboBox.TabIndex = 6;
            // 
            // Update_AreaNumber_textBox
            // 
            this.Update_AreaNumber_textBox.Location = new System.Drawing.Point(125, 81);
            this.Update_AreaNumber_textBox.Name = "Update_AreaNumber_textBox";
            this.Update_AreaNumber_textBox.Size = new System.Drawing.Size(121, 20);
            this.Update_AreaNumber_textBox.TabIndex = 7;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(172, 223);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(20, 223);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 8;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            // 
            // UpdateAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 294);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.Update_AreaNumber_textBox);
            this.Controls.Add(this.Update_idWarehouse_in_Area_comboBox);
            this.Controls.Add(this.Update_idPicket_in_Area_comboBox);
            this.Controls.Add(this.Update_id_Area_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateAreaForm";
            this.Text = "UpdateAreaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Update_id_Area_comboBox;
        private System.Windows.Forms.ComboBox Update_idPicket_in_Area_comboBox;
        private System.Windows.Forms.ComboBox Update_idWarehouse_in_Area_comboBox;
        private System.Windows.Forms.TextBox Update_AreaNumber_textBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ChangeButton;
    }
}