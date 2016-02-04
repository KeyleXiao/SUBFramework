using System;

namespace Vitality.Framework.Api
{
	public interface IUIBuilderProvider
	{
		T CreateControl<T> (UIBuilderConst t, params object[] o);
	}
}