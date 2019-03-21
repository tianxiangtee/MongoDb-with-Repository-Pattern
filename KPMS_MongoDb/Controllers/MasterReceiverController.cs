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
    public class MasterReceiverController : Controller
    {
        private readonly IMasterReceiverRepository _masterReceiverRepository;

        public MasterReceiverController(IMasterReceiverRepository masterReceiverRepository)
        {
            _masterReceiverRepository = masterReceiverRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<string> Get()
        {
            var keyword = await _masterReceiverRepository.Get();
            return JsonConvert.SerializeObject(keyword);
        }

        public async Task<string> GetById(string Id)
        {
            var keyword = await _masterReceiverRepository.GetById(Id) ?? new master_receiver();
            return JsonConvert.SerializeObject(keyword);
        }
    }
}