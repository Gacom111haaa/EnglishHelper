/*
	This code was generated by SQL Compact Code Generator version 1.3.0.7

	SQL Compact Code Generator was written by Christian Resma Helle (http://sqlcecodegen.codeplex.com)
	and is under the GNU General Public License version 2 (GPLv2)

	Generated: 07/13/2013 19:59:21
*/



namespace DBHelperTest
{
    using DBHelper;

	
	public class DataAccessTestBase
	{
		public DataAccessTestBase()
		{
			var databaseFile = @"C:\Users\Nho\Documents\Visual Studio 2012\Projects\DBHelper\DBHelper\db\EnghlistHelperDB.sdf_" + System.Guid.NewGuid().ToString().Replace("{", string.Empty).Replace("}", string.Empty) + ".sdf";
			EntityBase.ConnectionString = "Data Source='" + databaseFile + "'";
			if (System.IO.File.Exists(databaseFile)) return;
			try { DatabaseFile.CreateDatabase(); } catch {}
		}

        protected static DataAccessRandomGenerator RandomGenerator = new DataAccessRandomGenerator();

        protected class DataAccessRandomGenerator
        {
            const string PWD_CHARSET = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVXYZ1234567890";

            public string GenerateString(int len)
            {
                if (len > 4000) len = 4000;
                var buffer = new byte[len * 2];
                new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(buffer);

                using (var stream = new System.IO.MemoryStream(buffer, 0, buffer.Length, false, false))
                using (var reader = new System.IO.BinaryReader(stream))
                {
                    var builder = new System.Text.StringBuilder(buffer.Length, buffer.Length);
                    while (len-- > 0)
                    {
                        var i = (reader.ReadUInt16() & 8) % PWD_CHARSET.Length;
                        builder.Append(PWD_CHARSET[i]);
                    }
                    return builder.ToString();
                }
            }
        }
	}
}

