﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_BancoDadosFinanciadora
{
    internal class ConexaoString
    {
        string serverName = "localhost"; // localhost 
        string port = "5432"; // porta default
        string userName = "postgres"; // nome do administrador
        string password = "admin"; // Senha do SGDB
        string dataBaseName = "db_wfaFinanciadora"; // Nome do Banco de Dados

        public string ConnString()
        {
            //var connString = String.Format("Server = {0}; Port = {1}; Username = {2}; Password = {3}; Database = {4};", serverName, port, userName,
            //password, dataBaseName);

            var connString = "Server =" + serverName + ";Port = " + port + ";Username = " + userName + ";Password=" + password +
                 ";Database=" + dataBaseName + ";";

            return connString;
        }
    }
}
