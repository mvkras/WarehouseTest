namespace TestWarehouseProject.AddForms
{
    partial class AddAreaForm
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
            this.NumberOfArea_textBox = new System.Windows.Forms.TextBox();
            this.id_Picket_in_Area_textBox = new System.Windows.Forms.TextBox();
            this.Id_Warehouse_in_Area_textBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер площадки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "id_Пикета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "id_Склада";
            // 
            // NumberOfArea_textBox
            // 
            this.NumberOfArea_textBox.Location = new System.Drawing.Point(125, 36);
            this.NumberOfArea_textBox.Name = "NumberOfArea_textBox";
            this.NumberOfArea_textBox.Size = new System.Drawing.Size(133, 20);
            this.NumberOfArea_textBox.TabIndex = 3;
            // 
            // id_Picket_in_Area_textBox
            // 
            this.id_Picket_in_Area_textBox.Location = new System.Drawing.Point(125, 81);
            this.id_Picket_in_Area_textBox.Name = "id_Picket_in_Area_textBox";
            this.id_Picket_in_Area_textBox.Size = new System.Drawing.Size(133, 20);
            this.id_Picket_in_Area_textBox.TabIndex = 4;
            // 
            // Id_Warehouse_in_Area_textBox
            // 
            this.Id_Warehouse_in_Area_textBox.Location = new System.Drawing.Point(125, 120);
            this.Id_Warehouse_in_Area_textBox.Name = "Id_Warehouse_in_Area_textBox";
            this.Id_Warehouse_in_Area_textBox.Size = new System.Drawing.Size(133, 20);
            this.Id_Warehouse_in_Area_textBox.TabIndex = 5;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(183, 181);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(46, 181);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // AddAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 291);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Id_Warehouse_in_Area_textBox);
            this.Controls.Add(this.id_Picket_in_Area_textBox);
            this.Controls.Add(this.NumberOfArea_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAreaForm";
            this.Text = "AddAreaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumberOfArea_textBox;
        private System.Windows.Forms.TextBox id_Picket_in_Area_textBox;
        private System.Windows.Forms.TextBox Id_Warehouse_in_Area_textBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
    }
}