﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scryber {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Errors {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Errors() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Scryber.Errors", typeof(Errors).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot access the stream until its initial position has been set. Please use the Read() method before tring to access the stream..
        /// </summary>
        internal static string CannotAccessStreamWithoutRead {
            get {
                return ResourceManager.GetString("CannotAccessStreamWithoutRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object &apos;{0}&apos; could not be converted or cast to the required &apos;{1}&apos; type..
        /// </summary>
        internal static string CannotCastObjectToType {
            get {
                return ResourceManager.GetString("CannotCastObjectToType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It is an error to attempt to read past the end of the stream. Use the bool Read() return value before accessing the stream values..
        /// </summary>
        internal static string CannotReadPastTheEOF {
            get {
                return ResourceManager.GetString("CannotReadPastTheEOF", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The color component value for a pdf color (Red, Green, Blue, etc) must be a floating point number between 0 and 1. The value &apos;{0}&apos; is outside this range..
        /// </summary>
        internal static string ColorComponentMustBeBetweenZeroAndOne {
            get {
                return ResourceManager.GetString("ColorComponentMustBeBetweenZeroAndOne", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The color space &apos;{0}&apos; is not supported. The PDFX graphics system currently only supports RGB and Gray color spaces, other values of the enumeration are there for future use..
        /// </summary>
        internal static string ColorValueIsNotCurrentlySupported {
            get {
                return ResourceManager.GetString("ColorValueIsNotCurrentlySupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The PDF Graphics engine could not build a valid set of bezier curves describing the required arc. See inner exception for more details..
        /// </summary>
        internal static string CouldNotBuildPathFromArc {
            get {
                return ResourceManager.GetString("CouldNotBuildPathFromArc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The PDF Graphics engine could not build a valid set of bezier curves describing the required quadratic curve. See inner exception for more details..
        /// </summary>
        internal static string CouldNotBuildPathFromQuadratic {
            get {
                return ResourceManager.GetString("CouldNotBuildPathFromQuadratic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object of type &apos;{1}&apos; could not be cast to a &apos;{0}&apos;.
        /// </summary>
        internal static string CouldNotCastObjectToType {
            get {
                return ResourceManager.GetString("CouldNotCastObjectToType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not fill the graphics context with the specific text due to the error : {0}.
        /// </summary>
        internal static string CouldNotFillText {
            get {
                return ResourceManager.GetString("CouldNotFillText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The initialization of the fonts failed. {0}.
        /// </summary>
        internal static string CouldNotInitializeTheFonts {
            get {
                return ResourceManager.GetString("CouldNotInitializeTheFonts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configured imaging factory type &apos;{0}&apos; could not be loaded..
        /// </summary>
        internal static string CouldNotLoadImagingFactory {
            get {
                return ResourceManager.GetString("CouldNotLoadImagingFactory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified font file at path &apos;{0}&apos; could not be loaded. {1}.
        /// </summary>
        internal static string CouldNotLoadTheFontFile {
            get {
                return ResourceManager.GetString("CouldNotLoadTheFontFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The font resource with name &apos;{0}&apos; could not be loaded from the resource manager &apos;{1}&apos;.
        /// </summary>
        internal static string CouldNotLoadTheFontResource {
            get {
                return ResourceManager.GetString("CouldNotLoadTheFontResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The resource manager could not be loaded for the name &apos;{0}&apos;. The name must be in the format &apos;basename [,assemblyname]&apos; where assembly name is optional and if it is not provided the currently executing assembly will be used.
        /// </summary>
        internal static string CouldNotLoadTheResourceManagerForBase {
            get {
                return ResourceManager.GetString("CouldNotLoadTheResourceManagerForBase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The image parser could not parse the image at path &apos;{0}&apos;. {1}.
        /// </summary>
        internal static string CouldNotParseTheImageAtPath {
            get {
                return ResourceManager.GetString("CouldNotParseTheImageAtPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path data &apos;{0}&apos; could not be parsed into a graphics path. Expected an instruction character at index &apos;{1}&apos;, but found &apos;{2}&apos;..
        /// </summary>
        internal static string CouldNotParseThePathExpectedInstruction {
            get {
                return ResourceManager.GetString("CouldNotParseThePathExpectedInstruction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path data &apos;{0}&apos; could not be parsed into a graphics path. The instruction &apos;{2}&apos; at index {1} was not a known or supported instruction..
        /// </summary>
        internal static string CouldNotParseThePathInstructionNotRecognised {
            get {
                return ResourceManager.GetString("CouldNotParseThePathInstructionNotRecognised", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; could not be parsed into a {1} instance. A value in the format &apos;{2}&apos; was expected..
        /// </summary>
        internal static string CouldNotParseValue_3 {
            get {
                return ResourceManager.GetString("CouldNotParseValue_3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no font file associated with the font definition &apos;{0}&apos;.
        /// </summary>
        internal static string FontDefinitionDoesNotHaveFile {
            get {
                return ResourceManager.GetString("FontDefinitionDoesNotHaveFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A configuration must have either a &apos;font-file&apos; or &apos;rsrc-name&apos; attribute declared so that the font definiton can be found. The font &apos;{0}&apos; has neither..
        /// </summary>
        internal static string FontMappingMustHaveFilePathOrResourceName {
            get {
                return ResourceManager.GetString("FontMappingMustHaveFilePathOrResourceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The font &apos;{0}&apos; could not be found. Please check the name and style..
        /// </summary>
        internal static string FontNotFound {
            get {
                return ResourceManager.GetString("FontNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The font &apos;{0}&apos; could not be found. Please check the name and style. The use of system font files is currently blocked by the configuration settings..
        /// </summary>
        internal static string FontNotFoundOrEnableSystem {
            get {
                return ResourceManager.GetString("FontNotFoundOrEnableSystem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The PDFGraphics class only supports the TopDown DrawingOrigin.
        /// </summary>
        internal static string GraphicsOnlySupportsTopDownDrawing {
            get {
                return ResourceManager.GetString("GraphicsOnlySupportsTopDownDrawing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are no lines in this paragraph.
        /// </summary>
        internal static string NoLinesInParagraph {
            get {
                return ResourceManager.GetString("NoLinesInParagraph", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are no paragraphs in this block.
        /// </summary>
        internal static string NoParagraphsInBlock {
            get {
                return ResourceManager.GetString("NoParagraphsInBlock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The system font, or font family cound not be found for the PDFFont &apos;{0}&apos;. Please check the name and any required font mappings in the config file..
        /// </summary>
        internal static string NullSystemFont {
            get {
                return ResourceManager.GetString("NullSystemFont", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The layout of the text block could not be created. See inner exception for more details..
        /// </summary>
        internal static string TextLayoutFailed {
            get {
                return ResourceManager.GetString("TextLayoutFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The text style stack has become unbalanced and style end markers cannot be removed from an empty stack..
        /// </summary>
        internal static string UnbalancedTextStyle {
            get {
                return ResourceManager.GetString("UnbalancedTextStyle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The units &apos;{0}&apos; is not a known unit of measurement. Expected values are mm, inch and point (mm,&quot;,pt)..
        /// </summary>
        internal static string UnknownPageUnits {
            get {
                return ResourceManager.GetString("UnknownPageUnits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WriteTo method is only supported on Memory Streams.
        /// </summary>
        internal static string WriteToOnlySupportedForMemoryStreams {
            get {
                return ResourceManager.GetString("WriteToOnlySupportedForMemoryStreams", resourceCulture);
            }
        }
    }
}
