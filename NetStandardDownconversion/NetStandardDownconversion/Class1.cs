using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace NetStandardDownconversion
{
	public class Class1
	{
		public void DoWork()
		{
			var services = new ServiceCollection();
			var provider = services.BuildServiceProvider();
		}
	}
}
