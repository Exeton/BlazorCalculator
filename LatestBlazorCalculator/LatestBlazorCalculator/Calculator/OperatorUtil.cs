using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LatestBlazorCalculator.Calculator
{
	public enum Operator
	{
		ADD,
		SUBTRACT,
		MULTIPLY,
		DIVIDE,
		SIN,
		COS,
		TAN,
		SQRT,
		SQUARE,
		LOG,
		LN
	}

	public static class OperatorUtil
	{
		public static bool SingleNumberOperator(this Operator @operator)
		{
			switch (@operator)
			{
				case Operator.ADD:
					return false;
				case Operator.COS:
					return true;
				case Operator.DIVIDE:
					return false;
				case Operator.LN:
					return true;
				case Operator.LOG:
					return true;
				case Operator.MULTIPLY:
					return false;
				case Operator.SIN:
					return true;
				case Operator.SQRT:
					return true;
				case Operator.SQUARE:
					return true;
				case Operator.SUBTRACT:
					return false;
				case Operator.TAN:
					return true;
			}

			throw new Exception("Not implemented operator");
		}
	}
}
