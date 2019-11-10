// Copyright 2018-2019 Fabulous contributors. See LICENSE.md for license.
namespace Fabulous.Uno

open Windows.UI.Xaml.Media

[<AutoOpen>]
module InputTypes =
    /// Represents an image source
    type Image =
        /// A path to the image
        | Path of string
        /// A byte array representing the image
        | Bytes of byte[]
        /// An already defined ImageSource
        | Source of ImageSource
    
    /// Represents a dimension for either the row or column definition of a Grid    
    type Dimension =
        /// Use a size that fits the children of the row or column.
        | Auto
        /// Use a proportional size of 1
        | Star
        /// Use a proportional size defined by the associated value
        | Stars of float
        /// Use the associated value as the number of device-specific units.
        | Absolute of float
        
    /// Represents a font size
    type FontSize =
        /// Use a named size
        // UNO TODO
        // | Named of Xamarin.Forms.NamedSize
        /// Use a value as the size
        | FontSize of float

    /// Defines if the action should be animated or not
    type AnimationKind =
        | Animated
        | NotAnimated