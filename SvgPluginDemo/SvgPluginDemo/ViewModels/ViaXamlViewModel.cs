using System.Reflection;

namespace SvgPluginDemo.ViewModels
{
  public class ViaXamlViewModel
  {
    public Assembly SvgAssembly
    {
      get { return typeof (App).GetTypeInfo().Assembly; }
    }

    public string CoolMaskSvgPath
    {
      get { return "SvgPluginDemo.Images.CoolMask.svg"; }
    }

    public string ElvisSvgPath
    {
      get { return "SvgPluginDemo.Images.Elvis.svg"; }
    }

    public string TigerSvgPath
    {
      get { return "SvgPluginDemo.Images.tiger.svg"; }
    }

		public string ErulisseuiinSpaceshipPackPath
		{
			get { return "SvgPluginDemo.Images.ErulisseuiinSpaceshipPack.svg"; }
		}

  }
}
