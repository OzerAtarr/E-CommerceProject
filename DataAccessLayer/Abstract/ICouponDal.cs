﻿using Core.DataAccess.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICouponDal : IGenericDal<Coupon>
    {
        public string CheckCoupon(string couponCode);
    }
}
