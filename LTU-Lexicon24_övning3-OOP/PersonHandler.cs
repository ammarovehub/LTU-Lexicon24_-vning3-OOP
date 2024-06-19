namespace Encapsulation
{
    public class PersonHandler
    {
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            return new Person(age, fname, lname, height, weight);
        }
        public void SetAge(Person pers, int age) 
        {
            pers.Age = age;
        }

        public void SetHeight(Person pers, int height) 
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, int weight)
        {
            pers.Weight = weight;
        }
    }
}
