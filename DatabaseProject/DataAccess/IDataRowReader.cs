using System;

namespace DataAccess
{
    public interface IDataRowReader
    {
        bool Read();
        byte GetByte(string name);
        DateTimeOffset GetDateTimeOffset(string name);
        int GetInt32(string name);
        string GetString(string name);
        T GetValue<T>(string name);
        T GetValue<T>(string name, T defaultValue);
        bool IsDBNull(string name);
        long GetInt64(string name);
        decimal GetDecimal(string name);
    }
}