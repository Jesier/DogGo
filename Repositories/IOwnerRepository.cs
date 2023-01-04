using DogGo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        public void AddOwner(Owner owner);
        Owner GetOwnerById(int id);

        public void UpdateOwner(Owner owner);
        public void DeleteOwner(int ownerId);
    }
}
