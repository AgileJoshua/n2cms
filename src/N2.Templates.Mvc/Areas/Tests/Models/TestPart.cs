﻿#if DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace N2.Templates.Mvc.Areas.Tests.Models
{
	[PartDefinition("Test", SortOrder = 1001)]
	public class TestPart : TestItemBase
	{
	}
}
#endif