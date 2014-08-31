using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Diagnostics;

namespace Framework.ExceptionHandling {
	public class ExceptionManager {
		public static void Handle(Exception ex, MethodBase method) {
			throw new NotImplementedException();
		}
		public static void Handle(Exception ex) {
			Handle(ex, (new StackTrace()).GetFrame(1).GetMethod());
		}
	}
}
