using System.Collections.Generic;
using System.Drawing;

namespace Parsers.Portrait {
	public class Layer {
		/// <summary>
		/// The name of the Sprite file.
		/// </summary>
		public string Name;

		/// <summary>
		/// Index of the letter in the DNA/Properties string
		/// </summary>
		public int Index;
		public Type LayerType;
		public bool IsHair;
		public bool IsEye;
		public bool DontRefreshIfValid = false;

		/// <summary>
		/// The offset coordinates for this layer, from the bottom-left of the image
		/// </summary>
		public Point Offset = new Point(0, 0);

		public enum Type {
			DNA,
			Property
		}

		/// <summary>
		/// Used for storing data specific to the program.
		/// </summary>
		public Dictionary<string, object> CustomFlags = new Dictionary<string, object>();

		/// <summary>
		/// The file that the data was loaded from.
		/// </summary>
		public string Filename;

		public override string ToString() {
			return string.Format("Name: {0}, LayerType: {1}", Name, LayerType);
		}
	}
}