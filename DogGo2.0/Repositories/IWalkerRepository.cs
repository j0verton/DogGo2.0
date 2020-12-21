using DogGo2._0.Models;
using System.Collections.Generic;

namespace DogGo2._0.Repositories
{
    public interface IWalkerRepository
    {
        List<Walker> GetAllWalkers();
        Walker GetWalkerById(int id);
    }
}