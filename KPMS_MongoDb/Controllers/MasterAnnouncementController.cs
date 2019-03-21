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
    public class MasterAnnouncementController : Controller
    {
        private readonly IMasterAnnouncementRepository _masterAnnouncementRepository;
        public MasterAnnouncementController(IMasterAnnouncementRepository masterAnnouncementRepository)
        {
            _masterAnnouncementRepository = masterAnnouncementRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<string> Get()
        {
            //var announcements = await _masterAnnouncementRepository.Get();

            var announcements = await _masterAnnouncementRepository.GetfromRepo("master_announcement");
            return JsonConvert.SerializeObject(announcements);
        }

        public async Task<string> GetById(string Id)
        {
            var announcements = await _masterAnnouncementRepository.GetfromRepoById("master_announcement", Id) ?? new master_announcement();
            return JsonConvert.SerializeObject(announcements);
        }
    }
}