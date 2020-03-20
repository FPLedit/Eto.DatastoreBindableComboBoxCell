using Eto;

[assembly: ExportInitializer(typeof(Eto.DsBindComboBoxCell.Wpf.PlatformInitializer))]

namespace Eto.DsBindComboBoxCell.Wpf
{
    public sealed class PlatformInitializer : IPlatformInitializer
    {
        public void Initialize(Platform platform)
        {
            platform.Add<DsBindComboBoxCell.IHandler>(() => new DsBindComboBoxCellHandler());
        }
    }
}
