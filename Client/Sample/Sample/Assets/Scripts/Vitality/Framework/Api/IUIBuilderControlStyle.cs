using System;

namespace Vitality.Framework.Api
{
	public interface IUIBuilderControlStyle
	{
		int StyleID { get; set; }

		string StyleSheet{ get; set; }

		void StyleResolve<T> ();
	}
}

