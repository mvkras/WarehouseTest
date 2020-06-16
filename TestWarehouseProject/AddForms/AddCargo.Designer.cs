namespace TestWarehouseProject.AddForms
{
    partial class AddCargo
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
            this.CountCargo_textBox = new System.Windows.Forms.TextBox();
            this.id_Area_in_Cargo_textBox = new System.Windows.Forms.TextBox();
            this.id_Picket_in_Cargo_textBox = new System.Windows.Forms.TextBox();
            this.id_Warehouse_in_Cargo_textBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество груза (т)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(74, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "id_Площадки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(77, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "id_Пикета";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(77, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "id_Склада";
            // 
            // CountCargo_textBox
            // 
            this.CountCargo_textBox.Location = new System.Drawing.Point(179, 36);
            this.CountCargo_textBox.Name = "CountCargo_textBox";
            this.CountCargo_textBox.Size = new System.Drawing.Size(117, 20);
            this.CountCargo_textBox.TabIndex = 4;
            // 
            // id_Area_in_Cargo_textBox
            // 
            this.id_Area_in_Cargo_textBox.Location = new System.Drawing.Point(179, 82);
            this.id_Area_in_Cargo_textBox.Name = "id_Area_in_Cargo_textBox";
            this.id_Area_in_Cargo_textBox.Size = new System.Drawing.Size(117, 20);
            this.id_Area_in_Cargo_textBox.TabIndex = 5;
            // 
            // id_Picket_in_Cargo_textBox
            // 
            this.id_Picket_in_Cargo_textBox.Location = new System.Drawing.Point(179, 134);
            this.id_Picket_in_Cargo_textBox.Name = "id_Picket_in_Cargo_textBox";
            this.id_Picket_in_Cargo_textBox.Size = new System.Drawing.Size(117, 20);
            this.id_Picket_in_Cargo_textBox.TabIndex = 6;
            // 
            // id_Warehouse_in_Cargo_textBox
            // 
            this.id_Warehouse_in_Cargo_textBox.Location = new System.Drawing.Point(179, 183);
            this.id_Warehouse_in_Cargo_textBox.Name = "id_Warehouse_in_Cargo_textBox";
            this.id_Warehouse_in_Cargo_textBox.Size = new System.Drawing.Size(117, 20);
            this.id_Warehouse_in_Cargo_textBox.TabIndex = 7;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(217, 242);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(80, 242);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // AddCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 312);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.id_Warehouse_in_Cargo_textBox);
            this.Controls.Add(this.id_Picket_in_Cargo_textBox);
            this.Controls.Add(this.id_Area_in_Cargo_textBox);
            this.Controls.Add(this.CountCargo_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCargo";
            this.Text = "AddCargo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CountCargo_textBox;
        private System.Windows.Forms.TextBox id_Area_in_Cargo_textBox;
        private System.Windows.Forms.TextBox id_Picket_in_Cargo_textBox;
        private System.Windows.Forms.TextBox id_Warehouse_in_Cargo_textBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
    }
}