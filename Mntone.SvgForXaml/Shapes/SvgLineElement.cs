﻿using Mntone.SvgForXaml.Internal;
using Mntone.SvgForXaml.Primitives;
using System.Xml;

namespace Mntone.SvgForXaml.Shapes
{
	[System.Diagnostics.DebuggerDisplay("Line: 1 = ({this.X1}, {this.Y1}), 2 = ({this.X2}, {this.Y2})")]
	public sealed class SvgLineElement : SvgElement, ISvgStylable
	{
		internal SvgLineElement(INode parent, XmlElement element)
			: base(parent, element)
		{
			this._stylableHelper = new SvgStylableHelper(element);

			this.X1 = element.ParseCoordinate("x1", 0.0F);
			this.Y1 = element.ParseCoordinate("y1", 0.0F);
			this.X2 = element.ParseCoordinate("x2", 0.0F);
			this.Y2 = element.ParseCoordinate("y2", 0.0F);
		}

		public override string TagName => "line";
		public SvgLength X1 { get; }
		public SvgLength Y1 { get; }
		public SvgLength X2 { get; }
		public SvgLength Y2 { get; }

		#region ISvgStylable
		[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
		private readonly SvgStylableHelper _stylableHelper;
		public string ClassName => this._stylableHelper.ClassName;
		public CssStyleDeclaration Style => this._stylableHelper.Style;
		public ICssValue GetPresentationAttribute(string name) => this._stylableHelper.GetPresentationAttribute(name);
		#endregion
	}
}