﻿using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFrameWork
{
    public class EfSocialMediaDAL : GenericRepository<SocialMedia>, ISocialMediaDAL
    {
        public EfSocialMediaDAL(SignalRContext context) : base(context)
        {
        }
    }
}
