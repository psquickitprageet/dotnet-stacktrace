using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace log.loggly.com
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 10, b = 0, res = 0;
			var logger = LogManager.GetLogger(typeof(Program));
			//logger.Info("log message");
			//logger.Error("Some Exception", new Exception("your exception message"));
			try
			{
				//a = a / b;
				getException4();
			}
			catch (Exception ex)
			{
				logger.Error(ex.Message, ex);
			}
			Console.ReadKey();
		}

		static void getException4()
		{
			getException3();
		}
		static void getException3()
		{
			getException2();
		}
		static void getException2()
		{
			getException1();
		}
		static void getException1()
		{
			getException();
		}
		static void getException()
		{
			int a = 10, b = 0;
			a = a / b;
			// throw new Exception("New exception");
		}
	}
}
