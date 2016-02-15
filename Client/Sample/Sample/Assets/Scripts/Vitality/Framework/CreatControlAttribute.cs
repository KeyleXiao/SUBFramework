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

namespace Vitality.Framework
{
	[AttributeUsage (AttributeTargets.Field, Inherited = false, AllowMultiple = true)]
	public sealed class CreatControlAttribute : Attribute
	{
		readonly UIBuilderConstraintType model;
		readonly UIBuilderConst buildType;
		readonly IUIBuilderControlStyle style;
		readonly object[] arg;

		public UIBuilderConstraintType Model {
			get {
				return model;
			}
		}

		public UIBuilderConst BuildType {
			get {
				return buildType;
			}
		}

		public object[] Arg {
			get {
				return arg;
			}
		}

		public CreatControlAttribute (UIBuilderConstraintType model, UIBuilderConst buildType, IUIBuilderControlStyle style, params object[] arg)
		{
			this.model = model;
			this.buildType = buildType;
			this.arg = arg;
		}
	}
}

