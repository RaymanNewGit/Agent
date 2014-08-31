using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.ExceptionHandling {
	public interface IExceptionHandler {
		void Handle(Exception ex);
	}
	public abstract class ExceptionHandlerBase : IExceptionHandler {

		public void Handle(Exception ex) {
			try {
				if(!HandleException(ex)){
					throw ex;
				}
			} catch {
				throw ex;
			}
		}

		protected abstract bool HandleException(Exception ex);
	}
}
