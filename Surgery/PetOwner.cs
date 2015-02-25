using System.Collections.Generic;

namespace Surgery
{

    internal class PetOwner
    {
        private string _ownerName;
        private Address _address;
        private List<Animal> _pets;

        public PetOwner(string ownerName, Address address, Animal pet)
        {
            _ownerName = ownerName;
            _address = address;
            _pets = new List<Animal> {pet};
        }

        public void AddPet(Animal pet)
        {
            if (_pets == null)
                _pets = new List<Animal>();

            _pets.Add(pet);
        }
    }
}
