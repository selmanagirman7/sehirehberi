﻿using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
	public class EfAboutDal:EfGenericRepository<About>,IAboutDal
	{
	}
}




