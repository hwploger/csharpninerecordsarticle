using System;

/// Author: William Ploger
/// Email: wploger@icloud.com
/// Date: 12/1/2020
/// License: None
namespace csharpninerecordsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPersonRecord = new PersonRecord("William", "Ploger");
            Console.WriteLine("Hello {0}!", myPersonRecord.FirstName);

            var myPersonRecordCompare1 = new PersonRecord("Joe", "Schmoe");
            var MyPersonRecordCompare2 = new PersonRecord("Jack B", "Nimble");
            var myPersonRecordCompare3 = new PersonRecord("Joe", "Schmoe");

            //The output of this line should be falsed based on the Record Values above.
            //"Person { LastName = Schmoe, FirstName = Joe }"
            //"Person { LastName = Nimble, FirstName = Jack B }"
            //The comparison is between two different string outputs based on the values.
            Console.WriteLine(RecordEquality.CompareEquality(myPersonRecordCompare1, MyPersonRecordCompare2));
            //The output of this line should be true based on the Record Values above
            //"Person { LastName = Schmoe, FirstName = Joe }"
            //"Person { LastName = Schmoe, FirstName = Joe }"
            //The comparison is between two different string outputs based on the values.
            Console.WriteLine(RecordEquality.CompareEquality(myPersonRecordCompare1, myPersonRecordCompare3));
        }
    }
}
