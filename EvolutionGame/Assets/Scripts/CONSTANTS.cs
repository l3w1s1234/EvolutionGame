using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using Mono.Data.Sqlite;

public static class CONSTANTS
{
    static string DBCONN = "URI=file:" + Application.dataPath + "/testdb.db";


    public static IDbConnection GetConnection()
    {
        return  (IDbConnection)new SqliteConnection(DBCONN);
    }
}

