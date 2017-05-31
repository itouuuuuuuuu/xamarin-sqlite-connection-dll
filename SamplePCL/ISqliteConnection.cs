using System;
using SQLite.Net;

namespace SamplePCL
{
    public interface ISqliteConnection
    {
        SQLiteConnection GetConnection();
    }
}
