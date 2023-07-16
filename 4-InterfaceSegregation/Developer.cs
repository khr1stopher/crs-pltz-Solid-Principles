namespace InterfaceSegregation
{
    public class Developer : IWorkTeamActivities, IDevelopActivities
    {
        public Developer()
        {
        }

        public void Plan() 
        {
            Console.WriteLine("I'm making a plan");
        }

        public void Comunicate() 
        {
            Console.WriteLine("I'm talking to my team about my activities");
        }


        public void Develop() 
        {
            Console.WriteLine("I'm developing the functionalities required");
        }
    }
}