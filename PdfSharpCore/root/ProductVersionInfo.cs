#region PDFsharp - A .NET library for processing PDF
//
// Authors:
//   Stefan Lange
//
// Copyright (c) 2005-2016 empira Software GmbH, Cologne Area (Germany)
//
// http://www.PdfSharpCore.com
// http://sourceforge.net/projects/pdfsharp
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
#endregion

using System;

namespace PdfSharpCore
{
    /// <summary>
    /// Version info base for all PDFsharp related assemblies.
    /// </summary>
    public static class ProductVersionInfo
    {
        /// <summary>
        /// The title of the product.
        /// </summary>
        public const string Title = "KlaskManager";

        /// <summary>
        /// A characteristic description of the product.
        /// </summary>
        public const string Description = "KLAVS@Ramboll.dk";

        /// <summary>
        /// The PDF producer information string.
        /// TODO: Called Creator in MigraDoc???
        /// </summary>
        public const string Producer = "";

        /// <summary>
        /// The PDF producer information string including VersionPatch.
        /// </summary>
        public const string Producer2 = "";

        /// <summary>
        /// The full version number.
        /// </summary>
        public const string Version = "";

        /// <summary>
        /// The full version string.
        /// </summary>
        public const string Version2 = "";

        /// <summary>
        /// The home page of this product.
        /// </summary>
        public const string Url = "";

        /// <summary>
        /// Unused.
        /// </summary>
        public const string Configuration = "";

        /// <summary>
        /// The company that created/owned the product.
        /// </summary>
        public const string Company = "";

        /// <summary>
        /// The name the product.
        /// </summary>
        public const string Product = "";

        /// <summary>
        /// The copyright information.
        /// </summary>
        public const string Copyright = "";

        /// <summary>
        /// The trademark the product.
        /// </summary>
        public const string Trademark = "";

        /// <summary>
        /// Unused.
        /// </summary>
        public const string Culture = "";

        /// <summary>
        /// The major version number of the product.
        /// </summary>
        public const string VersionMajor = "";

        /// <summary>
        /// The minor version number of the product.
        /// </summary>
        public const string VersionMinor = "";

        /// <summary>
        /// The build number of the product.
        /// </summary>
        public const string VersionBuild = "";  // V16G // Build = days since 2005-01-01  -  change this values ONLY HERE

        /// <summary>
        /// The patch number of the product.
        /// </summary>
        public const string VersionPatch = "";

        /// <summary>
        /// The Version Prerelease String for NuGet.
        /// </summary>
        public const string VersionPrerelease = ""; // "" for stable Release, e.g. "beta" or "rc.1.2" for Prerelease. // Also used for NuGet Version.

#if DEBUG
        /// <summary>
        /// The calculated build number.
        /// </summary>
// ReSharper disable RedundantNameQualifier
        public static int BuildNumber = (System.DateTime.Now - new System.DateTime(2005, 1, 1)).Days;
// ReSharper restore RedundantNameQualifier
#endif

        /// <summary>
        /// E.g. "2005-01-01", for use in NuGet Script.
        /// </summary>
        public const string VersionReferenceDate = "";

        /// <summary>
        /// Use _ instead of blanks and special characters. Can be complemented with a suffix in the NuGet Script.
        /// Nuspec Doc: The unique identifier for the package. This is the package name that is shown when packages
        /// are listed using the Package Manager Console. These are also used when installing a package using the
        /// Install-Package command within the Package Manager Console. Package IDs may not contain any spaces
        /// or characters that are invalid in an URL. In general, they follow the same rules as .NET namespaces do.
        /// So Foo.Bar is a valid ID, Foo! and Foo Bar are not. 
        /// </summary>
        public const string NuGetID = "";

        /// <summary>
        /// Nuspec Doc: The human-friendly title of the package displayed in the Manage NuGet Packages dialog.
        /// If none is specified, the ID is used instead. 
        /// </summary>
        public const string NuGetTitle = "";

        /// <summary>
        /// Nuspec Doc: A comma-separated list of authors of the package code.
        /// </summary>
        public const string NuGetAuthors = "";

        /// <summary>
        /// Nuspec Doc: A comma-separated list of the package creators. This is often the same list as in authors.
        /// This is ignored when uploading the package to the NuGet.org Gallery. 
        /// </summary>
        public const string NuGetOwners = "";

        /// <summary>
        /// Nuspec Doc: A long description of the package. This shows up in the right pane of the Add Package Dialog
        /// as well as in the Package Manager Console when listing packages using the Get-Package command. 
        /// </summary>
        // This assignment must be written in one line because it will be parsed from a PS1 file.
        public const string NuGetDescription = "";

        /// <summary>
        /// Nuspec Doc: A description of the changes made in each release of the package. This field only shows up
        /// when the _Updates_ tab is selected and the package is an update to a previously installed package.
        /// It is displayed where the Description would normally be displayed. 
        /// </summary>                  
        public const string NuGetReleaseNotes = "";

        /// <summary>
        /// Nuspec Doc: A short description of the package. If specified, this shows up in the middle pane of the
        /// Add Package Dialog. If not specified, a truncated version of the description is used instead.
        /// </summary>                  
        public const string NuGetSummary = "";

        /// <summary>
        /// Nuspec Doc: The locale ID for the package, such as en-us.
        /// </summary>                  
        public const string NuGetLanguage = "";

        /// <summary>
        /// Nuspec Doc: A URL for the home page of the package.
        /// </summary>
        /// <remarks>
        /// http://www.PdfSharpCore.net/NuGetPackage_PDFsharp-GDI.ashx
        /// http://www.PdfSharpCore.net/NuGetPackage_PDFsharp-WPF.ashx
        /// </remarks>
        public const string NuGetProjectUrl = "";

        /// <summary>
        /// Nuspec Doc: A URL for the image to use as the icon for the package in the Manage NuGet Packages
        /// dialog box. This should be a 32x32-pixel .png file that has a transparent background.
        /// </summary>
        public const string NuGetIconUrl = "";

        /// <summary>
        /// Nuspec Doc: A link to the license that the package is under.
        /// </summary>                  
        public const string NuGetLicenseUrl = "";

        /// <summary>
        /// Nuspec Doc: A Boolean value that specifies whether the client needs to ensure that the package license (described by licenseUrl) is accepted before the package is installed.
        /// </summary>                  
        public const bool NuGetRequireLicenseAcceptance = false;

        /// <summary>
        /// Nuspec Doc: A space-delimited list of tags and keywords that describe the package. This information is used to help make sure users can find the package using
        /// searches in the Add Package Reference dialog box or filtering in the Package Manager Console window.
        /// </summary>                  
        public const string NuGetTags = "";

        /// <summary>
        /// The technology tag of the product:
        /// (none) Pure .NET
        /// -gdi : GDI+,
        /// -wpf : WPF,
        /// -hybrid : Both GDI+ and WPF (hybrid).
        /// -sl : Silverlight
        /// -wp : Windows Phone
        /// -wrt : Windows RunTime
        /// </summary>
        public const string Technology = "";
    }
}
