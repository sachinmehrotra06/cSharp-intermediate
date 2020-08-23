namespace CMS.UI.Models
{
    public class Person
    {
        public string FirstName {get; set; }

        public string LastName { get; set; }

        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}