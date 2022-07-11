using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        MySqlConnection mysqlCon = new MySqlConnection(@"Server=localhost;Database=libros;Uid=root;Pwd=123");
        public Form1()
        {
            InitializeComponent();
            llenarDGVLibros();
        }

        private void llenarDGVLibros()
        {
            string sqlSelect = "SELECT * FROM libros;";
            MySqlCommand mysqlCmd = new MySqlCommand(sqlSelect, mysqlCon);
            MySqlDataAdapter mysqlDA = new MySqlDataAdapter(mysqlCmd);
            DataTable tabla = new DataTable();
            mysqlDA.Fill(tabla);
            dgvComics.DataSource = tabla;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool check = true;
            string msg = "";

            if (txtNombre.Text.Equals(""))
            {
                check = false;
                msg += "\nSe requiere nombre del libro";
            }

            if (txtAutor.Text.Equals(""))
            {
                check = false;
                msg += "\nSe requiere el tipo de libro";
            }

          

            if(check)
            {
                mysqlCon.Open();
                String sqlInsert = "INSERT INTO `libros`(`nombre`,`autor`) VALUES (?, ?);";
                MySqlCommand mysqlCmd = new MySqlCommand(sqlInsert, mysqlCon);
                mysqlCmd.CommandType = CommandType.Text;
                mysqlCmd.Parameters.AddWithValue("nombre", txtNombre.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("autor", txtAutor.Text.Trim());
                

                if (mysqlCmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("libro Ingresado Correctamente!");
                    txtNombre.Text = "";
                    txtAutor.Text = "";
                    llenarDGVLibros();
                } else
                {
                    MessageBox.Show("Error!!");
                }
            }
            else
            {
                MessageBox.Show("Todos los Campos son Obligatorios!" + msg);
            }
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool check = true;
            string msg = "";

            int id = 0;

            foreach (DataGridViewRow row in dgvComics.SelectedRows)
            {
                id = Convert.ToInt32(row.Cells[0].Value.ToString());
            }

            if (txtNombreModificado.Text.Equals(""))
            {
                check = false;
                msg += "\nNombre libro";
            }
            if (txtAutorModificado.Text.Equals(""))
            {
                check = false;
                msg += "\nAutor libro";
            }
            

            if (check)
            {
                mysqlCon.Open();
                String sqlUpdate = "UPDATE `libros` SET `nombre` = ?, `autor` = ? WHERE `id` = ?;";
                MySqlCommand mysqlCmd = new MySqlCommand(sqlUpdate, mysqlCon);
                mysqlCmd.CommandType = CommandType.Text;
                mysqlCmd.Parameters.AddWithValue("nombre", txtNombreModificado.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("autor", txtAutorModificado.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("id", id );
                if (mysqlCmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Modificado Correctamente!");
                    txtNombreModificado.Text = "";
                    txtAutorModificado.Text = "";
                    
                    llenarDGVLibros();
                }
                else
                {
                    MessageBox.Show("Upps Ocurrio un Error!!");
                }
                mysqlCon.Close();
            }
            else
            {
                MessageBox.Show("Todos los Campos son Obligatorios!" + msg);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //bool check = true;
            //string msg = "";
            int id = 0;
            foreach (DataGridViewRow row in dgvComics.SelectedRows)
            {
                id = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
            mysqlCon.Open();
            String sqlDelete = "DELETE FROM `libros` WHERE `id` = ?;";
            MySqlCommand mysqlCmd = new MySqlCommand(sqlDelete, mysqlCon);
            mysqlCmd.CommandType = CommandType.Text;
            mysqlCmd.Parameters.AddWithValue("id", id);
            if (mysqlCmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Eliminado Correctamente!");
                llenarDGVLibros();
            }
            else
            {
                MessageBox.Show("Error!!");
            }
            mysqlCon.Close();
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSeleccionar_Click(object sender, EventArgs e)
        {

        }
    }
}
