using System.Collections.Generic;

namespace Laboratory_7_2
{
	class MyMatrix
	{
		readonly List<List<int>> matrix;

		public MyMatrix(int width, int height)
		{
			matrix = new List<List<int>>();  
			for (int i = 0; i < width; i++)
			{
				matrix.Add(new List<int>()); 
				for (int j = 0; j < height; j++)
				{
					matrix[i].Add(default); 
				}
			}
		}

		public int this[int x, int y]
		{
			get {
				return matrix[x][y];
			}
			set {
				matrix[x][y] = value;
			}
		}

		public int Width
		{
			get {
				return matrix.Count;
			}
		}
		public int Height
		{
			get {
				return matrix[0].Count;
			}
		}

		public void AddOneColumn()
		{
			matrix.Add(new List<int>());
			for (int i = 0; i < Height; i++)
			{
				matrix[^1].Add(default);
			}
		}
		public void RemoveOneColumn()
		{
			matrix.RemoveAt(matrix.Count - 1);
		}
		public void RemoveOneColumnAt(int position)
		{
			matrix.RemoveAt(position);
		}
		public void AddOneRow()
		{
			for (int i = 0; i < matrix.Count; i++)
			{
				matrix[i].Add(default);
			}
		}
		public void RemoveOneRow()
		{
			for (int i = 0; i < matrix.Count; i++)
			{
				matrix[i].RemoveAt(matrix[i].Count - 1);
			}
		}
	}
}
