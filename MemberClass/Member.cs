using System;

namespace MemberClass
{
    public class Member
    {
        string _firstName;
        string _lastName;
        int _age;
        string _relation;

        public Member(string FirstName, string LastName, int Age, string Relation)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
            this._age = Age;
            this._relation = Relation;
        }

        public void PrintMember()
        {
            Console.WriteLine("Family Member is {0}. Name of {0} is {1} {2}", this._relation, this._firstName, this._lastName);
        }
    }
}
