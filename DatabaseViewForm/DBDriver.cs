using MySqlConnector;

namespace DatabaseViewForm;

public class DBDriver
{
    public string ServerDomain = "vydb1.spsmb.cz";
    public string Username = "barbora.slavikova";
    public string Password = "";
    public string Database = "student_barbora.slavikova_duolingo";

    public string connectionString =>
        $"Server={ServerDomain};Database={Database};User={Username};Password={Password};Port=3306;";

    public MySqlException? ThrownException;

    public DBDriver(string password)
    {
        Password = password;
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    public List<User> GetUsers()
    {
        List<User> users = new List<User>();
        MySqlConnection connection = GetConnection();
        try
        {
            connection.Open();
            string query = "SELECT * FROM users";
            MySqlCommand command = new MySqlCommand(query, connection);
            // execute reader
            var reader = command.ExecuteReader();
            // while reader.next
            while (reader.Read())
            {
                // create new user
                var user = new User();
                user.Id = reader.GetInt32(0);
                user.Username = reader.GetString(1);
                user.CreatedAt = reader.GetDateTime(2);
                user.ModifiedAt = reader.GetDateTime(3);
                // add user to the list
                users.Add(user);
            }
        }
        catch (MySqlException ex)
        {
            ThrownException = ex;
        }

        // return list
        return users;
    }

    public void InsertUser(string username)
    {
        MySqlConnection connection = GetConnection();
        try
        {
            connection.Open();
            string query = "INSERT INTO users (user_name) VALUES (@username)";
            var cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.ExecuteNonQuery();
        }
        catch(MySqlException ex)
        {
            ThrownException = ex;
        }
    }
}