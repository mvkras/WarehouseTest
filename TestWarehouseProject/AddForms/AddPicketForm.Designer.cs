namespace TestWarehouseProject.AddForms
{
    partial class AddPicketForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PicketNumber_Label = new System.Windows.Forms.Label();
            this.id_WarehouseLabel = new System.Windows.Forms.Label();
            this.Number_of_Picket_textBox = new System.Windows.Forms.TextBox();
            this.id_Warehouse_in_Picket_textBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(16, 167);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(153, 167);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // PicketNumber_Label
            // 
            this.PicketNumber_Label.AutoSize = true;
            this.PicketNumber_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PicketNumber_Label.Location = new System.Drawing.Point(13, 47);
            this.PicketNumber_Label.Name = "PicketNumber_Label";
            this.PicketNumber_Label.Size = new System.Drawing.Size(90, 15);
            this.PicketNumber_Label.TabIndex = 2;
            this.PicketNumber_Label.Text = "Номер пикета";
            // 
            // id_WarehouseLabel
            // 
            this.id_WarehouseLabel.AutoSize = true;
            this.id_WarehouseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_WarehouseLabel.Location = new System.Drawing.Point(13, 84);
            this.id_WarehouseLabel.Name = "id_WarehouseLabel";
            this.id_WarehouseLabel.Size = new System.Drawing.Size(66, 15);
            this.id_WarehouseLabel.TabIndex = 3;
            this.id_WarehouseLabel.Text = "id_Склада";
            // 
            // Number_of_Picket_textBox
            // 
            this.Number_of_Picket_textBox.Location = new System.Drawing.Point(109, 47);
            this.Number_of_Picket_textBox.Name = "Number_of_Picket_textBox";
            this.Number_of_Picket_textBox.Size = new System.Drawing.Size(119, 20);
            this.Number_of_Picket_textBox.TabIndex = 4;
            // 
            // id_Warehouse_in_Picket_textBox
            // 
            this.id_Warehouse_in_Picket_textBox.Location = new System.Drawing.Point(109, 84);
            this.id_Warehouse_in_Picket_textBox.Name = "id_Warehouse_in_Picket_textBox";
            this.id_Warehouse_in_Picket_textBox.Size = new System.Drawing.Size(119, 20);
            this.id_Warehouse_in_Picket_textBox.TabIndex = 5;
            // 
            // AddPicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 252);
            this.Controls.Add(this.id_Warehouse_in_Picket_textBox);
            this.Controls.Add(this.Number_of_Picket_textBox);
            this.Controls.Add(this.id_WarehouseLabel);
            this.Controls.Add(this.PicketNumber_Label);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Name = "AddPicketForm";
            this.Text = "AddPicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label PicketNumber_Label;
        private System.Windows.Forms.Label id_WarehouseLabel;
        private System.Windows.Forms.TextBox Number_of_Picket_textBox;
        private System.Windows.Forms.TextBox id_Warehouse_in_Picket_textBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}