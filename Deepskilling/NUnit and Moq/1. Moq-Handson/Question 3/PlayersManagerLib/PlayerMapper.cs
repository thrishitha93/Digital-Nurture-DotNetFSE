using System.Data.SqlClient;

namespace PlayersManagerLib
{
    public class PlayerMapper : IPlayerMapper
    {
        private readonly string _connectionString =
            "Data Source=(local);Initial Catalog=GameDB;Integrated Security=True";

        public bool IsPlayerNameExistsInDb(string name)
        {
            // DB code (won’t be used in test)
            return false;
        }

        public void AddNewPlayerIntoDb(string name)
        {
        }
    }
}