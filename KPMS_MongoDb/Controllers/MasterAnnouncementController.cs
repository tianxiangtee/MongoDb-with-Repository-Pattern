﻿using System;
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

        public async Task<string> Get()
        {           
            var announcements = await _masterAnnouncementRepository.GetfromRepo();
            return JsonConvert.SerializeObject(announcements);
        }

        public async Task<string> GetById(string Id)
        {
            var announcements = await _masterAnnouncementRepository.GetfromRepoById(Id) ?? new master_announcement();
            return JsonConvert.SerializeObject(announcements);
        }
    }
}