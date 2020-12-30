using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Markup;

namespace Test_MenuItem
{
   [MarkupExtensionReturnType( typeof( string ))]
   public class PlaceholderReplacementExtension : MarkupExtension
   {
      [ConstructorArgument( "InputString" )]
      public string InputString { get; set; }

      [ConstructorArgument( "PlaceholderValue" )]
      public string PlaceholderValue { get; set; }

      [ConstructorArgument( "PlaceholderIndex" )]
      public int PlaceholderIndex { get; set; } = 0;

      public PlaceholderReplacementExtension()
      {
      }

      public override object ProvideValue( IServiceProvider serviceProvider )
      {
         return InputString.Replace( $"{{{PlaceholderIndex}}}", PlaceholderValue );
      }
   }
}
