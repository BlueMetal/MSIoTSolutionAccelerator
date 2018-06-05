﻿using Microsoft.Azure.ActiveDirectory.GraphClient;
using MS.IoT.Common;
using MS.IoT.DeviceManagementPortal.Web.Helpers;
using MS.IoT.Domain.Interface;
using MS.IoT.Domain.Model;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace MS.IoT.DeviceManagementPortal.Web.Controllers.Api
{
    /// <summary>
    /// User Controller API
    /// </summary>
    [Authorize]
    [RoutePrefix("api/user")]
    public class UserApiController : BaseApiController
    {
        /// <summary>
        /// Main Constructor
        /// </summary>
        /// <param name="userProfile">User Profile Service</param>
        public UserApiController(IUserProfileService userProfile)
             : base(userProfile)
        {
        }

        /// <summary>
        /// Endpoint to retrieve an object of the current user
        /// </summary>
        /// <returns>User Object</returns>
        [Route("current")]
        [ResponseType(typeof(IUser))]
        [HttpGet]
        public async Task<IHttpActionResult> GetCurrentUser()
        {
            //Domain.Model.User currentUser = await EnsureCurrentUser();

            //if (currentUser == null)
            //{
            //    Log.Error("API GetCurrentUser error: User not found.");
            //    return StatusCode(HttpStatusCode.InternalServerError);
            //}
            //return Ok(currentUser);
            return Ok(true);
        }
    }
}