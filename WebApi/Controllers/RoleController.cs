﻿using Eds.Data;
using Eds.IRepository;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApi.Controllers
{
    [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
    [RoutePrefix("api/Role")]
    public class RoleController : ApiController
    {
        [Dependency]
        public IRoleRepository roleRepository { get; set; }
        //GET: api/Role
        [Route("Roles")]
        public List<Role> GetRoles()
        {
            return roleRepository.GetRoles(); ;
        }

        // GET: api/Role/5
        
        [HttpGet]
        public Role GetRoleById(int id)
        {
            return roleRepository.GetRoleById(id); 
        }

        // POST: api/Role
        public int? Post(Role role)
        {
            int? result= roleRepository.AddRole(role);
            return result;
        }

        // PUT: api/Role/5
        [Route("ModifyRole")]
        public int? Put(Role role)
        {
            int? result = roleRepository.UpdateRole(role);
            return result;
        }

        // DELETE: api/Role/5
        public int? Delete(int id)
        {
            int? result = roleRepository.DeleteRole(id);
            return result;
        }
    }
}
