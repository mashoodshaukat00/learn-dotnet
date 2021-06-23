namespace OopConcepts.ConsoleApp
{
    public class Human : IHuman
    {
        public Human()
        {
        }
        public Human(int id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }

        /// <summary>
        /// Id
        /// This field shows Id of the object of type Human
        /// </summary>
        public int Id { get; set; }
        public string FullName { get; set; }
    }

}
