// This file is part of Core WF which is licensed under the MIT license.
// See LICENSE file in the project root for full license information.
using System;
using System.Runtime.InteropServices;
using Portable.Xaml.Markup;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("97bdccfe-43bf-4c17-991d-c797c2ef2243")]

// Define XAML namespace mappings
[assembly: XmlnsDefinition("http://schemas.microsoft.com/netfx/2009/xaml/activities", "CoreWf")]
[assembly: XmlnsDefinition("http://schemas.microsoft.com/netfx/2009/xaml/activities", "CoreWf.Statements")]
[assembly: XmlnsDefinition("http://schemas.microsoft.com/netfx/2009/xaml/activities", "CoreWf.Expressions")]
[assembly: XmlnsDefinition("http://schemas.microsoft.com/netfx/2009/xaml/activities", "CoreWf.Validation")]
[assembly: XmlnsDefinition("http://schemas.microsoft.com/netfx/2009/xaml/activities", "CoreWf.XamlIntegration")]

#if NET45

[assembly: XmlnsDefinition("http://schemas.microsoft.com/netfx/2010/xaml/activities/debugger", "CoreWf.Debugger.Symbol")]
[assembly: XmlnsPrefix("http://schemas.microsoft.com/netfx/2010/xaml/activities/debugger", "sads")]

#endif