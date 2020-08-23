using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LatestBlazorCalculator.Calculator
{
	public class Calculator
	{

		private double? Num1;
		private double? Num2;
		private Operator? operator_;

		public string Calculation
		{
			get;
			private set;
		}

		public string Value
		{
			get;
			private set;
		}


		public void OnOperatorInput(Operator newOperator)
		{

			if (newOperator.SingleNumberOperator())
			{

			}


			/*
			if (operator_ == null)
				operator_ = newOperator;
			else
				Num1
			*/
		}

		private int Calculate(int a, int b, Operator op)
		{
			return 0;
		}


		public void OnNumberInput(int number)
		{
			if (operator_ == null)
				Num1 = AppendNumber(Num1.Value, number);
			else
				Num2 = AppendNumber(Num2.Value, number);
		}

		private double AppendNumber(double num, int newDigit)
		{
			return num * 10 + newDigit;
		}

		private string GetText()
		{
			if (Num1 == null)
				return "0";

			if (operator_ == null)
				return Num1.ToString();

			if (Num2 == null)
				return Num1.ToString() + " " + operator_.ToString();

			return Num1.ToString() + " " + operator_.ToString() + " " + Num2.ToString();

		}

	}



}
