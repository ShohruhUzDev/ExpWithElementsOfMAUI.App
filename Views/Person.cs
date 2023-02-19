namespace ExpWithElementsOfMAUI.Views
{
   public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
