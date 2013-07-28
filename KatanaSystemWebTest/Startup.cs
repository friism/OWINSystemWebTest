using Owin;

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
