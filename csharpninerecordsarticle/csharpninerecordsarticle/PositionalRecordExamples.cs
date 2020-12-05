/// <summary>
/// Records are basicaly immutable Classes underneath the covers. You can
/// see this in IL when you build and disassemble the .dll. A record is a
/// reference type, lives on the HEAP BUT it has methods and characteristics
/// of a VALUE which lives on the STACK. So Records are basically values that
/// are slower to extract from memory, but don't count against your STACK
/// memory and are eligible for Garbage Collection.
///
/// This is the alternative Positional syntax for declaring records.
/// Author: William Ploger
/// Email: wploger@icloud.com
/// Date: 12/1/2020
/// License: None
/// </summary>

namespace csharpninerecordsapp
{
    /// <summary>
    ///  A simple Person RECORD in C# 9.0
    ///  positional
    /// 
    /// </summary>
    public record PersonPositionalRecord(string FirstName, string LastName);

    /// <summary>
    /// A simple Teacher Record with inheritance from Person Record
    /// C# 9.0
    /// positional
    /// </summary>
    public record TeacherPositionalRecord(string FirstName, string LastName, string Subject) :
        PersonPositionalRecord(FirstName, LastName);

    /// <summary>
    /// A simple SEALED Student Record with inheritance from Person Record
    /// Just like classes, a Record can be sealed, allowing no inheritance
    /// or changes.
    /// C# 9.0
    /// positional
    /// </summary>
    public sealed record StudentPositionalRecord(string FirstName, string LastName, int Level) :
        PersonPositionalRecord(FirstName, LastName);

    /// <summary>
    /// Example class using two Person Positional Records to try out Equality.
    /// </summary>
    public class RecordPositionalEquality
    {
        public static bool CompareEquality(PersonPositionalRecord record1, PersonPositionalRecord record2)
        {
            return record1 == record2;
        }
    }
}