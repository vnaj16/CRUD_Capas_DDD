namespace Presentacion.Forms
{
    partial class FormEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextBox_Buscar = new System.Windows.Forms.TextBox();
            this.Button_Remove = new System.Windows.Forms.Button();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.Button_New = new System.Windows.Forms.Button();
            this.DNI = new System.Windows.Forms.Label();
            this.TextBox_DNI = new System.Windows.Forms.TextBox();
            this.TextBox_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_Save = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Button_Buscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Button_Save);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBox_Email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextBox_Nombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBox_DNI);
            this.panel1.Controls.Add(this.DNI);
            this.panel1.Location = new System.Drawing.Point(540, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 381);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 282);
            this.dataGridView1.TabIndex = 1;
            // 
            // TextBox_Buscar
            // 
            this.TextBox_Buscar.Location = new System.Drawing.Point(12, 21);
            this.TextBox_Buscar.Name = "TextBox_Buscar";
            this.TextBox_Buscar.Size = new System.Drawing.Size(457, 20);
            this.TextBox_Buscar.TabIndex = 2;
            this.TextBox_Buscar.TextChanged += new System.EventHandler(this.TextBox_Buscar_TextChanged);
            // 
            // Button_Remove
            // 
            this.Button_Remove.Location = new System.Drawing.Point(254, 365);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Size = new System.Drawing.Size(75, 28);
            this.Button_Remove.TabIndex = 3;
            this.Button_Remove.Text = "Remove";
            this.Button_Remove.UseVisualStyleBackColor = true;
            this.Button_Remove.Click += new System.EventHandler(this.Button_Remove_Click);
            // 
            // Button_Edit
            // 
            this.Button_Edit.Location = new System.Drawing.Point(359, 365);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(75, 28);
            this.Button_Edit.TabIndex = 4;
            this.Button_Edit.Text = "Edit";
            this.Button_Edit.UseVisualStyleBackColor = true;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // Button_New
            // 
            this.Button_New.Location = new System.Drawing.Point(458, 365);
            this.Button_New.Name = "Button_New";
            this.Button_New.Size = new System.Drawing.Size(75, 28);
            this.Button_New.TabIndex = 5;
            this.Button_New.Text = "New";
            this.Button_New.UseVisualStyleBackColor = true;
            this.Button_New.Click += new System.EventHandler(this.Button_New_Click);
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(15, 15);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(26, 13);
            this.DNI.TabIndex = 0;
            this.DNI.Text = "DNI";
            // 
            // TextBox_DNI
            // 
            this.TextBox_DNI.Location = new System.Drawing.Point(18, 32);
            this.TextBox_DNI.Name = "TextBox_DNI";
            this.TextBox_DNI.Size = new System.Drawing.Size(210, 20);
            this.TextBox_DNI.TabIndex = 1;
            // 
            // TextBox_Nombre
            // 
            this.TextBox_Nombre.Location = new System.Drawing.Point(18, 84);
            this.TextBox_Nombre.Name = "TextBox_Nombre";
            this.TextBox_Nombre.Size = new System.Drawing.Size(210, 20);
            this.TextBox_Nombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // TextBox_Email
            // 
            this.TextBox_Email.Location = new System.Drawing.Point(18, 135);
            this.TextBox_Email.Name = "TextBox_Email";
            this.TextBox_Email.Size = new System.Drawing.Size(210, 20);
            this.TextBox_Email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birthday";
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(80, 256);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(95, 35);
            this.Button_Save.TabIndex = 7;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 187);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // Button_Buscar
            // 
            this.Button_Buscar.Location = new System.Drawing.Point(474, 19);
            this.Button_Buscar.Name = "Button_Buscar";
            this.Button_Buscar.Size = new System.Drawing.Size(48, 21);
            this.Button_Buscar.TabIndex = 6;
            this.Button_Buscar.Text = "Buscar";
            this.Button_Buscar.UseVisualStyleBackColor = true;
            this.Button_Buscar.Click += new System.EventHandler(this.Button_Buscar_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.Button_Buscar);
            this.Controls.Add(this.Button_New);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.Button_Remove);
            this.Controls.Add(this.TextBox_Buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_DNI;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TextBox_Buscar;
        private System.Windows.Forms.Button Button_Remove;
        private System.Windows.Forms.Button Button_Edit;
        private System.Windows.Forms.Button Button_New;
        private System.Windows.Forms.Button Button_Buscar;
    }
}