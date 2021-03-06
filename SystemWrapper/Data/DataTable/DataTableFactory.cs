﻿namespace SystemWrapper.Data.DataTable
{
    using System.Data;

    using SystemInterface.Data.DataTable;

    /// <summary>
    ///     Factory to create a new <see cref="IDataTable"/> instance.
    /// </summary>
    public class DataTableFactory : IDataTableFactory
    {
        #region Public Methods and Operators

        /// <summary>
        ///     Creates a new <see cref="IDataTable"/> instance using the default constructor.
        /// </summary>
        /// <returns>
        ///     The <see cref="IDataTable"/>.
        /// </returns>
        public IDataTable Create()
        {
            return new DataTableWrap();
        }

        /// <summary>
        ///     Creates a new <see cref="IDataTable"/> instance passing the table name.
        /// </summary>
        /// <param name="tableName">
        ///     The table name.
        /// </param>
        /// <returns>
        ///     The <see cref="IDataTable"/>.
        /// </returns>
        public IDataTable Create(string tableName)
        {
            return new DataTableWrap(tableName);
        }

        /// <summary>
        ///     Creates a new <see cref="IDataTable"/> instance passing the table name and namespace.
        /// </summary>
        /// <param name="tableName">
        ///     The table name.
        /// </param>
        /// <param name="tableNamespace">
        ///     The table namespace.
        /// </param>
        /// <returns>
        ///     The <see cref="IDataTable"/>.
        /// </returns>
        public IDataTable Create(string tableName,
                                 string tableNamespace)
        {
            return new DataTableWrap(tableName, tableNamespace);
        }

        /// <summary>
        ///     Creates a new <see cref="IDataTable"/> instance passing a data table.
        /// </summary>
        /// <param name="dataTable">
        ///     The data table.
        /// </param>
        /// <returns>
        ///     The <see cref="IDataTable"/>.
        /// </returns>
        public IDataTable Create(DataTable dataTable)
        {
            return new DataTableWrap(dataTable);
        }

        #endregion
    }
}