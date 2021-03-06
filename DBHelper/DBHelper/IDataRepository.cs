/*
	This code was generated by SQL Compact Code Generator version 1.3.0.7

	SQL Compact Code Generator was written by Christian Resma Helle (http://sqlcecodegen.codeplex.com)
	and is under the GNU General Public License version 2 (GPLv2)

	Generated: 07/13/2013 19:59:21
*/



namespace DBHelper
{
	/// <summary>
	/// Main Data Repository interface containing all table repositories
	/// </summary>
	public partial interface IDataRepository : System.IDisposable
	{
		/// <summary>
		/// Gets an instance of the IEnglishSentencesRepository
		/// </summary>
		IEnglishSentencesRepository EnglishSentences { get; }

		/// <summary>
		/// Starts a SqlCeTransaction using the global SQL CE Conection instance
		/// </summary>
		System.Data.SqlServerCe.SqlCeTransaction BeginTransaction();

		/// <summary>
		/// Commits the transaction
		/// </summary>
		void Commit();

		/// <summary>
		/// Rollbacks the transaction
		/// </summary>
		void Rollback();
	}
}

