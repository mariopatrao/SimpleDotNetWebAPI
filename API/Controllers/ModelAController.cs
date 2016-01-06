using API.Models;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace API.Controllers
{
    public class ModelAController : ApiController
    {

        // I only use the Post method because this allow me with the use of [FromBody] to use a list of variables instead of the URI string,
        // this values are passed by the .net Model in this case ModelA.
        // Using the GET method we could only pass a string as an argument and in addition we would more likely needed to use [FromURI] 

        // POST api
        public HttpResponseMessage Post([FromBody] ModelA Values)
        {
            try
            {

                string Command = Values.Command;
                string varA = Values.varA;
                string varB = Values.varB;


                // Insert Logic here related to the command passed
                // EX:  GET DB VALUES
                //      GetSomething()
                // 
                //      INSERT INTO db,
                //      Insert(varA)
                //
                //      DELETE FROM DB
                //      Delete(varB)


                // Using the Request.CreateResponse allows to pass more arguments ex: Json with a list of users. 
                return Request.CreateResponse(HttpStatusCode.OK, "You might want to pass more data like a json");

                //return new HttpResponseMessage(HttpStatusCode.OK);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

    }
}