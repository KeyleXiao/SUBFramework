//
//    Copyright 2016 KeyleXiao.
//    Project Site : http://keylexiao.github.io/SmartUIBuilderFramework
//    Contact to Me : Keyle_xiao@hotmail.com 
//
//   	Licensed under the Apache License, Version 2.0 (the "License");
//   	you may not use this file except in compliance with the License.
//   	You may obtain a copy of the License at
//
//   		http://www.apache.org/licenses/LICENSE-2.0
//
//   		Unless required by applicable law or agreed to in writing, software
//   		distributed under the License is distributed on an "AS IS" BASIS,
//   		WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   		See the License for the specific language governing permissions and
//   		limitations under the License.
//
using System;
using Vitality.Framework.Api;
using UnityEngine;

namespace Vitality.Framework.Impl
{
	public class ControlBuilderBase:IUIBuilderControl
	{
		#region IUIBuilderControl implementation

		public object CreateControl<T> () where T : MonoBehaviour
		{
			throw new NotImplementedException ();
		}

		public virtual object CreateControl (UIBuilderConstraintType model, UIBuilderConst buildType, IUIBuilderControlStyle style, params object[] arg)
		{
			if (model == UIBuilderConstraintType.DYNAMIC) {
				return DynamiCreat (buildType, style, arg);
			}	

			if (model == UIBuilderConstraintType.STATIC) {
				return StaticLoad (buildType, style, arg);
			}

			if (model == UIBuilderConstraintType.TEMPLATE) {
				return TemplateLoad (buildType, style, arg);
			}

			VitalityExpection.GetInstance ().ReportError (VitalityExpectionType.ERROR, "CreateControl has no progress logic");
			return null;
		}

		public virtual object  DynamiCreat (UIBuilderConst buildType, IUIBuilderControlStyle style, params object[] arg)
		{
			
			return null;
		}

		public virtual object StaticLoad (UIBuilderConst buildType, IUIBuilderControlStyle style, params object[] arg)
		{
			
			return null;
		}

		public virtual object TemplateLoad (UIBuilderConst buildType, IUIBuilderControlStyle style, params object[] arg)
		{
			
			return null;
		}


		#endregion
	}
}

