using Owin;
﻿using Microsoft.Owin;
﻿
﻿[assembly: OwinStartup (typeof (KatanaSystemWebTest.Startup), "Configuration")]

namespace KatanaSystemWebTest
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.UseDiagnosticsPage();
		}
	}
}
