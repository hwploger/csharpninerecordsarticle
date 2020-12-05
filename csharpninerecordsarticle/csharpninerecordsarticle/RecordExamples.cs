/// <summary>
/// Records are basicaly immutable Classes underneath the covers. You can
/// see this in IL when you build and disassemble the .dll. A record is a
/// reference type, lives on the HEAP BUT it has methods and characteristics
/// of a VALUE which lives on the STACK. So Records are basically values that
/// are slower to extract from memory, but don't count against your STACK
/// memory and are eligible for Garbage Collection.
/// csharpninerecordsapp
/// Author: William Ploger
/// Email: wploger@icloud.com
/// Date: 12/1/2020
/// License: None
/// </summary>

namespace csharpninerecordsapp
{
    /// <summary>
    ///  A simple Person RECORD in C# 9.0
    /// 
    /// </summary>
    public record PersonRecord
    {
        public string LastName { get; }
        public string FirstName { get; }

        public PersonRecord(string first, string last) => (FirstName, LastName) = (first, last);

    }

    /// <summary>
    /// A simple Teacher Record with inheritance from Person Record
    /// C# 9.0
    /// </summary>
    public record TeacherRecord : PersonRecord
    {
        public string Subject { get; }

        public TeacherRecord(string first, string last, string sub) : base(first, last) => Subject = sub;
    }

    /// <summary>
    /// A simple SEALED Student Record with inheritance from Person Record
    /// Just like classes, a Record can be sealed, allowing no inheritance
    /// or changes.
    /// C# 9.0
    /// </summary>
    public sealed record StudentRecord : PersonRecord
    {
        public int Level { get; }

        public StudentRecord(string first, string last, int level) : base(first, last) => Level = level;
    }

    /// <summary>
    /// Example class using two Person Records to try out Equality.
    /// </summary>
    public class RecordEquality
    {
        public static bool CompareEquality(PersonRecord record1, PersonRecord record2)
        {
            return record1 == record2;
        }
    }
}