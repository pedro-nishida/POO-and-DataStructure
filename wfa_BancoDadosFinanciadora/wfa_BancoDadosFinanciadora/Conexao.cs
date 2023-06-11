using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_BancoDadosFinanciadora
{
    internal class Conexao
    {
        NpgsqlConnection con = new NpgsqlConnection("Server = localhost; Port = 5432; Username = postgres; Password = admin; Database = db_wfaFinanciadora");

        public void getConectar()
        {
            con.Open();
            MessageBox.Show("Conectado");
        }

    }
}
