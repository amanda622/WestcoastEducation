namespace WestcoastEducation.Models;

public class Person
{
    public required string PersonNumber {get; set;}    
    public required string FirstName {get; set;}
    public required string LastName {get; set;}
    public required string Email {get; set;}
    public string? Phone {get; set;}
    public required Address Address {get; set;}
    public override string ToString()
    {
        return $"FirstName: {FirstName} LastName: {LastName} PersonNumber: {PersonNumber} Email: {Email} Phone: {Phone} Address: {Address}";   
    }

}
