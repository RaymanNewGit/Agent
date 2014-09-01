using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgentClient.Common {
	/// <summary>
	/// 委托模块要求提交委托指令的事件参数
	/// </summary>
	public class SubmitEventArgs : EventArgs {
		/// <summary>
		/// 委托模块的全局标识符
		/// </summary>
		public string Guid { get; private set; }
		/// <summary>
		/// 委托指令的设置数据
		/// </summary>
		public IDictionary<string, string> Data { get; private set; }
		/// <summary>
		/// 指示委托指令的提交操作是否成功
		/// </summary>
		public bool IsSuccessful { get; set; }
		/// <summary>
		/// 委托指令提交失败时的错误信息
		/// </summary>
		public string ErrorMessage { get; set; }
		public SubmitEventArgs(string guid) {
			this.Guid = guid;
			this.Data = new Dictionary<string, string>();
		}
	}

	/// <summary>
	/// 定义各种交易种类委托模块的接口规范
	/// </summary>
	public interface IAgent {
		/// <summary>
		/// 模块的全局标识符
		/// </summary>
		string Guid { get; set; }
		/// <summary>
		/// 显示委托指令设置界面
		/// </summary>
		void ShowUI();
		/// <summary>
		/// 在委托模块需要主程序发送委托指令时发生
		/// </summary>
		event EventHandler<SubmitEventArgs> Submit;

	}


}
