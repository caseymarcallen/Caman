using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Caman.Test
{
	public class Class1Tests
	{
		[Fact]
		public void Class1_Exists()
		{
			var c1 = new Class1();
			Assert.IsType<Class1>(c1);
		}
    }
}
