﻿using JWTAuth_WebAPI.Models;

namespace JWTAuth_WebAPI.Repositories
{
  public class UserRepository
  {
    public static List<User> Users = new List<User>()
    {
      new User() { UserName = "admin", Password= "admin", Role="Administrator", EmailAddress = "admin@test.com", IsActive = true },
      new User() { UserName = "test", Password= "test", Role="Standard", EmailAddress = "test@test.com", IsActive = true }
    };
  }
}