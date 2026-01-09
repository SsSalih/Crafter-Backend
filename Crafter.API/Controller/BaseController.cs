using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Crafter.Application.DTOS.ResponseDtos;
using Crafter.API.Dto.Response;

namespace Crafter.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected IActionResult CreateResponse<T>(ResponseDto<T> response) where T : class
        {
            if (response.Success)
            {
                return Ok(response);
            }
            return response.ErrorCode switch
            {
                ErrorCodes.NotFound => NotFound(response),
                ErrorCodes.ValidationError => BadRequest(response),
                ErrorCodes.Unauthorized => Unauthorized(response),
                ErrorCodes.Forbidden => StatusCode(StatusCodes.Status403Forbidden, response),
                ErrorCodes.Exception => StatusCode(StatusCodes.Status500InternalServerError, response),
                ErrorCodes.DuplicateEror => Conflict(response),
                ErrorCodes.BadRequest => BadRequest(response),
                _ => BadRequest(response)
            };
        }
    } 
}
    
       
