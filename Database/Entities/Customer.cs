﻿namespace Database.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public int Phonenumber { get; set; }
        public string Email { get; set; }
    }
}