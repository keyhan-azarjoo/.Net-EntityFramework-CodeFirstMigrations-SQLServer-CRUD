﻿namespace EntityFramework_CodeFirstMigrations_SQLServer_CRUD.Entities
{
    public class MyEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string FirstName{ get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Place {  get; set; } = string.Empty;
    }
}
