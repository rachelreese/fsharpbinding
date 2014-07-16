using System;
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

