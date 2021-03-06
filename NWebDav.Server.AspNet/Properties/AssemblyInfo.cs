﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("NWebDav.Server.AspNet")]
[assembly: AssemblyDescription("WebDAV server library (ASP.NET)")]
[assembly: AssemblyInformationalVersion("0.1.24.0 (beta)")]
#if DEBUG
[assembly: AssemblyConfiguration("DEBUG")]
#else
[assembly: AssemblyConfiguration("RELEASE")]
#endif
[assembly: AssemblyCompany("Ramon de Klein <mail@ramondeklein.nl>")]
[assembly: AssemblyProduct("NWebDav")]
[assembly: AssemblyCopyright("Copyright (C) 2016-2017 Ramon de Klein")]

// Assembly is CLS compliant and types are not visible by COM (unless set explicitly)
[assembly: CLSCompliant(true)]
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("0.1.24.0")]
[assembly: AssemblyFileVersion("0.1.24.0")]
