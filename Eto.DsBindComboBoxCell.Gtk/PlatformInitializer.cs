using Eto;
using Eto.DsBindComboBoxCell;

[assembly: ExportInitializer(typeof(Eto.DsBindComboBoxCell.Gtk.PlatformInitializer))]

namespace Eto.DsBindComboBoxCell.Gtk
{
    public sealed class PlatformInitializer : IPlatformInitializer
    {
        public void Initialize(Platform platform)
        {
            platform.Add<DsBindComboBoxCell.IHandler>(() => new DsBindComboBoxCellHandler());
        }
    }
}