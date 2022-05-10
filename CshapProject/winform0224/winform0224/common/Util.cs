using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform0224.common
{
    internal class Util
    {
        public static void initTheme(MaterialForm form)
        {
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(form);
            skin.Theme = MaterialSkinManager.Themes.LIGHT;
            skin.ColorScheme = new ColorScheme(
                Primary.Indigo800,
                Primary.Indigo800,
                Primary.LightBlue500,
                Accent.LightBlue200,
                TextShade.WHITE);
        }
    }
}
