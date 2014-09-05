using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MonoDevelop.FSharp.Gui
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class CompilerOptionsPanelWidget : Gtk.Bin
	{
		public CompilerOptionsPanelWidget ()
		{
			this.Build ();
		}

		public Gtk.ComboBox TargetFrameworkComboBox { get { return this.targetFrameworkComboBox; } }
	}
}
