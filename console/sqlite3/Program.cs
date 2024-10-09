using System.Data.SQLite;

// Create  a connection string
string connectionString = "Data Source=my_database_name.db";

// Establish a connection string
using (SQLiteConnection connection = new SQLiteConnection(connectionString))
{
    connection.Open();

    // Creating a Table:
    using (SQLiteCommand command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS MyTable (Id INTEGER PRIMARY KEY, Name TEXT)", connection))
    {
	command.ExecuteNonQuery();
    }

    // Inserting Data:
    using (SQLiteCommand command = new SQLiteCommand("INSERT INTO MyTable (Name) VALUES (@Name)", connection))
    {
	command.Parameters.AddWithValue("@Name", "John Doe");
	command.ExecuteNonQuery();
    }

    // Reading Data:
    using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM MyTable", connection))
    {
	using (SQLiteDataReader reader = command.ExecuteReader())
	{
	    while (reader.Read())
	    {
		int id = reader.GetInt32(0);
		string name = reader.GetString(1);
		Console.WriteLine($"ID: {id}, Name: {name}");
	    }
	}
    }

    // Updating Data:
    using (SQLiteCommand command = new SQLiteCommand("UPDATE MyTable SET Name = @NewName WHERE Id = @Id", connection))
    {
	command.Parameters.AddWithValue("@NewName", "Jane Smith");
	command.Parameters.AddWithValue("@Id", 1);
	command.ExecuteNonQuery();
    }

    // Deleting Data:
    using (SQLiteCommand command = new SQLiteCommand("DELETE FROM MyTable WHERE Id = @Id", connection))
    {
	command.Parameters.AddWithValue("@Id", 1);
	command.ExecuteNonQuery();
    }
}




