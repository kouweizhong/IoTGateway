﻿using System;
using System.Collections.Generic;
using System.Text;
using Waher.Script.Abstraction.Sets;
using Waher.Script.Abstraction.Elements;
using Waher.Script.Exceptions;

namespace Waher.Script.Objects.Matrices
{
	/// <summary>
	/// Pseudo-ring of Object-valued matrices.
	/// </summary>
	public sealed class ObjectMatrices : Ring
	{
		private int rows;
		private int columns;

		/// <summary>
		/// Pseudo-ring of Object-valued matrices.
		/// </summary>
		/// <param name="Rows">Number of rows.</param>
		/// <param name="Columns">Number of columns.</param>
		public ObjectMatrices(int Rows, int Columns)
		{
			this.rows = Rows;
			this.columns = Columns;
		}

		/// <summary>
		/// Number of rows.
		/// </summary>
		public int Rows
		{
			get { return this.rows; }
		}

		/// <summary>
		/// Number of columns.
		/// </summary>
		public int Columns
		{
			get { return this.columns; }
		}

		/// <summary>
		/// Returns the zero element of the group.
		/// </summary>
		public override IAbelianGroupElement Zero
		{
			get { throw new ScriptException("Zero element not defined for generic object matrices."); }
		}

		/// <summary>
		/// If the ring * operator is commutative or not.
		/// </summary>
		public override bool IsCommutative
		{
			get { return this.columns == 1 && this.rows == 1; }
		}

		/// <summary>
		/// Checks if the set contains an element.
		/// </summary>
		/// <param name="Element">Element.</param>
		/// <returns>If the element is contained in the set.</returns>
		public override bool Contains(IElement Element)
		{
			ObjectMatrix M = Element as ObjectMatrix;
			if (M == null)
				return false;

			return M.Rows == this.rows && M.Columns == this.columns;
		}

		/// <summary>
		/// Compares the element to another.
		/// </summary>
		/// <param name="obj">Other element to compare against.</param>
		/// <returns>If elements are equal.</returns>
		public override bool Equals(object obj)
		{
			ObjectMatrices S = obj as ObjectMatrices;
			return (S != null && S.rows == this.rows && S.columns == this.columns);
		}

		/// <summary>
		/// Calculates a hash code of the element.
		/// </summary>
		/// <returns>Hash code.</returns>
		public override int GetHashCode()
		{
			return this.rows.GetHashCode() ^ (this.columns.GetHashCode() << 16);
		}

	}
}
