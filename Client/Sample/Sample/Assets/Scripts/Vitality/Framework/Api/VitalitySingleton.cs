using System;
using System.Reflection;

namespace Vitality.Framework.Api
{
	public abstract class VitalitySingleton <T> where T: new()
	{
		private static T instance;

		public static T GetInstance ()
		{
			if (instance == null) {
				instance = new T ();
			}
			return instance;
		}

		public virtual void DisposeInstance ()
		{
			instance = default(T);
			System.GC.Collect ();
		}
	}
}

