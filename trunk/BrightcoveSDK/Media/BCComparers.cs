﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrightcoveSDK.Media;

namespace BrightcoveSDK
{
	public class BCVideoComparer : IEqualityComparer<BCVideo>
	{

		#region IEqualityComparer<BCVideo> Members

		public bool Equals(BCVideo x, BCVideo y) {
			return x.id.Equals(y.id);
		}

		public int GetHashCode(BCVideo obj) {
			return obj.GetHashCode();
		}

		#endregion
	}
	public class BCVideoComparer<CustomFieldType> : IEqualityComparer<BCVideo<CustomFieldType>>
	{

		#region IEqualityComparer<BCVideo> Members

		public bool Equals(BCVideo<CustomFieldType> x, BCVideo<CustomFieldType> y) {
			return x.id.Equals(y.id);
		}

		public int GetHashCode(BCVideo<CustomFieldType> obj) {
			return obj.GetHashCode();
		}

		#endregion
	}
}