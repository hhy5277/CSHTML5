﻿
//===============================================================================
//
//  IMPORTANT NOTICE, PLEASE READ CAREFULLY:
//
//  => This code is licensed under the GNU General Public License (GPL v3). A copy of the license is available at:
//        https://www.gnu.org/licenses/gpl.txt
//
//  => As stated in the license text linked above, "The GNU General Public License does not permit incorporating your program into proprietary programs". It also does not permit incorporating this code into non-GPL-licensed code (such as MIT-licensed code) in such a way that results in a non-GPL-licensed work (please refer to the license text for the precise terms).
//
//  => Licenses that permit proprietary use are available at:
//        http://www.cshtml5.com
//
//  => Copyright 2019 Userware/CSHTML5. This code is part of the CSHTML5 product (cshtml5.com).
//
//===============================================================================



#if MIGRATION
namespace System.Windows
#else
namespace Windows.UI.Text
#endif
{
    /// <summary>
    /// Provides a set of predefined text decorations.
    /// </summary>
    public enum TextDecorations
    {
        /// <summary>
        /// Defines a line above the text
        /// </summary>
        None = 0,

        ///// <summary>
        ///// Defines a line below the text
        ///// </summary>
        //Baseline = 1,

        /// <summary>
        /// Defines a line above the text
        /// </summary>
        OverLine = 2,

        /// <summary>
        /// Defines a line through the text
        /// </summary>
        Strikethrough = 3,

        /// <summary>
        /// Defines a line below the text
        /// </summary>
        Underline = 4
    }
}