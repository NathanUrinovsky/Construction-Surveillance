using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineerClientUI
{
    public class Constants
    {
        public static class Font
        {
            public const int buttonRegularSize = 12;
            public const int buttonLargeSize = 14;
        }

        public static class DropDownList
        {
            public const string defaultText = "select address";
        }

        public static class Image
        {
            public const string uploadFilter = "JPG Files (*.jpg)| *.jpg";
            public const string saveFilter = "PNG Image(*.png)|*.png|JPG Image(*.jpg)|*.jpg|BMP Image(*.bmp)|*.bmp";
        }

        public static class Characters
        {
            public const int illegalEmpID = 0;
        }

        public static class Names
        {
            public const string baseStringInReportFilesFolderNames = "report";
        }

    }
}
