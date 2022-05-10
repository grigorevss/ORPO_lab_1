using Npgsql;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORPO_lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isNeedCreate = false;

        SQLiteDataAdapter adapterSQLite = null;
        System.Data.DataTable dataTableSQLite = null;
        BindingSource bsSQLite = new BindingSource();

        private void SQLiteFill_Click(object sender, EventArgs e)
        {
            bool isNeedCreate = false;
            if (!System.IO.File.Exists(@"Db.db"))
            {
                isNeedCreate = true;
            }
            SQLiteConnection conn = new SQLiteConnection("Data Source=Db.db;foreign keys=true;Version=3;journal mode=Off;synchronous = OFF");
            try
            {
                conn.Open();
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    return;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            if (isNeedCreate)
            {
                string[] createTableSQL = { "CREATE TABLE AnotherTusurMainEntity(id INTEGER PRIMARY KEY AUTOINCREMENT, value_1 INTEGER, value_2 INTEGER, value_3 REAL, value_4 REAL)" };
                string[] insertTableSQL = { "INSERT INTO AnotherTusurMainEntity(value_1,value_2,value_3,value_4) values(1,1,3.14,2.7)",
                                            "INSERT INTO AnotherTusurMainEntity(value_1,value_2,value_3,value_4) values(2,2,5.12,7.77)",
                                            "INSERT INTO AnotherTusurMainEntity(value_1,value_2,value_3,value_4) values(5,2,66.6,98.1)",
                                            "INSERT INTO AnotherTusurMainEntity(value_1,value_2,value_3,value_4) values(55,11,234.123,2.123)",
                                            "INSERT INTO AnotherTusurMainEntity(value_1,value_2,value_3,value_4) values(987,54,3333.1111,123.456)",
                                            "INSERT INTO AnotherTusurMainEntity(value_1,value_2,value_3,value_4) values(3,4,8.54,4.2)",
                                            "INSERT INTO AnotherTusurMainEntity(value_1,value_2,value_3,value_4) values(32,66,8.111123,767.909)"};
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    for (int i = 0; i < createTableSQL.Length; i++)
                    {
                        try
                        {
                            SQLiteCommand command = new SQLiteCommand(createTableSQL[i], conn);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.Message);
                        }
                    }
                    for (int i = 0; i < insertTableSQL.Length; i++)
                    {
                        try
                        {
                            SQLiteCommand command = new SQLiteCommand(insertTableSQL[i], conn);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.Message);
                            return;
                        }
                    }
                }
            }
            if (adapterSQLite == null)
            {
                adapterSQLite = new SQLiteDataAdapter("SELECT id,value_1,value_2,value_3,value_4 FROM AnotherTusurMainEntity ", conn);
                dataTableSQLite = new DataTable();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = conn;
                command.CommandText = "INSERT INTO AnotherTusurMainEntity(value_1,value_2,value_3,value_4) values(@value_1,@value_2,@value_3,@value_4)";
                SQLiteParameter par = new SQLiteParameter();
                par.ParameterName = "@value_1";
                par.SourceColumn = "value_1";
                par.SourceVersion = System.Data.DataRowVersion.Current;
                par.DbType = System.Data.DbType.Int64;
                command.Parameters.Add(par);
                par = new SQLiteParameter();
                par.ParameterName = "@value_2";
                par.SourceColumn = "value_2";
                par.SourceVersion = System.Data.DataRowVersion.Current;
                par.DbType = System.Data.DbType.Int64;
                command.Parameters.Add(par);
                par = new SQLiteParameter();
                par.ParameterName = "@value_3";
                par.SourceColumn = "value_3";
                par.SourceVersion = System.Data.DataRowVersion.Current;
                par.DbType = System.Data.DbType.Double;
                command.Parameters.Add(par);
                par = new SQLiteParameter();
                par.ParameterName = "@value_4";
                par.SourceColumn = "value_4";
                par.SourceVersion = System.Data.DataRowVersion.Current;
                par.DbType = System.Data.DbType.Double;
                command.Parameters.Add(par);
                adapterSQLite.InsertCommand = command;
                command = new SQLiteCommand();
                command.Connection = conn;
                command.CommandText = "UPDATE AnotherTusurMainEntity SET value_1=@value_1,value_2=@value_2,value_3=@value_3,value_4=@value_4 WHERE id=@id";
                par = new SQLiteParameter();
                par.ParameterName = "@id";
                par.SourceColumn = "id";
                par.SourceVersion = System.Data.DataRowVersion.Original;
                par.DbType = System.Data.DbType.Int64;
                command.Parameters.Add(par);
                par = new SQLiteParameter();
                par.ParameterName = "@value_1";
                par.SourceColumn = "value_1";
                par.SourceVersion = System.Data.DataRowVersion.Current;
                par.DbType = System.Data.DbType.Int64;
                command.Parameters.Add(par);
                par = new SQLiteParameter();
                par.ParameterName = "@value_2";
                par.SourceColumn = "value_2";
                par.SourceVersion = System.Data.DataRowVersion.Current;
                par.DbType = System.Data.DbType.Int64;
                command.Parameters.Add(par);
                par = new SQLiteParameter();
                par.ParameterName = "@value_3";
                par.SourceColumn = "value_3";
                par.SourceVersion = System.Data.DataRowVersion.Current;
                par.DbType = System.Data.DbType.Double;
                command.Parameters.Add(par);
                par = new SQLiteParameter();
                par.ParameterName = "@value_4";
                par.SourceColumn = "value_4";
                par.SourceVersion = System.Data.DataRowVersion.Current;
                par.DbType = System.Data.DbType.Double;
                command.Parameters.Add(par);
                adapterSQLite.UpdateCommand = command;
                bsSQLite.DataSource = dataTableSQLite;
                bindingNavigatorSQLite.BindingSource = bsSQLite;
                dataGridViewSQLite.DataSource = bsSQLite;
                adapterSQLite.Fill(dataTableSQLite);
                dataGridViewSQLite.Columns[0].Visible = false;
            }
        }

        private void SQLiteUpdate_Click(object sender, EventArgs e)
        {
            dataGridViewSQLite.EndEdit();
            bsSQLite.EndEdit();
            if (adapterSQLite != null)
            {
                adapterSQLite.Update(dataTableSQLite);
            }
        }

        Npgsql.NpgsqlDataAdapter adapterNpgsql = null;
        System.Data.DataTable dataTableNpgsql = null;
        BindingSource bsNpgsql = new BindingSource();

        private void PostgreSQLFill_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=111;Database=GrigorevSS;");
            try
            {
                conn.Open();
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    return;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            if (isNeedCreate)
            {
                string[] createTableSQL = { "CREATE TABLE AnotherTusurMainEntity(id SERIAL PRIMARY KEY, value_1 INTEGER, value_2 INTEGER, value_3 double precision, value_4 double precision)" };
                string[] insertTableSQL = { "INSERT INTO AnotherTusurMainEntity(value_1,value_2,value_3,value_4) values(1,1,3.14,2.7)",
                                            "INSERT INTO AnotherTusurMainEntity(value_1,value_2,value_3,value_4) values(2,2,5.12,7.77)",
                                            "INSERT INTO AnotherTusurMainEntity(value_1,value_2,value_3,value_4) values(5,2,66.6,98.1)",
                                            "INSERT INTO AnotherTusurMainEntity(value_1,value_2,value_3,value_4) values(55,11,234.123,2.123)",
                                            "INSERT INTO AnotherTusurMainEntity(value_1,value_2,value_3,value_4) values(987,54,3333.1111,123.456)",
                                            "INSERT INTO AnotherTusurMainEntity(value_1,value_2,value_3,value_4) values(3,4,8.54,4.2)",
                                            "INSERT INTO AnotherTusurMainEntity(value_1,value_2,value_3,value_4) values(32,66,8.111123,767.909)"};
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    for (int i = 0; i < createTableSQL.Length; i++)
                    {
                        try
                        {
                            NpgsqlCommand command = new NpgsqlCommand(createTableSQL[i], conn);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.Message);
                        }
                    }
                    for (int i = 0; i < insertTableSQL.Length; i++)
                    {
                        try
                        {
                            NpgsqlCommand command = new NpgsqlCommand(insertTableSQL[i], conn);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.Message);
                            return;
                        }
                    }
                }
            }
            if (adapterNpgsql == null)
            {
                adapterNpgsql = new NpgsqlDataAdapter("SELECT id,value_1,value_2,value_3,value_4 FROM AnotherTusurMainEntity ", conn);
                dataTableNpgsql = new DataTable();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                command.CommandText = "INSERT INTO AnotherTusurMainEntity(value_1,value_2,value_3,value_4) values(@value_1,@value_2,@value_3,@value_4)";
                NpgsqlParameter par = new NpgsqlParameter();
                par.ParameterName = "@value_1";
                par.SourceColumn = "value_1";
                par.SourceVersion = System.Data.DataRowVersion.Current;
                par.DbType = System.Data.DbType.Int64;
                command.Parameters.Add(par);
                par = new NpgsqlParameter();
                par.ParameterName = "@value_2";
                par.SourceColumn = "value_2";
                par.SourceVersion = System.Data.DataRowVersion.Current;
                par.DbType = System.Data.DbType.Int64;
                command.Parameters.Add(par);
                par = new NpgsqlParameter();
                par.ParameterName = "@value_3";
                par.SourceColumn = "value_3";
                par.SourceVersion = System.Data.DataRowVersion.Current;
                par.DbType = System.Data.DbType.Double;
                command.Parameters.Add(par);
                par = new NpgsqlParameter();
                par.ParameterName = "@value_4";
                par.SourceColumn = "value_4";
                par.SourceVersion = System.Data.DataRowVersion.Current;
                par.DbType = System.Data.DbType.Double;
                command.Parameters.Add(par);
                adapterNpgsql.InsertCommand = command;
                command = new NpgsqlCommand();
                command.Connection = conn;
                command.CommandText = "UPDATE AnotherTusurMainEntity SET value_1=@value_1,value_2=@value_2,value_3=@value_3,value_4=@value_4 WHERE id=@id";
                par = new NpgsqlParameter();
                par.ParameterName = "@id";
                par.SourceColumn = "id";
                par.SourceVersion = System.Data.DataRowVersion.Original;
                par.DbType = System.Data.DbType.Int64;
                command.Parameters.Add(par);
                par = new NpgsqlParameter();
                par.ParameterName = "@value_1";
                par.SourceColumn = "value_1";
                par.SourceVersion = System.Data.DataRowVersion.Current;
                par.DbType = System.Data.DbType.Int64;
                command.Parameters.Add(par);
                par = new NpgsqlParameter();
                par.ParameterName = "@value_2";
                par.SourceColumn = "value_2";
                par.SourceVersion = System.Data.DataRowVersion.Current;
                par.DbType = System.Data.DbType.Int64;
                command.Parameters.Add(par);
                par = new NpgsqlParameter();
                par.ParameterName = "@value_3";
                par.SourceColumn = "value_3";
                par.SourceVersion = System.Data.DataRowVersion.Current;
                par.DbType = System.Data.DbType.Double;
                command.Parameters.Add(par);
                par = new NpgsqlParameter();
                par.ParameterName = "@value_4";
                par.SourceColumn = "value_4";
                par.SourceVersion = System.Data.DataRowVersion.Current;
                par.DbType = System.Data.DbType.Double;
                command.Parameters.Add(par);
                adapterNpgsql.UpdateCommand = command;
                bsNpgsql.DataSource = dataTableNpgsql;
                bindingNavigatorPosrtgreSQL.BindingSource = bsNpgsql;
                dataGridViewPostgreSQL.DataSource = bsNpgsql;
                adapterNpgsql.Fill(dataTableNpgsql);
                dataGridViewPostgreSQL.Columns[0].Visible = false;
            }
        }

        private void PostgreSQLUpdate_Click(object sender, EventArgs e)
        {
            dataGridViewPostgreSQL.EndEdit();
            bsNpgsql.EndEdit();
            if (adapterNpgsql != null)
            {
                adapterNpgsql.Update(dataTableNpgsql);
            }
        }
    }
}
