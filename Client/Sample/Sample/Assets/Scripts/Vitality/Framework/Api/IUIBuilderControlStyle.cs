using System;

namespace Vitality.Framework.Api
{
	public interface IUIBuilderControlStyle
	{
		IStyleSheetResolve sr { get; set; }

		void SetStyleResolve ();

		void InitControlStyle (int styleID, string styleSheet);

		int StyleID { get; set; }

		string StyleSheet{ get; set; }
	}
}

