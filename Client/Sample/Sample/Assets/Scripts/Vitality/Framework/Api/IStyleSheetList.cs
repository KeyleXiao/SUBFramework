using System;
using System.Collections.Generic;

namespace Vitality.Framework.Api
{
	public interface IStyleSheetList<T> where T:IUIBuilderControlStyle
	{
		List<T> StyleSheets{ get; set; }

		IUIBuilderControlStyle FindStyleSheetByID (int id);

		IStyleSheetList<T> RemoveStyleSheet (int id);

		IStyleSheetList<T> UpdateStyleSheet (IUIBuilderControlStyle item);

		IStyleSheetList<T> RemoveStyleSheet (IUIBuilderControlStyle item);
	}
}

