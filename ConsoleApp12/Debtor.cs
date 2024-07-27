using System;
using System.Buffers;
using System.Collections.Generic;

public class Debtor
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public int Debt { get; set; }

    public Debtor(string name, DateTime dob, string phone, string email, string address, int debt)
    {
        Name = name;
        DateOfBirth = dob;
        PhoneNumber = phone;
        Email = email;
        Address = address;
        Debt = debt;
    }



}