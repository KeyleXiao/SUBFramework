using System;
using Vitality.Framework.Api;

namespace Vitality.Framework.Impl
{
	public class VitalityExpection:VitalitySingleton<VitalityExpection>,IVitalityExpection
	{
		#region IVitalityExpection implementation

		public void ReportError (VitalityExpectionType t, string msg)
		{
			UnityEngine.Debug.Log (string.Format ("Level : {0}  -=-=-=-=-=-=-=-  Msg : {1}", t.ToString (), msg));
		}

		#endregion


	}
}

