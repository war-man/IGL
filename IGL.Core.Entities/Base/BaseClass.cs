﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IGL.Core.Entities.Base
{
    public abstract class BaseClass<T>
    {
		public T Id { get; set; }
		public int IsActive { get; set; } = 1;
		public int IsDeleted { get; set; } = 0;
		public int CreatedBy { get; set; } = 1;
		public DateTime CreatedDate { get; set; } = DateTime.Now.Date;
		public int? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
	}
}
