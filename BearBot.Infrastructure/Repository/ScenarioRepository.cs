using BearBot.Infrastructure.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearBot.Core.Model;
using BearBot.Core.Enumeration;
using BearBot.Infrastructure.Database;
using Npgsql;
using System.Data;

namespace BearBot.Infrastructure.Repository
{
    public class ScenarioRepository : IScenarioRepository
    {
        public List<Scenario> Fetch()
        {
            var conn = new NpgsqlConnection(BearDbConnection.ConnectionString);

            var cmd = new NpgsqlCommand();

            cmd.CommandText = "select * from scenario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            conn.Open();

            var reader = cmd.ExecuteReader();
            var model = new List<Scenario>();

            while (reader.Read())
            {
                model.Add(new Scenario(
                        reader.GetInt16(0)
                        , reader.GetString(1)
                        , reader.GetString(2)
                        , 1
                        , ScenarioLastRunStatus.NOTRUN
                    ));
            }

            conn.Close();

            return model;
        }
    }
}
