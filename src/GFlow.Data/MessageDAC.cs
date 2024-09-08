using System;
using Npgsql;
using NpgsqlTypes;
using System.Data;

namespace GFlow.Data
{
	public class MessageDAC
	{
	static string connStr = "Server=127.0.0.1;Port=5432;Database=Test;User ID=postgres;Password=Pa$$W0rd";
	public static WorkItem Create(WorkItem wk){
	string commandText = "usp_createworkitem";
	using(NpgsqlConnection conn = new NpgsqlConnection(connStr)){
	conn.Open();
	using(NpgsqlCommand cmd = new NpgsqlCommand(commandText,conn)){
	cmd.CommandType = CommandType.StoredProcedure;

	NpgsqlParameter nref = new NpgsqlParameter("nref",NpgsqlDbType.Varchar);
	nref.Direction = ParameterDirection.Output;
	cmd.Parameters.Add(nref);

	cmd.Parameters.Add("Title",NpgsqlDbType.Varchar).Value = wk.Title;
	cmd.Parameters.Add("AssignedTo",NpgsqlDbType.Varchar).Value = wk.AssignedTo;
	cmd.Parameters.Add("Area",NpgsqlDbType.Varchar).Value = wk.Area;
	cmd.Parameters.Add("Reason",NpgsqlDbType.Varchar).Value = wk.Reason;

	NpgsqlParameter created = new NpgsqlParameter("creationDate",NpgsqlDbType.Timestamp);
	created.Direction = ParameterDirection.Output;
	cmd.Parameters.Add(created);

	cmd.ExecuteNonQuery();

	wk.Numref = cmd.Parameters["nref"].Value.ToString();
	wk.Created = Convert.ToDateTime(cmd.Parameters["creationDate"].Value);
	}
	}
	return wk;
	}

	}
}

