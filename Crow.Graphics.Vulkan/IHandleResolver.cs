using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IHandleResolver
{
	void LoadHandle<T>(IntPtr functionName, out T result) where T : class;
}
