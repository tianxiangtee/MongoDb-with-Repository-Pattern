using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MYDC.CodeBase.DataAccess.EntityModel;
using MYDC.CodeBase.DataAccess.Interfaces;
using Newtonsoft.Json;

namespace KPMS_MongoDb.Controllers
{
    public class MasterKeyController : Controller
    {
        private readonly IMasterKeyRepository _masterKeyRepository;

        public MasterKeyController(IMasterKeyRepository masterKeyRepository)
        {
            _masterKeyRepository = masterKeyRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<string> Get()
        {
            var keyword = await _masterKeyRepository.Get();
            return JsonConvert.SerializeObject(keyword);
        }

        //public async Task<IActionResult> List()
        //{
        //    var keywords = await _masterKeyRepository.Get();
        //    var keywordVM = new List<MasterKeyWordViewModel>();

        //    if (keywords.Count() == 0)
        //    {
        //        return View("Empty");
        //    }
        //    //Do for good practice only.
        //    foreach (var keyword in keywords)
        //    {
        //        keywordVM.Add(new MasterKeyWordViewModel
        //        {
        //            Keyword = keyword
        //        });
        //    }

        //    return View(keywordVM);
        //}

        public async Task<string> GetById(string Id)
        {
            var keyword = await _masterKeyRepository.GetById(Id) ?? new master_keyword();
            return JsonConvert.SerializeObject(keyword);
        }
    }
}