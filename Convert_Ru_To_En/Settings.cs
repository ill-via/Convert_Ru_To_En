using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convert_Ru_To_En
{
    class Settings
    {
        private static Dictionary<char, string> ABC = new Dictionary<char, string>()
        {
            { 'А', "A" }, { 'Б', "B" }, { 'В', "V" },
            { 'Г', "G" }, { 'Д', "D" }, { 'Е', "E" },
            { 'Ё', "E" }, { 'Ж', "Zh" }, { 'З', "Z" },
            { 'И', "I" }, { 'Й', "I" }, { 'К', "K" },
            { 'Л', "L" }, { 'М', "M" }, { 'Н', "N" },
            { 'О', "O" }, { 'П', "P" }, { 'Р', "R" },
            { 'С', "S" }, { 'Т', "T" }, { 'У', "U" },
            { 'Ф', "F" }, { 'Х', "Kh" }, { 'Ц', "Ts" },
            { 'Ч', "Ch" }, { 'Ш', "Sh" }, { 'Щ', "Shch" },
            { 'Ъ', "" }, { 'Ы', "Y" }, { 'Ь', "" },
            { 'Э', "E" }, { 'Ю', "Iu" }, { 'Я', "Ia" },
        };
        private static string path;
    }
}
