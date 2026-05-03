using d01ApiV2.Common.Constant;
using d01ApiV2.Model.Component;
using d01ApiV2.Model.Grid;
using d01ApiV2.Model.Profile;
using d01ApiV2.Model.Request;
using d01ApiV2.Repository.Interface.Profile;
using d01ApiV2.Repository.Interface.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace d01ApiV2.Controllers.Profile
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        #region Private Fields
        private readonly IBrandRepository _repository;
        private readonly ISharedRepository _sharedRepository;
        #endregion Private Fields

        #region Constructors
        public BrandController(IBrandRepository repository, ISharedRepository sharedRepository)
        {
            _repository = repository;
            _sharedRepository = sharedRepository;
        }
        #endregion Constructors


        #region Test
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> PaginateTest()
        {
            RequestKeyValue request = new RequestKeyValue();

            request.Parameters.Add("CompanyId", Guid.Empty.ToString());
            request.Parameters.Add("UserId", Guid.Empty.ToString());
            request.Parameters.Add("SortBy", "Code");

            return Ok(await _repository.Paginate<ResponseDataGrid>(request));
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetDataTest()
        {
            RequestKeyValue request = new RequestKeyValue();

            request.Parameters.Add("CompanyId", "B71ECEEE-F966-4AF8-84BD-4C1074449171");
            request.Parameters.Add("UserId", Guid.Empty.ToString());
            request.Parameters.Add("DataId", "3AC985BC-09A2-45EC-B728-0C2E1692A2B4"); //Brand 2

            return Ok(await _repository.Get<DetailPageData>(request));
        }

        /*
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetPageComponentTest()
        {
            RequestKeyValue request = new RequestKeyValue();

            request.Parameters.Add("ModuleCode", ModuleCode.BRAND);
            request.Parameters.Add("CompanyId", Guid.Empty.ToString());
            request.Parameters.Add("UserId", Guid.Empty.ToString());

            return Ok(await _sharedRepository.GetPageComponents<ResponseDataComponents>(request));

        }

        //[HttpGet]
        //[Route("[action]")]
        [HttpGet("GetAdvanceSearchComponentTest")]
        public async Task<IActionResult> GetAdvanceSearchComponentTest()
        {
            RequestKeyValue request = new RequestKeyValue();

            request.Parameters.Add("ModuleCode", ModuleCode.BRAND);
            request.Parameters.Add("CompanyId", Guid.Empty.ToString());
            request.Parameters.Add("UserId", Guid.Empty.ToString());


            return Ok(await _sharedRepository.GetAdvanceSearchComponents<ResponseDataComponents>(request));
        }
        //*/

        /*
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> PaginateTest()
        {
            RequestKeyValue request = new RequestKeyValue();

            request.Parameters.Add("CompanyId", Guid.Empty.ToString());
            request.Parameters.Add("UserId", Guid.Empty.ToString());
            request.Parameters.Add("SortBy", "Code");

            return Ok(await _repository.Paginate<ResponseDataGrid>(request));
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> LazyLoadingTest()
        {
            //Lazy loading is a technique where content is loaded dynamically as the user scrolls down the page.
            //The browser only requests data when the user is about to reach the end of the current content.

            //MPD.OPEN
            //temp
            RequestKeyValue request = new RequestKeyValue();

            request.Parameters.Add("CompanyId", Guid.Empty.ToString());
            request.Parameters.Add("UserId", Guid.Empty.ToString());
            request.Parameters.Add("SortBy", "Code");

            return Ok(await _repository.Paginate<ResponseDataGrid>(request));

        }
        //*/
        #endregion Test

        #region Public Methods
        /*
        [HttpGet("AdvanceSearchComponents")]
        public async Task<IActionResult> PageComponents()
        {
            RequestKeyValue request = new RequestKeyValue();

            request.Parameters.Add("ModuleCode", ModuleCode.BRAND);
            request.Parameters.Add("CompanyId", Guid.Empty.ToString());
            request.Parameters.Add("UserId", Guid.Empty.ToString());

            return Ok(await _sharedRepository.GetPageComponents<ResponseDataComponents>(request));

        }
        //*/
        #endregion Public Methods
    }
}
