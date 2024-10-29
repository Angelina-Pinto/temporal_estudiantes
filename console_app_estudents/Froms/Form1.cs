using console_app_estudents.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace console_app_estudents
{
    public partial class Form1 : Form
    {
        private void AddStudentToListView(studentt student)
        {
            // Crear un ListViewItem con los datos del estudiante
            ListViewItem item = new ListViewItem(student.name);
            item.SubItems.Add(student.apellido);
            item.SubItems.Add(student.edad.ToString());

            // Agregar el item al ListView
            listView1.Items.Add(item);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 newForm = new Form2();
            this.Hide();
            newForm.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string apellido = textBox2.Text;
            int edad = int.Parse(textBox3.Text);

            studentt newStudent = new studentt(name, apellido, edad);

            studentt.StudentsList.Add(newStudent);

            AddStudentToListView(newStudent);

            // Limpiar las cajas de texto después de agregar
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            var item = listView1.GetItemAt(e.X, e.Y);
            if (item != null)
            {
                // Determina cuál celda fue clickeada
                int subItemIndex = item.SubItems.IndexOf(item.GetSubItemAt(e.X, e.Y));

                // Obtiene el contenido de la celda seleccionada
                string cellContent = item.SubItems[subItemIndex].Text;

                // Muestra el contenido de la celda
                MessageBox.Show($"Has seleccionado la celda: {cellContent}");
            }
        }
    }
}
