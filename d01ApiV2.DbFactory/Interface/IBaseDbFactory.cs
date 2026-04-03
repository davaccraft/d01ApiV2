namespace d01ApiV2.DbFactory.Interface
{
    public interface IBaseDbFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T1">Response Data</typeparam>
        /// <typeparam name="T2">Return Message</typeparam>
        /// <param name="storedprocedure">stored procedure name</param>
        /// <param name="parameter">parameters based on the store procedure</param>
        /// <returns></returns>
        Task<Tuple<IEnumerable<T1>, T2>> ExecuteQueryMultipleReturnAsync<T1, T2>(string storedprocedure, object parameter);


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3">Return Message</typeparam>
        /// <param name="storedprocedure">stored procedure name</param>
        /// <param name="parameter">parameters based on the store procedure</param>
        /// <returns></returns>
        Task<Tuple<IEnumerable<T1>, IEnumerable<T2>, T3>> ExecuteQueryMultipleReturnAsync<T1, T2, T3>(string storedprocedure, object parameter);



        /// <summary>
        /// Use for Pagination
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4">Return Message i.e. SELECT '00' AS ReturnCode, 'SUCCESS' AS ReturnMessage</typeparam>
        /// <param name="storedprocedure">[dbo].[Paginate{Module}] i.e. [dbo].[PaginateBrand]</param>
        /// <param name="parameter">@Parameter UDTTParameter READONLY</param>
        /// <returns></returns>
        Task<Tuple<IEnumerable<T1>, IEnumerable<T2>, T3, T4>> ExecuteQueryMultipleReturnAsync<T1, T2, T3, T4>(string storedprocedure, object parameter);

        /// <summary>
        /// Use for Pagination
        /// </summary>
        /// <typeparam name="T1">Return Form Buttons</typeparam>
        /// <typeparam name="T2">Column Headers</typeparam>
        /// <typeparam name="T3">Row Data</typeparam>
        /// <typeparam name="T4">Total Record Count</typeparam>
        /// <typeparam name="T5">Return Message i.e. SELECT '00' AS ReturnCode, 'SUCCESS' AS ReturnMessage</typeparam>
        /// <param name="storedprocedure">[dbo].[Paginate{Module}] i.e. [dbo].[PaginateBrand]</param>
        /// <param name="parameter">@Parameter UDTTParameter READONLY</param>
        /// <returns></returns>
        Task<Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, T4, T5>> ExecuteQueryMultipleReturnAsync<T1, T2, T3, T4, T5>(string storedprocedure, object parameter);




        /// <summary>
        /// Get Components
        /// </summary>
        /// <typeparam name="T1">Menu Components</typeparam>
        /// <typeparam name="T2">Advance Search Components of List Page</typeparam>
        /// <typeparam name="T3">Grid Components of List Page</typeparam>
        /// <typeparam name="T4">Detail Page Components</typeparam>
        /// <typeparam name="T5">List Page Components</typeparam>
        /// <typeparam name="T6">Return Message i.e. SELECT '00' AS ReturnCode, 'SUCCESS' AS ReturnMessage</typeparam>
        /// <param name="storedprocedure">[dbo].[Paginate{Module}] i.e. [dbo].[PaginateBrand]</param>
        /// <param name="parameter">@Parameter UDTTParameter READONLY</param>
        /// <returns></returns>
        Task<Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, T6>> ExecuteQueryMultipleReturnAsync<T1, T2, T3, T4, T5, T6>(string storedprocedure, object parameter);
    }
}
