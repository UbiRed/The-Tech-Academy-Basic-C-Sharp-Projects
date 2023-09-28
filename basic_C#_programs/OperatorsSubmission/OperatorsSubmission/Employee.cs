using System;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload "==" operator to compare employees by Id
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        // Check if both objects are null or if they have the same reference
        if (ReferenceEquals(employee1, employee2))
        {
            return true;
        }

        // Check if either object is null, then they are not equal
        if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
        {
            return false;
        }

        // Compare employees by their Id
        return employee1.Id == employee2.Id;
    }

    // Overload "!=" operator to appease the "=="
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return !(employee1 == employee2);
    }
}