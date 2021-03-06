/*
	Generated: 07/13/2013 19:59:21
*/



namespace DBHelper
{
	/// <summary>
	/// Base Repository interface defining the basic and commonly used data access methods
	/// </summary>
	public partial interface IRepository<T>
	{
		/// <summary>
		/// Retrieves all items as a generic collection
		/// </summary>
		System.Collections.Generic.List<T> ToList();

		/// <summary>
		/// Retrieves the first set of items specified by count as a generic collection
		/// </summary>
		/// <param name="count">Number of records to be retrieved</param>
		System.Collections.Generic.List<T> ToList(int count);

		/// <summary>
		/// Retrieves all items as an array of T
		/// </summary>
		T[] ToArray();

		/// <summary>
		/// Retrieves the first set of items specific by count as an array of T
		/// </summary>
		/// <param name="count">Number of records to be retrieved</param>
		T[] ToArray(int count);

		/// <summary>
		/// Inserts the item to the table
		/// </summary>
		/// <param name="item">Item to be inserted to the database</param>
		void Create(T item);

		/// <summary>
		/// Populates the table with a collection of items
		/// </summary>
		/// <param name="items">Items to be inserted to the database</param>
		void Create(System.Collections.Generic.IEnumerable<T> items);

		/// <summary>
		/// Updates the item
		/// </summary>
		/// <param name="item">Item to be updated on the database</param>
		void Update(T item);

		/// <summary>
		/// Updates a collection items
		/// </summary>
		/// <param name="items">Items to be updated on the database</param>
		void Update(System.Collections.Generic.IEnumerable<T> items);

		/// <summary>
		/// Deletes the item
		/// </summary>
		/// <param name="item">Item to be deleted from the database</param>
		void Delete(T item);

		/// <summary>
		/// Deletes a collection of item
		/// </summary>
		/// <param name="items">Items to be deleted from the database</param>
		void Delete(System.Collections.Generic.IEnumerable<T> items);

		/// <summary>
		/// Purges the contents of the table
		/// </summary>
		int Purge();

		/// <summary>
		/// Gets the number of records in the table
		/// </summary>
		int Count();
	}
}

