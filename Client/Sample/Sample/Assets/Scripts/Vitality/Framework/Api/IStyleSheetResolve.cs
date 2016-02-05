using System;

namespace Vitality.Framework.Api
{
	public interface IStyleSheetResolve
	{
		T GetStyleSheet<T> (string style);

		object GetStyleSheet (Type t, string style);
	}
}

