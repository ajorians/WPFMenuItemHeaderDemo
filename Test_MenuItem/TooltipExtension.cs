using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Test_MenuItem
{
   [MarkupExtensionReturnType( typeof( string ))]
   public class TooltipExtension : MarkupExtension
   {
      [ConstructorArgument("MainString")]
      public string MainString { get; set; }

      [ConstructorArgument( "ShortCutID" )]
      public string ShortCutID { get; set; }

      private string _result;
      public TooltipExtension()
      {
      }

      public TooltipExtension( string mainString, string d)
      {
         MainString = mainString;
         ShortCutID = d;
      }

      public override object ProvideValue( IServiceProvider serviceProvider )
      {
         _result = string.Format( MainString, ShortCutID );

         return _result;
      }
   }
}
