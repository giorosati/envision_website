﻿using Envision.Adapters.Adapters;
using Envision.Adapters.Interfaces;
using Envision.data;
using Envision.Data.Model;
using Envision.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Envision.Controllers
{
    public class apiUserDetailsController : ApiController
    {
        private IUserDetailsAdapter _adapter;

        public apiUserDetailsController()
        {
            _adapter = new UserDetailsAdapter();
        }

        public apiUserDetailsController(IUserDetailsAdapter a)
        {
            _adapter = a;
        }

        public IHttpActionResult Get()
        {
            List<ApplicationUserVM> users = _adapter.GetUsers();
            return Ok(users);
        }
    }
}