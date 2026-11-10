using System.ComponentModel.Design.Serialization;
using System.Data.SQLite;

namespace Base_de_datos_SQLite
{
    public partial class Form1 : Form
    {
        //Agregamos la base de datos
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";
        //la base de datos se crea en la carpeta debug 
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Create_db();
            data_show();
        }
        private void data_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM test";
            var cdm = new SQLiteCommand(stm, con);
            dr = cdm.ExecuteReader();
            while (dr.Read())
            {
                datagv.Rows.Insert(0, dr.GetString(0), dr.GetString(1));
            }
        }
        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table test(name varchar(20), id varchar(20))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("la base de datos no se puede crear");
                return;
            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "INSERT INTO test(name, id) VALUES(@name, @id)";
                string NAME = txtNombre.Text;
                string ID = txtId.Text;
                cmd.Parameters.AddWithValue("@name", NAME);
                cmd.Parameters.AddWithValue("@id", ID);

                datagv.ColumnCount = 2;
                datagv.Columns[0].Name = "Nombre";
                datagv.Columns[1].Name = "Id";
                string[] row = new string[] { NAME, ID };
                datagv.Rows.Add(row);
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo instertar la informacion");
                return;
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "UPDATE test SET id=@id WHERE name=@name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", txtNombre.Text);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.ExecuteNonQuery();
                datagv.Rows.Clear();
                data_show();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo actualizar la informcion");
                return;
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var con=new SQLiteConnection(cs);
            con.Open();
            var cmd=new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "DELETE FROM test WHERE name=@name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", txtNombre.Text);
                cmd.ExecuteNonQuery();
                datagv.Rows.Clear();
                data_show();
            }
            catch(Exception)
            {
                MessageBox.Show("No se pudo eliminaar la informacion");
                return;
            }
        }
    }
}
