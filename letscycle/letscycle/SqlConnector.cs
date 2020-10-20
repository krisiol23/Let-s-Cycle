﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Xamarin.Essentials;
//using MySql.Data.MySqlClient;

namespace letscycle
{
    public class SqlConnector
    {
        List<Track> expList = new List<Track>();
        public  List<Track> Connect(string cs, string query)
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                using var con = new MySqlConnection(cs);
                con.Open();
                string sql = query;
                using var cmd = new MySqlCommand(sql, con);

                using MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    expList.Add(new Track() { imgPath = rdr.GetString(1).Replace(" ", "_") + ".png", street = rdr.GetString(1), bikersToday = rdr.GetString(2) });
                }

            }
            else
            {
                expList.Add(new Track() { imgPath ="gowno", street = "dupa", bikersToday ="ladna pani" });
            }
            return expList;
        }
    }
}
