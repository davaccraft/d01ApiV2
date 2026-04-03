using d01ApiV2.Common.Constant;
using d01ApiV2.DbFactory.Interface;
using d01ApiV2.Model;
using d01ApiV2.Model.Dto;
using d01ApiV2.Model.Grid;
using d01ApiV2.Model.Grid.Profile;
using d01ApiV2.Model.Request;
using d01ApiV2.Repository.Interface.Profile;
using Dapper;
using System.Data;

namespace d01ApiV2.Repository.Implementation.Profile
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IAppDbFactory _appDbFactory;

        public BrandRepository(IAppDbFactory appDbFactory)
        {
            _appDbFactory = appDbFactory;
        }

        public async Task<ApiResponse<T>> Paginate<T>(RequestKeyValue request)
        {
            var dt = new DataTable();
            dt.Columns.Add("Key", typeof(string));
            dt.Columns.Add("Value", typeof(string));

            foreach (var entry in request.Parameters)
            {
                dt.Rows.Add(entry.Key, entry.Value);
            }

            var parameter = new
            {
                Parameter = dt.AsTableValuedParameter("dbo.UDTTParameter")
            };

            var result = await _appDbFactory.ExecuteQueryMultipleReturnAsync<DbReturnColumnHeader, DbReturnRowBrand, DbReturnPagination, ResultDto>(StoredProcedure.PaginateBrand, parameter).ConfigureAwait(false);

            var dataColumnHeaders = result.Item1
                .Select((row, index) => new ResponseColumnHeader
                {
                    InternalCode = row.InternalCode,
                    ColumnGroup = row.ColumnGroup,
                    Caption = row.Caption,
                    DisplayOrderNo = row.DisplayOrderNo,
                    DataType = row.DataType,
                    DataFormat = row.DataFormat,
                    ComponentType = row.ComponentType,
                    MethodCode = row.MethodCode,
                    IsVisible = row.IsVisible,
                    IsAllowSort = row.IsAllowSort,
                    IsAscending = row.IsAscending
                }).ToList();

            var dataRowDatas = result.Item2
                .Select((row, index) => new ResponseRow
                {
                    RowNo = index,
                    Cells = new List<ResponseCell>
                    {
                        new ResponseCell
                        {
                            CellNo = 0,
                            CellInternalCode = row.CellInternalCode0,
                            CellValue = row.CellValue0,
                            CellGroupNo = row.CellGroupNo0,
                            CellMethodCode = row.CellMethodCode0,
                            CellIsMask = row.CellIsMask0,
                            CellIsEnable = row.CellIsEnable0,
                            CellIsReadOnly = row.CellIsReadOnly0
                        },
                        new ResponseCell
                        {
                            CellNo = 1,
                            CellInternalCode = row.CellInternalCode1,
                            CellValue = row.CellValue1,
                            CellGroupNo = row.CellGroupNo1,
                            CellMethodCode = row.CellMethodCode1,
                            CellIsMask = row.CellIsMask1,
                            CellIsEnable = row.CellIsEnable1,
                            CellIsReadOnly = row.CellIsReadOnly1
                        },
                        new ResponseCell
                        {
                            CellNo = 2,
                            CellInternalCode = row.CellInternalCode2,
                            CellValue = row.CellValue2,
                            CellGroupNo = row.CellGroupNo2,
                            CellMethodCode = row.CellMethodCode2,
                            CellIsMask = row.CellIsMask2,
                            CellIsEnable = row.CellIsEnable2,
                            CellIsReadOnly = row.CellIsReadOnly2
                        },
                        new ResponseCell
                        {
                            CellNo = 3,
                            CellInternalCode = row.CellInternalCode3,
                            CellValue = row.CellValue3,
                            CellGroupNo = row.CellGroupNo3,
                            CellMethodCode = row.CellMethodCode3,
                            CellIsMask = row.CellIsMask3,
                            CellIsEnable = row.CellIsEnable3,
                            CellIsReadOnly = row.CellIsReadOnly3
                        },
                        new ResponseCell
                        {
                            CellNo = 4,
                            CellInternalCode = row.CellInternalCode4,
                            CellValue = row.CellValue4,
                            CellGroupNo = row.CellGroupNo4,
                            CellMethodCode = row.CellMethodCode4,
                            CellIsMask = row.CellIsMask4,
                            CellIsEnable = row.CellIsEnable4,
                            CellIsReadOnly = row.CellIsReadOnly4
                        },
                        new ResponseCell
                        {
                            CellNo = 5,
                            CellInternalCode = row.CellInternalCode5,
                            CellValue = row.CellValue5,
                            CellGroupNo = row.CellGroupNo5,
                            CellMethodCode = row.CellMethodCode5,
                            CellIsMask = row.CellIsMask5,
                            CellIsEnable = row.CellIsEnable5,
                            CellIsReadOnly = row.CellIsReadOnly5
                        },
                        new ResponseCell
                        {
                            CellNo = 6,
                            CellInternalCode = row.CellInternalCode6,
                            CellValue = row.CellValue6,
                            CellGroupNo = row.CellGroupNo6,
                            CellMethodCode = row.CellMethodCode6,
                            CellIsMask = row.CellIsMask6,
                            CellIsEnable = row.CellIsEnable6,
                            CellIsReadOnly = row.CellIsReadOnly6
                        },
                        new ResponseCell
                        {
                            CellNo = 7,
                            CellInternalCode = row.CellInternalCode7,
                            CellValue = row.CellValue7,
                            CellGroupNo = row.CellGroupNo7,
                            CellMethodCode = row.CellMethodCode7,
                            CellIsMask = row.CellIsMask7,
                            CellIsEnable = row.CellIsEnable7,
                            CellIsReadOnly = row.CellIsReadOnly7
                        },
                        new ResponseCell
                        {
                            CellNo = 8,
                            CellInternalCode = row.CellInternalCode8,
                            CellValue = row.CellValue8,
                            CellGroupNo = row.CellGroupNo8,
                            CellMethodCode = row.CellMethodCode8,
                            CellIsMask = row.CellIsMask8,
                            CellIsEnable = row.CellIsEnable8,
                            CellIsReadOnly = row.CellIsReadOnly8
                        }
                    }
                }).ToList();

            var dataPaginationInfo = new ResponsePagination()
            {
                CurrentPageNo = result.Item3.CurrentPageNo,
                CurrentPageSize = result.Item3.CurrentPageSize,
                RecordCount = result.Item3.RecordCount
            };

            ResponseDataGrid data = new ResponseDataGrid()
            {
                ColumnHeaders = dataColumnHeaders,
                RowList = dataRowDatas,
                PaginationInfo = dataPaginationInfo
            };

            ApiResponse<ResponseDataGrid> resultData = new ApiResponse<ResponseDataGrid>
            {
                Data = data,
                ReturnCode = result.Item4.ReturnCode,
                ReturnMessage = result.Item4.ReturnMessage
            };

            return (ApiResponse<T>)(object)resultData;
        }
        public async Task<ApiResponse<T>> GetList<T>(RequestKeyValue request)
        {
            throw new NotImplementedException();

            //MPD.OPEN
            //2 tables to received
            //- Brand
            //- BrandInfo
        }

        //Get Single Data
        public async Task<ApiResponse<T>> Get<T>(RequestKeyValue request)
        {
            throw new NotImplementedException();


            //var dt = new DataTable();
            //dt.Columns.Add("Key", typeof(string));
            //dt.Columns.Add("Value", typeof(string));

            //foreach (var entry in request.Parameters)
            //{
            //    dt.Rows.Add(entry.Key, entry.Value);
            //}

            //var parameter = new
            //{
            //    Parameter = dt.AsTableValuedParameter("dbo.UDTTParameter")
            //};

            //MPD.OPEN
            //2 tables to received
            //- Brand
            //- BrandInfo
        }


        //Save data
        public async Task<ApiResponse<T>> Save<T>(RequestKeyValue request)
        {
            throw new NotImplementedException();


            //MPD.OPEN
            //2 tables to received
            //- Brand
            //- BrandInfo
        }

        public async Task<ApiResponse<T>> Delete<T>(RequestKeyValue request)
        {
            throw new NotImplementedException();


            //MPD.OPEN
            //2 tables to received
            //- Brand
            //- BrandInfo
        }

        public async Task<ApiResponse<T>> HardDelete<T>(RequestKeyValue request)
        {
            throw new NotImplementedException();


            //MPD.OPEN
            //2 tables to received
            //- Brand
            //- BrandInfo
        }
    }
}
