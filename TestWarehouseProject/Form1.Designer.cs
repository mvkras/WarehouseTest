namespace TestWarehouseProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.MaindataGridView = new System.Windows.Forms.DataGridView();
            this.SelectButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.History_of_Area_Button = new System.Windows.Forms.Button();
            this.History_of_Cargo_Button = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MaindataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(13, 13);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTables.TabIndex = 0;
            this.comboBoxTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxTables_SelectedIndexChanged);
            // 
            // MaindataGridView
            // 
            this.MaindataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaindataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.MaindataGridView.Location = new System.Drawing.Point(13, 41);
            this.MaindataGridView.Name = "MaindataGridView";
            this.MaindataGridView.Size = new System.Drawing.Size(775, 359);
            this.MaindataGridView.TabIndex = 1;
            // 
            // SelectButton
            // 
            this.SelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectButton.Location = new System.Drawing.Point(141, 13);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 23);
            this.SelectButton.TabIndex = 2;
            this.SelectButton.Text = "SELECT";
            this.SelectButton.UseVisualStyleBackColor = true;
            // 
            // InsertButton
            // 
            this.InsertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertButton.Location = new System.Drawing.Point(223, 13);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "INSERT";
            this.InsertButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.Location = new System.Drawing.Point(305, 13);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Location = new System.Drawing.Point(387, 13);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // History_of_Area_Button
            // 
            this.History_of_Area_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.History_of_Area_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.History_of_Area_Button.Location = new System.Drawing.Point(13, 407);
            this.History_of_Area_Button.Name = "History_of_Area_Button";
            this.History_of_Area_Button.Size = new System.Drawing.Size(203, 31);
            this.History_of_Area_Button.TabIndex = 6;
            this.History_of_Area_Button.Text = "История площадок";
            this.History_of_Area_Button.UseVisualStyleBackColor = true;
            // 
            // History_of_Cargo_Button
            // 
            this.History_of_Cargo_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.History_of_Cargo_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.History_of_Cargo_Button.Location = new System.Drawing.Point(585, 407);
            this.History_of_Cargo_Button.Name = "History_of_Cargo_Button";
            this.History_of_Cargo_Button.Size = new System.Drawing.Size(203, 31);
            this.History_of_Cargo_Button.TabIndex = 7;
            this.History_of_Cargo_Button.Text = "История грузов";
            this.History_of_Cargo_Button.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.Location = new System.Drawing.Point(712, 13);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 8;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.History_of_Cargo_Button);
            this.Controls.Add(this.History_of_Area_Button);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.MaindataGridView);
            this.Controls.Add(this.comboBoxTables);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaindataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.DataGridView MaindataGridView;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button History_of_Area_Button;
        private System.Windows.Forms.Button History_of_Cargo_Button;
        private System.Windows.Forms.Button RefreshButton;
    }
}

