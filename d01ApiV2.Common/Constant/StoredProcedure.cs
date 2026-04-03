using System;
using System.Collections.Generic;
using System.Text;

namespace d01ApiV2.Common.Constant
{
    public class StoredProcedure
    {
        public const string ModuleGetList = "[dbo].[GetModuleList]";
        public const string GetModuleGroupsAndModules = "[dbo].[GetModuleGroupsAndModules]";
        
        
        public const string GetComponents = "[dbo].[GetComponents]";

        #region Generic/Shared
        public const string GetPageComponents = "[dbo].[GetPageComponents]";
        public const string GetAdvanceSearchComponents = "[dbo].[GetAdvanceSearchComponents]";
        #endregion Generic/Shared

        #region Profile
        //public const string GETITEM = "getItemById";
        ////public const string GETBRAND = "getBrandById";
        //public const string GETBRAND = "[dbo].[GetBrand]";
        //public const string SAVEBRAND = "[dbo].[SaveBrand]";
        public const string PaginateBrand = "[dbo].[PaginateBrand]";
        //public const string PageObjectBrand = "[dbo].[PageObjectBrand]"; -- use the PageObject
        #endregion Profile
    }
}
