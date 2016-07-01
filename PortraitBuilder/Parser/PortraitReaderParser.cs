/*
 * WARNING: this file has been generated by
 * Hime Parser Generator 2.0.4.0
 */
using System.Collections.Generic;
using Hime.Redist;
using Hime.Redist.Parsers;

namespace PortraitBuilder.Parser
{
	/// <summary>
	/// Represents a parser
	/// </summary>
	internal class PortraitReaderParser : LRkParser
	{
		/// <summary>
		/// The automaton for this parser
		/// </summary>
		private static readonly LRkAutomaton commonAutomaton = LRkAutomaton.Find(typeof(PortraitReaderParser), "PortraitReaderParser.bin");
		/// <summary>
		/// Contains the constant IDs for the variables and virtuals in this parser
		/// </summary>
		public class ID
		{
			/// <summary>
			/// The unique identifier for variable idOption
			/// </summary>
			public const int idOption = 0x0012;
			/// <summary>
			/// The unique identifier for variable boolOption
			/// </summary>
			public const int boolOption = 0x0013;
			/// <summary>
			/// The unique identifier for variable stringOption
			/// </summary>
			public const int stringOption = 0x0014;
			/// <summary>
			/// The unique identifier for variable numberOption
			/// </summary>
			public const int numberOption = 0x0015;
			/// <summary>
			/// The unique identifier for variable groupOption
			/// </summary>
			public const int groupOption = 0x0016;
			/// <summary>
			/// The unique identifier for variable colourGroup
			/// </summary>
			public const int colourGroup = 0x0017;
			/// <summary>
			/// The unique identifier for variable layerGroup
			/// </summary>
			public const int layerGroup = 0x0018;
			/// <summary>
			/// The unique identifier for variable cultureGroup
			/// </summary>
			public const int cultureGroup = 0x0019;
			/// <summary>
			/// The unique identifier for variable Option
			/// </summary>
			public const int Option = 0x001A;
			/// <summary>
			/// The unique identifier for variable Sprite
			/// </summary>
			public const int Sprite = 0x001B;
			/// <summary>
			/// The unique identifier for variable Start
			/// </summary>
			public const int Start = 0x001C;
			/// <summary>
			/// The unique identifier for variable __axiom
			/// </summary>
			public const int __axiom = 0x0022;
		}
		/// <summary>
		/// The collection of variables matched by this parser
		/// </summary>
		/// <remarks>
		/// The variables are in an order consistent with the automaton,
		/// so that variable indices in the automaton can be used to retrieve the variables in this table
		/// </remarks>
		private static readonly Symbol[] variables = {
			new Symbol(0x0012, "idOption"), 
			new Symbol(0x0013, "boolOption"), 
			new Symbol(0x0014, "stringOption"), 
			new Symbol(0x0015, "numberOption"), 
			new Symbol(0x0016, "groupOption"), 
			new Symbol(0x0017, "colourGroup"), 
			new Symbol(0x0018, "layerGroup"), 
			new Symbol(0x0019, "cultureGroup"), 
			new Symbol(0x001A, "Option"), 
			new Symbol(0x001B, "Sprite"), 
			new Symbol(0x001C, "Start"), 
			new Symbol(0x001D, "__V29"), 
			new Symbol(0x001E, "__V30"), 
			new Symbol(0x001F, "__V31"), 
			new Symbol(0x0020, "__V32"), 
			new Symbol(0x0021, "__V33"), 
			new Symbol(0x0022, "__axiom") };
		/// <summary>
		/// The collection of virtuals matched by this parser
		/// </summary>
		/// <remarks>
		/// The virtuals are in an order consistent with the automaton,
		/// so that virtual indices in the automaton can be used to retrieve the virtuals in this table
		/// </remarks>
		private static readonly Symbol[] virtuals = {
 };
		/// <summary>
		/// Initializes a new instance of the parser
		/// </summary>
		/// <param name="lexer">The input lexer</param>
		public PortraitReaderParser(PortraitReaderLexer lexer) : base (commonAutomaton, variables, virtuals, null, lexer) { }
	}
}
