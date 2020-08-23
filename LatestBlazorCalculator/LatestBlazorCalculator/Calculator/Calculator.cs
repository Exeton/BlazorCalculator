using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LatestBlazorCalculator.Calculator
{
	public class CalculatorModel
	{

		private double? Num1;
		private double? Num2;
		private Operator? operator_;

		public CalculatorModel()
		{
			Calculation = "0";
		}


		public string Calculation
		{
			get;
			private set;
		}


		public void OnOperatorInput(Operator newOperator)
		{

			if (newOperator.SingleNumberOperator())
			{
				if (Num2 != null)
				{
					Num2 = Calculate(Num2.Value, newOperator);
				}
				else
				{
					Num1 = Calculate(Num1.Value, newOperator);
					operator_ = null;
				}
			}
			else
			{
				if (operator_ == null)
					operator_ = newOperator;
				else
				{
					Num1 = Calculate(Num1.Value, Num2.Value, operator_.Value);
					Num2 = null;
					operator_ = newOperator;
				}
			}

			UpdateCalculation();
		}

		private double Calculate(double a, Operator op)
		{
			switch (op)
			{
				case Operator.COS:
					return Math.Cos(a);
				case Operator.LN:
					return Math.Log(a);
				case Operator.LOG:
					return Math.Log10(a);
				case Operator.SIN:
					return Math.Sin(a);
				case Operator.SQRT:
					return Math.Sqrt(a);
				case Operator.SQUARE:
					return Math.Pow(a, 2);
				case Operator.TAN:
					return Math.Tan(a);
			}

			throw new Exception("Operator must be a single number operator");
		}

		private double Calculate(double a, double b, Operator op)
		{
			switch (op)
			{
				case Operator.ADD:
					return a + b;
				case Operator.DIVIDE:
					return a / b;
				case Operator.MULTIPLY:
					return a * b;
				case Operator.SUBTRACT:
					return a - b;
			}

			throw new Exception("Operator must be a two number operator");
		}

		public void OnNumberInput(int number)
		{
			if (operator_ == null)
			{
				if (Num1 == null)
					Num1 = 0d;
				Num1 = AppendNumber(Num1.Value, number);
			}
			else
			{
				if (Num2 == null)
					Num2 = 0d;
				Num2 = AppendNumber(Num2.Value, number);
			}

			UpdateCalculation();
		}

		private double AppendNumber(double num, int newDigit)
		{
			return num * 10 + newDigit;
		}


		private void UpdateCalculation()
		{
			Calculation = GetText();
		}

		private string GetText()
		{
			if (Num1 == null)
				return "0";

			if (operator_ == null)
				return Num1.ToString();

			if (Num2 == null)
				return Num1.ToString() + " " + operator_.Value.FriendlyName();

			return Num1.ToString() + " " + operator_.Value.FriendlyName() + " " + Num2.ToString();
		}
	}



}
