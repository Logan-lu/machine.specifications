using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly : AssemblyTitle("Machine.Specifications")]
[assembly : AssemblyDescription("")]
[assembly : AssemblyConfiguration("")]
[assembly : AssemblyCulture("")]

[assembly: AssemblyVersion("0.9.3.0")]
[assembly: AssemblyInformationalVersion("1.0.*")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.

[assembly : ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM

[assembly : Guid("49db994f-04d4-47ff-ade6-0dbda007ee13")]

[assembly: AllowPartiallyTrustedCallers]

#if !NET35 && !NETSTANDARD
[assembly: SecurityRules(SecurityRuleSet.Level1)]
#endif