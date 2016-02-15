﻿using System;
using System.Collections.Generic;
using System.Text;
using Waher.Script.Model;

namespace Waher.Script.Operators.Arithmetics
{
	/// <summary>
	/// Inversion operator.
	/// </summary>
	public class Invert : UnaryOperator 
	{
		/// <summary>
		/// Inversion operator.
		/// </summary>
		/// <param name="Operand">Operand.</param>
		/// <param name="Start">Start position in script expression.</param>
		/// <param name="Length">Length of expression covered by node.</param>
		public Invert(ScriptNode Operand, int Start, int Length)
			: base(Operand, Start, Length)
		{
		}
	}
}