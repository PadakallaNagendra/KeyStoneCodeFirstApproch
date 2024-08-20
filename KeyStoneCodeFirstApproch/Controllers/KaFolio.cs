using KeyStoneCodeFirst_BusinessEntities.InterFace;
using KeyStoneCodeFirst_BusinessEntities.ModelDTO;
using KeyStoneCodeFirstApproch_ServiceLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KeyStoneCodeFirstApproch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KaFolio : ControllerBase
    {
        IKaFolioService _kaFolioService;
        public KaFolio(IKaFolioService kaFolioService)
        {
            _kaFolioService= kaFolioService;
        }
        /// <summary>
        /// Add Employee Details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddKaFolioDetails")]
        public IActionResult Post([FromBody] KaFolioDTO kaFolio)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, ModelState);
                }
                var employees = _kaFolioService.AddKaFolioDetails(kaFolio);
                return StatusCode(StatusCodes.Status201Created, " Details Added Succesfully");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "System or Server Error");
            }
        }
        [HttpPut]
        [Route("UpdateKaFolioDetails")]
        public IActionResult PUT([FromBody] KaFolioDTO kaFolio)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, ModelState);
                }
                var employees = _kaFolioService.UpdateKaFolioDetails(kaFolio);
                return StatusCode(StatusCodes.Status201Created, " Details Updated Succesfully");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "System or Server Error");
            }
        }
        /// <summary>
        /// Get All Employee Details
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        [Route("GetAllKaFolioDetails")]
        public IActionResult Get()
        {
            try
            {
                var kaFolios = _kaFolioService.GetAllKaFolioDetails();
                if (kaFolios != null)
                {
                    return StatusCode(StatusCodes.Status200OK,kaFolios);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "Bad input request");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "System or Server Error");
            }
        }
        /// <summary>
        /// Get Employee Details By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetKaFolioDetailsByID/{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Bad input request");
            }
            try
            {
                var emp = _kaFolioService.GetKaFolioDetailsByID(id);
                if (emp == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, " Id not found");
                }
                else
                {
                    return StatusCode(StatusCodes.Status200OK, emp);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "System or Server Error");
            }
        }
        /// <summary>
        /// Delete Employee Details By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteKaFolioDetails/{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Bad input request");
            }

            try
            {
                var kafolio = _kaFolioService.DeleteKaFolioDetails(id);
                if (kafolio == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, "kafolio Id not found");
                }
                else
                {
                    var employee = _kaFolioService.DeleteKaFolioDetails(id);
                    return StatusCode(StatusCodes.Status204NoContent, "kafilio details deleted successfully");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "System or Server Error");
            }
        }

    }
}
