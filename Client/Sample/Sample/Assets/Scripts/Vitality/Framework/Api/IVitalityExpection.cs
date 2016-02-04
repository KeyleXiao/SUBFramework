using System;

namespace Vitality.Framework.Api
{
	public interface IVitalityExpection
	{
		void ReportError (VitalityExpectionType t, string msg);
	}
}