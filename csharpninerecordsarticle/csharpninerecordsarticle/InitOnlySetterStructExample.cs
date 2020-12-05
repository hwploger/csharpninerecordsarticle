using System;

/// <summary>
/// Init only setters offer the ability to create an immutable struct (or class
/// for that matter). You can set these for ALL or SOME of your properties
/// This feature partially allows for the Records feature. The way this works
/// is that the only time that the setters will work is during the object
/// construction phase, afterwhich, the values of the properties will no
/// longer be settable.
/// csharpninerecordsapp
/// Author: William Ploger
/// Email: wploger@icloud.com
/// Date: 12/1/2020
/// License: None
/// </summary>
namespace csharpninerecordsapp
{
    public struct PersonInitOnlyStruct
    {
        public string LastName { get; init; }
        public string FirstName { get; init; }

        public override string ToString() =>
            $"Hello, {FirstName} {LastName}";
    }


}