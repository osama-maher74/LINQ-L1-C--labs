using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	internal class InhiritList<T> : List<T>
	{
		 string logFile = "list_log.txt";
		public void add(T item)
		{
			base.Add(item);
			File.AppendAllText(logFile, $"{item}{Environment.NewLine}");
		}
		public T get(int index)
		{
			return base[index];
		}

	}
}
