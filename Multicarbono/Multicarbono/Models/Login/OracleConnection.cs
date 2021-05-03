using System;

namespace Multicarbono.Models.Login
{
    internal class OracleConnection : IDisposable
    {
        private string connectionString;

        public OracleConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}