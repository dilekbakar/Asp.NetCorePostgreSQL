using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PostegreSQL.API.Request;
using PostegreSQL.Data;
using PostegreSQL.Data.Entities;

//Normalde direk controllerla contexte erişmek çok tercih edilen bir durum değil fakat burada bunu kullanacağız.
namespace PostegreSQL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {

        private readonly PostgreSQLDBContext _postgreSQLDBContext;

        public ArticleController(PostgreSQLDBContext postgreSQLDBContext)
        {
            //alt + enter yaptığımızda generate constructor otomatik olarak yukarda yazmış olduğumuz postgreSQLDbcontexti tanıyarak contructorın içini dolduracak.
            _postgreSQLDBContext = postgreSQLDBContext;
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody]ArticleRequestModel request)
        {
            var model = new Article
            {//datetime ve aktifliği override etmemize gerek yok. BaseEntityde ataması yapılmıştı.
                Title = request.Title,
                Description = request.Description

            };
            _postgreSQLDBContext.Add(model);
            _postgreSQLDBContext.SaveChanges(); //veritabanına değişiklikleri otomatik kaydedecek.
            return Ok("Başarılı");
        }
    }
}
