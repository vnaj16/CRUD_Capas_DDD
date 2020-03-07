using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Models;
using Negocio.ValueObjects;

namespace Presentacion.Forms
{
    public partial class FormEmployee : Form
    {
        private EmployeeModel employee = new EmployeeModel();
        public FormEmployee()
        {
            InitializeComponent();
            panel1.Enabled = false;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void LoadGridView()
        {
            try
            {
                dataGridView1.DataSource = employee.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = employee.FindByID(TextBox_Buscar.Text);
            }
            catch (Exception ex)
            {
                dataGridView1.DataSource = employee.GetAll();
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = employee.FindByID(TextBox_Buscar.Text);
            }
            catch (Exception ex)
            {
                dataGridView1.DataSource = employee.GetAll();
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            employee.DNI = TextBox_DNI.Text;
            employee.Nombre = TextBox_Nombre.Text;
            employee.Mail = TextBox_Email.Text;
            employee.Birthday = dateTimePicker1.Value;

            bool Valid = new Helps.DataValidation(employee).Validate();

            if (Valid)
            {
                string Result = employee.SaveChanges();
                MessageBox.Show(Result);
                //Actualizar lista
                LoadGridView();
                CleanPanel();
            }
            else
            {

            }

        }

        private void Button_New_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            employee.State = EntityState.Added;
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                panel1.Enabled = true;
                employee.State = EntityState.Modified;
                employee.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                TextBox_DNI.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TextBox_Nombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                TextBox_Email.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
            }
            else
            {
                MessageBox.Show("Seleccionar una fila");
            }
        }

        private void CleanPanel()
        {
            TextBox_DNI.Clear();
            TextBox_Nombre.Clear();
            TextBox_Email.Clear();
            //dateTimePicker1.Value = null;
            panel1.Enabled = false;
        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                panel1.Enabled = false;
                employee.State = EntityState.Deleted;
                employee.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                string Result = employee.SaveChanges();

                MessageBox.Show(Result);
                LoadGridView();
            }
            else
            {
                MessageBox.Show("Seleccionar una fila");
            }
        }
    }
}
