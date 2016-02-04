
namespace Vitality.Framework.Api
{
	public interface IUIBuilderControl
	{
		T CreateControl<T> (UIBuilderConstraintType model);
	}
}

