/*
	This code was generated by SQL Compact Code Generator version 1.3.0.7

	SQL Compact Code Generator was written by Christian Resma Helle (http://sqlcecodegen.codeplex.com)
	and is under the GNU General Public License version 2 (GPLv2)

	Generated: 07/13/2013 19:59:21
*/



namespace DBHelper
{
	using System.Linq;
	using System.Data.Linq;

	/// <summary>
	/// Default IEnglishSentencesRepository implementation 
	/// </summary>
	public partial class EnglishSentencesRepository : IEnglishSentencesRepository
	{
		public System.Data.SqlServerCe.SqlCeTransaction Transaction { get; set; }

		#region SELECT *

		/// <summary>
		/// Retrieves all items as a generic collection
		/// </summary>
		public System.Collections.Generic.List<EnglishSentences> ToList()
		{
			var list = new System.Collections.Generic.List<EnglishSentences>();
			using (var command = EntityBase.CreateCommand(Transaction))
			{
				command.CommandText = "SELECT * FROM EnglishSentences";
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var item = new EnglishSentences();
						item.ID = (System.Int32?) (reader.IsDBNull(0) ? null : reader["ID"]);
						item.Content = (reader.IsDBNull(1) ? null : reader["Content"] as System.String);
						item.Level = (System.Int32?) (reader.IsDBNull(2) ? null : reader["Level"]);
						list.Add(item);
					}
				}
			}
			return list.Count > 0 ? list : null;
		}

		public EnglishSentences[] ToArray()
		{
			var list = ToList();
			return list != null ? list.ToArray() : null;
		}

		#endregion

		#region SELECT TOP()

		/// <summary>
		/// Retrieves the first set of items specified by count as a generic collection
		/// </summary>
		/// <param name="count">Number of records to be retrieved</param>
		public System.Collections.Generic.List<EnglishSentences> ToList(int count)
		{
			var list = new System.Collections.Generic.List<EnglishSentences>();
			using (var command = EntityBase.CreateCommand(Transaction))
			{
				command.CommandText = string.Format("SELECT TOP({0}) * FROM EnglishSentences", count);
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var item = new EnglishSentences();
						item.ID = (System.Int32?) (reader.IsDBNull(0) ? null : reader["ID"]);
						item.Content = (reader.IsDBNull(1) ? null : reader["Content"] as System.String);
						item.Level = (System.Int32?) (reader.IsDBNull(2) ? null : reader["Level"]);
						list.Add(item);
					}
				}
			}
			return list.Count > 0 ? list : null;
		}

		public EnglishSentences[] ToArray(int count)
		{
			var list = ToList(count);
			return list != null ? list.ToArray() : null;
		}

		#endregion

		#region SELECT .... WHERE ID=?

		/// <summary>
		/// Retrieves a collection of items by ID
		/// </summary>
		/// <param name="ID">ID value</param>
		public System.Collections.Generic.List<EnglishSentences> SelectByID(System.Int32? ID)
		{
			var list = new System.Collections.Generic.List<EnglishSentences>();
			using (var command = EntityBase.CreateCommand(Transaction))
			{
				if (ID != null)
				{
					command.CommandText = "SELECT * FROM EnglishSentences WHERE ID=@ID";
					command.Parameters.Add("@ID", System.Data.SqlDbType.Int);
					command.Parameters["@ID"].Value = ID != null ? (object)ID : System.DBNull.Value;
				}
				else
					command.CommandText = "SELECT * FROM EnglishSentences WHERE ID IS NULL";

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var item = new EnglishSentences();
						item.ID = (System.Int32?) (reader.IsDBNull(0) ? null : reader["ID"]);
						item.Content = (reader.IsDBNull(1) ? null : reader["Content"] as System.String);
						item.Level = (System.Int32?) (reader.IsDBNull(2) ? null : reader["Level"]);
						list.Add(item);
					}
				}
			}
			return list.Count > 0 ? list : null;
		}

		#endregion

		#region SELECT .... WHERE Content=?

		/// <summary>
		/// Retrieves a collection of items by Content
		/// </summary>
		/// <param name="Content">Content value</param>
		public System.Collections.Generic.List<EnglishSentences> SelectByContent(System.String Content)
		{
			var list = new System.Collections.Generic.List<EnglishSentences>();
			using (var command = EntityBase.CreateCommand(Transaction))
			{
				if (Content != null)
				{
					command.CommandText = "SELECT * FROM EnglishSentences WHERE Content=@Content";
					command.Parameters.Add("@Content", System.Data.SqlDbType.NVarChar);
					command.Parameters["@Content"].Value = Content != null ? (object)Content : System.DBNull.Value;
				}
				else
					command.CommandText = "SELECT * FROM EnglishSentences WHERE Content IS NULL";

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var item = new EnglishSentences();
						item.ID = (System.Int32?) (reader.IsDBNull(0) ? null : reader["ID"]);
						item.Content = (reader.IsDBNull(1) ? null : reader["Content"] as System.String);
						item.Level = (System.Int32?) (reader.IsDBNull(2) ? null : reader["Level"]);
						list.Add(item);
					}
				}
			}
			return list.Count > 0 ? list : null;
		}

		#endregion

		#region SELECT .... WHERE Level=?

		/// <summary>
		/// Retrieves a collection of items by Level
		/// </summary>
		/// <param name="Level">Level value</param>
		public System.Collections.Generic.List<EnglishSentences> SelectByLevel(System.Int32? Level)
		{
			var list = new System.Collections.Generic.List<EnglishSentences>();
			using (var command = EntityBase.CreateCommand(Transaction))
			{
				if (Level != null)
				{
					command.CommandText = "SELECT * FROM EnglishSentences WHERE Level=@Level";
					command.Parameters.Add("@Level", System.Data.SqlDbType.Int);
					command.Parameters["@Level"].Value = Level != null ? (object)Level : System.DBNull.Value;
				}
				else
					command.CommandText = "SELECT * FROM EnglishSentences WHERE Level IS NULL";

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var item = new EnglishSentences();
						item.ID = (System.Int32?) (reader.IsDBNull(0) ? null : reader["ID"]);
						item.Content = (reader.IsDBNull(1) ? null : reader["Content"] as System.String);
						item.Level = (System.Int32?) (reader.IsDBNull(2) ? null : reader["Level"]);
						list.Add(item);
					}
				}
			}
			return list.Count > 0 ? list : null;
		}

		#endregion

		#region SELECT TOP(?).... WHERE ID=?

		/// <summary>
		/// Retrieves the first set of items specified by count by ID
		/// </summary>
		/// <param name="ID">ID value</param>
		/// <param name="count">Number of records to be retrieved</param>
		public System.Collections.Generic.List<EnglishSentences> SelectByID(System.Int32? ID, int count)
		{
			var list = new System.Collections.Generic.List<EnglishSentences>();
			using (var command = EntityBase.CreateCommand(Transaction))
			{
			if (ID != null)
			{
				command.CommandText = "SELECT TOP(" + count + ") * FROM EnglishSentences WHERE ID=@ID";
				command.Parameters.Add("@ID", System.Data.SqlDbType.Int);
				command.Parameters["@ID"].Value = ID != null ? (object)ID : System.DBNull.Value;
			}
			else
				command.CommandText = "SELECT TOP(" + count + ") * FROM EnglishSentences WHERE ID IS NULL";

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var item = new EnglishSentences();
						item.ID = (System.Int32?) (reader.IsDBNull(0) ? null : reader["ID"]);
						item.Content = (reader.IsDBNull(1) ? null : reader["Content"] as System.String);
						item.Level = (System.Int32?) (reader.IsDBNull(2) ? null : reader["Level"]);
						list.Add(item);
					}
				}
			}
			return list.Count > 0 ? list : null;
		}

		#endregion

		#region SELECT TOP(?).... WHERE Content=?

		/// <summary>
		/// Retrieves the first set of items specified by count by Content
		/// </summary>
		/// <param name="Content">Content value</param>
		/// <param name="count">Number of records to be retrieved</param>
		public System.Collections.Generic.List<EnglishSentences> SelectByContent(System.String Content, int count)
		{
			var list = new System.Collections.Generic.List<EnglishSentences>();
			using (var command = EntityBase.CreateCommand(Transaction))
			{
			if (Content != null)
			{
				command.CommandText = "SELECT TOP(" + count + ") * FROM EnglishSentences WHERE Content=@Content";
				command.Parameters.Add("@Content", System.Data.SqlDbType.NVarChar);
				command.Parameters["@Content"].Value = Content != null ? (object)Content : System.DBNull.Value;
			}
			else
				command.CommandText = "SELECT TOP(" + count + ") * FROM EnglishSentences WHERE Content IS NULL";

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var item = new EnglishSentences();
						item.ID = (System.Int32?) (reader.IsDBNull(0) ? null : reader["ID"]);
						item.Content = (reader.IsDBNull(1) ? null : reader["Content"] as System.String);
						item.Level = (System.Int32?) (reader.IsDBNull(2) ? null : reader["Level"]);
						list.Add(item);
					}
				}
			}
			return list.Count > 0 ? list : null;
		}

		#endregion

		#region SELECT TOP(?).... WHERE Level=?

		/// <summary>
		/// Retrieves the first set of items specified by count by Level
		/// </summary>
		/// <param name="Level">Level value</param>
		/// <param name="count">Number of records to be retrieved</param>
		public System.Collections.Generic.List<EnglishSentences> SelectByLevel(System.Int32? Level, int count)
		{
			var list = new System.Collections.Generic.List<EnglishSentences>();
			using (var command = EntityBase.CreateCommand(Transaction))
			{
			if (Level != null)
			{
				command.CommandText = "SELECT TOP(" + count + ") * FROM EnglishSentences WHERE Level=@Level";
				command.Parameters.Add("@Level", System.Data.SqlDbType.Int);
				command.Parameters["@Level"].Value = Level != null ? (object)Level : System.DBNull.Value;
			}
			else
				command.CommandText = "SELECT TOP(" + count + ") * FROM EnglishSentences WHERE Level IS NULL";

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var item = new EnglishSentences();
						item.ID = (System.Int32?) (reader.IsDBNull(0) ? null : reader["ID"]);
						item.Content = (reader.IsDBNull(1) ? null : reader["Content"] as System.String);
						item.Level = (System.Int32?) (reader.IsDBNull(2) ? null : reader["Level"]);
						list.Add(item);
					}
				}
			}
			return list.Count > 0 ? list : null;
		}

		#endregion

		#region INSERT [EnglishSentences]

		/// <summary>
		/// Inserts the item to the table
		/// </summary>
		/// <param name="item">Item to insert to the database</param>
		public void Create(EnglishSentences item)
		{
			Create(item.Content, item.Level);
		}

		#endregion

		#region INSERT Ignoring Primary Key

		/// <summary>
		/// Inserts a new record to the table without specifying the primary key
		/// </summary>
		/// <param name="Content">Content value</param>
		/// <param name="Level">Level value</param>
		public void Create(System.String Content, System.Int32? Level)
		{
			if (Content != null && Content.Length > 100)
				throw new System.ArgumentException("Max length for Content is 100");

			using (var command = EntityBase.CreateCommand(Transaction))
			{
				command.CommandText = "INSERT INTO [EnglishSentences] (Content, Level)  VALUES (@Content, @Level)";

				command.Parameters.Add("@Content", System.Data.SqlDbType.NVarChar);
				command.Parameters["@Content"].Value = Content != null ? (object)Content : System.DBNull.Value;
				command.Parameters.Add("@Level", System.Data.SqlDbType.Int);
				command.Parameters["@Level"].Value = Level != null ? (object)Level : System.DBNull.Value;
				command.ExecuteNonQuery();
			}
		}

		#endregion

		#region INSERT [EnglishSentences] by fields

		/// <summary>
		/// Inserts a new record to the table specifying all fields
		/// </summary>
		/// <param name="ID">ID value</param>
		/// <param name="Content">Content value</param>
		/// <param name="Level">Level value</param>
		public void Create(System.Int32? ID, System.String Content, System.Int32? Level)
		{
			if (Content != null && Content.Length > EnglishSentences.Content_Max_Length)
				throw new System.ArgumentException("Max length for Content is 100");

			using (var command = EntityBase.CreateCommand(Transaction))
			{
				command.CommandText = "INSERT INTO [EnglishSentences] (ID, Content, Level)  VALUES (@ID, @Content, @Level)";

				command.Parameters.Add("@ID", System.Data.SqlDbType.Int);
				command.Parameters["@ID"].Value = ID != null ? (object)ID : System.DBNull.Value;
				command.Parameters.Add("@Content", System.Data.SqlDbType.NVarChar);
				command.Parameters["@Content"].Value = Content != null ? (object)Content : System.DBNull.Value;
				command.Parameters.Add("@Level", System.Data.SqlDbType.Int);
				command.Parameters["@Level"].Value = Level != null ? (object)Level : System.DBNull.Value;
				command.ExecuteNonQuery();
			}
		}

		#endregion

		#region INSERT MANY

		/// <summary>
		/// Populates the table with a collection of items
		/// </summary>
		public void Create(System.Collections.Generic.IEnumerable<EnglishSentences> items)
		{
			using (var command = EntityBase.CreateCommand(Transaction))
			{
				command.CommandType = System.Data.CommandType.TableDirect;
				command.CommandText = "EnglishSentences";

				using (var resultSet = command.ExecuteResultSet(System.Data.SqlServerCe.ResultSetOptions.Updatable))
				{
					var record = resultSet.CreateRecord();
					foreach (var item in items)
					{
						record.SetValue(1, item.Content);
						record.SetValue(2, item.Level);
						resultSet.Insert(record);
					}
				}
			}
		}

		#endregion

		#region DELETE

		/// <summary>
		/// Deletes the item
		/// </summary>
		/// <param name="item">Item to delete</param>
		public void Delete(EnglishSentences item)
		{
			using (var command = EntityBase.CreateCommand(Transaction))
			{
				command.CommandText = "DELETE FROM [EnglishSentences] WHERE ID = @ID";

				command.Parameters.Add("@ID", System.Data.SqlDbType.Int);
				command.Parameters["@ID"].Value = item.ID != null ? (object)item.ID : System.DBNull.Value;
				command.ExecuteNonQuery();
			}
		}

		#endregion

		#region DELETE MANY

		/// <summary>
		/// Deletes a collection of item
		/// </summary>
		/// <param name="items">Items to delete</param>
		public void Delete(System.Collections.Generic.IEnumerable<EnglishSentences> items)
		{
			using (var command = EntityBase.CreateCommand(Transaction))
			{
				command.CommandText = "DELETE FROM [EnglishSentences] WHERE ID = @ID";
				command.Parameters.Add("@ID", System.Data.SqlDbType.Int);
				command.Prepare();

				foreach (var item in items)
				{
					command.Parameters["@ID"].Value = item.ID != null ? (object)item.ID : System.DBNull.Value;

					command.ExecuteNonQuery();
				}
			}
		}

		#endregion

		#region DELETE BY ID

		/// <summary>
		/// Delete records by ID
		/// </summary>
		/// <param name="ID">ID value</param>
		public int DeleteByID(System.Int32? ID)
		{
			using (var command = EntityBase.CreateCommand(Transaction))
			{
				command.CommandText = "DELETE FROM [EnglishSentences] WHERE ID=@ID";
				command.Parameters.Add("@ID", System.Data.SqlDbType.Int);
				command.Parameters["@ID"].Value = ID != null ? (object)ID : System.DBNull.Value;

				return command.ExecuteNonQuery();
			}
		}

		#endregion

		#region DELETE BY Content

		/// <summary>
		/// Delete records by Content
		/// </summary>
		/// <param name="Content">Content value</param>
		public int DeleteByContent(System.String Content)
		{
			using (var command = EntityBase.CreateCommand(Transaction))
			{
				command.CommandText = "DELETE FROM [EnglishSentences] WHERE Content=@Content";
				command.Parameters.Add("@Content", System.Data.SqlDbType.NVarChar);
				command.Parameters["@Content"].Value = Content != null ? (object)Content : System.DBNull.Value;

				return command.ExecuteNonQuery();
			}
		}

		#endregion

		#region DELETE BY Level

		/// <summary>
		/// Delete records by Level
		/// </summary>
		/// <param name="Level">Level value</param>
		public int DeleteByLevel(System.Int32? Level)
		{
			using (var command = EntityBase.CreateCommand(Transaction))
			{
				command.CommandText = "DELETE FROM [EnglishSentences] WHERE Level=@Level";
				command.Parameters.Add("@Level", System.Data.SqlDbType.Int);
				command.Parameters["@Level"].Value = Level != null ? (object)Level : System.DBNull.Value;

				return command.ExecuteNonQuery();
			}
		}

		#endregion

		#region Purge

		/// <summary>
		/// Purges the contents of the table
		/// </summary>
		public int Purge()
		{
			using (var command = EntityBase.CreateCommand(Transaction))
			{
				command.CommandText = "DELETE FROM [EnglishSentences]";
				return command.ExecuteNonQuery();
			}
		}

		#endregion

		#region UPDATE

		/// <summary>
		/// Updates the item
		/// </summary>
		/// <param name="item">Item to update</param>
		public void Update(EnglishSentences item)
		{
			using (var command = EntityBase.CreateCommand(Transaction))
			{
				command.CommandText = "UPDATE [EnglishSentences] SET Content = @Content, Level = @Level WHERE ID = @ID";

				command.Parameters.Add("@ID", System.Data.SqlDbType.Int);
				command.Parameters["@ID"].Value = item.ID != null ? (object)item.ID : System.DBNull.Value;
				command.Parameters.Add("@Content", System.Data.SqlDbType.NVarChar);
				command.Parameters["@Content"].Value = item.Content != null ? (object)item.Content : System.DBNull.Value;
				command.Parameters.Add("@Level", System.Data.SqlDbType.Int);
				command.Parameters["@Level"].Value = item.Level != null ? (object)item.Level : System.DBNull.Value;
				command.ExecuteNonQuery();
			}
		}

		#endregion

		#region UPDATE MANY

		/// <summary>
		/// Updates a collection of items
		/// </summary>
		/// <param name="items">Items to update</param>
		public void Update(System.Collections.Generic.IEnumerable<EnglishSentences> items)
		{
			using (var command = EntityBase.CreateCommand(Transaction))
			{
				command.CommandText = "UPDATE [EnglishSentences] SET Content = @Content, Level = @Level WHERE ID = @ID";
				command.Parameters.Add("@ID", System.Data.SqlDbType.Int);				command.Parameters.Add("@Content", System.Data.SqlDbType.NVarChar);				command.Parameters.Add("@Level", System.Data.SqlDbType.Int);				command.Prepare();

				foreach (var item in items)
				{
					command.Parameters["@ID"].Value = item.ID != null ? (object)item.ID : System.DBNull.Value;
					command.Parameters["@Content"].Value = item.Content != null ? (object)item.Content : System.DBNull.Value;
					command.Parameters["@Level"].Value = item.Level != null ? (object)item.Level : System.DBNull.Value;
					command.ExecuteNonQuery();
				}
			}
		}

		#endregion

		#region COUNT [EnglishSentences]

		/// <summary>
		/// Gets the number of records in the table
		/// </summary>
		public int Count()
		{
			using (var command = EntityBase.CreateCommand(Transaction))
			{
				command.CommandText = "SELECT COUNT(*) FROM EnglishSentences";
				return (int)command.ExecuteScalar();
			}
		}

		#endregion

	}
}

