namespace FoodTracker
{
    partial class Form1
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.grpFood = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMeal = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.grpFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(22, 210);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(776, 368);
            this.dgvData.TabIndex = 3;
            // 
            // grpFood
            // 
            this.grpFood.Controls.Add(this.button4);
            this.grpFood.Controls.Add(this.button3);
            this.grpFood.Controls.Add(this.button2);
            this.grpFood.Controls.Add(this.cmbMeal);
            this.grpFood.Controls.Add(this.label2);
            this.grpFood.Controls.Add(this.button1);
            this.grpFood.Controls.Add(this.dtpDate);
            this.grpFood.Controls.Add(this.lblDate);
            this.grpFood.Controls.Add(this.txtFood);
            this.grpFood.Controls.Add(this.label1);
            this.grpFood.Location = new System.Drawing.Point(23, 12);
            this.grpFood.Name = "grpFood";
            this.grpFood.Size = new System.Drawing.Size(776, 181);
            this.grpFood.TabIndex = 4;
            this.grpFood.TabStop = false;
            this.grpFood.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food";
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(43, 24);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(348, 20);
            this.txtFood.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(479, 34);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(527, 27);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Meal";
            // 
            // cmbMeal
            // 
            this.cmbMeal.FormattingEnabled = true;
            this.cmbMeal.Location = new System.Drawing.Point(43, 125);
            this.cmbMeal.Name = "cmbMeal";
            this.cmbMeal.Size = new System.Drawing.Size(121, 21);
            this.cmbMeal.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(369, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(466, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 642);
            this.Controls.Add(this.grpFood);
            this.Controls.Add(this.dgvData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.grpFood.ResumeLayout(false);
            this.grpFood.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox grpFood;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbMeal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.Label label1;
    }
}

