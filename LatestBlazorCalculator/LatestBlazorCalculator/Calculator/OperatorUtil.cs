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
	
		public static string FriendlyName(this Operator @operator)
		{
			switch (@operator)
			{
				case Operator.ADD:
					return "+";
				case Operator.COS:
					return "cos";
				case Operator.DIVIDE:
					return "/";
				case Operator.LN:
					return "ln";
				case Operator.LOG:
					return "log";
				case Operator.MULTIPLY:
					return "*";
				case Operator.SIN:
					return "sin";
				case Operator.SQRT:
					return "sqrt";
				case Operator.SQUARE:
					return "square";
				case Operator.SUBTRACT:
					return "-";
				case Operator.TAN:
					return "tan";
			}

			throw new Exception("Not implemented operator");
		}
	}
}
